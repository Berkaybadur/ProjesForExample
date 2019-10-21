using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#pragma warning disable CS0105 // Using directive appeared previously in this namespace
using BusinessLayer;
using DataLayer;
#pragma warning restore CS0105 // Using directive appeared previously in this namespace


namespace PresentationLayer
{
    public partial class urunler : Form
    {
        public urunler()
        {
            InitializeComponent();
            this.Load += Urunler_Load;
        }
        urunBusiness ub = new urunBusiness();
        CategBusiness cb = new CategBusiness();
        
        private void ListProducts()
        {
            LimanOtomEntities1 le = new LimanOtomEntities1();
            var urunler = from l in le.urunlers
                           select new
                           {
                               l.UrunId,
                               l.urunAd,
                               l.urunKateg,
                               l.Miktar


                           };
            dgwProduct.DataSource = urunler;
        }
        private void Urunler_Load(object sender, EventArgs e)
        {
            cmbCategory.SetDataSource(cb.List(), "KategAd", "KategoriId");
            ListProducts();

        }

        private void dgwProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
