using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;
using CommonBL;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace LogicWebAPI.Controllers
{
	[EnableCors(origins: "*", headers: "*", methods: "*")]
	public class LocationController : BaseApiController<Location_cu, Location_DTO>
	{
		[ActionName("getItemsByRange")]
		[HttpGet]
		public override async Task<IHttpActionResult> GetItemsByRange(int pageIndex)
		{
			IHttpActionResult response = base.GetItemsByRange(pageIndex).Result;

			if (response == null)
				return Ok(response);

			List<Location_DTO> contentList = DB_BL.SetLocationDetails(response);

			return Ok(contentList);
		}

		[ActionName("getCountriesList")]
		[HttpGet]
		public IHttpActionResult GetCountriesList()
		{
			List<Country_cu> list = DBCommon.GetItemsList<Country_cu>().ToList();
			List<Country_DTO> repsonseList = new List<Country_DTO>();
			if (list.Count > 0)
				repsonseList = MappingLogic<Country_cu, Country_DTO>.Map_Entity_To_DTO(list);
			return Ok(repsonseList);
		}

		[ActionName("getCitiesList")]
		[HttpGet]
		public IHttpActionResult GetCitiesList()
		{
			List<City_cu> list = DBCommon.GetItemsList<City_cu>().ToList();
			List<City_DTO> repsonseList = new List<City_DTO>();
			if (list.Count > 0)
				repsonseList = MappingLogic<City_cu, City_DTO>.Map_Entity_To_DTO(list);
			return Ok(repsonseList);
		}

		[ActionName("getRegionsList")]
		[HttpGet]
		public IHttpActionResult GetRegionsList()
		{
			List<Region_cu> list = DBCommon.GetItemsList<Region_cu>().ToList();
			List<Region_DTO> repsonseList = new List<Region_DTO>();
			if (list.Count > 0)
				repsonseList = MappingLogic<Region_cu, Region_DTO>.Map_Entity_To_DTO(list);
			return Ok(repsonseList);
		}
	}
}