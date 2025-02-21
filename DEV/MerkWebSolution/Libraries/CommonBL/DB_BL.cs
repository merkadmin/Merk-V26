using System;
using System.Collections.Generic;
using System.Web.Http;
using CommonBL.DTO;
using DataBusinessLogicLibrary.Context;
using DataBusinessLogicLibrary.Context.Common;

namespace CommonBL
{
	public class DB_BL
	{
		public static string GetEmployeeFullName(long employeeID)
		{
			string fullName = "";

			Person_cu personEmployee = DBCommon.GetItemByID<Person_cu>(employeeID);
			if (personEmployee == null)
				return fullName;

			fullName = personEmployee.FirstName_P + ' ' + personEmployee.SecondName_P + ' ' +
					   personEmployee.ThirdName_P + ' ' + personEmployee.FourthName_P;
			personEmployee.Employee_cu.EmployeeFullName = fullName;

			return fullName;
		}

		public static void SetEmployeeName(InventoryStoreCategory_DTO invDto)
		{
			if (invDto == null || invDto.InChargeID == null)
				return;

			Person_cu employee = DBCommon.GetItemByID<Person_cu>(Convert.ToInt64(invDto.InChargeID));
			if (employee != null)
				invDto.InChargeName_P = employee.FirstName_P + ' ' + employee.SecondName_P + ' ' +
										employee.ThirdName_P;
		}

		public static List<InventoryStoreCategory_DTO> SetEmployeesName(List<InventoryStoreCategory_DTO> dtoList)
		{
			if (dtoList == null || dtoList.Count == 0)
				return null;

			List<InventoryStoreCategory_DTO> list = new List<InventoryStoreCategory_DTO>();
			foreach (InventoryStoreCategory_DTO dtoItem in dtoList)
			{
				if (dtoItem.InChargeID != null)
				{
					Person_cu employee = DBCommon.GetItemByID<Person_cu>(Convert.ToInt64(dtoItem.InChargeID));
					if (employee != null)
					{
						dtoItem.InChargeName_P = employee.FirstName_P + ' ' + employee.SecondName_P + ' ' +
												 employee.ThirdName_P;
						list.Add(dtoItem);
					}
				}
				else
					list.Add(dtoItem);
			}

			return list;
		}

		public static List<InventoryStoreCategory_DTO> SetEmployeesName(IHttpActionResult response)
		{
			if (response == null)
				return null;

			List<InventoryStoreCategory_DTO> dtoList =
				SetEmployeesName(ControllerBL.GetContentList<InventoryStoreCategory_DTO>(response));

			return dtoList;
		}

		public static List<Location_DTO> SetLocationDetails(IHttpActionResult response)
		{
			if (response == null)
				return null;

			List<Location_DTO> list = ControllerBL.GetContentList<Location_DTO>(response);
			if (list == null || list.Count == 0)
				return list;

			foreach (Location_DTO locationDto in list)
			{
				Country_cu country = null;
				City_cu City = null;
				Region_cu region = null;

				if (locationDto.CountryID != null)
					country = DBCommon.GetItemByID<Country_cu>(Convert.ToInt64(locationDto.CountryID));

				if (locationDto.CountryID != null)
					City = DBCommon.GetItemByID<City_cu>(Convert.ToInt64(locationDto.CityID));

				if (locationDto.CountryID != null)
					region = DBCommon.GetItemByID<Region_cu>(Convert.ToInt64(locationDto.CountryID));

				if (country != null)
				{
					locationDto.CountryName_P = country.Name_P;
					locationDto.CountryName_S = country.Name_S;
				}

				if (City != null)
				{
					locationDto.CityName_P = City.Name_P;
					locationDto.CityName_S = City.Name_S;
				}

				if (region != null)
				{
					locationDto.RegionName_P = region.Name_P;
					locationDto.RegionName_S = region.Name_S;
				}
			}

			return list;
		}

		public static List<Floor_DTO> SetFloorDetails(IHttpActionResult response)
		{
			if (response == null)
				return null;

			List<Floor_DTO> list = ControllerBL.GetContentList<Floor_DTO>(response);
			if (list == null || list.Count == 0)
				return list;

			foreach (Floor_DTO floor in list)
			{
				Location_cu location = null;
				if (floor.LocationID != null)
					location = DBCommon.GetItemByID<Location_cu>(Convert.ToInt64(floor.LocationID));

				if (location != null)
				{
					floor.LocationName_P = location.Name_P;
					floor.LocationName_S = location.Name_S;
				}
			}

			return list;
		}

		public static List<Department_DTO> SetDepartmentDetails(IHttpActionResult response)
		{
			if (response == null)
				return null;

			List<Department_DTO> list = ControllerBL.GetContentList<Department_DTO>(response);
			if (list == null || list.Count == 0)
				return list;

			foreach (Department_DTO department in list)
			{
				DepartmentType_p entity = null;
				if (department.DepartmentTypeID != null)
					entity = DBCommon.GetItemByID<DepartmentType_p>(Convert.ToInt64(department.DepartmentTypeID));

				if (entity != null)
				{
					department.DepartmentTypeName_P = entity.Name_P;
					department.DepartmentTypeName_S = entity.Name_S;

				}
			}

			return list;
		}
	}
}
