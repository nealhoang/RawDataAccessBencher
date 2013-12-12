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
	/// <summary>Class which represents the entity 'Culture', mapped on table 'AdventureWorks.Production.Culture'.</summary>
	[Table(Name="[Production].[Culture]")]
	public partial class Culture : INotifyPropertyChanging, INotifyPropertyChanged
	{
		#region Events
		/// <summary>Event which is raised when a property value is changing.</summary>
		public event PropertyChangingEventHandler PropertyChanging;
		/// <summary>Event which is raised when a property value changes.</summary>
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
		
		#region Class Member Declarations
		private System.String	_cultureId;
		private System.DateTime	_modifiedDate;
		private System.String	_name;
		private EntitySet <ProductModelProductDescriptionCulture> _productModelProductDescriptionCultures;
		#endregion
		
		#region Extensibility Method Definitions
		partial void OnLoaded();
		partial void OnValidate(System.Data.Linq.ChangeAction action);
		partial void OnCreated();
		partial void OnCultureIdChanging(System.String value);
		partial void OnCultureIdChanged();
		partial void OnModifiedDateChanging(System.DateTime value);
		partial void OnModifiedDateChanged();
		partial void OnNameChanging(System.String value);
		partial void OnNameChanged();
		#endregion
		
		/// <summary>Initializes a new instance of the <see cref="Culture"/> class.</summary>
		public Culture()
		{
			_productModelProductDescriptionCultures = new EntitySet<ProductModelProductDescriptionCulture>(new Action<ProductModelProductDescriptionCulture>(this.Attach_ProductModelProductDescriptionCultures), new Action<ProductModelProductDescriptionCulture>(this.Detach_ProductModelProductDescriptionCultures) );
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
		private void Attach_ProductModelProductDescriptionCultures(ProductModelProductDescriptionCulture entity)
		{
			this.SendPropertyChanging("ProductModelProductDescriptionCultures");
			entity.Culture = this;
		}
		
		/// <summary>Detaches this instance from the entity specified so it's no longer an associated entity</summary>
		/// <param name="entity">The related entity to detach from</param>
		private void Detach_ProductModelProductDescriptionCultures(ProductModelProductDescriptionCulture entity)
		{
			this.SendPropertyChanging("ProductModelProductDescriptionCultures");
			entity.Culture = null;
		}


		#region Class Property Declarations
		/// <summary>Gets or sets the CultureId field. Mapped on target field 'CultureID'. </summary>
		[Column(Name="CultureID", Storage="_cultureId", CanBeNull=false, DbType="nchar(6) NOT NULL", IsPrimaryKey=true)]
		public System.String CultureId
		{
			get	{ return _cultureId; }
			set
			{
				if((_cultureId != value))
				{
					OnCultureIdChanging(value);
					SendPropertyChanging("CultureId");
					_cultureId = value;
					SendPropertyChanged("CultureId");
					OnCultureIdChanged();
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

		/// <summary>Represents the navigator which is mapped onto the association 'ProductModelProductDescriptionCulture.Culture - Culture.ProductModelProductDescriptionCultures (m:1)'</summary>
		[Association(Name="ProductModelProductDescriptionCulture_Culture985301aed07f4540ad5d30047ae03b49", Storage="_productModelProductDescriptionCultures", OtherKey="CultureId")]
		public EntitySet<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCultures
		{
			get { return this._productModelProductDescriptionCultures; }
			set { this._productModelProductDescriptionCultures.Assign(value); }
		}
		
		#endregion
	}
}
#pragma warning restore 0649