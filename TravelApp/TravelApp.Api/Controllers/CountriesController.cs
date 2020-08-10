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
	public class CountriesController : ControllerBase
	{
		private ICountriesService _countriesService;
		public CountriesController(ICountriesService countriesService)
		{
			_countriesService = countriesService;

		}
		[HttpGet("Get")]
		public List<Countries> Get()
		{
			return _countriesService.GetAllCountries();
		}
		[HttpGet("{id}")]
		public Countries GetById(int id)
		{
			return _countriesService.GetByCountriesId(id);
		}
		[HttpPost]
		public void Post([FromBody]Countries countries)
		{
			_countriesService.CreateCountries(countries);
		}
		[HttpPut]
		public void Put([FromBody]Countries countries)
		{
			 _countriesService.UpdateCountries(countries);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var countries = _countriesService.GetByCountriesId(id);
			_countriesService.RemoveCountries(countries);
		}
	}
}