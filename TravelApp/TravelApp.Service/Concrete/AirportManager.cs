using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirportManager : IAirportService
	{
		private IAirportsDal _airportsDal;
		public AirportManager(IAirportsDal airportsDal)
		{
			_airportsDal = airportsDal;
		}
		public void CreateAirport(Airports airport)
		{
			_airportsDal.Add(airport);
		}

		public List<Airports> GetAllAirport()
		{
			return _airportsDal.GetList();
		}

		public List<Airports> GetAllInclude()
		{
			return _airportsDal.GetInclude(x => x.Disc);
		}

		public Airports GetByAirportId(int id)
		{
			return _airportsDal.Get(a => a.AirportId == id);
		}

		public void RemoveAirport(Airports airports)
		{
			_airportsDal.Delete(airports);
		}

		public void UpdateAirport(Airports airport)
		{
			_airportsDal.Update(airport);
		}
	}
}
