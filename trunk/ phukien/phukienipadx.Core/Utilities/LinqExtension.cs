using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Caching;

public static class LinqExtension
{
    /// <summary>
    /// Sort
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    /// <param name="source"></param>
    /// <param name="sortExpression"></param>
    /// <returns></returns>
    public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string sortExpression) where TEntity : class
    {
        if (string.IsNullOrEmpty(sortExpression))
            return source; // nothing to sort on  

        var entityType = typeof(TEntity);
        string ascSortMethodName = "OrderBy";
        string descSortMethodName = "OrderByDescending";
        string[] sortExpressionParts = sortExpression.Split(' ');
        string sortProperty = sortExpressionParts[0];
        string sortMethod = ascSortMethodName;

        if (sortExpressionParts.Length > 1 && sortExpressionParts[1] == "DESC")
            sortMethod = descSortMethodName;

        var property = entityType.GetProperty(sortProperty);
        var parameter = Expression.Parameter(entityType, "p");
        var propertyAccess = Expression.MakeMemberAccess(parameter, property);
        var orderByExp = Expression.Lambda(propertyAccess, parameter);

        MethodCallExpression resultExp = Expression.Call(
                                            typeof(Queryable),
                                            sortMethod,
                                            new Type[] { entityType, property.PropertyType },
                                            source.Expression,
                                            Expression.Quote(orderByExp)
                                            );

        return source.Provider.CreateQuery<TEntity>(resultExp);
    }
    /// <summary>
    /// Paging
    /// </summary>
    /// <typeparam name="TSource"></typeparam>
    /// <param name="source"></param>
    /// <param name="page"></param>
    /// <param name="pageSize"></param>
    /// <returns></returns>
    public static IQueryable<TSource> PageIQuery<TSource>(this IQueryable<TSource> source, int page, int pageSize)
    {
        return source.Skip((page - 1) * pageSize).Take(pageSize).Cast<TSource>();
    }
    public static List<TSource> Page<TSource>(this List<TSource> source, int page, int pageSize)
    {
        return source.Skip((page - 1) * pageSize).Take(pageSize).ToList();
    }
    public static List<T> LinqCache<T>(this IQueryable<T> query, Table<T> table, string CacheKey) where T : class
    {
        string tableName = table.Context.Mapping.GetTable(typeof(T)).TableName;
        List<T> result = HttpContext.Current.Cache[CacheKey] as List<T>;
        if (result == null)
        {
            using (SqlConnection cn = new SqlConnection(table.Context.Connection.ConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand(table.Context.GetCommand(query).CommandText, cn);
                cmd.Notification = null;
                cmd.NotificationAutoEnlist = true;
                SqlCacheDependencyAdmin.EnableNotifications(table.Context.Connection.ConnectionString);
                if (!SqlCacheDependencyAdmin.GetTablesEnabledForNotifications(table.Context.Connection.ConnectionString).Contains(tableName))
                {
                    SqlCacheDependencyAdmin.EnableTableForNotifications(table.Context.Connection.ConnectionString, tableName);
                }
                SqlCacheDependency dependency = new SqlCacheDependency(cmd);
                cmd.ExecuteNonQuery();
                result = query.ToList();
                HttpContext.Current.Cache.Insert(tableName, CacheKey, dependency);
            }
        }
        return result;
    }

    // Condition

    public static IQueryable<TSource> Between<TSource, TKey>(
        this IQueryable<TSource> source,
        Expression<Func<TSource, TKey>> keySelector,
        TKey low, TKey high) where TKey : IComparable<TKey>
    {
        Expression key = Expression.Invoke(keySelector,
             keySelector.Parameters.ToArray());
        Expression lowerBound = Expression.LessThanOrEqual
            (Expression.Constant(low), key);
        Expression upperBound = Expression.LessThanOrEqual
            (key, Expression.Constant(high));
        Expression and = Expression.AndAlso(lowerBound, upperBound);
        Expression<Func<TSource, bool>> lambda =
            Expression.Lambda<Func<TSource, bool>>(and, keySelector.Parameters);
        return source.Where(lambda);
    }

    public static IQueryable<TSource> WhereIf<TSource>(
        this IQueryable<TSource> source, bool condition,
        Expression<Func<TSource, bool>> predicate)
    {
        if (condition)
            return source.Where(predicate);
        else
            return source;
    }

    public static IEnumerable<TSource> WhereIf<TSource>(
        this IEnumerable<TSource> source, bool condition,
        Func<TSource, bool> predicate)
    {
        if (condition)
            return source.Where(predicate);
        else
            return source;
    }
}