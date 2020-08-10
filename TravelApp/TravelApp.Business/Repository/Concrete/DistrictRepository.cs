using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class DistrictRepository : IDistrictRepository
	{
		public District CreateDistrict(District district)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.District.Add(district);
				db.SaveChanges();
				return district;
			}
		}

		public List<District> GetAllDistrict()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.District.ToList();
			}
		}

		public District GetByDistrictId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.District.Find(id);
			}
		}

		public void RemoveDistrict(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeDistrict = GetByDistrictId(id);
				db.Remove(removeDistrict);
				db.SaveChanges();
			}
		}

		public District UpdateDistrict(District district)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.District.Update(district);
				return district;
			}
		}
	}
}
