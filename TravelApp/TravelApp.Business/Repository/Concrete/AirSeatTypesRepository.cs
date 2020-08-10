using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirSeatTypesRepository : IAirSeatTypeRepository
	{
		public AirSeatType CreateAirSeatTypes(AirSeatType airSeatType)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirSeatType.Add(airSeatType);
				db.SaveChanges();
				return airSeatType;
			}
		}

		public List<AirSeatType> GetAirSeatTypes()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirSeatType.ToList();
			}
		}

		public AirSeatType GetByAirSeatTypesId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirSeatType.Find(id);
			}
		}

		public void RemoveAirSeatTypes(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirSeatTypes = GetByAirSeatTypesId(id);
				db.AirSeatType.Remove(removeAirSeatTypes);
				db.SaveChanges();
			}
		}

		public AirSeatType UpdateAirSeatTypes(AirSeatType airSeatType)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirSeatType.Update(airSeatType);
				return airSeatType;
			}
		}
	}
}
