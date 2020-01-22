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
    public partial class ExpeditionPanel : System.Web.UI.Page
    {
        int id;
        AirportServiceClient client = new AirportServiceClient();
        AirplaneConcrete airplane = new AirplaneConcrete();
        ExpeditionConcrete exp = new ExpeditionConcrete();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Userlist(true);
                ddlAirplaneId.SetDataSource<Airplane>(airplane.ListForComboBox(), "AirplaneName", "AirplaneId");
                var item = exp.SelectedItemExpedition(id);
                if (id > 0)
                {
                    txtDepartureLocation.Text = item.DepartureLocation;
                    txtRotationLocation.Text = item.RotationLocation;
                    txtDepartureDatetime.Text = Convert.ToString(item.DepartureDatetime);
                    txtRotationDatetime.Text = Convert.ToString(item.RotationDatetime);
                    ddlAirplaneId.SelectedValue = Convert.ToString(item.AirplaneId);
                    txtPrice.Text = Convert.ToString(item.Price);
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
            var a = client.GetExpedition();
            dgwExpedition.DataSource = a;
            dgwExpedition.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (ExpeditionKontrol())
            {
                var expedition = new Expedition
                {
                    DepartureLocation = txtDepartureLocation.Text,
                    RotationLocation = txtRotationLocation.Text,
                    DepartureDatetime = Convert.ToDateTime(txtDepartureDatetime.Text),
                    RotationDatetime = Convert.ToDateTime(txtRotationDatetime.Text),
                    AirplaneId = Convert.ToInt32(ddlAirplaneId.Text),
                    Price = Convert.ToDecimal(txtPrice.Text),
                };
                client.AddExpedition(expedition);
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
        private bool ExpeditionKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtDepartureLocation.Text) || string.IsNullOrWhiteSpace(txtRotationLocation.Text) || string.IsNullOrWhiteSpace(txtDepartureDatetime.Text) || string.IsNullOrWhiteSpace(txtRotationDatetime.Text) || string.IsNullOrWhiteSpace(ddlAirplaneId.Text))
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
                client.DeleteExpedition(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('SEFER SİLİNİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek sefer bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ExpeditionKontrol())
            {
                var expedition = new Expedition
                {
                    ExpeditionId = id,
                    DepartureLocation = txtDepartureLocation.Text,
                    RotationLocation = txtRotationLocation.Text,
                    DepartureDatetime = Convert.ToDateTime(txtDepartureDatetime.Text),
                    RotationDatetime = Convert.ToDateTime(txtRotationDatetime.Text),
                    AirplaneId = Convert.ToInt32(ddlAirplaneId.Text),
                    Price = Convert.ToDecimal(txtPrice.Text),
                };
                client.EditExpedition(expedition);
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
            txtDepartureDatetime.Text = string.Empty;
            txtDepartureLocation.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtRotationDatetime.Text = string.Empty;
            txtRotationLocation.Text = string.Empty;
            ddlAirplaneId.SelectedIndex = -1;
            
        }
    }
}