using Entities.Models;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUi
{
    
    public partial class Kayit : System.Web.UI.Page
    {
        int id;
        RegisterRepository registerrepo = new RegisterRepository();
        RegisterRepository _registerrepo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
                if (!IsPostBack)
                {
                    registerrepo = new RegisterRepository();
                    Userlist(false);
                }
            }
        
        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text= string.Empty;
            txtName.Text= string.Empty;
            txtSurName.Text= string.Empty;
            txtPhone.Text= string.Empty;
            txtAdress.Text= string.Empty;
        }

        private void Userlist(bool tt)
        {
            var rep = new RegisterRepository();
            var a = rep.GetAllList(tt);
            dgwRegister.DataSource = rep.GetAllList(tt);
            dgwRegister.DataBind();
        }

        #region Kontroller
        private bool RegisterKontrol()
        {
            if ( string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(txtAdress.Text))
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

        #endregion Kontroller

        protected void btnRegister_Click(object sender, EventArgs e)
        {

            if (id > 0) Güncelle();

            else KayitOl();
            Userlist(false);
            id = 0;
            Temizle();
        }


        public void KayitOl()
        {
            if (RegisterKontrol())
            {
                var register = new Register
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PhoneNumber = txtPhone.Text,
                    Adress = txtAdress.Text,
                };

                int id = registerrepo.Insert(register);
                if (id > 0)
                {
                    string confirmValue = Request.Form["confirm_value"];
                    if (confirmValue != "Yes")
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BAŞARIYLA KAYIT OLDUNUZ.')", true);
                    }
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        public void Temizle()
        {
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtName.Text = string.Empty;
            txtSurName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAdress.Text = string.Empty;
        }

        public void Güncelle()
        {
            if (RegisterKontrol())
            {
                var register = new Register
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PhoneNumber = txtPhone.Text,
                    Adress = txtAdress.Text,
                };
                _registerrepo.Update(register);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('KAYDINIZ GÜNCELLENMİŞTİR.')", true);
                }
            }
            else
            {
                return;
            }
    }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("GirisEkran.aspx");
        }
    }
}


