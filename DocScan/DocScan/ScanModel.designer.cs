﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DocScanSO
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SalesOrderScan")]
	public partial class ScanModelDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSalesOrdersArchive(SalesOrdersArchive instance);
    partial void UpdateSalesOrdersArchive(SalesOrdersArchive instance);
    partial void DeleteSalesOrdersArchive(SalesOrdersArchive instance);
    partial void InsertWorkOrdersArchive(WorkOrdersArchive instance);
    partial void UpdateWorkOrdersArchive(WorkOrdersArchive instance);
    partial void DeleteWorkOrdersArchive(WorkOrdersArchive instance);
    partial void InsertSetupInfo(SetupInfo instance);
    partial void UpdateSetupInfo(SetupInfo instance);
    partial void DeleteSetupInfo(SetupInfo instance);
    #endregion
		
		public ScanModelDataContext() : 
				base(global::DocScan.Properties.Settings.Default.SalesOrderScanConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ScanModelDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScanModelDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScanModelDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ScanModelDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SalesOrdersArchive> SalesOrdersArchives
		{
			get
			{
				return this.GetTable<SalesOrdersArchive>();
			}
		}
		
		public System.Data.Linq.Table<WorkOrdersArchive> WorkOrdersArchives
		{
			get
			{
				return this.GetTable<WorkOrdersArchive>();
			}
		}
		
		public System.Data.Linq.Table<SetupInfo> SetupInfos
		{
			get
			{
				return this.GetTable<SetupInfo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SalesOrdersArchive")]
	public partial class SalesOrdersArchive : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SONumber;
		
		private string _VendorName;
		
		private string _FileName;
		
		private System.Nullable<System.DateTime> _SODate;
		
		private System.DateTime _ScanDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSONumberChanging(string value);
    partial void OnSONumberChanged();
    partial void OnVendorNameChanging(string value);
    partial void OnVendorNameChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnSODateChanging(System.Nullable<System.DateTime> value);
    partial void OnSODateChanged();
    partial void OnScanDateChanging(System.DateTime value);
    partial void OnScanDateChanged();
    #endregion
		
		public SalesOrdersArchive()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SONumber", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string SONumber
		{
			get
			{
				return this._SONumber;
			}
			set
			{
				if ((this._SONumber != value))
				{
					this.OnSONumberChanging(value);
					this.SendPropertyChanging();
					this._SONumber = value;
					this.SendPropertyChanged("SONumber");
					this.OnSONumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VendorName", DbType="VarChar(50)")]
		public string VendorName
		{
			get
			{
				return this._VendorName;
			}
			set
			{
				if ((this._VendorName != value))
				{
					this.OnVendorNameChanging(value);
					this.SendPropertyChanging();
					this._VendorName = value;
					this.SendPropertyChanged("VendorName");
					this.OnVendorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(50)")]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SODate", DbType="Date")]
		public System.Nullable<System.DateTime> SODate
		{
			get
			{
				return this._SODate;
			}
			set
			{
				if ((this._SODate != value))
				{
					this.OnSODateChanging(value);
					this.SendPropertyChanging();
					this._SODate = value;
					this.SendPropertyChanged("SODate");
					this.OnSODateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScanDate", DbType="Date NOT NULL")]
		public System.DateTime ScanDate
		{
			get
			{
				return this._ScanDate;
			}
			set
			{
				if ((this._ScanDate != value))
				{
					this.OnScanDateChanging(value);
					this.SendPropertyChanging();
					this._ScanDate = value;
					this.SendPropertyChanged("ScanDate");
					this.OnScanDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkOrdersArchive")]
	public partial class WorkOrdersArchive : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _WONumber;
		
		private string _SOCustomerNumber;
		
		private string _CustomerName;
		
		private string _FileName;
		
		private System.Nullable<int> _LaborHoursStandard;
		
		private System.Nullable<int> _LaborHoursActual;
		
		private string _MakeForSalesOrderNumber;
		
		private System.Nullable<System.DateTime> _WODate;
		
		private System.DateTime _ScanDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnWONumberChanging(string value);
    partial void OnWONumberChanged();
    partial void OnSOCustomerNumberChanging(string value);
    partial void OnSOCustomerNumberChanged();
    partial void OnCustomerNameChanging(string value);
    partial void OnCustomerNameChanged();
    partial void OnFileNameChanging(string value);
    partial void OnFileNameChanged();
    partial void OnLaborHoursStandardChanging(System.Nullable<int> value);
    partial void OnLaborHoursStandardChanged();
    partial void OnLaborHoursActualChanging(System.Nullable<int> value);
    partial void OnLaborHoursActualChanged();
    partial void OnMakeForSalesOrderNumberChanging(string value);
    partial void OnMakeForSalesOrderNumberChanged();
    partial void OnWODateChanging(System.Nullable<System.DateTime> value);
    partial void OnWODateChanged();
    partial void OnScanDateChanging(System.DateTime value);
    partial void OnScanDateChanged();
    #endregion
		
		public WorkOrdersArchive()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WONumber", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string WONumber
		{
			get
			{
				return this._WONumber;
			}
			set
			{
				if ((this._WONumber != value))
				{
					this.OnWONumberChanging(value);
					this.SendPropertyChanging();
					this._WONumber = value;
					this.SendPropertyChanged("WONumber");
					this.OnWONumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SOCustomerNumber", DbType="VarChar(50)")]
		public string SOCustomerNumber
		{
			get
			{
				return this._SOCustomerNumber;
			}
			set
			{
				if ((this._SOCustomerNumber != value))
				{
					this.OnSOCustomerNumberChanging(value);
					this.SendPropertyChanging();
					this._SOCustomerNumber = value;
					this.SendPropertyChanged("SOCustomerNumber");
					this.OnSOCustomerNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerName", DbType="VarChar(50)")]
		public string CustomerName
		{
			get
			{
				return this._CustomerName;
			}
			set
			{
				if ((this._CustomerName != value))
				{
					this.OnCustomerNameChanging(value);
					this.SendPropertyChanging();
					this._CustomerName = value;
					this.SendPropertyChanged("CustomerName");
					this.OnCustomerNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FileName", DbType="VarChar(50)")]
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if ((this._FileName != value))
				{
					this.OnFileNameChanging(value);
					this.SendPropertyChanging();
					this._FileName = value;
					this.SendPropertyChanged("FileName");
					this.OnFileNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaborHoursStandard", DbType="Int")]
		public System.Nullable<int> LaborHoursStandard
		{
			get
			{
				return this._LaborHoursStandard;
			}
			set
			{
				if ((this._LaborHoursStandard != value))
				{
					this.OnLaborHoursStandardChanging(value);
					this.SendPropertyChanging();
					this._LaborHoursStandard = value;
					this.SendPropertyChanged("LaborHoursStandard");
					this.OnLaborHoursStandardChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LaborHoursActual", DbType="Int")]
		public System.Nullable<int> LaborHoursActual
		{
			get
			{
				return this._LaborHoursActual;
			}
			set
			{
				if ((this._LaborHoursActual != value))
				{
					this.OnLaborHoursActualChanging(value);
					this.SendPropertyChanging();
					this._LaborHoursActual = value;
					this.SendPropertyChanged("LaborHoursActual");
					this.OnLaborHoursActualChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MakeForSalesOrderNumber", DbType="NChar(10)")]
		public string MakeForSalesOrderNumber
		{
			get
			{
				return this._MakeForSalesOrderNumber;
			}
			set
			{
				if ((this._MakeForSalesOrderNumber != value))
				{
					this.OnMakeForSalesOrderNumberChanging(value);
					this.SendPropertyChanging();
					this._MakeForSalesOrderNumber = value;
					this.SendPropertyChanged("MakeForSalesOrderNumber");
					this.OnMakeForSalesOrderNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WODate", DbType="Date")]
		public System.Nullable<System.DateTime> WODate
		{
			get
			{
				return this._WODate;
			}
			set
			{
				if ((this._WODate != value))
				{
					this.OnWODateChanging(value);
					this.SendPropertyChanging();
					this._WODate = value;
					this.SendPropertyChanged("WODate");
					this.OnWODateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ScanDate", DbType="Date NOT NULL")]
		public System.DateTime ScanDate
		{
			get
			{
				return this._ScanDate;
			}
			set
			{
				if ((this._ScanDate != value))
				{
					this.OnScanDateChanging(value);
					this.SendPropertyChanging();
					this._ScanDate = value;
					this.SendPropertyChanged("ScanDate");
					this.OnScanDateChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SetupInfo")]
	public partial class SetupInfo : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _operatorName;
		
		private string _watchFileLocation;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnoperatorNameChanging(string value);
    partial void OnoperatorNameChanged();
    partial void OnwatchFileLocationChanging(string value);
    partial void OnwatchFileLocationChanged();
    #endregion
		
		public SetupInfo()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_operatorName", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string operatorName
		{
			get
			{
				return this._operatorName;
			}
			set
			{
				if ((this._operatorName != value))
				{
					this.OnoperatorNameChanging(value);
					this.SendPropertyChanging();
					this._operatorName = value;
					this.SendPropertyChanged("operatorName");
					this.OnoperatorNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_watchFileLocation", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string watchFileLocation
		{
			get
			{
				return this._watchFileLocation;
			}
			set
			{
				if ((this._watchFileLocation != value))
				{
					this.OnwatchFileLocationChanging(value);
					this.SendPropertyChanging();
					this._watchFileLocation = value;
					this.SendPropertyChanged("watchFileLocation");
					this.OnwatchFileLocationChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
