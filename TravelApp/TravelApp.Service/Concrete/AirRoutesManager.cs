using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirRoutesManager : IAirRoutesService
	{
		private IAirRoutesDal _airRoutesDal;
		public AirRoutesManager(IAirRoutesDal airRoutesDal)
		{
			_airRoutesDal = airRoutesDal;
		}
		public void CreateAirRoutes(AirRoutes airRoutes)
		{
			_airRoutesDal.Add(airRoutes);
		}

		public List<AirRoutes> GetAllAirRoutes()
		{
			return _airRoutesDal.GetList();
		}

		public List<AirRoutes> GetAllInclude()
		{
			return _airRoutesDal.GetIncludee(x => x.RoutesFrom, x => x.RoutesTo);
		}

		public AirRoutes GetByAirRoutesId(int id)
		{
			return _airRoutesDal.Get(a => a.RoutesId == id);
		}

		public void RemoveAirRoutes(AirRoutes airRoutes)
		{
			_airRoutesDal.Delete(airRoutes);
		}

		public void UpdateAirRoutes(AirRoutes airRoutes)
		{
			_airRoutesDal.Update(airRoutes);
		}
	}
}
