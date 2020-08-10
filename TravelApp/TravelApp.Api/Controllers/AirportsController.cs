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
	public class AirportsController : ControllerBase
	{
		private IAirportService _airportService;
		public AirportsController(IAirportService airportService)
		{
			_airportService = airportService;
		}

		//[HttpGet("All")]
		//public List<Airports> GetAll()
		//{
		//	return _airportService.GetAllInclude();
		//}


		[HttpGet("Get")]
		public List<Airports> Get()
		{
			return  _airportService.GetAllInclude();
		}
		[HttpGet("{id}")]
		public Airports GetById(int id)
		{
			return _airportService.GetByAirportId(id);
		}
		[HttpPost]
		public void Post([FromBody]Airports airports)
		{
			_airportService.CreateAirport(airports);
		}
		[HttpPut]
		public void Put([FromBody]Airports airports)
		{
			_airportService.UpdateAirport(airports);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airport = _airportService.GetByAirportId(id);
			_airportService.RemoveAirport(airport);
		}
	}
}