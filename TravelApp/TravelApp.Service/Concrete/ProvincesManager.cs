using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class ProvincesManager : IProvincesService
	{
		private IProvincesDal _provincesDal;
		public ProvincesManager(IProvincesDal provincesDal)
		{
			_provincesDal = provincesDal;
		}
		public void CreateProvinces(Provinces provinces)
		{
			_provincesDal.Add(provinces);
		}

		public List<Provinces> GetAllProvinces()
		{
			return _provincesDal.GetList();
		}

		public Provinces GetByProvincesId(int id)
		{
			return _provincesDal.Get(a=>a.ProvinceId==id);
		}

		public void RemoveProvinces(Provinces provinces)
		{
			_provincesDal.Delete(provinces);
		}

		public void UpdateProvinces(Provinces provinces)
		{
			_provincesDal.Update(provinces);
		}
	}
}
