using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class DistrictManager : IDistrictService
	{
		private IDistrictDal _districtDal;
		public DistrictManager(IDistrictDal districtDal)
		{
			_districtDal = districtDal;
		}
		public void CreateDistrict(District district)
		{
			_districtDal.Add(district);
		}

		public List<District> GetAllDistrict()
		{
			return _districtDal.GetList();
		}

		public District GetByDistrictId(int id)
		{
			return _districtDal.Get(a=>a.DistrictId==id);
		}

		public void RemoveDistrict(District district)
		{
			_districtDal.Delete(district);
		}

		public void UpdateDistrict(District district)
		{
			_districtDal.Update(district);
		}
	}
}
