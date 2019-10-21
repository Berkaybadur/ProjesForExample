using Entities.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deneme
{
    public partial class GirisEkran : Form
    {
        public GirisEkran()
        {

            InitializeComponent();
        }
        DataSet set;
        SqlDataAdapter adapter;
        SqlDataReader reader;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con = new SqlConnection("data source=DESKTOP-D5LK2C0\\SQLEXPRESS;initial catalog = Stajyer_Test;");
        private void İcineDoldur()
        {
            adapter = new SqlDataAdapter("Select * From GirisEkran", con);
            set = new DataSet();
            con.Open();
            adapter.Fill(set, "GirisEkran");
            con.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUserName.Text == string.Empty || txtPassword.Text == string.Empty)
            {
                MessageBox.Show("Boş Alan Mevcut Lütfen Doldurunuz... !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string UserName = txtUserName.Text;
                string Password = txtPassword.Text;
                var cmd = new SqlCommand();
                İcineDoldur();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM GirisEkran where UserName='" + txtUserName.Text + "' AND UPassword='" + txtPassword.Text + "'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (reader["RollerId"].ToString() == "1")
                        {
                            MessageBox.Show("Admin Olarak Giriş Yapılıyor...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            IlanForm ilan = new IlanForm();
                            ilan.Show();
                            this.Hide();
                        }
                        else

                        {
                            MessageBox.Show("Kullanıcı Olarak Giriş Yapılıyor...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            IlanForm ilan = new IlanForm();
                            ilan.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    reader.Close();
                    MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();

        }
    }
}


