using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirSeatTypeRepository
	{
		List<AirSeatType> GetAirSeatTypes();
		AirSeatType GetByAirSeatTypesId(int id);
		AirSeatType CreateAirSeatTypes(AirSeatType airSeatType);
		AirSeatType UpdateAirSeatTypes(AirSeatType airSeatType);
		void RemoveAirSeatTypes(int id);
	}
}
