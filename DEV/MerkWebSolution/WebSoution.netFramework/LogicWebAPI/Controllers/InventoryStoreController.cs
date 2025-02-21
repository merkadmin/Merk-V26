using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class InventoryStoreController : BaseApiController<InventoryStore_cu, InventoryStore_DTO>
	{

	}
}