using System;
using System.Collections.Generic;
using System.Linq;
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
	public class AirShipExpeditionController : ControllerBase
	{
		private IAirShipExpeditionService _airShipExpeditionService;
		public AirShipExpeditionController(IAirShipExpeditionService airShipExpeditionService)
		{
			_airShipExpeditionService = airShipExpeditionService;
		}
		[HttpGet]
		public List<AirShipExpedition> Get()
		{
			return _airShipExpeditionService.GetAllAirShipExpedition();
		}
		[HttpGet("{id}")]
		public AirShipExpedition GetById(int id)
		{
			return _airShipExpeditionService.GetByAirShipExpeditionId(id);
		}
		[HttpPost]
		public void Post([FromBody]AirShipExpedition airShipExpedition)
		{
			 _airShipExpeditionService.CreateAirShipExpedition(airShipExpedition);
		}
		[HttpPut]
		public void Put([FromBody]AirShipExpedition airShipExpedition)
		{
		   _airShipExpeditionService.UpdateAirShipExpedition(airShipExpedition);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airShipExpeditions = _airShipExpeditionService.GetByAirShipExpeditionId(id);
			_airShipExpeditionService.RemoveAirShipExpedition(airShipExpeditions);
		}
	}
}