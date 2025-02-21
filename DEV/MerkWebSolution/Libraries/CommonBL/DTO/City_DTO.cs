using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(City_cu))]
	public class City_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(City_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(City_cu.Name_P))]
		[MapTo("CityName_P")]
		public string CityName_P { get; set; }

		[SourceMember(nameof(City_cu.Name_S))]
		[MapTo("CityName_S")]
		public string CityName_S{ get; set; }

		[SourceMember(nameof(City_cu.Country_CU_ID))]
		[MapTo("CoutnryID")]
		public string CoutnryID { get; set; }
	}
}
