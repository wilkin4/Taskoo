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

namespace Taskoo
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Taskoo")]
	public partial class TaskDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTask(Task instance);
    partial void UpdateTask(Task instance);
    partial void DeleteTask(Task instance);
    #endregion
		
		public TaskDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["TaskooConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public TaskDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public TaskDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Task> Tasks
		{
			get
			{
				return this.GetTable<Task>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Task")]
	public partial class Task : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _taskID;
		
		private System.Nullable<char> _priority;
		
		private string _title;
		
		private System.Nullable<System.DateTime> _finalDate;
		
		private string _description;
		
		private System.Nullable<bool> _isDone;
		
		private System.Nullable<bool> _isAvailable;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntaskIDChanging(int value);
    partial void OntaskIDChanged();
    partial void OnpriorityChanging(System.Nullable<char> value);
    partial void OnpriorityChanged();
    partial void OntitleChanging(string value);
    partial void OntitleChanged();
    partial void OnfinalDateChanging(System.Nullable<System.DateTime> value);
    partial void OnfinalDateChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnisDoneChanging(System.Nullable<bool> value);
    partial void OnisDoneChanged();
    partial void OnisAvailableChanging(System.Nullable<bool> value);
    partial void OnisAvailableChanged();
    #endregion
		
		public Task()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_taskID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int taskID
		{
			get
			{
				return this._taskID;
			}
			set
			{
				if ((this._taskID != value))
				{
					this.OntaskIDChanging(value);
					this.SendPropertyChanging();
					this._taskID = value;
					this.SendPropertyChanged("taskID");
					this.OntaskIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_priority", DbType="Char(1)")]
		public System.Nullable<char> priority
		{
			get
			{
				return this._priority;
			}
			set
			{
				if ((this._priority != value))
				{
					this.OnpriorityChanging(value);
					this.SendPropertyChanging();
					this._priority = value;
					this.SendPropertyChanged("priority");
					this.OnpriorityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_title", DbType="VarChar(255)")]
		public string title
		{
			get
			{
				return this._title;
			}
			set
			{
				if ((this._title != value))
				{
					this.OntitleChanging(value);
					this.SendPropertyChanging();
					this._title = value;
					this.SendPropertyChanged("title");
					this.OntitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_finalDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> finalDate
		{
			get
			{
				return this._finalDate;
			}
			set
			{
				if ((this._finalDate != value))
				{
					this.OnfinalDateChanging(value);
					this.SendPropertyChanging();
					this._finalDate = value;
					this.SendPropertyChanged("finalDate");
					this.OnfinalDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="VarChar(1000)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isDone", DbType="Bit")]
		public System.Nullable<bool> isDone
		{
			get
			{
				return this._isDone;
			}
			set
			{
				if ((this._isDone != value))
				{
					this.OnisDoneChanging(value);
					this.SendPropertyChanging();
					this._isDone = value;
					this.SendPropertyChanged("isDone");
					this.OnisDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_isAvailable", DbType="Bit")]
		public System.Nullable<bool> isAvailable
		{
			get
			{
				return this._isAvailable;
			}
			set
			{
				if ((this._isAvailable != value))
				{
					this.OnisAvailableChanging(value);
					this.SendPropertyChanging();
					this._isAvailable = value;
					this.SendPropertyChanged("isAvailable");
					this.OnisAvailableChanged();
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
