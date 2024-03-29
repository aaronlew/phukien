//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Linq.Expressions;

namespace phukienipadx.Dal.Repository
{
    /// <summary>
    /// Repository for table orders 
    /// </summary>
    public partial class ordersRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;
        public IUnitOfWork UOW { get { return unitOfWork; } }

        #endregion

        #region Ctor

        // Default contructor that creates an instance of unit of work
        public ordersRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public ordersRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion

        #region Basic C.R.U.D. operations

        // Query orders
        public IQueryable<orders> Queryorders(Expression<Func<orders, bool>> expression)
        {
        	return unitOfWork.GetQuery<orders>(expression);
        }
        // List of all orders 
        public IList<orders> GetAllorders()
        {
            return unitOfWork.GetAll<orders>();
        }

        // Find all orders 
        public IList<orders> Findorders(Expression<Func<orders, bool>> expression)
        {
            return unitOfWork.Find<orders>(expression).ToList();
        }

        // Get single orders 
        public orders GetSingleorders(Func<orders, bool> expression)
        {
            return unitOfWork.GetSingle<orders>(expression);
        }

        // Add a new orders 
        public orders Addorders(orders _orders)
        {
            unitOfWork.Add<orders>(_orders);
            return _orders;
        }

        // Delete a existed orders 
        public void Deleteorders(orders _orders)
        {
            unitOfWork.Delete<orders>(_orders);
        }

        // Delete batch a existed orders 
        public void DeleteBatchorders(IEnumerable<orders> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<orders>(item);
        	}
        }

        // Update a existed orders 
        public orders Updateorders(orders _orders)
        {
            unitOfWork.Update<orders>(_orders);
            return _orders;
        }

        // Refresh an existed orders 
        public orders Refeshorders(orders _orders)
        {
            unitOfWork.Refresh<orders>(_orders);
            return _orders;
        }

        // Refresh Allorders 
        public void RefreshListorders(IEnumerable<orders> list)
        {
            unitOfWork.RefreshList<orders>(list);
        }

        // Commit all changes 
        public void Commit()
        {
            unitOfWork.Commit();
        }

        #endregion

        #endregion

        #region all the custom code


        #endregion
    }
}
