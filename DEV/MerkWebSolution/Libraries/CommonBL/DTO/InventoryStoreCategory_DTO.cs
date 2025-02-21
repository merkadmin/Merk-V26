using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(InventoryStoreCategory_cu))]
	public class InventoryStoreCategory_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.Name_P))]
		[MapTo("Name_P")]
		public string CategoryName_P { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.Name_S))]
		[MapTo("Name_S")]
		public string CategoryName_S { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.InChargeID))]
		[MapTo("InChargeID")]
		public object InChargeID { get; set; }

		public object InChargeName_P { get; set; }
		public object InChargeName_S { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.InternalCode))]
		[MapTo("InternalCode")]
		public string CategoryInternalCode { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.Description))]
		[MapTo("Description")]
		public string Description { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }

		public long RowCount { get; set; }

		[SourceMember(nameof(InventoryStoreCategory_cu.InsertedDate))]
		[MapTo("InsertedDate")]
		public DateTime InsertedDate { get; set; }

		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }
	}
}
