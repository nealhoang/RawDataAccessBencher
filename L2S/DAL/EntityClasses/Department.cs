﻿#pragma warning disable 0649
//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;

namespace L2S.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Department', mapped on table 'AdventureWorks.HumanResources.Department'.</summary>
	[Table(Name="[HumanResources].[Department]")]
	public partial class Department : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.Int16	_departmentId;
		private System.String	_groupName;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private EntitySet <EmployeeDepartmentHistory> _employeeDepartmentHistories;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnDepartmentIdChanging(System.Int16 value);
		partial void OnDepartmentIdChanged();
		partial void OnGroupNameChanging(System.String value);
		partial void OnGroupNameChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Department"/> class.</summary>
		public Department()
		{
			_employeeDepartmentHistories = new EntitySet<EmployeeDepartmentHistory>(new Action<EmployeeDepartmentHistory>(this.Attach_EmployeeDepartmentHistories), new Action<EmployeeDepartmentHistory>(this.Detach_EmployeeDepartmentHistories) );
			OnCreated();
		}

		/// <summary>Raises the PropertyChanging event</summary>
		/// <param name="propertyName">name of the property which is changing</param>
		protected virtual void SendPropertyChanging(string propertyName)
		{
			if((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>Raises the PropertyChanged event for the property specified</summary>
		/// <param name="propertyName">name of the property which was changed</param>
		protected virtual void SendPropertyChanged(string propertyName)
		{
			if((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		/// <summary>Attaches this instance to the entity specified as an associated entity</summary>
		/// <param name="entity">The related entity to attach to</param>
		private void Attach_EmployeeDepartmentHistories(EmployeeDepartmentHistory entity)
		{
			this.SendPropertyChanging("EmployeeDepartmentHistories");
			entity.Department = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_EmployeeDepartmentHistories(EmployeeDepartmentHistory entity)
		{
			this.SendPropertyChanging("EmployeeDepartmentHistories");
			entity.Department = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the DepartmentId field. Mapped on target field 'DepartmentID'. </summary>
		[Column(Name="DepartmentID", Storage="_departmentId", AutoSync=AutoSync.OnInsert, CanBeNull=false, DbType="smallint NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true, UpdateCheck=UpdateCheck.Never)]
		public System.Int16 DepartmentId
		{
			get	{ return _departmentId; }
			set
			{
				if((_departmentId != value))
				{
					OnDepartmentIdChanging(value);
					SendPropertyChanging("DepartmentId");
					_departmentId = value;
					SendPropertyChanged("DepartmentId");
					OnDepartmentIdChanged();
				}
			}
		}

		/// <summary>Gets or sets the GroupName field. Mapped on target field 'GroupName'. </summary>
		[Column(Name="GroupName", Storage="_groupName", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String GroupName
		{
			get	{ return _groupName; }
			set
			{
				if((_groupName != value))
				{
					OnGroupNameChanging(value);
					SendPropertyChanging("GroupName");
					_groupName = value;
					SendPropertyChanged("GroupName");
					OnGroupNameChanged();
				}
			}
		}

		/// <summary>Gets or sets the ModifiedDate field. Mapped on target field 'ModifiedDate'. </summary>
		[Column(Name="ModifiedDate", Storage="_modifiedDate", CanBeNull=false, DbType="datetime NOT NULL")]
		public System.DateTime ModifiedDate
		{
			get	{ return _modifiedDate; }
			set
			{
				if((_modifiedDate != value))
				{
					OnModifiedDateChanging(value);
					SendPropertyChanging("ModifiedDate");
					_modifiedDate = value;
					SendPropertyChanged("ModifiedDate");
					OnModifiedDateChanged();
				}
			}
		}

		/// <summary>Gets or sets the Name field. Mapped on target field 'Name'. </summary>
		[Column(Name="Name", Storage="_name", CanBeNull=false, DbType="nvarchar(50) NOT NULL")]
		public System.String Name
		{
			get	{ return _name; }
			set
			{
				if((_name != value))
				{
					OnNameChanging(value);
					SendPropertyChanging("Name");
					_name = value;
					SendPropertyChanged("Name");
					OnNameChanged();
				}
			}
		}

		/// <summary>Represents the navigator which is mapped onto the association 'EmployeeDepartmentHistory.Department - Department.EmployeeDepartmentHistories (m:1)'</summary>
		[Association(Name="EmployeeDepartmentHistory_Department80b9743b51654c6b973acf049e8d5735", Storage="_employeeDepartmentHistories", OtherKey="DepartmentId")]
		public EntitySet<EmployeeDepartmentHistory> EmployeeDepartmentHistories
		{
			get { return this._employeeDepartmentHistories; }
			set { this._employeeDepartmentHistories.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649