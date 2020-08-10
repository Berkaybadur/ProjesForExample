using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IProvincesService
	{
		List<Provinces> GetAllProvinces();
		Provinces GetByProvincesId(int id);
		void CreateProvinces(Provinces provinces);
		void UpdateProvinces(Provinces provinces);
		void RemoveProvinces(Provinces provinces);
	}
}
