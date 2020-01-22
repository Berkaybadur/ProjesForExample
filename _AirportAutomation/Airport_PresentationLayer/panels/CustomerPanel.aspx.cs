using Airport.Business.CustomExtension;
using Airport.Business.Repository.Concrete;
using Airport.DataEntities.Entities;
using Airport_PresentationLayer.AirportReferences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airport_PresentationLayer.panels
{
    public partial class CustomerPanel : System.Web.UI.Page
    {
        int id;
        AirportServiceClient client = new AirportServiceClient();
        DistrictConcrete dist = new DistrictConcrete();
        DegreeConcrete deg = new DegreeConcrete();
        CustomerConcrete cus = new CustomerConcrete();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {

                Userlist(true);
                ddlDistrict.SetDataSource<District>(dist.ListForComboBox(), "DistrictName", "DistrictId");
                ddlDegree.SetDataSource<Degree>(deg.ListForComboBox(), "Name", "DegreeId");
                var item = cus.SelectedItemCustomer(id);
                if (id > 0)
                {
                    txtCustomerTc.Text = item.CustomerTc;
                    txtCustomerMail.Text = item.CustomerMail;
                    txtCustomerName.Text = item.CustomerName;
                    txtCustomerSurname.Text = item.CustomerSurname;
                    txtAddress.Text = item.CustomerAdress;
                    txtPhone.Text = item.CustomerPhone;
                    txtUsername.Text = item.UserName;
                    txtPassword.Text = item.UserPassword;
                    ddlDistrict.SelectedValue = Convert.ToString(item.DistrictId);
                    ddlDegree.SelectedValue = Convert.ToString(item.DegreeId);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }


        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                client.DeleteCustomer(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('MÜŞTERİ SİLİNİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek müşteri bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CustomerKontrol())
            {
                var customer = new Customers
                {
                    CustomerId = id,
                    CustomerTc = txtCustomerTc.Text,
                    CustomerMail = txtCustomerMail.Text,
                    CustomerName = txtCustomerName.Text,
                    CustomerSurname = txtCustomerSurname.Text,
                    CustomerAdress = txtAddress.Text,
                    CustomerPhone = txtPhone.Text,
                    UserName = txtUsername.Text,
                    UserPassword = txtPassword.Text,
                    DistrictId = Convert.ToInt32(ddlDistrict.Text),
                    DegreeId = Convert.ToInt32(ddlDegree.Text),
                };
                client.EditCustomer(customer);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('İLANINIZ GÜNCELLENMİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                return;
            }
        }

        private void Userlist(bool tt)
        {
            var a = client.GetCustomers();
            dgwCustomer.DataSource = a;
            dgwCustomer.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (CustomerKontrol())
            {
                var customer = new Customers
                {
                    CustomerTc = txtCustomerTc.Text,
                    CustomerMail = txtCustomerMail.Text,
                    CustomerName = txtCustomerName.Text,
                    CustomerSurname = txtCustomerSurname.Text,
                    CustomerAdress = txtAddress.Text,
                    CustomerPhone = txtPhone.Text,
                    UserName = txtUsername.Text,
                    UserPassword = txtPassword.Text,
                    DistrictId = Convert.ToInt32(ddlDistrict.Text),
                    DegreeId = Convert.ToInt32(ddlDegree.Text),
                };
                client.AddCustomer(customer);
                string confirmValue = Request.Form["confirm_value"];

                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('EKLENDİ.')", true);
                    Userlist(true);
                }
                return;
            }
            else
            {
                return;
            }
        }
        #region Kontroller
        private bool CustomerKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtCustomerTc.Text) || string.IsNullOrWhiteSpace(txtCustomerName.Text) || string.IsNullOrWhiteSpace(txtCustomerSurname.Text) || string.IsNullOrWhiteSpace(txtCustomerMail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(ddlDistrict.Text) || string.IsNullOrWhiteSpace(ddlDegree.Text))
            {
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BOŞ ALAN MEVCUT.')", true);
                }
                return false;
            }
            return true;
        }
        private void Clear()
        {
            txtCustomerTc.Text = string.Empty;
            txtCustomerName.Text = string.Empty;
            txtCustomerSurname.Text = string.Empty;
            txtCustomerMail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            ddlDegree.SelectedIndex = -1;
            ddlDistrict.SelectedIndex = -1;
        }
        #endregion Kontroller

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

    }
}