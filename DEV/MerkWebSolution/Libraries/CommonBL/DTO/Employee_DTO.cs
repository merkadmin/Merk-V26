using System;
using AutoMapper;
using AutoMapper.Configuration.Annotations;
using AutoMapper.Configuration.Conventions;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL.DTO
{
	[AutoMap(typeof(GetEmployeesList_Result))]
	public class Employee_DTO : IDTO
	{
		[SourceMember(nameof(GetEmployeesList_Result.EmployeeID))]
		[MapTo("EmployeeID")]
		public long ID { get; set; }

		public bool IsOnDuty { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.InsertedBy))]
		[MapTo("InsertedBy")]
		public long UserID { get; set; }

		public long RowCount { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.InsertedDate))]
		[MapTo("InsertedDate")]
		public DateTime InsertedDate { get; set; }

		public DB_CommonTransactionType DB_CommonTransactionType { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.EmployeeFullName))]
		[MapTo("EmployeeFullName")]
		public string EmployeeFullName { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.InternalCode))]
		[MapTo("InternalCode")]
		public string InternalCode { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.EmployeeTypeID))]
		[MapTo("EmployeeTypeID")]
		public string EmployeeTypeID { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.EmployeeTypeName))]
		[MapTo("EmployeeTypeName")]
		public string EmployeeTypeName { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.AbbreviationName))]
		[MapTo("AbbreviationName")]
		public string AbbreviationName { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.MilitaryStatusID))]
		[MapTo("MilitaryStatusID")]
		public string MilitaryStatusID { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.Email))]
		[MapTo("Email")]
		public string Email { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.EmploymentDate))]
		[MapTo("EmploymentDate")]
		public string EmploymentDate { get; set; }

		[SourceMember(nameof(GetEmployeesList_Result.RetirementDate))]
		[MapTo("RetirementDate")]
		public string RetirementDate { get; set; }
	}
}
