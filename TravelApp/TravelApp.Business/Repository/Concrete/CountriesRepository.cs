using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class CountriesRepository : ICountriesRepository
	{
		public Countries CreateCountries(Countries countries)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Countries.Add(countries);
				db.SaveChanges();
				return countries;
			}
		}

		public List<Countries> GetAllCountries()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Countries.ToList();
			}
		}

		public Countries GetByCountriesId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Countries.Find(id);
			}
		}

		public void RemoveCountries(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeCountries = GetByCountriesId(id);
				db.Countries.Remove(removeCountries);
				db.SaveChanges();
			}
		}

		public Countries UpdateCountries(Countries countries)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Countries.Update(countries);
				return countries;
			}
		}
	}
}
