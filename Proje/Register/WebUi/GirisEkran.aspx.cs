using Entities.Repository;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUi
{
    public partial class Denemem : System.Web.UI.Page
    {

        private int id;

        RegisterRepository _registerRepo { get; set; }
        public Denemem()
        {
            _registerRepo = new RegisterRepository();
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Giris_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue == "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BOŞ ALAN MEVCUT.')", true);
                }
                return;
            }
            var res = _registerRepo.Login(txtKullaniciAdi.Text, txtPassword.Text);
            
            if (res == true)
            {
                Session["username"] = txtKullaniciAdi.Text;
                Response.Redirect("Ilan.aspx?username=" + txtKullaniciAdi.Text);
            }
            else
            {
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue == "Yes")
                {
                    GirisTemizle();
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('YANLIŞ BİR KULLANICI GİRİŞİ.')", true);
                }
            }
        }

        protected void Kayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Kayit.aspx");
        }

       public void GirisTemizle()
        {
            txtKullaniciAdi.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}



