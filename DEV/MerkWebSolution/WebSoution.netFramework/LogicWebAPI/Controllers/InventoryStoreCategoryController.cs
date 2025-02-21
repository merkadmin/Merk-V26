using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using CommonBL;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class InventoryStoreCategoryController : BaseApiController<InventoryStoreCategory_cu, InventoryStoreCategory_DTO>
	{
		[ActionName("getItemsByRange")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetItemsByRange(int pageIndex)
		{
			IHttpActionResult response = base.GetItemsByRange(pageIndex).Result;

			if (response == null)
				return Ok(response);

			List<InventoryStoreCategory_DTO> contentList = DB_BL.SetEmployeesName(response);

			return Ok(contentList);
		}

		[ActionName("getEmployees")]
		[HttpGet]
		public async Task<IHttpActionResult> GetEmployees()
		{
			EmployeeController employeeController = new EmployeeController();
			IHttpActionResult response = await employeeController.GetAllItems();

			return Ok(response);
		}
	}

	public class SP
	{
		public string CategoryID { get; set; }
		public string CategoryName_P { get; set; }
	}

	public class EntityDB
	{
		public string EntityDBID { get; set; }
		public string EntityDBValue { get; set; }
	}

	public interface IAdapter
	{
		void Adapt(string[,] adapterArray);
	}

	public class Adapter : IAdapter
	{
		public void Adapt(string[,] adapterArray)
		{
			string CategoryID = null;
			string CategoryName_P = null;
			string CategoryName_S = null;
			string CategoryInternalCode = null;
			string CategoryInsertedBy = null;
			string CategoryInsertedByName = null;
			string CategoryInsertedDate = null;

			List<InventoryStoreCategory_cu> list = new List<InventoryStoreCategory_cu>();
			for (int i = 0; i < adapterArray.GetLength(0); i++)
			{
				for (int j = 0; j < adapterArray.GetLength(1); j++)
				{

				}
			}
		}

		public static T[,] CreateRectangularArray<T>(IList<T[]> arrays)
		{
			// TODO: Validation and special-casing for arrays.Count == 0
			int minorLength = arrays[0].Length;
			T[,] ret = new T[arrays.Count, minorLength];
			for (int i = 0; i < arrays.Count; i++)
			{
				var array = arrays[i];
				if (array.Length != minorLength)
				{
					throw new ArgumentException
						("All arrays must be the same length");
				}
				for (int j = 0; j < minorLength; j++)
				{
					ret[i, j] = array[j];
				}
			}
			return ret;
		}
	}
}