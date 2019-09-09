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

namespace ConsoleApplication1
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="SqlDatabaseProject")]
	public partial class DbDataContextDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertcolor(color instance);
    partial void Updatecolor(color instance);
    partial void Deletecolor(color instance);
    partial void Insertgos_number(gos_number instance);
    partial void Updategos_number(gos_number instance);
    partial void Deletegos_number(gos_number instance);
    partial void Insertmodel_car(model_car instance);
    partial void Updatemodel_car(model_car instance);
    partial void Deletemodel_car(model_car instance);
    #endregion
		
		public DbDataContextDataContext() : 
				base(global::ConsoleApplication1.Properties.Settings.Default.SqlDatabaseProjectConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContextDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContextDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContextDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DbDataContextDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<color> colors
		{
			get
			{
				return this.GetTable<color>();
			}
		}
		
		public System.Data.Linq.Table<gos_number> gos_numbers
		{
			get
			{
				return this.GetTable<gos_number>();
			}
		}
		
		public System.Data.Linq.Table<model_car> model_cars
		{
			get
			{
				return this.GetTable<model_car>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Procedure1")]
		public ISingleResult<Procedure1Result> Procedure1([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param1, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> param2)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), param1, param2);
			return ((ISingleResult<Procedure1Result>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.color")]
	public partial class color : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _color1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Oncolor1Changing(string value);
    partial void Oncolor1Changed();
    #endregion
		
		public color()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="color", Storage="_color1", DbType="NChar(10)")]
		public string color1
		{
			get
			{
				return this._color1;
			}
			set
			{
				if ((this._color1 != value))
				{
					this.Oncolor1Changing(value);
					this.SendPropertyChanging();
					this._color1 = value;
					this.SendPropertyChanged("color1");
					this.Oncolor1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.gos_number")]
	public partial class gos_number : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _number;
		
		private string _serial;
		
		private string _region;
		
		private System.Nullable<int> _idModelCar;
		
		private System.Nullable<int> _idColor;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnnumberChanging(string value);
    partial void OnnumberChanged();
    partial void OnserialChanging(string value);
    partial void OnserialChanged();
    partial void OnregionChanging(string value);
    partial void OnregionChanged();
    partial void OnidModelCarChanging(System.Nullable<int> value);
    partial void OnidModelCarChanged();
    partial void OnidColorChanging(System.Nullable<int> value);
    partial void OnidColorChanged();
    #endregion
		
		public gos_number()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_number", DbType="NChar(10)")]
		public string number
		{
			get
			{
				return this._number;
			}
			set
			{
				if ((this._number != value))
				{
					this.OnnumberChanging(value);
					this.SendPropertyChanging();
					this._number = value;
					this.SendPropertyChanged("number");
					this.OnnumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_serial", DbType="NChar(10)")]
		public string serial
		{
			get
			{
				return this._serial;
			}
			set
			{
				if ((this._serial != value))
				{
					this.OnserialChanging(value);
					this.SendPropertyChanging();
					this._serial = value;
					this.SendPropertyChanged("serial");
					this.OnserialChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_region", DbType="NChar(10)")]
		public string region
		{
			get
			{
				return this._region;
			}
			set
			{
				if ((this._region != value))
				{
					this.OnregionChanging(value);
					this.SendPropertyChanging();
					this._region = value;
					this.SendPropertyChanged("region");
					this.OnregionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idModelCar", DbType="Int")]
		public System.Nullable<int> idModelCar
		{
			get
			{
				return this._idModelCar;
			}
			set
			{
				if ((this._idModelCar != value))
				{
					this.OnidModelCarChanging(value);
					this.SendPropertyChanging();
					this._idModelCar = value;
					this.SendPropertyChanged("idModelCar");
					this.OnidModelCarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idColor", DbType="Int")]
		public System.Nullable<int> idColor
		{
			get
			{
				return this._idColor;
			}
			set
			{
				if ((this._idColor != value))
				{
					this.OnidColorChanging(value);
					this.SendPropertyChanging();
					this._idColor = value;
					this.SendPropertyChanged("idColor");
					this.OnidColorChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.model_car")]
	public partial class model_car : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _model;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnmodelChanging(string value);
    partial void OnmodelChanged();
    #endregion
		
		public model_car()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="Int NOT NULL", IsPrimaryKey=true)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_model", DbType="NChar(10)")]
		public string model
		{
			get
			{
				return this._model;
			}
			set
			{
				if ((this._model != value))
				{
					this.OnmodelChanging(value);
					this.SendPropertyChanging();
					this._model = value;
					this.SendPropertyChanged("model");
					this.OnmodelChanged();
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
	
	public partial class Procedure1Result
	{
		
		private string _color;
		
		public Procedure1Result()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_color", DbType="NChar(10)")]
		public string color
		{
			get
			{
				return this._color;
			}
			set
			{
				if ((this._color != value))
				{
					this._color = value;
				}
			}
		}
	}
}
#pragma warning restore 1591