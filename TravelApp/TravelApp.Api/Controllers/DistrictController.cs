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
	public class DistrictController : ControllerBase
	{
		private IDistrictService _districtService;
		public DistrictController(IDistrictService districtService)
		{
			_districtService = districtService;
		}
		[HttpGet]
		public List<District> Get()
		{
			return _districtService.GetAllDistrict();
		}
		[HttpGet("{id}")]
		public District GetById(int id)
		{
			return _districtService.GetByDistrictId(id);
		}
		[HttpPost]
		public void Post([FromBody]District district)
		{
			 _districtService.CreateDistrict(district);
		}
		[HttpPut]
		public void Put([FromBody]District district)
		{
			 _districtService.UpdateDistrict(district);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var district = _districtService.GetByDistrictId(id);
			_districtService.RemoveDistrict(district);
		}
	}
}