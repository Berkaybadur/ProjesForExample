using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _BusinessLayer.Abstract;
using _BusinessLayer.Concrete;
using _DataLayer;

namespace _PresentationLayer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		ClassBusiness classBusiness = new ClassBusiness();
		CustomerBusiness customerBusiness;
		Customer customer = new Customer();



		private void List()
		{
			customerBusiness = new CustomerBusiness(customer);
			classBusiness.dgwCustomer = dgwCustomer;
			classBusiness.Operation(customerBusiness, ClassBusiness.OperationType.List);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			List();
		}

		private void BtnAdd_Click(object sender, EventArgs e)
		{
			customer.CustomerId = Convert.ToInt16(txtCustomerId.Text);
			customer.FirstName = txtCustomerFirstName.Text;
			customer.LastName = txtCustomerLastName.Text;
			customer.Email = txtEMail.Text;
			customer.IdentityNumber = txtIdentityNumber.Text;
			customer.PhoneNumber = txtPhoneNumber.Text;
			customerBusiness = new CustomerBusiness(customer);
			classBusiness.Operation(customerBusiness, ClassBusiness.OperationType.Create);
			List();
		}

		private void BtnUpdate_Click(object sender, EventArgs e)
		{
			customer.CustomerId = Convert.ToInt16(txtCustomerId.Text);
			customer.FirstName = txtCustomerFirstName.Text;
			customer.LastName = txtCustomerLastName.Text;
			customer.Email = txtEMail.Text;
			customer.IdentityNumber = txtIdentityNumber.Text;
			customer.PhoneNumber = txtPhoneNumber.Text;
			customerBusiness = new CustomerBusiness(customer);
			classBusiness.Operation(customerBusiness, ClassBusiness.OperationType.Update);
			List();
		}

		private void BtnDelete_Click(object sender, EventArgs e)
		{
			customer.CustomerId = Convert.ToInt16(txtCustomerId.Text);
			customerBusiness = new CustomerBusiness(customer);
			classBusiness.Operation(customerBusiness, ClassBusiness.OperationType.Delete);
			List();
		}

		private void DgwCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			txtCustomerId.Text = dgwCustomer.CurrentRow.Cells[0].Value.ToString();
			txtCustomerFirstName.Text = dgwCustomer.CurrentRow.Cells[1].Value.ToString();
			txtCustomerLastName.Text = dgwCustomer.CurrentRow.Cells[2].Value.ToString();
			txtEMail.Text = dgwCustomer.CurrentRow.Cells[3].Value.ToString();
			txtIdentityNumber.Text = dgwCustomer.CurrentRow.Cells[4].Value.ToString();
			txtPhoneNumber.Text = dgwCustomer.CurrentRow.Cells[4].Value.ToString(); 
		}
	}
}
