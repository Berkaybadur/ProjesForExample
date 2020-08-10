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
    public class AirRouteController : ControllerBase
    {
		private IAirRoutesService _airRoutesService;
		public AirRouteController(IAirRoutesService airRoutesService)
		{
			_airRoutesService = airRoutesService;
		}
		[HttpGet("Get")]
		public List<AirRoutes> Get()
		{
			return _airRoutesService.GetAllInclude();
		}
		[HttpGet("{id}")]
		public AirRoutes GetById(int id)
		{
			return _airRoutesService.GetByAirRoutesId(id);
		}
		[HttpPost]
		public void Post([FromBody]AirRoutes airRoutes)
		{
			 _airRoutesService.CreateAirRoutes(airRoutes);
		}
		[HttpPut]
		public void Put([FromBody]AirRoutes airports)
		{
			 _airRoutesService.UpdateAirRoutes(airports);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airroutes = _airRoutesService.GetByAirRoutesId(id);
			_airRoutesService.RemoveAirRoutes(airroutes);
		}
	}
}