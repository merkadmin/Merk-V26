using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(Floor_cu))]
	public class Floor_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(Floor_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(Floor_cu.Name_P))]
		[MapTo("Name_P")]
		public string FloorName_P { get; set; }

		[SourceMember(nameof(Floor_cu.Name_S))]
		[MapTo("Name_S")]
		public string FloorName_S { get; set; }

		[SourceMember(nameof(Floor_cu.Location_CU_ID))]
		[MapTo("Location_CU_ID")]
		public string LocationID { get; set; }
		public object LocationName_P { get; set; }
		public object LocationName_S { get; set; }

		[SourceMember(nameof(Floor_cu.InternalCode))]
		[MapTo("InternalCode")]
		public string FloorInternalCode { get; set; }

		[SourceMember(nameof(Floor_cu.Description))]
		[MapTo("Description")]
		public string Description { get; set; }
	}
}