using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirShipTicketsRepository : IAirShipTicketsRepository
	{
		public AirShipTickets CreateAirShipTickets(AirShipTickets airShipTickets)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShipTickets.Add(airShipTickets);
				db.SaveChanges();
				return airShipTickets;
			}
		}

		public List<AirShipTickets> GetAllAirShipTickets()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShipTickets.ToList();
			}
		}

		public AirShipTickets GetByAirShipTicketsId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.AirShipTickets.Find(id);
			}
		}

		public void RemoveAirShipTickets(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirShipTickets = GetByAirShipTicketsId(id);
				db.AirShipTickets.Remove(removeAirShipTickets);
				db.SaveChanges();
			}
		}

		public AirShipTickets UpdateAirShipTickets(AirShipTickets airShipTickets)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.AirShipTickets.Update(airShipTickets);
				return airShipTickets;
			}
		}
	}
}
