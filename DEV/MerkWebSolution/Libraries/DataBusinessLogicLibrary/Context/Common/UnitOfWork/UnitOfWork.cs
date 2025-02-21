using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using DataBusinessLogicLibrary.Context.Common.Repositories;

namespace DataBusinessLogicLibrary.Context.Common.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly MerkFinanceEntities _dbContext;
		public UnitOfWork(MerkFinanceEntities conetxt)
		{
			_dbContext = conetxt;
		}
		public int SaveChanges()
		{
			try
			{
				int num = _dbContext.SaveChanges();

				return num;
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}
		public int UpdateChanges<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				TEntity existingEntity = GetEntity<TEntity>(entity.EntityID);
				_dbContext.Entry(existingEntity).CurrentValues.SetValues(entity);
				return SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}
		public TEntity CreateDBEntity<TEntity>() 
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).CreateDBEntity();
		}
		public int RemoveEntity<TEntity>(TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			try
			{
				//TODO :: Check from System Configuration if the owner wants to delete forever or just mark it as IsOnDuty = false
				Repository<TEntity> repository = new Repository<TEntity>(_dbContext);
				TEntity updatedEntity = GetEntity<TEntity>(entity.EntityID);
				repository.RemoveEntity(updatedEntity);
				return SaveChanges();

				//This is to Update After Making IsOnDuty = false;
				//return UpdateChanges<TEntity>(entity);
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}
		public int UpdateChanges<TEntity>(IDBCommon activeDbItem) where TEntity : class, new()
		{
			try
			{
				TEntity updatedEntity = GetEntity<TEntity>(activeDbItem.EntityID);
				_dbContext.Entry(updatedEntity).CurrentValues.SetValues(activeDbItem);
				return SaveChanges();
			}
			catch (DbEntityValidationException e)
			{
				foreach (var eve in e.EntityValidationErrors)
				{
					Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
						eve.Entry.Entity.GetType().Name, eve.Entry.State);
					foreach (var ve in eve.ValidationErrors)
					{
						Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
							ve.PropertyName, ve.ErrorMessage);
					}
				}
				throw;
			}
		}
		public Repository<TEntity> GetList<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext);
		}
		public IEnumerable<TEntity> GetAllEntities<TEntity>()
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetAllEntities();
		}
		public IEnumerable<TEntity> GetAllEntities<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntities(predicate);
		}
		public long GetEntitiesCount<TEntity>(Expression<Func<TEntity, bool>> predicatE)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntitiesCount<TEntity>(predicatE);
		}
		public TEntity GetEntity<TEntity>(int id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(id);
		}
		public TEntity GetEntity<TEntity>(Expression<Func<TEntity, bool>> predicate)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(predicate);
		}
		public TEntity GetEntity<TEntity>(long id)
			where TEntity : class, new()
		{
			return new Repository<TEntity>(_dbContext).GetEntity(id);
		}
		public void Dispose()
		{
			
		}
	}
}
