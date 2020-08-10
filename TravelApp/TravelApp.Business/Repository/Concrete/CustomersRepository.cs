using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelApp.Business.Repository.Abstract;
using TravelApp.Data.Models;

namespace TravelApp.Business.Repository.Concrete
{
	public class CustomersRepository : ICustomersRepository
	{
		public Customers CreateCustomers(Customers customers)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Customers.Add(customers);
				db.SaveChanges();
				return customers;
			}
		}

		public List<Customers> GetAllCustomers()
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Customers.ToList();
			}
		}

		public Customers GetByCustomersId(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				return db.Customers.Find(id);
			}
		}

		public void RemoveCustomers(int id)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				var removeCustomers = GetByCustomersId(id);
				db.Customers.Remove(removeCustomers);
				db.SaveChanges();
			}
		}

		public Customers UpdateCustomers(Customers customers)
		{
			using (TravelMobilContext db = new TravelMobilContext())
			{
				db.Customers.Update(customers);
				return customers;
			}
		}
	}
}
