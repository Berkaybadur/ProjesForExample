using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirSeatTypeService
	{
		List<AirSeatType> GetAirSeatTypes();
		AirSeatType GetByAirSeatTypesId(int id);
		void CreateAirSeatTypes(AirSeatType airSeatType);
		void UpdateAirSeatTypes(AirSeatType airSeatType);
		void RemoveAirSeatTypes(AirSeatType airSeatType);
	}
}
