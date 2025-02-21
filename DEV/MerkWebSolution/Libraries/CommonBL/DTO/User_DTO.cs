using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(User_cu))]
	public class User_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		public long Person_CU_ID { get; set; }
		public string LoginName { get; set; }
		public string Password { get; set; }
		public int OragnizationID { get; set; }
		public string InternalCode { get; set; }
		public string Description { get; set; }
	}
}
