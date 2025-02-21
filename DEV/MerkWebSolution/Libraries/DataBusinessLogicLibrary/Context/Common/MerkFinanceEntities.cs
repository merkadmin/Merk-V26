namespace DataBusinessLogicLibrary.Context
{
	public partial class MerkFinanceEntities
	{
		public MerkFinanceEntities(string connectionString)
		{
			this.Database.Connection.ConnectionString = connectionString;
		}
	}
}
