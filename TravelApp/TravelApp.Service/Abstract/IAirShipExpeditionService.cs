using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirShipExpeditionService
	{
		List<AirShipExpedition> GetAllAirShipExpedition();
		AirShipExpedition GetByAirShipExpeditionId(int id);
		void CreateAirShipExpedition(AirShipExpedition airShipExpedition);
		void UpdateAirShipExpedition(AirShipExpedition airShipExpedition);
		void RemoveAirShipExpedition(AirShipExpedition airShipExpedition);
	}
}
