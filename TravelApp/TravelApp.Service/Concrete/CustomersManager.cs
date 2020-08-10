using System;
using System.Collections.Generic;
using System.Text;
using TravelApp.Business.Repository.Concrete;
using TravelApp.Data.Models;
using TravelApp.DataAccess.Abstract;
using TravelApp.Service.Abstract;

namespace TravelApp.Service.Concrete
{
	public class CustomersManager : ICustomersService
	{
		private ICustomersDal _customersDal;
		public CustomersManager(ICustomersDal customersDal)
		{
			_customersDal = customersDal;
		}
		public void CreateCustomers(Customers customers)
		{
			_customersDal.Add(customers);
		}

		public List<Customers> GetAllCustomers()
		{
			return _customersDal.GetList();
		}

		public Customers GetByCustomersId(int id)
		{
			return _customersDal.Get(a=>a.CustomerId==id);
		}

		public void RemoveCustomers(Customers customers)
		{
			_customersDal.Delete(customers);
		}

		public void UpdateCustomers(Customers customers)
		{
			_customersDal.Update(customers);
		}
	}
}
