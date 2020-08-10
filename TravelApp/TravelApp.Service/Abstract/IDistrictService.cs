using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IDistrictService
	{
		List<District> GetAllDistrict();
		District GetByDistrictId(int id);
		void CreateDistrict(District district);
		void UpdateDistrict(District district);
		void RemoveDistrict(District district);
	}
}
