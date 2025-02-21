using System.Web.Http.Cors;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class RegionController : BaseApiController<Region_cu, Region_DTO>
	{
	}
}