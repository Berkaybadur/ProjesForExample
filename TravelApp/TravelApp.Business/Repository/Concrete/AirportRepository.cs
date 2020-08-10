using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class AirportRepository : IAirportRepository
	{
		public Airports CreateAirport(Airports airport)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Airports.Add(airport);
				db.SaveChanges();
				return airport;
			}
		}

		public List<Airports> GetAllAirport()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Airports.ToList();
			}
		}

		public List<Airports> GetAllInclude()
		{
			throw new NotImplementedException();
		}

		public Airports GetByAirportId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Airports.Find(id);
			}
		}

		public void RemoveAirport(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeAirport = GetByAirportId(id);
				db.Airports.Remove(removeAirport);
				db.SaveChanges();

			}
		}

		public Airports UpdateAirport(Airports airport)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Airports.Update(airport);
				return airport;
			}
		}
	}
}
