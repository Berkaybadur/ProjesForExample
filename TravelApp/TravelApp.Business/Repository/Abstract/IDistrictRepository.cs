using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IDistrictRepository
	{
		List<District> GetAllDistrict();
		District GetByDistrictId(int id);
		District CreateDistrict(District district);
		District UpdateDistrict(District district);
		void RemoveDistrict(int id);
	}
}
