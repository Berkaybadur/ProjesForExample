using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirShipsRepository
	{
		List<AirShips> GetAllAirShips();
		AirShips GetByAirShipsId(int id);
		AirShips CreateAirShips(AirShips airShips);
		AirShips UpdateAirShips(AirShips airShips);
		void RemoveAirShips(int id);
	}
}
