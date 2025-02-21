using System.Web.Http.Cors;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class CityController : BaseApiController<City_cu, City_DTO>
	{
	}
}