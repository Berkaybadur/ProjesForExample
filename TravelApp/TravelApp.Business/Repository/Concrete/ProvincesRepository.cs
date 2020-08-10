using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class ProvincesRepository : IProvincesRepository
	{
		public Provinces CreateProvinces(Provinces provinces)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Provinces.Add(provinces);
				db.SaveChanges();
				return provinces;
			}
		}

		public List<Provinces> GetAllProvinces()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Provinces.ToList();
			}
		}

		public Provinces GetByProvincesId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Provinces.Find(id);
			}
		}

		public void RemoveProvinces(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeProvinces = GetByProvincesId(id);
				db.Provinces.Remove(removeProvinces);
				db.SaveChanges();
			}
		}

		public Provinces UpdateProvinces(Provinces provinces)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Provinces.Update(provinces);
				return provinces;
			}
		}
	}
}
