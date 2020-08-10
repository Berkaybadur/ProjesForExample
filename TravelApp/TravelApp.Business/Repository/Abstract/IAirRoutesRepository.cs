using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirRoutesRepository
	{
		List<AirRoutes> GetAllAirRoute();
		AirRoutes GetByAirRouteId(int id);
		AirRoutes CreateAirRoute(AirRoutes airRoutes);
		AirRoutes UpdateAirRoute(AirRoutes airRoutes);
		void RemoveAirRoute(int id);
	}
}
