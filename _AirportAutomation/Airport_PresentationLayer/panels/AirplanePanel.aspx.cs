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
    public partial class AirplanePanel : System.Web.UI.Page
    {
        AirportServiceClient client = new AirportServiceClient();
        AirportConcrete air = new AirportConcrete();
        AirplaneConcrete plane = new AirplaneConcrete();
         int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Userlist(true);
                ddlAirportId.SetDataSource<Airports>(air.ListForComboBox(), "AirportName", "AirportId");
                var item = plane.SelectedItemAirplane(id);
                if (id > 0)
                {
                   txtAirplaneName.Text =item.AirplaneName;
                    txtSeatingCapacity.Text= item.SeatingCapacity;
                    ddlAirportId.SelectedValue= Convert.ToString(item.AirportId); 
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
            var a = client.GetAirplane();
            dgwAirplane.DataSource = a;
            dgwAirplane.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (AirplaneKontrol())
            {
                var airplane = new Airplane
                {
                    AirplaneName = txtAirplaneName.Text,
                    SeatingCapacity = txtSeatingCapacity.Text,
                    AirportId = Convert.ToInt32(ddlAirportId.Text),
                };
                client.AddAirplane(airplane);
                string confirmValue = Request.Form["confirm_value"];

                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('EKLENDİ.')", true);
                    Userlist(true);
                }
                return;
            }
            else
            {
                return;
            }
        }
        #region Kontroller
        private bool AirplaneKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtAirplaneName.Text) || string.IsNullOrWhiteSpace(txtSeatingCapacity.Text) || string.IsNullOrWhiteSpace(ddlAirportId.Text))
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
                client.DeleteAirplane(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('UÇAK SİLİNİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek uçak bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AirplaneKontrol())
            {
                var airplane = new Airplane
                {
                    AirplaneId = id,
                   AirplaneName=txtAirplaneName.Text,
                   SeatingCapacity=txtSeatingCapacity.Text,
                   AirportId=Convert.ToInt16(ddlAirportId.Text),
                };
                client.EditAirplane(airplane);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('UÇAK GÜNCELLENMİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                return;
            }
        }
        private void Temizle()
        {
            txtAirplaneName.Text = string.Empty;
            txtSeatingCapacity.Text = string.Empty;
            ddlAirportId.SelectedIndex = -1;
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}