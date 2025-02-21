﻿using System;
using System.Data.Entity;

namespace DataBusinessLogicLibrary.Context.Common
{
	public static class DBCommonExtension
	{
		public static bool SaveChanges<TEntity>(this TEntity entity)
			where TEntity : class, IDBCommon, new()
		{
			int count = 0;
			if (entity != null)
				using (UnitOfWork.UnitOfWork unitOfWork = new UnitOfWork.UnitOfWork(DBCommon.DBContext_External))
				{
					entity.InsertedDate = DateTime.Now;
					//entity.IsOnDuty = entity.IsOnDuty;

					if (entity.DBCommonTransactionType == DB_CommonTransactionType.CreateNew
						|| entity.DBCommonTransactionType == DB_CommonTransactionType.SaveNew)
					{
						unitOfWork.GetList<TEntity>().AddEntity(entity);
						count = unitOfWork.SaveChanges();
					}
					else if (entity.DBCommonTransactionType == DB_CommonTransactionType.UpdateExisting)
						count = unitOfWork.UpdateChanges(entity);
					else if (entity.DBCommonTransactionType == DB_CommonTransactionType.DeleteExisting)
						count = unitOfWork.RemoveEntity(entity);
				}

			return count > 0;
		}
	}
}
