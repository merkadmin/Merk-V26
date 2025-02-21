using DataBusinessLogicLibrary.Context.Common;

namespace DataBusinessLogicLibrary.Context
{
	public partial class InventoryStore_cu : DBCommon, IDBCommon
	{
		public long EntityID => ID;
	}
}
