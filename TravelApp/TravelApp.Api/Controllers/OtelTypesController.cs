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
    public class OtelTypesController : ControllerBase
    {
        private IOtelTypesService _otelTypesService;
        public OtelTypesController(IOtelTypesService otelTypesService)
        {
			_otelTypesService = otelTypesService;
        }
		[HttpGet]
		public List<OtelTypes> Get()
		{
			return _otelTypesService.GetAllOtelTypes();
		}
		[HttpGet("{id}")]
		public OtelTypes GetById(int id)
		{
			return _otelTypesService.GetByOtelTypesId(id);
		}
		[HttpPost]
		public void Post([FromBody]OtelTypes otelTypes)
		{
			 _otelTypesService.CreateOtelTypes(otelTypes);
		}
		[HttpPut]
		public void Put([FromBody]OtelTypes otelTypes)
		{
			 _otelTypesService.UpdateOtelTypes(otelTypes);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var oteltypes = _otelTypesService.GetByOtelTypesId(id);
			_otelTypesService.RemoveOtelTypes(oteltypes);
		}
	}
}