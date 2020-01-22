using Airport.DataEntities.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airport_PresentationLayer
{
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        AirportContext airportcontext = new AirportContext();
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            var Person = airportcontext.Customers.Where(x => x.UserName == txtUsername.Text && x.UserPassword == txtPassword.Text).Count();
            if(Person !=0)
            {
                var Person2 = airportcontext.Customers.FirstOrDefault(x => x.UserName == txtUsername.Text && x.UserPassword == txtPassword.Text);
                if(Person2.DegreeId==1)
                {
                    Session["username"] = txtUsername.Text;
                    Response.Redirect("AdminPanels.aspx?username=" + txtUsername.Text);
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Admin Panele Yönlendiriliyorsunuz.')", true);
                    Response.Redirect("AdminPanels.aspx");
                }
                else if(Person2.DegreeId==2)
                {
                    Session["username"] = txtUsername.Text;
                    Response.Redirect("UserPanel.aspx?username=" + txtUsername.Text);
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Kullanıcı Panele Yönlendiriliyorsunuz.')", true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('YANLIŞ BİR KULLANICI GİRİŞİ.')", true);
                GirisTemizle();
            }
        }
        public void GirisTemizle()
        {
            txtUsername.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}