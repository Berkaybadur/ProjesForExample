using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BusinessLayer.Abstract;
using _DataLayer;

namespace _BusinessLayer.Concrete
{

	public class CustomerBusiness:IDatabaseBusiness
	{
		private BankaDbEntities db = new BankaDbEntities();
		private Customer _customer;
		public CustomerBusiness(Customer Customer)
		{
			_customer = Customer;
		}
		public void Create()
		{
			db.Customers.Add(_customer);
			db.SaveChanges();
		}

		public void Delete()
		{
			db.Customers.Remove(_customer);
			db.SaveChanges();
		}

		public void List(DataGridView dgwCustomer)

        {
			dgwCustomer.DataSource = db.Customers.ToList();
		}

		public void Update()
		{
			db.Customers.Attach(_customer);
			db.Entry(_customer).State = EntityState.Modified;
			db.SaveChanges();
		}
	}
}
