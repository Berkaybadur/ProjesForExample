using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TravelApp.Data.Models;
using TravelApp.Service.Abstract;
using TravelApp.Service.Concrete;

namespace TravelApp.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AirShipTicketController : ControllerBase
	{
		private IAirShipTicketsService _airShipTicketsService;
		public AirShipTicketController(IAirShipTicketsService airShipTicketsService )
		{
			_airShipTicketsService = airShipTicketsService;
		}
		[HttpGet]
		public List<AirShipTickets> Get()
		{
			return _airShipTicketsService.GetAllAirShipTickets();
		}
		[HttpGet("{id}")]
		public AirShipTickets GetById(int id)
		{
			return _airShipTicketsService.GetByAirShipTicketsId(id);
		}
		[HttpPost]
		public void Post([FromBody]AirShipTickets airShipTickets)
		{
			_airShipTicketsService.CreateAirShipTickets(airShipTickets);
		}
		[HttpPut]
		public void Put([FromBody]AirShipTickets airShipTickets)
		{
			 _airShipTicketsService.UpdateAirShipTickets(airShipTickets);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airShips = _airShipTicketsService.GetByAirShipTicketsId(id);
			_airShipTicketsService.RemoveAirShipTickets(airShips);
		}
	}
}