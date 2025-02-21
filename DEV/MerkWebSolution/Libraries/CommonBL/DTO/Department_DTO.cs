using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(Department_cu))]
	public class Department_DTO : IDTO
	{
		public long ID { get; set; }
		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(Department_cu.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }
		public long RowCount { get; set; }
		public DateTime InsertedDate { get; set; }
		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(Department_cu.Name_P))]
		[MapTo("Name_P")]
		public string DepartmentName_P { get; set; }

		[SourceMember(nameof(Department_cu.Name_S))]
		[MapTo("Name_S")]
		public string DepartmentName_S { get; set; }

		[SourceMember(nameof(Department_cu.Department_P_ID))]
		[MapTo("Department_P_ID")]
		public string DepartmentTypeID { get; set; }
		public object DepartmentTypeName_P { get; set; }
		public object DepartmentTypeName_S { get; set; }

		[SourceMember(nameof(Department_cu.InternalCode))]
		[MapTo("InternalCode")]
		public string DepartmentInternalCode { get; set; }

		[SourceMember(nameof(Department_cu.Description))]
		[MapTo("Description")]
		public string Description { get; set; }
	}
}