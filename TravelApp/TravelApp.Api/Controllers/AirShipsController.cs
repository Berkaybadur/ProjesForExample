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
	public class AirShipsController : ControllerBase
	{
		private IAirShipsService _airShipsService;
		public AirShipsController(IAirShipsService airShipsService)
		{
			_airShipsService = airShipsService;
		}
		[HttpGet("Get")]
		public List<AirShips> Get()
		{
			return _airShipsService.GetAllAirShips();
		}
		[HttpGet("{id}")]
		public AirShips GetById(int id)
		{
			return _airShipsService.GetByAirShipsId(id);
		}
		[HttpPost]
		public void Post([FromBody]AirShips airShips)
		{
			 _airShipsService.CreateAirShips(airShips);
		}
		[HttpPut]
		public void Put([FromBody]AirShips airShips)
		{
			 _airShipsService.UpdateAirShips(airShips);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airShips = _airShipsService.GetByAirShipsId(id);
			_airShipsService.RemoveAirShips(airShips);
		}
	}
}