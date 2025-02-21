using DataBusinessLogicLibrary.Context.Common;
using System;

namespace DataBusinessLogicLibrary.Context
{
	public partial class PaginationConfiguration_cu : IDBCommon
	{
		public long EntityID => ID;
		public DB_CommonTransactionType DBCommonTransactionType { get; set; }
		long IDBCommon.InsertedBy { get; set; }
		DateTime IDBCommon.InsertedDate { get; set; }
	}
}
