using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface IAirShipTicketsRepository
	{
		List<AirShipTickets> GetAllAirShipTickets();
		AirShipTickets GetByAirShipTicketsId(int id);
		AirShipTickets CreateAirShipTickets(AirShipTickets airShipTickets);
		AirShipTickets UpdateAirShipTickets(AirShipTickets airShipTickets);
		void RemoveAirShipTickets(int id);
	}
}
