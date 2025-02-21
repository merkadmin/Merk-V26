using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(Location_cu))]
	public class Location_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(Location_cu.InsertedBy))]
		[MapTo("UserID")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(Location_cu.Name_P))]
		[MapTo("Name_P")]
		public string LocationName_P { get; set; }

		[SourceMember(nameof(Location_cu.Name_S))]
		[MapTo("Name_S")]
		public string LocationName_S { get; set; }

		[SourceMember(nameof(Location_cu.Country_CU_ID))]
		[MapTo("Country_CU_ID")]
		public object CountryID { get; set; }

		public object CountryName_P { get; set; }
		public object CountryName_S { get; set; }

		[SourceMember(nameof(Location_cu.City_P_ID))]
		[MapTo("CityID")]
		public string CityID { get; set; }
		public object CityName_P { get; set; }
		public object CityName_S { get; set; }

		[SourceMember(nameof(Location_cu.Region_P_ID))]
		[MapTo("Region_P_ID")]
		public string RegionID { get; set; }
		public object RegionName_P { get; set; }
		public object RegionName_S { get; set; }

		[SourceMember(nameof(Location_cu.Address))]
		[MapTo("Address")]
		public string Address { get; set; }

		[SourceMember(nameof(Location_cu.InternalCode))]
		[MapTo("InternalCode")]
		public string LocationInternalCode { get; set; }

		[SourceMember(nameof(Location_cu.Description))]
		[MapTo("Description")]
		public string Description { get; set; }
	}
}
