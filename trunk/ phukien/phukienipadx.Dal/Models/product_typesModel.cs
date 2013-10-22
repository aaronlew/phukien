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

namespace phukienipadx.Dal.Models
{
    /// <summary>
    /// Model for table product_types 
    /// </summary>
    public partial class product_typesModel 
    {
        #region Ctor

        // Default contructor
        public product_typesModel()
        {
            this.IsNewItem = true;
            this._product__types = new product_types();
        }

        // Default contructor that set entity to field
        public product_typesModel(product_types product_types)
        {
        	this._product__types = product_types;
            this._type__id = product_types.type_id;
            this._type__name = product_types.type_name;
            this._type__handler = product_types.type_handler;
            this._type__master__type = product_types.type_master_type;
            this._allow__add__to__cart = product_types.allow_add_to_cart;
            this._default__image = product_types.default_image;
            this._date__added = product_types.date_added;
            this._last__modified = product_types.last_modified;
            this._originalproduct_types = product_types.DeepClone();
        }

        #endregion

        #region Entity Properties

        
        public event EventHandler PropertyChanged;
        private product_types _product__types;
        private product_types _originalproduct_types;
        
        public product_types Mapproduct_types()
        {
            this._product__types.type_id = this._type__id;
            this._product__types.type_name = this._type__name;
            this._product__types.type_handler = this._type__handler;
            this._product__types.type_master_type = this._type__master__type;
            this._product__types.allow_add_to_cart = this._allow__add__to__cart;
            this._product__types.default_image = this._default__image;
            this._product__types.date_added = this._date__added;
            this._product__types.last_modified = this._last__modified;
        	return _product__types;
        }
        
        public void Undo()
        {
            if(this._originalproduct_types == null) return;
            this._type__id = this._originalproduct_types.type_id;
            this._type__name = this._originalproduct_types.type_name;
            this._type__handler = this._originalproduct_types.type_handler;
            this._type__master__type = this._originalproduct_types.type_master_type;
            this._allow__add__to__cart = this._originalproduct_types.allow_add_to_cart;
            this._default__image = this._originalproduct_types.default_image;
            this._date__added = this._originalproduct_types.date_added;
            this._last__modified = this._originalproduct_types.last_modified;
        	this.Commit();
        }
        
        public void Reload()
        {
        	if(this._originalproduct_types == null) return;
            this._product__types.type_id = this._originalproduct_types.type_id;
            this._product__types.type_name = this._originalproduct_types.type_name;
            this._product__types.type_handler = this._originalproduct_types.type_handler;
            this._product__types.type_master_type = this._originalproduct_types.type_master_type;
            this._product__types.allow_add_to_cart = this._originalproduct_types.allow_add_to_cart;
            this._product__types.default_image = this._originalproduct_types.default_image;
            this._product__types.date_added = this._originalproduct_types.date_added;
            this._product__types.last_modified = this._originalproduct_types.last_modified;
        }
        

        public bool IsNewItem { get; private set; }
        public bool IsDeleted { get; set; }
        public bool IsChecked { get; set; }
        
        private bool _isDirty;
        public bool IsDirty
        {
            get
            {
                return _isDirty;
            }
            private set
            {
                if (_isDirty != value)
                {
                    _isDirty = value;
                    if (PropertyChanged != null)
                        PropertyChanged.Invoke(this, new EventArgs());
                }
            }
        }
        
        public void Commit() {
        	IsNewItem = false;
        	IsDirty = false;
        }

        #endregion

        #region Primitive Properties

        
        private int _type__id;
        public int type_id
        {
            get { return this._type__id; }
            set
            {
                if (this._type__id != value)
                {
                    this.IsDirty = true;
                    this._type__id = value;
                }
            }
        }
        
        private string _type__name;
        public string type_name
        {
            get { return this._type__name; }
            set
            {
                if (this._type__name != value)
                {
                    this.IsDirty = true;
                    this._type__name = value;
                }
            }
        }
        
        private string _type__handler;
        public string type_handler
        {
            get { return this._type__handler; }
            set
            {
                if (this._type__handler != value)
                {
                    this.IsDirty = true;
                    this._type__handler = value;
                }
            }
        }
        
        private int _type__master__type;
        public int type_master_type
        {
            get { return this._type__master__type; }
            set
            {
                if (this._type__master__type != value)
                {
                    this.IsDirty = true;
                    this._type__master__type = value;
                }
            }
        }
        
        private string _allow__add__to__cart;
        public string allow_add_to_cart
        {
            get { return this._allow__add__to__cart; }
            set
            {
                if (this._allow__add__to__cart != value)
                {
                    this.IsDirty = true;
                    this._allow__add__to__cart = value;
                }
            }
        }
        
        private string _default__image;
        public string default_image
        {
            get { return this._default__image; }
            set
            {
                if (this._default__image != value)
                {
                    this.IsDirty = true;
                    this._default__image = value;
                }
            }
        }
        
        private System.DateTime _date__added;
        public System.DateTime date_added
        {
            get { return this._date__added; }
            set
            {
                if (this._date__added != value)
                {
                    this.IsDirty = true;
                    this._date__added = value;
                }
            }
        }
        
        private System.DateTime _last__modified;
        public System.DateTime last_modified
        {
            get { return this._last__modified; }
            set
            {
                if (this._last__modified != value)
                {
                    this.IsDirty = true;
                    this._last__modified = value;
                }
            }
        }

        #endregion

        #region all the custom code


        #endregion
    }
}