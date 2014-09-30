using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Caching;

namespace phukienipadx.Core.Utilities
{
    public static class LinqExtension
    {
        /// <summary>
        ///     Sort
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="source"></param>
        /// <param name="sortExpression"></param>
        /// <returns></returns>
        public static IQueryable<TEntity> OrderBy<TEntity>(this IQueryable<TEntity> source, string sortExpression)
            where TEntity : class
        {
            if (string.IsNullOrEmpty(sortExpression))
                return source; // nothing to sort on  

            Type entityType = typeof (TEntity);
            const string ascSortMethodName = "OrderBy";
            const string descSortMethodName = "OrderByDescending";
            string[] sortExpressionParts = sortExpression.Split(' ');
            string sortProperty = sortExpressionParts[0];
            string sortMethod = ascSortMethodName;

            if (sortExpressionParts.Length > 1 && sortExpressionParts[1] == "DESC")
                sortMethod = descSortMethodName;

            PropertyInfo property = entityType.GetProperty(sortProperty);
            ParameterExpression parameter = Expression.Parameter(entityType, "p");
            MemberExpression propertyAccess = Expression.MakeMemberAccess(parameter, property);
            LambdaExpression orderByExp = Expression.Lambda(propertyAccess, parameter);

            MethodCallExpression resultExp = Expression.Call(
                typeof (Queryable),
                sortMethod,
                new[] {entityType, property.PropertyType},
                source.Expression,
                Expression.Quote(orderByExp)
                );

            return source.Provider.CreateQuery<TEntity>(resultExp);
        }

        /// <summary>
        ///     Paging
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <param name="source"></param>
        /// <param name="page"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        public static IQueryable<TSource> PageIQuery<TSource>(this IQueryable<TSource> source, int page, int pageSize)
        {
            return source.Skip((page - 1)*pageSize).Take(pageSize).Cast<TSource>();
        }

        public static List<TSource> Page<TSource>(this List<TSource> source, int page, int pageSize)
        {
            return source.Skip((page - 1)*pageSize).Take(pageSize).ToList();
        }

        public static List<T> LinqCache<T>(this IQueryable<T> query, Table<T> table, string cacheKey) where T : class
        {
            string tableName = table.Context.Mapping.GetTable(typeof (T)).TableName;
            var result = HttpContext.Current.Cache[cacheKey] as List<T>;
            if (result == null)
            {
                using (var cn = new SqlConnection(table.Context.Connection.ConnectionString))
                {
                    cn.Open();
                    var cmd = new SqlCommand(table.Context.GetCommand(query).CommandText, cn)
                    {
                        Notification = null,
                        NotificationAutoEnlist = true
                    };
                    SqlCacheDependencyAdmin.EnableNotifications(table.Context.Connection.ConnectionString);
                    if (
                        !SqlCacheDependencyAdmin.GetTablesEnabledForNotifications(table.Context.Connection.ConnectionString)
                            .Contains(tableName))
                    {
                        SqlCacheDependencyAdmin.EnableTableForNotifications(table.Context.Connection.ConnectionString,
                            tableName);
                    }
                    var dependency = new SqlCacheDependency(cmd);
                    cmd.ExecuteNonQuery();
                    result = query.ToList();
                    HttpContext.Current.Cache.Insert(tableName, cacheKey, dependency);
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
            if (keySelector != null)
            {
                Expression key = Expression.Invoke(keySelector,
                    keySelector.Parameters);
                Expression lowerBound = Expression.LessThanOrEqual
                    (Expression.Constant(low), key);
                Expression upperBound = Expression.LessThanOrEqual
                    (key, Expression.Constant(high));
                Expression and = Expression.AndAlso(lowerBound, upperBound);
                Expression<Func<TSource, bool>> lambda =
                    Expression.Lambda<Func<TSource, bool>>(and, keySelector.Parameters);
                return source.Where(lambda);
            }
            return null;
        }

        public static IQueryable<TSource> WhereIf<TSource>(
            this IQueryable<TSource> source, bool condition,
            Expression<Func<TSource, bool>> predicate)
        {
            if (condition)
                return source.Where(predicate);
            return source;
        }

        public static IEnumerable<TSource> WhereIf<TSource>(
            this IEnumerable<TSource> source, bool condition,
            Func<TSource, bool> predicate)
        {
            if (condition)
                return source.Where(predicate);
            return source;
        }
    }
}