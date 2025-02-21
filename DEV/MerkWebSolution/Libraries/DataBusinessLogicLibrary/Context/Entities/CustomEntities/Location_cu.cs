using System;
using DataBusinessLogicLibrary.Context.Common;

namespace DataBusinessLogicLibrary.Context
{
	public partial class Location_cu : IDBCommon
	{
		public long EntityID => ID;
		public DB_CommonTransactionType DBCommonTransactionType { get; set; }
		long IDBCommon.InsertedBy { get; set; }
		DateTime IDBCommon.InsertedDate { get; set; }
	}
}