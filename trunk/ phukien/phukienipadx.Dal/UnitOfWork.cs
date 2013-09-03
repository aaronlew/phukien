using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Linq.Expressions;

namespace phukienipadx.Dal
{
    internal sealed class UnitOfWork : IUnitOfWork, IDisposable
    {

        #region Private Members
        //A Static instance of the Linq Data Context
        private readonly System.Data.Objects.ObjectContext _service;

        #endregion

        #region Constructors
        //The default constructor
        public UnitOfWork()
        {
            if (_service == null)
            {
                _service = new Entities(ConnectionHelper.ConnectionString);
            }
        }
        #endregion

        //Add a new entity to the model
        public void Add<T>(T _entity) where T : class
        {
            _service.AddObject(typeof(T).Name, _entity);
        }

        //Delete an existing entity from the model
        public void Delete<T>(T _entity) where T : class
        {
            object originalItem;
            EntityKey key = _service.CreateEntityKey(typeof(T).Name, _entity);
            if (_service.TryGetObjectByKey(key, out originalItem))
            {
                _service.DeleteObject(originalItem);
            }
        }

        //Update an existing entity
        public void Update<T>(T _entity) where T : class
        {
            object originalItem;
            EntityKey key = _service.CreateEntityKey(typeof(T).Name, _entity);
            if (_service.TryGetObjectByKey(key, out originalItem))
            {
                _service.ApplyCurrentValues(typeof(T).Name, _entity);
            }
        }

        public void Refresh<T>(T source) where T : class
        {
            if (null != source)
            {
                _service.Refresh(System.Data.Objects.RefreshMode.StoreWins, source);
            }
        }

        public void RefreshList<T>(IEnumerable<T> list) where T : class
        {
            if (null != list)
            {
                _service.Refresh(System.Data.Objects.RefreshMode.StoreWins, list);
            }
        }

        //Get the entire Entity table
        public IEnumerable<T> Take<T>(int skip, int count, Func<T, object> sorter) where T : class
        {
            var query = _service
                .CreateObjectSet<T>()
                .OrderByDescending(sorter)
                .Skip(skip)
                .Take(count);
            foreach (var item in query)
            {
                _service.Detach(item);
                yield return item;
            }
        }

        //Get the entire Entity table
        public IList<T> GetAll<T>() where T : class
        {
            IList<T> list = _service
                .CreateObjectSet<T>()
                .ToList();
            return list;
        }

        public IEnumerable<T> Find<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var query = _service
                .CreateObjectSet<T>();
            foreach (var item in query.Where(expression))
            {
                _service.Detach(item);
                yield return item;
            }
        }

        //Get query
        public IQueryable<T> GetQuery<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var query = _service
                .CreateObjectSet<T>();

            return query.Where(expression);
        }

        //Get by query
        public T GetSingle<T>(Func<T, bool> expression) where T : class
        {
            T result = _service
                .CreateObjectSet<T>()
                .Where(expression)
                .FirstOrDefault();
            //_service.Detach(result);
            return result;
        }

        //Count by query
        public int CountBy<T>(Expression<Func<T, bool>> expression) where T : class
        {
            return _service
                .CreateObjectSet<T>()
                .Count(expression);
        }

        //Commit all the pending changes in the data context
        public void Commit()
        {
            _service.SaveChanges();
        }

        #region IDisposable Members

        public void Dispose()
        {
            _service.Dispose();
            GC.SuppressFinalize(this);
        }

        #endregion

    }
}

//Console.WriteLine(((System.Data.Objects.ObjectQuery)query.Where(expression)).ToTraceString());