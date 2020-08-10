using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirRoutesRepository : IAirRoutesRepository
	{
		public AirRoutes CreateAirRoute(AirRoutes airRoutes)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirRoutes.Add(airRoutes);
				db.SaveChanges();
				return airRoutes;
			}
		}

		public List<AirRoutes> GetAllAirRoute()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirRoutes.ToList();
			}
		}

		public AirRoutes GetByAirRouteId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirRoutes.Find(id);
			}
		}

		public void RemoveAirRoute(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirRoute = GetByAirRouteId(id);
				db.AirRoutes.Remove(removeAirRoute);
				db.SaveChanges();
			}
		}

		public AirRoutes UpdateAirRoute(AirRoutes airRoutes)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirRoutes.Update(airRoutes);
				return airRoutes;
			}
		}
	}
}
