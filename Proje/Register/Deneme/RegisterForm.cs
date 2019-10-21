using Entities.Models;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entities.Models;
using Entities.Repository;

namespace Deneme
{
    public partial class RegisterForm : Form
    {
        RegisterRepository _repo { get; set; }
        private int id;
        public RegisterForm()
        {
            _repo = new RegisterRepository();
            InitializeComponent();
        }
        #region Methodlar

        public void Kaydet()
        {
         
                

            
            if (FormKontrol())
            {

                var result = _repo.KullaniciKontrol(txtUserName.Text, txtPhoneNumber.Text);



                var rg = new Register
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Adress = rchAdress.Text
                };
               int id = _repo.Insert(rg);
                if  (id > 0)   
                {
                    MessageBox.Show("Bilgileriniz Basariyla Kaydedilmistir !", "Kaydediliyor...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("hatalı", "sd", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

            }
        }


        public void Guncelle()
        {


            if (FormKontrol())
            {
                var rg = new Register
                {
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    Name = txtName.Text,
                    SurName = txtSurName.Text,
                    PhoneNumber = txtPhoneNumber.Text,
                    Adress = rchAdress.Text,
                    Id = id,

                };

                var result = _repo.KullaniciKontrol(txtUserName.Text, txtPhoneNumber.Text,id);

                _repo.Update(rg);
                
                MessageBox.Show("Basariyla Guncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Boş geçilmez alanlar mevcut !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Userlist(bool tt)
        {
            var rep = new RegisterRepository();
            var a = rep.GetAllList(tt);
            dgwRegister.DataSource = a;
            dgwRegister.RowHeadersVisible = false;
            dgwRegister.EnableHeadersVisualStyles = false;
            this.dgwRegister.GridColor = Color.MidnightBlue;
            dgwRegister.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgwRegister.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwRegister.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwRegister.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgwRegister.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgwRegister.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            dgwRegister.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }

        #endregion

        #region  ButtonClick

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (id <= 0)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _repo.SoftDelete(id);
            MessageBox.Show("Kayıt silinmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Userlist(false);
            id = 0;

        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (id > 0) Guncelle();
            else Kaydet();
            
            Userlist(false);
            id = 0;


            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtSurName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(rchAdress.Text))
            {
                MessageBox.Show("Boş geçilmez alanlar mevcut !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Temizle();
        }

        public void Temizle()
        {

            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtSurName.Text = string.Empty;
            rchAdress.Text = string.Empty;
            btnRegister.Text = "KAYDET";

        }

        #endregion

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            Userlist(false);
        }

        private void RegisterForm_MouseClick(object sender, MouseEventArgs e)
        {
            id = Convert.ToInt32(dgwRegister.CurrentRow.Cells[0].Value);
            txtUserName.Text = dgwRegister.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dgwRegister.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgwRegister.CurrentRow.Cells[3].Value.ToString();
            txtSurName.Text = dgwRegister.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgwRegister.CurrentRow.Cells[5].Value.ToString();
            rchAdress.Text = dgwRegister.CurrentRow.Cells[6].Value.ToString();
            btnRegister.Text = "GÜNCELLE";
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void chkNotRegistered_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNotRegistered.Checked == true)
            {
                Userlist(true);
            }
            else
                Userlist(false);
        }

        private void dgwRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwRegister.CurrentRow.Cells[0].Value);
            txtUserName.Text = dgwRegister.CurrentRow.Cells[1].Value.ToString();
            txtPassword.Text = dgwRegister.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgwRegister.CurrentRow.Cells[3].Value.ToString();
            txtSurName.Text = dgwRegister.CurrentRow.Cells[4].Value.ToString();
            txtPhoneNumber.Text = dgwRegister.CurrentRow.Cells[5].Value.ToString();
            rchAdress.Text = dgwRegister.CurrentRow.Cells[6].Value.ToString();
            btnRegister.Text = "Güncelle";
        }

        private void btnClean_Click(object sender, EventArgs e)
        {

            Temizle();
        }


        #region Kontroller

        private bool FormKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtUserName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text) || string.IsNullOrWhiteSpace(txtSurName.Text) || string.IsNullOrWhiteSpace(txtPhoneNumber.Text) || string.IsNullOrWhiteSpace(rchAdress.Text))
            {
                return false;
            }
            return true;
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            GirisEkran giris = new GirisEkran();
            giris.Show();
            this.Hide();
        }

        private void btnGoLogin_Click(object sender, EventArgs e)
        {
            GirisEkran giris = new GirisEkran();
            giris.Show();
            this.Hide();
        }
    }
}
