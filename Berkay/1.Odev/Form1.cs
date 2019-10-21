using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
     DatabaseBusiness db = new DatabaseBusiness();


        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void ProductsList()
        {
            dgvProducts.DataSource = db.ExecuteAdapter("SP_Select");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ProductsList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen bilgileri doldurun!", "UYARI", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Bilgiler kaydedilecek emin misiniz?", "KAYIT ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                switch (r)
                {
                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Insert", new SqlParameter[]
                        {
                            new SqlParameter("@Name", txtName.Text),
                            new SqlParameter("@Price", txtPrice.Text)
                        });
                        ProductsList();
                        break;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen formu doldurun!", "GÜNCELLEME", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Güncelleme işlemini yapmak istediğinizden emin misiniz?", "GÜNCELLEME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (r)
                {

                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Update", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text),
                            new SqlParameter("@Name", txtName.Text),
                            new SqlParameter("@Price", txtPrice.Text)
                        });
                        ProductsList();
                        break;

                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtId.Text) || string.IsNullOrEmpty(txtPrice.Text))
            {
                MessageBox.Show("Lütfen formu doldurun!", "GÜNCELLEME", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult r = MessageBox.Show("Silme işlemini yapmak istediğinizden emin misiniz?", "SİLME ONAY", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                switch (r)
                {

                    case DialogResult.Yes:
                        db.ExecuteCommand("SP_Delete", new SqlParameter[] {
                            new SqlParameter("@Id", txtId.Text)
                        });
                        ProductsList();
                        break;

                }
            }
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvProducts.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            txtName.Text = dgvProducts.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            txtPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["Price"].Value.ToString();
        }
    }
}
