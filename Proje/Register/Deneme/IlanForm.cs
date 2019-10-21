using Entities.Models;
using Entities.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Deneme
{
    public partial class IlanForm : Form
    #region Load
    #region Baslangic
    {
        RegisterRepository _repo { get; set; }
        AracRepository _aracrepo { get; set; }
        IlanRepository _ılanrepo { get; set; }
        ModelRepository _modelrepo { get; set; }
        private int id;
        public IlanForm()
        {
            _aracrepo = new AracRepository();
            _ılanrepo = new IlanRepository();
            _repo = new RegisterRepository();
            _modelrepo = new ModelRepository();
            InitializeComponent();
            var lst = _aracrepo.GetAllListArac(false);
            cmbArac.Items.Clear();

          

            foreach (var item in lst)
            {
                
                cmbArac.Items.Add(new { name = Convert.ToString(item.AracAd), value = Convert.ToString(item.AracKod) });
            }
            cmbArac.ValueMember = "value";
            cmbArac.DisplayMember = "name";


            var lstregister = _repo.GetAllList(false);
            cmbUsers.Items.Clear();



            foreach (var item in lstregister)
            {

                cmbUsers.Items.Add(new { name = Convert.ToString(item.Name), value = Convert.ToString(item.SurName) });
            }
            cmbUsers.ValueMember = "value";
            cmbUsers.DisplayMember = "name";

          


          

        }

        #endregion Load Bitis




        #region Crud İşlemleri 





        public void Kaydet()
        {

            if (IlanFormKontrol())
            {
               
          

                var ilan = new Ilan
                {
                    AracAd = cmbArac.Text,
                    AracModel = cmbModels.Text,
                    Kullanici = cmbUsers.Text,
                    BaslangicTarih = Convert.ToDateTime(dtpBaslangic.Text),
                    BitisTarih = Convert.ToDateTime(dtpBitis.Text),
                    Acıklama = txtComment.Text
                    
                };
                    
                int id = _ılanrepo.Insert(ilan);
                if (id > 0 )
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


            if (IlanFormKontrol())
            {

                var ilan = new Ilan
                {
                    AracAd = cmbArac.Text,
                    AracModel = cmbModels.Text,
                    Kullanici = cmbUsers.Text,
                    BaslangicTarih = Convert.ToDateTime(dtpBaslangic.Text),
                    BitisTarih = Convert.ToDateTime(dtpBitis.Text),
                    Acıklama = txtComment.Text,
                    Id = id,
            };

              

                _ılanrepo.Update(ilan);
                MessageBox.Show("Basariyla Guncellendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Boş geçilmez alanlar mevcut !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        #endregion Baslangic


        #endregion Crud İşlemleri





        #region Ayarlamalar





       

        private void Userlist(bool tt)
        {
            var rep = new RegisterRepository();
            var a = _ılanrepo.GetAllListIlan(tt);
            dgwIlan.DataSource = a;
            dgwIlan.RowHeadersVisible = false;
            dgwIlan.EnableHeadersVisualStyles = false;
            this.dgwIlan.GridColor = Color.MidnightBlue;
            dgwIlan.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgwIlan.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgwIlan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgwIlan.RowsDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgwIlan.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ActiveCaption;
            dgwIlan.DefaultCellStyle.SelectionBackColor = SystemColors.GradientActiveCaption;
            dgwIlan.ColumnHeadersDefaultCellStyle.Font = new Font("Times New Roman", 10, FontStyle.Bold);
        }




        private void Temizle()
        {
            dtpBaslangic.Text = string.Empty;
            txtComment.Text = string.Empty;
            dtpBitis.Text = string.Empty;
            cmbArac.Text = string.Empty;
            cmbModels.Text = string.Empty;
            cmbUsers.Text = string.Empty;
            btnIlan.Text = "İLAN VER";
            

        }



        #region Kontroller
        private bool IlanFormKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(cmbArac.Text) || string.IsNullOrWhiteSpace(cmbModels.Text)  || string.IsNullOrWhiteSpace(cmbUsers.Text) || string.IsNullOrWhiteSpace(dtpBitis.Text) || string.IsNullOrWhiteSpace(dtpBaslangic.Text) || string.IsNullOrWhiteSpace(txtComment.Text))
            {
                return false;
            }
            return true;
        }

        #endregion Kontroller







        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {

           var arac  = cmbArac.SelectedItem; 
            System.Reflection.PropertyInfo pi = (arac.GetType().GetProperty("value"));
            string code = (String)(pi.GetValue(arac, null));
            var models = _modelrepo.GetAllListAracModel(code);
            cmbModels.Items.Clear();
            foreach (var item in models)
            {
                cmbModels.Items.Add(new { name = Convert.ToString(item.ModelAd), value = Convert.ToString(item.AracCode) });
            }
            
            cmbModels.ValueMember = "value";
            cmbModels.DisplayMember = "name";

            lblModelSec.Enabled = true;
            cmbModels.Enabled= true;
            

        }



        private void dgwIlan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(dgwIlan.CurrentRow.Cells[0].Value);
            cmbArac.Text = dgwIlan.CurrentRow.Cells[1].Value.ToString();
            cmbModels.Text = dgwIlan.CurrentRow.Cells[2].Value.ToString();
            cmbUsers.Text = dgwIlan.CurrentRow.Cells[3].Value.ToString();
            txtComment.Text = dgwIlan.CurrentRow.Cells[4].Value.ToString();
            dtpBaslangic.Text = dgwIlan.CurrentRow.Cells[5].Value.ToString();
            dtpBitis.Text = dgwIlan.CurrentRow.Cells[6].Value.ToString();
            btnIlan.Text = "Güncelle";
        }



        private void btnClean_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void IlanForm_Load(object sender, EventArgs e)
        {
            Userlist(false);
            lblModelSec.Enabled = false;
            cmbModels.Enabled = false;
        }

        private void chkIsDeleted_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIsDeleted.Checked == true)
            {
                Userlist(true);
            }
            else
                Userlist(false);
        }

        private void btnIlan_Click(object sender, EventArgs e)
        {
            if (id > 0) Guncelle();

            else Kaydet();
        
            Userlist(false);
            id = 0;

           

            if (dtpBaslangic.Text == string.Empty || dtpBitis.Text==string.Empty || txtComment.Text==string.Empty || cmbArac.Text ==string.Empty || cmbModels.Text==string.Empty || cmbUsers.Text==string.Empty)
            {
                MessageBox.Show("Boş geçilmez alanlar mevcut !", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;   
            }
            Temizle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (id <= 0)
            {
                MessageBox.Show("Silinecek Kayıt Bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ılanrepo.SoftDeleteIlan(id);
            MessageBox.Show("Kayıt silinmiştir", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            Userlist(false);
            id = 0;
        }

        private void txtBDatetime_KeyPress(object sender, KeyPressEventArgs e)
        {
           

            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFDatetime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            GirisEkran giris = new GirisEkran();
                       giris.Show();
                       this.Hide();
        }
    }



    #endregion Ayarlamalar

    public class ComboboxItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public override string ToString() { return Text; }
    }




}
