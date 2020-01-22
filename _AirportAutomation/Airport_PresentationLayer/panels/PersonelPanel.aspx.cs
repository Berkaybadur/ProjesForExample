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

namespace Airport_PresentationLayer.panels
{
    public partial class PersonelPanel : System.Web.UI.Page
    {
        AirplaneConcrete airplane = new AirplaneConcrete();
        AirportServiceClient client = new AirportServiceClient();
        DistrictConcrete dist = new DistrictConcrete();
        TitleConcrete title = new TitleConcrete();
        PersonelConcrete per = new PersonelConcrete();
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Userlist(true);
                ddlAirplane.SetDataSource<Airplane>(airplane.ListForComboBox(), "AirplaneName", "AirplaneId");
                ddlDistrict.SetDataSource<District>(dist.ListForComboBox(), "DistrictName", "DistrictId");
                ddlTitle.SetDataSource<Title>(title.ListForComboBox(), "TitleName", "TitleId");
                var item = per.SelectedItemPersonel(id);
                if (id > 0)
                {
                    txtPersonelFirstName.Text = item.PersonelFirstName;
                    txtPersonelLastName.Text = item.PersonelLastName;
                    txtPersonelTc.Text = item.PersonelTc;
                    txtPhone.Text = item.PersonelPhoneNumber;
                    txtAddress.Text = item.PersonelAddress;
                    ddlAirplane.SelectedValue = Convert.ToString(item.AirplaneId);
                    ddlTitle.SelectedValue= Convert.ToString(item.TitleId);
                    ddlDistrict.SelectedValue= Convert.ToString(item.DistrictId);
                }
                else
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
        private void Userlist(bool tt)
        {
            var a = client.GetPersonel();
            dgwPersonel.DataSource = a;
            dgwPersonel.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (PersonelKontrol())
            {
                var personel = new Personel
                {
                    PersonelFirstName = txtPersonelFirstName.Text,
                    PersonelLastName = txtPersonelLastName.Text,
                    PersonelTc = txtPersonelTc.Text,
                    PersonelPhoneNumber = txtPhone.Text,
                    PersonelAddress = txtAddress.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    TitleId = Convert.ToInt32(ddlTitle.Text),
                    DistrictId = Convert.ToInt32(ddlDistrict.Text)
                };
                client.AddPersonel(personel);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('EKLENDİ.')", true);
                }
                return;
            }
            else
            {
                return;
            }
       
        }
        #region Kontroller
        private bool PersonelKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtPersonelTc.Text) || string.IsNullOrWhiteSpace(txtPersonelFirstName.Text) || string.IsNullOrWhiteSpace(txtPersonelLastName.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtPhone.Text) || string.IsNullOrWhiteSpace(ddlAirplane.Text) || string.IsNullOrWhiteSpace(ddlDistrict.Text) || string.IsNullOrWhiteSpace(ddlTitle.Text))
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                client.DeletePersonel(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('PERSONEL SİLİNİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek personel bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (PersonelKontrol())
            {
                var personel = new Personel
                {
                    PersonelId = id,
                    PersonelFirstName = txtPersonelFirstName.Text,
                    PersonelLastName = txtPersonelLastName.Text,
                    PersonelTc = txtPersonelTc.Text,
                    PersonelPhoneNumber = txtPhone.Text,
                    PersonelAddress = txtAddress.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    TitleId = Convert.ToInt32(ddlTitle.Text),
                    DistrictId = Convert.ToInt32(ddlDistrict.Text)
                };
                client.EditPersonel(personel);
                string confirmValue = Request.Form["confirm_value"];

                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('GÜNCELLENDİ.')", true);
                    Userlist(true);
                }
                return;
            }
            else
            {
                return;
            }
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtPersonelFirstName.Text = string.Empty;
            txtPersonelLastName.Text = string.Empty;
            txtPersonelTc.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;
            ddlAirplane.SelectedIndex = -1;
            ddlDistrict.SelectedIndex = -1;
            ddlTitle.SelectedIndex = -1;
        }
    }
}