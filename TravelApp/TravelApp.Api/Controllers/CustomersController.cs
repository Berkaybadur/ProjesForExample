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
	public class CustomersController : ControllerBase
	{
		private ICustomersService _customersService;
		public CustomersController(ICustomersService customersService)
		{
			_customersService = customersService;
		}
		[HttpGet("Get")]
		public List<Customers> Get()
		{
			return _customersService.GetAllCustomers();
		}
		[HttpGet("{id}")]
		public Customers GetById(int id)
		{
			return _customersService.GetByCustomersId(id);
		}
		[HttpPost]
		public IActionResult Post([FromBody]Customers customers)
		{
			_customersService.CreateCustomers(customers);
			return Ok();

		}
		[HttpPut]
		public void Put([FromBody]Customers customers)
		{
			_customersService.UpdateCustomers(customers);
		}
		[HttpDelete]
		public void Delete(int id)
		{
			var customer = _customersService.GetByCustomersId(id);
			_customersService.RemoveCustomers(customer);
		}
	}
}