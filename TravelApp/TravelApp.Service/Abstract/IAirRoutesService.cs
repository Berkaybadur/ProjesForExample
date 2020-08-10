using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirRoutesService
	{
		List<AirRoutes> GetAllAirRoutes();
		AirRoutes GetByAirRoutesId(int id);
		void CreateAirRoutes(AirRoutes airRoutes);
		void UpdateAirRoutes(AirRoutes airRoutes);
		void RemoveAirRoutes(AirRoutes airRoutes);
		List<AirRoutes> GetAllInclude();
	}
}
