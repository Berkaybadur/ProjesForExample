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
	public class AirSeatTypeController : ControllerBase
	{
		private IAirSeatTypeService _airSeatTypeService;
		public AirSeatTypeController(IAirSeatTypeService airSeatTypeService)
		{
			_airSeatTypeService = airSeatTypeService;
		}
		[HttpGet]
		public List<AirSeatType> Get()
		{
			return _airSeatTypeService.GetAirSeatTypes();
		}
		[HttpGet("{id}")]
		public AirSeatType GetById(int id)
		{
			return _airSeatTypeService.GetByAirSeatTypesId(id);
		}
		[HttpPost]
		public void Post([FromBody]AirSeatType airSeatType)
		{
			 _airSeatTypeService.CreateAirSeatTypes(airSeatType);
		}
		[HttpPut]
		public void Put([FromBody]AirSeatType airSeatType)
		{
			 _airSeatTypeService.UpdateAirSeatTypes(airSeatType);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var airSeatType = _airSeatTypeService.GetByAirSeatTypesId(id);
			_airSeatTypeService.RemoveAirSeatTypes(airSeatType);
		}
	}
}