using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirShipsManager : IAirShipsService
	{
		private IAirShipsDal _airShipsDal;
		public AirShipsManager(IAirShipsDal airShipsDal)
		{
			_airShipsDal = airShipsDal;
		}
		public void CreateAirShips(AirShips airShips)
		{
			_airShipsDal.Add(airShips);
		}

		public List<AirShips> GetAirShips()
		{
			throw new NotImplementedException();
		}

		public List<AirShips> GetAllAirShips()
		{
			return _airShipsDal.GetList();
		}

		public List<AirShips> GetAllInclude()
		{
			return _airShipsDal.GetInclude(x => x.RouteTo);
		}

		public AirShips GetByAirShipsId(int id)
		{
			return _airShipsDal.Get(a => a.AirShipsId == id);
		}

		public void RemoveAirShips(AirShips airShips)
		{
			_airShipsDal.Delete(airShips);
		}

		public void UpdateAirShips(AirShips airShips)
		{
			_airShipsDal.Update(airShips);
		}
	}
}
