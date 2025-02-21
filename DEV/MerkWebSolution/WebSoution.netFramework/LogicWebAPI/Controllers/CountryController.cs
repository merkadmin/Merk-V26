using System.Web.Http.Cors;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class CountryController : BaseApiController<Country_cu, Country_DTO>
	{
	}
}