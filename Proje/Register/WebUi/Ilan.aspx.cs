using Entities.Models;
using Entities.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace WebUi.Pages
{
    public partial class Deneme2 : System.Web.UI.Page
    {
        int id;
        AracRepository _aracrepo { get; set; }
        ModelRepository _modelrepo { get; set; }
        IlanRepository _ilanrepo { get; set; }
        RenkRepository _renkrepo { get; set; }
        VitesRepository _vitesrepo { get; set; }
        string kullaniciAdi = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            txtSearch.Attributes.Add("onkeypress", "return clickButton(event,'" + btnSeacrh.ClientID + "')");

            txtDes.MaxLength = 40;
           
            


            if (Session["username"] == null)
            {
                Response.Redirect("GirisEkran.aspx");
            }
            else
            {
                _aracrepo = new AracRepository();
                _modelrepo = new ModelRepository();
                _ilanrepo = new IlanRepository();
                _renkrepo = new RenkRepository();
                _vitesrepo = new VitesRepository();
                id = Convert.ToInt32(Request.QueryString["id"]);
                kullaniciAdi =Session["username"].ToString();
                lblKullanici.Text=kullaniciAdi;
                if (!IsPostBack)

                {
                    txtSearch.Attributes.Add("onkeypress", "return clickButton(event,'" + btnSeacrh.ClientID + "')");
                    _ilanrepo = new IlanRepository();

                    Arac arac = new Arac { AracAd = "Seçiniz", AracKod = " -1 ", ArabaId = 0 };
                    List<Arac> lstArac = new List<Arac>();
                    var list = _aracrepo.GetAllListArac(false);
                    lstArac.Add(arac);
                    lstArac.AddRange(list);
                    BindDropdown(ddlArac, "AracAd", "AracKod", lstArac);
                    Userlist(false);

                    Renk renk = new Renk { Renkler = "Seçiniz", RenkKod = " -1 ", RenkId = 0 };
                    List<Renk> listrenkler = new List<Renk>();
                    var listrenk = _renkrepo.GetAllListRenk(true).ToList();
                    listrenkler.Add(renk);
                    listrenkler.AddRange(listrenk);
                    BindDropdown(ddlrenk, "Renkler", "RenkKod",listrenkler);
                    BindDropdown(ddlGRenk, "Renkler", "RenkKod", listrenkler);

                    Vites vites = new Vites { VitesId = 0, Vitestip = "Seçiniz", VitesKod = "-1" };
                    List<Vites> aracvites = new List<Vites>();
                    var listvites = _vitesrepo.GetAllListVites(true);
                    aracvites.Add(vites);
                    aracvites.AddRange(listvites);
                    BindDropdown(ddlvites, "Vitestip", "VitesKod", aracvites);
                    BindDropdown(ddlGVites, "Vitestip", "VitesKod", aracvites);

                    ddlAracModel.Enabled = false;
                    var item = _ilanrepo.SelectedItemIlan(id).FirstOrDefault();
                    if (id > 0)
                    {
                        if (item.Kullanici==kullaniciAdi)
                        {
                            ddlArac.Items.Clear();
                            ddlAracModel.Items.Clear();
                            ddlrenk.Items.Clear();
                            ddlvites.Items.Clear();
                            //Araç modeli tanımlayıp viewden bind etmek
                            string aracmodel = item.AracModel;
                            string aracrenk = item.Renk;
                            string ilanaracvites = item.Vites;
                            var aracList = _aracrepo.GetAracList(int.Parse(aracmodel));
                            var modelList = _modelrepo.GetAllListAracModel(int.Parse(aracmodel));
                            var viteslist = _vitesrepo.GetAllVitesId(ilanaracvites);
                            var renklist = _renkrepo.GetAllListRenkId(aracrenk);
                            txtDes.Text = item.Acıklama;
                            txtFiyat.Text = item.Fiyat.ToString();
                            txtKM.Text = item.KM.ToString();
                            txtYil.Text = item.Yil;
                            txtBTarih.Text = item.BaslangicTarih.ToShortDateString();
                            txtFTarih.Text = item.BitisTarih.ToShortDateString();
                            BindDropdown(ddlArac, "AracAd", "AracKod", lstArac);
                            ddlArac.SelectedValue = aracList[0].AracKod;
                            //var aracModel = _modelrepo.GetAllListAracModel(int.Parse(aracmodel));
                            var araccode = ddlArac.SelectedItem.Value;
                            var yenilist = _modelrepo.GetAllAracModelCode(araccode);
                            BindDropdown(ddlAracModel, "ModelAd", "Id", yenilist);
                            ddlAracModel.Enabled = true;
                            ddlAracModel.SelectedValue = modelList[0].Id.ToString();
                            item.Kullanici = lblKullanici.Text;
                            ddlAracModel.Enabled = true;
                            BindDropdown(ddlrenk, "Renkler", "RenkKod", listrenkler);
                            ddlrenk.SelectedValue = renklist[0].RenkKod;
                            BindDropdown(ddlvites, "Vitestip", "VitesKod", aracvites);
                            ddlvites.SelectedValue = viteslist[0].VitesKod;
                            Ilanver.Text = "GÜNCELLE";
                        }
                        else
                        {
                            this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BU İLAN SİZE AİT DEĞİL DÜZENLEYEMEZSİNİZ.')", true);
                            return;
                        }
                       
                    }
                }
            }
        }

        static void BindDropdown(DropDownList ddl, string text, string value, object list)
        {
            ddl.DataTextField = text;
            ddl.DataValueField = value;
            ddl.DataSource = (IList)list;
            ddl.DataBind();
        }

        protected void Ilanver_Click(object sender, EventArgs e)
        {
            if (id > 0) Güncelle();
            else IlanVer();
            Userlist(false);
            id = 0;
            Temizle();
        }

        private void Userlist(bool tt)
        {
            var rep = new IlanRepository();
            var a = _ilanrepo.GetAllListIlan(tt);
            dgwIlan.DataSource =a;
            dgwIlan.DataBind();
        }

        #region Methodlar

        private void IlanVer()
        {
            if (IlanKontrol())
            {
                var ilan = new Ilan
                {
                    Kullanici = kullaniciAdi,
                    AracAd = ddlArac.Text,
                    AracModel = ddlAracModel.Text,
                    BaslangicTarih = DateTime.Parse(txtBTarih.Text),
                    BitisTarih = DateTime.Parse(txtFTarih.Text),
                    Acıklama = txtDes.Text,
                    Yil = txtYil.Text,
                    Fiyat = Convert.ToDecimal(txtFiyat.Text),
                    KM = Convert.ToDecimal(txtKM.Text),
                    Renk = ddlrenk.Text,
                    Vites=ddlvites.Text,

                };
                int id = _ilanrepo.Insert(ilan);
                if (id > 0)
                {
                    string confirmValue = Request.Form["confirm_value"];

                    if (confirmValue != "Yes")
                    {
                        this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('İLANINIZ VERİLMİŞTİR.')", true);
                    }
                    return;
                    }
                    else
                    {
                      return;
                    }
            }
        }
        private void Temizle()
         {
            txtGFiyat.Text = string.Empty;
            txtGKM.Text = string.Empty;
            txtGYil.Text = string.Empty;
            ddlGVites.SelectedIndex =  -1 ;
            ddlGRenk.SelectedValue = " -1 ";
            ddlrenk.SelectedValue = " -1 ";
            ddlvites.SelectedValue =  "-1" ;
            ddlArac.SelectedValue = " -1 ";
            ddlAracModel.Items.Clear();
            txtBTarih.Text = string.Empty;
            txtFTarih.Text = string.Empty;
            txtDes.Text = string.Empty;
            Ilanver.Text = "ILAN VER";
            txtSearch.Text = string.Empty;
            txtKM.Text = string.Empty;
            txtYil.Text = string.Empty;
            txtFiyat.Text = string.Empty;
        
        }

        private void Güncelle()
        {
            if (IlanKontrol())
            {
                var ilan = new Ilan
                {
                    Id = id,
                    Kullanici = kullaniciAdi,
                    AracAd = ddlArac.Text,
                    AracModel = ddlAracModel.Text,
                    BaslangicTarih = DateTime.Parse(txtBTarih.Text),
                    BitisTarih = DateTime.Parse(txtFTarih.Text),
                    Acıklama = txtDes.Text,
                    Yil=txtYil.Text,
                    Fiyat=Convert.ToDecimal(txtFiyat.Text),
                    KM=Convert.ToDecimal(txtKM.Text),
                    Renk = ddlrenk.Text,
                    Vites = ddlvites.Text,

                };
                _ilanrepo.Update(ilan);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('İLANINIZ GÜNCELLENMİŞTİR.')", true);
                }
            }
            else
            {
                return;
            }
        }
        #region Kontroller
        private bool IlanKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(kullaniciAdi) || string.IsNullOrWhiteSpace(ddlArac.Text) || string.IsNullOrWhiteSpace(ddlAracModel.Text) || string.IsNullOrWhiteSpace(txtBTarih.Text) || string.IsNullOrWhiteSpace(txtFTarih.Text) || string.IsNullOrWhiteSpace(txtDes.Text))
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
        #endregion Methodlar

        protected void ddlArac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var araccode = ddlArac.SelectedItem.Value;
            var list = _modelrepo.GetAllListAracModel(araccode);
            BindDropdown(ddlAracModel, "ModelAd", "Id", list);
            ddlAracModel.Enabled = true;
        }
        protected void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (id >0)
            {
                _ilanrepo.SoftDeleteIlan(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('İLANINIZ SİLİNİŞTİR.')", true);
                    Userlist(false);
                    Temizle();
                }             
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek ilan bulunamamıştır!')", true);
            }
        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("GirisEkran.aspx");
        }

        protected void btnSeacrh_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                var bos = _ilanrepo.GetAllListIlan(false).ToList();
                dgwIlan.DataSource = bos;
                dgwIlan.DataBind();
            }
            else
            {
                var ara = _ilanrepo.GetSearch(txtSearch.Text).ToList();
                dgwIlan.DataSource = ara;
                dgwIlan.DataBind();
            }
        }

        protected void btnAra_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtGFiyat.Text) || string.IsNullOrWhiteSpace(txtGKM.Text) || string.IsNullOrWhiteSpace(txtGYil.Text) )
            {
                var bos = _ilanrepo.GetAllListIlan(false).ToList();
                dgwIlan.DataSource = bos;
                dgwIlan.DataBind();
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BOŞ BİR ALAN BIRAKTINIZ!')", true);
                Temizle();
            }
            else
            {
                var ara = _ilanrepo.GetAra(Convert.ToDecimal(txtGKM.Text), (txtGYil.Text), (ddlGRenk.Text), (ddlGVites.Text), Convert.ToDecimal(txtGFiyat.Text)).ToList();
                dgwIlan.DataSource = ara;
                dgwIlan.DataBind();
            }
        }
    }

}