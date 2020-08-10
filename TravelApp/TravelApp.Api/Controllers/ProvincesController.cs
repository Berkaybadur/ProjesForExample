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
	public class ProvincesController : ControllerBase
	{
		private IProvincesService _provincesService;
		public ProvincesController(IProvincesService provincesService)
		{
			_provincesService = provincesService;
		}
		[HttpGet]
		public List<Provinces> Get()
		{
			return _provincesService.GetAllProvinces();
		}
		[HttpGet("{id}")]
		public Provinces GetById(int id)
		{
			return _provincesService.GetByProvincesId(id);
		}
		[HttpPost]
		public void Post([FromBody]Provinces provinces)
		{
			 _provincesService.CreateProvinces(provinces);
		}
		[HttpPut]
		public void Put([FromBody]Provinces provinces)
		{
			 _provincesService.UpdateProvinces(provinces);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var province = _provincesService.GetByProvincesId(id);
			_provincesService.RemoveProvinces(province);
		}
	}
}