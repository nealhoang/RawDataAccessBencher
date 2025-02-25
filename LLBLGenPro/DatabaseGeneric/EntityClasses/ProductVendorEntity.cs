﻿//////////////////////////////////////////////////////////////
// <auto-generated>This code was generated by LLBLGen Pro 5.9.</auto-generated>
//////////////////////////////////////////////////////////////
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
//////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using AdventureWorks.Dal.Adapter.HelperClasses;
using AdventureWorks.Dal.Adapter.FactoryClasses;
using AdventureWorks.Dal.Adapter.RelationClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AdventureWorks.Dal.Adapter.EntityClasses
{
	// __LLBLGENPRO_USER_CODE_REGION_START AdditionalNamespaces
	// __LLBLGENPRO_USER_CODE_REGION_END
	/// <summary>Entity class which represents the entity 'ProductVendor'.<br/><br/></summary>
	[Serializable]
	public partial class ProductVendorEntity : CommonEntityBase
		// __LLBLGENPRO_USER_CODE_REGION_START AdditionalInterfaces
		// __LLBLGENPRO_USER_CODE_REGION_END	
	{
		private ProductEntity _product;
		private UnitMeasureEntity _unitMeasure;
		private VendorEntity _vendor;

		// __LLBLGENPRO_USER_CODE_REGION_START PrivateMembers
		// __LLBLGENPRO_USER_CODE_REGION_END
		private static ProductVendorEntityStaticMetaData _staticMetaData = new ProductVendorEntityStaticMetaData();
		private static ProductVendorRelations _relationsFactory = new ProductVendorRelations();

		/// <summary>All names of fields mapped onto a relation. Usable for in-memory filtering</summary>
		public static partial class MemberNames
		{
			/// <summary>Member name Product</summary>
			public static readonly string Product = "Product";
			/// <summary>Member name UnitMeasure</summary>
			public static readonly string UnitMeasure = "UnitMeasure";
			/// <summary>Member name Vendor</summary>
			public static readonly string Vendor = "Vendor";
		}

		/// <summary>Static meta-data storage for navigator related information</summary>
		protected class ProductVendorEntityStaticMetaData : EntityStaticMetaDataBase
		{
			public ProductVendorEntityStaticMetaData()
			{
				SetEntityCoreInfo("ProductVendorEntity", InheritanceHierarchyType.None, false, (int)AdventureWorks.Dal.Adapter.EntityType.ProductVendorEntity, typeof(ProductVendorEntity), typeof(ProductVendorEntityFactory), false);
				AddNavigatorMetaData<ProductVendorEntity, ProductEntity>("Product", "ProductVendors", (a, b) => a._product = b, a => a._product, (a, b) => a.Product = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductVendorRelations.ProductEntityUsingProductIdStatic, ()=>new ProductVendorRelations().ProductEntityUsingProductId, null, new int[] { (int)ProductVendorFieldIndex.ProductId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.ProductEntity);
				AddNavigatorMetaData<ProductVendorEntity, UnitMeasureEntity>("UnitMeasure", "ProductVendors", (a, b) => a._unitMeasure = b, a => a._unitMeasure, (a, b) => a.UnitMeasure = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductVendorRelations.UnitMeasureEntityUsingUnitMeasureCodeStatic, ()=>new ProductVendorRelations().UnitMeasureEntityUsingUnitMeasureCode, null, new int[] { (int)ProductVendorFieldIndex.UnitMeasureCode }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.UnitMeasureEntity);
				AddNavigatorMetaData<ProductVendorEntity, VendorEntity>("Vendor", "ProductVendors", (a, b) => a._vendor = b, a => a._vendor, (a, b) => a.Vendor = b, AdventureWorks.Dal.Adapter.RelationClasses.StaticProductVendorRelations.VendorEntityUsingVendorIdStatic, ()=>new ProductVendorRelations().VendorEntityUsingVendorId, null, new int[] { (int)ProductVendorFieldIndex.VendorId }, null, true, (int)AdventureWorks.Dal.Adapter.EntityType.VendorEntity);
			}
		}

		/// <summary>Static ctor</summary>
		static ProductVendorEntity()
		{
		}

		/// <summary> CTor</summary>
		public ProductVendorEntity()
		{
			InitClassEmpty(null, null);
		}

		/// <summary> CTor</summary>
		/// <param name="fields">Fields object to set as the fields for this entity.</param>
		public ProductVendorEntity(IEntityFields2 fields)
		{
			InitClassEmpty(null, fields);
		}

		/// <summary> CTor</summary>
		/// <param name="validator">The custom validator object for this ProductVendorEntity</param>
		public ProductVendorEntity(IValidator validator)
		{
			InitClassEmpty(validator, null);
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorId">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		public ProductVendorEntity(System.Int32 productId, System.Int32 vendorId) : this(productId, vendorId, null)
		{
		}

		/// <summary> CTor</summary>
		/// <param name="productId">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="vendorId">PK value for ProductVendor which data should be fetched into this ProductVendor object</param>
		/// <param name="validator">The custom validator object for this ProductVendorEntity</param>
		public ProductVendorEntity(System.Int32 productId, System.Int32 vendorId, IValidator validator)
		{
			InitClassEmpty(validator, null);
			this.ProductId = productId;
			this.VendorId = vendorId;
		}

		/// <summary>Private CTor for deserialization</summary>
		/// <param name="info"></param>
		/// <param name="context"></param>
		protected ProductVendorEntity(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			// __LLBLGENPRO_USER_CODE_REGION_START DeserializationConstructor
			// __LLBLGENPRO_USER_CODE_REGION_END
		}

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Product' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoProduct() { return CreateRelationInfoForNavigator("Product"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'UnitMeasure' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoUnitMeasure() { return CreateRelationInfoForNavigator("UnitMeasure"); }

		/// <summary>Creates a new IRelationPredicateBucket object which contains the predicate expression and relation collection to fetch the related entity of type 'Vendor' to this entity.</summary>
		/// <returns></returns>
		public virtual IRelationPredicateBucket GetRelationInfoVendor() { return CreateRelationInfoForNavigator("Vendor"); }
		
		/// <inheritdoc/>
		protected override EntityStaticMetaDataBase GetEntityStaticMetaData() {	return _staticMetaData; }

		/// <summary>Initializes the class members</summary>
		private void InitClassMembers()
		{
			PerformDependencyInjection();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassMembers
			// __LLBLGENPRO_USER_CODE_REGION_END
			OnInitClassMembersComplete();
		}

		/// <summary>Initializes the class with empty data, as if it is a new Entity.</summary>
		/// <param name="validator">The validator object for this ProductVendorEntity</param>
		/// <param name="fields">Fields of this entity</param>
		private void InitClassEmpty(IValidator validator, IEntityFields2 fields)
		{
			OnInitializing();
			this.Fields = fields ?? CreateFields();
			this.Validator = validator;
			InitClassMembers();
			// __LLBLGENPRO_USER_CODE_REGION_START InitClassEmpty
			// __LLBLGENPRO_USER_CODE_REGION_END

			OnInitialized();
		}

		/// <summary>The relations object holding all relations of this entity with other entity classes.</summary>
		public static ProductVendorRelations Relations { get { return _relationsFactory; } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Product' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathProduct { get { return _staticMetaData.GetPrefetchPathElement("Product", CommonEntityBase.CreateEntityCollection<ProductEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'UnitMeasure' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathUnitMeasure { get { return _staticMetaData.GetPrefetchPathElement("UnitMeasure", CommonEntityBase.CreateEntityCollection<UnitMeasureEntity>()); } }

		/// <summary>Creates a new PrefetchPathElement2 object which contains all the information to prefetch the related entities of type 'Vendor' for this entity.</summary>
		/// <returns>Ready to use IPrefetchPathElement2 implementation.</returns>
		public static IPrefetchPathElement2 PrefetchPathVendor { get { return _staticMetaData.GetPrefetchPathElement("Vendor", CommonEntityBase.CreateEntityCollection<VendorEntity>()); } }

		/// <summary>The AverageLeadTime property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."AverageLeadTime".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 AverageLeadTime
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.AverageLeadTime, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.AverageLeadTime, value); }
		}

		/// <summary>The LastReceiptCost property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."LastReceiptCost".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Decimal> LastReceiptCost
		{
			get { return (Nullable<System.Decimal>)GetValue((int)ProductVendorFieldIndex.LastReceiptCost, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.LastReceiptCost, value); }
		}

		/// <summary>The LastReceiptDate property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."LastReceiptDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.DateTime> LastReceiptDate
		{
			get { return (Nullable<System.DateTime>)GetValue((int)ProductVendorFieldIndex.LastReceiptDate, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.LastReceiptDate, value); }
		}

		/// <summary>The MaxOrderQty property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."MaxOrderQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MaxOrderQty
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.MaxOrderQty, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.MaxOrderQty, value); }
		}

		/// <summary>The MinOrderQty property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."MinOrderQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Int32 MinOrderQty
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.MinOrderQty, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.MinOrderQty, value); }
		}

		/// <summary>The ModifiedDate property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."ModifiedDate".<br/>Table field type characteristics (type, precision, scale, length): DateTime, 0, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.DateTime ModifiedDate
		{
			get { return (System.DateTime)GetValue((int)ProductVendorFieldIndex.ModifiedDate, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.ModifiedDate, value); }
		}

		/// <summary>The OnOrderQty property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."OnOrderQty".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): true, false, false</remarks>
		public virtual Nullable<System.Int32> OnOrderQty
		{
			get { return (Nullable<System.Int32>)GetValue((int)ProductVendorFieldIndex.OnOrderQty, false); }
			set	{ SetValue((int)ProductVendorFieldIndex.OnOrderQty, value); }
		}

		/// <summary>The ProductId property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."ProductID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 ProductId
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.ProductId, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.ProductId, value); }
		}

		/// <summary>The StandardPrice property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."StandardPrice".<br/>Table field type characteristics (type, precision, scale, length): Money, 19, 4, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.Decimal StandardPrice
		{
			get { return (System.Decimal)GetValue((int)ProductVendorFieldIndex.StandardPrice, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.StandardPrice, value); }
		}

		/// <summary>The UnitMeasureCode property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."UnitMeasureCode".<br/>Table field type characteristics (type, precision, scale, length): NChar, 0, 0, 3.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, false, false</remarks>
		public virtual System.String UnitMeasureCode
		{
			get { return (System.String)GetValue((int)ProductVendorFieldIndex.UnitMeasureCode, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.UnitMeasureCode, value); }
		}

		/// <summary>The VendorId property of the Entity ProductVendor<br/><br/></summary>
		/// <remarks>Mapped on  table field: "ProductVendor"."BusinessEntityID".<br/>Table field type characteristics (type, precision, scale, length): Int, 10, 0, 0.<br/>Table field behavior characteristics (is nullable, is PK, is identity): false, true, false</remarks>
		public virtual System.Int32 VendorId
		{
			get { return (System.Int32)GetValue((int)ProductVendorFieldIndex.VendorId, true); }
			set	{ SetValue((int)ProductVendorFieldIndex.VendorId, value); }
		}

		/// <summary>Gets / sets related entity of type 'ProductEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual ProductEntity Product
		{
			get { return _product; }
			set { SetSingleRelatedEntityNavigator(value, "Product"); }
		}

		/// <summary>Gets / sets related entity of type 'UnitMeasureEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual UnitMeasureEntity UnitMeasure
		{
			get { return _unitMeasure; }
			set { SetSingleRelatedEntityNavigator(value, "UnitMeasure"); }
		}

		/// <summary>Gets / sets related entity of type 'VendorEntity' which has to be set using a fetch action earlier. If no related entity is set for this property, null is returned..<br/><br/></summary>
		[Browsable(false)]
		public virtual VendorEntity Vendor
		{
			get { return _vendor; }
			set { SetSingleRelatedEntityNavigator(value, "Vendor"); }
		}

		// __LLBLGENPRO_USER_CODE_REGION_START CustomEntityCode
		// __LLBLGENPRO_USER_CODE_REGION_END

	}
}

namespace AdventureWorks.Dal.Adapter
{
	public enum ProductVendorFieldIndex
	{
		///<summary>AverageLeadTime. </summary>
		AverageLeadTime,
		///<summary>LastReceiptCost. </summary>
		LastReceiptCost,
		///<summary>LastReceiptDate. </summary>
		LastReceiptDate,
		///<summary>MaxOrderQty. </summary>
		MaxOrderQty,
		///<summary>MinOrderQty. </summary>
		MinOrderQty,
		///<summary>ModifiedDate. </summary>
		ModifiedDate,
		///<summary>OnOrderQty. </summary>
		OnOrderQty,
		///<summary>ProductId. </summary>
		ProductId,
		///<summary>StandardPrice. </summary>
		StandardPrice,
		///<summary>UnitMeasureCode. </summary>
		UnitMeasureCode,
		///<summary>VendorId. </summary>
		VendorId,
		/// <summary></summary>
		AmountOfFields
	}
}

namespace AdventureWorks.Dal.Adapter.RelationClasses
{
	/// <summary>Implements the relations factory for the entity: ProductVendor. </summary>
	public partial class ProductVendorRelations: RelationFactory
	{

		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and ProductEntity over the m:1 relation they have, using the relation between the fields: ProductVendor.ProductId - Product.ProductId</summary>
		public virtual IEntityRelation ProductEntityUsingProductId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Product", false, new[] { ProductFields.ProductId, ProductVendorFields.ProductId }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and UnitMeasureEntity over the m:1 relation they have, using the relation between the fields: ProductVendor.UnitMeasureCode - UnitMeasure.UnitMeasureCode</summary>
		public virtual IEntityRelation UnitMeasureEntityUsingUnitMeasureCode
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "UnitMeasure", false, new[] { UnitMeasureFields.UnitMeasureCode, ProductVendorFields.UnitMeasureCode }); }
		}

		/// <summary>Returns a new IEntityRelation object, between ProductVendorEntity and VendorEntity over the m:1 relation they have, using the relation between the fields: ProductVendor.VendorId - Vendor.VendorId</summary>
		public virtual IEntityRelation VendorEntityUsingVendorId
		{
			get	{ return ModelInfoProviderSingleton.GetInstance().CreateRelation(RelationType.ManyToOne, "Vendor", false, new[] { VendorFields.VendorId, ProductVendorFields.VendorId }); }
		}

	}
	
	/// <summary>Static class which is used for providing relationship instances which are re-used internally for syncing</summary>
	internal static class StaticProductVendorRelations
	{
		internal static readonly IEntityRelation ProductEntityUsingProductIdStatic = new ProductVendorRelations().ProductEntityUsingProductId;
		internal static readonly IEntityRelation UnitMeasureEntityUsingUnitMeasureCodeStatic = new ProductVendorRelations().UnitMeasureEntityUsingUnitMeasureCode;
		internal static readonly IEntityRelation VendorEntityUsingVendorIdStatic = new ProductVendorRelations().VendorEntityUsingVendorId;

		/// <summary>CTor</summary>
		static StaticProductVendorRelations() { }
	}
}
