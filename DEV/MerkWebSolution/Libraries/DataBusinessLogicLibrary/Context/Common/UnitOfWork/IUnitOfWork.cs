using System;

namespace DataBusinessLogicLibrary.Context.Common.UnitOfWork
{
	public interface IUnitOfWork : IDisposable
	{
		int SaveChanges();
	}
}
