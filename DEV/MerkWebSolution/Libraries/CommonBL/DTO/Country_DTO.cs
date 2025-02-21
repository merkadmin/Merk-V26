using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(Country_cu))]
	public class Country_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(Country_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(Country_cu.Name_P))]
		[MapTo("CountryName_P")]
		public string CountryName_P { get; set; }

		[SourceMember(nameof(Country_cu.Name_S))]
		[MapTo("CountryName_S")]
		public string CountryName_S { get; set; }


		[SourceMember(nameof(Location_cu.Description))]
		[MapTo("Description")]
		public string Description { get; set; }
	}
}
