using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface ICountriesRepository
	{
		List<Countries> GetAllCountries();
		Countries GetByCountriesId(int id);
		Countries CreateCountries(Countries countries);
		Countries UpdateCountries(Countries countries);
		void RemoveCountries(int id);
	}
}
