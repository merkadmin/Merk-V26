using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using CommonBL;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class FloorController : BaseApiController<Floor_cu, Floor_DTO>
	{
		[ActionName("getItemsByRange")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetItemsByRange(int pageIndex)
		{
			IHttpActionResult response = base.GetItemsByRange(pageIndex).Result;

			if (response == null)
				return Ok(response);

			List<Floor_DTO> contentList = DB_BL.SetFloorDetails(response);

			return Ok(contentList);
		}
	}
}