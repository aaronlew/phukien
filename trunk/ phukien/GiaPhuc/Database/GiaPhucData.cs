// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from reselleradmin_phukienipadx on 2012-07-03 08:16:54Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace GiaPhuc.Data
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class ResellEraDMInPhUkIeNipAdX : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public ResellEraDMInPhUkIeNipAdX(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public ResellEraDMInPhUkIeNipAdX(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public ResellEraDMInPhUkIeNipAdX(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<AddressBook> AddressBook
		{
			get
			{
				return this.GetTable<AddressBook>();
			}
		}
		
		public Table<AddressFormat> AddressFormat
		{
			get
			{
				return this.GetTable<AddressFormat>();
			}
		}
		
		public Table<AdMIn> AdMIn
		{
			get
			{
				return this.GetTable<AdMIn>();
			}
		}
		
		public Table<AdMInActivityLog> AdMInActivityLog
		{
			get
			{
				return this.GetTable<AdMInActivityLog>();
			}
		}
		
		public Table<AuthorizeNet> AuthorizeNet
		{
			get
			{
				return this.GetTable<AuthorizeNet>();
			}
		}
		
		public Table<Banners> Banners
		{
			get
			{
				return this.GetTable<Banners>();
			}
		}
		
		public Table<BannersHistory> BannersHistory
		{
			get
			{
				return this.GetTable<BannersHistory>();
			}
		}
		
		public Table<Categories> Categories
		{
			get
			{
				return this.GetTable<Categories>();
			}
		}
		
		public Table<CategoriesDescription> CategoriesDescription
		{
			get
			{
				return this.GetTable<CategoriesDescription>();
			}
		}
		
		public Table<Configuration> Configuration
		{
			get
			{
				return this.GetTable<Configuration>();
			}
		}
		
		public Table<ConfigurationGroup> ConfigurationGroup
		{
			get
			{
				return this.GetTable<ConfigurationGroup>();
			}
		}
		
		public Table<Counter> Counter
		{
			get
			{
				return this.GetTable<Counter>();
			}
		}
		
		public Table<CounterHistory> CounterHistory
		{
			get
			{
				return this.GetTable<CounterHistory>();
			}
		}
		
		public Table<Countries> Countries
		{
			get
			{
				return this.GetTable<Countries>();
			}
		}
		
		public Table<CouponEmailTrack> CouponEmailTrack
		{
			get
			{
				return this.GetTable<CouponEmailTrack>();
			}
		}
		
		public Table<CouponGVCustomer> CouponGVCustomer
		{
			get
			{
				return this.GetTable<CouponGVCustomer>();
			}
		}
		
		public Table<CouponGVQueue> CouponGVQueue
		{
			get
			{
				return this.GetTable<CouponGVQueue>();
			}
		}
		
		public Table<CouponRedeemTrack> CouponRedeemTrack
		{
			get
			{
				return this.GetTable<CouponRedeemTrack>();
			}
		}
		
		public Table<CouponRestrict> CouponRestrict
		{
			get
			{
				return this.GetTable<CouponRestrict>();
			}
		}
		
		public Table<Coupons> Coupons
		{
			get
			{
				return this.GetTable<Coupons>();
			}
		}
		
		public Table<CouponsDescription> CouponsDescription
		{
			get
			{
				return this.GetTable<CouponsDescription>();
			}
		}
		
		public Table<Currencies> Currencies
		{
			get
			{
				return this.GetTable<Currencies>();
			}
		}
		
		public Table<Customers> Customers
		{
			get
			{
				return this.GetTable<Customers>();
			}
		}
		
		public Table<CustomersBasket> CustomersBasket
		{
			get
			{
				return this.GetTable<CustomersBasket>();
			}
		}
		
		public Table<CustomersBasketAttributes> CustomersBasketAttributes
		{
			get
			{
				return this.GetTable<CustomersBasketAttributes>();
			}
		}
		
		public Table<CustomersInfo> CustomersInfo
		{
			get
			{
				return this.GetTable<CustomersInfo>();
			}
		}
		
		public Table<CustomersWishList> CustomersWishList
		{
			get
			{
				return this.GetTable<CustomersWishList>();
			}
		}
		
		public Table<DbCache> DbCache
		{
			get
			{
				return this.GetTable<DbCache>();
			}
		}
		
		public Table<EmailArchive> EmailArchive
		{
			get
			{
				return this.GetTable<EmailArchive>();
			}
		}
		
		public Table<EZPages> EZPages
		{
			get
			{
				return this.GetTable<EZPages>();
			}
		}
		
		public Table<Featured> Featured
		{
			get
			{
				return this.GetTable<Featured>();
			}
		}
		
		public Table<FilesUploadEd> FilesUploadEd
		{
			get
			{
				return this.GetTable<FilesUploadEd>();
			}
		}
		
		public Table<GeOZones> GeOZones
		{
			get
			{
				return this.GetTable<GeOZones>();
			}
		}
		
		public Table<GetTermsToFilter> GetTermsToFilter
		{
			get
			{
				return this.GetTable<GetTermsToFilter>();
			}
		}
		
		public Table<GroupPricing> GroupPricing
		{
			get
			{
				return this.GetTable<GroupPricing>();
			}
		}
		
		public Table<Languages> Languages
		{
			get
			{
				return this.GetTable<Languages>();
			}
		}
		
		public Table<LayoutBoxes> LayoutBoxes
		{
			get
			{
				return this.GetTable<LayoutBoxes>();
			}
		}
		
		public Table<Manufacturers> Manufacturers
		{
			get
			{
				return this.GetTable<Manufacturers>();
			}
		}
		
		public Table<ManufacturersInfo> ManufacturersInfo
		{
			get
			{
				return this.GetTable<ManufacturersInfo>();
			}
		}
		
		public Table<MediaClips> MediaClips
		{
			get
			{
				return this.GetTable<MediaClips>();
			}
		}
		
		public Table<MediaManager> MediaManager
		{
			get
			{
				return this.GetTable<MediaManager>();
			}
		}
		
		public Table<MediaToProducts> MediaToProducts
		{
			get
			{
				return this.GetTable<MediaToProducts>();
			}
		}
		
		public Table<MediaTypes> MediaTypes
		{
			get
			{
				return this.GetTable<MediaTypes>();
			}
		}
		
		public Table<MetaTags> MetaTags
		{
			get
			{
				return this.GetTable<MetaTags>();
			}
		}
		
		public Table<MetaTagsCategoriesDescription> MetaTagsCategoriesDescription
		{
			get
			{
				return this.GetTable<MetaTagsCategoriesDescription>();
			}
		}
		
		public Table<MetaTagsProductsDescription> MetaTagsProductsDescription
		{
			get
			{
				return this.GetTable<MetaTagsProductsDescription>();
			}
		}
		
		public Table<MusicGenre> MusicGenre
		{
			get
			{
				return this.GetTable<MusicGenre>();
			}
		}
		
		public Table<Newsletters> Newsletters
		{
			get
			{
				return this.GetTable<Newsletters>();
			}
		}
		
		public Table<Orders> Orders
		{
			get
			{
				return this.GetTable<Orders>();
			}
		}
		
		public Table<OrdersProducts> OrdersProducts
		{
			get
			{
				return this.GetTable<OrdersProducts>();
			}
		}
		
		public Table<OrdersProductsAttributes> OrdersProductsAttributes
		{
			get
			{
				return this.GetTable<OrdersProductsAttributes>();
			}
		}
		
		public Table<OrdersProductsDownload> OrdersProductsDownload
		{
			get
			{
				return this.GetTable<OrdersProductsDownload>();
			}
		}
		
		public Table<OrdersStatus> OrdersStatus
		{
			get
			{
				return this.GetTable<OrdersStatus>();
			}
		}
		
		public Table<OrdersStatusHistory> OrdersStatusHistory
		{
			get
			{
				return this.GetTable<OrdersStatusHistory>();
			}
		}
		
		public Table<OrdersTotal> OrdersTotal
		{
			get
			{
				return this.GetTable<OrdersTotal>();
			}
		}
		
		public Table<PayPal> PayPal
		{
			get
			{
				return this.GetTable<PayPal>();
			}
		}
		
		public Table<PayPalPaymentStatus> PayPalPaymentStatus
		{
			get
			{
				return this.GetTable<PayPalPaymentStatus>();
			}
		}
		
		public Table<PayPalPaymentStatusHistory> PayPalPaymentStatusHistory
		{
			get
			{
				return this.GetTable<PayPalPaymentStatusHistory>();
			}
		}
		
		public Table<PayPalSession> PayPalSession
		{
			get
			{
				return this.GetTable<PayPalSession>();
			}
		}
		
		public Table<PayPalTesting> PayPalTesting
		{
			get
			{
				return this.GetTable<PayPalTesting>();
			}
		}
		
		public Table<ProductMusicExtra> ProductMusicExtra
		{
			get
			{
				return this.GetTable<ProductMusicExtra>();
			}
		}
		
		public Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public Table<ProductsAttributes> ProductsAttributes
		{
			get
			{
				return this.GetTable<ProductsAttributes>();
			}
		}
		
		public Table<ProductsAttributesDownload> ProductsAttributesDownload
		{
			get
			{
				return this.GetTable<ProductsAttributesDownload>();
			}
		}
		
		public Table<ProductsDescription> ProductsDescription
		{
			get
			{
				return this.GetTable<ProductsDescription>();
			}
		}
		
		public Table<ProductsDiscountQuantity> ProductsDiscountQuantity
		{
			get
			{
				return this.GetTable<ProductsDiscountQuantity>();
			}
		}
		
		public Table<ProductsNotifications> ProductsNotifications
		{
			get
			{
				return this.GetTable<ProductsNotifications>();
			}
		}
		
		public Table<ProductsOptions> ProductsOptions
		{
			get
			{
				return this.GetTable<ProductsOptions>();
			}
		}
		
		public Table<ProductsOptionsTypes> ProductsOptionsTypes
		{
			get
			{
				return this.GetTable<ProductsOptionsTypes>();
			}
		}
		
		public Table<ProductsOptionsValues> ProductsOptionsValues
		{
			get
			{
				return this.GetTable<ProductsOptionsValues>();
			}
		}
		
		public Table<ProductsOptionsValuesToProductsOptions> ProductsOptionsValuesToProductsOptions
		{
			get
			{
				return this.GetTable<ProductsOptionsValuesToProductsOptions>();
			}
		}
		
		public Table<ProductsToCategories> ProductsToCategories
		{
			get
			{
				return this.GetTable<ProductsToCategories>();
			}
		}
		
		public Table<ProductTypeLayout> ProductTypeLayout
		{
			get
			{
				return this.GetTable<ProductTypeLayout>();
			}
		}
		
		public Table<ProductTypes> ProductTypes
		{
			get
			{
				return this.GetTable<ProductTypes>();
			}
		}
		
		public Table<ProductTypesToCategory> ProductTypesToCategory
		{
			get
			{
				return this.GetTable<ProductTypesToCategory>();
			}
		}
		
		public Table<ProjectVersion> ProjectVersion
		{
			get
			{
				return this.GetTable<ProjectVersion>();
			}
		}
		
		public Table<ProjectVersionHistory> ProjectVersionHistory
		{
			get
			{
				return this.GetTable<ProjectVersionHistory>();
			}
		}
		
		public Table<QueryBuilder> QueryBuilder
		{
			get
			{
				return this.GetTable<QueryBuilder>();
			}
		}
		
		public Table<RecordArtists> RecordArtists
		{
			get
			{
				return this.GetTable<RecordArtists>();
			}
		}
		
		public Table<RecordArtistsInfo> RecordArtistsInfo
		{
			get
			{
				return this.GetTable<RecordArtistsInfo>();
			}
		}
		
		public Table<RecordCompany> RecordCompany
		{
			get
			{
				return this.GetTable<RecordCompany>();
			}
		}
		
		public Table<RecordCompanyInfo> RecordCompanyInfo
		{
			get
			{
				return this.GetTable<RecordCompanyInfo>();
			}
		}
		
		public Table<Reviews> Reviews
		{
			get
			{
				return this.GetTable<Reviews>();
			}
		}
		
		public Table<ReviewsDescription> ReviewsDescription
		{
			get
			{
				return this.GetTable<ReviewsDescription>();
			}
		}
		
		public Table<SaleMakerSales> SaleMakerSales
		{
			get
			{
				return this.GetTable<SaleMakerSales>();
			}
		}
		
		public Table<Sessions> Sessions
		{
			get
			{
				return this.GetTable<Sessions>();
			}
		}
		
		public Table<Specials> Specials
		{
			get
			{
				return this.GetTable<Specials>();
			}
		}
		
		public Table<TaxClass> TaxClass
		{
			get
			{
				return this.GetTable<TaxClass>();
			}
		}
		
		public Table<TaxRates> TaxRates
		{
			get
			{
				return this.GetTable<TaxRates>();
			}
		}
		
		public Table<TemplateSelect> TemplateSelect
		{
			get
			{
				return this.GetTable<TemplateSelect>();
			}
		}
		
		public Table<UpgradeExceptions> UpgradeExceptions
		{
			get
			{
				return this.GetTable<UpgradeExceptions>();
			}
		}
		
		public Table<WhoSOnline> WhoSOnline
		{
			get
			{
				return this.GetTable<WhoSOnline>();
			}
		}
		
		public Table<Zones> Zones
		{
			get
			{
				return this.GetTable<Zones>();
			}
		}
		
		public Table<ZonesToGeOZones> ZonesToGeOZones
		{
			get
			{
				return this.GetTable<ZonesToGeOZones>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class ResellEraDMInPhUkIeNipAdX
	{
		
		public ResellEraDMInPhUkIeNipAdX(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class ResellEraDMInPhUkIeNipAdX
	{
		
		public ResellEraDMInPhUkIeNipAdX(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public ResellEraDMInPhUkIeNipAdX(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public ResellEraDMInPhUkIeNipAdX(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="reselleradmin_phukienipadx.address_book")]
	public partial class AddressBook : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _addressBookID;
		
		private int _customersID;
		
		private string _entryCity;
		
		private string _entryCompany;
		
		private int _entryCountryID;
		
		private string _entryFirstName;
		
		private string _entryGender;
		
		private string _entryLastName;
		
		private string _entryPostCode;
		
		private string _entryState;
		
		private string _entryStreetAddress;
		
		private string _entrySuburb;
		
		private int _entryZoneID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressBookIDChanged();
		
		partial void OnAddressBookIDChanging(int value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnEntryCityChanged();
		
		partial void OnEntryCityChanging(string value);
		
		partial void OnEntryCompanyChanged();
		
		partial void OnEntryCompanyChanging(string value);
		
		partial void OnEntryCountryIDChanged();
		
		partial void OnEntryCountryIDChanging(int value);
		
		partial void OnEntryFirstNameChanged();
		
		partial void OnEntryFirstNameChanging(string value);
		
		partial void OnEntryGenderChanged();
		
		partial void OnEntryGenderChanging(string value);
		
		partial void OnEntryLastNameChanged();
		
		partial void OnEntryLastNameChanging(string value);
		
		partial void OnEntryPostCodeChanged();
		
		partial void OnEntryPostCodeChanging(string value);
		
		partial void OnEntryStateChanged();
		
		partial void OnEntryStateChanging(string value);
		
		partial void OnEntryStreetAddressChanged();
		
		partial void OnEntryStreetAddressChanging(string value);
		
		partial void OnEntrySuburbChanged();
		
		partial void OnEntrySuburbChanging(string value);
		
		partial void OnEntryZoneIDChanged();
		
		partial void OnEntryZoneIDChanging(int value);
		#endregion
		
		
		public AddressBook()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_addressBookID", Name="address_book_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AddressBookID
		{
			get
			{
				return this._addressBookID;
			}
			set
			{
				if ((_addressBookID != value))
				{
					this.OnAddressBookIDChanging(value);
					this.SendPropertyChanging();
					this._addressBookID = value;
					this.SendPropertyChanged("AddressBookID");
					this.OnAddressBookIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_entryCity", Name="entry_city", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryCity
		{
			get
			{
				return this._entryCity;
			}
			set
			{
				if (((_entryCity == value) 
							== false))
				{
					this.OnEntryCityChanging(value);
					this.SendPropertyChanging();
					this._entryCity = value;
					this.SendPropertyChanged("EntryCity");
					this.OnEntryCityChanged();
				}
			}
		}
		
		[Column(Storage="_entryCompany", Name="entry_company", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntryCompany
		{
			get
			{
				return this._entryCompany;
			}
			set
			{
				if (((_entryCompany == value) 
							== false))
				{
					this.OnEntryCompanyChanging(value);
					this.SendPropertyChanging();
					this._entryCompany = value;
					this.SendPropertyChanged("EntryCompany");
					this.OnEntryCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_entryCountryID", Name="entry_country_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int EntryCountryID
		{
			get
			{
				return this._entryCountryID;
			}
			set
			{
				if ((_entryCountryID != value))
				{
					this.OnEntryCountryIDChanging(value);
					this.SendPropertyChanging();
					this._entryCountryID = value;
					this.SendPropertyChanged("EntryCountryID");
					this.OnEntryCountryIDChanged();
				}
			}
		}
		
		[Column(Storage="_entryFirstName", Name="entry_firstname", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryFirstName
		{
			get
			{
				return this._entryFirstName;
			}
			set
			{
				if (((_entryFirstName == value) 
							== false))
				{
					this.OnEntryFirstNameChanging(value);
					this.SendPropertyChanging();
					this._entryFirstName = value;
					this.SendPropertyChanged("EntryFirstName");
					this.OnEntryFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_entryGender", Name="entry_gender", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryGender
		{
			get
			{
				return this._entryGender;
			}
			set
			{
				if (((_entryGender == value) 
							== false))
				{
					this.OnEntryGenderChanging(value);
					this.SendPropertyChanging();
					this._entryGender = value;
					this.SendPropertyChanged("EntryGender");
					this.OnEntryGenderChanged();
				}
			}
		}
		
		[Column(Storage="_entryLastName", Name="entry_lastname", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryLastName
		{
			get
			{
				return this._entryLastName;
			}
			set
			{
				if (((_entryLastName == value) 
							== false))
				{
					this.OnEntryLastNameChanging(value);
					this.SendPropertyChanging();
					this._entryLastName = value;
					this.SendPropertyChanged("EntryLastName");
					this.OnEntryLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_entryPostCode", Name="entry_postcode", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryPostCode
		{
			get
			{
				return this._entryPostCode;
			}
			set
			{
				if (((_entryPostCode == value) 
							== false))
				{
					this.OnEntryPostCodeChanging(value);
					this.SendPropertyChanging();
					this._entryPostCode = value;
					this.SendPropertyChanged("EntryPostCode");
					this.OnEntryPostCodeChanged();
				}
			}
		}
		
		[Column(Storage="_entryState", Name="entry_state", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntryState
		{
			get
			{
				return this._entryState;
			}
			set
			{
				if (((_entryState == value) 
							== false))
				{
					this.OnEntryStateChanging(value);
					this.SendPropertyChanging();
					this._entryState = value;
					this.SendPropertyChanged("EntryState");
					this.OnEntryStateChanged();
				}
			}
		}
		
		[Column(Storage="_entryStreetAddress", Name="entry_street_address", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EntryStreetAddress
		{
			get
			{
				return this._entryStreetAddress;
			}
			set
			{
				if (((_entryStreetAddress == value) 
							== false))
				{
					this.OnEntryStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._entryStreetAddress = value;
					this.SendPropertyChanged("EntryStreetAddress");
					this.OnEntryStreetAddressChanged();
				}
			}
		}
		
		[Column(Storage="_entrySuburb", Name="entry_suburb", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EntrySuburb
		{
			get
			{
				return this._entrySuburb;
			}
			set
			{
				if (((_entrySuburb == value) 
							== false))
				{
					this.OnEntrySuburbChanging(value);
					this.SendPropertyChanging();
					this._entrySuburb = value;
					this.SendPropertyChanged("EntrySuburb");
					this.OnEntrySuburbChanged();
				}
			}
		}
		
		[Column(Storage="_entryZoneID", Name="entry_zone_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int EntryZoneID
		{
			get
			{
				return this._entryZoneID;
			}
			set
			{
				if ((_entryZoneID != value))
				{
					this.OnEntryZoneIDChanging(value);
					this.SendPropertyChanging();
					this._entryZoneID = value;
					this.SendPropertyChanged("EntryZoneID");
					this.OnEntryZoneIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.address_format")]
	public partial class AddressFormat : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _addressFormat1;
		
		private int _addressFormatID;
		
		private string _addressSummary;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressFormat1Changed();
		
		partial void OnAddressFormat1Changing(string value);
		
		partial void OnAddressFormatIDChanged();
		
		partial void OnAddressFormatIDChanging(int value);
		
		partial void OnAddressSummaryChanged();
		
		partial void OnAddressSummaryChanging(string value);
		#endregion
		
		
		public AddressFormat()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_addressFormat1", Name="address_format", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AddressFormat1
		{
			get
			{
				return this._addressFormat1;
			}
			set
			{
				if (((_addressFormat1 == value) 
							== false))
				{
					this.OnAddressFormat1Changing(value);
					this.SendPropertyChanging();
					this._addressFormat1 = value;
					this.SendPropertyChanged("AddressFormat1");
					this.OnAddressFormat1Changed();
				}
			}
		}
		
		[Column(Storage="_addressFormatID", Name="address_format_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AddressFormatID
		{
			get
			{
				return this._addressFormatID;
			}
			set
			{
				if ((_addressFormatID != value))
				{
					this.OnAddressFormatIDChanging(value);
					this.SendPropertyChanging();
					this._addressFormatID = value;
					this.SendPropertyChanged("AddressFormatID");
					this.OnAddressFormatIDChanged();
				}
			}
		}
		
		[Column(Storage="_addressSummary", Name="address_summary", DbType="varchar(48)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AddressSummary
		{
			get
			{
				return this._addressSummary;
			}
			set
			{
				if (((_addressSummary == value) 
							== false))
				{
					this.OnAddressSummaryChanging(value);
					this.SendPropertyChanging();
					this._addressSummary = value;
					this.SendPropertyChanged("AddressSummary");
					this.OnAddressSummaryChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.admin")]
	public partial class AdMIn : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _adMiNEmail;
		
		private int _adMiNID;
		
		private sbyte _adMiNLevel;
		
		private string _adMiNName;
		
		private string _adMiNPass;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAdMInEmailChanged();
		
		partial void OnAdMInEmailChanging(string value);
		
		partial void OnAdMInIDChanged();
		
		partial void OnAdMInIDChanging(int value);
		
		partial void OnAdMInLevelChanged();
		
		partial void OnAdMInLevelChanging(sbyte value);
		
		partial void OnAdMInNameChanged();
		
		partial void OnAdMInNameChanging(string value);
		
		partial void OnAdMInPassChanged();
		
		partial void OnAdMInPassChanging(string value);
		#endregion
		
		
		public AdMIn()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_adMiNEmail", Name="admin_email", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AdMInEmail
		{
			get
			{
				return this._adMiNEmail;
			}
			set
			{
				if (((_adMiNEmail == value) 
							== false))
				{
					this.OnAdMInEmailChanging(value);
					this.SendPropertyChanging();
					this._adMiNEmail = value;
					this.SendPropertyChanged("AdMInEmail");
					this.OnAdMInEmailChanged();
				}
			}
		}
		
		[Column(Storage="_adMiNID", Name="admin_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AdMInID
		{
			get
			{
				return this._adMiNID;
			}
			set
			{
				if ((_adMiNID != value))
				{
					this.OnAdMInIDChanging(value);
					this.SendPropertyChanging();
					this._adMiNID = value;
					this.SendPropertyChanged("AdMInID");
					this.OnAdMInIDChanged();
				}
			}
		}
		
		[Column(Storage="_adMiNLevel", Name="admin_level", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AdMInLevel
		{
			get
			{
				return this._adMiNLevel;
			}
			set
			{
				if ((_adMiNLevel != value))
				{
					this.OnAdMInLevelChanging(value);
					this.SendPropertyChanging();
					this._adMiNLevel = value;
					this.SendPropertyChanged("AdMInLevel");
					this.OnAdMInLevelChanged();
				}
			}
		}
		
		[Column(Storage="_adMiNName", Name="admin_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AdMInName
		{
			get
			{
				return this._adMiNName;
			}
			set
			{
				if (((_adMiNName == value) 
							== false))
				{
					this.OnAdMInNameChanging(value);
					this.SendPropertyChanging();
					this._adMiNName = value;
					this.SendPropertyChanged("AdMInName");
					this.OnAdMInNameChanged();
				}
			}
		}
		
		[Column(Storage="_adMiNPass", Name="admin_pass", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AdMInPass
		{
			get
			{
				return this._adMiNPass;
			}
			set
			{
				if (((_adMiNPass == value) 
							== false))
				{
					this.OnAdMInPassChanging(value);
					this.SendPropertyChanging();
					this._adMiNPass = value;
					this.SendPropertyChanged("AdMInPass");
					this.OnAdMInPassChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.admin_activity_log")]
	public partial class AdMInActivityLog : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _accessDate;
		
		private int _adMiNID;
		
		private string _ipaDdress;
		
		private int _logID;
		
		private string _pageAccessed;
		
		private string _pageParameters;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAccessDateChanged();
		
		partial void OnAccessDateChanging(System.DateTime value);
		
		partial void OnAdMInIDChanged();
		
		partial void OnAdMInIDChanging(int value);
		
		partial void OnIPAddressChanged();
		
		partial void OnIPAddressChanging(string value);
		
		partial void OnLogIDChanged();
		
		partial void OnLogIDChanging(int value);
		
		partial void OnPageAccessedChanged();
		
		partial void OnPageAccessedChanging(string value);
		
		partial void OnPageParametersChanged();
		
		partial void OnPageParametersChanging(string value);
		#endregion
		
		
		public AdMInActivityLog()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_accessDate", Name="access_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime AccessDate
		{
			get
			{
				return this._accessDate;
			}
			set
			{
				if ((_accessDate != value))
				{
					this.OnAccessDateChanging(value);
					this.SendPropertyChanging();
					this._accessDate = value;
					this.SendPropertyChanged("AccessDate");
					this.OnAccessDateChanged();
				}
			}
		}
		
		[Column(Storage="_adMiNID", Name="admin_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AdMInID
		{
			get
			{
				return this._adMiNID;
			}
			set
			{
				if ((_adMiNID != value))
				{
					this.OnAdMInIDChanging(value);
					this.SendPropertyChanging();
					this._adMiNID = value;
					this.SendPropertyChanged("AdMInID");
					this.OnAdMInIDChanged();
				}
			}
		}
		
		[Column(Storage="_ipaDdress", Name="ip_address", DbType="varchar(15)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string IPAddress
		{
			get
			{
				return this._ipaDdress;
			}
			set
			{
				if (((_ipaDdress == value) 
							== false))
				{
					this.OnIPAddressChanging(value);
					this.SendPropertyChanging();
					this._ipaDdress = value;
					this.SendPropertyChanged("IPAddress");
					this.OnIPAddressChanged();
				}
			}
		}
		
		[Column(Storage="_logID", Name="log_id", DbType="int(15)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LogID
		{
			get
			{
				return this._logID;
			}
			set
			{
				if ((_logID != value))
				{
					this.OnLogIDChanging(value);
					this.SendPropertyChanging();
					this._logID = value;
					this.SendPropertyChanged("LogID");
					this.OnLogIDChanged();
				}
			}
		}
		
		[Column(Storage="_pageAccessed", Name="page_accessed", DbType="varchar(80)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PageAccessed
		{
			get
			{
				return this._pageAccessed;
			}
			set
			{
				if (((_pageAccessed == value) 
							== false))
				{
					this.OnPageAccessedChanging(value);
					this.SendPropertyChanging();
					this._pageAccessed = value;
					this.SendPropertyChanged("PageAccessed");
					this.OnPageAccessedChanged();
				}
			}
		}
		
		[Column(Storage="_pageParameters", Name="page_parameters", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PageParameters
		{
			get
			{
				return this._pageParameters;
			}
			set
			{
				if (((_pageParameters == value) 
							== false))
				{
					this.OnPageParametersChanging(value);
					this.SendPropertyChanging();
					this._pageParameters = value;
					this.SendPropertyChanged("PageParameters");
					this.OnPageParametersChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.authorizenet")]
	public partial class AuthorizeNet : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _authorizationType;
		
		private int _customerID;
		
		private uint _id;
		
		private int _orderID;
		
		private string _received;
		
		private int _responseCode;
		
		private string _responseText;
		
		private string _sent;
		
		private string _sessionID;
		
		private string _time;
		
		private System.Nullable<long> _transactionID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAuthorizationTypeChanged();
		
		partial void OnAuthorizationTypeChanging(string value);
		
		partial void OnCustomerIDChanged();
		
		partial void OnCustomerIDChanging(int value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnOrderIDChanged();
		
		partial void OnOrderIDChanging(int value);
		
		partial void OnReceivedChanged();
		
		partial void OnReceivedChanging(string value);
		
		partial void OnResponseCodeChanged();
		
		partial void OnResponseCodeChanging(int value);
		
		partial void OnResponseTextChanged();
		
		partial void OnResponseTextChanging(string value);
		
		partial void OnSentChanged();
		
		partial void OnSentChanging(string value);
		
		partial void OnSessionIDChanged();
		
		partial void OnSessionIDChanging(string value);
		
		partial void OnTimeChanged();
		
		partial void OnTimeChanging(string value);
		
		partial void OnTransactionIDChanged();
		
		partial void OnTransactionIDChanging(System.Nullable<long> value);
		#endregion
		
		
		public AuthorizeNet()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_authorizationType", Name="authorization_type", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AuthorizationType
		{
			get
			{
				return this._authorizationType;
			}
			set
			{
				if (((_authorizationType == value) 
							== false))
				{
					this.OnAuthorizationTypeChanging(value);
					this.SendPropertyChanging();
					this._authorizationType = value;
					this.SendPropertyChanged("AuthorizationType");
					this.OnAuthorizationTypeChanged();
				}
			}
		}
		
		[Column(Storage="_customerID", Name="customer_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((_customerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_orderID", Name="order_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((_orderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_received", Name="received", DbType="longtext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Received
		{
			get
			{
				return this._received;
			}
			set
			{
				if (((_received == value) 
							== false))
				{
					this.OnReceivedChanging(value);
					this.SendPropertyChanging();
					this._received = value;
					this.SendPropertyChanged("Received");
					this.OnReceivedChanged();
				}
			}
		}
		
		[Column(Storage="_responseCode", Name="response_code", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ResponseCode
		{
			get
			{
				return this._responseCode;
			}
			set
			{
				if ((_responseCode != value))
				{
					this.OnResponseCodeChanging(value);
					this.SendPropertyChanging();
					this._responseCode = value;
					this.SendPropertyChanged("ResponseCode");
					this.OnResponseCodeChanged();
				}
			}
		}
		
		[Column(Storage="_responseText", Name="response_text", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ResponseText
		{
			get
			{
				return this._responseText;
			}
			set
			{
				if (((_responseText == value) 
							== false))
				{
					this.OnResponseTextChanging(value);
					this.SendPropertyChanging();
					this._responseText = value;
					this.SendPropertyChanged("ResponseText");
					this.OnResponseTextChanged();
				}
			}
		}
		
		[Column(Storage="_sent", Name="sent", DbType="longtext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Sent
		{
			get
			{
				return this._sent;
			}
			set
			{
				if (((_sent == value) 
							== false))
				{
					this.OnSentChanging(value);
					this.SendPropertyChanging();
					this._sent = value;
					this.SendPropertyChanged("Sent");
					this.OnSentChanged();
				}
			}
		}
		
		[Column(Storage="_sessionID", Name="session_id", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SessionID
		{
			get
			{
				return this._sessionID;
			}
			set
			{
				if (((_sessionID == value) 
							== false))
				{
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._sessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[Column(Storage="_time", Name="time", DbType="varchar(50)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Time
		{
			get
			{
				return this._time;
			}
			set
			{
				if (((_time == value) 
							== false))
				{
					this.OnTimeChanging(value);
					this.SendPropertyChanging();
					this._time = value;
					this.SendPropertyChanged("Time");
					this.OnTimeChanged();
				}
			}
		}
		
		[Column(Storage="_transactionID", Name="transaction_id", DbType="bigint(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<long> TransactionID
		{
			get
			{
				return this._transactionID;
			}
			set
			{
				if ((_transactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._transactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.banners")]
	public partial class Banners : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _bannersGroup;
		
		private string _bannersHtmltExt;
		
		private int _bannersID;
		
		private string _bannersImage;
		
		private int _bannersOnSsL;
		
		private int _bannersOpenNewWindowS;
		
		private int _bannersSortOrder;
		
		private string _bannersTitle;
		
		private string _bannersUrl;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _dateScheduled;
		
		private System.Nullable<System.DateTime> _dateStatusChange;
		
		private System.Nullable<System.DateTime> _expiresDate;
		
		private System.Nullable<int> _expiresImpressions;
		
		private int _status;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBannersGroupChanged();
		
		partial void OnBannersGroupChanging(string value);
		
		partial void OnBannersHTMLTextChanged();
		
		partial void OnBannersHTMLTextChanging(string value);
		
		partial void OnBannersIDChanged();
		
		partial void OnBannersIDChanging(int value);
		
		partial void OnBannersImageChanged();
		
		partial void OnBannersImageChanging(string value);
		
		partial void OnBannersOnSsLChanged();
		
		partial void OnBannersOnSsLChanging(int value);
		
		partial void OnBannersOpenNewWindowSChanged();
		
		partial void OnBannersOpenNewWindowSChanging(int value);
		
		partial void OnBannersSortOrderChanged();
		
		partial void OnBannersSortOrderChanging(int value);
		
		partial void OnBannersTitleChanged();
		
		partial void OnBannersTitleChanging(string value);
		
		partial void OnBannersURLChanged();
		
		partial void OnBannersURLChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnDateScheduledChanged();
		
		partial void OnDateScheduledChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDateStatusChangeChanged();
		
		partial void OnDateStatusChangeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnExpiresDateChanged();
		
		partial void OnExpiresDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnExpiresImpressionsChanged();
		
		partial void OnExpiresImpressionsChanging(System.Nullable<int> value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(int value);
		#endregion
		
		
		public Banners()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_bannersGroup", Name="banners_group", DbType="varchar(15)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BannersGroup
		{
			get
			{
				return this._bannersGroup;
			}
			set
			{
				if (((_bannersGroup == value) 
							== false))
				{
					this.OnBannersGroupChanging(value);
					this.SendPropertyChanging();
					this._bannersGroup = value;
					this.SendPropertyChanged("BannersGroup");
					this.OnBannersGroupChanged();
				}
			}
		}
		
		[Column(Storage="_bannersHtmltExt", Name="banners_html_text", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BannersHTMLText
		{
			get
			{
				return this._bannersHtmltExt;
			}
			set
			{
				if (((_bannersHtmltExt == value) 
							== false))
				{
					this.OnBannersHTMLTextChanging(value);
					this.SendPropertyChanging();
					this._bannersHtmltExt = value;
					this.SendPropertyChanged("BannersHTMLText");
					this.OnBannersHTMLTextChanged();
				}
			}
		}
		
		[Column(Storage="_bannersID", Name="banners_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersID
		{
			get
			{
				return this._bannersID;
			}
			set
			{
				if ((_bannersID != value))
				{
					this.OnBannersIDChanging(value);
					this.SendPropertyChanging();
					this._bannersID = value;
					this.SendPropertyChanged("BannersID");
					this.OnBannersIDChanged();
				}
			}
		}
		
		[Column(Storage="_bannersImage", Name="banners_image", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BannersImage
		{
			get
			{
				return this._bannersImage;
			}
			set
			{
				if (((_bannersImage == value) 
							== false))
				{
					this.OnBannersImageChanging(value);
					this.SendPropertyChanging();
					this._bannersImage = value;
					this.SendPropertyChanged("BannersImage");
					this.OnBannersImageChanged();
				}
			}
		}
		
		[Column(Storage="_bannersOnSsL", Name="banners_on_ssl", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersOnSsL
		{
			get
			{
				return this._bannersOnSsL;
			}
			set
			{
				if ((_bannersOnSsL != value))
				{
					this.OnBannersOnSsLChanging(value);
					this.SendPropertyChanging();
					this._bannersOnSsL = value;
					this.SendPropertyChanged("BannersOnSsL");
					this.OnBannersOnSsLChanged();
				}
			}
		}
		
		[Column(Storage="_bannersOpenNewWindowS", Name="banners_open_new_windows", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersOpenNewWindowS
		{
			get
			{
				return this._bannersOpenNewWindowS;
			}
			set
			{
				if ((_bannersOpenNewWindowS != value))
				{
					this.OnBannersOpenNewWindowSChanging(value);
					this.SendPropertyChanging();
					this._bannersOpenNewWindowS = value;
					this.SendPropertyChanged("BannersOpenNewWindowS");
					this.OnBannersOpenNewWindowSChanged();
				}
			}
		}
		
		[Column(Storage="_bannersSortOrder", Name="banners_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersSortOrder
		{
			get
			{
				return this._bannersSortOrder;
			}
			set
			{
				if ((_bannersSortOrder != value))
				{
					this.OnBannersSortOrderChanging(value);
					this.SendPropertyChanging();
					this._bannersSortOrder = value;
					this.SendPropertyChanged("BannersSortOrder");
					this.OnBannersSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_bannersTitle", Name="banners_title", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BannersTitle
		{
			get
			{
				return this._bannersTitle;
			}
			set
			{
				if (((_bannersTitle == value) 
							== false))
				{
					this.OnBannersTitleChanging(value);
					this.SendPropertyChanging();
					this._bannersTitle = value;
					this.SendPropertyChanged("BannersTitle");
					this.OnBannersTitleChanged();
				}
			}
		}
		
		[Column(Storage="_bannersUrl", Name="banners_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BannersURL
		{
			get
			{
				return this._bannersUrl;
			}
			set
			{
				if (((_bannersUrl == value) 
							== false))
				{
					this.OnBannersURLChanging(value);
					this.SendPropertyChanging();
					this._bannersUrl = value;
					this.SendPropertyChanged("BannersURL");
					this.OnBannersURLChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_dateScheduled", Name="date_scheduled", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateScheduled
		{
			get
			{
				return this._dateScheduled;
			}
			set
			{
				if ((_dateScheduled != value))
				{
					this.OnDateScheduledChanging(value);
					this.SendPropertyChanging();
					this._dateScheduled = value;
					this.SendPropertyChanged("DateScheduled");
					this.OnDateScheduledChanged();
				}
			}
		}
		
		[Column(Storage="_dateStatusChange", Name="date_status_change", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateStatusChange
		{
			get
			{
				return this._dateStatusChange;
			}
			set
			{
				if ((_dateStatusChange != value))
				{
					this.OnDateStatusChangeChanging(value);
					this.SendPropertyChanging();
					this._dateStatusChange = value;
					this.SendPropertyChanged("DateStatusChange");
					this.OnDateStatusChangeChanged();
				}
			}
		}
		
		[Column(Storage="_expiresDate", Name="expires_date", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ExpiresDate
		{
			get
			{
				return this._expiresDate;
			}
			set
			{
				if ((_expiresDate != value))
				{
					this.OnExpiresDateChanging(value);
					this.SendPropertyChanging();
					this._expiresDate = value;
					this.SendPropertyChanged("ExpiresDate");
					this.OnExpiresDateChanged();
				}
			}
		}
		
		[Column(Storage="_expiresImpressions", Name="expires_impressions", DbType="int(7)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ExpiresImpressions
		{
			get
			{
				return this._expiresImpressions;
			}
			set
			{
				if ((_expiresImpressions != value))
				{
					this.OnExpiresImpressionsChanging(value);
					this.SendPropertyChanging();
					this._expiresImpressions = value;
					this.SendPropertyChanged("ExpiresImpressions");
					this.OnExpiresImpressionsChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.banners_history")]
	public partial class BannersHistory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _bannersClicked;
		
		private System.DateTime _bannersHistoryDate;
		
		private int _bannersHistoryID;
		
		private int _bannersID;
		
		private int _bannersShown;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBannersClickedChanged();
		
		partial void OnBannersClickedChanging(int value);
		
		partial void OnBannersHistoryDateChanged();
		
		partial void OnBannersHistoryDateChanging(System.DateTime value);
		
		partial void OnBannersHistoryIDChanged();
		
		partial void OnBannersHistoryIDChanging(int value);
		
		partial void OnBannersIDChanged();
		
		partial void OnBannersIDChanging(int value);
		
		partial void OnBannersShownChanged();
		
		partial void OnBannersShownChanging(int value);
		#endregion
		
		
		public BannersHistory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_bannersClicked", Name="banners_clicked", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersClicked
		{
			get
			{
				return this._bannersClicked;
			}
			set
			{
				if ((_bannersClicked != value))
				{
					this.OnBannersClickedChanging(value);
					this.SendPropertyChanging();
					this._bannersClicked = value;
					this.SendPropertyChanged("BannersClicked");
					this.OnBannersClickedChanged();
				}
			}
		}
		
		[Column(Storage="_bannersHistoryDate", Name="banners_history_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime BannersHistoryDate
		{
			get
			{
				return this._bannersHistoryDate;
			}
			set
			{
				if ((_bannersHistoryDate != value))
				{
					this.OnBannersHistoryDateChanging(value);
					this.SendPropertyChanging();
					this._bannersHistoryDate = value;
					this.SendPropertyChanged("BannersHistoryDate");
					this.OnBannersHistoryDateChanged();
				}
			}
		}
		
		[Column(Storage="_bannersHistoryID", Name="banners_history_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersHistoryID
		{
			get
			{
				return this._bannersHistoryID;
			}
			set
			{
				if ((_bannersHistoryID != value))
				{
					this.OnBannersHistoryIDChanging(value);
					this.SendPropertyChanging();
					this._bannersHistoryID = value;
					this.SendPropertyChanged("BannersHistoryID");
					this.OnBannersHistoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_bannersID", Name="banners_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersID
		{
			get
			{
				return this._bannersID;
			}
			set
			{
				if ((_bannersID != value))
				{
					this.OnBannersIDChanging(value);
					this.SendPropertyChanging();
					this._bannersID = value;
					this.SendPropertyChanged("BannersID");
					this.OnBannersIDChanged();
				}
			}
		}
		
		[Column(Storage="_bannersShown", Name="banners_shown", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BannersShown
		{
			get
			{
				return this._bannersShown;
			}
			set
			{
				if ((_bannersShown != value))
				{
					this.OnBannersShownChanging(value);
					this.SendPropertyChanging();
					this._bannersShown = value;
					this.SendPropertyChanged("BannersShown");
					this.OnBannersShownChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.categories")]
	public partial class Categories : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _categoriesID;
		
		private string _categoriesImage;
		
		private sbyte _categoriesStatus;
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _parentID;
		
		private System.Nullable<int> _sortOrder;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoriesIDChanged();
		
		partial void OnCategoriesIDChanging(int value);
		
		partial void OnCategoriesImageChanged();
		
		partial void OnCategoriesImageChanging(string value);
		
		partial void OnCategoriesStatusChanged();
		
		partial void OnCategoriesStatusChanging(sbyte value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnParentIDChanged();
		
		partial void OnParentIDChanging(int value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(System.Nullable<int> value);
		#endregion
		
		
		public Categories()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoriesID", Name="categories_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoriesID
		{
			get
			{
				return this._categoriesID;
			}
			set
			{
				if ((_categoriesID != value))
				{
					this.OnCategoriesIDChanging(value);
					this.SendPropertyChanging();
					this._categoriesID = value;
					this.SendPropertyChanged("CategoriesID");
					this.OnCategoriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_categoriesImage", Name="categories_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CategoriesImage
		{
			get
			{
				return this._categoriesImage;
			}
			set
			{
				if (((_categoriesImage == value) 
							== false))
				{
					this.OnCategoriesImageChanging(value);
					this.SendPropertyChanging();
					this._categoriesImage = value;
					this.SendPropertyChanged("CategoriesImage");
					this.OnCategoriesImageChanged();
				}
			}
		}
		
		[Column(Storage="_categoriesStatus", Name="categories_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte CategoriesStatus
		{
			get
			{
				return this._categoriesStatus;
			}
			set
			{
				if ((_categoriesStatus != value))
				{
					this.OnCategoriesStatusChanging(value);
					this.SendPropertyChanging();
					this._categoriesStatus = value;
					this.SendPropertyChanged("CategoriesStatus");
					this.OnCategoriesStatusChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_parentID", Name="parent_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ParentID
		{
			get
			{
				return this._parentID;
			}
			set
			{
				if ((_parentID != value))
				{
					this.OnParentIDChanging(value);
					this.SendPropertyChanging();
					this._parentID = value;
					this.SendPropertyChanged("ParentID");
					this.OnParentIDChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int(3)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.categories_description")]
	public partial class CategoriesDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _categoriesDescription1;
		
		private int _categoriesID;
		
		private string _categoriesName;
		
		private int _languageID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoriesDescription1Changed();
		
		partial void OnCategoriesDescription1Changing(string value);
		
		partial void OnCategoriesIDChanged();
		
		partial void OnCategoriesIDChanging(int value);
		
		partial void OnCategoriesNameChanged();
		
		partial void OnCategoriesNameChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		#endregion
		
		
		public CategoriesDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoriesDescription1", Name="categories_description", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CategoriesDescription1
		{
			get
			{
				return this._categoriesDescription1;
			}
			set
			{
				if (((_categoriesDescription1 == value) 
							== false))
				{
					this.OnCategoriesDescription1Changing(value);
					this.SendPropertyChanging();
					this._categoriesDescription1 = value;
					this.SendPropertyChanged("CategoriesDescription1");
					this.OnCategoriesDescription1Changed();
				}
			}
		}
		
		[Column(Storage="_categoriesID", Name="categories_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoriesID
		{
			get
			{
				return this._categoriesID;
			}
			set
			{
				if ((_categoriesID != value))
				{
					this.OnCategoriesIDChanging(value);
					this.SendPropertyChanging();
					this._categoriesID = value;
					this.SendPropertyChanged("CategoriesID");
					this.OnCategoriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_categoriesName", Name="categories_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CategoriesName
		{
			get
			{
				return this._categoriesName;
			}
			set
			{
				if (((_categoriesName == value) 
							== false))
				{
					this.OnCategoriesNameChanging(value);
					this.SendPropertyChanging();
					this._categoriesName = value;
					this.SendPropertyChanged("CategoriesName");
					this.OnCategoriesNameChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.configuration")]
	public partial class Configuration : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _configurationDescription;
		
		private int _configurationGroupID;
		
		private int _configurationID;
		
		private string _configurationKey;
		
		private string _configurationTitle;
		
		private string _configurationValue;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private string _setFunction;
		
		private System.Nullable<int> _sortOrder;
		
		private string _useFunction;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConfigurationDescriptionChanged();
		
		partial void OnConfigurationDescriptionChanging(string value);
		
		partial void OnConfigurationGroupIDChanged();
		
		partial void OnConfigurationGroupIDChanging(int value);
		
		partial void OnConfigurationIDChanged();
		
		partial void OnConfigurationIDChanging(int value);
		
		partial void OnConfigurationKeyChanged();
		
		partial void OnConfigurationKeyChanging(string value);
		
		partial void OnConfigurationTitleChanged();
		
		partial void OnConfigurationTitleChanging(string value);
		
		partial void OnConfigurationValueChanged();
		
		partial void OnConfigurationValueChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSetFunctionChanged();
		
		partial void OnSetFunctionChanging(string value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(System.Nullable<int> value);
		
		partial void OnUseFunctionChanged();
		
		partial void OnUseFunctionChanging(string value);
		#endregion
		
		
		public Configuration()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_configurationDescription", Name="configuration_description", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationDescription
		{
			get
			{
				return this._configurationDescription;
			}
			set
			{
				if (((_configurationDescription == value) 
							== false))
				{
					this.OnConfigurationDescriptionChanging(value);
					this.SendPropertyChanging();
					this._configurationDescription = value;
					this.SendPropertyChanged("ConfigurationDescription");
					this.OnConfigurationDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_configurationGroupID", Name="configuration_group_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConfigurationGroupID
		{
			get
			{
				return this._configurationGroupID;
			}
			set
			{
				if ((_configurationGroupID != value))
				{
					this.OnConfigurationGroupIDChanging(value);
					this.SendPropertyChanging();
					this._configurationGroupID = value;
					this.SendPropertyChanged("ConfigurationGroupID");
					this.OnConfigurationGroupIDChanged();
				}
			}
		}
		
		[Column(Storage="_configurationID", Name="configuration_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConfigurationID
		{
			get
			{
				return this._configurationID;
			}
			set
			{
				if ((_configurationID != value))
				{
					this.OnConfigurationIDChanging(value);
					this.SendPropertyChanging();
					this._configurationID = value;
					this.SendPropertyChanged("ConfigurationID");
					this.OnConfigurationIDChanged();
				}
			}
		}
		
		[Column(Storage="_configurationKey", Name="configuration_key", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationKey
		{
			get
			{
				return this._configurationKey;
			}
			set
			{
				if (((_configurationKey == value) 
							== false))
				{
					this.OnConfigurationKeyChanging(value);
					this.SendPropertyChanging();
					this._configurationKey = value;
					this.SendPropertyChanged("ConfigurationKey");
					this.OnConfigurationKeyChanged();
				}
			}
		}
		
		[Column(Storage="_configurationTitle", Name="configuration_title", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationTitle
		{
			get
			{
				return this._configurationTitle;
			}
			set
			{
				if (((_configurationTitle == value) 
							== false))
				{
					this.OnConfigurationTitleChanging(value);
					this.SendPropertyChanging();
					this._configurationTitle = value;
					this.SendPropertyChanged("ConfigurationTitle");
					this.OnConfigurationTitleChanged();
				}
			}
		}
		
		[Column(Storage="_configurationValue", Name="configuration_value", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationValue
		{
			get
			{
				return this._configurationValue;
			}
			set
			{
				if (((_configurationValue == value) 
							== false))
				{
					this.OnConfigurationValueChanging(value);
					this.SendPropertyChanging();
					this._configurationValue = value;
					this.SendPropertyChanged("ConfigurationValue");
					this.OnConfigurationValueChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_setFunction", Name="set_function", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SetFunction
		{
			get
			{
				return this._setFunction;
			}
			set
			{
				if (((_setFunction == value) 
							== false))
				{
					this.OnSetFunctionChanging(value);
					this.SendPropertyChanging();
					this._setFunction = value;
					this.SendPropertyChanged("SetFunction");
					this.OnSetFunctionChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_useFunction", Name="use_function", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UseFunction
		{
			get
			{
				return this._useFunction;
			}
			set
			{
				if (((_useFunction == value) 
							== false))
				{
					this.OnUseFunctionChanging(value);
					this.SendPropertyChanging();
					this._useFunction = value;
					this.SendPropertyChanged("UseFunction");
					this.OnUseFunctionChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.configuration_group")]
	public partial class ConfigurationGroup : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _configurationGroupDescription;
		
		private int _configurationGroupID;
		
		private string _configurationGroupTitle;
		
		private System.Nullable<int> _sortOrder;
		
		private System.Nullable<int> _visible;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConfigurationGroupDescriptionChanged();
		
		partial void OnConfigurationGroupDescriptionChanging(string value);
		
		partial void OnConfigurationGroupIDChanged();
		
		partial void OnConfigurationGroupIDChanging(int value);
		
		partial void OnConfigurationGroupTitleChanged();
		
		partial void OnConfigurationGroupTitleChanging(string value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(System.Nullable<int> value);
		
		partial void OnVisibleChanged();
		
		partial void OnVisibleChanging(System.Nullable<int> value);
		#endregion
		
		
		public ConfigurationGroup()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_configurationGroupDescription", Name="configuration_group_description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationGroupDescription
		{
			get
			{
				return this._configurationGroupDescription;
			}
			set
			{
				if (((_configurationGroupDescription == value) 
							== false))
				{
					this.OnConfigurationGroupDescriptionChanging(value);
					this.SendPropertyChanging();
					this._configurationGroupDescription = value;
					this.SendPropertyChanged("ConfigurationGroupDescription");
					this.OnConfigurationGroupDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_configurationGroupID", Name="configuration_group_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConfigurationGroupID
		{
			get
			{
				return this._configurationGroupID;
			}
			set
			{
				if ((_configurationGroupID != value))
				{
					this.OnConfigurationGroupIDChanging(value);
					this.SendPropertyChanging();
					this._configurationGroupID = value;
					this.SendPropertyChanged("ConfigurationGroupID");
					this.OnConfigurationGroupIDChanged();
				}
			}
		}
		
		[Column(Storage="_configurationGroupTitle", Name="configuration_group_title", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationGroupTitle
		{
			get
			{
				return this._configurationGroupTitle;
			}
			set
			{
				if (((_configurationGroupTitle == value) 
							== false))
				{
					this.OnConfigurationGroupTitleChanging(value);
					this.SendPropertyChanging();
					this._configurationGroupTitle = value;
					this.SendPropertyChanged("ConfigurationGroupTitle");
					this.OnConfigurationGroupTitleChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_visible", Name="visible", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Visible
		{
			get
			{
				return this._visible;
			}
			set
			{
				if ((_visible != value))
				{
					this.OnVisibleChanging(value);
					this.SendPropertyChanging();
					this._visible = value;
					this.SendPropertyChanged("Visible");
					this.OnVisibleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.counter")]
	public partial class Counter
	{
		
		private System.Nullable<int> _counter1;
		
		private string _startDate;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCounter1Changed();
		
		partial void OnCounter1Changing(System.Nullable<int> value);
		
		partial void OnStartDateChanged();
		
		partial void OnStartDateChanging(string value);
		#endregion
		
		
		public Counter()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_counter1", Name="counter", DbType="int(12)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Counter1
		{
			get
			{
				return this._counter1;
			}
			set
			{
				if ((_counter1 != value))
				{
					this.OnCounter1Changing(value);
					this._counter1 = value;
					this.OnCounter1Changed();
				}
			}
		}
		
		[Column(Storage="_startDate", Name="startdate", DbType="char(8)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string StartDate
		{
			get
			{
				return this._startDate;
			}
			set
			{
				if (((_startDate == value) 
							== false))
				{
					this.OnStartDateChanging(value);
					this._startDate = value;
					this.OnStartDateChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.counter_history")]
	public partial class CounterHistory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _counter;
		
		private System.Nullable<int> _sessionCounter;
		
		private string _startDate;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCounterChanged();
		
		partial void OnCounterChanging(System.Nullable<int> value);
		
		partial void OnSessionCounterChanged();
		
		partial void OnSessionCounterChanging(System.Nullable<int> value);
		
		partial void OnStartDateChanged();
		
		partial void OnStartDateChanging(string value);
		#endregion
		
		
		public CounterHistory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_counter", Name="counter", DbType="int(12)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Counter
		{
			get
			{
				return this._counter;
			}
			set
			{
				if ((_counter != value))
				{
					this.OnCounterChanging(value);
					this.SendPropertyChanging();
					this._counter = value;
					this.SendPropertyChanged("Counter");
					this.OnCounterChanged();
				}
			}
		}
		
		[Column(Storage="_sessionCounter", Name="session_counter", DbType="int(12)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SessionCounter
		{
			get
			{
				return this._sessionCounter;
			}
			set
			{
				if ((_sessionCounter != value))
				{
					this.OnSessionCounterChanging(value);
					this.SendPropertyChanging();
					this._sessionCounter = value;
					this.SendPropertyChanged("SessionCounter");
					this.OnSessionCounterChanged();
				}
			}
		}
		
		[Column(Storage="_startDate", Name="startdate", DbType="char(8)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string StartDate
		{
			get
			{
				return this._startDate;
			}
			set
			{
				if (((_startDate == value) 
							== false))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._startDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.countries")]
	public partial class Countries : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _addressFormatID;
		
		private int _countriesID;
		
		private string _countriesIsoCode2;
		
		private string _countriesIsoCode3;
		
		private string _countriesName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressFormatIDChanged();
		
		partial void OnAddressFormatIDChanging(int value);
		
		partial void OnCountriesIDChanged();
		
		partial void OnCountriesIDChanging(int value);
		
		partial void OnCountriesIsoCode2Changed();
		
		partial void OnCountriesIsoCode2Changing(string value);
		
		partial void OnCountriesIsoCode3Changed();
		
		partial void OnCountriesIsoCode3Changing(string value);
		
		partial void OnCountriesNameChanged();
		
		partial void OnCountriesNameChanging(string value);
		#endregion
		
		
		public Countries()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_addressFormatID", Name="address_format_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AddressFormatID
		{
			get
			{
				return this._addressFormatID;
			}
			set
			{
				if ((_addressFormatID != value))
				{
					this.OnAddressFormatIDChanging(value);
					this.SendPropertyChanging();
					this._addressFormatID = value;
					this.SendPropertyChanged("AddressFormatID");
					this.OnAddressFormatIDChanged();
				}
			}
		}
		
		[Column(Storage="_countriesID", Name="countries_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CountriesID
		{
			get
			{
				return this._countriesID;
			}
			set
			{
				if ((_countriesID != value))
				{
					this.OnCountriesIDChanging(value);
					this.SendPropertyChanging();
					this._countriesID = value;
					this.SendPropertyChanged("CountriesID");
					this.OnCountriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_countriesIsoCode2", Name="countries_iso_code_2", DbType="char(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CountriesIsoCode2
		{
			get
			{
				return this._countriesIsoCode2;
			}
			set
			{
				if (((_countriesIsoCode2 == value) 
							== false))
				{
					this.OnCountriesIsoCode2Changing(value);
					this.SendPropertyChanging();
					this._countriesIsoCode2 = value;
					this.SendPropertyChanged("CountriesIsoCode2");
					this.OnCountriesIsoCode2Changed();
				}
			}
		}
		
		[Column(Storage="_countriesIsoCode3", Name="countries_iso_code_3", DbType="char(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CountriesIsoCode3
		{
			get
			{
				return this._countriesIsoCode3;
			}
			set
			{
				if (((_countriesIsoCode3 == value) 
							== false))
				{
					this.OnCountriesIsoCode3Changing(value);
					this.SendPropertyChanging();
					this._countriesIsoCode3 = value;
					this.SendPropertyChanged("CountriesIsoCode3");
					this.OnCountriesIsoCode3Changed();
				}
			}
		}
		
		[Column(Storage="_countriesName", Name="countries_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CountriesName
		{
			get
			{
				return this._countriesName;
			}
			set
			{
				if (((_countriesName == value) 
							== false))
				{
					this.OnCountriesNameChanging(value);
					this.SendPropertyChanging();
					this._countriesName = value;
					this.SendPropertyChanged("CountriesName");
					this.OnCountriesNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupon_email_track")]
	public partial class CouponEmailTrack : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _couponID;
		
		private int _customerIdsEnt;
		
		private System.DateTime _dateSent;
		
		private string _emailEdTo;
		
		private string _sentFirstName;
		
		private string _sentLastName;
		
		private int _uniqueID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCouponIDChanged();
		
		partial void OnCouponIDChanging(int value);
		
		partial void OnCustomerIDSentChanged();
		
		partial void OnCustomerIDSentChanging(int value);
		
		partial void OnDateSentChanged();
		
		partial void OnDateSentChanging(System.DateTime value);
		
		partial void OnEmailEdToChanged();
		
		partial void OnEmailEdToChanging(string value);
		
		partial void OnSentFirstNameChanged();
		
		partial void OnSentFirstNameChanging(string value);
		
		partial void OnSentLastNameChanged();
		
		partial void OnSentLastNameChanging(string value);
		
		partial void OnUniqueIDChanged();
		
		partial void OnUniqueIDChanging(int value);
		#endregion
		
		
		public CouponEmailTrack()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_couponID", Name="coupon_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponID
		{
			get
			{
				return this._couponID;
			}
			set
			{
				if ((_couponID != value))
				{
					this.OnCouponIDChanging(value);
					this.SendPropertyChanging();
					this._couponID = value;
					this.SendPropertyChanged("CouponID");
					this.OnCouponIDChanged();
				}
			}
		}
		
		[Column(Storage="_customerIdsEnt", Name="customer_id_sent", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomerIDSent
		{
			get
			{
				return this._customerIdsEnt;
			}
			set
			{
				if ((_customerIdsEnt != value))
				{
					this.OnCustomerIDSentChanging(value);
					this.SendPropertyChanging();
					this._customerIdsEnt = value;
					this.SendPropertyChanged("CustomerIDSent");
					this.OnCustomerIDSentChanged();
				}
			}
		}
		
		[Column(Storage="_dateSent", Name="date_sent", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateSent
		{
			get
			{
				return this._dateSent;
			}
			set
			{
				if ((_dateSent != value))
				{
					this.OnDateSentChanging(value);
					this.SendPropertyChanging();
					this._dateSent = value;
					this.SendPropertyChanged("DateSent");
					this.OnDateSentChanged();
				}
			}
		}
		
		[Column(Storage="_emailEdTo", Name="emailed_to", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string EmailEdTo
		{
			get
			{
				return this._emailEdTo;
			}
			set
			{
				if (((_emailEdTo == value) 
							== false))
				{
					this.OnEmailEdToChanging(value);
					this.SendPropertyChanging();
					this._emailEdTo = value;
					this.SendPropertyChanged("EmailEdTo");
					this.OnEmailEdToChanged();
				}
			}
		}
		
		[Column(Storage="_sentFirstName", Name="sent_firstname", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SentFirstName
		{
			get
			{
				return this._sentFirstName;
			}
			set
			{
				if (((_sentFirstName == value) 
							== false))
				{
					this.OnSentFirstNameChanging(value);
					this.SendPropertyChanging();
					this._sentFirstName = value;
					this.SendPropertyChanged("SentFirstName");
					this.OnSentFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_sentLastName", Name="sent_lastname", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SentLastName
		{
			get
			{
				return this._sentLastName;
			}
			set
			{
				if (((_sentLastName == value) 
							== false))
				{
					this.OnSentLastNameChanging(value);
					this.SendPropertyChanging();
					this._sentLastName = value;
					this.SendPropertyChanged("SentLastName");
					this.OnSentLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_uniqueID", Name="unique_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UniqueID
		{
			get
			{
				return this._uniqueID;
			}
			set
			{
				if ((_uniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._uniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupon_gv_customer")]
	public partial class CouponGVCustomer : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private decimal _amount;
		
		private int _customerID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAmountChanged();
		
		partial void OnAmountChanging(decimal value);
		
		partial void OnCustomerIDChanged();
		
		partial void OnCustomerIDChanging(int value);
		#endregion
		
		
		public CouponGVCustomer()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_amount", Name="amount", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal Amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((_amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[Column(Storage="_customerID", Name="customer_id", DbType="int(5)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((_customerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupon_gv_queue")]
	public partial class CouponGVQueue : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private decimal _amount;
		
		private int _customerID;
		
		private System.DateTime _dateCreated;
		
		private string _ipaDdR;
		
		private int _orderID;
		
		private string _releaseFlag;
		
		private int _uniqueID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAmountChanged();
		
		partial void OnAmountChanging(decimal value);
		
		partial void OnCustomerIDChanged();
		
		partial void OnCustomerIDChanging(int value);
		
		partial void OnDateCreatedChanged();
		
		partial void OnDateCreatedChanging(System.DateTime value);
		
		partial void OnIpaDdRChanged();
		
		partial void OnIpaDdRChanging(string value);
		
		partial void OnOrderIDChanged();
		
		partial void OnOrderIDChanging(int value);
		
		partial void OnReleaseFlagChanged();
		
		partial void OnReleaseFlagChanging(string value);
		
		partial void OnUniqueIDChanged();
		
		partial void OnUniqueIDChanging(int value);
		#endregion
		
		
		public CouponGVQueue()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_amount", Name="amount", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal Amount
		{
			get
			{
				return this._amount;
			}
			set
			{
				if ((_amount != value))
				{
					this.OnAmountChanging(value);
					this.SendPropertyChanging();
					this._amount = value;
					this.SendPropertyChanged("Amount");
					this.OnAmountChanged();
				}
			}
		}
		
		[Column(Storage="_customerID", Name="customer_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((_customerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_dateCreated", Name="date_created", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((_dateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_ipaDdR", Name="ipaddr", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string IpaDdR
		{
			get
			{
				return this._ipaDdR;
			}
			set
			{
				if (((_ipaDdR == value) 
							== false))
				{
					this.OnIpaDdRChanging(value);
					this.SendPropertyChanging();
					this._ipaDdR = value;
					this.SendPropertyChanged("IpaDdR");
					this.OnIpaDdRChanged();
				}
			}
		}
		
		[Column(Storage="_orderID", Name="order_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((_orderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_releaseFlag", Name="release_flag", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReleaseFlag
		{
			get
			{
				return this._releaseFlag;
			}
			set
			{
				if (((_releaseFlag == value) 
							== false))
				{
					this.OnReleaseFlagChanging(value);
					this.SendPropertyChanging();
					this._releaseFlag = value;
					this.SendPropertyChanged("ReleaseFlag");
					this.OnReleaseFlagChanged();
				}
			}
		}
		
		[Column(Storage="_uniqueID", Name="unique_id", DbType="int(5)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UniqueID
		{
			get
			{
				return this._uniqueID;
			}
			set
			{
				if ((_uniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._uniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupon_redeem_track")]
	public partial class CouponRedeemTrack : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _couponID;
		
		private int _customerID;
		
		private int _orderID;
		
		private System.DateTime _redeemDate;
		
		private string _redeemIp;
		
		private int _uniqueID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCouponIDChanged();
		
		partial void OnCouponIDChanging(int value);
		
		partial void OnCustomerIDChanged();
		
		partial void OnCustomerIDChanging(int value);
		
		partial void OnOrderIDChanged();
		
		partial void OnOrderIDChanging(int value);
		
		partial void OnRedeemDateChanged();
		
		partial void OnRedeemDateChanging(System.DateTime value);
		
		partial void OnRedeemIPChanged();
		
		partial void OnRedeemIPChanging(string value);
		
		partial void OnUniqueIDChanged();
		
		partial void OnUniqueIDChanging(int value);
		#endregion
		
		
		public CouponRedeemTrack()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_couponID", Name="coupon_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponID
		{
			get
			{
				return this._couponID;
			}
			set
			{
				if ((_couponID != value))
				{
					this.OnCouponIDChanging(value);
					this.SendPropertyChanging();
					this._couponID = value;
					this.SendPropertyChanged("CouponID");
					this.OnCouponIDChanged();
				}
			}
		}
		
		[Column(Storage="_customerID", Name="customer_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((_customerID != value))
				{
					this.OnCustomerIDChanging(value);
					this.SendPropertyChanging();
					this._customerID = value;
					this.SendPropertyChanged("CustomerID");
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_orderID", Name="order_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((_orderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_redeemDate", Name="redeem_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime RedeemDate
		{
			get
			{
				return this._redeemDate;
			}
			set
			{
				if ((_redeemDate != value))
				{
					this.OnRedeemDateChanging(value);
					this.SendPropertyChanging();
					this._redeemDate = value;
					this.SendPropertyChanged("RedeemDate");
					this.OnRedeemDateChanged();
				}
			}
		}
		
		[Column(Storage="_redeemIp", Name="redeem_ip", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string RedeemIP
		{
			get
			{
				return this._redeemIp;
			}
			set
			{
				if (((_redeemIp == value) 
							== false))
				{
					this.OnRedeemIPChanging(value);
					this.SendPropertyChanging();
					this._redeemIp = value;
					this.SendPropertyChanged("RedeemIP");
					this.OnRedeemIPChanged();
				}
			}
		}
		
		[Column(Storage="_uniqueID", Name="unique_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UniqueID
		{
			get
			{
				return this._uniqueID;
			}
			set
			{
				if ((_uniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._uniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupon_restrict")]
	public partial class CouponRestrict : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _categoryID;
		
		private int _couponID;
		
		private string _couponRestrict1;
		
		private int _productID;
		
		private int _restrictID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoryIDChanged();
		
		partial void OnCategoryIDChanging(int value);
		
		partial void OnCouponIDChanged();
		
		partial void OnCouponIDChanging(int value);
		
		partial void OnCouponRestrict1Changed();
		
		partial void OnCouponRestrict1Changing(string value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(int value);
		
		partial void OnRestrictIDChanged();
		
		partial void OnRestrictIDChanging(int value);
		#endregion
		
		
		public CouponRestrict()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoryID", Name="category_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoryID
		{
			get
			{
				return this._categoryID;
			}
			set
			{
				if ((_categoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this.SendPropertyChanging();
					this._categoryID = value;
					this.SendPropertyChanged("CategoryID");
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_couponID", Name="coupon_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponID
		{
			get
			{
				return this._couponID;
			}
			set
			{
				if ((_couponID != value))
				{
					this.OnCouponIDChanging(value);
					this.SendPropertyChanging();
					this._couponID = value;
					this.SendPropertyChanged("CouponID");
					this.OnCouponIDChanged();
				}
			}
		}
		
		[Column(Storage="_couponRestrict1", Name="coupon_restrict", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponRestrict1
		{
			get
			{
				return this._couponRestrict1;
			}
			set
			{
				if (((_couponRestrict1 == value) 
							== false))
				{
					this.OnCouponRestrict1Changing(value);
					this.SendPropertyChanging();
					this._couponRestrict1 = value;
					this.SendPropertyChanged("CouponRestrict1");
					this.OnCouponRestrict1Changed();
				}
			}
		}
		
		[Column(Storage="_productID", Name="product_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_restrictID", Name="restrict_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RestrictID
		{
			get
			{
				return this._restrictID;
			}
			set
			{
				if ((_restrictID != value))
				{
					this.OnRestrictIDChanging(value);
					this.SendPropertyChanging();
					this._restrictID = value;
					this.SendPropertyChanged("RestrictID");
					this.OnRestrictIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupons")]
	public partial class Coupons : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _couponActive;
		
		private decimal _couponAmount;
		
		private string _couponCode;
		
		private System.DateTime _couponExpireDate;
		
		private int _couponID;
		
		private decimal _couponMinimumOrder;
		
		private System.DateTime _couponStartDate;
		
		private string _couponType;
		
		private int _couponZoneRestriction;
		
		private System.DateTime _dateCreated;
		
		private System.DateTime _dateModified;
		
		private string _restrictToCategories;
		
		private string _restrictToCustomers;
		
		private string _restrictToProducts;
		
		private int _usesPerCoupon;
		
		private int _usesPerUser;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCouponActiveChanged();
		
		partial void OnCouponActiveChanging(string value);
		
		partial void OnCouponAmountChanged();
		
		partial void OnCouponAmountChanging(decimal value);
		
		partial void OnCouponCodeChanged();
		
		partial void OnCouponCodeChanging(string value);
		
		partial void OnCouponExpireDateChanged();
		
		partial void OnCouponExpireDateChanging(System.DateTime value);
		
		partial void OnCouponIDChanged();
		
		partial void OnCouponIDChanging(int value);
		
		partial void OnCouponMinimumOrderChanged();
		
		partial void OnCouponMinimumOrderChanging(decimal value);
		
		partial void OnCouponStartDateChanged();
		
		partial void OnCouponStartDateChanging(System.DateTime value);
		
		partial void OnCouponTypeChanged();
		
		partial void OnCouponTypeChanging(string value);
		
		partial void OnCouponZoneRestrictionChanged();
		
		partial void OnCouponZoneRestrictionChanging(int value);
		
		partial void OnDateCreatedChanged();
		
		partial void OnDateCreatedChanging(System.DateTime value);
		
		partial void OnDateModifiedChanged();
		
		partial void OnDateModifiedChanging(System.DateTime value);
		
		partial void OnRestrictToCategoriesChanged();
		
		partial void OnRestrictToCategoriesChanging(string value);
		
		partial void OnRestrictToCustomersChanged();
		
		partial void OnRestrictToCustomersChanging(string value);
		
		partial void OnRestrictToProductsChanged();
		
		partial void OnRestrictToProductsChanging(string value);
		
		partial void OnUsesPerCouponChanged();
		
		partial void OnUsesPerCouponChanging(int value);
		
		partial void OnUsesPerUserChanged();
		
		partial void OnUsesPerUserChanging(int value);
		#endregion
		
		
		public Coupons()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_couponActive", Name="coupon_active", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponActive
		{
			get
			{
				return this._couponActive;
			}
			set
			{
				if (((_couponActive == value) 
							== false))
				{
					this.OnCouponActiveChanging(value);
					this.SendPropertyChanging();
					this._couponActive = value;
					this.SendPropertyChanged("CouponActive");
					this.OnCouponActiveChanged();
				}
			}
		}
		
		[Column(Storage="_couponAmount", Name="coupon_amount", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal CouponAmount
		{
			get
			{
				return this._couponAmount;
			}
			set
			{
				if ((_couponAmount != value))
				{
					this.OnCouponAmountChanging(value);
					this.SendPropertyChanging();
					this._couponAmount = value;
					this.SendPropertyChanged("CouponAmount");
					this.OnCouponAmountChanged();
				}
			}
		}
		
		[Column(Storage="_couponCode", Name="coupon_code", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponCode
		{
			get
			{
				return this._couponCode;
			}
			set
			{
				if (((_couponCode == value) 
							== false))
				{
					this.OnCouponCodeChanging(value);
					this.SendPropertyChanging();
					this._couponCode = value;
					this.SendPropertyChanged("CouponCode");
					this.OnCouponCodeChanged();
				}
			}
		}
		
		[Column(Storage="_couponExpireDate", Name="coupon_expire_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CouponExpireDate
		{
			get
			{
				return this._couponExpireDate;
			}
			set
			{
				if ((_couponExpireDate != value))
				{
					this.OnCouponExpireDateChanging(value);
					this.SendPropertyChanging();
					this._couponExpireDate = value;
					this.SendPropertyChanged("CouponExpireDate");
					this.OnCouponExpireDateChanged();
				}
			}
		}
		
		[Column(Storage="_couponID", Name="coupon_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponID
		{
			get
			{
				return this._couponID;
			}
			set
			{
				if ((_couponID != value))
				{
					this.OnCouponIDChanging(value);
					this.SendPropertyChanging();
					this._couponID = value;
					this.SendPropertyChanged("CouponID");
					this.OnCouponIDChanged();
				}
			}
		}
		
		[Column(Storage="_couponMinimumOrder", Name="coupon_minimum_order", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal CouponMinimumOrder
		{
			get
			{
				return this._couponMinimumOrder;
			}
			set
			{
				if ((_couponMinimumOrder != value))
				{
					this.OnCouponMinimumOrderChanging(value);
					this.SendPropertyChanging();
					this._couponMinimumOrder = value;
					this.SendPropertyChanged("CouponMinimumOrder");
					this.OnCouponMinimumOrderChanged();
				}
			}
		}
		
		[Column(Storage="_couponStartDate", Name="coupon_start_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CouponStartDate
		{
			get
			{
				return this._couponStartDate;
			}
			set
			{
				if ((_couponStartDate != value))
				{
					this.OnCouponStartDateChanging(value);
					this.SendPropertyChanging();
					this._couponStartDate = value;
					this.SendPropertyChanged("CouponStartDate");
					this.OnCouponStartDateChanged();
				}
			}
		}
		
		[Column(Storage="_couponType", Name="coupon_type", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponType
		{
			get
			{
				return this._couponType;
			}
			set
			{
				if (((_couponType == value) 
							== false))
				{
					this.OnCouponTypeChanging(value);
					this.SendPropertyChanging();
					this._couponType = value;
					this.SendPropertyChanged("CouponType");
					this.OnCouponTypeChanged();
				}
			}
		}
		
		[Column(Storage="_couponZoneRestriction", Name="coupon_zone_restriction", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponZoneRestriction
		{
			get
			{
				return this._couponZoneRestriction;
			}
			set
			{
				if ((_couponZoneRestriction != value))
				{
					this.OnCouponZoneRestrictionChanging(value);
					this.SendPropertyChanging();
					this._couponZoneRestriction = value;
					this.SendPropertyChanged("CouponZoneRestriction");
					this.OnCouponZoneRestrictionChanged();
				}
			}
		}
		
		[Column(Storage="_dateCreated", Name="date_created", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateCreated
		{
			get
			{
				return this._dateCreated;
			}
			set
			{
				if ((_dateCreated != value))
				{
					this.OnDateCreatedChanging(value);
					this.SendPropertyChanging();
					this._dateCreated = value;
					this.SendPropertyChanged("DateCreated");
					this.OnDateCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_dateModified", Name="date_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateModified
		{
			get
			{
				return this._dateModified;
			}
			set
			{
				if ((_dateModified != value))
				{
					this.OnDateModifiedChanging(value);
					this.SendPropertyChanging();
					this._dateModified = value;
					this.SendPropertyChanged("DateModified");
					this.OnDateModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_restrictToCategories", Name="restrict_to_categories", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RestrictToCategories
		{
			get
			{
				return this._restrictToCategories;
			}
			set
			{
				if (((_restrictToCategories == value) 
							== false))
				{
					this.OnRestrictToCategoriesChanging(value);
					this.SendPropertyChanging();
					this._restrictToCategories = value;
					this.SendPropertyChanged("RestrictToCategories");
					this.OnRestrictToCategoriesChanged();
				}
			}
		}
		
		[Column(Storage="_restrictToCustomers", Name="restrict_to_customers", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RestrictToCustomers
		{
			get
			{
				return this._restrictToCustomers;
			}
			set
			{
				if (((_restrictToCustomers == value) 
							== false))
				{
					this.OnRestrictToCustomersChanging(value);
					this.SendPropertyChanging();
					this._restrictToCustomers = value;
					this.SendPropertyChanged("RestrictToCustomers");
					this.OnRestrictToCustomersChanged();
				}
			}
		}
		
		[Column(Storage="_restrictToProducts", Name="restrict_to_products", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RestrictToProducts
		{
			get
			{
				return this._restrictToProducts;
			}
			set
			{
				if (((_restrictToProducts == value) 
							== false))
				{
					this.OnRestrictToProductsChanging(value);
					this.SendPropertyChanging();
					this._restrictToProducts = value;
					this.SendPropertyChanged("RestrictToProducts");
					this.OnRestrictToProductsChanged();
				}
			}
		}
		
		[Column(Storage="_usesPerCoupon", Name="uses_per_coupon", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UsesPerCoupon
		{
			get
			{
				return this._usesPerCoupon;
			}
			set
			{
				if ((_usesPerCoupon != value))
				{
					this.OnUsesPerCouponChanging(value);
					this.SendPropertyChanging();
					this._usesPerCoupon = value;
					this.SendPropertyChanged("UsesPerCoupon");
					this.OnUsesPerCouponChanged();
				}
			}
		}
		
		[Column(Storage="_usesPerUser", Name="uses_per_user", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UsesPerUser
		{
			get
			{
				return this._usesPerUser;
			}
			set
			{
				if ((_usesPerUser != value))
				{
					this.OnUsesPerUserChanging(value);
					this.SendPropertyChanging();
					this._usesPerUser = value;
					this.SendPropertyChanged("UsesPerUser");
					this.OnUsesPerUserChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.coupons_description")]
	public partial class CouponsDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _couponDescription;
		
		private int _couponID;
		
		private string _couponName;
		
		private int _languageID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCouponDescriptionChanged();
		
		partial void OnCouponDescriptionChanging(string value);
		
		partial void OnCouponIDChanged();
		
		partial void OnCouponIDChanging(int value);
		
		partial void OnCouponNameChanged();
		
		partial void OnCouponNameChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		#endregion
		
		
		public CouponsDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_couponDescription", Name="coupon_description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CouponDescription
		{
			get
			{
				return this._couponDescription;
			}
			set
			{
				if (((_couponDescription == value) 
							== false))
				{
					this.OnCouponDescriptionChanging(value);
					this.SendPropertyChanging();
					this._couponDescription = value;
					this.SendPropertyChanged("CouponDescription");
					this.OnCouponDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_couponID", Name="coupon_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CouponID
		{
			get
			{
				return this._couponID;
			}
			set
			{
				if ((_couponID != value))
				{
					this.OnCouponIDChanging(value);
					this.SendPropertyChanging();
					this._couponID = value;
					this.SendPropertyChanged("CouponID");
					this.OnCouponIDChanged();
				}
			}
		}
		
		[Column(Storage="_couponName", Name="coupon_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponName
		{
			get
			{
				return this._couponName;
			}
			set
			{
				if (((_couponName == value) 
							== false))
				{
					this.OnCouponNameChanging(value);
					this.SendPropertyChanging();
					this._couponName = value;
					this.SendPropertyChanged("CouponName");
					this.OnCouponNameChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.currencies")]
	public partial class Currencies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _code;
		
		private int _currenciesID;
		
		private string _decimalPlaces;
		
		private string _decimalPoint;
		
		private System.Nullable<System.DateTime> _lastUpdated;
		
		private string _symbolLeft;
		
		private string _symbolRight;
		
		private string _thousandsPoint;
		
		private string _title;
		
		private System.Nullable<float> _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(string value);
		
		partial void OnCurrenciesIDChanged();
		
		partial void OnCurrenciesIDChanging(int value);
		
		partial void OnDecimalPlacesChanged();
		
		partial void OnDecimalPlacesChanging(string value);
		
		partial void OnDecimalPointChanged();
		
		partial void OnDecimalPointChanging(string value);
		
		partial void OnLastUpdatedChanged();
		
		partial void OnLastUpdatedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSymbolLeftChanged();
		
		partial void OnSymbolLeftChanging(string value);
		
		partial void OnSymbolRightChanged();
		
		partial void OnSymbolRightChanging(string value);
		
		partial void OnThousandsPointChanged();
		
		partial void OnThousandsPointChanging(string value);
		
		partial void OnTitleChanged();
		
		partial void OnTitleChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(System.Nullable<float> value);
		#endregion
		
		
		public Currencies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="char(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if (((_code == value) 
							== false))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_currenciesID", Name="currencies_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CurrenciesID
		{
			get
			{
				return this._currenciesID;
			}
			set
			{
				if ((_currenciesID != value))
				{
					this.OnCurrenciesIDChanging(value);
					this.SendPropertyChanging();
					this._currenciesID = value;
					this.SendPropertyChanged("CurrenciesID");
					this.OnCurrenciesIDChanged();
				}
			}
		}
		
		[Column(Storage="_decimalPlaces", Name="decimal_places", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DecimalPlaces
		{
			get
			{
				return this._decimalPlaces;
			}
			set
			{
				if (((_decimalPlaces == value) 
							== false))
				{
					this.OnDecimalPlacesChanging(value);
					this.SendPropertyChanging();
					this._decimalPlaces = value;
					this.SendPropertyChanged("DecimalPlaces");
					this.OnDecimalPlacesChanged();
				}
			}
		}
		
		[Column(Storage="_decimalPoint", Name="decimal_point", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DecimalPoint
		{
			get
			{
				return this._decimalPoint;
			}
			set
			{
				if (((_decimalPoint == value) 
							== false))
				{
					this.OnDecimalPointChanging(value);
					this.SendPropertyChanging();
					this._decimalPoint = value;
					this.SendPropertyChanged("DecimalPoint");
					this.OnDecimalPointChanged();
				}
			}
		}
		
		[Column(Storage="_lastUpdated", Name="last_updated", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastUpdated
		{
			get
			{
				return this._lastUpdated;
			}
			set
			{
				if ((_lastUpdated != value))
				{
					this.OnLastUpdatedChanging(value);
					this.SendPropertyChanging();
					this._lastUpdated = value;
					this.SendPropertyChanged("LastUpdated");
					this.OnLastUpdatedChanged();
				}
			}
		}
		
		[Column(Storage="_symbolLeft", Name="symbol_left", DbType="varchar(24)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SymbolLeft
		{
			get
			{
				return this._symbolLeft;
			}
			set
			{
				if (((_symbolLeft == value) 
							== false))
				{
					this.OnSymbolLeftChanging(value);
					this.SendPropertyChanging();
					this._symbolLeft = value;
					this.SendPropertyChanged("SymbolLeft");
					this.OnSymbolLeftChanged();
				}
			}
		}
		
		[Column(Storage="_symbolRight", Name="symbol_right", DbType="varchar(24)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SymbolRight
		{
			get
			{
				return this._symbolRight;
			}
			set
			{
				if (((_symbolRight == value) 
							== false))
				{
					this.OnSymbolRightChanging(value);
					this.SendPropertyChanging();
					this._symbolRight = value;
					this.SendPropertyChanged("SymbolRight");
					this.OnSymbolRightChanged();
				}
			}
		}
		
		[Column(Storage="_thousandsPoint", Name="thousands_point", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ThousandsPoint
		{
			get
			{
				return this._thousandsPoint;
			}
			set
			{
				if (((_thousandsPoint == value) 
							== false))
				{
					this.OnThousandsPointChanging(value);
					this.SendPropertyChanging();
					this._thousandsPoint = value;
					this.SendPropertyChanged("ThousandsPoint");
					this.OnThousandsPointChanged();
				}
			}
		}
		
		[Column(Storage="_title", Name="title", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value) 
							== false))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="value", DbType="float(13,8)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<float> Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.customers")]
	public partial class Customers : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _customersAuthorization;
		
		private int _customersDefaultAddressID;
		
		private System.DateTime _customersDob;
		
		private string _customersEmailAddress;
		
		private string _customersEmailFormat;
		
		private string _customersFax;
		
		private string _customersFirstName;
		
		private string _customersGender;
		
		private int _customersGroupPricing;
		
		private int _customersID;
		
		private string _customersLastName;
		
		private string _customersNewsletter;
		
		private string _customersNick;
		
		private string _customersPassword;
		
		private byte _customersPayPalEc;
		
		private string _customersPayPalPayerID;
		
		private string _customersReferral;
		
		private string _customersTelephone;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersAuthorizationChanged();
		
		partial void OnCustomersAuthorizationChanging(int value);
		
		partial void OnCustomersDefaultAddressIDChanged();
		
		partial void OnCustomersDefaultAddressIDChanging(int value);
		
		partial void OnCustomersDobChanged();
		
		partial void OnCustomersDobChanging(System.DateTime value);
		
		partial void OnCustomersEmailAddressChanged();
		
		partial void OnCustomersEmailAddressChanging(string value);
		
		partial void OnCustomersEmailFormatChanged();
		
		partial void OnCustomersEmailFormatChanging(string value);
		
		partial void OnCustomersFaxChanged();
		
		partial void OnCustomersFaxChanging(string value);
		
		partial void OnCustomersFirstNameChanged();
		
		partial void OnCustomersFirstNameChanging(string value);
		
		partial void OnCustomersGenderChanged();
		
		partial void OnCustomersGenderChanging(string value);
		
		partial void OnCustomersGroupPricingChanged();
		
		partial void OnCustomersGroupPricingChanging(int value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnCustomersLastNameChanged();
		
		partial void OnCustomersLastNameChanging(string value);
		
		partial void OnCustomersNewsletterChanged();
		
		partial void OnCustomersNewsletterChanging(string value);
		
		partial void OnCustomersNickChanged();
		
		partial void OnCustomersNickChanging(string value);
		
		partial void OnCustomersPasswordChanged();
		
		partial void OnCustomersPasswordChanging(string value);
		
		partial void OnCustomersPayPalEcChanged();
		
		partial void OnCustomersPayPalEcChanging(byte value);
		
		partial void OnCustomersPayPalPayerIDChanged();
		
		partial void OnCustomersPayPalPayerIDChanging(string value);
		
		partial void OnCustomersReferralChanged();
		
		partial void OnCustomersReferralChanging(string value);
		
		partial void OnCustomersTelephoneChanged();
		
		partial void OnCustomersTelephoneChanging(string value);
		#endregion
		
		
		public Customers()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersAuthorization", Name="customers_authorization", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersAuthorization
		{
			get
			{
				return this._customersAuthorization;
			}
			set
			{
				if ((_customersAuthorization != value))
				{
					this.OnCustomersAuthorizationChanging(value);
					this.SendPropertyChanging();
					this._customersAuthorization = value;
					this.SendPropertyChanged("CustomersAuthorization");
					this.OnCustomersAuthorizationChanged();
				}
			}
		}
		
		[Column(Storage="_customersDefaultAddressID", Name="customers_default_address_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersDefaultAddressID
		{
			get
			{
				return this._customersDefaultAddressID;
			}
			set
			{
				if ((_customersDefaultAddressID != value))
				{
					this.OnCustomersDefaultAddressIDChanging(value);
					this.SendPropertyChanging();
					this._customersDefaultAddressID = value;
					this.SendPropertyChanged("CustomersDefaultAddressID");
					this.OnCustomersDefaultAddressIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersDob", Name="customers_dob", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CustomersDob
		{
			get
			{
				return this._customersDob;
			}
			set
			{
				if ((_customersDob != value))
				{
					this.OnCustomersDobChanging(value);
					this.SendPropertyChanging();
					this._customersDob = value;
					this.SendPropertyChanged("CustomersDob");
					this.OnCustomersDobChanged();
				}
			}
		}
		
		[Column(Storage="_customersEmailAddress", Name="customers_email_address", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersEmailAddress
		{
			get
			{
				return this._customersEmailAddress;
			}
			set
			{
				if (((_customersEmailAddress == value) 
							== false))
				{
					this.OnCustomersEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._customersEmailAddress = value;
					this.SendPropertyChanged("CustomersEmailAddress");
					this.OnCustomersEmailAddressChanged();
				}
			}
		}
		
		[Column(Storage="_customersEmailFormat", Name="customers_email_format", DbType="varchar(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersEmailFormat
		{
			get
			{
				return this._customersEmailFormat;
			}
			set
			{
				if (((_customersEmailFormat == value) 
							== false))
				{
					this.OnCustomersEmailFormatChanging(value);
					this.SendPropertyChanging();
					this._customersEmailFormat = value;
					this.SendPropertyChanged("CustomersEmailFormat");
					this.OnCustomersEmailFormatChanged();
				}
			}
		}
		
		[Column(Storage="_customersFax", Name="customers_fax", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersFax
		{
			get
			{
				return this._customersFax;
			}
			set
			{
				if (((_customersFax == value) 
							== false))
				{
					this.OnCustomersFaxChanging(value);
					this.SendPropertyChanging();
					this._customersFax = value;
					this.SendPropertyChanged("CustomersFax");
					this.OnCustomersFaxChanged();
				}
			}
		}
		
		[Column(Storage="_customersFirstName", Name="customers_firstname", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersFirstName
		{
			get
			{
				return this._customersFirstName;
			}
			set
			{
				if (((_customersFirstName == value) 
							== false))
				{
					this.OnCustomersFirstNameChanging(value);
					this.SendPropertyChanging();
					this._customersFirstName = value;
					this.SendPropertyChanged("CustomersFirstName");
					this.OnCustomersFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_customersGender", Name="customers_gender", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersGender
		{
			get
			{
				return this._customersGender;
			}
			set
			{
				if (((_customersGender == value) 
							== false))
				{
					this.OnCustomersGenderChanging(value);
					this.SendPropertyChanging();
					this._customersGender = value;
					this.SendPropertyChanged("CustomersGender");
					this.OnCustomersGenderChanged();
				}
			}
		}
		
		[Column(Storage="_customersGroupPricing", Name="customers_group_pricing", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersGroupPricing
		{
			get
			{
				return this._customersGroupPricing;
			}
			set
			{
				if ((_customersGroupPricing != value))
				{
					this.OnCustomersGroupPricingChanging(value);
					this.SendPropertyChanging();
					this._customersGroupPricing = value;
					this.SendPropertyChanged("CustomersGroupPricing");
					this.OnCustomersGroupPricingChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersLastName", Name="customers_lastname", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersLastName
		{
			get
			{
				return this._customersLastName;
			}
			set
			{
				if (((_customersLastName == value) 
							== false))
				{
					this.OnCustomersLastNameChanging(value);
					this.SendPropertyChanging();
					this._customersLastName = value;
					this.SendPropertyChanged("CustomersLastName");
					this.OnCustomersLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_customersNewsletter", Name="customers_newsletter", DbType="char(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersNewsletter
		{
			get
			{
				return this._customersNewsletter;
			}
			set
			{
				if (((_customersNewsletter == value) 
							== false))
				{
					this.OnCustomersNewsletterChanging(value);
					this.SendPropertyChanging();
					this._customersNewsletter = value;
					this.SendPropertyChanged("CustomersNewsletter");
					this.OnCustomersNewsletterChanged();
				}
			}
		}
		
		[Column(Storage="_customersNick", Name="customers_nick", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersNick
		{
			get
			{
				return this._customersNick;
			}
			set
			{
				if (((_customersNick == value) 
							== false))
				{
					this.OnCustomersNickChanging(value);
					this.SendPropertyChanging();
					this._customersNick = value;
					this.SendPropertyChanged("CustomersNick");
					this.OnCustomersNickChanged();
				}
			}
		}
		
		[Column(Storage="_customersPassword", Name="customers_password", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersPassword
		{
			get
			{
				return this._customersPassword;
			}
			set
			{
				if (((_customersPassword == value) 
							== false))
				{
					this.OnCustomersPasswordChanging(value);
					this.SendPropertyChanging();
					this._customersPassword = value;
					this.SendPropertyChanged("CustomersPassword");
					this.OnCustomersPasswordChanged();
				}
			}
		}
		
		[Column(Storage="_customersPayPalEc", Name="customers_paypal_ec", DbType="tinyint(1) unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte CustomersPayPalEc
		{
			get
			{
				return this._customersPayPalEc;
			}
			set
			{
				if ((_customersPayPalEc != value))
				{
					this.OnCustomersPayPalEcChanging(value);
					this.SendPropertyChanging();
					this._customersPayPalEc = value;
					this.SendPropertyChanged("CustomersPayPalEc");
					this.OnCustomersPayPalEcChanged();
				}
			}
		}
		
		[Column(Storage="_customersPayPalPayerID", Name="customers_paypal_payerid", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersPayPalPayerID
		{
			get
			{
				return this._customersPayPalPayerID;
			}
			set
			{
				if (((_customersPayPalPayerID == value) 
							== false))
				{
					this.OnCustomersPayPalPayerIDChanging(value);
					this.SendPropertyChanging();
					this._customersPayPalPayerID = value;
					this.SendPropertyChanged("CustomersPayPalPayerID");
					this.OnCustomersPayPalPayerIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersReferral", Name="customers_referral", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersReferral
		{
			get
			{
				return this._customersReferral;
			}
			set
			{
				if (((_customersReferral == value) 
							== false))
				{
					this.OnCustomersReferralChanging(value);
					this.SendPropertyChanging();
					this._customersReferral = value;
					this.SendPropertyChanged("CustomersReferral");
					this.OnCustomersReferralChanged();
				}
			}
		}
		
		[Column(Storage="_customersTelephone", Name="customers_telephone", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersTelephone
		{
			get
			{
				return this._customersTelephone;
			}
			set
			{
				if (((_customersTelephone == value) 
							== false))
				{
					this.OnCustomersTelephoneChanging(value);
					this.SendPropertyChanging();
					this._customersTelephone = value;
					this.SendPropertyChanged("CustomersTelephone");
					this.OnCustomersTelephoneChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.customers_basket")]
	public partial class CustomersBasket : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _customersBasketDateAdded;
		
		private int _customersBasketID;
		
		private float _customersBasketQuantity;
		
		private int _customersID;
		
		private decimal _finalPrice;
		
		private string _productsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersBasketDateAddedChanged();
		
		partial void OnCustomersBasketDateAddedChanging(string value);
		
		partial void OnCustomersBasketIDChanged();
		
		partial void OnCustomersBasketIDChanging(int value);
		
		partial void OnCustomersBasketQuantityChanged();
		
		partial void OnCustomersBasketQuantityChanging(float value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnFinalPriceChanged();
		
		partial void OnFinalPriceChanging(decimal value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(string value);
		#endregion
		
		
		public CustomersBasket()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersBasketDateAdded", Name="customers_basket_date_added", DbType="varchar(8)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersBasketDateAdded
		{
			get
			{
				return this._customersBasketDateAdded;
			}
			set
			{
				if (((_customersBasketDateAdded == value) 
							== false))
				{
					this.OnCustomersBasketDateAddedChanging(value);
					this.SendPropertyChanging();
					this._customersBasketDateAdded = value;
					this.SendPropertyChanged("CustomersBasketDateAdded");
					this.OnCustomersBasketDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_customersBasketID", Name="customers_basket_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersBasketID
		{
			get
			{
				return this._customersBasketID;
			}
			set
			{
				if ((_customersBasketID != value))
				{
					this.OnCustomersBasketIDChanging(value);
					this.SendPropertyChanging();
					this._customersBasketID = value;
					this.SendPropertyChanged("CustomersBasketID");
					this.OnCustomersBasketIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersBasketQuantity", Name="customers_basket_quantity", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float CustomersBasketQuantity
		{
			get
			{
				return this._customersBasketQuantity;
			}
			set
			{
				if ((_customersBasketQuantity != value))
				{
					this.OnCustomersBasketQuantityChanging(value);
					this.SendPropertyChanging();
					this._customersBasketQuantity = value;
					this.SendPropertyChanged("CustomersBasketQuantity");
					this.OnCustomersBasketQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_finalPrice", Name="final_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal FinalPrice
		{
			get
			{
				return this._finalPrice;
			}
			set
			{
				if ((_finalPrice != value))
				{
					this.OnFinalPriceChanging(value);
					this.SendPropertyChanging();
					this._finalPrice = value;
					this.SendPropertyChanged("FinalPrice");
					this.OnFinalPriceChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="tinytext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if (((_productsID == value) 
							== false))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.customers_basket_attributes")]
	public partial class CustomersBasketAttributes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _customersBasketAttributesID;
		
		private int _customersID;
		
		private string _productsID;
		
		private string _productsOptionsID;
		
		private string _productsOptionsSortOrder;
		
		private int _productsOptionsValueID;
		
		private byte[] _productsOptionsValueText;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersBasketAttributesIDChanged();
		
		partial void OnCustomersBasketAttributesIDChanging(int value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(string value);
		
		partial void OnProductsOptionsIDChanged();
		
		partial void OnProductsOptionsIDChanging(string value);
		
		partial void OnProductsOptionsSortOrderChanged();
		
		partial void OnProductsOptionsSortOrderChanging(string value);
		
		partial void OnProductsOptionsValueIDChanged();
		
		partial void OnProductsOptionsValueIDChanging(int value);
		
		partial void OnProductsOptionsValueTextChanged();
		
		partial void OnProductsOptionsValueTextChanging(byte[] value);
		#endregion
		
		
		public CustomersBasketAttributes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersBasketAttributesID", Name="customers_basket_attributes_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersBasketAttributesID
		{
			get
			{
				return this._customersBasketAttributesID;
			}
			set
			{
				if ((_customersBasketAttributesID != value))
				{
					this.OnCustomersBasketAttributesIDChanging(value);
					this.SendPropertyChanging();
					this._customersBasketAttributesID = value;
					this.SendPropertyChanged("CustomersBasketAttributesID");
					this.OnCustomersBasketAttributesIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="tinytext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if (((_productsID == value) 
							== false))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsID", Name="products_options_id", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsID
		{
			get
			{
				return this._productsOptionsID;
			}
			set
			{
				if (((_productsOptionsID == value) 
							== false))
				{
					this.OnProductsOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsID = value;
					this.SendPropertyChanged("ProductsOptionsID");
					this.OnProductsOptionsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsSortOrder", Name="products_options_sort_order", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsSortOrder
		{
			get
			{
				return this._productsOptionsSortOrder;
			}
			set
			{
				if (((_productsOptionsSortOrder == value) 
							== false))
				{
					this.OnProductsOptionsSortOrderChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsSortOrder = value;
					this.SendPropertyChanged("ProductsOptionsSortOrder");
					this.OnProductsOptionsSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValueID", Name="products_options_value_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValueID
		{
			get
			{
				return this._productsOptionsValueID;
			}
			set
			{
				if ((_productsOptionsValueID != value))
				{
					this.OnProductsOptionsValueIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValueID = value;
					this.SendPropertyChanged("ProductsOptionsValueID");
					this.OnProductsOptionsValueIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValueText", Name="products_options_value_text", DbType="blob", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public byte[] ProductsOptionsValueText
		{
			get
			{
				return this._productsOptionsValueText;
			}
			set
			{
				if (((_productsOptionsValueText == value) 
							== false))
				{
					this.OnProductsOptionsValueTextChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValueText = value;
					this.SendPropertyChanged("ProductsOptionsValueText");
					this.OnProductsOptionsValueTextChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.customers_info")]
	public partial class CustomersInfo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _customersInfoDateAccountCreated;
		
		private System.Nullable<System.DateTime> _customersInfoDateAccountLastModified;
		
		private System.Nullable<System.DateTime> _customersInfoDateOfLastLogon;
		
		private int _customersInfoID;
		
		private System.Nullable<int> _customersInfoNumberOfLogoNs;
		
		private System.Nullable<int> _globalProductNotifications;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersInfoDateAccountCreatedChanged();
		
		partial void OnCustomersInfoDateAccountCreatedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnCustomersInfoDateAccountLastModifiedChanged();
		
		partial void OnCustomersInfoDateAccountLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnCustomersInfoDateOfLastLogonChanged();
		
		partial void OnCustomersInfoDateOfLastLogonChanging(System.Nullable<System.DateTime> value);
		
		partial void OnCustomersInfoIDChanged();
		
		partial void OnCustomersInfoIDChanging(int value);
		
		partial void OnCustomersInfoNumberOfLogoNSChanged();
		
		partial void OnCustomersInfoNumberOfLogoNSChanging(System.Nullable<int> value);
		
		partial void OnGlobalProductNotificationsChanged();
		
		partial void OnGlobalProductNotificationsChanging(System.Nullable<int> value);
		#endregion
		
		
		public CustomersInfo()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersInfoDateAccountCreated", Name="customers_info_date_account_created", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CustomersInfoDateAccountCreated
		{
			get
			{
				return this._customersInfoDateAccountCreated;
			}
			set
			{
				if ((_customersInfoDateAccountCreated != value))
				{
					this.OnCustomersInfoDateAccountCreatedChanging(value);
					this.SendPropertyChanging();
					this._customersInfoDateAccountCreated = value;
					this.SendPropertyChanged("CustomersInfoDateAccountCreated");
					this.OnCustomersInfoDateAccountCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_customersInfoDateAccountLastModified", Name="customers_info_date_account_last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CustomersInfoDateAccountLastModified
		{
			get
			{
				return this._customersInfoDateAccountLastModified;
			}
			set
			{
				if ((_customersInfoDateAccountLastModified != value))
				{
					this.OnCustomersInfoDateAccountLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._customersInfoDateAccountLastModified = value;
					this.SendPropertyChanged("CustomersInfoDateAccountLastModified");
					this.OnCustomersInfoDateAccountLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_customersInfoDateOfLastLogon", Name="customers_info_date_of_last_logon", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> CustomersInfoDateOfLastLogon
		{
			get
			{
				return this._customersInfoDateOfLastLogon;
			}
			set
			{
				if ((_customersInfoDateOfLastLogon != value))
				{
					this.OnCustomersInfoDateOfLastLogonChanging(value);
					this.SendPropertyChanging();
					this._customersInfoDateOfLastLogon = value;
					this.SendPropertyChanged("CustomersInfoDateOfLastLogon");
					this.OnCustomersInfoDateOfLastLogonChanged();
				}
			}
		}
		
		[Column(Storage="_customersInfoID", Name="customers_info_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersInfoID
		{
			get
			{
				return this._customersInfoID;
			}
			set
			{
				if ((_customersInfoID != value))
				{
					this.OnCustomersInfoIDChanging(value);
					this.SendPropertyChanging();
					this._customersInfoID = value;
					this.SendPropertyChanged("CustomersInfoID");
					this.OnCustomersInfoIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersInfoNumberOfLogoNs", Name="customers_info_number_of_logons", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomersInfoNumberOfLogoNS
		{
			get
			{
				return this._customersInfoNumberOfLogoNs;
			}
			set
			{
				if ((_customersInfoNumberOfLogoNs != value))
				{
					this.OnCustomersInfoNumberOfLogoNSChanging(value);
					this.SendPropertyChanging();
					this._customersInfoNumberOfLogoNs = value;
					this.SendPropertyChanged("CustomersInfoNumberOfLogoNS");
					this.OnCustomersInfoNumberOfLogoNSChanged();
				}
			}
		}
		
		[Column(Storage="_globalProductNotifications", Name="global_product_notifications", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GlobalProductNotifications
		{
			get
			{
				return this._globalProductNotifications;
			}
			set
			{
				if ((_globalProductNotifications != value))
				{
					this.OnGlobalProductNotificationsChanging(value);
					this.SendPropertyChanging();
					this._globalProductNotifications = value;
					this.SendPropertyChanged("GlobalProductNotifications");
					this.OnGlobalProductNotificationsChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.customers_wishlist")]
	public partial class CustomersWishList
	{
		
		private int _customersID;
		
		private decimal _finalPrice;
		
		private int _productsID;
		
		private string _productsModel;
		
		private string _productsName;
		
		private decimal _productsPrice;
		
		private int _productsQuantity;
		
		private string _wishListName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnFinalPriceChanged();
		
		partial void OnFinalPriceChanging(decimal value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnProductsModelChanged();
		
		partial void OnProductsModelChanging(string value);
		
		partial void OnProductsNameChanged();
		
		partial void OnProductsNameChanging(string value);
		
		partial void OnProductsPriceChanged();
		
		partial void OnProductsPriceChanging(decimal value);
		
		partial void OnProductsQuantityChanged();
		
		partial void OnProductsQuantityChanging(int value);
		
		partial void OnWishListNameChanged();
		
		partial void OnWishListNameChanging(string value);
		#endregion
		
		
		public CustomersWishList()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int(13)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this._customersID = value;
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_finalPrice", Name="final_price", DbType="decimal(8,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal FinalPrice
		{
			get
			{
				return this._finalPrice;
			}
			set
			{
				if ((_finalPrice != value))
				{
					this.OnFinalPriceChanging(value);
					this._finalPrice = value;
					this.OnFinalPriceChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int(13)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this._productsID = value;
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsModel", Name="products_model", DbType="varchar(13)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsModel
		{
			get
			{
				return this._productsModel;
			}
			set
			{
				if (((_productsModel == value) 
							== false))
				{
					this.OnProductsModelChanging(value);
					this._productsModel = value;
					this.OnProductsModelChanged();
				}
			}
		}
		
		[Column(Storage="_productsName", Name="products_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsName
		{
			get
			{
				return this._productsName;
			}
			set
			{
				if (((_productsName == value) 
							== false))
				{
					this.OnProductsNameChanging(value);
					this._productsName = value;
					this.OnProductsNameChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrice", Name="products_price", DbType="decimal(8,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal ProductsPrice
		{
			get
			{
				return this._productsPrice;
			}
			set
			{
				if ((_productsPrice != value))
				{
					this.OnProductsPriceChanging(value);
					this._productsPrice = value;
					this.OnProductsPriceChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantity", Name="products_quantity", DbType="int(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsQuantity
		{
			get
			{
				return this._productsQuantity;
			}
			set
			{
				if ((_productsQuantity != value))
				{
					this.OnProductsQuantityChanging(value);
					this._productsQuantity = value;
					this.OnProductsQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_wishListName", Name="wishlist_name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string WishListName
		{
			get
			{
				return this._wishListName;
			}
			set
			{
				if (((_wishListName == value) 
							== false))
				{
					this.OnWishListNameChanging(value);
					this._wishListName = value;
					this.OnWishListNameChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.db_cache")]
	public partial class DbCache : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private byte[] _cacheData;
		
		private System.Nullable<int> _cacheEntryCreated;
		
		private string _cacheEntryName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCacheDataChanged();
		
		partial void OnCacheDataChanging(byte[] value);
		
		partial void OnCacheEntryCreatedChanged();
		
		partial void OnCacheEntryCreatedChanging(System.Nullable<int> value);
		
		partial void OnCacheEntryNameChanged();
		
		partial void OnCacheEntryNameChanging(string value);
		#endregion
		
		
		public DbCache()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_cacheData", Name="cache_data", DbType="mediumblob", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public byte[] CacheData
		{
			get
			{
				return this._cacheData;
			}
			set
			{
				if (((_cacheData == value) 
							== false))
				{
					this.OnCacheDataChanging(value);
					this.SendPropertyChanging();
					this._cacheData = value;
					this.SendPropertyChanged("CacheData");
					this.OnCacheDataChanged();
				}
			}
		}
		
		[Column(Storage="_cacheEntryCreated", Name="cache_entry_created", DbType="int(15)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CacheEntryCreated
		{
			get
			{
				return this._cacheEntryCreated;
			}
			set
			{
				if ((_cacheEntryCreated != value))
				{
					this.OnCacheEntryCreatedChanging(value);
					this.SendPropertyChanging();
					this._cacheEntryCreated = value;
					this.SendPropertyChanged("CacheEntryCreated");
					this.OnCacheEntryCreatedChanged();
				}
			}
		}
		
		[Column(Storage="_cacheEntryName", Name="cache_entry_name", DbType="varchar(64)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CacheEntryName
		{
			get
			{
				return this._cacheEntryName;
			}
			set
			{
				if (((_cacheEntryName == value) 
							== false))
				{
					this.OnCacheEntryNameChanging(value);
					this.SendPropertyChanging();
					this._cacheEntryName = value;
					this.SendPropertyChanged("CacheEntryName");
					this.OnCacheEntryNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.email_archive")]
	public partial class EmailArchive : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _archiveID;
		
		private System.DateTime _dateSent;
		
		private string _emailFromAddress;
		
		private string _emailFromName;
		
		private string _emailHtml;
		
		private string _emailSubject;
		
		private string _emailText;
		
		private string _emailToAddress;
		
		private string _emailToName;
		
		private string _module;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArchiveIDChanged();
		
		partial void OnArchiveIDChanging(int value);
		
		partial void OnDateSentChanged();
		
		partial void OnDateSentChanging(System.DateTime value);
		
		partial void OnEmailFromAddressChanged();
		
		partial void OnEmailFromAddressChanging(string value);
		
		partial void OnEmailFromNameChanged();
		
		partial void OnEmailFromNameChanging(string value);
		
		partial void OnEmailHTMLChanged();
		
		partial void OnEmailHTMLChanging(string value);
		
		partial void OnEmailSubjectChanged();
		
		partial void OnEmailSubjectChanging(string value);
		
		partial void OnEmailTextChanged();
		
		partial void OnEmailTextChanging(string value);
		
		partial void OnEmailToAddressChanged();
		
		partial void OnEmailToAddressChanging(string value);
		
		partial void OnEmailToNameChanged();
		
		partial void OnEmailToNameChanging(string value);
		
		partial void OnModuleChanged();
		
		partial void OnModuleChanging(string value);
		#endregion
		
		
		public EmailArchive()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_archiveID", Name="archive_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArchiveID
		{
			get
			{
				return this._archiveID;
			}
			set
			{
				if ((_archiveID != value))
				{
					this.OnArchiveIDChanging(value);
					this.SendPropertyChanging();
					this._archiveID = value;
					this.SendPropertyChanged("ArchiveID");
					this.OnArchiveIDChanged();
				}
			}
		}
		
		[Column(Storage="_dateSent", Name="date_sent", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateSent
		{
			get
			{
				return this._dateSent;
			}
			set
			{
				if ((_dateSent != value))
				{
					this.OnDateSentChanging(value);
					this.SendPropertyChanging();
					this._dateSent = value;
					this.SendPropertyChanged("DateSent");
					this.OnDateSentChanged();
				}
			}
		}
		
		[Column(Storage="_emailFromAddress", Name="email_from_address", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailFromAddress
		{
			get
			{
				return this._emailFromAddress;
			}
			set
			{
				if (((_emailFromAddress == value) 
							== false))
				{
					this.OnEmailFromAddressChanging(value);
					this.SendPropertyChanging();
					this._emailFromAddress = value;
					this.SendPropertyChanged("EmailFromAddress");
					this.OnEmailFromAddressChanged();
				}
			}
		}
		
		[Column(Storage="_emailFromName", Name="email_from_name", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailFromName
		{
			get
			{
				return this._emailFromName;
			}
			set
			{
				if (((_emailFromName == value) 
							== false))
				{
					this.OnEmailFromNameChanging(value);
					this.SendPropertyChanging();
					this._emailFromName = value;
					this.SendPropertyChanged("EmailFromName");
					this.OnEmailFromNameChanged();
				}
			}
		}
		
		[Column(Storage="_emailHtml", Name="email_html", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailHTML
		{
			get
			{
				return this._emailHtml;
			}
			set
			{
				if (((_emailHtml == value) 
							== false))
				{
					this.OnEmailHTMLChanging(value);
					this.SendPropertyChanging();
					this._emailHtml = value;
					this.SendPropertyChanged("EmailHTML");
					this.OnEmailHTMLChanged();
				}
			}
		}
		
		[Column(Storage="_emailSubject", Name="email_subject", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailSubject
		{
			get
			{
				return this._emailSubject;
			}
			set
			{
				if (((_emailSubject == value) 
							== false))
				{
					this.OnEmailSubjectChanging(value);
					this.SendPropertyChanging();
					this._emailSubject = value;
					this.SendPropertyChanged("EmailSubject");
					this.OnEmailSubjectChanged();
				}
			}
		}
		
		[Column(Storage="_emailText", Name="email_text", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailText
		{
			get
			{
				return this._emailText;
			}
			set
			{
				if (((_emailText == value) 
							== false))
				{
					this.OnEmailTextChanging(value);
					this.SendPropertyChanging();
					this._emailText = value;
					this.SendPropertyChanged("EmailText");
					this.OnEmailTextChanged();
				}
			}
		}
		
		[Column(Storage="_emailToAddress", Name="email_to_address", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailToAddress
		{
			get
			{
				return this._emailToAddress;
			}
			set
			{
				if (((_emailToAddress == value) 
							== false))
				{
					this.OnEmailToAddressChanging(value);
					this.SendPropertyChanging();
					this._emailToAddress = value;
					this.SendPropertyChanged("EmailToAddress");
					this.OnEmailToAddressChanged();
				}
			}
		}
		
		[Column(Storage="_emailToName", Name="email_to_name", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string EmailToName
		{
			get
			{
				return this._emailToName;
			}
			set
			{
				if (((_emailToName == value) 
							== false))
				{
					this.OnEmailToNameChanging(value);
					this.SendPropertyChanging();
					this._emailToName = value;
					this.SendPropertyChanged("EmailToName");
					this.OnEmailToNameChanged();
				}
			}
		}
		
		[Column(Storage="_module", Name="module", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Module
		{
			get
			{
				return this._module;
			}
			set
			{
				if (((_module == value) 
							== false))
				{
					this.OnModuleChanging(value);
					this.SendPropertyChanging();
					this._module = value;
					this.SendPropertyChanged("Module");
					this.OnModuleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.ezpages")]
	public partial class EZPages : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _alTUrl;
		
		private string _alTUrleXternal;
		
		private int _footerSortOrder;
		
		private int _headerSortOrder;
		
		private int _languagesID;
		
		private int _pageIsSsL;
		
		private int _pageOpenNewWindow;
		
		private string _pagesHtmltExt;
		
		private int _pagesID;
		
		private string _pagesTitle;
		
		private int _sideBoxSortOrder;
		
		private int _statusFooter;
		
		private int _statusHeader;
		
		private int _statusSideBox;
		
		private int _statusToC;
		
		private int _toCcHapter;
		
		private int _toCsOrtOrder;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnALtURLChanged();
		
		partial void OnALtURLChanging(string value);
		
		partial void OnALtURLExternalChanged();
		
		partial void OnALtURLExternalChanging(string value);
		
		partial void OnFooterSortOrderChanged();
		
		partial void OnFooterSortOrderChanging(int value);
		
		partial void OnHeaderSortOrderChanged();
		
		partial void OnHeaderSortOrderChanging(int value);
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnPageIsSsLChanged();
		
		partial void OnPageIsSsLChanging(int value);
		
		partial void OnPageOpenNewWindowChanged();
		
		partial void OnPageOpenNewWindowChanging(int value);
		
		partial void OnPagesHTMLTextChanged();
		
		partial void OnPagesHTMLTextChanging(string value);
		
		partial void OnPagesIDChanged();
		
		partial void OnPagesIDChanging(int value);
		
		partial void OnPagesTitleChanged();
		
		partial void OnPagesTitleChanging(string value);
		
		partial void OnSideBoxSortOrderChanged();
		
		partial void OnSideBoxSortOrderChanging(int value);
		
		partial void OnStatusFooterChanged();
		
		partial void OnStatusFooterChanging(int value);
		
		partial void OnStatusHeaderChanged();
		
		partial void OnStatusHeaderChanging(int value);
		
		partial void OnStatusSideBoxChanged();
		
		partial void OnStatusSideBoxChanging(int value);
		
		partial void OnStatusToCChanged();
		
		partial void OnStatusToCChanging(int value);
		
		partial void OnToCChapterChanged();
		
		partial void OnToCChapterChanging(int value);
		
		partial void OnToCSortOrderChanged();
		
		partial void OnToCSortOrderChanging(int value);
		#endregion
		
		
		public EZPages()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_alTUrl", Name="alt_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ALtURL
		{
			get
			{
				return this._alTUrl;
			}
			set
			{
				if (((_alTUrl == value) 
							== false))
				{
					this.OnALtURLChanging(value);
					this.SendPropertyChanging();
					this._alTUrl = value;
					this.SendPropertyChanged("ALtURL");
					this.OnALtURLChanged();
				}
			}
		}
		
		[Column(Storage="_alTUrleXternal", Name="alt_url_external", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ALtURLExternal
		{
			get
			{
				return this._alTUrleXternal;
			}
			set
			{
				if (((_alTUrleXternal == value) 
							== false))
				{
					this.OnALtURLExternalChanging(value);
					this.SendPropertyChanging();
					this._alTUrleXternal = value;
					this.SendPropertyChanged("ALtURLExternal");
					this.OnALtURLExternalChanged();
				}
			}
		}
		
		[Column(Storage="_footerSortOrder", Name="footer_sort_order", DbType="int(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FooterSortOrder
		{
			get
			{
				return this._footerSortOrder;
			}
			set
			{
				if ((_footerSortOrder != value))
				{
					this.OnFooterSortOrderChanging(value);
					this.SendPropertyChanging();
					this._footerSortOrder = value;
					this.SendPropertyChanged("FooterSortOrder");
					this.OnFooterSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_headerSortOrder", Name="header_sort_order", DbType="int(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int HeaderSortOrder
		{
			get
			{
				return this._headerSortOrder;
			}
			set
			{
				if ((_headerSortOrder != value))
				{
					this.OnHeaderSortOrderChanging(value);
					this.SendPropertyChanging();
					this._headerSortOrder = value;
					this.SendPropertyChanged("HeaderSortOrder");
					this.OnHeaderSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_pageIsSsL", Name="page_is_ssl", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PageIsSsL
		{
			get
			{
				return this._pageIsSsL;
			}
			set
			{
				if ((_pageIsSsL != value))
				{
					this.OnPageIsSsLChanging(value);
					this.SendPropertyChanging();
					this._pageIsSsL = value;
					this.SendPropertyChanged("PageIsSsL");
					this.OnPageIsSsLChanged();
				}
			}
		}
		
		[Column(Storage="_pageOpenNewWindow", Name="page_open_new_window", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PageOpenNewWindow
		{
			get
			{
				return this._pageOpenNewWindow;
			}
			set
			{
				if ((_pageOpenNewWindow != value))
				{
					this.OnPageOpenNewWindowChanging(value);
					this.SendPropertyChanging();
					this._pageOpenNewWindow = value;
					this.SendPropertyChanged("PageOpenNewWindow");
					this.OnPageOpenNewWindowChanged();
				}
			}
		}
		
		[Column(Storage="_pagesHtmltExt", Name="pages_html_text", DbType="mediumtext", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PagesHTMLText
		{
			get
			{
				return this._pagesHtmltExt;
			}
			set
			{
				if (((_pagesHtmltExt == value) 
							== false))
				{
					this.OnPagesHTMLTextChanging(value);
					this.SendPropertyChanging();
					this._pagesHtmltExt = value;
					this.SendPropertyChanged("PagesHTMLText");
					this.OnPagesHTMLTextChanged();
				}
			}
		}
		
		[Column(Storage="_pagesID", Name="pages_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PagesID
		{
			get
			{
				return this._pagesID;
			}
			set
			{
				if ((_pagesID != value))
				{
					this.OnPagesIDChanging(value);
					this.SendPropertyChanging();
					this._pagesID = value;
					this.SendPropertyChanged("PagesID");
					this.OnPagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_pagesTitle", Name="pages_title", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PagesTitle
		{
			get
			{
				return this._pagesTitle;
			}
			set
			{
				if (((_pagesTitle == value) 
							== false))
				{
					this.OnPagesTitleChanging(value);
					this.SendPropertyChanging();
					this._pagesTitle = value;
					this.SendPropertyChanged("PagesTitle");
					this.OnPagesTitleChanged();
				}
			}
		}
		
		[Column(Storage="_sideBoxSortOrder", Name="sidebox_sort_order", DbType="int(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SideBoxSortOrder
		{
			get
			{
				return this._sideBoxSortOrder;
			}
			set
			{
				if ((_sideBoxSortOrder != value))
				{
					this.OnSideBoxSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sideBoxSortOrder = value;
					this.SendPropertyChanged("SideBoxSortOrder");
					this.OnSideBoxSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_statusFooter", Name="status_footer", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int StatusFooter
		{
			get
			{
				return this._statusFooter;
			}
			set
			{
				if ((_statusFooter != value))
				{
					this.OnStatusFooterChanging(value);
					this.SendPropertyChanging();
					this._statusFooter = value;
					this.SendPropertyChanged("StatusFooter");
					this.OnStatusFooterChanged();
				}
			}
		}
		
		[Column(Storage="_statusHeader", Name="status_header", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int StatusHeader
		{
			get
			{
				return this._statusHeader;
			}
			set
			{
				if ((_statusHeader != value))
				{
					this.OnStatusHeaderChanging(value);
					this.SendPropertyChanging();
					this._statusHeader = value;
					this.SendPropertyChanged("StatusHeader");
					this.OnStatusHeaderChanged();
				}
			}
		}
		
		[Column(Storage="_statusSideBox", Name="status_sidebox", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int StatusSideBox
		{
			get
			{
				return this._statusSideBox;
			}
			set
			{
				if ((_statusSideBox != value))
				{
					this.OnStatusSideBoxChanging(value);
					this.SendPropertyChanging();
					this._statusSideBox = value;
					this.SendPropertyChanged("StatusSideBox");
					this.OnStatusSideBoxChanged();
				}
			}
		}
		
		[Column(Storage="_statusToC", Name="status_toc", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int StatusToC
		{
			get
			{
				return this._statusToC;
			}
			set
			{
				if ((_statusToC != value))
				{
					this.OnStatusToCChanging(value);
					this.SendPropertyChanging();
					this._statusToC = value;
					this.SendPropertyChanged("StatusToC");
					this.OnStatusToCChanged();
				}
			}
		}
		
		[Column(Storage="_toCcHapter", Name="toc_chapter", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ToCChapter
		{
			get
			{
				return this._toCcHapter;
			}
			set
			{
				if ((_toCcHapter != value))
				{
					this.OnToCChapterChanging(value);
					this.SendPropertyChanging();
					this._toCcHapter = value;
					this.SendPropertyChanged("ToCChapter");
					this.OnToCChapterChanged();
				}
			}
		}
		
		[Column(Storage="_toCsOrtOrder", Name="toc_sort_order", DbType="int(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ToCSortOrder
		{
			get
			{
				return this._toCsOrtOrder;
			}
			set
			{
				if ((_toCsOrtOrder != value))
				{
					this.OnToCSortOrderChanging(value);
					this.SendPropertyChanging();
					this._toCsOrtOrder = value;
					this.SendPropertyChanged("ToCSortOrder");
					this.OnToCSortOrderChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.featured")]
	public partial class Featured : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateStatusChange;
		
		private System.DateTime _expiresDate;
		
		private System.Nullable<System.DateTime> _featuredDateAdded;
		
		private System.DateTime _featuredDateAvailable;
		
		private int _featuredID;
		
		private System.Nullable<System.DateTime> _featuredLastModified;
		
		private int _productsID;
		
		private int _status;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateStatusChangeChanged();
		
		partial void OnDateStatusChangeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnExpiresDateChanged();
		
		partial void OnExpiresDateChanging(System.DateTime value);
		
		partial void OnFeaturedDateAddedChanged();
		
		partial void OnFeaturedDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnFeaturedDateAvailableChanged();
		
		partial void OnFeaturedDateAvailableChanging(System.DateTime value);
		
		partial void OnFeaturedIDChanged();
		
		partial void OnFeaturedIDChanging(int value);
		
		partial void OnFeaturedLastModifiedChanged();
		
		partial void OnFeaturedLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(int value);
		#endregion
		
		
		public Featured()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateStatusChange", Name="date_status_change", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateStatusChange
		{
			get
			{
				return this._dateStatusChange;
			}
			set
			{
				if ((_dateStatusChange != value))
				{
					this.OnDateStatusChangeChanging(value);
					this.SendPropertyChanging();
					this._dateStatusChange = value;
					this.SendPropertyChanged("DateStatusChange");
					this.OnDateStatusChangeChanged();
				}
			}
		}
		
		[Column(Storage="_expiresDate", Name="expires_date", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExpiresDate
		{
			get
			{
				return this._expiresDate;
			}
			set
			{
				if ((_expiresDate != value))
				{
					this.OnExpiresDateChanging(value);
					this.SendPropertyChanging();
					this._expiresDate = value;
					this.SendPropertyChanged("ExpiresDate");
					this.OnExpiresDateChanged();
				}
			}
		}
		
		[Column(Storage="_featuredDateAdded", Name="featured_date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> FeaturedDateAdded
		{
			get
			{
				return this._featuredDateAdded;
			}
			set
			{
				if ((_featuredDateAdded != value))
				{
					this.OnFeaturedDateAddedChanging(value);
					this.SendPropertyChanging();
					this._featuredDateAdded = value;
					this.SendPropertyChanged("FeaturedDateAdded");
					this.OnFeaturedDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_featuredDateAvailable", Name="featured_date_available", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime FeaturedDateAvailable
		{
			get
			{
				return this._featuredDateAvailable;
			}
			set
			{
				if ((_featuredDateAvailable != value))
				{
					this.OnFeaturedDateAvailableChanging(value);
					this.SendPropertyChanging();
					this._featuredDateAvailable = value;
					this.SendPropertyChanged("FeaturedDateAvailable");
					this.OnFeaturedDateAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_featuredID", Name="featured_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FeaturedID
		{
			get
			{
				return this._featuredID;
			}
			set
			{
				if ((_featuredID != value))
				{
					this.OnFeaturedIDChanging(value);
					this.SendPropertyChanging();
					this._featuredID = value;
					this.SendPropertyChanged("FeaturedID");
					this.OnFeaturedIDChanged();
				}
			}
		}
		
		[Column(Storage="_featuredLastModified", Name="featured_last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> FeaturedLastModified
		{
			get
			{
				return this._featuredLastModified;
			}
			set
			{
				if ((_featuredLastModified != value))
				{
					this.OnFeaturedLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._featuredLastModified = value;
					this.SendPropertyChanged("FeaturedLastModified");
					this.OnFeaturedLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.files_uploaded")]
	public partial class FilesUploadEd : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _customersID;
		
		private int _filesUploadEdID;
		
		private string _filesUploadEdName;
		
		private string _seSSkEy;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(System.Nullable<int> value);
		
		partial void OnFilesUploadEdIDChanged();
		
		partial void OnFilesUploadEdIDChanging(int value);
		
		partial void OnFilesUploadEdNameChanged();
		
		partial void OnFilesUploadEdNameChanging(string value);
		
		partial void OnSEsSKeyChanged();
		
		partial void OnSEsSKeyChanging(string value);
		#endregion
		
		
		public FilesUploadEd()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_filesUploadEdID", Name="files_uploaded_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int FilesUploadEdID
		{
			get
			{
				return this._filesUploadEdID;
			}
			set
			{
				if ((_filesUploadEdID != value))
				{
					this.OnFilesUploadEdIDChanging(value);
					this.SendPropertyChanging();
					this._filesUploadEdID = value;
					this.SendPropertyChanged("FilesUploadEdID");
					this.OnFilesUploadEdIDChanged();
				}
			}
		}
		
		[Column(Storage="_filesUploadEdName", Name="files_uploaded_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FilesUploadEdName
		{
			get
			{
				return this._filesUploadEdName;
			}
			set
			{
				if (((_filesUploadEdName == value) 
							== false))
				{
					this.OnFilesUploadEdNameChanging(value);
					this.SendPropertyChanging();
					this._filesUploadEdName = value;
					this.SendPropertyChanged("FilesUploadEdName");
					this.OnFilesUploadEdNameChanged();
				}
			}
		}
		
		[Column(Storage="_seSSkEy", Name="sesskey", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SEsSKey
		{
			get
			{
				return this._seSSkEy;
			}
			set
			{
				if (((_seSSkEy == value) 
							== false))
				{
					this.OnSEsSKeyChanging(value);
					this.SendPropertyChanging();
					this._seSSkEy = value;
					this.SendPropertyChanged("SEsSKey");
					this.OnSEsSKeyChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.geo_zones")]
	public partial class GeOZones : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private string _geOzOneDescription;
		
		private int _geOzOneID;
		
		private string _geOzOneName;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnGeOZoneDescriptionChanged();
		
		partial void OnGeOZoneDescriptionChanging(string value);
		
		partial void OnGeOZoneIDChanged();
		
		partial void OnGeOZoneIDChanging(int value);
		
		partial void OnGeOZoneNameChanged();
		
		partial void OnGeOZoneNameChanging(string value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public GeOZones()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_geOzOneDescription", Name="geo_zone_description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GeOZoneDescription
		{
			get
			{
				return this._geOzOneDescription;
			}
			set
			{
				if (((_geOzOneDescription == value) 
							== false))
				{
					this.OnGeOZoneDescriptionChanging(value);
					this.SendPropertyChanging();
					this._geOzOneDescription = value;
					this.SendPropertyChanged("GeOZoneDescription");
					this.OnGeOZoneDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_geOzOneID", Name="geo_zone_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int GeOZoneID
		{
			get
			{
				return this._geOzOneID;
			}
			set
			{
				if ((_geOzOneID != value))
				{
					this.OnGeOZoneIDChanging(value);
					this.SendPropertyChanging();
					this._geOzOneID = value;
					this.SendPropertyChanged("GeOZoneID");
					this.OnGeOZoneIDChanged();
				}
			}
		}
		
		[Column(Storage="_geOzOneName", Name="geo_zone_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GeOZoneName
		{
			get
			{
				return this._geOzOneName;
			}
			set
			{
				if (((_geOzOneName == value) 
							== false))
				{
					this.OnGeOZoneNameChanging(value);
					this.SendPropertyChanging();
					this._geOzOneName = value;
					this.SendPropertyChanged("GeOZoneName");
					this.OnGeOZoneNameChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.get_terms_to_filter")]
	public partial class GetTermsToFilter : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _getTermName;
		
		private string _getTermNameField;
		
		private string _getTermTable;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnGetTermNameChanged();
		
		partial void OnGetTermNameChanging(string value);
		
		partial void OnGetTermNameFieldChanged();
		
		partial void OnGetTermNameFieldChanging(string value);
		
		partial void OnGetTermTableChanged();
		
		partial void OnGetTermTableChanging(string value);
		#endregion
		
		
		public GetTermsToFilter()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_getTermName", Name="get_term_name", DbType="varchar(255)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GetTermName
		{
			get
			{
				return this._getTermName;
			}
			set
			{
				if (((_getTermName == value) 
							== false))
				{
					this.OnGetTermNameChanging(value);
					this.SendPropertyChanging();
					this._getTermName = value;
					this.SendPropertyChanged("GetTermName");
					this.OnGetTermNameChanged();
				}
			}
		}
		
		[Column(Storage="_getTermNameField", Name="get_term_name_field", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GetTermNameField
		{
			get
			{
				return this._getTermNameField;
			}
			set
			{
				if (((_getTermNameField == value) 
							== false))
				{
					this.OnGetTermNameFieldChanging(value);
					this.SendPropertyChanging();
					this._getTermNameField = value;
					this.SendPropertyChanged("GetTermNameField");
					this.OnGetTermNameFieldChanged();
				}
			}
		}
		
		[Column(Storage="_getTermTable", Name="get_term_table", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GetTermTable
		{
			get
			{
				return this._getTermTable;
			}
			set
			{
				if (((_getTermTable == value) 
							== false))
				{
					this.OnGetTermTableChanging(value);
					this.SendPropertyChanging();
					this._getTermTable = value;
					this.SendPropertyChanged("GetTermTable");
					this.OnGetTermTableChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.group_pricing")]
	public partial class GroupPricing : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private int _groupID;
		
		private string _groupName;
		
		private decimal _groupPercentage;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnGroupIDChanged();
		
		partial void OnGroupIDChanging(int value);
		
		partial void OnGroupNameChanged();
		
		partial void OnGroupNameChanging(string value);
		
		partial void OnGroupPercentageChanged();
		
		partial void OnGroupPercentageChanging(decimal value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public GroupPricing()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_groupID", Name="group_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int GroupID
		{
			get
			{
				return this._groupID;
			}
			set
			{
				if ((_groupID != value))
				{
					this.OnGroupIDChanging(value);
					this.SendPropertyChanging();
					this._groupID = value;
					this.SendPropertyChanged("GroupID");
					this.OnGroupIDChanged();
				}
			}
		}
		
		[Column(Storage="_groupName", Name="group_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string GroupName
		{
			get
			{
				return this._groupName;
			}
			set
			{
				if (((_groupName == value) 
							== false))
				{
					this.OnGroupNameChanging(value);
					this.SendPropertyChanging();
					this._groupName = value;
					this.SendPropertyChanged("GroupName");
					this.OnGroupNameChanged();
				}
			}
		}
		
		[Column(Storage="_groupPercentage", Name="group_percentage", DbType="decimal(5,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal GroupPercentage
		{
			get
			{
				return this._groupPercentage;
			}
			set
			{
				if ((_groupPercentage != value))
				{
					this.OnGroupPercentageChanging(value);
					this.SendPropertyChanging();
					this._groupPercentage = value;
					this.SendPropertyChanged("GroupPercentage");
					this.OnGroupPercentageChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.languages")]
	public partial class Languages : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _code;
		
		private string _directory;
		
		private string _image;
		
		private int _languagesID;
		
		private string _name;
		
		private System.Nullable<int> _sortOrder;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCodeChanged();
		
		partial void OnCodeChanging(string value);
		
		partial void OnDirectoryChanged();
		
		partial void OnDirectoryChanging(string value);
		
		partial void OnImageChanged();
		
		partial void OnImageChanging(string value);
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(System.Nullable<int> value);
		#endregion
		
		
		public Languages()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_code", Name="code", DbType="char(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Code
		{
			get
			{
				return this._code;
			}
			set
			{
				if (((_code == value) 
							== false))
				{
					this.OnCodeChanging(value);
					this.SendPropertyChanging();
					this._code = value;
					this.SendPropertyChanged("Code");
					this.OnCodeChanged();
				}
			}
		}
		
		[Column(Storage="_directory", Name="directory", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Directory
		{
			get
			{
				return this._directory;
			}
			set
			{
				if (((_directory == value) 
							== false))
				{
					this.OnDirectoryChanging(value);
					this.SendPropertyChanging();
					this._directory = value;
					this.SendPropertyChanged("Directory");
					this.OnDirectoryChanged();
				}
			}
		}
		
		[Column(Storage="_image", Name="image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Image
		{
			get
			{
				return this._image;
			}
			set
			{
				if (((_image == value) 
							== false))
				{
					this.OnImageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("Image");
					this.OnImageChanged();
				}
			}
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int(3)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.layout_boxes")]
	public partial class LayoutBoxes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _layoutBoxLocation;
		
		private string _layoutBoxName;
		
		private int _layoutBoxSortOrder;
		
		private int _layoutBoxSortOrderSingle;
		
		private sbyte _layoutBoxStatus;
		
		private sbyte _layoutBoxStatusSingle;
		
		private int _layoutID;
		
		private string _layoutTemplate;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLayoutBoxLocationChanged();
		
		partial void OnLayoutBoxLocationChanging(sbyte value);
		
		partial void OnLayoutBoxNameChanged();
		
		partial void OnLayoutBoxNameChanging(string value);
		
		partial void OnLayoutBoxSortOrderChanged();
		
		partial void OnLayoutBoxSortOrderChanging(int value);
		
		partial void OnLayoutBoxSortOrderSingleChanged();
		
		partial void OnLayoutBoxSortOrderSingleChanging(int value);
		
		partial void OnLayoutBoxStatusChanged();
		
		partial void OnLayoutBoxStatusChanging(sbyte value);
		
		partial void OnLayoutBoxStatusSingleChanged();
		
		partial void OnLayoutBoxStatusSingleChanging(sbyte value);
		
		partial void OnLayoutIDChanged();
		
		partial void OnLayoutIDChanging(int value);
		
		partial void OnLayoutTemplateChanged();
		
		partial void OnLayoutTemplateChanging(string value);
		#endregion
		
		
		public LayoutBoxes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_layoutBoxLocation", Name="layout_box_location", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte LayoutBoxLocation
		{
			get
			{
				return this._layoutBoxLocation;
			}
			set
			{
				if ((_layoutBoxLocation != value))
				{
					this.OnLayoutBoxLocationChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxLocation = value;
					this.SendPropertyChanged("LayoutBoxLocation");
					this.OnLayoutBoxLocationChanged();
				}
			}
		}
		
		[Column(Storage="_layoutBoxName", Name="layout_box_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LayoutBoxName
		{
			get
			{
				return this._layoutBoxName;
			}
			set
			{
				if (((_layoutBoxName == value) 
							== false))
				{
					this.OnLayoutBoxNameChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxName = value;
					this.SendPropertyChanged("LayoutBoxName");
					this.OnLayoutBoxNameChanged();
				}
			}
		}
		
		[Column(Storage="_layoutBoxSortOrder", Name="layout_box_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LayoutBoxSortOrder
		{
			get
			{
				return this._layoutBoxSortOrder;
			}
			set
			{
				if ((_layoutBoxSortOrder != value))
				{
					this.OnLayoutBoxSortOrderChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxSortOrder = value;
					this.SendPropertyChanged("LayoutBoxSortOrder");
					this.OnLayoutBoxSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_layoutBoxSortOrderSingle", Name="layout_box_sort_order_single", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LayoutBoxSortOrderSingle
		{
			get
			{
				return this._layoutBoxSortOrderSingle;
			}
			set
			{
				if ((_layoutBoxSortOrderSingle != value))
				{
					this.OnLayoutBoxSortOrderSingleChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxSortOrderSingle = value;
					this.SendPropertyChanged("LayoutBoxSortOrderSingle");
					this.OnLayoutBoxSortOrderSingleChanged();
				}
			}
		}
		
		[Column(Storage="_layoutBoxStatus", Name="layout_box_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte LayoutBoxStatus
		{
			get
			{
				return this._layoutBoxStatus;
			}
			set
			{
				if ((_layoutBoxStatus != value))
				{
					this.OnLayoutBoxStatusChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxStatus = value;
					this.SendPropertyChanged("LayoutBoxStatus");
					this.OnLayoutBoxStatusChanged();
				}
			}
		}
		
		[Column(Storage="_layoutBoxStatusSingle", Name="layout_box_status_single", DbType="tinyint(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte LayoutBoxStatusSingle
		{
			get
			{
				return this._layoutBoxStatusSingle;
			}
			set
			{
				if ((_layoutBoxStatusSingle != value))
				{
					this.OnLayoutBoxStatusSingleChanging(value);
					this.SendPropertyChanging();
					this._layoutBoxStatusSingle = value;
					this.SendPropertyChanged("LayoutBoxStatusSingle");
					this.OnLayoutBoxStatusSingleChanged();
				}
			}
		}
		
		[Column(Storage="_layoutID", Name="layout_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LayoutID
		{
			get
			{
				return this._layoutID;
			}
			set
			{
				if ((_layoutID != value))
				{
					this.OnLayoutIDChanging(value);
					this.SendPropertyChanging();
					this._layoutID = value;
					this.SendPropertyChanged("LayoutID");
					this.OnLayoutIDChanged();
				}
			}
		}
		
		[Column(Storage="_layoutTemplate", Name="layout_template", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LayoutTemplate
		{
			get
			{
				return this._layoutTemplate;
			}
			set
			{
				if (((_layoutTemplate == value) 
							== false))
				{
					this.OnLayoutTemplateChanging(value);
					this.SendPropertyChanging();
					this._layoutTemplate = value;
					this.SendPropertyChanged("LayoutTemplate");
					this.OnLayoutTemplateChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.manufacturers")]
	public partial class Manufacturers : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _manufacturersID;
		
		private string _manufacturersImage;
		
		private string _manufacturersName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnManufacturersIDChanged();
		
		partial void OnManufacturersIDChanging(int value);
		
		partial void OnManufacturersImageChanged();
		
		partial void OnManufacturersImageChanging(string value);
		
		partial void OnManufacturersNameChanged();
		
		partial void OnManufacturersNameChanging(string value);
		#endregion
		
		
		public Manufacturers()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_manufacturersID", Name="manufacturers_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ManufacturersID
		{
			get
			{
				return this._manufacturersID;
			}
			set
			{
				if ((_manufacturersID != value))
				{
					this.OnManufacturersIDChanging(value);
					this.SendPropertyChanging();
					this._manufacturersID = value;
					this.SendPropertyChanged("ManufacturersID");
					this.OnManufacturersIDChanged();
				}
			}
		}
		
		[Column(Storage="_manufacturersImage", Name="manufacturers_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ManufacturersImage
		{
			get
			{
				return this._manufacturersImage;
			}
			set
			{
				if (((_manufacturersImage == value) 
							== false))
				{
					this.OnManufacturersImageChanging(value);
					this.SendPropertyChanging();
					this._manufacturersImage = value;
					this.SendPropertyChanged("ManufacturersImage");
					this.OnManufacturersImageChanged();
				}
			}
		}
		
		[Column(Storage="_manufacturersName", Name="manufacturers_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ManufacturersName
		{
			get
			{
				return this._manufacturersName;
			}
			set
			{
				if (((_manufacturersName == value) 
							== false))
				{
					this.OnManufacturersNameChanging(value);
					this.SendPropertyChanging();
					this._manufacturersName = value;
					this.SendPropertyChanged("ManufacturersName");
					this.OnManufacturersNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.manufacturers_info")]
	public partial class ManufacturersInfo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateLastClick;
		
		private int _languagesID;
		
		private int _manufacturersID;
		
		private string _manufacturersUrl;
		
		private int _urlcLicked;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateLastClickChanged();
		
		partial void OnDateLastClickChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnManufacturersIDChanged();
		
		partial void OnManufacturersIDChanging(int value);
		
		partial void OnManufacturersURLChanged();
		
		partial void OnManufacturersURLChanging(string value);
		
		partial void OnURLClickedChanged();
		
		partial void OnURLClickedChanging(int value);
		#endregion
		
		
		public ManufacturersInfo()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateLastClick", Name="date_last_click", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateLastClick
		{
			get
			{
				return this._dateLastClick;
			}
			set
			{
				if ((_dateLastClick != value))
				{
					this.OnDateLastClickChanging(value);
					this.SendPropertyChanging();
					this._dateLastClick = value;
					this.SendPropertyChanged("DateLastClick");
					this.OnDateLastClickChanged();
				}
			}
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_manufacturersID", Name="manufacturers_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ManufacturersID
		{
			get
			{
				return this._manufacturersID;
			}
			set
			{
				if ((_manufacturersID != value))
				{
					this.OnManufacturersIDChanging(value);
					this.SendPropertyChanging();
					this._manufacturersID = value;
					this.SendPropertyChanged("ManufacturersID");
					this.OnManufacturersIDChanged();
				}
			}
		}
		
		[Column(Storage="_manufacturersUrl", Name="manufacturers_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ManufacturersURL
		{
			get
			{
				return this._manufacturersUrl;
			}
			set
			{
				if (((_manufacturersUrl == value) 
							== false))
				{
					this.OnManufacturersURLChanging(value);
					this.SendPropertyChanging();
					this._manufacturersUrl = value;
					this.SendPropertyChanged("ManufacturersURL");
					this.OnManufacturersURLChanged();
				}
			}
		}
		
		[Column(Storage="_urlcLicked", Name="url_clicked", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int URLClicked
		{
			get
			{
				return this._urlcLicked;
			}
			set
			{
				if ((_urlcLicked != value))
				{
					this.OnURLClickedChanging(value);
					this.SendPropertyChanging();
					this._urlcLicked = value;
					this.SendPropertyChanged("URLClicked");
					this.OnURLClickedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.media_clips")]
	public partial class MediaClips : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _clipFilename;
		
		private int _clipID;
		
		private short _clipType;
		
		private System.DateTime _dateAdded;
		
		private System.DateTime _lastModified;
		
		private int _mediaID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnClipFilenameChanged();
		
		partial void OnClipFilenameChanging(string value);
		
		partial void OnClipIDChanged();
		
		partial void OnClipIDChanging(int value);
		
		partial void OnClipTypeChanged();
		
		partial void OnClipTypeChanging(short value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.DateTime value);
		
		partial void OnMediaIDChanged();
		
		partial void OnMediaIDChanging(int value);
		#endregion
		
		
		public MediaClips()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_clipFilename", Name="clip_filename", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ClipFilename
		{
			get
			{
				return this._clipFilename;
			}
			set
			{
				if (((_clipFilename == value) 
							== false))
				{
					this.OnClipFilenameChanging(value);
					this.SendPropertyChanging();
					this._clipFilename = value;
					this.SendPropertyChanged("ClipFilename");
					this.OnClipFilenameChanged();
				}
			}
		}
		
		[Column(Storage="_clipID", Name="clip_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ClipID
		{
			get
			{
				return this._clipID;
			}
			set
			{
				if ((_clipID != value))
				{
					this.OnClipIDChanging(value);
					this.SendPropertyChanging();
					this._clipID = value;
					this.SendPropertyChanged("ClipID");
					this.OnClipIDChanged();
				}
			}
		}
		
		[Column(Storage="_clipType", Name="clip_type", DbType="smallint(6)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public short ClipType
		{
			get
			{
				return this._clipType;
			}
			set
			{
				if ((_clipType != value))
				{
					this.OnClipTypeChanging(value);
					this.SendPropertyChanging();
					this._clipType = value;
					this.SendPropertyChanged("ClipType");
					this.OnClipTypeChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_mediaID", Name="media_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MediaID
		{
			get
			{
				return this._mediaID;
			}
			set
			{
				if ((_mediaID != value))
				{
					this.OnMediaIDChanging(value);
					this.SendPropertyChanging();
					this._mediaID = value;
					this.SendPropertyChanged("MediaID");
					this.OnMediaIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.media_manager")]
	public partial class MediaManager : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private System.DateTime _lastModified;
		
		private int _mediaID;
		
		private string _mediaName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.DateTime value);
		
		partial void OnMediaIDChanged();
		
		partial void OnMediaIDChanging(int value);
		
		partial void OnMediaNameChanged();
		
		partial void OnMediaNameChanging(string value);
		#endregion
		
		
		public MediaManager()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_mediaID", Name="media_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MediaID
		{
			get
			{
				return this._mediaID;
			}
			set
			{
				if ((_mediaID != value))
				{
					this.OnMediaIDChanging(value);
					this.SendPropertyChanging();
					this._mediaID = value;
					this.SendPropertyChanged("MediaID");
					this.OnMediaIDChanged();
				}
			}
		}
		
		[Column(Storage="_mediaName", Name="media_name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string MediaName
		{
			get
			{
				return this._mediaName;
			}
			set
			{
				if (((_mediaName == value) 
							== false))
				{
					this.OnMediaNameChanging(value);
					this.SendPropertyChanging();
					this._mediaName = value;
					this.SendPropertyChanged("MediaName");
					this.OnMediaNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.media_to_products")]
	public partial class MediaToProducts
	{
		
		private int _mediaID;
		
		private int _productID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnMediaIDChanged();
		
		partial void OnMediaIDChanging(int value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(int value);
		#endregion
		
		
		public MediaToProducts()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_mediaID", Name="media_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MediaID
		{
			get
			{
				return this._mediaID;
			}
			set
			{
				if ((_mediaID != value))
				{
					this.OnMediaIDChanging(value);
					this._mediaID = value;
					this.OnMediaIDChanged();
				}
			}
		}
		
		[Column(Storage="_productID", Name="product_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this._productID = value;
					this.OnProductIDChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.media_types")]
	public partial class MediaTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _typeExT;
		
		private int _typeID;
		
		private string _typeName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnTypeExTChanged();
		
		partial void OnTypeExTChanging(string value);
		
		partial void OnTypeIDChanged();
		
		partial void OnTypeIDChanging(int value);
		
		partial void OnTypeNameChanged();
		
		partial void OnTypeNameChanging(string value);
		#endregion
		
		
		public MediaTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_typeExT", Name="type_ext", DbType="varchar(8)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TypeExT
		{
			get
			{
				return this._typeExT;
			}
			set
			{
				if (((_typeExT == value) 
							== false))
				{
					this.OnTypeExTChanging(value);
					this.SendPropertyChanging();
					this._typeExT = value;
					this.SendPropertyChanged("TypeExT");
					this.OnTypeExTChanged();
				}
			}
		}
		
		[Column(Storage="_typeID", Name="type_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TypeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((_typeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_typeName", Name="type_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TypeName
		{
			get
			{
				return this._typeName;
			}
			set
			{
				if (((_typeName == value) 
							== false))
				{
					this.OnTypeNameChanging(value);
					this.SendPropertyChanging();
					this._typeName = value;
					this.SendPropertyChanged("TypeName");
					this.OnTypeNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.meta_tags")]
	public partial class MetaTags : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private string _metaTagsDescription;
		
		private int _metaTagsID;
		
		private string _metaTagsKeywords;
		
		private string _metaTagsTitle;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnMetaTagsDescriptionChanged();
		
		partial void OnMetaTagsDescriptionChanging(string value);
		
		partial void OnMetaTagsIDChanged();
		
		partial void OnMetaTagsIDChanging(int value);
		
		partial void OnMetaTagsKeywordsChanged();
		
		partial void OnMetaTagsKeywordsChanging(string value);
		
		partial void OnMetaTagsTitleChanged();
		
		partial void OnMetaTagsTitleChanging(string value);
		#endregion
		
		
		public MetaTags()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsDescription", Name="metatags_description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsDescription
		{
			get
			{
				return this._metaTagsDescription;
			}
			set
			{
				if (((_metaTagsDescription == value) 
							== false))
				{
					this.OnMetaTagsDescriptionChanging(value);
					this.SendPropertyChanging();
					this._metaTagsDescription = value;
					this.SendPropertyChanged("MetaTagsDescription");
					this.OnMetaTagsDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsID", Name="meta_tags_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MetaTagsID
		{
			get
			{
				return this._metaTagsID;
			}
			set
			{
				if ((_metaTagsID != value))
				{
					this.OnMetaTagsIDChanging(value);
					this.SendPropertyChanging();
					this._metaTagsID = value;
					this.SendPropertyChanged("MetaTagsID");
					this.OnMetaTagsIDChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsKeywords", Name="metatags_keywords", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsKeywords
		{
			get
			{
				return this._metaTagsKeywords;
			}
			set
			{
				if (((_metaTagsKeywords == value) 
							== false))
				{
					this.OnMetaTagsKeywordsChanging(value);
					this.SendPropertyChanging();
					this._metaTagsKeywords = value;
					this.SendPropertyChanged("MetaTagsKeywords");
					this.OnMetaTagsKeywordsChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsTitle", Name="metatags_title", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string MetaTagsTitle
		{
			get
			{
				return this._metaTagsTitle;
			}
			set
			{
				if (((_metaTagsTitle == value) 
							== false))
				{
					this.OnMetaTagsTitleChanging(value);
					this.SendPropertyChanging();
					this._metaTagsTitle = value;
					this.SendPropertyChanged("MetaTagsTitle");
					this.OnMetaTagsTitleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.meta_tags_categories_description")]
	public partial class MetaTagsCategoriesDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _categoriesID;
		
		private int _languageID;
		
		private string _metaTagsDescription;
		
		private string _metaTagsKeywords;
		
		private string _metaTagsTitle;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoriesIDChanged();
		
		partial void OnCategoriesIDChanging(int value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnMetaTagsDescriptionChanged();
		
		partial void OnMetaTagsDescriptionChanging(string value);
		
		partial void OnMetaTagsKeywordsChanged();
		
		partial void OnMetaTagsKeywordsChanging(string value);
		
		partial void OnMetaTagsTitleChanged();
		
		partial void OnMetaTagsTitleChanging(string value);
		#endregion
		
		
		public MetaTagsCategoriesDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoriesID", Name="categories_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoriesID
		{
			get
			{
				return this._categoriesID;
			}
			set
			{
				if ((_categoriesID != value))
				{
					this.OnCategoriesIDChanging(value);
					this.SendPropertyChanging();
					this._categoriesID = value;
					this.SendPropertyChanged("CategoriesID");
					this.OnCategoriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsDescription", Name="metatags_description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsDescription
		{
			get
			{
				return this._metaTagsDescription;
			}
			set
			{
				if (((_metaTagsDescription == value) 
							== false))
				{
					this.OnMetaTagsDescriptionChanging(value);
					this.SendPropertyChanging();
					this._metaTagsDescription = value;
					this.SendPropertyChanged("MetaTagsDescription");
					this.OnMetaTagsDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsKeywords", Name="metatags_keywords", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsKeywords
		{
			get
			{
				return this._metaTagsKeywords;
			}
			set
			{
				if (((_metaTagsKeywords == value) 
							== false))
				{
					this.OnMetaTagsKeywordsChanging(value);
					this.SendPropertyChanging();
					this._metaTagsKeywords = value;
					this.SendPropertyChanged("MetaTagsKeywords");
					this.OnMetaTagsKeywordsChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsTitle", Name="metatags_title", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string MetaTagsTitle
		{
			get
			{
				return this._metaTagsTitle;
			}
			set
			{
				if (((_metaTagsTitle == value) 
							== false))
				{
					this.OnMetaTagsTitleChanging(value);
					this.SendPropertyChanging();
					this._metaTagsTitle = value;
					this.SendPropertyChanged("MetaTagsTitle");
					this.OnMetaTagsTitleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.meta_tags_products_description")]
	public partial class MetaTagsProductsDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private string _metaTagsDescription;
		
		private string _metaTagsKeywords;
		
		private string _metaTagsTitle;
		
		private int _productsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnMetaTagsDescriptionChanged();
		
		partial void OnMetaTagsDescriptionChanging(string value);
		
		partial void OnMetaTagsKeywordsChanged();
		
		partial void OnMetaTagsKeywordsChanging(string value);
		
		partial void OnMetaTagsTitleChanged();
		
		partial void OnMetaTagsTitleChanging(string value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		#endregion
		
		
		public MetaTagsProductsDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsDescription", Name="metatags_description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsDescription
		{
			get
			{
				return this._metaTagsDescription;
			}
			set
			{
				if (((_metaTagsDescription == value) 
							== false))
				{
					this.OnMetaTagsDescriptionChanging(value);
					this.SendPropertyChanging();
					this._metaTagsDescription = value;
					this.SendPropertyChanged("MetaTagsDescription");
					this.OnMetaTagsDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsKeywords", Name="metatags_keywords", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string MetaTagsKeywords
		{
			get
			{
				return this._metaTagsKeywords;
			}
			set
			{
				if (((_metaTagsKeywords == value) 
							== false))
				{
					this.OnMetaTagsKeywordsChanging(value);
					this.SendPropertyChanging();
					this._metaTagsKeywords = value;
					this.SendPropertyChanged("MetaTagsKeywords");
					this.OnMetaTagsKeywordsChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsTitle", Name="metatags_title", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string MetaTagsTitle
		{
			get
			{
				return this._metaTagsTitle;
			}
			set
			{
				if (((_metaTagsTitle == value) 
							== false))
				{
					this.OnMetaTagsTitleChanging(value);
					this.SendPropertyChanging();
					this._metaTagsTitle = value;
					this.SendPropertyChanged("MetaTagsTitle");
					this.OnMetaTagsTitleChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.music_genre")]
	public partial class MusicGenre : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _musicGenreID;
		
		private string _musicGenreName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnMusicGenreIDChanged();
		
		partial void OnMusicGenreIDChanging(int value);
		
		partial void OnMusicGenreNameChanged();
		
		partial void OnMusicGenreNameChanging(string value);
		#endregion
		
		
		public MusicGenre()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_musicGenreID", Name="music_genre_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MusicGenreID
		{
			get
			{
				return this._musicGenreID;
			}
			set
			{
				if ((_musicGenreID != value))
				{
					this.OnMusicGenreIDChanging(value);
					this.SendPropertyChanging();
					this._musicGenreID = value;
					this.SendPropertyChanged("MusicGenreID");
					this.OnMusicGenreIDChanged();
				}
			}
		}
		
		[Column(Storage="_musicGenreName", Name="music_genre_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string MusicGenreName
		{
			get
			{
				return this._musicGenreName;
			}
			set
			{
				if (((_musicGenreName == value) 
							== false))
				{
					this.OnMusicGenreNameChanging(value);
					this.SendPropertyChanging();
					this._musicGenreName = value;
					this.SendPropertyChanged("MusicGenreName");
					this.OnMusicGenreNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.newsletters")]
	public partial class Newsletters : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _content;
		
		private string _contentHtml;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _dateSent;
		
		private System.Nullable<int> _locked;
		
		private string _module;
		
		private int _newslettersID;
		
		private System.Nullable<int> _status;
		
		private string _title;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnContentChanged();
		
		partial void OnContentChanging(string value);
		
		partial void OnContentHTMLChanged();
		
		partial void OnContentHTMLChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnDateSentChanged();
		
		partial void OnDateSentChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLockedChanged();
		
		partial void OnLockedChanging(System.Nullable<int> value);
		
		partial void OnModuleChanged();
		
		partial void OnModuleChanging(string value);
		
		partial void OnNewslettersIDChanged();
		
		partial void OnNewslettersIDChanging(int value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(System.Nullable<int> value);
		
		partial void OnTitleChanged();
		
		partial void OnTitleChanging(string value);
		#endregion
		
		
		public Newsletters()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_content", Name="content", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Content
		{
			get
			{
				return this._content;
			}
			set
			{
				if (((_content == value) 
							== false))
				{
					this.OnContentChanging(value);
					this.SendPropertyChanging();
					this._content = value;
					this.SendPropertyChanged("Content");
					this.OnContentChanged();
				}
			}
		}
		
		[Column(Storage="_contentHtml", Name="content_html", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ContentHTML
		{
			get
			{
				return this._contentHtml;
			}
			set
			{
				if (((_contentHtml == value) 
							== false))
				{
					this.OnContentHTMLChanging(value);
					this.SendPropertyChanging();
					this._contentHtml = value;
					this.SendPropertyChanged("ContentHTML");
					this.OnContentHTMLChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_dateSent", Name="date_sent", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateSent
		{
			get
			{
				return this._dateSent;
			}
			set
			{
				if ((_dateSent != value))
				{
					this.OnDateSentChanging(value);
					this.SendPropertyChanging();
					this._dateSent = value;
					this.SendPropertyChanged("DateSent");
					this.OnDateSentChanged();
				}
			}
		}
		
		[Column(Storage="_locked", Name="locked", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Locked
		{
			get
			{
				return this._locked;
			}
			set
			{
				if ((_locked != value))
				{
					this.OnLockedChanging(value);
					this.SendPropertyChanging();
					this._locked = value;
					this.SendPropertyChanged("Locked");
					this.OnLockedChanged();
				}
			}
		}
		
		[Column(Storage="_module", Name="module", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Module
		{
			get
			{
				return this._module;
			}
			set
			{
				if (((_module == value) 
							== false))
				{
					this.OnModuleChanging(value);
					this.SendPropertyChanging();
					this._module = value;
					this.SendPropertyChanged("Module");
					this.OnModuleChanged();
				}
			}
		}
		
		[Column(Storage="_newslettersID", Name="newsletters_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int NewslettersID
		{
			get
			{
				return this._newslettersID;
			}
			set
			{
				if ((_newslettersID != value))
				{
					this.OnNewslettersIDChanging(value);
					this.SendPropertyChanging();
					this._newslettersID = value;
					this.SendPropertyChanged("NewslettersID");
					this.OnNewslettersIDChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[Column(Storage="_title", Name="title", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value) 
							== false))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders")]
	public partial class Orders : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _billingAddressFormatID;
		
		private string _billingCity;
		
		private string _billingCompany;
		
		private string _billingCountry;
		
		private string _billingName;
		
		private string _billingPostCode;
		
		private string _billingState;
		
		private string _billingStreetAddress;
		
		private string _billingSuburb;
		
		private byte[] _ccCvV;
		
		private string _ccExpires;
		
		private string _ccNumber;
		
		private string _ccOwner;
		
		private string _ccType;
		
		private string _couponCode;
		
		private string _currency;
		
		private System.Nullable<decimal> _currencyValue;
		
		private int _customersAddressFormatID;
		
		private string _customersCity;
		
		private string _customersCompany;
		
		private string _customersCountry;
		
		private string _customersEmailAddress;
		
		private int _customersID;
		
		private string _customersName;
		
		private string _customersPostCode;
		
		private string _customersState;
		
		private string _customersStreetAddress;
		
		private string _customersSuburb;
		
		private string _customersTelephone;
		
		private System.Nullable<System.DateTime> _datePurchased;
		
		private int _deliveryAddressFormatID;
		
		private string _deliveryCity;
		
		private string _deliveryCompany;
		
		private string _deliveryCountry;
		
		private string _deliveryName;
		
		private string _deliveryPostCode;
		
		private string _deliveryState;
		
		private string _deliveryStreetAddress;
		
		private string _deliverySuburb;
		
		private string _ipaDdress;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private System.Nullable<System.DateTime> _ordersDateFinished;
		
		private int _ordersID;
		
		private int _ordersStatus;
		
		private System.Nullable<decimal> _orderTax;
		
		private System.Nullable<decimal> _orderTotal;
		
		private string _paymentMethod;
		
		private string _paymentModuleCode;
		
		private int _payPalIpnid;
		
		private string _shippingMethod;
		
		private string _shippingModuleCode;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBillingAddressFormatIDChanged();
		
		partial void OnBillingAddressFormatIDChanging(int value);
		
		partial void OnBillingCityChanged();
		
		partial void OnBillingCityChanging(string value);
		
		partial void OnBillingCompanyChanged();
		
		partial void OnBillingCompanyChanging(string value);
		
		partial void OnBillingCountryChanged();
		
		partial void OnBillingCountryChanging(string value);
		
		partial void OnBillingNameChanged();
		
		partial void OnBillingNameChanging(string value);
		
		partial void OnBillingPostCodeChanged();
		
		partial void OnBillingPostCodeChanging(string value);
		
		partial void OnBillingStateChanged();
		
		partial void OnBillingStateChanging(string value);
		
		partial void OnBillingStreetAddressChanged();
		
		partial void OnBillingStreetAddressChanging(string value);
		
		partial void OnBillingSuburbChanged();
		
		partial void OnBillingSuburbChanging(string value);
		
		partial void OnCcCvVChanged();
		
		partial void OnCcCvVChanging(byte[] value);
		
		partial void OnCcExpiresChanged();
		
		partial void OnCcExpiresChanging(string value);
		
		partial void OnCcNumberChanged();
		
		partial void OnCcNumberChanging(string value);
		
		partial void OnCcOwnerChanged();
		
		partial void OnCcOwnerChanging(string value);
		
		partial void OnCcTypeChanged();
		
		partial void OnCcTypeChanging(string value);
		
		partial void OnCouponCodeChanged();
		
		partial void OnCouponCodeChanging(string value);
		
		partial void OnCurrencyChanged();
		
		partial void OnCurrencyChanging(string value);
		
		partial void OnCurrencyValueChanged();
		
		partial void OnCurrencyValueChanging(System.Nullable<decimal> value);
		
		partial void OnCustomersAddressFormatIDChanged();
		
		partial void OnCustomersAddressFormatIDChanging(int value);
		
		partial void OnCustomersCityChanged();
		
		partial void OnCustomersCityChanging(string value);
		
		partial void OnCustomersCompanyChanged();
		
		partial void OnCustomersCompanyChanging(string value);
		
		partial void OnCustomersCountryChanged();
		
		partial void OnCustomersCountryChanging(string value);
		
		partial void OnCustomersEmailAddressChanged();
		
		partial void OnCustomersEmailAddressChanging(string value);
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnCustomersNameChanged();
		
		partial void OnCustomersNameChanging(string value);
		
		partial void OnCustomersPostCodeChanged();
		
		partial void OnCustomersPostCodeChanging(string value);
		
		partial void OnCustomersStateChanged();
		
		partial void OnCustomersStateChanging(string value);
		
		partial void OnCustomersStreetAddressChanged();
		
		partial void OnCustomersStreetAddressChanging(string value);
		
		partial void OnCustomersSuburbChanged();
		
		partial void OnCustomersSuburbChanging(string value);
		
		partial void OnCustomersTelephoneChanged();
		
		partial void OnCustomersTelephoneChanging(string value);
		
		partial void OnDatePurchasedChanged();
		
		partial void OnDatePurchasedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDeliveryAddressFormatIDChanged();
		
		partial void OnDeliveryAddressFormatIDChanging(int value);
		
		partial void OnDeliveryCityChanged();
		
		partial void OnDeliveryCityChanging(string value);
		
		partial void OnDeliveryCompanyChanged();
		
		partial void OnDeliveryCompanyChanging(string value);
		
		partial void OnDeliveryCountryChanged();
		
		partial void OnDeliveryCountryChanging(string value);
		
		partial void OnDeliveryNameChanged();
		
		partial void OnDeliveryNameChanging(string value);
		
		partial void OnDeliveryPostCodeChanged();
		
		partial void OnDeliveryPostCodeChanging(string value);
		
		partial void OnDeliveryStateChanged();
		
		partial void OnDeliveryStateChanging(string value);
		
		partial void OnDeliveryStreetAddressChanged();
		
		partial void OnDeliveryStreetAddressChanging(string value);
		
		partial void OnDeliverySuburbChanged();
		
		partial void OnDeliverySuburbChanging(string value);
		
		partial void OnIPAddressChanged();
		
		partial void OnIPAddressChanging(string value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnOrdersDateFinishedChanged();
		
		partial void OnOrdersDateFinishedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersStatusChanged();
		
		partial void OnOrdersStatusChanging(int value);
		
		partial void OnOrderTaxChanged();
		
		partial void OnOrderTaxChanging(System.Nullable<decimal> value);
		
		partial void OnOrderTotalChanged();
		
		partial void OnOrderTotalChanging(System.Nullable<decimal> value);
		
		partial void OnPaymentMethodChanged();
		
		partial void OnPaymentMethodChanging(string value);
		
		partial void OnPaymentModuleCodeChanged();
		
		partial void OnPaymentModuleCodeChanging(string value);
		
		partial void OnPayPalIPNIDChanged();
		
		partial void OnPayPalIPNIDChanging(int value);
		
		partial void OnShippingMethodChanged();
		
		partial void OnShippingMethodChanging(string value);
		
		partial void OnShippingModuleCodeChanged();
		
		partial void OnShippingModuleCodeChanging(string value);
		#endregion
		
		
		public Orders()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_billingAddressFormatID", Name="billing_address_format_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BillingAddressFormatID
		{
			get
			{
				return this._billingAddressFormatID;
			}
			set
			{
				if ((_billingAddressFormatID != value))
				{
					this.OnBillingAddressFormatIDChanging(value);
					this.SendPropertyChanging();
					this._billingAddressFormatID = value;
					this.SendPropertyChanged("BillingAddressFormatID");
					this.OnBillingAddressFormatIDChanged();
				}
			}
		}
		
		[Column(Storage="_billingCity", Name="billing_city", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BillingCity
		{
			get
			{
				return this._billingCity;
			}
			set
			{
				if (((_billingCity == value) 
							== false))
				{
					this.OnBillingCityChanging(value);
					this.SendPropertyChanging();
					this._billingCity = value;
					this.SendPropertyChanged("BillingCity");
					this.OnBillingCityChanged();
				}
			}
		}
		
		[Column(Storage="_billingCompany", Name="billing_company", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingCompany
		{
			get
			{
				return this._billingCompany;
			}
			set
			{
				if (((_billingCompany == value) 
							== false))
				{
					this.OnBillingCompanyChanging(value);
					this.SendPropertyChanging();
					this._billingCompany = value;
					this.SendPropertyChanged("BillingCompany");
					this.OnBillingCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_billingCountry", Name="billing_country", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BillingCountry
		{
			get
			{
				return this._billingCountry;
			}
			set
			{
				if (((_billingCountry == value) 
							== false))
				{
					this.OnBillingCountryChanging(value);
					this.SendPropertyChanging();
					this._billingCountry = value;
					this.SendPropertyChanged("BillingCountry");
					this.OnBillingCountryChanged();
				}
			}
		}
		
		[Column(Storage="_billingName", Name="billing_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BillingName
		{
			get
			{
				return this._billingName;
			}
			set
			{
				if (((_billingName == value) 
							== false))
				{
					this.OnBillingNameChanging(value);
					this.SendPropertyChanging();
					this._billingName = value;
					this.SendPropertyChanged("BillingName");
					this.OnBillingNameChanged();
				}
			}
		}
		
		[Column(Storage="_billingPostCode", Name="billing_postcode", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BillingPostCode
		{
			get
			{
				return this._billingPostCode;
			}
			set
			{
				if (((_billingPostCode == value) 
							== false))
				{
					this.OnBillingPostCodeChanging(value);
					this.SendPropertyChanging();
					this._billingPostCode = value;
					this.SendPropertyChanged("BillingPostCode");
					this.OnBillingPostCodeChanged();
				}
			}
		}
		
		[Column(Storage="_billingState", Name="billing_state", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingState
		{
			get
			{
				return this._billingState;
			}
			set
			{
				if (((_billingState == value) 
							== false))
				{
					this.OnBillingStateChanging(value);
					this.SendPropertyChanging();
					this._billingState = value;
					this.SendPropertyChanged("BillingState");
					this.OnBillingStateChanged();
				}
			}
		}
		
		[Column(Storage="_billingStreetAddress", Name="billing_street_address", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string BillingStreetAddress
		{
			get
			{
				return this._billingStreetAddress;
			}
			set
			{
				if (((_billingStreetAddress == value) 
							== false))
				{
					this.OnBillingStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._billingStreetAddress = value;
					this.SendPropertyChanged("BillingStreetAddress");
					this.OnBillingStreetAddressChanged();
				}
			}
		}
		
		[Column(Storage="_billingSuburb", Name="billing_suburb", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string BillingSuburb
		{
			get
			{
				return this._billingSuburb;
			}
			set
			{
				if (((_billingSuburb == value) 
							== false))
				{
					this.OnBillingSuburbChanging(value);
					this.SendPropertyChanging();
					this._billingSuburb = value;
					this.SendPropertyChanged("BillingSuburb");
					this.OnBillingSuburbChanged();
				}
			}
		}
		
		[Column(Storage="_ccCvV", Name="cc_cvv", DbType="blob", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public byte[] CcCvV
		{
			get
			{
				return this._ccCvV;
			}
			set
			{
				if (((_ccCvV == value) 
							== false))
				{
					this.OnCcCvVChanging(value);
					this.SendPropertyChanging();
					this._ccCvV = value;
					this.SendPropertyChanged("CcCvV");
					this.OnCcCvVChanged();
				}
			}
		}
		
		[Column(Storage="_ccExpires", Name="cc_expires", DbType="varchar(4)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CcExpires
		{
			get
			{
				return this._ccExpires;
			}
			set
			{
				if (((_ccExpires == value) 
							== false))
				{
					this.OnCcExpiresChanging(value);
					this.SendPropertyChanging();
					this._ccExpires = value;
					this.SendPropertyChanged("CcExpires");
					this.OnCcExpiresChanged();
				}
			}
		}
		
		[Column(Storage="_ccNumber", Name="cc_number", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CcNumber
		{
			get
			{
				return this._ccNumber;
			}
			set
			{
				if (((_ccNumber == value) 
							== false))
				{
					this.OnCcNumberChanging(value);
					this.SendPropertyChanging();
					this._ccNumber = value;
					this.SendPropertyChanged("CcNumber");
					this.OnCcNumberChanged();
				}
			}
		}
		
		[Column(Storage="_ccOwner", Name="cc_owner", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CcOwner
		{
			get
			{
				return this._ccOwner;
			}
			set
			{
				if (((_ccOwner == value) 
							== false))
				{
					this.OnCcOwnerChanging(value);
					this.SendPropertyChanging();
					this._ccOwner = value;
					this.SendPropertyChanged("CcOwner");
					this.OnCcOwnerChanged();
				}
			}
		}
		
		[Column(Storage="_ccType", Name="cc_type", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CcType
		{
			get
			{
				return this._ccType;
			}
			set
			{
				if (((_ccType == value) 
							== false))
				{
					this.OnCcTypeChanging(value);
					this.SendPropertyChanging();
					this._ccType = value;
					this.SendPropertyChanged("CcType");
					this.OnCcTypeChanged();
				}
			}
		}
		
		[Column(Storage="_couponCode", Name="coupon_code", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CouponCode
		{
			get
			{
				return this._couponCode;
			}
			set
			{
				if (((_couponCode == value) 
							== false))
				{
					this.OnCouponCodeChanging(value);
					this.SendPropertyChanging();
					this._couponCode = value;
					this.SendPropertyChanged("CouponCode");
					this.OnCouponCodeChanged();
				}
			}
		}
		
		[Column(Storage="_currency", Name="currency", DbType="char(3)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Currency
		{
			get
			{
				return this._currency;
			}
			set
			{
				if (((_currency == value) 
							== false))
				{
					this.OnCurrencyChanging(value);
					this.SendPropertyChanging();
					this._currency = value;
					this.SendPropertyChanged("Currency");
					this.OnCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_currencyValue", Name="currency_value", DbType="decimal(14,6)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> CurrencyValue
		{
			get
			{
				return this._currencyValue;
			}
			set
			{
				if ((_currencyValue != value))
				{
					this.OnCurrencyValueChanging(value);
					this.SendPropertyChanging();
					this._currencyValue = value;
					this.SendPropertyChanged("CurrencyValue");
					this.OnCurrencyValueChanged();
				}
			}
		}
		
		[Column(Storage="_customersAddressFormatID", Name="customers_address_format_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersAddressFormatID
		{
			get
			{
				return this._customersAddressFormatID;
			}
			set
			{
				if ((_customersAddressFormatID != value))
				{
					this.OnCustomersAddressFormatIDChanging(value);
					this.SendPropertyChanging();
					this._customersAddressFormatID = value;
					this.SendPropertyChanged("CustomersAddressFormatID");
					this.OnCustomersAddressFormatIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersCity", Name="customers_city", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersCity
		{
			get
			{
				return this._customersCity;
			}
			set
			{
				if (((_customersCity == value) 
							== false))
				{
					this.OnCustomersCityChanging(value);
					this.SendPropertyChanging();
					this._customersCity = value;
					this.SendPropertyChanged("CustomersCity");
					this.OnCustomersCityChanged();
				}
			}
		}
		
		[Column(Storage="_customersCompany", Name="customers_company", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersCompany
		{
			get
			{
				return this._customersCompany;
			}
			set
			{
				if (((_customersCompany == value) 
							== false))
				{
					this.OnCustomersCompanyChanging(value);
					this.SendPropertyChanging();
					this._customersCompany = value;
					this.SendPropertyChanged("CustomersCompany");
					this.OnCustomersCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_customersCountry", Name="customers_country", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersCountry
		{
			get
			{
				return this._customersCountry;
			}
			set
			{
				if (((_customersCountry == value) 
							== false))
				{
					this.OnCustomersCountryChanging(value);
					this.SendPropertyChanging();
					this._customersCountry = value;
					this.SendPropertyChanged("CustomersCountry");
					this.OnCustomersCountryChanged();
				}
			}
		}
		
		[Column(Storage="_customersEmailAddress", Name="customers_email_address", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersEmailAddress
		{
			get
			{
				return this._customersEmailAddress;
			}
			set
			{
				if (((_customersEmailAddress == value) 
							== false))
				{
					this.OnCustomersEmailAddressChanging(value);
					this.SendPropertyChanging();
					this._customersEmailAddress = value;
					this.SendPropertyChanged("CustomersEmailAddress");
					this.OnCustomersEmailAddressChanged();
				}
			}
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersName", Name="customers_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersName
		{
			get
			{
				return this._customersName;
			}
			set
			{
				if (((_customersName == value) 
							== false))
				{
					this.OnCustomersNameChanging(value);
					this.SendPropertyChanging();
					this._customersName = value;
					this.SendPropertyChanged("CustomersName");
					this.OnCustomersNameChanged();
				}
			}
		}
		
		[Column(Storage="_customersPostCode", Name="customers_postcode", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersPostCode
		{
			get
			{
				return this._customersPostCode;
			}
			set
			{
				if (((_customersPostCode == value) 
							== false))
				{
					this.OnCustomersPostCodeChanging(value);
					this.SendPropertyChanging();
					this._customersPostCode = value;
					this.SendPropertyChanged("CustomersPostCode");
					this.OnCustomersPostCodeChanged();
				}
			}
		}
		
		[Column(Storage="_customersState", Name="customers_state", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersState
		{
			get
			{
				return this._customersState;
			}
			set
			{
				if (((_customersState == value) 
							== false))
				{
					this.OnCustomersStateChanging(value);
					this.SendPropertyChanging();
					this._customersState = value;
					this.SendPropertyChanged("CustomersState");
					this.OnCustomersStateChanged();
				}
			}
		}
		
		[Column(Storage="_customersStreetAddress", Name="customers_street_address", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersStreetAddress
		{
			get
			{
				return this._customersStreetAddress;
			}
			set
			{
				if (((_customersStreetAddress == value) 
							== false))
				{
					this.OnCustomersStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._customersStreetAddress = value;
					this.SendPropertyChanged("CustomersStreetAddress");
					this.OnCustomersStreetAddressChanged();
				}
			}
		}
		
		[Column(Storage="_customersSuburb", Name="customers_suburb", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string CustomersSuburb
		{
			get
			{
				return this._customersSuburb;
			}
			set
			{
				if (((_customersSuburb == value) 
							== false))
				{
					this.OnCustomersSuburbChanging(value);
					this.SendPropertyChanging();
					this._customersSuburb = value;
					this.SendPropertyChanged("CustomersSuburb");
					this.OnCustomersSuburbChanged();
				}
			}
		}
		
		[Column(Storage="_customersTelephone", Name="customers_telephone", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersTelephone
		{
			get
			{
				return this._customersTelephone;
			}
			set
			{
				if (((_customersTelephone == value) 
							== false))
				{
					this.OnCustomersTelephoneChanging(value);
					this.SendPropertyChanging();
					this._customersTelephone = value;
					this.SendPropertyChanged("CustomersTelephone");
					this.OnCustomersTelephoneChanged();
				}
			}
		}
		
		[Column(Storage="_datePurchased", Name="date_purchased", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DatePurchased
		{
			get
			{
				return this._datePurchased;
			}
			set
			{
				if ((_datePurchased != value))
				{
					this.OnDatePurchasedChanging(value);
					this.SendPropertyChanging();
					this._datePurchased = value;
					this.SendPropertyChanged("DatePurchased");
					this.OnDatePurchasedChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryAddressFormatID", Name="delivery_address_format_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DeliveryAddressFormatID
		{
			get
			{
				return this._deliveryAddressFormatID;
			}
			set
			{
				if ((_deliveryAddressFormatID != value))
				{
					this.OnDeliveryAddressFormatIDChanging(value);
					this.SendPropertyChanging();
					this._deliveryAddressFormatID = value;
					this.SendPropertyChanged("DeliveryAddressFormatID");
					this.OnDeliveryAddressFormatIDChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryCity", Name="delivery_city", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DeliveryCity
		{
			get
			{
				return this._deliveryCity;
			}
			set
			{
				if (((_deliveryCity == value) 
							== false))
				{
					this.OnDeliveryCityChanging(value);
					this.SendPropertyChanging();
					this._deliveryCity = value;
					this.SendPropertyChanged("DeliveryCity");
					this.OnDeliveryCityChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryCompany", Name="delivery_company", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeliveryCompany
		{
			get
			{
				return this._deliveryCompany;
			}
			set
			{
				if (((_deliveryCompany == value) 
							== false))
				{
					this.OnDeliveryCompanyChanging(value);
					this.SendPropertyChanging();
					this._deliveryCompany = value;
					this.SendPropertyChanged("DeliveryCompany");
					this.OnDeliveryCompanyChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryCountry", Name="delivery_country", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DeliveryCountry
		{
			get
			{
				return this._deliveryCountry;
			}
			set
			{
				if (((_deliveryCountry == value) 
							== false))
				{
					this.OnDeliveryCountryChanging(value);
					this.SendPropertyChanging();
					this._deliveryCountry = value;
					this.SendPropertyChanged("DeliveryCountry");
					this.OnDeliveryCountryChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryName", Name="delivery_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DeliveryName
		{
			get
			{
				return this._deliveryName;
			}
			set
			{
				if (((_deliveryName == value) 
							== false))
				{
					this.OnDeliveryNameChanging(value);
					this.SendPropertyChanging();
					this._deliveryName = value;
					this.SendPropertyChanged("DeliveryName");
					this.OnDeliveryNameChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryPostCode", Name="delivery_postcode", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DeliveryPostCode
		{
			get
			{
				return this._deliveryPostCode;
			}
			set
			{
				if (((_deliveryPostCode == value) 
							== false))
				{
					this.OnDeliveryPostCodeChanging(value);
					this.SendPropertyChanging();
					this._deliveryPostCode = value;
					this.SendPropertyChanged("DeliveryPostCode");
					this.OnDeliveryPostCodeChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryState", Name="delivery_state", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeliveryState
		{
			get
			{
				return this._deliveryState;
			}
			set
			{
				if (((_deliveryState == value) 
							== false))
				{
					this.OnDeliveryStateChanging(value);
					this.SendPropertyChanging();
					this._deliveryState = value;
					this.SendPropertyChanged("DeliveryState");
					this.OnDeliveryStateChanged();
				}
			}
		}
		
		[Column(Storage="_deliveryStreetAddress", Name="delivery_street_address", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DeliveryStreetAddress
		{
			get
			{
				return this._deliveryStreetAddress;
			}
			set
			{
				if (((_deliveryStreetAddress == value) 
							== false))
				{
					this.OnDeliveryStreetAddressChanging(value);
					this.SendPropertyChanging();
					this._deliveryStreetAddress = value;
					this.SendPropertyChanged("DeliveryStreetAddress");
					this.OnDeliveryStreetAddressChanged();
				}
			}
		}
		
		[Column(Storage="_deliverySuburb", Name="delivery_suburb", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string DeliverySuburb
		{
			get
			{
				return this._deliverySuburb;
			}
			set
			{
				if (((_deliverySuburb == value) 
							== false))
				{
					this.OnDeliverySuburbChanging(value);
					this.SendPropertyChanging();
					this._deliverySuburb = value;
					this.SendPropertyChanged("DeliverySuburb");
					this.OnDeliverySuburbChanged();
				}
			}
		}
		
		[Column(Storage="_ipaDdress", Name="ip_address", DbType="varchar(96)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string IPAddress
		{
			get
			{
				return this._ipaDdress;
			}
			set
			{
				if (((_ipaDdress == value) 
							== false))
				{
					this.OnIPAddressChanging(value);
					this.SendPropertyChanging();
					this._ipaDdress = value;
					this.SendPropertyChanged("IPAddress");
					this.OnIPAddressChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_ordersDateFinished", Name="orders_date_finished", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> OrdersDateFinished
		{
			get
			{
				return this._ordersDateFinished;
			}
			set
			{
				if ((_ordersDateFinished != value))
				{
					this.OnOrdersDateFinishedChanging(value);
					this.SendPropertyChanging();
					this._ordersDateFinished = value;
					this.SendPropertyChanged("OrdersDateFinished");
					this.OnOrdersDateFinishedChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersStatus", Name="orders_status", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersStatus
		{
			get
			{
				return this._ordersStatus;
			}
			set
			{
				if ((_ordersStatus != value))
				{
					this.OnOrdersStatusChanging(value);
					this.SendPropertyChanging();
					this._ordersStatus = value;
					this.SendPropertyChanged("OrdersStatus");
					this.OnOrdersStatusChanged();
				}
			}
		}
		
		[Column(Storage="_orderTax", Name="order_tax", DbType="decimal(14,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> OrderTax
		{
			get
			{
				return this._orderTax;
			}
			set
			{
				if ((_orderTax != value))
				{
					this.OnOrderTaxChanging(value);
					this.SendPropertyChanging();
					this._orderTax = value;
					this.SendPropertyChanged("OrderTax");
					this.OnOrderTaxChanged();
				}
			}
		}
		
		[Column(Storage="_orderTotal", Name="order_total", DbType="decimal(14,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> OrderTotal
		{
			get
			{
				return this._orderTotal;
			}
			set
			{
				if ((_orderTotal != value))
				{
					this.OnOrderTotalChanging(value);
					this.SendPropertyChanging();
					this._orderTotal = value;
					this.SendPropertyChanged("OrderTotal");
					this.OnOrderTotalChanged();
				}
			}
		}
		
		[Column(Storage="_paymentMethod", Name="payment_method", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentMethod
		{
			get
			{
				return this._paymentMethod;
			}
			set
			{
				if (((_paymentMethod == value) 
							== false))
				{
					this.OnPaymentMethodChanging(value);
					this.SendPropertyChanging();
					this._paymentMethod = value;
					this.SendPropertyChanged("PaymentMethod");
					this.OnPaymentMethodChanged();
				}
			}
		}
		
		[Column(Storage="_paymentModuleCode", Name="payment_module_code", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentModuleCode
		{
			get
			{
				return this._paymentModuleCode;
			}
			set
			{
				if (((_paymentModuleCode == value) 
							== false))
				{
					this.OnPaymentModuleCodeChanging(value);
					this.SendPropertyChanging();
					this._paymentModuleCode = value;
					this.SendPropertyChanged("PaymentModuleCode");
					this.OnPaymentModuleCodeChanged();
				}
			}
		}
		
		[Column(Storage="_payPalIpnid", Name="paypal_ipn_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PayPalIPNID
		{
			get
			{
				return this._payPalIpnid;
			}
			set
			{
				if ((_payPalIpnid != value))
				{
					this.OnPayPalIPNIDChanging(value);
					this.SendPropertyChanging();
					this._payPalIpnid = value;
					this.SendPropertyChanged("PayPalIPNID");
					this.OnPayPalIPNIDChanged();
				}
			}
		}
		
		[Column(Storage="_shippingMethod", Name="shipping_method", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ShippingMethod
		{
			get
			{
				return this._shippingMethod;
			}
			set
			{
				if (((_shippingMethod == value) 
							== false))
				{
					this.OnShippingMethodChanging(value);
					this.SendPropertyChanging();
					this._shippingMethod = value;
					this.SendPropertyChanged("ShippingMethod");
					this.OnShippingMethodChanged();
				}
			}
		}
		
		[Column(Storage="_shippingModuleCode", Name="shipping_module_code", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ShippingModuleCode
		{
			get
			{
				return this._shippingModuleCode;
			}
			set
			{
				if (((_shippingModuleCode == value) 
							== false))
				{
					this.OnShippingModuleCodeChanging(value);
					this.SendPropertyChanging();
					this._shippingModuleCode = value;
					this.SendPropertyChanged("ShippingModuleCode");
					this.OnShippingModuleCodeChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_products")]
	public partial class OrdersProducts : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private decimal _finalPrice;
		
		private decimal _onetimeCharges;
		
		private int _ordersID;
		
		private int _ordersProductsID;
		
		private sbyte _productIsFree;
		
		private sbyte _productsDiscountType;
		
		private sbyte _productsDiscountTypeFrom;
		
		private int _productsID;
		
		private string _productsModel;
		
		private string _productsName;
		
		private decimal _productsPrice;
		
		private sbyte _productsPricedByAttribute;
		
		private string _productsPrID;
		
		private float _productsQuantity;
		
		private decimal _productsTax;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnFinalPriceChanged();
		
		partial void OnFinalPriceChanging(decimal value);
		
		partial void OnOnetimeChargesChanged();
		
		partial void OnOnetimeChargesChanging(decimal value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersProductsIDChanged();
		
		partial void OnOrdersProductsIDChanging(int value);
		
		partial void OnProductIsFreeChanged();
		
		partial void OnProductIsFreeChanging(sbyte value);
		
		partial void OnProductsDiscountTypeChanged();
		
		partial void OnProductsDiscountTypeChanging(sbyte value);
		
		partial void OnProductsDiscountTypeFromChanged();
		
		partial void OnProductsDiscountTypeFromChanging(sbyte value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnProductsModelChanged();
		
		partial void OnProductsModelChanging(string value);
		
		partial void OnProductsNameChanged();
		
		partial void OnProductsNameChanging(string value);
		
		partial void OnProductsPriceChanged();
		
		partial void OnProductsPriceChanging(decimal value);
		
		partial void OnProductsPricedByAttributeChanged();
		
		partial void OnProductsPricedByAttributeChanging(sbyte value);
		
		partial void OnProductsPRidChanged();
		
		partial void OnProductsPRidChanging(string value);
		
		partial void OnProductsQuantityChanged();
		
		partial void OnProductsQuantityChanging(float value);
		
		partial void OnProductsTaxChanged();
		
		partial void OnProductsTaxChanging(decimal value);
		#endregion
		
		
		public OrdersProducts()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_finalPrice", Name="final_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal FinalPrice
		{
			get
			{
				return this._finalPrice;
			}
			set
			{
				if ((_finalPrice != value))
				{
					this.OnFinalPriceChanging(value);
					this.SendPropertyChanging();
					this._finalPrice = value;
					this.SendPropertyChanged("FinalPrice");
					this.OnFinalPriceChanged();
				}
			}
		}
		
		[Column(Storage="_onetimeCharges", Name="onetime_charges", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal OnetimeCharges
		{
			get
			{
				return this._onetimeCharges;
			}
			set
			{
				if ((_onetimeCharges != value))
				{
					this.OnOnetimeChargesChanging(value);
					this.SendPropertyChanging();
					this._onetimeCharges = value;
					this.SendPropertyChanged("OnetimeCharges");
					this.OnOnetimeChargesChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsID", Name="orders_products_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersProductsID
		{
			get
			{
				return this._ordersProductsID;
			}
			set
			{
				if ((_ordersProductsID != value))
				{
					this.OnOrdersProductsIDChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsID = value;
					this.SendPropertyChanged("OrdersProductsID");
					this.OnOrdersProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productIsFree", Name="product_is_free", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductIsFree
		{
			get
			{
				return this._productIsFree;
			}
			set
			{
				if ((_productIsFree != value))
				{
					this.OnProductIsFreeChanging(value);
					this.SendPropertyChanging();
					this._productIsFree = value;
					this.SendPropertyChanged("ProductIsFree");
					this.OnProductIsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_productsDiscountType", Name="products_discount_type", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsDiscountType
		{
			get
			{
				return this._productsDiscountType;
			}
			set
			{
				if ((_productsDiscountType != value))
				{
					this.OnProductsDiscountTypeChanging(value);
					this.SendPropertyChanging();
					this._productsDiscountType = value;
					this.SendPropertyChanged("ProductsDiscountType");
					this.OnProductsDiscountTypeChanged();
				}
			}
		}
		
		[Column(Storage="_productsDiscountTypeFrom", Name="products_discount_type_from", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsDiscountTypeFrom
		{
			get
			{
				return this._productsDiscountTypeFrom;
			}
			set
			{
				if ((_productsDiscountTypeFrom != value))
				{
					this.OnProductsDiscountTypeFromChanging(value);
					this.SendPropertyChanging();
					this._productsDiscountTypeFrom = value;
					this.SendPropertyChanged("ProductsDiscountTypeFrom");
					this.OnProductsDiscountTypeFromChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsModel", Name="products_model", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsModel
		{
			get
			{
				return this._productsModel;
			}
			set
			{
				if (((_productsModel == value) 
							== false))
				{
					this.OnProductsModelChanging(value);
					this.SendPropertyChanging();
					this._productsModel = value;
					this.SendPropertyChanged("ProductsModel");
					this.OnProductsModelChanged();
				}
			}
		}
		
		[Column(Storage="_productsName", Name="products_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsName
		{
			get
			{
				return this._productsName;
			}
			set
			{
				if (((_productsName == value) 
							== false))
				{
					this.OnProductsNameChanging(value);
					this.SendPropertyChanging();
					this._productsName = value;
					this.SendPropertyChanged("ProductsName");
					this.OnProductsNameChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrice", Name="products_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal ProductsPrice
		{
			get
			{
				return this._productsPrice;
			}
			set
			{
				if ((_productsPrice != value))
				{
					this.OnProductsPriceChanging(value);
					this.SendPropertyChanging();
					this._productsPrice = value;
					this.SendPropertyChanged("ProductsPrice");
					this.OnProductsPriceChanged();
				}
			}
		}
		
		[Column(Storage="_productsPricedByAttribute", Name="products_priced_by_attribute", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsPricedByAttribute
		{
			get
			{
				return this._productsPricedByAttribute;
			}
			set
			{
				if ((_productsPricedByAttribute != value))
				{
					this.OnProductsPricedByAttributeChanging(value);
					this.SendPropertyChanging();
					this._productsPricedByAttribute = value;
					this.SendPropertyChanged("ProductsPricedByAttribute");
					this.OnProductsPricedByAttributeChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrID", Name="products_prid", DbType="tinytext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsPRid
		{
			get
			{
				return this._productsPrID;
			}
			set
			{
				if (((_productsPrID == value) 
							== false))
				{
					this.OnProductsPRidChanging(value);
					this.SendPropertyChanging();
					this._productsPrID = value;
					this.SendPropertyChanged("ProductsPRid");
					this.OnProductsPRidChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantity", Name="products_quantity", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsQuantity
		{
			get
			{
				return this._productsQuantity;
			}
			set
			{
				if ((_productsQuantity != value))
				{
					this.OnProductsQuantityChanging(value);
					this.SendPropertyChanging();
					this._productsQuantity = value;
					this.SendPropertyChanged("ProductsQuantity");
					this.OnProductsQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_productsTax", Name="products_tax", DbType="decimal(7,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal ProductsTax
		{
			get
			{
				return this._productsTax;
			}
			set
			{
				if ((_productsTax != value))
				{
					this.OnProductsTaxChanging(value);
					this.SendPropertyChanging();
					this._productsTax = value;
					this.SendPropertyChanged("ProductsTax");
					this.OnProductsTaxChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_products_attributes")]
	public partial class OrdersProductsAttributes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _attributesDiscounted;
		
		private sbyte _attributesPriceBaseIncluded;
		
		private decimal _attributesPriceFactor;
		
		private decimal _attributesPriceFactorOffset;
		
		private decimal _attributesPriceFactorOnetime;
		
		private decimal _attributesPriceFactorOnetimeOffset;
		
		private decimal _attributesPriceLetters;
		
		private int _attributesPriceLettersFree;
		
		private decimal _attributesPriceOnetime;
		
		private decimal _attributesPriceWords;
		
		private int _attributesPriceWordsFree;
		
		private string _attributesQtypRices;
		
		private string _attributesQtypRicesOnetime;
		
		private decimal _optionsValuesPrice;
		
		private int _ordersID;
		
		private int _ordersProductsAttributesID;
		
		private int _ordersProductsID;
		
		private string _pricePrefix;
		
		private sbyte _productAttributeIsFree;
		
		private float _productsAttributesWeight;
		
		private string _productsAttributesWeightPrefix;
		
		private string _productsOptions;
		
		private int _productsOptionsID;
		
		private string _productsOptionsValues;
		
		private int _productsOptionsValuesID;
		
		private string _productsPrID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttributesDiscountedChanged();
		
		partial void OnAttributesDiscountedChanging(sbyte value);
		
		partial void OnAttributesPriceBaseIncludedChanged();
		
		partial void OnAttributesPriceBaseIncludedChanging(sbyte value);
		
		partial void OnAttributesPriceFactorChanged();
		
		partial void OnAttributesPriceFactorChanging(decimal value);
		
		partial void OnAttributesPriceFactorOffsetChanged();
		
		partial void OnAttributesPriceFactorOffsetChanging(decimal value);
		
		partial void OnAttributesPriceFactorOnetimeChanged();
		
		partial void OnAttributesPriceFactorOnetimeChanging(decimal value);
		
		partial void OnAttributesPriceFactorOnetimeOffsetChanged();
		
		partial void OnAttributesPriceFactorOnetimeOffsetChanging(decimal value);
		
		partial void OnAttributesPriceLettersChanged();
		
		partial void OnAttributesPriceLettersChanging(decimal value);
		
		partial void OnAttributesPriceLettersFreeChanged();
		
		partial void OnAttributesPriceLettersFreeChanging(int value);
		
		partial void OnAttributesPriceOnetimeChanged();
		
		partial void OnAttributesPriceOnetimeChanging(decimal value);
		
		partial void OnAttributesPriceWordsChanged();
		
		partial void OnAttributesPriceWordsChanging(decimal value);
		
		partial void OnAttributesPriceWordsFreeChanged();
		
		partial void OnAttributesPriceWordsFreeChanging(int value);
		
		partial void OnAttributesQTYPricesChanged();
		
		partial void OnAttributesQTYPricesChanging(string value);
		
		partial void OnAttributesQTYPricesOnetimeChanged();
		
		partial void OnAttributesQTYPricesOnetimeChanging(string value);
		
		partial void OnOptionsValuesPriceChanged();
		
		partial void OnOptionsValuesPriceChanging(decimal value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersProductsAttributesIDChanged();
		
		partial void OnOrdersProductsAttributesIDChanging(int value);
		
		partial void OnOrdersProductsIDChanged();
		
		partial void OnOrdersProductsIDChanging(int value);
		
		partial void OnPricePrefixChanged();
		
		partial void OnPricePrefixChanging(string value);
		
		partial void OnProductAttributeIsFreeChanged();
		
		partial void OnProductAttributeIsFreeChanging(sbyte value);
		
		partial void OnProductsAttributesWeightChanged();
		
		partial void OnProductsAttributesWeightChanging(float value);
		
		partial void OnProductsAttributesWeightPrefixChanged();
		
		partial void OnProductsAttributesWeightPrefixChanging(string value);
		
		partial void OnProductsOptionsChanged();
		
		partial void OnProductsOptionsChanging(string value);
		
		partial void OnProductsOptionsIDChanged();
		
		partial void OnProductsOptionsIDChanging(int value);
		
		partial void OnProductsOptionsValuesChanged();
		
		partial void OnProductsOptionsValuesChanging(string value);
		
		partial void OnProductsOptionsValuesIDChanged();
		
		partial void OnProductsOptionsValuesIDChanging(int value);
		
		partial void OnProductsPRidChanged();
		
		partial void OnProductsPRidChanging(string value);
		#endregion
		
		
		public OrdersProductsAttributes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_attributesDiscounted", Name="attributes_discounted", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesDiscounted
		{
			get
			{
				return this._attributesDiscounted;
			}
			set
			{
				if ((_attributesDiscounted != value))
				{
					this.OnAttributesDiscountedChanging(value);
					this.SendPropertyChanging();
					this._attributesDiscounted = value;
					this.SendPropertyChanged("AttributesDiscounted");
					this.OnAttributesDiscountedChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceBaseIncluded", Name="attributes_price_base_included", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesPriceBaseIncluded
		{
			get
			{
				return this._attributesPriceBaseIncluded;
			}
			set
			{
				if ((_attributesPriceBaseIncluded != value))
				{
					this.OnAttributesPriceBaseIncludedChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceBaseIncluded = value;
					this.SendPropertyChanged("AttributesPriceBaseIncluded");
					this.OnAttributesPriceBaseIncludedChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactor", Name="attributes_price_factor", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactor
		{
			get
			{
				return this._attributesPriceFactor;
			}
			set
			{
				if ((_attributesPriceFactor != value))
				{
					this.OnAttributesPriceFactorChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactor = value;
					this.SendPropertyChanged("AttributesPriceFactor");
					this.OnAttributesPriceFactorChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOffset", Name="attributes_price_factor_offset", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOffset
		{
			get
			{
				return this._attributesPriceFactorOffset;
			}
			set
			{
				if ((_attributesPriceFactorOffset != value))
				{
					this.OnAttributesPriceFactorOffsetChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOffset = value;
					this.SendPropertyChanged("AttributesPriceFactorOffset");
					this.OnAttributesPriceFactorOffsetChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOnetime", Name="attributes_price_factor_onetime", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOnetime
		{
			get
			{
				return this._attributesPriceFactorOnetime;
			}
			set
			{
				if ((_attributesPriceFactorOnetime != value))
				{
					this.OnAttributesPriceFactorOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOnetime = value;
					this.SendPropertyChanged("AttributesPriceFactorOnetime");
					this.OnAttributesPriceFactorOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOnetimeOffset", Name="attributes_price_factor_onetime_offset", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOnetimeOffset
		{
			get
			{
				return this._attributesPriceFactorOnetimeOffset;
			}
			set
			{
				if ((_attributesPriceFactorOnetimeOffset != value))
				{
					this.OnAttributesPriceFactorOnetimeOffsetChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOnetimeOffset = value;
					this.SendPropertyChanged("AttributesPriceFactorOnetimeOffset");
					this.OnAttributesPriceFactorOnetimeOffsetChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceLetters", Name="attributes_price_letters", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceLetters
		{
			get
			{
				return this._attributesPriceLetters;
			}
			set
			{
				if ((_attributesPriceLetters != value))
				{
					this.OnAttributesPriceLettersChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceLetters = value;
					this.SendPropertyChanged("AttributesPriceLetters");
					this.OnAttributesPriceLettersChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceLettersFree", Name="attributes_price_letters_free", DbType="int(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AttributesPriceLettersFree
		{
			get
			{
				return this._attributesPriceLettersFree;
			}
			set
			{
				if ((_attributesPriceLettersFree != value))
				{
					this.OnAttributesPriceLettersFreeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceLettersFree = value;
					this.SendPropertyChanged("AttributesPriceLettersFree");
					this.OnAttributesPriceLettersFreeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceOnetime", Name="attributes_price_onetime", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceOnetime
		{
			get
			{
				return this._attributesPriceOnetime;
			}
			set
			{
				if ((_attributesPriceOnetime != value))
				{
					this.OnAttributesPriceOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceOnetime = value;
					this.SendPropertyChanged("AttributesPriceOnetime");
					this.OnAttributesPriceOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceWords", Name="attributes_price_words", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceWords
		{
			get
			{
				return this._attributesPriceWords;
			}
			set
			{
				if ((_attributesPriceWords != value))
				{
					this.OnAttributesPriceWordsChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceWords = value;
					this.SendPropertyChanged("AttributesPriceWords");
					this.OnAttributesPriceWordsChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceWordsFree", Name="attributes_price_words_free", DbType="int(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AttributesPriceWordsFree
		{
			get
			{
				return this._attributesPriceWordsFree;
			}
			set
			{
				if ((_attributesPriceWordsFree != value))
				{
					this.OnAttributesPriceWordsFreeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceWordsFree = value;
					this.SendPropertyChanged("AttributesPriceWordsFree");
					this.OnAttributesPriceWordsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesQtypRices", Name="attributes_qty_prices", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributesQTYPrices
		{
			get
			{
				return this._attributesQtypRices;
			}
			set
			{
				if (((_attributesQtypRices == value) 
							== false))
				{
					this.OnAttributesQTYPricesChanging(value);
					this.SendPropertyChanging();
					this._attributesQtypRices = value;
					this.SendPropertyChanged("AttributesQTYPrices");
					this.OnAttributesQTYPricesChanged();
				}
			}
		}
		
		[Column(Storage="_attributesQtypRicesOnetime", Name="attributes_qty_prices_onetime", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributesQTYPricesOnetime
		{
			get
			{
				return this._attributesQtypRicesOnetime;
			}
			set
			{
				if (((_attributesQtypRicesOnetime == value) 
							== false))
				{
					this.OnAttributesQTYPricesOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesQtypRicesOnetime = value;
					this.SendPropertyChanged("AttributesQTYPricesOnetime");
					this.OnAttributesQTYPricesOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_optionsValuesPrice", Name="options_values_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal OptionsValuesPrice
		{
			get
			{
				return this._optionsValuesPrice;
			}
			set
			{
				if ((_optionsValuesPrice != value))
				{
					this.OnOptionsValuesPriceChanging(value);
					this.SendPropertyChanging();
					this._optionsValuesPrice = value;
					this.SendPropertyChanged("OptionsValuesPrice");
					this.OnOptionsValuesPriceChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsAttributesID", Name="orders_products_attributes_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersProductsAttributesID
		{
			get
			{
				return this._ordersProductsAttributesID;
			}
			set
			{
				if ((_ordersProductsAttributesID != value))
				{
					this.OnOrdersProductsAttributesIDChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsAttributesID = value;
					this.SendPropertyChanged("OrdersProductsAttributesID");
					this.OnOrdersProductsAttributesIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsID", Name="orders_products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersProductsID
		{
			get
			{
				return this._ordersProductsID;
			}
			set
			{
				if ((_ordersProductsID != value))
				{
					this.OnOrdersProductsIDChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsID = value;
					this.SendPropertyChanged("OrdersProductsID");
					this.OnOrdersProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_pricePrefix", Name="price_prefix", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PricePrefix
		{
			get
			{
				return this._pricePrefix;
			}
			set
			{
				if (((_pricePrefix == value) 
							== false))
				{
					this.OnPricePrefixChanging(value);
					this.SendPropertyChanging();
					this._pricePrefix = value;
					this.SendPropertyChanged("PricePrefix");
					this.OnPricePrefixChanged();
				}
			}
		}
		
		[Column(Storage="_productAttributeIsFree", Name="product_attribute_is_free", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductAttributeIsFree
		{
			get
			{
				return this._productAttributeIsFree;
			}
			set
			{
				if ((_productAttributeIsFree != value))
				{
					this.OnProductAttributeIsFreeChanging(value);
					this.SendPropertyChanging();
					this._productAttributeIsFree = value;
					this.SendPropertyChanged("ProductAttributeIsFree");
					this.OnProductAttributeIsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesWeight", Name="products_attributes_weight", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsAttributesWeight
		{
			get
			{
				return this._productsAttributesWeight;
			}
			set
			{
				if ((_productsAttributesWeight != value))
				{
					this.OnProductsAttributesWeightChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesWeight = value;
					this.SendPropertyChanged("ProductsAttributesWeight");
					this.OnProductsAttributesWeightChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesWeightPrefix", Name="products_attributes_weight_prefix", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsAttributesWeightPrefix
		{
			get
			{
				return this._productsAttributesWeightPrefix;
			}
			set
			{
				if (((_productsAttributesWeightPrefix == value) 
							== false))
				{
					this.OnProductsAttributesWeightPrefixChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesWeightPrefix = value;
					this.SendPropertyChanged("ProductsAttributesWeightPrefix");
					this.OnProductsAttributesWeightPrefixChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptions", Name="products_options", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptions
		{
			get
			{
				return this._productsOptions;
			}
			set
			{
				if (((_productsOptions == value) 
							== false))
				{
					this.OnProductsOptionsChanging(value);
					this.SendPropertyChanging();
					this._productsOptions = value;
					this.SendPropertyChanged("ProductsOptions");
					this.OnProductsOptionsChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsID", Name="products_options_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsID
		{
			get
			{
				return this._productsOptionsID;
			}
			set
			{
				if ((_productsOptionsID != value))
				{
					this.OnProductsOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsID = value;
					this.SendPropertyChanged("ProductsOptionsID");
					this.OnProductsOptionsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValues", Name="products_options_values", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsValues
		{
			get
			{
				return this._productsOptionsValues;
			}
			set
			{
				if (((_productsOptionsValues == value) 
							== false))
				{
					this.OnProductsOptionsValuesChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValues = value;
					this.SendPropertyChanged("ProductsOptionsValues");
					this.OnProductsOptionsValuesChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesID", Name="products_options_values_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValuesID
		{
			get
			{
				return this._productsOptionsValuesID;
			}
			set
			{
				if ((_productsOptionsValuesID != value))
				{
					this.OnProductsOptionsValuesIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesID = value;
					this.SendPropertyChanged("ProductsOptionsValuesID");
					this.OnProductsOptionsValuesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrID", Name="products_prid", DbType="tinytext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsPRid
		{
			get
			{
				return this._productsPrID;
			}
			set
			{
				if (((_productsPrID == value) 
							== false))
				{
					this.OnProductsPRidChanging(value);
					this.SendPropertyChanging();
					this._productsPrID = value;
					this.SendPropertyChanged("ProductsPRid");
					this.OnProductsPRidChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_products_download")]
	public partial class OrdersProductsDownload : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _downloadCount;
		
		private int _downloadMaXdAys;
		
		private int _ordersID;
		
		private int _ordersProductsDownloadID;
		
		private string _ordersProductsFilename;
		
		private int _ordersProductsID;
		
		private string _productsPrID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDownloadCountChanged();
		
		partial void OnDownloadCountChanging(int value);
		
		partial void OnDownloadMaXDaysChanged();
		
		partial void OnDownloadMaXDaysChanging(int value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersProductsDownloadIDChanged();
		
		partial void OnOrdersProductsDownloadIDChanging(int value);
		
		partial void OnOrdersProductsFilenameChanged();
		
		partial void OnOrdersProductsFilenameChanging(string value);
		
		partial void OnOrdersProductsIDChanged();
		
		partial void OnOrdersProductsIDChanging(int value);
		
		partial void OnProductsPRidChanged();
		
		partial void OnProductsPRidChanging(string value);
		#endregion
		
		
		public OrdersProductsDownload()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_downloadCount", Name="download_count", DbType="int(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DownloadCount
		{
			get
			{
				return this._downloadCount;
			}
			set
			{
				if ((_downloadCount != value))
				{
					this.OnDownloadCountChanging(value);
					this.SendPropertyChanging();
					this._downloadCount = value;
					this.SendPropertyChanged("DownloadCount");
					this.OnDownloadCountChanged();
				}
			}
		}
		
		[Column(Storage="_downloadMaXdAys", Name="download_maxdays", DbType="int(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DownloadMaXDays
		{
			get
			{
				return this._downloadMaXdAys;
			}
			set
			{
				if ((_downloadMaXdAys != value))
				{
					this.OnDownloadMaXDaysChanging(value);
					this.SendPropertyChanging();
					this._downloadMaXdAys = value;
					this.SendPropertyChanged("DownloadMaXDays");
					this.OnDownloadMaXDaysChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsDownloadID", Name="orders_products_download_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersProductsDownloadID
		{
			get
			{
				return this._ordersProductsDownloadID;
			}
			set
			{
				if ((_ordersProductsDownloadID != value))
				{
					this.OnOrdersProductsDownloadIDChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsDownloadID = value;
					this.SendPropertyChanged("OrdersProductsDownloadID");
					this.OnOrdersProductsDownloadIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsFilename", Name="orders_products_filename", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string OrdersProductsFilename
		{
			get
			{
				return this._ordersProductsFilename;
			}
			set
			{
				if (((_ordersProductsFilename == value) 
							== false))
				{
					this.OnOrdersProductsFilenameChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsFilename = value;
					this.SendPropertyChanged("OrdersProductsFilename");
					this.OnOrdersProductsFilenameChanged();
				}
			}
		}
		
		[Column(Storage="_ordersProductsID", Name="orders_products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersProductsID
		{
			get
			{
				return this._ordersProductsID;
			}
			set
			{
				if ((_ordersProductsID != value))
				{
					this.OnOrdersProductsIDChanging(value);
					this.SendPropertyChanging();
					this._ordersProductsID = value;
					this.SendPropertyChanged("OrdersProductsID");
					this.OnOrdersProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrID", Name="products_prid", DbType="tinytext", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsPRid
		{
			get
			{
				return this._productsPrID;
			}
			set
			{
				if (((_productsPrID == value) 
							== false))
				{
					this.OnProductsPRidChanging(value);
					this.SendPropertyChanging();
					this._productsPrID = value;
					this.SendPropertyChanged("ProductsPRid");
					this.OnProductsPRidChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_status")]
	public partial class OrdersStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private int _ordersStatusID;
		
		private string _ordersStatusName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnOrdersStatusIDChanged();
		
		partial void OnOrdersStatusIDChanging(int value);
		
		partial void OnOrdersStatusNameChanged();
		
		partial void OnOrdersStatusNameChanging(string value);
		#endregion
		
		
		public OrdersStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersStatusID", Name="orders_status_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersStatusID
		{
			get
			{
				return this._ordersStatusID;
			}
			set
			{
				if ((_ordersStatusID != value))
				{
					this.OnOrdersStatusIDChanging(value);
					this.SendPropertyChanging();
					this._ordersStatusID = value;
					this.SendPropertyChanged("OrdersStatusID");
					this.OnOrdersStatusIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersStatusName", Name="orders_status_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string OrdersStatusName
		{
			get
			{
				return this._ordersStatusName;
			}
			set
			{
				if (((_ordersStatusName == value) 
							== false))
				{
					this.OnOrdersStatusNameChanging(value);
					this.SendPropertyChanging();
					this._ordersStatusName = value;
					this.SendPropertyChanged("OrdersStatusName");
					this.OnOrdersStatusNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_status_history")]
	public partial class OrdersStatusHistory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _comments;
		
		private System.Nullable<int> _customerNotified;
		
		private System.DateTime _dateAdded;
		
		private int _ordersID;
		
		private int _ordersStatusHistoryID;
		
		private int _ordersStatusID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCommentsChanged();
		
		partial void OnCommentsChanging(string value);
		
		partial void OnCustomerNotifiedChanged();
		
		partial void OnCustomerNotifiedChanging(System.Nullable<int> value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersStatusHistoryIDChanged();
		
		partial void OnOrdersStatusHistoryIDChanging(int value);
		
		partial void OnOrdersStatusIDChanged();
		
		partial void OnOrdersStatusIDChanging(int value);
		#endregion
		
		
		public OrdersStatusHistory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_comments", Name="comments", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Comments
		{
			get
			{
				return this._comments;
			}
			set
			{
				if (((_comments == value) 
							== false))
				{
					this.OnCommentsChanging(value);
					this.SendPropertyChanging();
					this._comments = value;
					this.SendPropertyChanged("Comments");
					this.OnCommentsChanged();
				}
			}
		}
		
		[Column(Storage="_customerNotified", Name="customer_notified", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomerNotified
		{
			get
			{
				return this._customerNotified;
			}
			set
			{
				if ((_customerNotified != value))
				{
					this.OnCustomerNotifiedChanging(value);
					this.SendPropertyChanging();
					this._customerNotified = value;
					this.SendPropertyChanged("CustomerNotified");
					this.OnCustomerNotifiedChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersStatusHistoryID", Name="orders_status_history_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersStatusHistoryID
		{
			get
			{
				return this._ordersStatusHistoryID;
			}
			set
			{
				if ((_ordersStatusHistoryID != value))
				{
					this.OnOrdersStatusHistoryIDChanging(value);
					this.SendPropertyChanging();
					this._ordersStatusHistoryID = value;
					this.SendPropertyChanged("OrdersStatusHistoryID");
					this.OnOrdersStatusHistoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersStatusID", Name="orders_status_id", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersStatusID
		{
			get
			{
				return this._ordersStatusID;
			}
			set
			{
				if ((_ordersStatusID != value))
				{
					this.OnOrdersStatusIDChanging(value);
					this.SendPropertyChanging();
					this._ordersStatusID = value;
					this.SendPropertyChanged("OrdersStatusID");
					this.OnOrdersStatusIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.orders_total")]
	public partial class OrdersTotal : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _class;
		
		private int _ordersID;
		
		private uint _ordersTotalID;
		
		private int _sortOrder;
		
		private string _text;
		
		private string _title;
		
		private decimal _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnClassChanged();
		
		partial void OnClassChanging(string value);
		
		partial void OnOrdersIDChanged();
		
		partial void OnOrdersIDChanging(int value);
		
		partial void OnOrdersTotalIDChanged();
		
		partial void OnOrdersTotalIDChanging(uint value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(int value);
		
		partial void OnTextChanged();
		
		partial void OnTextChanging(string value);
		
		partial void OnTitleChanged();
		
		partial void OnTitleChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(decimal value);
		#endregion
		
		
		public OrdersTotal()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_class", Name="class", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Class
		{
			get
			{
				return this._class;
			}
			set
			{
				if (((_class == value) 
							== false))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
				}
			}
		}
		
		[Column(Storage="_ordersID", Name="orders_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OrdersID
		{
			get
			{
				return this._ordersID;
			}
			set
			{
				if ((_ordersID != value))
				{
					this.OnOrdersIDChanging(value);
					this.SendPropertyChanging();
					this._ordersID = value;
					this.SendPropertyChanged("OrdersID");
					this.OnOrdersIDChanged();
				}
			}
		}
		
		[Column(Storage="_ordersTotalID", Name="orders_total_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint OrdersTotalID
		{
			get
			{
				return this._ordersTotalID;
			}
			set
			{
				if ((_ordersTotalID != value))
				{
					this.OnOrdersTotalIDChanging(value);
					this.SendPropertyChanging();
					this._ordersTotalID = value;
					this.SendPropertyChanged("OrdersTotalID");
					this.OnOrdersTotalIDChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_text", Name="text", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Text
		{
			get
			{
				return this._text;
			}
			set
			{
				if (((_text == value) 
							== false))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[Column(Storage="_title", Name="title", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Title
		{
			get
			{
				return this._title;
			}
			set
			{
				if (((_title == value) 
							== false))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="value", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if ((_value != value))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.paypal")]
	public partial class PayPal : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _addressCity;
		
		private string _addressCountry;
		
		private string _addressName;
		
		private string _addressState;
		
		private string _addressStatus;
		
		private string _addressStreet;
		
		private string _addressZip;
		
		private string _business;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<decimal> _exchangeRate;
		
		private string _firstName;
		
		private string _invoice;
		
		private System.DateTime _lastModified;
		
		private string _lastName;
		
		private string _mcCurrency;
		
		private decimal _mcFee;
		
		private decimal _mcGross;
		
		private string _memo;
		
		private string _moduleMode;
		
		private string _moduleName;
		
		private string _notifyVersion;
		
		private byte _numCartItems;
		
		private uint _orderID;
		
		private string _parentTxNid;
		
		private string _payerBusinessName;
		
		private string _payerEmail;
		
		private string _payerID;
		
		private string _payerStatus;
		
		private System.DateTime _paymentDate;
		
		private System.Nullable<decimal> _paymentFee;
		
		private System.Nullable<decimal> _paymentGross;
		
		private string _paymentStatus;
		
		private string _paymentType;
		
		private uint _payPalIpnid;
		
		private string _pendingReason;
		
		private string _reasonCode;
		
		private string _receiverEmail;
		
		private string _receiverID;
		
		private System.Nullable<decimal> _settleAmount;
		
		private string _settleCurrency;
		
		private string _txNid;
		
		private string _txNtYpe;
		
		private string _verifySign;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressCityChanged();
		
		partial void OnAddressCityChanging(string value);
		
		partial void OnAddressCountryChanged();
		
		partial void OnAddressCountryChanging(string value);
		
		partial void OnAddressNameChanged();
		
		partial void OnAddressNameChanging(string value);
		
		partial void OnAddressStateChanged();
		
		partial void OnAddressStateChanging(string value);
		
		partial void OnAddressStatusChanged();
		
		partial void OnAddressStatusChanging(string value);
		
		partial void OnAddressStreetChanged();
		
		partial void OnAddressStreetChanging(string value);
		
		partial void OnAddressZipChanged();
		
		partial void OnAddressZipChanging(string value);
		
		partial void OnBusinessChanged();
		
		partial void OnBusinessChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnExchangeRateChanged();
		
		partial void OnExchangeRateChanging(System.Nullable<decimal> value);
		
		partial void OnFirstNameChanged();
		
		partial void OnFirstNameChanging(string value);
		
		partial void OnInvoiceChanged();
		
		partial void OnInvoiceChanging(string value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.DateTime value);
		
		partial void OnLastNameChanged();
		
		partial void OnLastNameChanging(string value);
		
		partial void OnMcCurrencyChanged();
		
		partial void OnMcCurrencyChanging(string value);
		
		partial void OnMcFeeChanged();
		
		partial void OnMcFeeChanging(decimal value);
		
		partial void OnMcGrossChanged();
		
		partial void OnMcGrossChanging(decimal value);
		
		partial void OnMemoChanged();
		
		partial void OnMemoChanging(string value);
		
		partial void OnModuleModeChanged();
		
		partial void OnModuleModeChanging(string value);
		
		partial void OnModuleNameChanged();
		
		partial void OnModuleNameChanging(string value);
		
		partial void OnNotifyVersionChanged();
		
		partial void OnNotifyVersionChanging(string value);
		
		partial void OnNumCartItemsChanged();
		
		partial void OnNumCartItemsChanging(byte value);
		
		partial void OnOrderIDChanged();
		
		partial void OnOrderIDChanging(uint value);
		
		partial void OnParentTxNIDChanged();
		
		partial void OnParentTxNIDChanging(string value);
		
		partial void OnPayerBusinessNameChanged();
		
		partial void OnPayerBusinessNameChanging(string value);
		
		partial void OnPayerEmailChanged();
		
		partial void OnPayerEmailChanging(string value);
		
		partial void OnPayerIDChanged();
		
		partial void OnPayerIDChanging(string value);
		
		partial void OnPayerStatusChanged();
		
		partial void OnPayerStatusChanging(string value);
		
		partial void OnPaymentDateChanged();
		
		partial void OnPaymentDateChanging(System.DateTime value);
		
		partial void OnPaymentFeeChanged();
		
		partial void OnPaymentFeeChanging(System.Nullable<decimal> value);
		
		partial void OnPaymentGrossChanged();
		
		partial void OnPaymentGrossChanging(System.Nullable<decimal> value);
		
		partial void OnPaymentStatusChanged();
		
		partial void OnPaymentStatusChanging(string value);
		
		partial void OnPaymentTypeChanged();
		
		partial void OnPaymentTypeChanging(string value);
		
		partial void OnPayPalIPNIDChanged();
		
		partial void OnPayPalIPNIDChanging(uint value);
		
		partial void OnPendingReasonChanged();
		
		partial void OnPendingReasonChanging(string value);
		
		partial void OnReasonCodeChanged();
		
		partial void OnReasonCodeChanging(string value);
		
		partial void OnReceiverEmailChanged();
		
		partial void OnReceiverEmailChanging(string value);
		
		partial void OnReceiverIDChanged();
		
		partial void OnReceiverIDChanging(string value);
		
		partial void OnSettleAmountChanged();
		
		partial void OnSettleAmountChanging(System.Nullable<decimal> value);
		
		partial void OnSettleCurrencyChanged();
		
		partial void OnSettleCurrencyChanging(string value);
		
		partial void OnTxNIDChanged();
		
		partial void OnTxNIDChanging(string value);
		
		partial void OnTxNTypeChanged();
		
		partial void OnTxNTypeChanging(string value);
		
		partial void OnVerifySignChanged();
		
		partial void OnVerifySignChanging(string value);
		#endregion
		
		
		public PayPal()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_addressCity", Name="address_city", DbType="varchar(120)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCity
		{
			get
			{
				return this._addressCity;
			}
			set
			{
				if (((_addressCity == value) 
							== false))
				{
					this.OnAddressCityChanging(value);
					this.SendPropertyChanging();
					this._addressCity = value;
					this.SendPropertyChanged("AddressCity");
					this.OnAddressCityChanged();
				}
			}
		}
		
		[Column(Storage="_addressCountry", Name="address_country", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCountry
		{
			get
			{
				return this._addressCountry;
			}
			set
			{
				if (((_addressCountry == value) 
							== false))
				{
					this.OnAddressCountryChanging(value);
					this.SendPropertyChanging();
					this._addressCountry = value;
					this.SendPropertyChanged("AddressCountry");
					this.OnAddressCountryChanged();
				}
			}
		}
		
		[Column(Storage="_addressName", Name="address_name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressName
		{
			get
			{
				return this._addressName;
			}
			set
			{
				if (((_addressName == value) 
							== false))
				{
					this.OnAddressNameChanging(value);
					this.SendPropertyChanging();
					this._addressName = value;
					this.SendPropertyChanged("AddressName");
					this.OnAddressNameChanged();
				}
			}
		}
		
		[Column(Storage="_addressState", Name="address_state", DbType="varchar(120)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressState
		{
			get
			{
				return this._addressState;
			}
			set
			{
				if (((_addressState == value) 
							== false))
				{
					this.OnAddressStateChanging(value);
					this.SendPropertyChanging();
					this._addressState = value;
					this.SendPropertyChanged("AddressState");
					this.OnAddressStateChanged();
				}
			}
		}
		
		[Column(Storage="_addressStatus", Name="address_status", DbType="varchar(11)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressStatus
		{
			get
			{
				return this._addressStatus;
			}
			set
			{
				if (((_addressStatus == value) 
							== false))
				{
					this.OnAddressStatusChanging(value);
					this.SendPropertyChanging();
					this._addressStatus = value;
					this.SendPropertyChanged("AddressStatus");
					this.OnAddressStatusChanged();
				}
			}
		}
		
		[Column(Storage="_addressStreet", Name="address_street", DbType="varchar(254)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressStreet
		{
			get
			{
				return this._addressStreet;
			}
			set
			{
				if (((_addressStreet == value) 
							== false))
				{
					this.OnAddressStreetChanging(value);
					this.SendPropertyChanging();
					this._addressStreet = value;
					this.SendPropertyChanged("AddressStreet");
					this.OnAddressStreetChanged();
				}
			}
		}
		
		[Column(Storage="_addressZip", Name="address_zip", DbType="varchar(10)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressZip
		{
			get
			{
				return this._addressZip;
			}
			set
			{
				if (((_addressZip == value) 
							== false))
				{
					this.OnAddressZipChanging(value);
					this.SendPropertyChanging();
					this._addressZip = value;
					this.SendPropertyChanged("AddressZip");
					this.OnAddressZipChanged();
				}
			}
		}
		
		[Column(Storage="_business", Name="business", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Business
		{
			get
			{
				return this._business;
			}
			set
			{
				if (((_business == value) 
							== false))
				{
					this.OnBusinessChanging(value);
					this.SendPropertyChanging();
					this._business = value;
					this.SendPropertyChanged("Business");
					this.OnBusinessChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_exchangeRate", Name="exchange_rate", DbType="decimal(4,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this._exchangeRate;
			}
			set
			{
				if ((_exchangeRate != value))
				{
					this.OnExchangeRateChanging(value);
					this.SendPropertyChanging();
					this._exchangeRate = value;
					this.SendPropertyChanged("ExchangeRate");
					this.OnExchangeRateChanged();
				}
			}
		}
		
		[Column(Storage="_firstName", Name="first_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if (((_firstName == value) 
							== false))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_invoice", Name="invoice", DbType="varchar(128)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Invoice
		{
			get
			{
				return this._invoice;
			}
			set
			{
				if (((_invoice == value) 
							== false))
				{
					this.OnInvoiceChanging(value);
					this.SendPropertyChanging();
					this._invoice = value;
					this.SendPropertyChanged("Invoice");
					this.OnInvoiceChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_lastName", Name="last_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if (((_lastName == value) 
							== false))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_mcCurrency", Name="mc_currency", DbType="char(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string McCurrency
		{
			get
			{
				return this._mcCurrency;
			}
			set
			{
				if (((_mcCurrency == value) 
							== false))
				{
					this.OnMcCurrencyChanging(value);
					this.SendPropertyChanging();
					this._mcCurrency = value;
					this.SendPropertyChanged("McCurrency");
					this.OnMcCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_mcFee", Name="mc_fee", DbType="decimal(7,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal McFee
		{
			get
			{
				return this._mcFee;
			}
			set
			{
				if ((_mcFee != value))
				{
					this.OnMcFeeChanging(value);
					this.SendPropertyChanging();
					this._mcFee = value;
					this.SendPropertyChanged("McFee");
					this.OnMcFeeChanged();
				}
			}
		}
		
		[Column(Storage="_mcGross", Name="mc_gross", DbType="decimal(7,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal McGross
		{
			get
			{
				return this._mcGross;
			}
			set
			{
				if ((_mcGross != value))
				{
					this.OnMcGrossChanging(value);
					this.SendPropertyChanging();
					this._mcGross = value;
					this.SendPropertyChanged("McGross");
					this.OnMcGrossChanged();
				}
			}
		}
		
		[Column(Storage="_memo", Name="memo", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Memo
		{
			get
			{
				return this._memo;
			}
			set
			{
				if (((_memo == value) 
							== false))
				{
					this.OnMemoChanging(value);
					this.SendPropertyChanging();
					this._memo = value;
					this.SendPropertyChanged("Memo");
					this.OnMemoChanged();
				}
			}
		}
		
		[Column(Storage="_moduleMode", Name="module_mode", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ModuleMode
		{
			get
			{
				return this._moduleMode;
			}
			set
			{
				if (((_moduleMode == value) 
							== false))
				{
					this.OnModuleModeChanging(value);
					this.SendPropertyChanging();
					this._moduleMode = value;
					this.SendPropertyChanged("ModuleMode");
					this.OnModuleModeChanged();
				}
			}
		}
		
		[Column(Storage="_moduleName", Name="module_name", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ModuleName
		{
			get
			{
				return this._moduleName;
			}
			set
			{
				if (((_moduleName == value) 
							== false))
				{
					this.OnModuleNameChanging(value);
					this.SendPropertyChanging();
					this._moduleName = value;
					this.SendPropertyChanged("ModuleName");
					this.OnModuleNameChanged();
				}
			}
		}
		
		[Column(Storage="_notifyVersion", Name="notify_version", DbType="varchar(6)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string NotifyVersion
		{
			get
			{
				return this._notifyVersion;
			}
			set
			{
				if (((_notifyVersion == value) 
							== false))
				{
					this.OnNotifyVersionChanging(value);
					this.SendPropertyChanging();
					this._notifyVersion = value;
					this.SendPropertyChanged("NotifyVersion");
					this.OnNotifyVersionChanged();
				}
			}
		}
		
		[Column(Storage="_numCartItems", Name="num_cart_items", DbType="tinyint(4) unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte NumCartItems
		{
			get
			{
				return this._numCartItems;
			}
			set
			{
				if ((_numCartItems != value))
				{
					this.OnNumCartItemsChanging(value);
					this.SendPropertyChanging();
					this._numCartItems = value;
					this.SendPropertyChanged("NumCartItems");
					this.OnNumCartItemsChanged();
				}
			}
		}
		
		[Column(Storage="_orderID", Name="order_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint OrderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((_orderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_parentTxNid", Name="parent_txn_id", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ParentTxNID
		{
			get
			{
				return this._parentTxNid;
			}
			set
			{
				if (((_parentTxNid == value) 
							== false))
				{
					this.OnParentTxNIDChanging(value);
					this.SendPropertyChanging();
					this._parentTxNid = value;
					this.SendPropertyChanged("ParentTxNID");
					this.OnParentTxNIDChanged();
				}
			}
		}
		
		[Column(Storage="_payerBusinessName", Name="payer_business_name", DbType="varchar(128)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PayerBusinessName
		{
			get
			{
				return this._payerBusinessName;
			}
			set
			{
				if (((_payerBusinessName == value) 
							== false))
				{
					this.OnPayerBusinessNameChanging(value);
					this.SendPropertyChanging();
					this._payerBusinessName = value;
					this.SendPropertyChanged("PayerBusinessName");
					this.OnPayerBusinessNameChanged();
				}
			}
		}
		
		[Column(Storage="_payerEmail", Name="payer_email", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerEmail
		{
			get
			{
				return this._payerEmail;
			}
			set
			{
				if (((_payerEmail == value) 
							== false))
				{
					this.OnPayerEmailChanging(value);
					this.SendPropertyChanging();
					this._payerEmail = value;
					this.SendPropertyChanged("PayerEmail");
					this.OnPayerEmailChanged();
				}
			}
		}
		
		[Column(Storage="_payerID", Name="payer_id", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerID
		{
			get
			{
				return this._payerID;
			}
			set
			{
				if (((_payerID == value) 
							== false))
				{
					this.OnPayerIDChanging(value);
					this.SendPropertyChanging();
					this._payerID = value;
					this.SendPropertyChanged("PayerID");
					this.OnPayerIDChanged();
				}
			}
		}
		
		[Column(Storage="_payerStatus", Name="payer_status", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerStatus
		{
			get
			{
				return this._payerStatus;
			}
			set
			{
				if (((_payerStatus == value) 
							== false))
				{
					this.OnPayerStatusChanging(value);
					this.SendPropertyChanging();
					this._payerStatus = value;
					this.SendPropertyChanged("PayerStatus");
					this.OnPayerStatusChanged();
				}
			}
		}
		
		[Column(Storage="_paymentDate", Name="payment_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime PaymentDate
		{
			get
			{
				return this._paymentDate;
			}
			set
			{
				if ((_paymentDate != value))
				{
					this.OnPaymentDateChanging(value);
					this.SendPropertyChanging();
					this._paymentDate = value;
					this.SendPropertyChanged("PaymentDate");
					this.OnPaymentDateChanged();
				}
			}
		}
		
		[Column(Storage="_paymentFee", Name="payment_fee", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> PaymentFee
		{
			get
			{
				return this._paymentFee;
			}
			set
			{
				if ((_paymentFee != value))
				{
					this.OnPaymentFeeChanging(value);
					this.SendPropertyChanging();
					this._paymentFee = value;
					this.SendPropertyChanged("PaymentFee");
					this.OnPaymentFeeChanged();
				}
			}
		}
		
		[Column(Storage="_paymentGross", Name="payment_gross", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> PaymentGross
		{
			get
			{
				return this._paymentGross;
			}
			set
			{
				if ((_paymentGross != value))
				{
					this.OnPaymentGrossChanging(value);
					this.SendPropertyChanging();
					this._paymentGross = value;
					this.SendPropertyChanged("PaymentGross");
					this.OnPaymentGrossChanged();
				}
			}
		}
		
		[Column(Storage="_paymentStatus", Name="payment_status", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentStatus
		{
			get
			{
				return this._paymentStatus;
			}
			set
			{
				if (((_paymentStatus == value) 
							== false))
				{
					this.OnPaymentStatusChanging(value);
					this.SendPropertyChanging();
					this._paymentStatus = value;
					this.SendPropertyChanged("PaymentStatus");
					this.OnPaymentStatusChanged();
				}
			}
		}
		
		[Column(Storage="_paymentType", Name="payment_type", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentType
		{
			get
			{
				return this._paymentType;
			}
			set
			{
				if (((_paymentType == value) 
							== false))
				{
					this.OnPaymentTypeChanging(value);
					this.SendPropertyChanging();
					this._paymentType = value;
					this.SendPropertyChanged("PaymentType");
					this.OnPaymentTypeChanged();
				}
			}
		}
		
		[Column(Storage="_payPalIpnid", Name="paypal_ipn_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint PayPalIPNID
		{
			get
			{
				return this._payPalIpnid;
			}
			set
			{
				if ((_payPalIpnid != value))
				{
					this.OnPayPalIPNIDChanging(value);
					this.SendPropertyChanging();
					this._payPalIpnid = value;
					this.SendPropertyChanged("PayPalIPNID");
					this.OnPayPalIPNIDChanged();
				}
			}
		}
		
		[Column(Storage="_pendingReason", Name="pending_reason", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PendingReason
		{
			get
			{
				return this._pendingReason;
			}
			set
			{
				if (((_pendingReason == value) 
							== false))
				{
					this.OnPendingReasonChanging(value);
					this.SendPropertyChanging();
					this._pendingReason = value;
					this.SendPropertyChanged("PendingReason");
					this.OnPendingReasonChanged();
				}
			}
		}
		
		[Column(Storage="_reasonCode", Name="reason_code", DbType="varchar(40)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReasonCode
		{
			get
			{
				return this._reasonCode;
			}
			set
			{
				if (((_reasonCode == value) 
							== false))
				{
					this.OnReasonCodeChanging(value);
					this.SendPropertyChanging();
					this._reasonCode = value;
					this.SendPropertyChanged("ReasonCode");
					this.OnReasonCodeChanged();
				}
			}
		}
		
		[Column(Storage="_receiverEmail", Name="receiver_email", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReceiverEmail
		{
			get
			{
				return this._receiverEmail;
			}
			set
			{
				if (((_receiverEmail == value) 
							== false))
				{
					this.OnReceiverEmailChanging(value);
					this.SendPropertyChanging();
					this._receiverEmail = value;
					this.SendPropertyChanged("ReceiverEmail");
					this.OnReceiverEmailChanged();
				}
			}
		}
		
		[Column(Storage="_receiverID", Name="receiver_id", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReceiverID
		{
			get
			{
				return this._receiverID;
			}
			set
			{
				if (((_receiverID == value) 
							== false))
				{
					this.OnReceiverIDChanging(value);
					this.SendPropertyChanging();
					this._receiverID = value;
					this.SendPropertyChanged("ReceiverID");
					this.OnReceiverIDChanged();
				}
			}
		}
		
		[Column(Storage="_settleAmount", Name="settle_amount", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> SettleAmount
		{
			get
			{
				return this._settleAmount;
			}
			set
			{
				if ((_settleAmount != value))
				{
					this.OnSettleAmountChanging(value);
					this.SendPropertyChanging();
					this._settleAmount = value;
					this.SendPropertyChanged("SettleAmount");
					this.OnSettleAmountChanged();
				}
			}
		}
		
		[Column(Storage="_settleCurrency", Name="settle_currency", DbType="char(3)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SettleCurrency
		{
			get
			{
				return this._settleCurrency;
			}
			set
			{
				if (((_settleCurrency == value) 
							== false))
				{
					this.OnSettleCurrencyChanging(value);
					this.SendPropertyChanging();
					this._settleCurrency = value;
					this.SendPropertyChanged("SettleCurrency");
					this.OnSettleCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_txNid", Name="txn_id", DbType="varchar(20)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TxNID
		{
			get
			{
				return this._txNid;
			}
			set
			{
				if (((_txNid == value) 
							== false))
				{
					this.OnTxNIDChanging(value);
					this.SendPropertyChanging();
					this._txNid = value;
					this.SendPropertyChanged("TxNID");
					this.OnTxNIDChanged();
				}
			}
		}
		
		[Column(Storage="_txNtYpe", Name="txn_type", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TxNType
		{
			get
			{
				return this._txNtYpe;
			}
			set
			{
				if (((_txNtYpe == value) 
							== false))
				{
					this.OnTxNTypeChanging(value);
					this.SendPropertyChanging();
					this._txNtYpe = value;
					this.SendPropertyChanged("TxNType");
					this.OnTxNTypeChanged();
				}
			}
		}
		
		[Column(Storage="_verifySign", Name="verify_sign", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string VerifySign
		{
			get
			{
				return this._verifySign;
			}
			set
			{
				if (((_verifySign == value) 
							== false))
				{
					this.OnVerifySignChanging(value);
					this.SendPropertyChanging();
					this._verifySign = value;
					this.SendPropertyChanged("VerifySign");
					this.OnVerifySignChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.paypal_payment_status")]
	public partial class PayPalPaymentStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _paymentStatusID;
		
		private string _paymentStatusName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnPaymentStatusIDChanged();
		
		partial void OnPaymentStatusIDChanging(int value);
		
		partial void OnPaymentStatusNameChanged();
		
		partial void OnPaymentStatusNameChanging(string value);
		#endregion
		
		
		public PayPalPaymentStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_paymentStatusID", Name="payment_status_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PaymentStatusID
		{
			get
			{
				return this._paymentStatusID;
			}
			set
			{
				if ((_paymentStatusID != value))
				{
					this.OnPaymentStatusIDChanging(value);
					this.SendPropertyChanging();
					this._paymentStatusID = value;
					this.SendPropertyChanged("PaymentStatusID");
					this.OnPaymentStatusIDChanged();
				}
			}
		}
		
		[Column(Storage="_paymentStatusName", Name="payment_status_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentStatusName
		{
			get
			{
				return this._paymentStatusName;
			}
			set
			{
				if (((_paymentStatusName == value) 
							== false))
				{
					this.OnPaymentStatusNameChanging(value);
					this.SendPropertyChanging();
					this._paymentStatusName = value;
					this.SendPropertyChanged("PaymentStatusName");
					this.OnPaymentStatusNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.paypal_payment_status_history")]
	public partial class PayPalPaymentStatusHistory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private string _parentTxNid;
		
		private string _paymentStatus;
		
		private int _paymentStatusHistoryID;
		
		private int _payPalIpnid;
		
		private string _pendingReason;
		
		private string _txNid;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnParentTxNIDChanged();
		
		partial void OnParentTxNIDChanging(string value);
		
		partial void OnPaymentStatusChanged();
		
		partial void OnPaymentStatusChanging(string value);
		
		partial void OnPaymentStatusHistoryIDChanged();
		
		partial void OnPaymentStatusHistoryIDChanging(int value);
		
		partial void OnPayPalIPNIDChanged();
		
		partial void OnPayPalIPNIDChanging(int value);
		
		partial void OnPendingReasonChanged();
		
		partial void OnPendingReasonChanging(string value);
		
		partial void OnTxNIDChanged();
		
		partial void OnTxNIDChanging(string value);
		#endregion
		
		
		public PayPalPaymentStatusHistory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_parentTxNid", Name="parent_txn_id", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ParentTxNID
		{
			get
			{
				return this._parentTxNid;
			}
			set
			{
				if (((_parentTxNid == value) 
							== false))
				{
					this.OnParentTxNIDChanging(value);
					this.SendPropertyChanging();
					this._parentTxNid = value;
					this.SendPropertyChanged("ParentTxNID");
					this.OnParentTxNIDChanged();
				}
			}
		}
		
		[Column(Storage="_paymentStatus", Name="payment_status", DbType="varchar(17)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentStatus
		{
			get
			{
				return this._paymentStatus;
			}
			set
			{
				if (((_paymentStatus == value) 
							== false))
				{
					this.OnPaymentStatusChanging(value);
					this.SendPropertyChanging();
					this._paymentStatus = value;
					this.SendPropertyChanged("PaymentStatus");
					this.OnPaymentStatusChanged();
				}
			}
		}
		
		[Column(Storage="_paymentStatusHistoryID", Name="payment_status_history_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PaymentStatusHistoryID
		{
			get
			{
				return this._paymentStatusHistoryID;
			}
			set
			{
				if ((_paymentStatusHistoryID != value))
				{
					this.OnPaymentStatusHistoryIDChanging(value);
					this.SendPropertyChanging();
					this._paymentStatusHistoryID = value;
					this.SendPropertyChanged("PaymentStatusHistoryID");
					this.OnPaymentStatusHistoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_payPalIpnid", Name="paypal_ipn_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int PayPalIPNID
		{
			get
			{
				return this._payPalIpnid;
			}
			set
			{
				if ((_payPalIpnid != value))
				{
					this.OnPayPalIPNIDChanging(value);
					this.SendPropertyChanging();
					this._payPalIpnid = value;
					this.SendPropertyChanged("PayPalIPNID");
					this.OnPayPalIPNIDChanged();
				}
			}
		}
		
		[Column(Storage="_pendingReason", Name="pending_reason", DbType="varchar(14)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PendingReason
		{
			get
			{
				return this._pendingReason;
			}
			set
			{
				if (((_pendingReason == value) 
							== false))
				{
					this.OnPendingReasonChanging(value);
					this.SendPropertyChanging();
					this._pendingReason = value;
					this.SendPropertyChanged("PendingReason");
					this.OnPendingReasonChanged();
				}
			}
		}
		
		[Column(Storage="_txNid", Name="txn_id", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TxNID
		{
			get
			{
				return this._txNid;
			}
			set
			{
				if (((_txNid == value) 
							== false))
				{
					this.OnTxNIDChanging(value);
					this.SendPropertyChanging();
					this._txNid = value;
					this.SendPropertyChanged("TxNID");
					this.OnTxNIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.paypal_session")]
	public partial class PayPalSession : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _expiry;
		
		private byte[] _savedSession;
		
		private string _sessionID;
		
		private int _uniqueID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnExpiryChanged();
		
		partial void OnExpiryChanging(int value);
		
		partial void OnSavedSessionChanged();
		
		partial void OnSavedSessionChanging(byte[] value);
		
		partial void OnSessionIDChanged();
		
		partial void OnSessionIDChanging(string value);
		
		partial void OnUniqueIDChanged();
		
		partial void OnUniqueIDChanging(int value);
		#endregion
		
		
		public PayPalSession()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_expiry", Name="expiry", DbType="int(17)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Expiry
		{
			get
			{
				return this._expiry;
			}
			set
			{
				if ((_expiry != value))
				{
					this.OnExpiryChanging(value);
					this.SendPropertyChanging();
					this._expiry = value;
					this.SendPropertyChanged("Expiry");
					this.OnExpiryChanged();
				}
			}
		}
		
		[Column(Storage="_savedSession", Name="saved_session", DbType="mediumblob", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte[] SavedSession
		{
			get
			{
				return this._savedSession;
			}
			set
			{
				if (((_savedSession == value) 
							== false))
				{
					this.OnSavedSessionChanging(value);
					this.SendPropertyChanging();
					this._savedSession = value;
					this.SendPropertyChanged("SavedSession");
					this.OnSavedSessionChanged();
				}
			}
		}
		
		[Column(Storage="_sessionID", Name="session_id", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SessionID
		{
			get
			{
				return this._sessionID;
			}
			set
			{
				if (((_sessionID == value) 
							== false))
				{
					this.OnSessionIDChanging(value);
					this.SendPropertyChanging();
					this._sessionID = value;
					this.SendPropertyChanged("SessionID");
					this.OnSessionIDChanged();
				}
			}
		}
		
		[Column(Storage="_uniqueID", Name="unique_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int UniqueID
		{
			get
			{
				return this._uniqueID;
			}
			set
			{
				if ((_uniqueID != value))
				{
					this.OnUniqueIDChanging(value);
					this.SendPropertyChanging();
					this._uniqueID = value;
					this.SendPropertyChanged("UniqueID");
					this.OnUniqueIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.paypal_testing")]
	public partial class PayPalTesting : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _addressCity;
		
		private string _addressCountry;
		
		private string _addressName;
		
		private string _addressState;
		
		private string _addressStatus;
		
		private string _addressStreet;
		
		private string _addressZip;
		
		private string _business;
		
		private string _custom;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<decimal> _exchangeRate;
		
		private string _firstName;
		
		private string _invoice;
		
		private System.DateTime _lastModified;
		
		private string _lastName;
		
		private string _mcCurrency;
		
		private decimal _mcFee;
		
		private decimal _mcGross;
		
		private string _memo;
		
		private string _moduleMode;
		
		private string _moduleName;
		
		private decimal _notifyVersion;
		
		private byte _numCartItems;
		
		private uint _orderID;
		
		private string _parentTxNid;
		
		private string _payerBusinessName;
		
		private string _payerEmail;
		
		private string _payerID;
		
		private string _payerStatus;
		
		private System.DateTime _paymentDate;
		
		private System.Nullable<decimal> _paymentFee;
		
		private System.Nullable<decimal> _paymentGross;
		
		private string _paymentStatus;
		
		private string _paymentType;
		
		private uint _payPalIpnid;
		
		private string _pendingReason;
		
		private string _reasonCode;
		
		private string _receiverEmail;
		
		private string _receiverID;
		
		private System.Nullable<decimal> _settleAmount;
		
		private string _settleCurrency;
		
		private string _txNid;
		
		private string _txNtYpe;
		
		private string _verifySign;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAddressCityChanged();
		
		partial void OnAddressCityChanging(string value);
		
		partial void OnAddressCountryChanged();
		
		partial void OnAddressCountryChanging(string value);
		
		partial void OnAddressNameChanged();
		
		partial void OnAddressNameChanging(string value);
		
		partial void OnAddressStateChanged();
		
		partial void OnAddressStateChanging(string value);
		
		partial void OnAddressStatusChanged();
		
		partial void OnAddressStatusChanging(string value);
		
		partial void OnAddressStreetChanged();
		
		partial void OnAddressStreetChanging(string value);
		
		partial void OnAddressZipChanged();
		
		partial void OnAddressZipChanging(string value);
		
		partial void OnBusinessChanged();
		
		partial void OnBusinessChanging(string value);
		
		partial void OnCustomChanged();
		
		partial void OnCustomChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnExchangeRateChanged();
		
		partial void OnExchangeRateChanging(System.Nullable<decimal> value);
		
		partial void OnFirstNameChanged();
		
		partial void OnFirstNameChanging(string value);
		
		partial void OnInvoiceChanged();
		
		partial void OnInvoiceChanging(string value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.DateTime value);
		
		partial void OnLastNameChanged();
		
		partial void OnLastNameChanging(string value);
		
		partial void OnMcCurrencyChanged();
		
		partial void OnMcCurrencyChanging(string value);
		
		partial void OnMcFeeChanged();
		
		partial void OnMcFeeChanging(decimal value);
		
		partial void OnMcGrossChanged();
		
		partial void OnMcGrossChanging(decimal value);
		
		partial void OnMemoChanged();
		
		partial void OnMemoChanging(string value);
		
		partial void OnModuleModeChanged();
		
		partial void OnModuleModeChanging(string value);
		
		partial void OnModuleNameChanged();
		
		partial void OnModuleNameChanging(string value);
		
		partial void OnNotifyVersionChanged();
		
		partial void OnNotifyVersionChanging(decimal value);
		
		partial void OnNumCartItemsChanged();
		
		partial void OnNumCartItemsChanging(byte value);
		
		partial void OnOrderIDChanged();
		
		partial void OnOrderIDChanging(uint value);
		
		partial void OnParentTxNIDChanged();
		
		partial void OnParentTxNIDChanging(string value);
		
		partial void OnPayerBusinessNameChanged();
		
		partial void OnPayerBusinessNameChanging(string value);
		
		partial void OnPayerEmailChanged();
		
		partial void OnPayerEmailChanging(string value);
		
		partial void OnPayerIDChanged();
		
		partial void OnPayerIDChanging(string value);
		
		partial void OnPayerStatusChanged();
		
		partial void OnPayerStatusChanging(string value);
		
		partial void OnPaymentDateChanged();
		
		partial void OnPaymentDateChanging(System.DateTime value);
		
		partial void OnPaymentFeeChanged();
		
		partial void OnPaymentFeeChanging(System.Nullable<decimal> value);
		
		partial void OnPaymentGrossChanged();
		
		partial void OnPaymentGrossChanging(System.Nullable<decimal> value);
		
		partial void OnPaymentStatusChanged();
		
		partial void OnPaymentStatusChanging(string value);
		
		partial void OnPaymentTypeChanged();
		
		partial void OnPaymentTypeChanging(string value);
		
		partial void OnPayPalIPNIDChanged();
		
		partial void OnPayPalIPNIDChanging(uint value);
		
		partial void OnPendingReasonChanged();
		
		partial void OnPendingReasonChanging(string value);
		
		partial void OnReasonCodeChanged();
		
		partial void OnReasonCodeChanging(string value);
		
		partial void OnReceiverEmailChanged();
		
		partial void OnReceiverEmailChanging(string value);
		
		partial void OnReceiverIDChanged();
		
		partial void OnReceiverIDChanging(string value);
		
		partial void OnSettleAmountChanged();
		
		partial void OnSettleAmountChanging(System.Nullable<decimal> value);
		
		partial void OnSettleCurrencyChanged();
		
		partial void OnSettleCurrencyChanging(string value);
		
		partial void OnTxNIDChanged();
		
		partial void OnTxNIDChanging(string value);
		
		partial void OnTxNTypeChanged();
		
		partial void OnTxNTypeChanging(string value);
		
		partial void OnVerifySignChanged();
		
		partial void OnVerifySignChanging(string value);
		#endregion
		
		
		public PayPalTesting()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_addressCity", Name="address_city", DbType="varchar(120)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCity
		{
			get
			{
				return this._addressCity;
			}
			set
			{
				if (((_addressCity == value) 
							== false))
				{
					this.OnAddressCityChanging(value);
					this.SendPropertyChanging();
					this._addressCity = value;
					this.SendPropertyChanged("AddressCity");
					this.OnAddressCityChanged();
				}
			}
		}
		
		[Column(Storage="_addressCountry", Name="address_country", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressCountry
		{
			get
			{
				return this._addressCountry;
			}
			set
			{
				if (((_addressCountry == value) 
							== false))
				{
					this.OnAddressCountryChanging(value);
					this.SendPropertyChanging();
					this._addressCountry = value;
					this.SendPropertyChanged("AddressCountry");
					this.OnAddressCountryChanged();
				}
			}
		}
		
		[Column(Storage="_addressName", Name="address_name", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressName
		{
			get
			{
				return this._addressName;
			}
			set
			{
				if (((_addressName == value) 
							== false))
				{
					this.OnAddressNameChanging(value);
					this.SendPropertyChanging();
					this._addressName = value;
					this.SendPropertyChanged("AddressName");
					this.OnAddressNameChanged();
				}
			}
		}
		
		[Column(Storage="_addressState", Name="address_state", DbType="varchar(120)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressState
		{
			get
			{
				return this._addressState;
			}
			set
			{
				if (((_addressState == value) 
							== false))
				{
					this.OnAddressStateChanging(value);
					this.SendPropertyChanging();
					this._addressState = value;
					this.SendPropertyChanged("AddressState");
					this.OnAddressStateChanged();
				}
			}
		}
		
		[Column(Storage="_addressStatus", Name="address_status", DbType="varchar(11)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressStatus
		{
			get
			{
				return this._addressStatus;
			}
			set
			{
				if (((_addressStatus == value) 
							== false))
				{
					this.OnAddressStatusChanging(value);
					this.SendPropertyChanging();
					this._addressStatus = value;
					this.SendPropertyChanged("AddressStatus");
					this.OnAddressStatusChanged();
				}
			}
		}
		
		[Column(Storage="_addressStreet", Name="address_street", DbType="varchar(254)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressStreet
		{
			get
			{
				return this._addressStreet;
			}
			set
			{
				if (((_addressStreet == value) 
							== false))
				{
					this.OnAddressStreetChanging(value);
					this.SendPropertyChanging();
					this._addressStreet = value;
					this.SendPropertyChanged("AddressStreet");
					this.OnAddressStreetChanged();
				}
			}
		}
		
		[Column(Storage="_addressZip", Name="address_zip", DbType="varchar(10)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AddressZip
		{
			get
			{
				return this._addressZip;
			}
			set
			{
				if (((_addressZip == value) 
							== false))
				{
					this.OnAddressZipChanging(value);
					this.SendPropertyChanging();
					this._addressZip = value;
					this.SendPropertyChanged("AddressZip");
					this.OnAddressZipChanged();
				}
			}
		}
		
		[Column(Storage="_business", Name="business", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Business
		{
			get
			{
				return this._business;
			}
			set
			{
				if (((_business == value) 
							== false))
				{
					this.OnBusinessChanging(value);
					this.SendPropertyChanging();
					this._business = value;
					this.SendPropertyChanged("Business");
					this.OnBusinessChanged();
				}
			}
		}
		
		[Column(Storage="_custom", Name="custom", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Custom
		{
			get
			{
				return this._custom;
			}
			set
			{
				if (((_custom == value) 
							== false))
				{
					this.OnCustomChanging(value);
					this.SendPropertyChanging();
					this._custom = value;
					this.SendPropertyChanged("Custom");
					this.OnCustomChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_exchangeRate", Name="exchange_rate", DbType="decimal(4,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> ExchangeRate
		{
			get
			{
				return this._exchangeRate;
			}
			set
			{
				if ((_exchangeRate != value))
				{
					this.OnExchangeRateChanging(value);
					this.SendPropertyChanging();
					this._exchangeRate = value;
					this.SendPropertyChanged("ExchangeRate");
					this.OnExchangeRateChanged();
				}
			}
		}
		
		[Column(Storage="_firstName", Name="first_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if (((_firstName == value) 
							== false))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[Column(Storage="_invoice", Name="invoice", DbType="varchar(128)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Invoice
		{
			get
			{
				return this._invoice;
			}
			set
			{
				if (((_invoice == value) 
							== false))
				{
					this.OnInvoiceChanging(value);
					this.SendPropertyChanging();
					this._invoice = value;
					this.SendPropertyChanged("Invoice");
					this.OnInvoiceChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_lastName", Name="last_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if (((_lastName == value) 
							== false))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[Column(Storage="_mcCurrency", Name="mc_currency", DbType="char(3)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string McCurrency
		{
			get
			{
				return this._mcCurrency;
			}
			set
			{
				if (((_mcCurrency == value) 
							== false))
				{
					this.OnMcCurrencyChanging(value);
					this.SendPropertyChanging();
					this._mcCurrency = value;
					this.SendPropertyChanged("McCurrency");
					this.OnMcCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_mcFee", Name="mc_fee", DbType="decimal(7,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal McFee
		{
			get
			{
				return this._mcFee;
			}
			set
			{
				if ((_mcFee != value))
				{
					this.OnMcFeeChanging(value);
					this.SendPropertyChanging();
					this._mcFee = value;
					this.SendPropertyChanged("McFee");
					this.OnMcFeeChanged();
				}
			}
		}
		
		[Column(Storage="_mcGross", Name="mc_gross", DbType="decimal(7,2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal McGross
		{
			get
			{
				return this._mcGross;
			}
			set
			{
				if ((_mcGross != value))
				{
					this.OnMcGrossChanging(value);
					this.SendPropertyChanging();
					this._mcGross = value;
					this.SendPropertyChanged("McGross");
					this.OnMcGrossChanged();
				}
			}
		}
		
		[Column(Storage="_memo", Name="memo", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Memo
		{
			get
			{
				return this._memo;
			}
			set
			{
				if (((_memo == value) 
							== false))
				{
					this.OnMemoChanging(value);
					this.SendPropertyChanging();
					this._memo = value;
					this.SendPropertyChanged("Memo");
					this.OnMemoChanged();
				}
			}
		}
		
		[Column(Storage="_moduleMode", Name="module_mode", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ModuleMode
		{
			get
			{
				return this._moduleMode;
			}
			set
			{
				if (((_moduleMode == value) 
							== false))
				{
					this.OnModuleModeChanging(value);
					this.SendPropertyChanging();
					this._moduleMode = value;
					this.SendPropertyChanged("ModuleMode");
					this.OnModuleModeChanged();
				}
			}
		}
		
		[Column(Storage="_moduleName", Name="module_name", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ModuleName
		{
			get
			{
				return this._moduleName;
			}
			set
			{
				if (((_moduleName == value) 
							== false))
				{
					this.OnModuleNameChanging(value);
					this.SendPropertyChanging();
					this._moduleName = value;
					this.SendPropertyChanged("ModuleName");
					this.OnModuleNameChanged();
				}
			}
		}
		
		[Column(Storage="_notifyVersion", Name="notify_version", DbType="decimal(2,1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal NotifyVersion
		{
			get
			{
				return this._notifyVersion;
			}
			set
			{
				if ((_notifyVersion != value))
				{
					this.OnNotifyVersionChanging(value);
					this.SendPropertyChanging();
					this._notifyVersion = value;
					this.SendPropertyChanged("NotifyVersion");
					this.OnNotifyVersionChanged();
				}
			}
		}
		
		[Column(Storage="_numCartItems", Name="num_cart_items", DbType="tinyint(4) unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte NumCartItems
		{
			get
			{
				return this._numCartItems;
			}
			set
			{
				if ((_numCartItems != value))
				{
					this.OnNumCartItemsChanging(value);
					this.SendPropertyChanging();
					this._numCartItems = value;
					this.SendPropertyChanged("NumCartItems");
					this.OnNumCartItemsChanged();
				}
			}
		}
		
		[Column(Storage="_orderID", Name="order_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint OrderID
		{
			get
			{
				return this._orderID;
			}
			set
			{
				if ((_orderID != value))
				{
					this.OnOrderIDChanging(value);
					this.SendPropertyChanging();
					this._orderID = value;
					this.SendPropertyChanged("OrderID");
					this.OnOrderIDChanged();
				}
			}
		}
		
		[Column(Storage="_parentTxNid", Name="parent_txn_id", DbType="varchar(20)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ParentTxNID
		{
			get
			{
				return this._parentTxNid;
			}
			set
			{
				if (((_parentTxNid == value) 
							== false))
				{
					this.OnParentTxNIDChanging(value);
					this.SendPropertyChanging();
					this._parentTxNid = value;
					this.SendPropertyChanged("ParentTxNID");
					this.OnParentTxNIDChanged();
				}
			}
		}
		
		[Column(Storage="_payerBusinessName", Name="payer_business_name", DbType="varchar(128)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PayerBusinessName
		{
			get
			{
				return this._payerBusinessName;
			}
			set
			{
				if (((_payerBusinessName == value) 
							== false))
				{
					this.OnPayerBusinessNameChanging(value);
					this.SendPropertyChanging();
					this._payerBusinessName = value;
					this.SendPropertyChanged("PayerBusinessName");
					this.OnPayerBusinessNameChanged();
				}
			}
		}
		
		[Column(Storage="_payerEmail", Name="payer_email", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerEmail
		{
			get
			{
				return this._payerEmail;
			}
			set
			{
				if (((_payerEmail == value) 
							== false))
				{
					this.OnPayerEmailChanging(value);
					this.SendPropertyChanging();
					this._payerEmail = value;
					this.SendPropertyChanged("PayerEmail");
					this.OnPayerEmailChanged();
				}
			}
		}
		
		[Column(Storage="_payerID", Name="payer_id", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerID
		{
			get
			{
				return this._payerID;
			}
			set
			{
				if (((_payerID == value) 
							== false))
				{
					this.OnPayerIDChanging(value);
					this.SendPropertyChanging();
					this._payerID = value;
					this.SendPropertyChanged("PayerID");
					this.OnPayerIDChanged();
				}
			}
		}
		
		[Column(Storage="_payerStatus", Name="payer_status", DbType="varchar(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PayerStatus
		{
			get
			{
				return this._payerStatus;
			}
			set
			{
				if (((_payerStatus == value) 
							== false))
				{
					this.OnPayerStatusChanging(value);
					this.SendPropertyChanging();
					this._payerStatus = value;
					this.SendPropertyChanged("PayerStatus");
					this.OnPayerStatusChanged();
				}
			}
		}
		
		[Column(Storage="_paymentDate", Name="payment_date", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime PaymentDate
		{
			get
			{
				return this._paymentDate;
			}
			set
			{
				if ((_paymentDate != value))
				{
					this.OnPaymentDateChanging(value);
					this.SendPropertyChanging();
					this._paymentDate = value;
					this.SendPropertyChanged("PaymentDate");
					this.OnPaymentDateChanged();
				}
			}
		}
		
		[Column(Storage="_paymentFee", Name="payment_fee", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> PaymentFee
		{
			get
			{
				return this._paymentFee;
			}
			set
			{
				if ((_paymentFee != value))
				{
					this.OnPaymentFeeChanging(value);
					this.SendPropertyChanging();
					this._paymentFee = value;
					this.SendPropertyChanged("PaymentFee");
					this.OnPaymentFeeChanged();
				}
			}
		}
		
		[Column(Storage="_paymentGross", Name="payment_gross", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> PaymentGross
		{
			get
			{
				return this._paymentGross;
			}
			set
			{
				if ((_paymentGross != value))
				{
					this.OnPaymentGrossChanging(value);
					this.SendPropertyChanging();
					this._paymentGross = value;
					this.SendPropertyChanged("PaymentGross");
					this.OnPaymentGrossChanged();
				}
			}
		}
		
		[Column(Storage="_paymentStatus", Name="payment_status", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentStatus
		{
			get
			{
				return this._paymentStatus;
			}
			set
			{
				if (((_paymentStatus == value) 
							== false))
				{
					this.OnPaymentStatusChanging(value);
					this.SendPropertyChanging();
					this._paymentStatus = value;
					this.SendPropertyChanged("PaymentStatus");
					this.OnPaymentStatusChanged();
				}
			}
		}
		
		[Column(Storage="_paymentType", Name="payment_type", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PaymentType
		{
			get
			{
				return this._paymentType;
			}
			set
			{
				if (((_paymentType == value) 
							== false))
				{
					this.OnPaymentTypeChanging(value);
					this.SendPropertyChanging();
					this._paymentType = value;
					this.SendPropertyChanged("PaymentType");
					this.OnPaymentTypeChanged();
				}
			}
		}
		
		[Column(Storage="_payPalIpnid", Name="paypal_ipn_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint PayPalIPNID
		{
			get
			{
				return this._payPalIpnid;
			}
			set
			{
				if ((_payPalIpnid != value))
				{
					this.OnPayPalIPNIDChanging(value);
					this.SendPropertyChanging();
					this._payPalIpnid = value;
					this.SendPropertyChanged("PayPalIPNID");
					this.OnPayPalIPNIDChanged();
				}
			}
		}
		
		[Column(Storage="_pendingReason", Name="pending_reason", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string PendingReason
		{
			get
			{
				return this._pendingReason;
			}
			set
			{
				if (((_pendingReason == value) 
							== false))
				{
					this.OnPendingReasonChanging(value);
					this.SendPropertyChanging();
					this._pendingReason = value;
					this.SendPropertyChanged("PendingReason");
					this.OnPendingReasonChanged();
				}
			}
		}
		
		[Column(Storage="_reasonCode", Name="reason_code", DbType="varchar(40)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ReasonCode
		{
			get
			{
				return this._reasonCode;
			}
			set
			{
				if (((_reasonCode == value) 
							== false))
				{
					this.OnReasonCodeChanging(value);
					this.SendPropertyChanging();
					this._reasonCode = value;
					this.SendPropertyChanged("ReasonCode");
					this.OnReasonCodeChanged();
				}
			}
		}
		
		[Column(Storage="_receiverEmail", Name="receiver_email", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReceiverEmail
		{
			get
			{
				return this._receiverEmail;
			}
			set
			{
				if (((_receiverEmail == value) 
							== false))
				{
					this.OnReceiverEmailChanging(value);
					this.SendPropertyChanging();
					this._receiverEmail = value;
					this.SendPropertyChanged("ReceiverEmail");
					this.OnReceiverEmailChanged();
				}
			}
		}
		
		[Column(Storage="_receiverID", Name="receiver_id", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReceiverID
		{
			get
			{
				return this._receiverID;
			}
			set
			{
				if (((_receiverID == value) 
							== false))
				{
					this.OnReceiverIDChanging(value);
					this.SendPropertyChanging();
					this._receiverID = value;
					this.SendPropertyChanged("ReceiverID");
					this.OnReceiverIDChanged();
				}
			}
		}
		
		[Column(Storage="_settleAmount", Name="settle_amount", DbType="decimal(7,2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<decimal> SettleAmount
		{
			get
			{
				return this._settleAmount;
			}
			set
			{
				if ((_settleAmount != value))
				{
					this.OnSettleAmountChanging(value);
					this.SendPropertyChanging();
					this._settleAmount = value;
					this.SendPropertyChanged("SettleAmount");
					this.OnSettleAmountChanged();
				}
			}
		}
		
		[Column(Storage="_settleCurrency", Name="settle_currency", DbType="char(3)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SettleCurrency
		{
			get
			{
				return this._settleCurrency;
			}
			set
			{
				if (((_settleCurrency == value) 
							== false))
				{
					this.OnSettleCurrencyChanging(value);
					this.SendPropertyChanging();
					this._settleCurrency = value;
					this.SendPropertyChanged("SettleCurrency");
					this.OnSettleCurrencyChanged();
				}
			}
		}
		
		[Column(Storage="_txNid", Name="txn_id", DbType="varchar(20)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TxNID
		{
			get
			{
				return this._txNid;
			}
			set
			{
				if (((_txNid == value) 
							== false))
				{
					this.OnTxNIDChanging(value);
					this.SendPropertyChanging();
					this._txNid = value;
					this.SendPropertyChanged("TxNID");
					this.OnTxNIDChanged();
				}
			}
		}
		
		[Column(Storage="_txNtYpe", Name="txn_type", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TxNType
		{
			get
			{
				return this._txNtYpe;
			}
			set
			{
				if (((_txNtYpe == value) 
							== false))
				{
					this.OnTxNTypeChanging(value);
					this.SendPropertyChanging();
					this._txNtYpe = value;
					this.SendPropertyChanged("TxNType");
					this.OnTxNTypeChanged();
				}
			}
		}
		
		[Column(Storage="_verifySign", Name="verify_sign", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string VerifySign
		{
			get
			{
				return this._verifySign;
			}
			set
			{
				if (((_verifySign == value) 
							== false))
				{
					this.OnVerifySignChanging(value);
					this.SendPropertyChanging();
					this._verifySign = value;
					this.SendPropertyChanged("VerifySign");
					this.OnVerifySignChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.product_music_extra")]
	public partial class ProductMusicExtra : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _artistsID;
		
		private int _musicGenreID;
		
		private int _productsID;
		
		private int _recordCompanyID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArtistsIDChanged();
		
		partial void OnArtistsIDChanging(int value);
		
		partial void OnMusicGenreIDChanged();
		
		partial void OnMusicGenreIDChanging(int value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnRecordCompanyIDChanged();
		
		partial void OnRecordCompanyIDChanging(int value);
		#endregion
		
		
		public ProductMusicExtra()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_artistsID", Name="artists_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArtistsID
		{
			get
			{
				return this._artistsID;
			}
			set
			{
				if ((_artistsID != value))
				{
					this.OnArtistsIDChanging(value);
					this.SendPropertyChanging();
					this._artistsID = value;
					this.SendPropertyChanged("ArtistsID");
					this.OnArtistsIDChanged();
				}
			}
		}
		
		[Column(Storage="_musicGenreID", Name="music_genre_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MusicGenreID
		{
			get
			{
				return this._musicGenreID;
			}
			set
			{
				if ((_musicGenreID != value))
				{
					this.OnMusicGenreIDChanging(value);
					this.SendPropertyChanging();
					this._musicGenreID = value;
					this.SendPropertyChanged("MusicGenreID");
					this.OnMusicGenreIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyID", Name="record_company_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RecordCompanyID
		{
			get
			{
				return this._recordCompanyID;
			}
			set
			{
				if ((_recordCompanyID != value))
				{
					this.OnRecordCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyID = value;
					this.SendPropertyChanged("RecordCompanyID");
					this.OnRecordCompanyIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products")]
	public partial class Products : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _manufacturersID;
		
		private int _masterCategoriesID;
		
		private sbyte _metaTagsModelStatus;
		
		private sbyte _metaTagsPriceStatus;
		
		private sbyte _metaTagsProductsNameStatus;
		
		private sbyte _metaTagsTitleStatus;
		
		private sbyte _metaTagsTitleTagLineStatus;
		
		private sbyte _productIsAlwaysFreeShipping;
		
		private sbyte _productIsCall;
		
		private sbyte _productIsFree;
		
		private System.DateTime _productsDateAdded;
		
		private System.Nullable<System.DateTime> _productsDateAvailable;
		
		private sbyte _productsDiscountType;
		
		private sbyte _productsDiscountTypeFrom;
		
		private int _productsID;
		
		private string _productsImage;
		
		private System.Nullable<System.DateTime> _productsLastModified;
		
		private sbyte _productsMixedDiscountQuantity;
		
		private string _productsModel;
		
		private float _productsOrdered;
		
		private decimal _productsPrice;
		
		private sbyte _productsPricedByAttribute;
		
		private decimal _productsPriceSorter;
		
		private sbyte _productsQtybOxStatus;
		
		private float _productsQuantity;
		
		private sbyte _productsQuantityMixed;
		
		private float _productsQuantityOrderMaX;
		
		private float _productsQuantityOrderMiN;
		
		private float _productsQuantityOrderUnits;
		
		private int _productsSortOrder;
		
		private sbyte _productsStatus;
		
		private int _productsTaxClassID;
		
		private int _productsType;
		
		private sbyte _productsVirtual;
		
		private float _productsWeight;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnManufacturersIDChanged();
		
		partial void OnManufacturersIDChanging(System.Nullable<int> value);
		
		partial void OnMasterCategoriesIDChanged();
		
		partial void OnMasterCategoriesIDChanging(int value);
		
		partial void OnMetaTagsModelStatusChanged();
		
		partial void OnMetaTagsModelStatusChanging(sbyte value);
		
		partial void OnMetaTagsPriceStatusChanged();
		
		partial void OnMetaTagsPriceStatusChanging(sbyte value);
		
		partial void OnMetaTagsProductsNameStatusChanged();
		
		partial void OnMetaTagsProductsNameStatusChanging(sbyte value);
		
		partial void OnMetaTagsTitleStatusChanged();
		
		partial void OnMetaTagsTitleStatusChanging(sbyte value);
		
		partial void OnMetaTagsTitleTagLineStatusChanged();
		
		partial void OnMetaTagsTitleTagLineStatusChanging(sbyte value);
		
		partial void OnProductIsAlwaysFreeShippingChanged();
		
		partial void OnProductIsAlwaysFreeShippingChanging(sbyte value);
		
		partial void OnProductIsCallChanged();
		
		partial void OnProductIsCallChanging(sbyte value);
		
		partial void OnProductIsFreeChanged();
		
		partial void OnProductIsFreeChanging(sbyte value);
		
		partial void OnProductsDateAddedChanged();
		
		partial void OnProductsDateAddedChanging(System.DateTime value);
		
		partial void OnProductsDateAvailableChanged();
		
		partial void OnProductsDateAvailableChanging(System.Nullable<System.DateTime> value);
		
		partial void OnProductsDiscountTypeChanged();
		
		partial void OnProductsDiscountTypeChanging(sbyte value);
		
		partial void OnProductsDiscountTypeFromChanged();
		
		partial void OnProductsDiscountTypeFromChanging(sbyte value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnProductsImageChanged();
		
		partial void OnProductsImageChanging(string value);
		
		partial void OnProductsLastModifiedChanged();
		
		partial void OnProductsLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnProductsMixedDiscountQuantityChanged();
		
		partial void OnProductsMixedDiscountQuantityChanging(sbyte value);
		
		partial void OnProductsModelChanged();
		
		partial void OnProductsModelChanging(string value);
		
		partial void OnProductsOrderedChanged();
		
		partial void OnProductsOrderedChanging(float value);
		
		partial void OnProductsPriceChanged();
		
		partial void OnProductsPriceChanging(decimal value);
		
		partial void OnProductsPricedByAttributeChanged();
		
		partial void OnProductsPricedByAttributeChanging(sbyte value);
		
		partial void OnProductsPriceSorterChanged();
		
		partial void OnProductsPriceSorterChanging(decimal value);
		
		partial void OnProductsQTYBoxStatusChanged();
		
		partial void OnProductsQTYBoxStatusChanging(sbyte value);
		
		partial void OnProductsQuantityChanged();
		
		partial void OnProductsQuantityChanging(float value);
		
		partial void OnProductsQuantityMixedChanged();
		
		partial void OnProductsQuantityMixedChanging(sbyte value);
		
		partial void OnProductsQuantityOrderMaXChanged();
		
		partial void OnProductsQuantityOrderMaXChanging(float value);
		
		partial void OnProductsQuantityOrderMInChanged();
		
		partial void OnProductsQuantityOrderMInChanging(float value);
		
		partial void OnProductsQuantityOrderUnitsChanged();
		
		partial void OnProductsQuantityOrderUnitsChanging(float value);
		
		partial void OnProductsSortOrderChanged();
		
		partial void OnProductsSortOrderChanging(int value);
		
		partial void OnProductsStatusChanged();
		
		partial void OnProductsStatusChanging(sbyte value);
		
		partial void OnProductsTaxClassIDChanged();
		
		partial void OnProductsTaxClassIDChanging(int value);
		
		partial void OnProductsTypeChanged();
		
		partial void OnProductsTypeChanging(int value);
		
		partial void OnProductsVirtualChanged();
		
		partial void OnProductsVirtualChanging(sbyte value);
		
		partial void OnProductsWeightChanged();
		
		partial void OnProductsWeightChanging(float value);
		#endregion
		
		
		public Products()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_manufacturersID", Name="manufacturers_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ManufacturersID
		{
			get
			{
				return this._manufacturersID;
			}
			set
			{
				if ((_manufacturersID != value))
				{
					this.OnManufacturersIDChanging(value);
					this.SendPropertyChanging();
					this._manufacturersID = value;
					this.SendPropertyChanged("ManufacturersID");
					this.OnManufacturersIDChanged();
				}
			}
		}
		
		[Column(Storage="_masterCategoriesID", Name="master_categories_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int MasterCategoriesID
		{
			get
			{
				return this._masterCategoriesID;
			}
			set
			{
				if ((_masterCategoriesID != value))
				{
					this.OnMasterCategoriesIDChanging(value);
					this.SendPropertyChanging();
					this._masterCategoriesID = value;
					this.SendPropertyChanged("MasterCategoriesID");
					this.OnMasterCategoriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsModelStatus", Name="metatags_model_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte MetaTagsModelStatus
		{
			get
			{
				return this._metaTagsModelStatus;
			}
			set
			{
				if ((_metaTagsModelStatus != value))
				{
					this.OnMetaTagsModelStatusChanging(value);
					this.SendPropertyChanging();
					this._metaTagsModelStatus = value;
					this.SendPropertyChanged("MetaTagsModelStatus");
					this.OnMetaTagsModelStatusChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsPriceStatus", Name="metatags_price_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte MetaTagsPriceStatus
		{
			get
			{
				return this._metaTagsPriceStatus;
			}
			set
			{
				if ((_metaTagsPriceStatus != value))
				{
					this.OnMetaTagsPriceStatusChanging(value);
					this.SendPropertyChanging();
					this._metaTagsPriceStatus = value;
					this.SendPropertyChanged("MetaTagsPriceStatus");
					this.OnMetaTagsPriceStatusChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsProductsNameStatus", Name="metatags_products_name_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte MetaTagsProductsNameStatus
		{
			get
			{
				return this._metaTagsProductsNameStatus;
			}
			set
			{
				if ((_metaTagsProductsNameStatus != value))
				{
					this.OnMetaTagsProductsNameStatusChanging(value);
					this.SendPropertyChanging();
					this._metaTagsProductsNameStatus = value;
					this.SendPropertyChanged("MetaTagsProductsNameStatus");
					this.OnMetaTagsProductsNameStatusChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsTitleStatus", Name="metatags_title_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte MetaTagsTitleStatus
		{
			get
			{
				return this._metaTagsTitleStatus;
			}
			set
			{
				if ((_metaTagsTitleStatus != value))
				{
					this.OnMetaTagsTitleStatusChanging(value);
					this.SendPropertyChanging();
					this._metaTagsTitleStatus = value;
					this.SendPropertyChanged("MetaTagsTitleStatus");
					this.OnMetaTagsTitleStatusChanged();
				}
			}
		}
		
		[Column(Storage="_metaTagsTitleTagLineStatus", Name="metatags_title_tagline_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte MetaTagsTitleTagLineStatus
		{
			get
			{
				return this._metaTagsTitleTagLineStatus;
			}
			set
			{
				if ((_metaTagsTitleTagLineStatus != value))
				{
					this.OnMetaTagsTitleTagLineStatusChanging(value);
					this.SendPropertyChanging();
					this._metaTagsTitleTagLineStatus = value;
					this.SendPropertyChanged("MetaTagsTitleTagLineStatus");
					this.OnMetaTagsTitleTagLineStatusChanged();
				}
			}
		}
		
		[Column(Storage="_productIsAlwaysFreeShipping", Name="product_is_always_free_shipping", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductIsAlwaysFreeShipping
		{
			get
			{
				return this._productIsAlwaysFreeShipping;
			}
			set
			{
				if ((_productIsAlwaysFreeShipping != value))
				{
					this.OnProductIsAlwaysFreeShippingChanging(value);
					this.SendPropertyChanging();
					this._productIsAlwaysFreeShipping = value;
					this.SendPropertyChanged("ProductIsAlwaysFreeShipping");
					this.OnProductIsAlwaysFreeShippingChanged();
				}
			}
		}
		
		[Column(Storage="_productIsCall", Name="product_is_call", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductIsCall
		{
			get
			{
				return this._productIsCall;
			}
			set
			{
				if ((_productIsCall != value))
				{
					this.OnProductIsCallChanging(value);
					this.SendPropertyChanging();
					this._productIsCall = value;
					this.SendPropertyChanged("ProductIsCall");
					this.OnProductIsCallChanged();
				}
			}
		}
		
		[Column(Storage="_productIsFree", Name="product_is_free", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductIsFree
		{
			get
			{
				return this._productIsFree;
			}
			set
			{
				if ((_productIsFree != value))
				{
					this.OnProductIsFreeChanging(value);
					this.SendPropertyChanging();
					this._productIsFree = value;
					this.SendPropertyChanged("ProductIsFree");
					this.OnProductIsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_productsDateAdded", Name="products_date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ProductsDateAdded
		{
			get
			{
				return this._productsDateAdded;
			}
			set
			{
				if ((_productsDateAdded != value))
				{
					this.OnProductsDateAddedChanging(value);
					this.SendPropertyChanging();
					this._productsDateAdded = value;
					this.SendPropertyChanged("ProductsDateAdded");
					this.OnProductsDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_productsDateAvailable", Name="products_date_available", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ProductsDateAvailable
		{
			get
			{
				return this._productsDateAvailable;
			}
			set
			{
				if ((_productsDateAvailable != value))
				{
					this.OnProductsDateAvailableChanging(value);
					this.SendPropertyChanging();
					this._productsDateAvailable = value;
					this.SendPropertyChanged("ProductsDateAvailable");
					this.OnProductsDateAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_productsDiscountType", Name="products_discount_type", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsDiscountType
		{
			get
			{
				return this._productsDiscountType;
			}
			set
			{
				if ((_productsDiscountType != value))
				{
					this.OnProductsDiscountTypeChanging(value);
					this.SendPropertyChanging();
					this._productsDiscountType = value;
					this.SendPropertyChanged("ProductsDiscountType");
					this.OnProductsDiscountTypeChanged();
				}
			}
		}
		
		[Column(Storage="_productsDiscountTypeFrom", Name="products_discount_type_from", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsDiscountTypeFrom
		{
			get
			{
				return this._productsDiscountTypeFrom;
			}
			set
			{
				if ((_productsDiscountTypeFrom != value))
				{
					this.OnProductsDiscountTypeFromChanging(value);
					this.SendPropertyChanging();
					this._productsDiscountTypeFrom = value;
					this.SendPropertyChanged("ProductsDiscountTypeFrom");
					this.OnProductsDiscountTypeFromChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsImage", Name="products_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsImage
		{
			get
			{
				return this._productsImage;
			}
			set
			{
				if (((_productsImage == value) 
							== false))
				{
					this.OnProductsImageChanging(value);
					this.SendPropertyChanging();
					this._productsImage = value;
					this.SendPropertyChanged("ProductsImage");
					this.OnProductsImageChanged();
				}
			}
		}
		
		[Column(Storage="_productsLastModified", Name="products_last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ProductsLastModified
		{
			get
			{
				return this._productsLastModified;
			}
			set
			{
				if ((_productsLastModified != value))
				{
					this.OnProductsLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._productsLastModified = value;
					this.SendPropertyChanged("ProductsLastModified");
					this.OnProductsLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_productsMixedDiscountQuantity", Name="products_mixed_discount_quantity", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsMixedDiscountQuantity
		{
			get
			{
				return this._productsMixedDiscountQuantity;
			}
			set
			{
				if ((_productsMixedDiscountQuantity != value))
				{
					this.OnProductsMixedDiscountQuantityChanging(value);
					this.SendPropertyChanging();
					this._productsMixedDiscountQuantity = value;
					this.SendPropertyChanged("ProductsMixedDiscountQuantity");
					this.OnProductsMixedDiscountQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_productsModel", Name="products_model", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsModel
		{
			get
			{
				return this._productsModel;
			}
			set
			{
				if (((_productsModel == value) 
							== false))
				{
					this.OnProductsModelChanging(value);
					this.SendPropertyChanging();
					this._productsModel = value;
					this.SendPropertyChanged("ProductsModel");
					this.OnProductsModelChanged();
				}
			}
		}
		
		[Column(Storage="_productsOrdered", Name="products_ordered", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsOrdered
		{
			get
			{
				return this._productsOrdered;
			}
			set
			{
				if ((_productsOrdered != value))
				{
					this.OnProductsOrderedChanging(value);
					this.SendPropertyChanging();
					this._productsOrdered = value;
					this.SendPropertyChanged("ProductsOrdered");
					this.OnProductsOrderedChanged();
				}
			}
		}
		
		[Column(Storage="_productsPrice", Name="products_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal ProductsPrice
		{
			get
			{
				return this._productsPrice;
			}
			set
			{
				if ((_productsPrice != value))
				{
					this.OnProductsPriceChanging(value);
					this.SendPropertyChanging();
					this._productsPrice = value;
					this.SendPropertyChanged("ProductsPrice");
					this.OnProductsPriceChanged();
				}
			}
		}
		
		[Column(Storage="_productsPricedByAttribute", Name="products_priced_by_attribute", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsPricedByAttribute
		{
			get
			{
				return this._productsPricedByAttribute;
			}
			set
			{
				if ((_productsPricedByAttribute != value))
				{
					this.OnProductsPricedByAttributeChanging(value);
					this.SendPropertyChanging();
					this._productsPricedByAttribute = value;
					this.SendPropertyChanged("ProductsPricedByAttribute");
					this.OnProductsPricedByAttributeChanged();
				}
			}
		}
		
		[Column(Storage="_productsPriceSorter", Name="products_price_sorter", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal ProductsPriceSorter
		{
			get
			{
				return this._productsPriceSorter;
			}
			set
			{
				if ((_productsPriceSorter != value))
				{
					this.OnProductsPriceSorterChanging(value);
					this.SendPropertyChanging();
					this._productsPriceSorter = value;
					this.SendPropertyChanged("ProductsPriceSorter");
					this.OnProductsPriceSorterChanged();
				}
			}
		}
		
		[Column(Storage="_productsQtybOxStatus", Name="products_qty_box_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsQTYBoxStatus
		{
			get
			{
				return this._productsQtybOxStatus;
			}
			set
			{
				if ((_productsQtybOxStatus != value))
				{
					this.OnProductsQTYBoxStatusChanging(value);
					this.SendPropertyChanging();
					this._productsQtybOxStatus = value;
					this.SendPropertyChanged("ProductsQTYBoxStatus");
					this.OnProductsQTYBoxStatusChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantity", Name="products_quantity", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsQuantity
		{
			get
			{
				return this._productsQuantity;
			}
			set
			{
				if ((_productsQuantity != value))
				{
					this.OnProductsQuantityChanging(value);
					this.SendPropertyChanging();
					this._productsQuantity = value;
					this.SendPropertyChanged("ProductsQuantity");
					this.OnProductsQuantityChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantityMixed", Name="products_quantity_mixed", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsQuantityMixed
		{
			get
			{
				return this._productsQuantityMixed;
			}
			set
			{
				if ((_productsQuantityMixed != value))
				{
					this.OnProductsQuantityMixedChanging(value);
					this.SendPropertyChanging();
					this._productsQuantityMixed = value;
					this.SendPropertyChanged("ProductsQuantityMixed");
					this.OnProductsQuantityMixedChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantityOrderMaX", Name="products_quantity_order_max", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsQuantityOrderMaX
		{
			get
			{
				return this._productsQuantityOrderMaX;
			}
			set
			{
				if ((_productsQuantityOrderMaX != value))
				{
					this.OnProductsQuantityOrderMaXChanging(value);
					this.SendPropertyChanging();
					this._productsQuantityOrderMaX = value;
					this.SendPropertyChanged("ProductsQuantityOrderMaX");
					this.OnProductsQuantityOrderMaXChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantityOrderMiN", Name="products_quantity_order_min", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsQuantityOrderMIn
		{
			get
			{
				return this._productsQuantityOrderMiN;
			}
			set
			{
				if ((_productsQuantityOrderMiN != value))
				{
					this.OnProductsQuantityOrderMInChanging(value);
					this.SendPropertyChanging();
					this._productsQuantityOrderMiN = value;
					this.SendPropertyChanged("ProductsQuantityOrderMIn");
					this.OnProductsQuantityOrderMInChanged();
				}
			}
		}
		
		[Column(Storage="_productsQuantityOrderUnits", Name="products_quantity_order_units", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsQuantityOrderUnits
		{
			get
			{
				return this._productsQuantityOrderUnits;
			}
			set
			{
				if ((_productsQuantityOrderUnits != value))
				{
					this.OnProductsQuantityOrderUnitsChanging(value);
					this.SendPropertyChanging();
					this._productsQuantityOrderUnits = value;
					this.SendPropertyChanged("ProductsQuantityOrderUnits");
					this.OnProductsQuantityOrderUnitsChanged();
				}
			}
		}
		
		[Column(Storage="_productsSortOrder", Name="products_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsSortOrder
		{
			get
			{
				return this._productsSortOrder;
			}
			set
			{
				if ((_productsSortOrder != value))
				{
					this.OnProductsSortOrderChanging(value);
					this.SendPropertyChanging();
					this._productsSortOrder = value;
					this.SendPropertyChanged("ProductsSortOrder");
					this.OnProductsSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_productsStatus", Name="products_status", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsStatus
		{
			get
			{
				return this._productsStatus;
			}
			set
			{
				if ((_productsStatus != value))
				{
					this.OnProductsStatusChanging(value);
					this.SendPropertyChanging();
					this._productsStatus = value;
					this.SendPropertyChanged("ProductsStatus");
					this.OnProductsStatusChanged();
				}
			}
		}
		
		[Column(Storage="_productsTaxClassID", Name="products_tax_class_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsTaxClassID
		{
			get
			{
				return this._productsTaxClassID;
			}
			set
			{
				if ((_productsTaxClassID != value))
				{
					this.OnProductsTaxClassIDChanging(value);
					this.SendPropertyChanging();
					this._productsTaxClassID = value;
					this.SendPropertyChanged("ProductsTaxClassID");
					this.OnProductsTaxClassIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsType", Name="products_type", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsType
		{
			get
			{
				return this._productsType;
			}
			set
			{
				if ((_productsType != value))
				{
					this.OnProductsTypeChanging(value);
					this.SendPropertyChanging();
					this._productsType = value;
					this.SendPropertyChanged("ProductsType");
					this.OnProductsTypeChanged();
				}
			}
		}
		
		[Column(Storage="_productsVirtual", Name="products_virtual", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductsVirtual
		{
			get
			{
				return this._productsVirtual;
			}
			set
			{
				if ((_productsVirtual != value))
				{
					this.OnProductsVirtualChanging(value);
					this.SendPropertyChanging();
					this._productsVirtual = value;
					this.SendPropertyChanged("ProductsVirtual");
					this.OnProductsVirtualChanged();
				}
			}
		}
		
		[Column(Storage="_productsWeight", Name="products_weight", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsWeight
		{
			get
			{
				return this._productsWeight;
			}
			set
			{
				if ((_productsWeight != value))
				{
					this.OnProductsWeightChanging(value);
					this.SendPropertyChanging();
					this._productsWeight = value;
					this.SendPropertyChanged("ProductsWeight");
					this.OnProductsWeightChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_attributes")]
	public partial class ProductsAttributes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private sbyte _attributesDefault;
		
		private sbyte _attributesDiscounted;
		
		private sbyte _attributesDisplayOnly;
		
		private string _attributesImage;
		
		private sbyte _attributesPriceBaseIncluded;
		
		private decimal _attributesPriceFactor;
		
		private decimal _attributesPriceFactorOffset;
		
		private decimal _attributesPriceFactorOnetime;
		
		private decimal _attributesPriceFactorOnetimeOffset;
		
		private decimal _attributesPriceLetters;
		
		private int _attributesPriceLettersFree;
		
		private decimal _attributesPriceOnetime;
		
		private decimal _attributesPriceWords;
		
		private int _attributesPriceWordsFree;
		
		private string _attributesQtypRices;
		
		private string _attributesQtypRicesOnetime;
		
		private sbyte _attributesRequired;
		
		private int _optionsID;
		
		private int _optionsValuesID;
		
		private decimal _optionsValuesPrice;
		
		private string _pricePrefix;
		
		private sbyte _productAttributeIsFree;
		
		private int _productsAttributesID;
		
		private float _productsAttributesWeight;
		
		private string _productsAttributesWeightPrefix;
		
		private int _productsID;
		
		private int _productsOptionsSortOrder;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAttributesDefaultChanged();
		
		partial void OnAttributesDefaultChanging(sbyte value);
		
		partial void OnAttributesDiscountedChanged();
		
		partial void OnAttributesDiscountedChanging(sbyte value);
		
		partial void OnAttributesDisplayOnlyChanged();
		
		partial void OnAttributesDisplayOnlyChanging(sbyte value);
		
		partial void OnAttributesImageChanged();
		
		partial void OnAttributesImageChanging(string value);
		
		partial void OnAttributesPriceBaseIncludedChanged();
		
		partial void OnAttributesPriceBaseIncludedChanging(sbyte value);
		
		partial void OnAttributesPriceFactorChanged();
		
		partial void OnAttributesPriceFactorChanging(decimal value);
		
		partial void OnAttributesPriceFactorOffsetChanged();
		
		partial void OnAttributesPriceFactorOffsetChanging(decimal value);
		
		partial void OnAttributesPriceFactorOnetimeChanged();
		
		partial void OnAttributesPriceFactorOnetimeChanging(decimal value);
		
		partial void OnAttributesPriceFactorOnetimeOffsetChanged();
		
		partial void OnAttributesPriceFactorOnetimeOffsetChanging(decimal value);
		
		partial void OnAttributesPriceLettersChanged();
		
		partial void OnAttributesPriceLettersChanging(decimal value);
		
		partial void OnAttributesPriceLettersFreeChanged();
		
		partial void OnAttributesPriceLettersFreeChanging(int value);
		
		partial void OnAttributesPriceOnetimeChanged();
		
		partial void OnAttributesPriceOnetimeChanging(decimal value);
		
		partial void OnAttributesPriceWordsChanged();
		
		partial void OnAttributesPriceWordsChanging(decimal value);
		
		partial void OnAttributesPriceWordsFreeChanged();
		
		partial void OnAttributesPriceWordsFreeChanging(int value);
		
		partial void OnAttributesQTYPricesChanged();
		
		partial void OnAttributesQTYPricesChanging(string value);
		
		partial void OnAttributesQTYPricesOnetimeChanged();
		
		partial void OnAttributesQTYPricesOnetimeChanging(string value);
		
		partial void OnAttributesRequiredChanged();
		
		partial void OnAttributesRequiredChanging(sbyte value);
		
		partial void OnOptionsIDChanged();
		
		partial void OnOptionsIDChanging(int value);
		
		partial void OnOptionsValuesIDChanged();
		
		partial void OnOptionsValuesIDChanging(int value);
		
		partial void OnOptionsValuesPriceChanged();
		
		partial void OnOptionsValuesPriceChanging(decimal value);
		
		partial void OnPricePrefixChanged();
		
		partial void OnPricePrefixChanging(string value);
		
		partial void OnProductAttributeIsFreeChanged();
		
		partial void OnProductAttributeIsFreeChanging(sbyte value);
		
		partial void OnProductsAttributesIDChanged();
		
		partial void OnProductsAttributesIDChanging(int value);
		
		partial void OnProductsAttributesWeightChanged();
		
		partial void OnProductsAttributesWeightChanging(float value);
		
		partial void OnProductsAttributesWeightPrefixChanged();
		
		partial void OnProductsAttributesWeightPrefixChanging(string value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnProductsOptionsSortOrderChanged();
		
		partial void OnProductsOptionsSortOrderChanging(int value);
		#endregion
		
		
		public ProductsAttributes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_attributesDefault", Name="attributes_default", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesDefault
		{
			get
			{
				return this._attributesDefault;
			}
			set
			{
				if ((_attributesDefault != value))
				{
					this.OnAttributesDefaultChanging(value);
					this.SendPropertyChanging();
					this._attributesDefault = value;
					this.SendPropertyChanged("AttributesDefault");
					this.OnAttributesDefaultChanged();
				}
			}
		}
		
		[Column(Storage="_attributesDiscounted", Name="attributes_discounted", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesDiscounted
		{
			get
			{
				return this._attributesDiscounted;
			}
			set
			{
				if ((_attributesDiscounted != value))
				{
					this.OnAttributesDiscountedChanging(value);
					this.SendPropertyChanging();
					this._attributesDiscounted = value;
					this.SendPropertyChanged("AttributesDiscounted");
					this.OnAttributesDiscountedChanged();
				}
			}
		}
		
		[Column(Storage="_attributesDisplayOnly", Name="attributes_display_only", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesDisplayOnly
		{
			get
			{
				return this._attributesDisplayOnly;
			}
			set
			{
				if ((_attributesDisplayOnly != value))
				{
					this.OnAttributesDisplayOnlyChanging(value);
					this.SendPropertyChanging();
					this._attributesDisplayOnly = value;
					this.SendPropertyChanged("AttributesDisplayOnly");
					this.OnAttributesDisplayOnlyChanged();
				}
			}
		}
		
		[Column(Storage="_attributesImage", Name="attributes_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributesImage
		{
			get
			{
				return this._attributesImage;
			}
			set
			{
				if (((_attributesImage == value) 
							== false))
				{
					this.OnAttributesImageChanging(value);
					this.SendPropertyChanging();
					this._attributesImage = value;
					this.SendPropertyChanged("AttributesImage");
					this.OnAttributesImageChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceBaseIncluded", Name="attributes_price_base_included", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesPriceBaseIncluded
		{
			get
			{
				return this._attributesPriceBaseIncluded;
			}
			set
			{
				if ((_attributesPriceBaseIncluded != value))
				{
					this.OnAttributesPriceBaseIncludedChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceBaseIncluded = value;
					this.SendPropertyChanged("AttributesPriceBaseIncluded");
					this.OnAttributesPriceBaseIncludedChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactor", Name="attributes_price_factor", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactor
		{
			get
			{
				return this._attributesPriceFactor;
			}
			set
			{
				if ((_attributesPriceFactor != value))
				{
					this.OnAttributesPriceFactorChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactor = value;
					this.SendPropertyChanged("AttributesPriceFactor");
					this.OnAttributesPriceFactorChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOffset", Name="attributes_price_factor_offset", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOffset
		{
			get
			{
				return this._attributesPriceFactorOffset;
			}
			set
			{
				if ((_attributesPriceFactorOffset != value))
				{
					this.OnAttributesPriceFactorOffsetChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOffset = value;
					this.SendPropertyChanged("AttributesPriceFactorOffset");
					this.OnAttributesPriceFactorOffsetChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOnetime", Name="attributes_price_factor_onetime", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOnetime
		{
			get
			{
				return this._attributesPriceFactorOnetime;
			}
			set
			{
				if ((_attributesPriceFactorOnetime != value))
				{
					this.OnAttributesPriceFactorOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOnetime = value;
					this.SendPropertyChanged("AttributesPriceFactorOnetime");
					this.OnAttributesPriceFactorOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceFactorOnetimeOffset", Name="attributes_price_factor_onetime_offset", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceFactorOnetimeOffset
		{
			get
			{
				return this._attributesPriceFactorOnetimeOffset;
			}
			set
			{
				if ((_attributesPriceFactorOnetimeOffset != value))
				{
					this.OnAttributesPriceFactorOnetimeOffsetChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceFactorOnetimeOffset = value;
					this.SendPropertyChanged("AttributesPriceFactorOnetimeOffset");
					this.OnAttributesPriceFactorOnetimeOffsetChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceLetters", Name="attributes_price_letters", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceLetters
		{
			get
			{
				return this._attributesPriceLetters;
			}
			set
			{
				if ((_attributesPriceLetters != value))
				{
					this.OnAttributesPriceLettersChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceLetters = value;
					this.SendPropertyChanged("AttributesPriceLetters");
					this.OnAttributesPriceLettersChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceLettersFree", Name="attributes_price_letters_free", DbType="int(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AttributesPriceLettersFree
		{
			get
			{
				return this._attributesPriceLettersFree;
			}
			set
			{
				if ((_attributesPriceLettersFree != value))
				{
					this.OnAttributesPriceLettersFreeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceLettersFree = value;
					this.SendPropertyChanged("AttributesPriceLettersFree");
					this.OnAttributesPriceLettersFreeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceOnetime", Name="attributes_price_onetime", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceOnetime
		{
			get
			{
				return this._attributesPriceOnetime;
			}
			set
			{
				if ((_attributesPriceOnetime != value))
				{
					this.OnAttributesPriceOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceOnetime = value;
					this.SendPropertyChanged("AttributesPriceOnetime");
					this.OnAttributesPriceOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceWords", Name="attributes_price_words", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal AttributesPriceWords
		{
			get
			{
				return this._attributesPriceWords;
			}
			set
			{
				if ((_attributesPriceWords != value))
				{
					this.OnAttributesPriceWordsChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceWords = value;
					this.SendPropertyChanged("AttributesPriceWords");
					this.OnAttributesPriceWordsChanged();
				}
			}
		}
		
		[Column(Storage="_attributesPriceWordsFree", Name="attributes_price_words_free", DbType="int(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AttributesPriceWordsFree
		{
			get
			{
				return this._attributesPriceWordsFree;
			}
			set
			{
				if ((_attributesPriceWordsFree != value))
				{
					this.OnAttributesPriceWordsFreeChanging(value);
					this.SendPropertyChanging();
					this._attributesPriceWordsFree = value;
					this.SendPropertyChanged("AttributesPriceWordsFree");
					this.OnAttributesPriceWordsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesQtypRices", Name="attributes_qty_prices", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributesQTYPrices
		{
			get
			{
				return this._attributesQtypRices;
			}
			set
			{
				if (((_attributesQtypRices == value) 
							== false))
				{
					this.OnAttributesQTYPricesChanging(value);
					this.SendPropertyChanging();
					this._attributesQtypRices = value;
					this.SendPropertyChanged("AttributesQTYPrices");
					this.OnAttributesQTYPricesChanged();
				}
			}
		}
		
		[Column(Storage="_attributesQtypRicesOnetime", Name="attributes_qty_prices_onetime", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string AttributesQTYPricesOnetime
		{
			get
			{
				return this._attributesQtypRicesOnetime;
			}
			set
			{
				if (((_attributesQtypRicesOnetime == value) 
							== false))
				{
					this.OnAttributesQTYPricesOnetimeChanging(value);
					this.SendPropertyChanging();
					this._attributesQtypRicesOnetime = value;
					this.SendPropertyChanged("AttributesQTYPricesOnetime");
					this.OnAttributesQTYPricesOnetimeChanged();
				}
			}
		}
		
		[Column(Storage="_attributesRequired", Name="attributes_required", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte AttributesRequired
		{
			get
			{
				return this._attributesRequired;
			}
			set
			{
				if ((_attributesRequired != value))
				{
					this.OnAttributesRequiredChanging(value);
					this.SendPropertyChanging();
					this._attributesRequired = value;
					this.SendPropertyChanged("AttributesRequired");
					this.OnAttributesRequiredChanged();
				}
			}
		}
		
		[Column(Storage="_optionsID", Name="options_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OptionsID
		{
			get
			{
				return this._optionsID;
			}
			set
			{
				if ((_optionsID != value))
				{
					this.OnOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._optionsID = value;
					this.SendPropertyChanged("OptionsID");
					this.OnOptionsIDChanged();
				}
			}
		}
		
		[Column(Storage="_optionsValuesID", Name="options_values_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int OptionsValuesID
		{
			get
			{
				return this._optionsValuesID;
			}
			set
			{
				if ((_optionsValuesID != value))
				{
					this.OnOptionsValuesIDChanging(value);
					this.SendPropertyChanging();
					this._optionsValuesID = value;
					this.SendPropertyChanged("OptionsValuesID");
					this.OnOptionsValuesIDChanged();
				}
			}
		}
		
		[Column(Storage="_optionsValuesPrice", Name="options_values_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal OptionsValuesPrice
		{
			get
			{
				return this._optionsValuesPrice;
			}
			set
			{
				if ((_optionsValuesPrice != value))
				{
					this.OnOptionsValuesPriceChanging(value);
					this.SendPropertyChanging();
					this._optionsValuesPrice = value;
					this.SendPropertyChanged("OptionsValuesPrice");
					this.OnOptionsValuesPriceChanged();
				}
			}
		}
		
		[Column(Storage="_pricePrefix", Name="price_prefix", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string PricePrefix
		{
			get
			{
				return this._pricePrefix;
			}
			set
			{
				if (((_pricePrefix == value) 
							== false))
				{
					this.OnPricePrefixChanging(value);
					this.SendPropertyChanging();
					this._pricePrefix = value;
					this.SendPropertyChanged("PricePrefix");
					this.OnPricePrefixChanged();
				}
			}
		}
		
		[Column(Storage="_productAttributeIsFree", Name="product_attribute_is_free", DbType="tinyint(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProductAttributeIsFree
		{
			get
			{
				return this._productAttributeIsFree;
			}
			set
			{
				if ((_productAttributeIsFree != value))
				{
					this.OnProductAttributeIsFreeChanging(value);
					this.SendPropertyChanging();
					this._productAttributeIsFree = value;
					this.SendPropertyChanged("ProductAttributeIsFree");
					this.OnProductAttributeIsFreeChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesID", Name="products_attributes_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsAttributesID
		{
			get
			{
				return this._productsAttributesID;
			}
			set
			{
				if ((_productsAttributesID != value))
				{
					this.OnProductsAttributesIDChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesID = value;
					this.SendPropertyChanged("ProductsAttributesID");
					this.OnProductsAttributesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesWeight", Name="products_attributes_weight", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float ProductsAttributesWeight
		{
			get
			{
				return this._productsAttributesWeight;
			}
			set
			{
				if ((_productsAttributesWeight != value))
				{
					this.OnProductsAttributesWeightChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesWeight = value;
					this.SendPropertyChanged("ProductsAttributesWeight");
					this.OnProductsAttributesWeightChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesWeightPrefix", Name="products_attributes_weight_prefix", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsAttributesWeightPrefix
		{
			get
			{
				return this._productsAttributesWeightPrefix;
			}
			set
			{
				if (((_productsAttributesWeightPrefix == value) 
							== false))
				{
					this.OnProductsAttributesWeightPrefixChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesWeightPrefix = value;
					this.SendPropertyChanged("ProductsAttributesWeightPrefix");
					this.OnProductsAttributesWeightPrefixChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsSortOrder", Name="products_options_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsSortOrder
		{
			get
			{
				return this._productsOptionsSortOrder;
			}
			set
			{
				if ((_productsOptionsSortOrder != value))
				{
					this.OnProductsOptionsSortOrderChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsSortOrder = value;
					this.SendPropertyChanged("ProductsOptionsSortOrder");
					this.OnProductsOptionsSortOrderChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_attributes_download")]
	public partial class ProductsAttributesDownload : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _productsAttributesFilename;
		
		private int _productsAttributesID;
		
		private System.Nullable<int> _productsAttributesMaXcOunt;
		
		private System.Nullable<int> _productsAttributesMaXdAys;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProductsAttributesFilenameChanged();
		
		partial void OnProductsAttributesFilenameChanging(string value);
		
		partial void OnProductsAttributesIDChanged();
		
		partial void OnProductsAttributesIDChanging(int value);
		
		partial void OnProductsAttributesMaXCountChanged();
		
		partial void OnProductsAttributesMaXCountChanging(System.Nullable<int> value);
		
		partial void OnProductsAttributesMaXDaysChanged();
		
		partial void OnProductsAttributesMaXDaysChanging(System.Nullable<int> value);
		#endregion
		
		
		public ProductsAttributesDownload()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_productsAttributesFilename", Name="products_attributes_filename", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsAttributesFilename
		{
			get
			{
				return this._productsAttributesFilename;
			}
			set
			{
				if (((_productsAttributesFilename == value) 
							== false))
				{
					this.OnProductsAttributesFilenameChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesFilename = value;
					this.SendPropertyChanged("ProductsAttributesFilename");
					this.OnProductsAttributesFilenameChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesID", Name="products_attributes_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsAttributesID
		{
			get
			{
				return this._productsAttributesID;
			}
			set
			{
				if ((_productsAttributesID != value))
				{
					this.OnProductsAttributesIDChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesID = value;
					this.SendPropertyChanged("ProductsAttributesID");
					this.OnProductsAttributesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesMaXcOunt", Name="products_attributes_maxcount", DbType="int(2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProductsAttributesMaXCount
		{
			get
			{
				return this._productsAttributesMaXcOunt;
			}
			set
			{
				if ((_productsAttributesMaXcOunt != value))
				{
					this.OnProductsAttributesMaXCountChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesMaXcOunt = value;
					this.SendPropertyChanged("ProductsAttributesMaXCount");
					this.OnProductsAttributesMaXCountChanged();
				}
			}
		}
		
		[Column(Storage="_productsAttributesMaXdAys", Name="products_attributes_maxdays", DbType="int(2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProductsAttributesMaXDays
		{
			get
			{
				return this._productsAttributesMaXdAys;
			}
			set
			{
				if ((_productsAttributesMaXdAys != value))
				{
					this.OnProductsAttributesMaXDaysChanging(value);
					this.SendPropertyChanging();
					this._productsAttributesMaXdAys = value;
					this.SendPropertyChanged("ProductsAttributesMaXDays");
					this.OnProductsAttributesMaXDaysChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_description")]
	public partial class ProductsDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private string _productsDescription1;
		
		private int _productsID;
		
		private string _productsImages;
		
		private string _productsName;
		
		private string _productsUrl;
		
		private System.Nullable<int> _productsViewed;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnProductsDescription1Changed();
		
		partial void OnProductsDescription1Changing(string value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnProductsImagesChanged();
		
		partial void OnProductsImagesChanging(string value);
		
		partial void OnProductsNameChanged();
		
		partial void OnProductsNameChanging(string value);
		
		partial void OnProductsURLChanged();
		
		partial void OnProductsURLChanging(string value);
		
		partial void OnProductsViewedChanged();
		
		partial void OnProductsViewedChanging(System.Nullable<int> value);
		#endregion
		
		
		public ProductsDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsDescription1", Name="products_description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsDescription1
		{
			get
			{
				return this._productsDescription1;
			}
			set
			{
				if (((_productsDescription1 == value) 
							== false))
				{
					this.OnProductsDescription1Changing(value);
					this.SendPropertyChanging();
					this._productsDescription1 = value;
					this.SendPropertyChanged("ProductsDescription1");
					this.OnProductsDescription1Changed();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsImages", Name="products_images", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsImages
		{
			get
			{
				return this._productsImages;
			}
			set
			{
				if (((_productsImages == value) 
							== false))
				{
					this.OnProductsImagesChanging(value);
					this.SendPropertyChanging();
					this._productsImages = value;
					this.SendPropertyChanged("ProductsImages");
					this.OnProductsImagesChanged();
				}
			}
		}
		
		[Column(Storage="_productsName", Name="products_name", DbType="varchar(200)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsName
		{
			get
			{
				return this._productsName;
			}
			set
			{
				if (((_productsName == value) 
							== false))
				{
					this.OnProductsNameChanging(value);
					this.SendPropertyChanging();
					this._productsName = value;
					this.SendPropertyChanged("ProductsName");
					this.OnProductsNameChanged();
				}
			}
		}
		
		[Column(Storage="_productsUrl", Name="products_url", DbType="varchar(255)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsURL
		{
			get
			{
				return this._productsUrl;
			}
			set
			{
				if (((_productsUrl == value) 
							== false))
				{
					this.OnProductsURLChanging(value);
					this.SendPropertyChanging();
					this._productsUrl = value;
					this.SendPropertyChanged("ProductsURL");
					this.OnProductsURLChanged();
				}
			}
		}
		
		[Column(Storage="_productsViewed", Name="products_viewed", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProductsViewed
		{
			get
			{
				return this._productsViewed;
			}
			set
			{
				if ((_productsViewed != value))
				{
					this.OnProductsViewedChanging(value);
					this.SendPropertyChanging();
					this._productsViewed = value;
					this.SendPropertyChanged("ProductsViewed");
					this.OnProductsViewedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_discount_quantity")]
	public partial class ProductsDiscountQuantity
	{
		
		private int _discountID;
		
		private decimal _discountPrice;
		
		private float _discountQty;
		
		private int _productsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDiscountIDChanged();
		
		partial void OnDiscountIDChanging(int value);
		
		partial void OnDiscountPriceChanged();
		
		partial void OnDiscountPriceChanging(decimal value);
		
		partial void OnDiscountQTYChanged();
		
		partial void OnDiscountQTYChanging(float value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		#endregion
		
		
		public ProductsDiscountQuantity()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_discountID", Name="discount_id", DbType="int(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int DiscountID
		{
			get
			{
				return this._discountID;
			}
			set
			{
				if ((_discountID != value))
				{
					this.OnDiscountIDChanging(value);
					this._discountID = value;
					this.OnDiscountIDChanged();
				}
			}
		}
		
		[Column(Storage="_discountPrice", Name="discount_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal DiscountPrice
		{
			get
			{
				return this._discountPrice;
			}
			set
			{
				if ((_discountPrice != value))
				{
					this.OnDiscountPriceChanging(value);
					this._discountPrice = value;
					this.OnDiscountPriceChanged();
				}
			}
		}
		
		[Column(Storage="_discountQty", Name="discount_qty", DbType="float", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public float DiscountQTY
		{
			get
			{
				return this._discountQty;
			}
			set
			{
				if ((_discountQty != value))
				{
					this.OnDiscountQTYChanging(value);
					this._discountQty = value;
					this.OnDiscountQTYChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this._productsID = value;
					this.OnProductsIDChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_notifications")]
	public partial class ProductsNotifications : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _customersID;
		
		private System.DateTime _dateAdded;
		
		private int _productsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(int value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		#endregion
		
		
		public ProductsNotifications()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_options")]
	public partial class ProductsOptions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private string _productsOptionsComment;
		
		private int _productsOptionsID;
		
		private System.Nullable<int> _productsOptionsImagesPerRow;
		
		private System.Nullable<int> _productsOptionsImagesStyle;
		
		private short _productsOptionsLength;
		
		private string _productsOptionsName;
		
		private short _productsOptionsRows;
		
		private short _productsOptionsSize;
		
		private int _productsOptionsSortOrder;
		
		private int _productsOptionsType;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnProductsOptionsCommentChanged();
		
		partial void OnProductsOptionsCommentChanging(string value);
		
		partial void OnProductsOptionsIDChanged();
		
		partial void OnProductsOptionsIDChanging(int value);
		
		partial void OnProductsOptionsImagesPerRowChanged();
		
		partial void OnProductsOptionsImagesPerRowChanging(System.Nullable<int> value);
		
		partial void OnProductsOptionsImagesStyleChanged();
		
		partial void OnProductsOptionsImagesStyleChanging(System.Nullable<int> value);
		
		partial void OnProductsOptionsLengthChanged();
		
		partial void OnProductsOptionsLengthChanging(short value);
		
		partial void OnProductsOptionsNameChanged();
		
		partial void OnProductsOptionsNameChanging(string value);
		
		partial void OnProductsOptionsRowsChanged();
		
		partial void OnProductsOptionsRowsChanging(short value);
		
		partial void OnProductsOptionsSizeChanged();
		
		partial void OnProductsOptionsSizeChanging(short value);
		
		partial void OnProductsOptionsSortOrderChanged();
		
		partial void OnProductsOptionsSortOrderChanging(int value);
		
		partial void OnProductsOptionsTypeChanged();
		
		partial void OnProductsOptionsTypeChanging(int value);
		#endregion
		
		
		public ProductsOptions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsComment", Name="products_options_comment", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsComment
		{
			get
			{
				return this._productsOptionsComment;
			}
			set
			{
				if (((_productsOptionsComment == value) 
							== false))
				{
					this.OnProductsOptionsCommentChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsComment = value;
					this.SendPropertyChanged("ProductsOptionsComment");
					this.OnProductsOptionsCommentChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsID", Name="products_options_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsID
		{
			get
			{
				return this._productsOptionsID;
			}
			set
			{
				if ((_productsOptionsID != value))
				{
					this.OnProductsOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsID = value;
					this.SendPropertyChanged("ProductsOptionsID");
					this.OnProductsOptionsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsImagesPerRow", Name="products_options_images_per_row", DbType="int(2)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProductsOptionsImagesPerRow
		{
			get
			{
				return this._productsOptionsImagesPerRow;
			}
			set
			{
				if ((_productsOptionsImagesPerRow != value))
				{
					this.OnProductsOptionsImagesPerRowChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsImagesPerRow = value;
					this.SendPropertyChanged("ProductsOptionsImagesPerRow");
					this.OnProductsOptionsImagesPerRowChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsImagesStyle", Name="products_options_images_style", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ProductsOptionsImagesStyle
		{
			get
			{
				return this._productsOptionsImagesStyle;
			}
			set
			{
				if ((_productsOptionsImagesStyle != value))
				{
					this.OnProductsOptionsImagesStyleChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsImagesStyle = value;
					this.SendPropertyChanged("ProductsOptionsImagesStyle");
					this.OnProductsOptionsImagesStyleChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsLength", Name="products_options_length", DbType="smallint(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public short ProductsOptionsLength
		{
			get
			{
				return this._productsOptionsLength;
			}
			set
			{
				if ((_productsOptionsLength != value))
				{
					this.OnProductsOptionsLengthChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsLength = value;
					this.SendPropertyChanged("ProductsOptionsLength");
					this.OnProductsOptionsLengthChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsName", Name="products_options_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsName
		{
			get
			{
				return this._productsOptionsName;
			}
			set
			{
				if (((_productsOptionsName == value) 
							== false))
				{
					this.OnProductsOptionsNameChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsName = value;
					this.SendPropertyChanged("ProductsOptionsName");
					this.OnProductsOptionsNameChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsRows", Name="products_options_rows", DbType="smallint(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public short ProductsOptionsRows
		{
			get
			{
				return this._productsOptionsRows;
			}
			set
			{
				if ((_productsOptionsRows != value))
				{
					this.OnProductsOptionsRowsChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsRows = value;
					this.SendPropertyChanged("ProductsOptionsRows");
					this.OnProductsOptionsRowsChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsSize", Name="products_options_size", DbType="smallint(2)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public short ProductsOptionsSize
		{
			get
			{
				return this._productsOptionsSize;
			}
			set
			{
				if ((_productsOptionsSize != value))
				{
					this.OnProductsOptionsSizeChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsSize = value;
					this.SendPropertyChanged("ProductsOptionsSize");
					this.OnProductsOptionsSizeChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsSortOrder", Name="products_options_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsSortOrder
		{
			get
			{
				return this._productsOptionsSortOrder;
			}
			set
			{
				if ((_productsOptionsSortOrder != value))
				{
					this.OnProductsOptionsSortOrderChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsSortOrder = value;
					this.SendPropertyChanged("ProductsOptionsSortOrder");
					this.OnProductsOptionsSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsType", Name="products_options_type", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsType
		{
			get
			{
				return this._productsOptionsType;
			}
			set
			{
				if ((_productsOptionsType != value))
				{
					this.OnProductsOptionsTypeChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsType = value;
					this.SendPropertyChanged("ProductsOptionsType");
					this.OnProductsOptionsTypeChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_options_types")]
	public partial class ProductsOptionsTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _productsOptionsTypesID;
		
		private string _productsOptionsTypesName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProductsOptionsTypesIDChanged();
		
		partial void OnProductsOptionsTypesIDChanging(int value);
		
		partial void OnProductsOptionsTypesNameChanged();
		
		partial void OnProductsOptionsTypesNameChanging(string value);
		#endregion
		
		
		public ProductsOptionsTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_productsOptionsTypesID", Name="products_options_types_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsTypesID
		{
			get
			{
				return this._productsOptionsTypesID;
			}
			set
			{
				if ((_productsOptionsTypesID != value))
				{
					this.OnProductsOptionsTypesIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsTypesID = value;
					this.SendPropertyChanged("ProductsOptionsTypesID");
					this.OnProductsOptionsTypesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsTypesName", Name="products_options_types_name", DbType="varchar(32)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsTypesName
		{
			get
			{
				return this._productsOptionsTypesName;
			}
			set
			{
				if (((_productsOptionsTypesName == value) 
							== false))
				{
					this.OnProductsOptionsTypesNameChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsTypesName = value;
					this.SendPropertyChanged("ProductsOptionsTypesName");
					this.OnProductsOptionsTypesNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_options_values")]
	public partial class ProductsOptionsValues : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languageID;
		
		private int _productsOptionsValuesID;
		
		private string _productsOptionsValuesName;
		
		private int _productsOptionsValuesSortOrder;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(int value);
		
		partial void OnProductsOptionsValuesIDChanged();
		
		partial void OnProductsOptionsValuesIDChanging(int value);
		
		partial void OnProductsOptionsValuesNameChanged();
		
		partial void OnProductsOptionsValuesNameChanging(string value);
		
		partial void OnProductsOptionsValuesSortOrderChanged();
		
		partial void OnProductsOptionsValuesSortOrderChanging(int value);
		#endregion
		
		
		public ProductsOptionsValues()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesID", Name="products_options_values_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValuesID
		{
			get
			{
				return this._productsOptionsValuesID;
			}
			set
			{
				if ((_productsOptionsValuesID != value))
				{
					this.OnProductsOptionsValuesIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesID = value;
					this.SendPropertyChanged("ProductsOptionsValuesID");
					this.OnProductsOptionsValuesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesName", Name="products_options_values_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProductsOptionsValuesName
		{
			get
			{
				return this._productsOptionsValuesName;
			}
			set
			{
				if (((_productsOptionsValuesName == value) 
							== false))
				{
					this.OnProductsOptionsValuesNameChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesName = value;
					this.SendPropertyChanged("ProductsOptionsValuesName");
					this.OnProductsOptionsValuesNameChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesSortOrder", Name="products_options_values_sort_order", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValuesSortOrder
		{
			get
			{
				return this._productsOptionsValuesSortOrder;
			}
			set
			{
				if ((_productsOptionsValuesSortOrder != value))
				{
					this.OnProductsOptionsValuesSortOrderChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesSortOrder = value;
					this.SendPropertyChanged("ProductsOptionsValuesSortOrder");
					this.OnProductsOptionsValuesSortOrderChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_options_values_to_products_options")]
	public partial class ProductsOptionsValuesToProductsOptions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _productsOptionsID;
		
		private int _productsOptionsValuesID;
		
		private int _productsOptionsValuesToProductsOptionsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProductsOptionsIDChanged();
		
		partial void OnProductsOptionsIDChanging(int value);
		
		partial void OnProductsOptionsValuesIDChanged();
		
		partial void OnProductsOptionsValuesIDChanging(int value);
		
		partial void OnProductsOptionsValuesToProductsOptionsIDChanged();
		
		partial void OnProductsOptionsValuesToProductsOptionsIDChanging(int value);
		#endregion
		
		
		public ProductsOptionsValuesToProductsOptions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_productsOptionsID", Name="products_options_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsID
		{
			get
			{
				return this._productsOptionsID;
			}
			set
			{
				if ((_productsOptionsID != value))
				{
					this.OnProductsOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsID = value;
					this.SendPropertyChanged("ProductsOptionsID");
					this.OnProductsOptionsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesID", Name="products_options_values_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValuesID
		{
			get
			{
				return this._productsOptionsValuesID;
			}
			set
			{
				if ((_productsOptionsValuesID != value))
				{
					this.OnProductsOptionsValuesIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesID = value;
					this.SendPropertyChanged("ProductsOptionsValuesID");
					this.OnProductsOptionsValuesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsOptionsValuesToProductsOptionsID", Name="products_options_values_to_products_options_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsOptionsValuesToProductsOptionsID
		{
			get
			{
				return this._productsOptionsValuesToProductsOptionsID;
			}
			set
			{
				if ((_productsOptionsValuesToProductsOptionsID != value))
				{
					this.OnProductsOptionsValuesToProductsOptionsIDChanging(value);
					this.SendPropertyChanging();
					this._productsOptionsValuesToProductsOptionsID = value;
					this.SendPropertyChanged("ProductsOptionsValuesToProductsOptionsID");
					this.OnProductsOptionsValuesToProductsOptionsIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.products_to_categories")]
	public partial class ProductsToCategories : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _categoriesID;
		
		private int _productsID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoriesIDChanged();
		
		partial void OnCategoriesIDChanging(int value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		#endregion
		
		
		public ProductsToCategories()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoriesID", Name="categories_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoriesID
		{
			get
			{
				return this._categoriesID;
			}
			set
			{
				if ((_categoriesID != value))
				{
					this.OnCategoriesIDChanging(value);
					this.SendPropertyChanging();
					this._categoriesID = value;
					this.SendPropertyChanged("CategoriesID");
					this.OnCategoriesIDChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.product_type_layout")]
	public partial class ProductTypeLayout : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _configurationDescription;
		
		private int _configurationID;
		
		private string _configurationKey;
		
		private string _configurationTitle;
		
		private string _configurationValue;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _productTypeID;
		
		private string _setFunction;
		
		private System.Nullable<int> _sortOrder;
		
		private string _useFunction;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnConfigurationDescriptionChanged();
		
		partial void OnConfigurationDescriptionChanging(string value);
		
		partial void OnConfigurationIDChanged();
		
		partial void OnConfigurationIDChanging(int value);
		
		partial void OnConfigurationKeyChanged();
		
		partial void OnConfigurationKeyChanging(string value);
		
		partial void OnConfigurationTitleChanged();
		
		partial void OnConfigurationTitleChanging(string value);
		
		partial void OnConfigurationValueChanged();
		
		partial void OnConfigurationValueChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnProductTypeIDChanged();
		
		partial void OnProductTypeIDChanging(int value);
		
		partial void OnSetFunctionChanged();
		
		partial void OnSetFunctionChanging(string value);
		
		partial void OnSortOrderChanged();
		
		partial void OnSortOrderChanging(System.Nullable<int> value);
		
		partial void OnUseFunctionChanged();
		
		partial void OnUseFunctionChanging(string value);
		#endregion
		
		
		public ProductTypeLayout()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_configurationDescription", Name="configuration_description", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationDescription
		{
			get
			{
				return this._configurationDescription;
			}
			set
			{
				if (((_configurationDescription == value) 
							== false))
				{
					this.OnConfigurationDescriptionChanging(value);
					this.SendPropertyChanging();
					this._configurationDescription = value;
					this.SendPropertyChanged("ConfigurationDescription");
					this.OnConfigurationDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_configurationID", Name="configuration_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ConfigurationID
		{
			get
			{
				return this._configurationID;
			}
			set
			{
				if ((_configurationID != value))
				{
					this.OnConfigurationIDChanging(value);
					this.SendPropertyChanging();
					this._configurationID = value;
					this.SendPropertyChanged("ConfigurationID");
					this.OnConfigurationIDChanged();
				}
			}
		}
		
		[Column(Storage="_configurationKey", Name="configuration_key", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationKey
		{
			get
			{
				return this._configurationKey;
			}
			set
			{
				if (((_configurationKey == value) 
							== false))
				{
					this.OnConfigurationKeyChanging(value);
					this.SendPropertyChanging();
					this._configurationKey = value;
					this.SendPropertyChanged("ConfigurationKey");
					this.OnConfigurationKeyChanged();
				}
			}
		}
		
		[Column(Storage="_configurationTitle", Name="configuration_title", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationTitle
		{
			get
			{
				return this._configurationTitle;
			}
			set
			{
				if (((_configurationTitle == value) 
							== false))
				{
					this.OnConfigurationTitleChanging(value);
					this.SendPropertyChanging();
					this._configurationTitle = value;
					this.SendPropertyChanged("ConfigurationTitle");
					this.OnConfigurationTitleChanged();
				}
			}
		}
		
		[Column(Storage="_configurationValue", Name="configuration_value", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ConfigurationValue
		{
			get
			{
				return this._configurationValue;
			}
			set
			{
				if (((_configurationValue == value) 
							== false))
				{
					this.OnConfigurationValueChanging(value);
					this.SendPropertyChanging();
					this._configurationValue = value;
					this.SendPropertyChanged("ConfigurationValue");
					this.OnConfigurationValueChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_productTypeID", Name="product_type_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductTypeID
		{
			get
			{
				return this._productTypeID;
			}
			set
			{
				if ((_productTypeID != value))
				{
					this.OnProductTypeIDChanging(value);
					this.SendPropertyChanging();
					this._productTypeID = value;
					this.SendPropertyChanged("ProductTypeID");
					this.OnProductTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_setFunction", Name="set_function", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SetFunction
		{
			get
			{
				return this._setFunction;
			}
			set
			{
				if (((_setFunction == value) 
							== false))
				{
					this.OnSetFunctionChanging(value);
					this.SendPropertyChanging();
					this._setFunction = value;
					this.SendPropertyChanged("SetFunction");
					this.OnSetFunctionChanged();
				}
			}
		}
		
		[Column(Storage="_sortOrder", Name="sort_order", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> SortOrder
		{
			get
			{
				return this._sortOrder;
			}
			set
			{
				if ((_sortOrder != value))
				{
					this.OnSortOrderChanging(value);
					this.SendPropertyChanging();
					this._sortOrder = value;
					this.SendPropertyChanged("SortOrder");
					this.OnSortOrderChanged();
				}
			}
		}
		
		[Column(Storage="_useFunction", Name="use_function", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string UseFunction
		{
			get
			{
				return this._useFunction;
			}
			set
			{
				if (((_useFunction == value) 
							== false))
				{
					this.OnUseFunctionChanging(value);
					this.SendPropertyChanging();
					this._useFunction = value;
					this.SendPropertyChanged("UseFunction");
					this.OnUseFunctionChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.product_types")]
	public partial class ProductTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _allowAddToCart;
		
		private System.DateTime _dateAdded;
		
		private string _defaultImage;
		
		private System.DateTime _lastModified;
		
		private string _typeHandler;
		
		private int _typeID;
		
		private int _typeMasterType;
		
		private string _typeName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAllowAddToCartChanged();
		
		partial void OnAllowAddToCartChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnDefaultImageChanged();
		
		partial void OnDefaultImageChanging(string value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.DateTime value);
		
		partial void OnTypeHandlerChanged();
		
		partial void OnTypeHandlerChanging(string value);
		
		partial void OnTypeIDChanged();
		
		partial void OnTypeIDChanging(int value);
		
		partial void OnTypeMasterTypeChanged();
		
		partial void OnTypeMasterTypeChanging(int value);
		
		partial void OnTypeNameChanged();
		
		partial void OnTypeNameChanging(string value);
		#endregion
		
		
		public ProductTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_allowAddToCart", Name="allow_add_to_cart", DbType="char(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string AllowAddToCart
		{
			get
			{
				return this._allowAddToCart;
			}
			set
			{
				if (((_allowAddToCart == value) 
							== false))
				{
					this.OnAllowAddToCartChanging(value);
					this.SendPropertyChanging();
					this._allowAddToCart = value;
					this.SendPropertyChanged("AllowAddToCart");
					this.OnAllowAddToCartChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_defaultImage", Name="default_image", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string DefaultImage
		{
			get
			{
				return this._defaultImage;
			}
			set
			{
				if (((_defaultImage == value) 
							== false))
				{
					this.OnDefaultImageChanging(value);
					this.SendPropertyChanging();
					this._defaultImage = value;
					this.SendPropertyChanged("DefaultImage");
					this.OnDefaultImageChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_typeHandler", Name="type_handler", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TypeHandler
		{
			get
			{
				return this._typeHandler;
			}
			set
			{
				if (((_typeHandler == value) 
							== false))
				{
					this.OnTypeHandlerChanging(value);
					this.SendPropertyChanging();
					this._typeHandler = value;
					this.SendPropertyChanged("TypeHandler");
					this.OnTypeHandlerChanged();
				}
			}
		}
		
		[Column(Storage="_typeID", Name="type_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TypeID
		{
			get
			{
				return this._typeID;
			}
			set
			{
				if ((_typeID != value))
				{
					this.OnTypeIDChanging(value);
					this.SendPropertyChanging();
					this._typeID = value;
					this.SendPropertyChanged("TypeID");
					this.OnTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_typeMasterType", Name="type_master_type", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TypeMasterType
		{
			get
			{
				return this._typeMasterType;
			}
			set
			{
				if ((_typeMasterType != value))
				{
					this.OnTypeMasterTypeChanging(value);
					this.SendPropertyChanging();
					this._typeMasterType = value;
					this.SendPropertyChanged("TypeMasterType");
					this.OnTypeMasterTypeChanged();
				}
			}
		}
		
		[Column(Storage="_typeName", Name="type_name", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TypeName
		{
			get
			{
				return this._typeName;
			}
			set
			{
				if (((_typeName == value) 
							== false))
				{
					this.OnTypeNameChanging(value);
					this.SendPropertyChanging();
					this._typeName = value;
					this.SendPropertyChanged("TypeName");
					this.OnTypeNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.product_types_to_category")]
	public partial class ProductTypesToCategory
	{
		
		private int _categoryID;
		
		private int _productTypeID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCategoryIDChanged();
		
		partial void OnCategoryIDChanging(int value);
		
		partial void OnProductTypeIDChanged();
		
		partial void OnProductTypeIDChanging(int value);
		#endregion
		
		
		public ProductTypesToCategory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_categoryID", Name="category_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int CategoryID
		{
			get
			{
				return this._categoryID;
			}
			set
			{
				if ((_categoryID != value))
				{
					this.OnCategoryIDChanging(value);
					this._categoryID = value;
					this.OnCategoryIDChanged();
				}
			}
		}
		
		[Column(Storage="_productTypeID", Name="product_type_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductTypeID
		{
			get
			{
				return this._productTypeID;
			}
			set
			{
				if ((_productTypeID != value))
				{
					this.OnProductTypeIDChanging(value);
					this._productTypeID = value;
					this.OnProductTypeIDChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.project_version")]
	public partial class ProjectVersion : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _projectVersionComment;
		
		private System.DateTime _projectVersionDateApplied;
		
		private sbyte _projectVersionID;
		
		private string _projectVersionKey;
		
		private string _projectVersionMajor;
		
		private string _projectVersionMinor;
		
		private string _projectVersionPatch1;
		
		private string _projectVersionPatch1sOurce;
		
		private string _projectVersionPatch2;
		
		private string _projectVersionPatch2sOurce;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProjectVersionCommentChanged();
		
		partial void OnProjectVersionCommentChanging(string value);
		
		partial void OnProjectVersionDateAppliedChanged();
		
		partial void OnProjectVersionDateAppliedChanging(System.DateTime value);
		
		partial void OnProjectVersionIDChanged();
		
		partial void OnProjectVersionIDChanging(sbyte value);
		
		partial void OnProjectVersionKeyChanged();
		
		partial void OnProjectVersionKeyChanging(string value);
		
		partial void OnProjectVersionMajorChanged();
		
		partial void OnProjectVersionMajorChanging(string value);
		
		partial void OnProjectVersionMinorChanged();
		
		partial void OnProjectVersionMinorChanging(string value);
		
		partial void OnProjectVersionPatch1Changed();
		
		partial void OnProjectVersionPatch1Changing(string value);
		
		partial void OnProjectVersionPatch1SourceChanged();
		
		partial void OnProjectVersionPatch1SourceChanging(string value);
		
		partial void OnProjectVersionPatch2Changed();
		
		partial void OnProjectVersionPatch2Changing(string value);
		
		partial void OnProjectVersionPatch2SourceChanged();
		
		partial void OnProjectVersionPatch2SourceChanging(string value);
		#endregion
		
		
		public ProjectVersion()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_projectVersionComment", Name="project_version_comment", DbType="varchar(250)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionComment
		{
			get
			{
				return this._projectVersionComment;
			}
			set
			{
				if (((_projectVersionComment == value) 
							== false))
				{
					this.OnProjectVersionCommentChanging(value);
					this.SendPropertyChanging();
					this._projectVersionComment = value;
					this.SendPropertyChanged("ProjectVersionComment");
					this.OnProjectVersionCommentChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionDateApplied", Name="project_version_date_applied", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ProjectVersionDateApplied
		{
			get
			{
				return this._projectVersionDateApplied;
			}
			set
			{
				if ((_projectVersionDateApplied != value))
				{
					this.OnProjectVersionDateAppliedChanging(value);
					this.SendPropertyChanging();
					this._projectVersionDateApplied = value;
					this.SendPropertyChanged("ProjectVersionDateApplied");
					this.OnProjectVersionDateAppliedChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionID", Name="project_version_id", DbType="tinyint(3)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProjectVersionID
		{
			get
			{
				return this._projectVersionID;
			}
			set
			{
				if ((_projectVersionID != value))
				{
					this.OnProjectVersionIDChanging(value);
					this.SendPropertyChanging();
					this._projectVersionID = value;
					this.SendPropertyChanged("ProjectVersionID");
					this.OnProjectVersionIDChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionKey", Name="project_version_key", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionKey
		{
			get
			{
				return this._projectVersionKey;
			}
			set
			{
				if (((_projectVersionKey == value) 
							== false))
				{
					this.OnProjectVersionKeyChanging(value);
					this.SendPropertyChanging();
					this._projectVersionKey = value;
					this.SendPropertyChanged("ProjectVersionKey");
					this.OnProjectVersionKeyChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionMajor", Name="project_version_major", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionMajor
		{
			get
			{
				return this._projectVersionMajor;
			}
			set
			{
				if (((_projectVersionMajor == value) 
							== false))
				{
					this.OnProjectVersionMajorChanging(value);
					this.SendPropertyChanging();
					this._projectVersionMajor = value;
					this.SendPropertyChanged("ProjectVersionMajor");
					this.OnProjectVersionMajorChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionMinor", Name="project_version_minor", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionMinor
		{
			get
			{
				return this._projectVersionMinor;
			}
			set
			{
				if (((_projectVersionMinor == value) 
							== false))
				{
					this.OnProjectVersionMinorChanging(value);
					this.SendPropertyChanging();
					this._projectVersionMinor = value;
					this.SendPropertyChanged("ProjectVersionMinor");
					this.OnProjectVersionMinorChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionPatch1", Name="project_version_patch1", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionPatch1
		{
			get
			{
				return this._projectVersionPatch1;
			}
			set
			{
				if (((_projectVersionPatch1 == value) 
							== false))
				{
					this.OnProjectVersionPatch1Changing(value);
					this.SendPropertyChanging();
					this._projectVersionPatch1 = value;
					this.SendPropertyChanged("ProjectVersionPatch1");
					this.OnProjectVersionPatch1Changed();
				}
			}
		}
		
		[Column(Storage="_projectVersionPatch1sOurce", Name="project_version_patch1_source", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionPatch1Source
		{
			get
			{
				return this._projectVersionPatch1sOurce;
			}
			set
			{
				if (((_projectVersionPatch1sOurce == value) 
							== false))
				{
					this.OnProjectVersionPatch1SourceChanging(value);
					this.SendPropertyChanging();
					this._projectVersionPatch1sOurce = value;
					this.SendPropertyChanged("ProjectVersionPatch1Source");
					this.OnProjectVersionPatch1SourceChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionPatch2", Name="project_version_patch2", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionPatch2
		{
			get
			{
				return this._projectVersionPatch2;
			}
			set
			{
				if (((_projectVersionPatch2 == value) 
							== false))
				{
					this.OnProjectVersionPatch2Changing(value);
					this.SendPropertyChanging();
					this._projectVersionPatch2 = value;
					this.SendPropertyChanged("ProjectVersionPatch2");
					this.OnProjectVersionPatch2Changed();
				}
			}
		}
		
		[Column(Storage="_projectVersionPatch2sOurce", Name="project_version_patch2_source", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionPatch2Source
		{
			get
			{
				return this._projectVersionPatch2sOurce;
			}
			set
			{
				if (((_projectVersionPatch2sOurce == value) 
							== false))
				{
					this.OnProjectVersionPatch2SourceChanging(value);
					this.SendPropertyChanging();
					this._projectVersionPatch2sOurce = value;
					this.SendPropertyChanged("ProjectVersionPatch2Source");
					this.OnProjectVersionPatch2SourceChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.project_version_history")]
	public partial class ProjectVersionHistory : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _projectVersionComment;
		
		private System.DateTime _projectVersionDateApplied;
		
		private sbyte _projectVersionID;
		
		private string _projectVersionKey;
		
		private string _projectVersionMajor;
		
		private string _projectVersionMinor;
		
		private string _projectVersionPatch;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnProjectVersionCommentChanged();
		
		partial void OnProjectVersionCommentChanging(string value);
		
		partial void OnProjectVersionDateAppliedChanged();
		
		partial void OnProjectVersionDateAppliedChanging(System.DateTime value);
		
		partial void OnProjectVersionIDChanged();
		
		partial void OnProjectVersionIDChanging(sbyte value);
		
		partial void OnProjectVersionKeyChanged();
		
		partial void OnProjectVersionKeyChanging(string value);
		
		partial void OnProjectVersionMajorChanged();
		
		partial void OnProjectVersionMajorChanging(string value);
		
		partial void OnProjectVersionMinorChanged();
		
		partial void OnProjectVersionMinorChanging(string value);
		
		partial void OnProjectVersionPatchChanged();
		
		partial void OnProjectVersionPatchChanging(string value);
		#endregion
		
		
		public ProjectVersionHistory()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_projectVersionComment", Name="project_version_comment", DbType="varchar(250)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionComment
		{
			get
			{
				return this._projectVersionComment;
			}
			set
			{
				if (((_projectVersionComment == value) 
							== false))
				{
					this.OnProjectVersionCommentChanging(value);
					this.SendPropertyChanging();
					this._projectVersionComment = value;
					this.SendPropertyChanged("ProjectVersionComment");
					this.OnProjectVersionCommentChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionDateApplied", Name="project_version_date_applied", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ProjectVersionDateApplied
		{
			get
			{
				return this._projectVersionDateApplied;
			}
			set
			{
				if ((_projectVersionDateApplied != value))
				{
					this.OnProjectVersionDateAppliedChanging(value);
					this.SendPropertyChanging();
					this._projectVersionDateApplied = value;
					this.SendPropertyChanged("ProjectVersionDateApplied");
					this.OnProjectVersionDateAppliedChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionID", Name="project_version_id", DbType="tinyint(3)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte ProjectVersionID
		{
			get
			{
				return this._projectVersionID;
			}
			set
			{
				if ((_projectVersionID != value))
				{
					this.OnProjectVersionIDChanging(value);
					this.SendPropertyChanging();
					this._projectVersionID = value;
					this.SendPropertyChanged("ProjectVersionID");
					this.OnProjectVersionIDChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionKey", Name="project_version_key", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionKey
		{
			get
			{
				return this._projectVersionKey;
			}
			set
			{
				if (((_projectVersionKey == value) 
							== false))
				{
					this.OnProjectVersionKeyChanging(value);
					this.SendPropertyChanging();
					this._projectVersionKey = value;
					this.SendPropertyChanged("ProjectVersionKey");
					this.OnProjectVersionKeyChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionMajor", Name="project_version_major", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionMajor
		{
			get
			{
				return this._projectVersionMajor;
			}
			set
			{
				if (((_projectVersionMajor == value) 
							== false))
				{
					this.OnProjectVersionMajorChanging(value);
					this.SendPropertyChanging();
					this._projectVersionMajor = value;
					this.SendPropertyChanged("ProjectVersionMajor");
					this.OnProjectVersionMajorChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionMinor", Name="project_version_minor", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionMinor
		{
			get
			{
				return this._projectVersionMinor;
			}
			set
			{
				if (((_projectVersionMinor == value) 
							== false))
				{
					this.OnProjectVersionMinorChanging(value);
					this.SendPropertyChanging();
					this._projectVersionMinor = value;
					this.SendPropertyChanged("ProjectVersionMinor");
					this.OnProjectVersionMinorChanged();
				}
			}
		}
		
		[Column(Storage="_projectVersionPatch", Name="project_version_patch", DbType="varchar(20)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ProjectVersionPatch
		{
			get
			{
				return this._projectVersionPatch;
			}
			set
			{
				if (((_projectVersionPatch == value) 
							== false))
				{
					this.OnProjectVersionPatchChanging(value);
					this.SendPropertyChanging();
					this._projectVersionPatch = value;
					this.SendPropertyChanged("ProjectVersionPatch");
					this.OnProjectVersionPatchChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.query_builder")]
	public partial class QueryBuilder : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _queryCategory;
		
		private string _queryDescription;
		
		private int _queryID;
		
		private string _queryKeysList;
		
		private string _queryName;
		
		private string _queryString;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnQueryCategoryChanged();
		
		partial void OnQueryCategoryChanging(string value);
		
		partial void OnQueryDescriptionChanged();
		
		partial void OnQueryDescriptionChanging(string value);
		
		partial void OnQueryIDChanged();
		
		partial void OnQueryIDChanging(int value);
		
		partial void OnQueryKeysListChanged();
		
		partial void OnQueryKeysListChanging(string value);
		
		partial void OnQueryNameChanged();
		
		partial void OnQueryNameChanging(string value);
		
		partial void OnQueryStringChanged();
		
		partial void OnQueryStringChanging(string value);
		#endregion
		
		
		public QueryBuilder()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_queryCategory", Name="query_category", DbType="varchar(40)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string QueryCategory
		{
			get
			{
				return this._queryCategory;
			}
			set
			{
				if (((_queryCategory == value) 
							== false))
				{
					this.OnQueryCategoryChanging(value);
					this.SendPropertyChanging();
					this._queryCategory = value;
					this.SendPropertyChanged("QueryCategory");
					this.OnQueryCategoryChanged();
				}
			}
		}
		
		[Column(Storage="_queryDescription", Name="query_description", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string QueryDescription
		{
			get
			{
				return this._queryDescription;
			}
			set
			{
				if (((_queryDescription == value) 
							== false))
				{
					this.OnQueryDescriptionChanging(value);
					this.SendPropertyChanging();
					this._queryDescription = value;
					this.SendPropertyChanged("QueryDescription");
					this.OnQueryDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_queryID", Name="query_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int QueryID
		{
			get
			{
				return this._queryID;
			}
			set
			{
				if ((_queryID != value))
				{
					this.OnQueryIDChanging(value);
					this.SendPropertyChanging();
					this._queryID = value;
					this.SendPropertyChanged("QueryID");
					this.OnQueryIDChanged();
				}
			}
		}
		
		[Column(Storage="_queryKeysList", Name="query_keys_list", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string QueryKeysList
		{
			get
			{
				return this._queryKeysList;
			}
			set
			{
				if (((_queryKeysList == value) 
							== false))
				{
					this.OnQueryKeysListChanging(value);
					this.SendPropertyChanging();
					this._queryKeysList = value;
					this.SendPropertyChanged("QueryKeysList");
					this.OnQueryKeysListChanged();
				}
			}
		}
		
		[Column(Storage="_queryName", Name="query_name", DbType="varchar(80)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string QueryName
		{
			get
			{
				return this._queryName;
			}
			set
			{
				if (((_queryName == value) 
							== false))
				{
					this.OnQueryNameChanging(value);
					this.SendPropertyChanging();
					this._queryName = value;
					this.SendPropertyChanged("QueryName");
					this.OnQueryNameChanged();
				}
			}
		}
		
		[Column(Storage="_queryString", Name="query_string", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string QueryString
		{
			get
			{
				return this._queryString;
			}
			set
			{
				if (((_queryString == value) 
							== false))
				{
					this.OnQueryStringChanging(value);
					this.SendPropertyChanging();
					this._queryString = value;
					this.SendPropertyChanged("QueryString");
					this.OnQueryStringChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.record_artists")]
	public partial class RecordArtists : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _artistsID;
		
		private string _artistsImage;
		
		private string _artistsName;
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArtistsIDChanged();
		
		partial void OnArtistsIDChanging(int value);
		
		partial void OnArtistsImageChanged();
		
		partial void OnArtistsImageChanging(string value);
		
		partial void OnArtistsNameChanged();
		
		partial void OnArtistsNameChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		#endregion
		
		
		public RecordArtists()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_artistsID", Name="artists_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArtistsID
		{
			get
			{
				return this._artistsID;
			}
			set
			{
				if ((_artistsID != value))
				{
					this.OnArtistsIDChanging(value);
					this.SendPropertyChanging();
					this._artistsID = value;
					this.SendPropertyChanged("ArtistsID");
					this.OnArtistsIDChanged();
				}
			}
		}
		
		[Column(Storage="_artistsImage", Name="artists_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string ArtistsImage
		{
			get
			{
				return this._artistsImage;
			}
			set
			{
				if (((_artistsImage == value) 
							== false))
				{
					this.OnArtistsImageChanging(value);
					this.SendPropertyChanging();
					this._artistsImage = value;
					this.SendPropertyChanged("ArtistsImage");
					this.OnArtistsImageChanged();
				}
			}
		}
		
		[Column(Storage="_artistsName", Name="artists_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ArtistsName
		{
			get
			{
				return this._artistsName;
			}
			set
			{
				if (((_artistsName == value) 
							== false))
				{
					this.OnArtistsNameChanging(value);
					this.SendPropertyChanging();
					this._artistsName = value;
					this.SendPropertyChanged("ArtistsName");
					this.OnArtistsNameChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.record_artists_info")]
	public partial class RecordArtistsInfo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _artistsID;
		
		private string _artistsUrl;
		
		private System.Nullable<System.DateTime> _dateLastClick;
		
		private int _languagesID;
		
		private int _urlcLicked;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnArtistsIDChanged();
		
		partial void OnArtistsIDChanging(int value);
		
		partial void OnArtistsURLChanged();
		
		partial void OnArtistsURLChanging(string value);
		
		partial void OnDateLastClickChanged();
		
		partial void OnDateLastClickChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnURLClickedChanged();
		
		partial void OnURLClickedChanging(int value);
		#endregion
		
		
		public RecordArtistsInfo()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_artistsID", Name="artists_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ArtistsID
		{
			get
			{
				return this._artistsID;
			}
			set
			{
				if ((_artistsID != value))
				{
					this.OnArtistsIDChanging(value);
					this.SendPropertyChanging();
					this._artistsID = value;
					this.SendPropertyChanged("ArtistsID");
					this.OnArtistsIDChanged();
				}
			}
		}
		
		[Column(Storage="_artistsUrl", Name="artists_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ArtistsURL
		{
			get
			{
				return this._artistsUrl;
			}
			set
			{
				if (((_artistsUrl == value) 
							== false))
				{
					this.OnArtistsURLChanging(value);
					this.SendPropertyChanging();
					this._artistsUrl = value;
					this.SendPropertyChanged("ArtistsURL");
					this.OnArtistsURLChanged();
				}
			}
		}
		
		[Column(Storage="_dateLastClick", Name="date_last_click", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateLastClick
		{
			get
			{
				return this._dateLastClick;
			}
			set
			{
				if ((_dateLastClick != value))
				{
					this.OnDateLastClickChanging(value);
					this.SendPropertyChanging();
					this._dateLastClick = value;
					this.SendPropertyChanged("DateLastClick");
					this.OnDateLastClickChanged();
				}
			}
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_urlcLicked", Name="url_clicked", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int URLClicked
		{
			get
			{
				return this._urlcLicked;
			}
			set
			{
				if ((_urlcLicked != value))
				{
					this.OnURLClickedChanging(value);
					this.SendPropertyChanging();
					this._urlcLicked = value;
					this.SendPropertyChanged("URLClicked");
					this.OnURLClickedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.record_company")]
	public partial class RecordCompany : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _recordCompanyID;
		
		private string _recordCompanyImage;
		
		private string _recordCompanyName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnRecordCompanyIDChanged();
		
		partial void OnRecordCompanyIDChanging(int value);
		
		partial void OnRecordCompanyImageChanged();
		
		partial void OnRecordCompanyImageChanging(string value);
		
		partial void OnRecordCompanyNameChanged();
		
		partial void OnRecordCompanyNameChanging(string value);
		#endregion
		
		
		public RecordCompany()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyID", Name="record_company_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RecordCompanyID
		{
			get
			{
				return this._recordCompanyID;
			}
			set
			{
				if ((_recordCompanyID != value))
				{
					this.OnRecordCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyID = value;
					this.SendPropertyChanged("RecordCompanyID");
					this.OnRecordCompanyIDChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyImage", Name="record_company_image", DbType="varchar(64)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string RecordCompanyImage
		{
			get
			{
				return this._recordCompanyImage;
			}
			set
			{
				if (((_recordCompanyImage == value) 
							== false))
				{
					this.OnRecordCompanyImageChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyImage = value;
					this.SendPropertyChanged("RecordCompanyImage");
					this.OnRecordCompanyImageChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyName", Name="record_company_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string RecordCompanyName
		{
			get
			{
				return this._recordCompanyName;
			}
			set
			{
				if (((_recordCompanyName == value) 
							== false))
				{
					this.OnRecordCompanyNameChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyName = value;
					this.SendPropertyChanged("RecordCompanyName");
					this.OnRecordCompanyNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.record_company_info")]
	public partial class RecordCompanyInfo : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateLastClick;
		
		private int _languagesID;
		
		private int _recordCompanyID;
		
		private string _recordCompanyUrl;
		
		private int _urlcLicked;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateLastClickChanged();
		
		partial void OnDateLastClickChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnRecordCompanyIDChanged();
		
		partial void OnRecordCompanyIDChanging(int value);
		
		partial void OnRecordCompanyURLChanged();
		
		partial void OnRecordCompanyURLChanging(string value);
		
		partial void OnURLClickedChanged();
		
		partial void OnURLClickedChanging(int value);
		#endregion
		
		
		public RecordCompanyInfo()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateLastClick", Name="date_last_click", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateLastClick
		{
			get
			{
				return this._dateLastClick;
			}
			set
			{
				if ((_dateLastClick != value))
				{
					this.OnDateLastClickChanging(value);
					this.SendPropertyChanging();
					this._dateLastClick = value;
					this.SendPropertyChanged("DateLastClick");
					this.OnDateLastClickChanged();
				}
			}
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyID", Name="record_company_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int RecordCompanyID
		{
			get
			{
				return this._recordCompanyID;
			}
			set
			{
				if ((_recordCompanyID != value))
				{
					this.OnRecordCompanyIDChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyID = value;
					this.SendPropertyChanged("RecordCompanyID");
					this.OnRecordCompanyIDChanged();
				}
			}
		}
		
		[Column(Storage="_recordCompanyUrl", Name="record_company_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string RecordCompanyURL
		{
			get
			{
				return this._recordCompanyUrl;
			}
			set
			{
				if (((_recordCompanyUrl == value) 
							== false))
				{
					this.OnRecordCompanyURLChanging(value);
					this.SendPropertyChanging();
					this._recordCompanyUrl = value;
					this.SendPropertyChanged("RecordCompanyURL");
					this.OnRecordCompanyURLChanged();
				}
			}
		}
		
		[Column(Storage="_urlcLicked", Name="url_clicked", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int URLClicked
		{
			get
			{
				return this._urlcLicked;
			}
			set
			{
				if ((_urlcLicked != value))
				{
					this.OnURLClickedChanging(value);
					this.SendPropertyChanging();
					this._urlcLicked = value;
					this.SendPropertyChanged("URLClicked");
					this.OnURLClickedChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.reviews")]
	public partial class Reviews : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<int> _customersID;
		
		private string _customersName;
		
		private System.Nullable<System.DateTime> _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _productsID;
		
		private int _reviewsID;
		
		private System.Nullable<int> _reviewsRating;
		
		private int _reviewsRead;
		
		private int _status;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomersIDChanged();
		
		partial void OnCustomersIDChanging(System.Nullable<int> value);
		
		partial void OnCustomersNameChanged();
		
		partial void OnCustomersNameChanging(string value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnReviewsIDChanged();
		
		partial void OnReviewsIDChanging(int value);
		
		partial void OnReviewsRatingChanged();
		
		partial void OnReviewsRatingChanging(System.Nullable<int> value);
		
		partial void OnReviewsReadChanged();
		
		partial void OnReviewsReadChanging(int value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(int value);
		#endregion
		
		
		public Reviews()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customersID", Name="customers_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomersID
		{
			get
			{
				return this._customersID;
			}
			set
			{
				if ((_customersID != value))
				{
					this.OnCustomersIDChanging(value);
					this.SendPropertyChanging();
					this._customersID = value;
					this.SendPropertyChanged("CustomersID");
					this.OnCustomersIDChanged();
				}
			}
		}
		
		[Column(Storage="_customersName", Name="customers_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string CustomersName
		{
			get
			{
				return this._customersName;
			}
			set
			{
				if (((_customersName == value) 
							== false))
				{
					this.OnCustomersNameChanging(value);
					this.SendPropertyChanging();
					this._customersName = value;
					this.SendPropertyChanged("CustomersName");
					this.OnCustomersNameChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_reviewsID", Name="reviews_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ReviewsID
		{
			get
			{
				return this._reviewsID;
			}
			set
			{
				if ((_reviewsID != value))
				{
					this.OnReviewsIDChanging(value);
					this.SendPropertyChanging();
					this._reviewsID = value;
					this.SendPropertyChanged("ReviewsID");
					this.OnReviewsIDChanged();
				}
			}
		}
		
		[Column(Storage="_reviewsRating", Name="reviews_rating", DbType="int(1)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ReviewsRating
		{
			get
			{
				return this._reviewsRating;
			}
			set
			{
				if ((_reviewsRating != value))
				{
					this.OnReviewsRatingChanging(value);
					this.SendPropertyChanging();
					this._reviewsRating = value;
					this.SendPropertyChanged("ReviewsRating");
					this.OnReviewsRatingChanged();
				}
			}
		}
		
		[Column(Storage="_reviewsRead", Name="reviews_read", DbType="int(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ReviewsRead
		{
			get
			{
				return this._reviewsRead;
			}
			set
			{
				if ((_reviewsRead != value))
				{
					this.OnReviewsReadChanging(value);
					this.SendPropertyChanging();
					this._reviewsRead = value;
					this.SendPropertyChanged("ReviewsRead");
					this.OnReviewsReadChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.reviews_description")]
	public partial class ReviewsDescription : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _languagesID;
		
		private int _reviewsID;
		
		private string _reviewsText;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnLanguagesIDChanged();
		
		partial void OnLanguagesIDChanging(int value);
		
		partial void OnReviewsIDChanged();
		
		partial void OnReviewsIDChanging(int value);
		
		partial void OnReviewsTextChanged();
		
		partial void OnReviewsTextChanging(string value);
		#endregion
		
		
		public ReviewsDescription()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_languagesID", Name="languages_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int LanguagesID
		{
			get
			{
				return this._languagesID;
			}
			set
			{
				if ((_languagesID != value))
				{
					this.OnLanguagesIDChanging(value);
					this.SendPropertyChanging();
					this._languagesID = value;
					this.SendPropertyChanged("LanguagesID");
					this.OnLanguagesIDChanged();
				}
			}
		}
		
		[Column(Storage="_reviewsID", Name="reviews_id", DbType="int", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ReviewsID
		{
			get
			{
				return this._reviewsID;
			}
			set
			{
				if ((_reviewsID != value))
				{
					this.OnReviewsIDChanging(value);
					this.SendPropertyChanging();
					this._reviewsID = value;
					this.SendPropertyChanged("ReviewsID");
					this.OnReviewsIDChanged();
				}
			}
		}
		
		[Column(Storage="_reviewsText", Name="reviews_text", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ReviewsText
		{
			get
			{
				return this._reviewsText;
			}
			set
			{
				if (((_reviewsText == value) 
							== false))
				{
					this.OnReviewsTextChanging(value);
					this.SendPropertyChanging();
					this._reviewsText = value;
					this.SendPropertyChanged("ReviewsText");
					this.OnReviewsTextChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.salemaker_sales")]
	public partial class SaleMakerSales : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _saleCategoriesAll;
		
		private string _saleCategoriesSelected;
		
		private System.DateTime _saleDateAdded;
		
		private System.DateTime _saleDateEnd;
		
		private System.DateTime _saleDateLastModified;
		
		private System.DateTime _saleDateStart;
		
		private System.DateTime _saleDateStatusChange;
		
		private sbyte _saleDeductionType;
		
		private decimal _saleDeductionValue;
		
		private int _saleID;
		
		private string _saleName;
		
		private decimal _salePriceRangeFrom;
		
		private decimal _salePriceRangeTo;
		
		private sbyte _saleSpecialsCondition;
		
		private sbyte _saleStatus;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnSaleCategoriesAllChanged();
		
		partial void OnSaleCategoriesAllChanging(string value);
		
		partial void OnSaleCategoriesSelectedChanged();
		
		partial void OnSaleCategoriesSelectedChanging(string value);
		
		partial void OnSaleDateAddedChanged();
		
		partial void OnSaleDateAddedChanging(System.DateTime value);
		
		partial void OnSaleDateEndChanged();
		
		partial void OnSaleDateEndChanging(System.DateTime value);
		
		partial void OnSaleDateLastModifiedChanged();
		
		partial void OnSaleDateLastModifiedChanging(System.DateTime value);
		
		partial void OnSaleDateStartChanged();
		
		partial void OnSaleDateStartChanging(System.DateTime value);
		
		partial void OnSaleDateStatusChangeChanged();
		
		partial void OnSaleDateStatusChangeChanging(System.DateTime value);
		
		partial void OnSaleDeductionTypeChanged();
		
		partial void OnSaleDeductionTypeChanging(sbyte value);
		
		partial void OnSaleDeductionValueChanged();
		
		partial void OnSaleDeductionValueChanging(decimal value);
		
		partial void OnSaleIDChanged();
		
		partial void OnSaleIDChanging(int value);
		
		partial void OnSaleNameChanged();
		
		partial void OnSaleNameChanging(string value);
		
		partial void OnSalePriceRangeFromChanged();
		
		partial void OnSalePriceRangeFromChanging(decimal value);
		
		partial void OnSalePriceRangeToChanged();
		
		partial void OnSalePriceRangeToChanging(decimal value);
		
		partial void OnSaleSpecialsConditionChanged();
		
		partial void OnSaleSpecialsConditionChanging(sbyte value);
		
		partial void OnSaleStatusChanged();
		
		partial void OnSaleStatusChanging(sbyte value);
		#endregion
		
		
		public SaleMakerSales()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_saleCategoriesAll", Name="sale_categories_all", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SaleCategoriesAll
		{
			get
			{
				return this._saleCategoriesAll;
			}
			set
			{
				if (((_saleCategoriesAll == value) 
							== false))
				{
					this.OnSaleCategoriesAllChanging(value);
					this.SendPropertyChanging();
					this._saleCategoriesAll = value;
					this.SendPropertyChanged("SaleCategoriesAll");
					this.OnSaleCategoriesAllChanged();
				}
			}
		}
		
		[Column(Storage="_saleCategoriesSelected", Name="sale_categories_selected", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SaleCategoriesSelected
		{
			get
			{
				return this._saleCategoriesSelected;
			}
			set
			{
				if (((_saleCategoriesSelected == value) 
							== false))
				{
					this.OnSaleCategoriesSelectedChanging(value);
					this.SendPropertyChanging();
					this._saleCategoriesSelected = value;
					this.SendPropertyChanged("SaleCategoriesSelected");
					this.OnSaleCategoriesSelectedChanged();
				}
			}
		}
		
		[Column(Storage="_saleDateAdded", Name="sale_date_added", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaleDateAdded
		{
			get
			{
				return this._saleDateAdded;
			}
			set
			{
				if ((_saleDateAdded != value))
				{
					this.OnSaleDateAddedChanging(value);
					this.SendPropertyChanging();
					this._saleDateAdded = value;
					this.SendPropertyChanged("SaleDateAdded");
					this.OnSaleDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_saleDateEnd", Name="sale_date_end", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaleDateEnd
		{
			get
			{
				return this._saleDateEnd;
			}
			set
			{
				if ((_saleDateEnd != value))
				{
					this.OnSaleDateEndChanging(value);
					this.SendPropertyChanging();
					this._saleDateEnd = value;
					this.SendPropertyChanged("SaleDateEnd");
					this.OnSaleDateEndChanged();
				}
			}
		}
		
		[Column(Storage="_saleDateLastModified", Name="sale_date_last_modified", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaleDateLastModified
		{
			get
			{
				return this._saleDateLastModified;
			}
			set
			{
				if ((_saleDateLastModified != value))
				{
					this.OnSaleDateLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._saleDateLastModified = value;
					this.SendPropertyChanged("SaleDateLastModified");
					this.OnSaleDateLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_saleDateStart", Name="sale_date_start", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaleDateStart
		{
			get
			{
				return this._saleDateStart;
			}
			set
			{
				if ((_saleDateStart != value))
				{
					this.OnSaleDateStartChanging(value);
					this.SendPropertyChanging();
					this._saleDateStart = value;
					this.SendPropertyChanged("SaleDateStart");
					this.OnSaleDateStartChanged();
				}
			}
		}
		
		[Column(Storage="_saleDateStatusChange", Name="sale_date_status_change", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SaleDateStatusChange
		{
			get
			{
				return this._saleDateStatusChange;
			}
			set
			{
				if ((_saleDateStatusChange != value))
				{
					this.OnSaleDateStatusChangeChanging(value);
					this.SendPropertyChanging();
					this._saleDateStatusChange = value;
					this.SendPropertyChanged("SaleDateStatusChange");
					this.OnSaleDateStatusChangeChanged();
				}
			}
		}
		
		[Column(Storage="_saleDeductionType", Name="sale_deduction_type", DbType="tinyint(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte SaleDeductionType
		{
			get
			{
				return this._saleDeductionType;
			}
			set
			{
				if ((_saleDeductionType != value))
				{
					this.OnSaleDeductionTypeChanging(value);
					this.SendPropertyChanging();
					this._saleDeductionType = value;
					this.SendPropertyChanged("SaleDeductionType");
					this.OnSaleDeductionTypeChanged();
				}
			}
		}
		
		[Column(Storage="_saleDeductionValue", Name="sale_deduction_value", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal SaleDeductionValue
		{
			get
			{
				return this._saleDeductionValue;
			}
			set
			{
				if ((_saleDeductionValue != value))
				{
					this.OnSaleDeductionValueChanging(value);
					this.SendPropertyChanging();
					this._saleDeductionValue = value;
					this.SendPropertyChanged("SaleDeductionValue");
					this.OnSaleDeductionValueChanged();
				}
			}
		}
		
		[Column(Storage="_saleID", Name="sale_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SaleID
		{
			get
			{
				return this._saleID;
			}
			set
			{
				if ((_saleID != value))
				{
					this.OnSaleIDChanging(value);
					this.SendPropertyChanging();
					this._saleID = value;
					this.SendPropertyChanged("SaleID");
					this.OnSaleIDChanged();
				}
			}
		}
		
		[Column(Storage="_saleName", Name="sale_name", DbType="varchar(30)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SaleName
		{
			get
			{
				return this._saleName;
			}
			set
			{
				if (((_saleName == value) 
							== false))
				{
					this.OnSaleNameChanging(value);
					this.SendPropertyChanging();
					this._saleName = value;
					this.SendPropertyChanged("SaleName");
					this.OnSaleNameChanged();
				}
			}
		}
		
		[Column(Storage="_salePriceRangeFrom", Name="sale_pricerange_from", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal SalePriceRangeFrom
		{
			get
			{
				return this._salePriceRangeFrom;
			}
			set
			{
				if ((_salePriceRangeFrom != value))
				{
					this.OnSalePriceRangeFromChanging(value);
					this.SendPropertyChanging();
					this._salePriceRangeFrom = value;
					this.SendPropertyChanged("SalePriceRangeFrom");
					this.OnSalePriceRangeFromChanged();
				}
			}
		}
		
		[Column(Storage="_salePriceRangeTo", Name="sale_pricerange_to", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal SalePriceRangeTo
		{
			get
			{
				return this._salePriceRangeTo;
			}
			set
			{
				if ((_salePriceRangeTo != value))
				{
					this.OnSalePriceRangeToChanging(value);
					this.SendPropertyChanging();
					this._salePriceRangeTo = value;
					this.SendPropertyChanged("SalePriceRangeTo");
					this.OnSalePriceRangeToChanged();
				}
			}
		}
		
		[Column(Storage="_saleSpecialsCondition", Name="sale_specials_condition", DbType="tinyint(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte SaleSpecialsCondition
		{
			get
			{
				return this._saleSpecialsCondition;
			}
			set
			{
				if ((_saleSpecialsCondition != value))
				{
					this.OnSaleSpecialsConditionChanging(value);
					this.SendPropertyChanging();
					this._saleSpecialsCondition = value;
					this.SendPropertyChanged("SaleSpecialsCondition");
					this.OnSaleSpecialsConditionChanged();
				}
			}
		}
		
		[Column(Storage="_saleStatus", Name="sale_status", DbType="tinyint(4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public sbyte SaleStatus
		{
			get
			{
				return this._saleStatus;
			}
			set
			{
				if ((_saleStatus != value))
				{
					this.OnSaleStatusChanging(value);
					this.SendPropertyChanging();
					this._saleStatus = value;
					this.SendPropertyChanged("SaleStatus");
					this.OnSaleStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.sessions")]
	public partial class Sessions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private uint _expiry;
		
		private string _seSSkEy;
		
		private byte[] _value;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnExpiryChanged();
		
		partial void OnExpiryChanging(uint value);
		
		partial void OnSEsSKeyChanged();
		
		partial void OnSEsSKeyChanging(string value);
		
		partial void OnValueChanged();
		
		partial void OnValueChanging(byte[] value);
		#endregion
		
		
		public Sessions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_expiry", Name="expiry", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint Expiry
		{
			get
			{
				return this._expiry;
			}
			set
			{
				if ((_expiry != value))
				{
					this.OnExpiryChanging(value);
					this.SendPropertyChanging();
					this._expiry = value;
					this.SendPropertyChanged("Expiry");
					this.OnExpiryChanged();
				}
			}
		}
		
		[Column(Storage="_seSSkEy", Name="sesskey", DbType="varchar(32)", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SEsSKey
		{
			get
			{
				return this._seSSkEy;
			}
			set
			{
				if (((_seSSkEy == value) 
							== false))
				{
					this.OnSEsSKeyChanging(value);
					this.SendPropertyChanging();
					this._seSSkEy = value;
					this.SendPropertyChanged("SEsSKey");
					this.OnSEsSKeyChanged();
				}
			}
		}
		
		[Column(Storage="_value", Name="value", DbType="mediumblob", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public byte[] Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (((_value == value) 
							== false))
				{
					this.OnValueChanging(value);
					this.SendPropertyChanging();
					this._value = value;
					this.SendPropertyChanged("Value");
					this.OnValueChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.specials")]
	public partial class Specials : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _dateStatusChange;
		
		private System.DateTime _expiresDate;
		
		private int _productsID;
		
		private System.Nullable<System.DateTime> _specialsDateAdded;
		
		private System.DateTime _specialsDateAvailable;
		
		private int _specialsID;
		
		private System.Nullable<System.DateTime> _specialsLastModified;
		
		private decimal _specialsNewProductsPrice;
		
		private int _status;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateStatusChangeChanged();
		
		partial void OnDateStatusChangeChanging(System.Nullable<System.DateTime> value);
		
		partial void OnExpiresDateChanged();
		
		partial void OnExpiresDateChanging(System.DateTime value);
		
		partial void OnProductsIDChanged();
		
		partial void OnProductsIDChanging(int value);
		
		partial void OnSpecialsDateAddedChanged();
		
		partial void OnSpecialsDateAddedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSpecialsDateAvailableChanged();
		
		partial void OnSpecialsDateAvailableChanging(System.DateTime value);
		
		partial void OnSpecialsIDChanged();
		
		partial void OnSpecialsIDChanging(int value);
		
		partial void OnSpecialsLastModifiedChanged();
		
		partial void OnSpecialsLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnSpecialsNewProductsPriceChanged();
		
		partial void OnSpecialsNewProductsPriceChanging(decimal value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(int value);
		#endregion
		
		
		public Specials()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateStatusChange", Name="date_status_change", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateStatusChange
		{
			get
			{
				return this._dateStatusChange;
			}
			set
			{
				if ((_dateStatusChange != value))
				{
					this.OnDateStatusChangeChanging(value);
					this.SendPropertyChanging();
					this._dateStatusChange = value;
					this.SendPropertyChanged("DateStatusChange");
					this.OnDateStatusChangeChanged();
				}
			}
		}
		
		[Column(Storage="_expiresDate", Name="expires_date", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime ExpiresDate
		{
			get
			{
				return this._expiresDate;
			}
			set
			{
				if ((_expiresDate != value))
				{
					this.OnExpiresDateChanging(value);
					this.SendPropertyChanging();
					this._expiresDate = value;
					this.SendPropertyChanged("ExpiresDate");
					this.OnExpiresDateChanged();
				}
			}
		}
		
		[Column(Storage="_productsID", Name="products_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ProductsID
		{
			get
			{
				return this._productsID;
			}
			set
			{
				if ((_productsID != value))
				{
					this.OnProductsIDChanging(value);
					this.SendPropertyChanging();
					this._productsID = value;
					this.SendPropertyChanged("ProductsID");
					this.OnProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_specialsDateAdded", Name="specials_date_added", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SpecialsDateAdded
		{
			get
			{
				return this._specialsDateAdded;
			}
			set
			{
				if ((_specialsDateAdded != value))
				{
					this.OnSpecialsDateAddedChanging(value);
					this.SendPropertyChanging();
					this._specialsDateAdded = value;
					this.SendPropertyChanged("SpecialsDateAdded");
					this.OnSpecialsDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_specialsDateAvailable", Name="specials_date_available", DbType="date", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime SpecialsDateAvailable
		{
			get
			{
				return this._specialsDateAvailable;
			}
			set
			{
				if ((_specialsDateAvailable != value))
				{
					this.OnSpecialsDateAvailableChanging(value);
					this.SendPropertyChanging();
					this._specialsDateAvailable = value;
					this.SendPropertyChanged("SpecialsDateAvailable");
					this.OnSpecialsDateAvailableChanged();
				}
			}
		}
		
		[Column(Storage="_specialsID", Name="specials_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int SpecialsID
		{
			get
			{
				return this._specialsID;
			}
			set
			{
				if ((_specialsID != value))
				{
					this.OnSpecialsIDChanging(value);
					this.SendPropertyChanging();
					this._specialsID = value;
					this.SendPropertyChanged("SpecialsID");
					this.OnSpecialsIDChanged();
				}
			}
		}
		
		[Column(Storage="_specialsLastModified", Name="specials_last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> SpecialsLastModified
		{
			get
			{
				return this._specialsLastModified;
			}
			set
			{
				if ((_specialsLastModified != value))
				{
					this.OnSpecialsLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._specialsLastModified = value;
					this.SendPropertyChanged("SpecialsLastModified");
					this.OnSpecialsLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_specialsNewProductsPrice", Name="specials_new_products_price", DbType="decimal(15,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal SpecialsNewProductsPrice
		{
			get
			{
				return this._specialsNewProductsPrice;
			}
			set
			{
				if ((_specialsNewProductsPrice != value))
				{
					this.OnSpecialsNewProductsPriceChanging(value);
					this.SendPropertyChanging();
					this._specialsNewProductsPrice = value;
					this.SendPropertyChanged("SpecialsNewProductsPrice");
					this.OnSpecialsNewProductsPriceChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int(1)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.tax_class")]
	public partial class TaxClass : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private string _taxClassDescription;
		
		private int _taxClassID;
		
		private string _taxClassTitle;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnTaxClassDescriptionChanged();
		
		partial void OnTaxClassDescriptionChanging(string value);
		
		partial void OnTaxClassIDChanged();
		
		partial void OnTaxClassIDChanging(int value);
		
		partial void OnTaxClassTitleChanged();
		
		partial void OnTaxClassTitleChanging(string value);
		#endregion
		
		
		public TaxClass()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_taxClassDescription", Name="tax_class_description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TaxClassDescription
		{
			get
			{
				return this._taxClassDescription;
			}
			set
			{
				if (((_taxClassDescription == value) 
							== false))
				{
					this.OnTaxClassDescriptionChanging(value);
					this.SendPropertyChanging();
					this._taxClassDescription = value;
					this.SendPropertyChanged("TaxClassDescription");
					this.OnTaxClassDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_taxClassID", Name="tax_class_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaxClassID
		{
			get
			{
				return this._taxClassID;
			}
			set
			{
				if ((_taxClassID != value))
				{
					this.OnTaxClassIDChanging(value);
					this.SendPropertyChanging();
					this._taxClassID = value;
					this.SendPropertyChanged("TaxClassID");
					this.OnTaxClassIDChanged();
				}
			}
		}
		
		[Column(Storage="_taxClassTitle", Name="tax_class_title", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TaxClassTitle
		{
			get
			{
				return this._taxClassTitle;
			}
			set
			{
				if (((_taxClassTitle == value) 
							== false))
				{
					this.OnTaxClassTitleChanging(value);
					this.SendPropertyChanging();
					this._taxClassTitle = value;
					this.SendPropertyChanged("TaxClassTitle");
					this.OnTaxClassTitleChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.tax_rates")]
	public partial class TaxRates : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _taxClassID;
		
		private string _taxDescription;
		
		private System.Nullable<int> _taxPriority;
		
		private decimal _taxRate;
		
		private int _taxRatesID;
		
		private int _taxZoneID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnTaxClassIDChanged();
		
		partial void OnTaxClassIDChanging(int value);
		
		partial void OnTaxDescriptionChanged();
		
		partial void OnTaxDescriptionChanging(string value);
		
		partial void OnTaxPriorityChanged();
		
		partial void OnTaxPriorityChanging(System.Nullable<int> value);
		
		partial void OnTaxRateChanged();
		
		partial void OnTaxRateChanging(decimal value);
		
		partial void OnTaxRatesIDChanged();
		
		partial void OnTaxRatesIDChanging(int value);
		
		partial void OnTaxZoneIDChanged();
		
		partial void OnTaxZoneIDChanging(int value);
		#endregion
		
		
		public TaxRates()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_taxClassID", Name="tax_class_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaxClassID
		{
			get
			{
				return this._taxClassID;
			}
			set
			{
				if ((_taxClassID != value))
				{
					this.OnTaxClassIDChanging(value);
					this.SendPropertyChanging();
					this._taxClassID = value;
					this.SendPropertyChanged("TaxClassID");
					this.OnTaxClassIDChanged();
				}
			}
		}
		
		[Column(Storage="_taxDescription", Name="tax_description", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TaxDescription
		{
			get
			{
				return this._taxDescription;
			}
			set
			{
				if (((_taxDescription == value) 
							== false))
				{
					this.OnTaxDescriptionChanging(value);
					this.SendPropertyChanging();
					this._taxDescription = value;
					this.SendPropertyChanged("TaxDescription");
					this.OnTaxDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_taxPriority", Name="tax_priority", DbType="int(5)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> TaxPriority
		{
			get
			{
				return this._taxPriority;
			}
			set
			{
				if ((_taxPriority != value))
				{
					this.OnTaxPriorityChanging(value);
					this.SendPropertyChanging();
					this._taxPriority = value;
					this.SendPropertyChanged("TaxPriority");
					this.OnTaxPriorityChanged();
				}
			}
		}
		
		[Column(Storage="_taxRate", Name="tax_rate", DbType="decimal(7,4)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public decimal TaxRate
		{
			get
			{
				return this._taxRate;
			}
			set
			{
				if ((_taxRate != value))
				{
					this.OnTaxRateChanging(value);
					this.SendPropertyChanging();
					this._taxRate = value;
					this.SendPropertyChanged("TaxRate");
					this.OnTaxRateChanged();
				}
			}
		}
		
		[Column(Storage="_taxRatesID", Name="tax_rates_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaxRatesID
		{
			get
			{
				return this._taxRatesID;
			}
			set
			{
				if ((_taxRatesID != value))
				{
					this.OnTaxRatesIDChanging(value);
					this.SendPropertyChanging();
					this._taxRatesID = value;
					this.SendPropertyChanged("TaxRatesID");
					this.OnTaxRatesIDChanged();
				}
			}
		}
		
		[Column(Storage="_taxZoneID", Name="tax_zone_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TaxZoneID
		{
			get
			{
				return this._taxZoneID;
			}
			set
			{
				if ((_taxZoneID != value))
				{
					this.OnTaxZoneIDChanging(value);
					this.SendPropertyChanging();
					this._taxZoneID = value;
					this.SendPropertyChanged("TaxZoneID");
					this.OnTaxZoneIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.template_select")]
	public partial class TemplateSelect : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _templateDiR;
		
		private int _templateID;
		
		private string _templateLanguage;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnTemplateDiRChanged();
		
		partial void OnTemplateDiRChanging(string value);
		
		partial void OnTemplateIDChanged();
		
		partial void OnTemplateIDChanging(int value);
		
		partial void OnTemplateLanguageChanged();
		
		partial void OnTemplateLanguageChanging(string value);
		#endregion
		
		
		public TemplateSelect()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_templateDiR", Name="template_dir", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TemplateDiR
		{
			get
			{
				return this._templateDiR;
			}
			set
			{
				if (((_templateDiR == value) 
							== false))
				{
					this.OnTemplateDiRChanging(value);
					this.SendPropertyChanging();
					this._templateDiR = value;
					this.SendPropertyChanged("TemplateDiR");
					this.OnTemplateDiRChanged();
				}
			}
		}
		
		[Column(Storage="_templateID", Name="template_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int TemplateID
		{
			get
			{
				return this._templateID;
			}
			set
			{
				if ((_templateID != value))
				{
					this.OnTemplateIDChanging(value);
					this.SendPropertyChanging();
					this._templateID = value;
					this.SendPropertyChanged("TemplateID");
					this.OnTemplateIDChanged();
				}
			}
		}
		
		[Column(Storage="_templateLanguage", Name="template_language", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TemplateLanguage
		{
			get
			{
				return this._templateLanguage;
			}
			set
			{
				if (((_templateLanguage == value) 
							== false))
				{
					this.OnTemplateLanguageChanging(value);
					this.SendPropertyChanging();
					this._templateLanguage = value;
					this.SendPropertyChanged("TemplateLanguage");
					this.OnTemplateLanguageChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.upgrade_exceptions")]
	public partial class UpgradeExceptions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.Nullable<System.DateTime> _errorDate;
		
		private string _reason;
		
		private string _sqlfIle;
		
		private string _sqlsTatement;
		
		private short _upgradeExceptionID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnErrorDateChanged();
		
		partial void OnErrorDateChanging(System.Nullable<System.DateTime> value);
		
		partial void OnReasonChanged();
		
		partial void OnReasonChanging(string value);
		
		partial void OnSQLFileChanged();
		
		partial void OnSQLFileChanging(string value);
		
		partial void OnSQLStatementChanged();
		
		partial void OnSQLStatementChanging(string value);
		
		partial void OnUpgradeExceptionIDChanged();
		
		partial void OnUpgradeExceptionIDChanging(short value);
		#endregion
		
		
		public UpgradeExceptions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_errorDate", Name="errordate", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> ErrorDate
		{
			get
			{
				return this._errorDate;
			}
			set
			{
				if ((_errorDate != value))
				{
					this.OnErrorDateChanging(value);
					this.SendPropertyChanging();
					this._errorDate = value;
					this.SendPropertyChanged("ErrorDate");
					this.OnErrorDateChanged();
				}
			}
		}
		
		[Column(Storage="_reason", Name="reason", DbType="varchar(200)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Reason
		{
			get
			{
				return this._reason;
			}
			set
			{
				if (((_reason == value) 
							== false))
				{
					this.OnReasonChanging(value);
					this.SendPropertyChanging();
					this._reason = value;
					this.SendPropertyChanged("Reason");
					this.OnReasonChanged();
				}
			}
		}
		
		[Column(Storage="_sqlfIle", Name="sql_file", DbType="varchar(50)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SQLFile
		{
			get
			{
				return this._sqlfIle;
			}
			set
			{
				if (((_sqlfIle == value) 
							== false))
				{
					this.OnSQLFileChanging(value);
					this.SendPropertyChanging();
					this._sqlfIle = value;
					this.SendPropertyChanged("SQLFile");
					this.OnSQLFileChanged();
				}
			}
		}
		
		[Column(Storage="_sqlsTatement", Name="sqlstatement", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string SQLStatement
		{
			get
			{
				return this._sqlsTatement;
			}
			set
			{
				if (((_sqlsTatement == value) 
							== false))
				{
					this.OnSQLStatementChanging(value);
					this.SendPropertyChanging();
					this._sqlsTatement = value;
					this.SendPropertyChanged("SQLStatement");
					this.OnSQLStatementChanged();
				}
			}
		}
		
		[Column(Storage="_upgradeExceptionID", Name="upgrade_exception_id", DbType="smallint(5)", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public short UpgradeExceptionID
		{
			get
			{
				return this._upgradeExceptionID;
			}
			set
			{
				if ((_upgradeExceptionID != value))
				{
					this.OnUpgradeExceptionIDChanging(value);
					this.SendPropertyChanging();
					this._upgradeExceptionID = value;
					this.SendPropertyChanged("UpgradeExceptionID");
					this.OnUpgradeExceptionIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.whos_online")]
	public partial class WhoSOnline
	{
		
		private System.Nullable<int> _customerID;
		
		private string _fullName;
		
		private string _hostAddress;
		
		private string _ipaDdress;
		
		private string _lastPageUrl;
		
		private string _sessionID;
		
		private string _timeEntry;
		
		private string _timeLastClick;
		
		private string _userAgent;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCustomerIDChanged();
		
		partial void OnCustomerIDChanging(System.Nullable<int> value);
		
		partial void OnFullNameChanged();
		
		partial void OnFullNameChanging(string value);
		
		partial void OnHostAddressChanged();
		
		partial void OnHostAddressChanging(string value);
		
		partial void OnIPAddressChanged();
		
		partial void OnIPAddressChanging(string value);
		
		partial void OnLastPageURLChanged();
		
		partial void OnLastPageURLChanging(string value);
		
		partial void OnSessionIDChanged();
		
		partial void OnSessionIDChanging(string value);
		
		partial void OnTimeEntryChanged();
		
		partial void OnTimeEntryChanging(string value);
		
		partial void OnTimeLastClickChanged();
		
		partial void OnTimeLastClickChanging(string value);
		
		partial void OnUserAgentChanged();
		
		partial void OnUserAgentChanging(string value);
		#endregion
		
		
		public WhoSOnline()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_customerID", Name="customer_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> CustomerID
		{
			get
			{
				return this._customerID;
			}
			set
			{
				if ((_customerID != value))
				{
					this.OnCustomerIDChanging(value);
					this._customerID = value;
					this.OnCustomerIDChanged();
				}
			}
		}
		
		[Column(Storage="_fullName", Name="full_name", DbType="varchar(64)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string FullName
		{
			get
			{
				return this._fullName;
			}
			set
			{
				if (((_fullName == value) 
							== false))
				{
					this.OnFullNameChanging(value);
					this._fullName = value;
					this.OnFullNameChanged();
				}
			}
		}
		
		[Column(Storage="_hostAddress", Name="host_address", DbType="text", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string HostAddress
		{
			get
			{
				return this._hostAddress;
			}
			set
			{
				if (((_hostAddress == value) 
							== false))
				{
					this.OnHostAddressChanging(value);
					this._hostAddress = value;
					this.OnHostAddressChanged();
				}
			}
		}
		
		[Column(Storage="_ipaDdress", Name="ip_address", DbType="varchar(15)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string IPAddress
		{
			get
			{
				return this._ipaDdress;
			}
			set
			{
				if (((_ipaDdress == value) 
							== false))
				{
					this.OnIPAddressChanging(value);
					this._ipaDdress = value;
					this.OnIPAddressChanged();
				}
			}
		}
		
		[Column(Storage="_lastPageUrl", Name="last_page_url", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string LastPageURL
		{
			get
			{
				return this._lastPageUrl;
			}
			set
			{
				if (((_lastPageUrl == value) 
							== false))
				{
					this.OnLastPageURLChanging(value);
					this._lastPageUrl = value;
					this.OnLastPageURLChanged();
				}
			}
		}
		
		[Column(Storage="_sessionID", Name="session_id", DbType="varchar(128)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string SessionID
		{
			get
			{
				return this._sessionID;
			}
			set
			{
				if (((_sessionID == value) 
							== false))
				{
					this.OnSessionIDChanging(value);
					this._sessionID = value;
					this.OnSessionIDChanged();
				}
			}
		}
		
		[Column(Storage="_timeEntry", Name="time_entry", DbType="varchar(14)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TimeEntry
		{
			get
			{
				return this._timeEntry;
			}
			set
			{
				if (((_timeEntry == value) 
							== false))
				{
					this.OnTimeEntryChanging(value);
					this._timeEntry = value;
					this.OnTimeEntryChanged();
				}
			}
		}
		
		[Column(Storage="_timeLastClick", Name="time_last_click", DbType="varchar(14)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string TimeLastClick
		{
			get
			{
				return this._timeLastClick;
			}
			set
			{
				if (((_timeLastClick == value) 
							== false))
				{
					this.OnTimeLastClickChanging(value);
					this._timeLastClick = value;
					this.OnTimeLastClickChanged();
				}
			}
		}
		
		[Column(Storage="_userAgent", Name="user_agent", DbType="varchar(255)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string UserAgent
		{
			get
			{
				return this._userAgent;
			}
			set
			{
				if (((_userAgent == value) 
							== false))
				{
					this.OnUserAgentChanging(value);
					this._userAgent = value;
					this.OnUserAgentChanged();
				}
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.zones")]
	public partial class Zones : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _zoneCode;
		
		private int _zoneCountryID;
		
		private int _zoneID;
		
		private string _zoneName;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnZoneCodeChanged();
		
		partial void OnZoneCodeChanging(string value);
		
		partial void OnZoneCountryIDChanged();
		
		partial void OnZoneCountryIDChanging(int value);
		
		partial void OnZoneIDChanged();
		
		partial void OnZoneIDChanging(int value);
		
		partial void OnZoneNameChanged();
		
		partial void OnZoneNameChanging(string value);
		#endregion
		
		
		public Zones()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_zoneCode", Name="zone_code", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ZoneCode
		{
			get
			{
				return this._zoneCode;
			}
			set
			{
				if (((_zoneCode == value) 
							== false))
				{
					this.OnZoneCodeChanging(value);
					this.SendPropertyChanging();
					this._zoneCode = value;
					this.SendPropertyChanged("ZoneCode");
					this.OnZoneCodeChanged();
				}
			}
		}
		
		[Column(Storage="_zoneCountryID", Name="zone_country_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ZoneCountryID
		{
			get
			{
				return this._zoneCountryID;
			}
			set
			{
				if ((_zoneCountryID != value))
				{
					this.OnZoneCountryIDChanging(value);
					this.SendPropertyChanging();
					this._zoneCountryID = value;
					this.SendPropertyChanged("ZoneCountryID");
					this.OnZoneCountryIDChanged();
				}
			}
		}
		
		[Column(Storage="_zoneID", Name="zone_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ZoneID
		{
			get
			{
				return this._zoneID;
			}
			set
			{
				if ((_zoneID != value))
				{
					this.OnZoneIDChanging(value);
					this.SendPropertyChanging();
					this._zoneID = value;
					this.SendPropertyChanged("ZoneID");
					this.OnZoneIDChanged();
				}
			}
		}
		
		[Column(Storage="_zoneName", Name="zone_name", DbType="varchar(32)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string ZoneName
		{
			get
			{
				return this._zoneName;
			}
			set
			{
				if (((_zoneName == value) 
							== false))
				{
					this.OnZoneNameChanging(value);
					this.SendPropertyChanging();
					this._zoneName = value;
					this.SendPropertyChanged("ZoneName");
					this.OnZoneNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="reselleradmin_phukienipadx.zones_to_geo_zones")]
	public partial class ZonesToGeOZones : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _associationID;
		
		private System.DateTime _dateAdded;
		
		private System.Nullable<int> _geOzOneID;
		
		private System.Nullable<System.DateTime> _lastModified;
		
		private int _zoneCountryID;
		
		private System.Nullable<int> _zoneID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAssociationIDChanged();
		
		partial void OnAssociationIDChanging(int value);
		
		partial void OnDateAddedChanged();
		
		partial void OnDateAddedChanging(System.DateTime value);
		
		partial void OnGeOZoneIDChanged();
		
		partial void OnGeOZoneIDChanging(System.Nullable<int> value);
		
		partial void OnLastModifiedChanged();
		
		partial void OnLastModifiedChanging(System.Nullable<System.DateTime> value);
		
		partial void OnZoneCountryIDChanged();
		
		partial void OnZoneCountryIDChanging(int value);
		
		partial void OnZoneIDChanged();
		
		partial void OnZoneIDChanging(System.Nullable<int> value);
		#endregion
		
		
		public ZonesToGeOZones()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_associationID", Name="association_id", DbType="int", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int AssociationID
		{
			get
			{
				return this._associationID;
			}
			set
			{
				if ((_associationID != value))
				{
					this.OnAssociationIDChanging(value);
					this.SendPropertyChanging();
					this._associationID = value;
					this.SendPropertyChanged("AssociationID");
					this.OnAssociationIDChanged();
				}
			}
		}
		
		[Column(Storage="_dateAdded", Name="date_added", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime DateAdded
		{
			get
			{
				return this._dateAdded;
			}
			set
			{
				if ((_dateAdded != value))
				{
					this.OnDateAddedChanging(value);
					this.SendPropertyChanging();
					this._dateAdded = value;
					this.SendPropertyChanged("DateAdded");
					this.OnDateAddedChanged();
				}
			}
		}
		
		[Column(Storage="_geOzOneID", Name="geo_zone_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> GeOZoneID
		{
			get
			{
				return this._geOzOneID;
			}
			set
			{
				if ((_geOzOneID != value))
				{
					this.OnGeOZoneIDChanging(value);
					this.SendPropertyChanging();
					this._geOzOneID = value;
					this.SendPropertyChanged("GeOZoneID");
					this.OnGeOZoneIDChanged();
				}
			}
		}
		
		[Column(Storage="_lastModified", Name="last_modified", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> LastModified
		{
			get
			{
				return this._lastModified;
			}
			set
			{
				if ((_lastModified != value))
				{
					this.OnLastModifiedChanging(value);
					this.SendPropertyChanging();
					this._lastModified = value;
					this.SendPropertyChanged("LastModified");
					this.OnLastModifiedChanged();
				}
			}
		}
		
		[Column(Storage="_zoneCountryID", Name="zone_country_id", DbType="int", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int ZoneCountryID
		{
			get
			{
				return this._zoneCountryID;
			}
			set
			{
				if ((_zoneCountryID != value))
				{
					this.OnZoneCountryIDChanging(value);
					this.SendPropertyChanging();
					this._zoneCountryID = value;
					this.SendPropertyChanged("ZoneCountryID");
					this.OnZoneCountryIDChanged();
				}
			}
		}
		
		[Column(Storage="_zoneID", Name="zone_id", DbType="int", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<int> ZoneID
		{
			get
			{
				return this._zoneID;
			}
			set
			{
				if ((_zoneID != value))
				{
					this.OnZoneIDChanging(value);
					this.SendPropertyChanging();
					this._zoneID = value;
					this.SendPropertyChanged("ZoneID");
					this.OnZoneIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
