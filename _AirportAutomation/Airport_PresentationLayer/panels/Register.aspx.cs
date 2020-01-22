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

namespace Airport_PresentationLayer
{
    public partial class Login : System.Web.UI.Page
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
                ddlDistrict.SetDataSource<District>(dist.ListForComboBox(), "DistrictName", "DistrictId");
                ddlDegree.SetDataSource<Degree>(deg.ListForComboBoxRegister(), "Name", "DegreeId");


            }
        }

        private bool CustomerKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtTc.Text) || string.IsNullOrWhiteSpace(txtFirstname.Text) || string.IsNullOrWhiteSpace(txtLastname.Text) || string.IsNullOrWhiteSpace(txtCustomerMail.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(ddlDistrict.Text))
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

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (CustomerKontrol())
            {
                var customer = new Customers
                {
                    CustomerTc = txtTc.Text,
                    CustomerMail = txtCustomerMail.Text,
                    CustomerName = txtFirstname.Text,
                    CustomerSurname = txtLastname.Text,
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
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BAŞARIYLA KAYIT OLDUNUZ.')", true);
                    Clear();
                }
                return;
            }
            else
            {
                return;
            }
        }
        private void Clear()
        {
            txtTc.Text = string.Empty;
            txtFirstname.Text = string.Empty;
            txtLastname.Text = string.Empty;
            txtCustomerMail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            ddlDistrict.SelectedIndex = -1;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}