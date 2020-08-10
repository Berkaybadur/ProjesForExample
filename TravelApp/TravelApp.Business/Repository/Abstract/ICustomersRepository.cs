using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Abstract
{
	public interface ICustomersRepository
	{
		List<Customers> GetAllCustomers();
		Customers GetByCustomersId(int id);
		Customers CreateCustomers(Customers customers);
		Customers UpdateCustomers(Customers customers);
		void RemoveCustomers(int id);

	}
}
