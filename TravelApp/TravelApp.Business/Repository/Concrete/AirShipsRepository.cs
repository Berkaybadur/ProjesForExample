using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirShipsRepository : IAirShipsRepository
	{
		public AirShips CreateAirShips(AirShips airShips)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShips.Add(airShips);
				db.SaveChanges();
				return airShips;
			}
		}

		public List<AirShips> GetAllAirShips()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShips.ToList();
			}
		}

		public AirShips GetByAirShipsId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShips.Find(id);
			}
		}

		public void RemoveAirShips(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirShips = GetByAirShipsId(id);
				db.AirShips.Remove(removeAirShips);
				db.SaveChanges();
			}
		}

		public AirShips UpdateAirShips(AirShips airShips)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShips.Update(airShips);
				return airShips;
			}
		}
	}
}
