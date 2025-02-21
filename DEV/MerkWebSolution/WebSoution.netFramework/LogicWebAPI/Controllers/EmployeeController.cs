using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using CommonBL;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class EmployeeController : BaseApiController<GetEmployeesList_Result, Employee_DTO>
	{
		[ActionName("getAllItems")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetAllItems()
		{
			List<GetEmployeesList_Result> list = new List<GetEmployeesList_Result>();
			using (MerkFinanceEntities context = new MerkFinanceEntities())
				list = context.GetEmployeesList(true, null, null).ToList();

			List<Employee_DTO> dtoList = MappingLogic<GetEmployeesList_Result, Employee_DTO>.Map_Entity_To_DTO(list);

			return Ok(dtoList);
		}
	}
}