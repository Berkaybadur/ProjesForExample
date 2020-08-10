using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirShipsService
	{
		List<AirShips> GetAllAirShips();
		AirShips GetByAirShipsId(int id);
		void CreateAirShips(AirShips airShips);
		void UpdateAirShips(AirShips airShips);
		void RemoveAirShips(AirShips airShips);
		List<AirShips> GetAirShips();
	}
}
