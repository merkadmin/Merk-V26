using System;
using DataBusinessLogicLibrary.Context.Common;

namespace DataBusinessLogicLibrary.Context
{
	public partial class Employee_cu : IDBCommon
	{
		public long EntityID => Person_CU_ID;
		public bool IsOnDuty { get; set; }
		public DB_CommonTransactionType DBCommonTransactionType { get; set; }
		public long InsertedBy { get; set; }
		public DateTime InsertedDate { get; set; }
		public string EmployeeFullName { get; set; }
	}
}
