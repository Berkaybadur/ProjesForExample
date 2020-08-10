using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class AirShipTicketsManager : IAirShipTicketsService
	{
		private IAirShipTicketsDal _airShipTicketsDal;
		public AirShipTicketsManager(IAirShipTicketsDal airShipTicketsDal)
		{
			_airShipTicketsDal = airShipTicketsDal;
		}
		public void CreateAirShipTickets(AirShipTickets airShipTickets)
		{
			_airShipTicketsDal.Add(airShipTickets);
		}

		public List<AirShipTickets> GetAllAirShipTickets()
		{
			return _airShipTicketsDal.GetList();
		}

		public AirShipTickets GetByAirShipTicketsId(int id)
		{
			return _airShipTicketsDal.Get(a=>a.TicketId==id);
		}

		public void RemoveAirShipTickets(AirShipTickets airShipTickets)
		{
			_airShipTicketsDal.Delete(airShipTickets);
		}

		public void UpdateAirShipTickets(AirShipTickets airShipTickets)
		{
			_airShipTicketsDal.Update(airShipTickets);
		}
	}
}
