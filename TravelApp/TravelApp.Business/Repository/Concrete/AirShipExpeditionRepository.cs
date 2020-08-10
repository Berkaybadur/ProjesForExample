using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirShipExpeditionRepository : IAirShipExpeditionRepository
	{
		public AirShipExpedition CreateAirShipExpedition(AirShipExpedition airShipExpedition)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShipExpedition.Add(airShipExpedition);
				db.SaveChanges();
				return airShipExpedition;
			}
		}

		public List<AirShipExpedition> GetAllAirShipExpedition()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShipExpedition.ToList();
			}
		}

		public AirShipExpedition GetByAirShipExpeditionId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShipExpedition.Find(id);
			}
		}

		public void RemoveAirShipExpedition(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirShipExpedition = GetByAirShipExpeditionId(id);
				db.Remove(removeAirShipExpedition);
				db.SaveChanges();
			}
		}

		public AirShipExpedition UpdateAirShipExpedition(AirShipExpedition airShipExpedition)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShipExpedition.Update(airShipExpedition);
				return airShipExpedition;
			}
		}
	}
}
