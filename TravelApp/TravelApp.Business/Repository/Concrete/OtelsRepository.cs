using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class OtelsRepository : IOtelsRepository
	{
		public Otels CreateOtels(Otels otels)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Otels.Add(otels);
				db.SaveChanges();
				return otels;
			}
		}

		public List<Otels> GetAllOtels()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Otels.ToList();
			}
		}

		public Otels GetByOtelsId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Otels.Find(id);
			}
		}

		public void RemoveOtels(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeOtels = GetByOtelsId(id);
				db.Otels.Remove(removeOtels);
				db.SaveChanges();
			}
		}

		public Otels UpdateOtels(Otels otels)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Otels.Update(otels);
				return otels;
			}
		}
	}
}
