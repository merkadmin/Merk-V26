using System;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	public class InventoryStore_DTO : IDTO
	{
		public long ID { get; set; }
		public string Name_P { get; set; }
		public string Name_S { get; set; }
		public long ParentInventoryStore_CU_ID { get; set; }
		public long InventoryCategory_CU_ID { get; set; }
		public bool IsFavorite { get; set; }
		public bool IsMain { get; set; }
		public bool UseAcceptReceive { get; set; }
		public long Department_CU_ID { get; set; }
		public long InChargeID { get; set; }
		public long Location_CU_ID { get; set; }
		public long Floor_CU_ID { get; set; }
		public string InternalCode { get; set; }
		public string Description { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(InventoryStore_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public long InsertedBy { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }
	}
}
