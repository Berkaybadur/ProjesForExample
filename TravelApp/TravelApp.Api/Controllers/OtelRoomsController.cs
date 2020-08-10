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
	public class OtelRoomsController : ControllerBase
	{
		private IOtelRoomsService _otelRoomsService;
		public OtelRoomsController(IOtelRoomsService otelRoomsService)
		{
			_otelRoomsService = otelRoomsService;
		}
		[HttpGet]
		public List<OtelRooms> Get()
		{
			return _otelRoomsService.GetAllOtelRooms();
		}
		[HttpGet("{id}")]
		public OtelRooms GetById(int id)
		{
			return _otelRoomsService.GetByOtelRoomsId(id);
		}
		[HttpPost]
		public void Post([FromBody]OtelRooms otelRooms)
		{
			 _otelRoomsService.CreateOtelRooms(otelRooms);
		}
		[HttpPut]
		public void Put([FromBody]OtelRooms otelRooms)
		{
			 _otelRoomsService.UpdateOtelRooms(otelRooms);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var otelRooms = _otelRoomsService.GetByOtelRoomsId(id);
			_otelRoomsService.RemoveOtelRooms(otelRooms);
		}
	}
}