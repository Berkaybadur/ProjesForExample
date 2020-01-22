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
    public partial class TicketPanel : System.Web.UI.Page
    {
        int id;
        AirplaneConcrete airplane = new AirplaneConcrete();
        AirportConcrete airport = new AirportConcrete();
        AirportServiceClient client = new AirportServiceClient();
        CustomerConcrete cust = new CustomerConcrete();
        ExpeditionConcrete exp = new ExpeditionConcrete();
        TicketConcrete tic = new TicketConcrete();
        ClassConcrete con = new ClassConcrete();
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Convert.ToInt32(Request.QueryString["id"]);
            if (!IsPostBack)
            {
                Userlist(true);
                ddlAirplane.SetDataSource<Airplane>(airplane.ListForComboBox(), "AirplaneName", "AirplaneId");
                ddlAirports.SetDataSource<Airports>(airport.ListForComboBox(), "AirportName", "AirportId");
                ddlCustomer.SetDataSource<Customers>(cust.ListForComboBox(), "CustomerName", "CustomerId");
                ddlExpedition.SetDataSource<Expedition>(exp.ListForComboBox(), "RotationLocation", "ExpeditionId");
                ddlClass.SetDataSource<Classes>(con.ListForComboBox(), "ClassName", "ClassesId");
                var item = tic.SelectedItemTicket(id);
                if (id > 0)
                {
                    txtNumberOfSeats.Text = item.NumberOfSeats;
                    ddlAirplane.SelectedValue= Convert.ToString(item.AirplaneId);
                    ddlAirports.SelectedValue = Convert.ToString(item.AirportsId);
                    ddlCustomer.SelectedValue = Convert.ToString(item.CustomerId);
                    ddlExpedition.SelectedValue = Convert.ToString(item.ExpeditionId);
                    ddlClass.SelectedValue = Convert.ToString(item.ClassesId);
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
            var a = client.GetTicket();
            dgwTicket.DataSource = a;
            dgwTicket.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (TicketKontrol())
            {
                var ticket = new Ticket
                {
                   NumberOfSeats=txtNumberOfSeats.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    AirportsId = Convert.ToInt32(ddlAirports.Text),
                    CustomerId = Convert.ToInt32(ddlCustomer.Text),
                    ExpeditionId = Convert.ToInt32(ddlExpedition.Text),
                    ClassesId = Convert.ToInt32(ddlClass.Text),
                };
                client.AddTicket(ticket);
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
        private bool TicketKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtNumberOfSeats.Text) || string.IsNullOrWhiteSpace(ddlAirplane.Text) || string.IsNullOrWhiteSpace(ddlAirports.Text) || string.IsNullOrWhiteSpace(ddlCustomer.Text) || string.IsNullOrWhiteSpace(ddlExpedition.Text) || string.IsNullOrWhiteSpace(ddlClass.Text))
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
                client.DeleteTicket(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BİLET SİLİNİŞTİR.')", true);
                    Userlist(true);
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek bilet bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (TicketKontrol())
            {
                var ticket = new Ticket
                {
                    TicketId = id,
                    NumberOfSeats = txtNumberOfSeats.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    AirportsId = Convert.ToInt32(ddlAirports.Text),
                    CustomerId = Convert.ToInt32(ddlCustomer.Text),
                    ExpeditionId = Convert.ToInt32(ddlExpedition.Text),
                    ClassesId=Convert.ToInt32(ddlClass.Text),
                };
                client.EditTicket(ticket);
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
            txtNumberOfSeats.Text = string.Empty;
            ddlAirplane.SelectedIndex = -1;
            ddlAirports.SelectedIndex = -1;
            ddlClass.SelectedIndex = -1;
            ddlCustomer.SelectedIndex = -1;
            ddlExpedition.SelectedIndex = -1;
        }
    }
}