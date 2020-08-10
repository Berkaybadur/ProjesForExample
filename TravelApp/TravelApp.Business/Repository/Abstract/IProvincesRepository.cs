using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IProvincesRepository
	{
		List<Provinces> GetAllProvinces();
		Provinces GetByProvincesId(int id);
		Provinces CreateProvinces(Provinces provinces);
		Provinces UpdateProvinces(Provinces provinces);
		void RemoveProvinces(int id);
	}
}
