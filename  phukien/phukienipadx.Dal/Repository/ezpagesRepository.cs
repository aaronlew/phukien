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
    /// Repository for table ezpages 
    /// </summary>
    public partial class ezpagesRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;
        public IUnitOfWork UOW { get { return unitOfWork; } }

        #endregion

        #region Ctor

        // Default contructor that creates an instance of unit of work
        public ezpagesRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public ezpagesRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion

        #region Basic C.R.U.D. operations

        // Query ezpages
        public IQueryable<ezpages> Queryezpages(Expression<Func<ezpages, bool>> expression)
        {
        	return unitOfWork.GetQuery<ezpages>(expression);
        }
        // List of all ezpages 
        public IList<ezpages> GetAllezpages()
        {
            return unitOfWork.GetAll<ezpages>();
        }

        // Find all ezpages 
        public IList<ezpages> Findezpages(Expression<Func<ezpages, bool>> expression)
        {
            return unitOfWork.Find<ezpages>(expression).ToList();
        }

        // Get single ezpages 
        public ezpages GetSingleezpages(Func<ezpages, bool> expression)
        {
            return unitOfWork.GetSingle<ezpages>(expression);
        }

        // Add a new ezpages 
        public ezpages Addezpages(ezpages _ezpages)
        {
            unitOfWork.Add<ezpages>(_ezpages);
            return _ezpages;
        }

        // Delete a existed ezpages 
        public void Deleteezpages(ezpages _ezpages)
        {
            unitOfWork.Delete<ezpages>(_ezpages);
        }

        // Delete batch a existed ezpages 
        public void DeleteBatchezpages(IEnumerable<ezpages> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<ezpages>(item);
        	}
        }

        // Update a existed ezpages 
        public ezpages Updateezpages(ezpages _ezpages)
        {
            unitOfWork.Update<ezpages>(_ezpages);
            return _ezpages;
        }

        // Refresh an existed ezpages 
        public ezpages Refeshezpages(ezpages _ezpages)
        {
            unitOfWork.Refresh<ezpages>(_ezpages);
            return _ezpages;
        }

        // Refresh Allezpages 
        public void RefreshListezpages(IEnumerable<ezpages> list)
        {
            unitOfWork.RefreshList<ezpages>(list);
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
