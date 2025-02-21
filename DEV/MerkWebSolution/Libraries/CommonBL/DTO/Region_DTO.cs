using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(Region_cu))]
	public class Region_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(Region_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(Region_cu.Name_P))]
		[MapTo("RegionName_P")]
		public string RegionName_P { get; set; }

		[SourceMember(nameof(Region_cu.Name_S))]
		[MapTo("RegionName_S")]
		public string RegionName_S { get; set; }

		[SourceMember(nameof(Region_cu.CIty_CU_ID))]
		[MapTo("CityID")]
		public string CityID { get; set; }
	}
}
