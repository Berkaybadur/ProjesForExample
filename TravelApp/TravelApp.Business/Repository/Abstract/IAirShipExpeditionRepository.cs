using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirShipExpeditionRepository
	{
		List<AirShipExpedition> GetAllAirShipExpedition();
		AirShipExpedition GetByAirShipExpeditionId(int id);
		AirShipExpedition CreateAirShipExpedition(AirShipExpedition airShipExpedition);
		AirShipExpedition UpdateAirShipExpedition(AirShipExpedition airShipExpedition);
		void RemoveAirShipExpedition(int id);
	}
}
