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
    /// Repository for table categories_descriptions 
    /// </summary>
    public partial class categories_descriptionsRepository
    {
        #region auto generate code

        #region variable define

        IUnitOfWork unitOfWork;

        #endregion

        #region Ctor

        // Default contructor that creates an instance of unit of work
        public categories_descriptionsRepository()
        {
            if (null == unitOfWork)
                unitOfWork = new UnitOfWork();
        }

        // Constructor of an instance of unit of work
        public categories_descriptionsRepository(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }

        #endregion

        #region Basic C.R.U.D. operations

        // List of all categories_descriptions 
        public IList<categories_descriptions> GetAllcategories_descriptions()
        {
            return unitOfWork.GetAll<categories_descriptions>();
        }

        // Find all categories_descriptions 
        public IList<categories_descriptions> Findcategories_descriptions(Expression<Func<categories_descriptions, bool>> expression)
        {
            return unitOfWork.Find<categories_descriptions>(expression).ToList();
        }

        // Get single categories_descriptions 
        public categories_descriptions GetSinglecategories_descriptions(Func<categories_descriptions, bool> expression)
        {
            return unitOfWork.GetSingle<categories_descriptions>(expression);
        }

        // Add a new categories_descriptions 
        public categories_descriptions Addcategories_descriptions(categories_descriptions _categories_descriptions)
        {
            unitOfWork.Add<categories_descriptions>(_categories_descriptions);
            return _categories_descriptions;
        }

        // Delete a existed categories_descriptions 
        public void Deletecategories_descriptions(categories_descriptions _categories_descriptions)
        {
            unitOfWork.Delete<categories_descriptions>(_categories_descriptions);
        }

        // Delete batch a existed categories_descriptions 
        public void DeleteBatchcategories_descriptions(IEnumerable<categories_descriptions> collection)
        {
        	foreach(var item in collection)
        	{
        		unitOfWork.Delete<categories_descriptions>(item);
        	}
        }

        // Update a existed categories_descriptions 
        public categories_descriptions Updatecategories_descriptions(categories_descriptions _categories_descriptions)
        {
            unitOfWork.Update<categories_descriptions>(_categories_descriptions);
            return _categories_descriptions;
        }

        // Refresh an existed categories_descriptions 
        public categories_descriptions Refeshcategories_descriptions(categories_descriptions _categories_descriptions)
        {
            unitOfWork.Refresh<categories_descriptions>(_categories_descriptions);
            return _categories_descriptions;
        }

        // Refresh Allcategories_descriptions 
        public void RefreshListcategories_descriptions(IEnumerable<categories_descriptions> list)
        {
            unitOfWork.RefreshList<categories_descriptions>(list);
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
