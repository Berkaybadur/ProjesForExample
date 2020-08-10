using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class CountriesManager : ICountriesService
	{
		private ICountriesDal _countriesDal;
		public CountriesManager(ICountriesDal countriesDal)
		{
			_countriesDal = countriesDal;
		}
		public void CreateCountries(Countries countries)
		{
			_countriesDal.Add(countries);
		}

		public List<Countries> GetAllCountries()
		{
			return _countriesDal.GetList();
		}

		public Countries GetByCountriesId(int id)
		{
			return _countriesDal.Get(a=>a.CountryId==id);
		}

		public void RemoveCountries(Countries countries)
		{
			_countriesDal.Delete(countries);
		}

		public void UpdateCountries(Countries countries)
		{
			_countriesDal.Update(countries);
		}
	}
}
