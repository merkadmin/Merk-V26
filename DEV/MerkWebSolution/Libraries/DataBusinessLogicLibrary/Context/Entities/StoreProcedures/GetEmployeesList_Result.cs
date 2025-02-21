using DataBusinessLogicLibrary.Context.Common;
using System;

namespace DataBusinessLogicLibrary.Context
{
	public partial class GetEmployeesList_Result : IDBCommon
	{
		public long EntityID { get; }
		public DB_CommonTransactionType DBCommonTransactionType { get; set; }
		long IDBCommon.InsertedBy { get; set; }
		DateTime IDBCommon.InsertedDate { get; set; }
	}
}
