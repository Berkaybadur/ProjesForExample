using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Service.Abstract
{
	public interface ICustomersService
	{
		List<Customers> GetAllCustomers();
		Customers GetByCustomersId(int id);
		void CreateCustomers(Customers customers);
		void UpdateCustomers(Customers customers);
		void RemoveCustomers(Customers customers);
	}
}
