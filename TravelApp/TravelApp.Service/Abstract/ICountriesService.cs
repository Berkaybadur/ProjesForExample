using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface ICountriesService
	{
		List<Countries> GetAllCountries();
		Countries GetByCountriesId(int id);
		void CreateCountries(Countries countries);
		void UpdateCountries(Countries countries);
		void RemoveCountries(Countries countries);
	}
}
