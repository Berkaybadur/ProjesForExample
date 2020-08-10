using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface IAirShipTicketsService
	{
		List<AirShipTickets> GetAllAirShipTickets();
		AirShipTickets GetByAirShipTicketsId(int id);
		void CreateAirShipTickets(AirShipTickets airShipTickets);
		void UpdateAirShipTickets(AirShipTickets airShipTickets);
		void RemoveAirShipTickets(AirShipTickets airShipTickets);
	}
}
