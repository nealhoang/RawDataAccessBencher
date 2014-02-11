﻿//------------------------------------------------------------------------------
// <auto-generated>This code was generated by LLBLGen Pro v4.1.</auto-generated>
//------------------------------------------------------------------------------
using System;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Collections.Specialized;
using System.Collections.Generic;

namespace EF6.Bencher.EntityClasses
{
	/// <summary>Class which represents the entity 'Customer'.</summary>
	[Serializable]
	[DataContract(IsReference=true)]
	public partial class Customer : CommonEntityBase
	{
		/// <summary>Initializes a new instance of the <see cref="Customer"/> class.</summary>
		public Customer() : base()
		{
			this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
		}

		#region Class Property Declarations
		/// <summary>Gets or sets the AccountNumber field. </summary>
		[DataMember]
		public System.String AccountNumber { get; set;}
		/// <summary>Gets or sets the CustomerId field. </summary>
		[DataMember]
		public System.Int32 CustomerId { get; set;}
		/// <summary>Gets or sets the ModifiedDate field. </summary>
		[DataMember]
		public System.DateTime ModifiedDate { get; set;}
		/// <summary>Gets or sets the PersonId field. </summary>
		[DataMember]
		public Nullable<System.Int32> PersonId { get; set;}
		/// <summary>Gets or sets the Rowguid field. </summary>
		[DataMember]
		public System.Guid Rowguid { get; set;}
		/// <summary>Gets or sets the StoreId field. </summary>
		[DataMember]
		public Nullable<System.Int32> StoreId { get; set;}
		/// <summary>Gets or sets the TerritoryId field. </summary>
		[DataMember]
		public Nullable<System.Int32> TerritoryId { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Person - Person.Person.Customers (m:1)'</summary>
		[DataMember]
		public virtual Person Person { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'SalesOrderHeader.Customer - Customer.SalesOrderHeaders (m:1)'</summary>
		[DataMember]
		public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.SalesTerritory - SalesTerritory.Customers (m:1)'</summary>
		[DataMember]
		public virtual SalesTerritory SalesTerritory { get; set;}
		/// <summary>Represents the navigator which is mapped onto the association 'Customer.Store - Store.Customers (m:1)'</summary>
		[DataMember]
		public virtual Store Store { get; set;}
		#endregion
	}
}
