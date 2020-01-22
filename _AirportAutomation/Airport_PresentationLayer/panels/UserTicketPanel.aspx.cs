using Airport.Business.CustomExtension;
using Airport.Business.Repository.Concrete;
using Airport.DataEntities.Entities;
using Airport_PresentationLayer.AirportReferences;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airport_PresentationLayer.panels
{
    public partial class UserTicketPanel : System.Web.UI.Page
    {
        int id;
        AirplaneConcrete airplane = new AirplaneConcrete();
        AirportConcrete airport = new AirportConcrete();
        AirportServiceClient client = new AirportServiceClient();
        CustomerConcrete cust = new CustomerConcrete();
        ExpeditionConcrete exp = new ExpeditionConcrete();
        TicketConcrete tic = new TicketConcrete();
        ClassConcrete con = new ClassConcrete();
        UserTicketConcrete user = new UserTicketConcrete();
        string kullaniciAdi = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                id = Convert.ToInt32(Request.QueryString["id"]);
                kullaniciAdi = Session["username"].ToString();
                lblKullanici.Text = kullaniciAdi;
                if (!IsPostBack)
                {
                    Userlist(true);
                    //ddlAirplane.SetDataSource<Airplane>(airplane.ListForComboBox(), "AirplaneName", "AirplaneId");
                    //ddlAirports.SetDataSource<Airports>(airport.ListForComboBox(), "AirportName", "AirportId");
                    //ddlExpedition.SetDataSource<Expedition>(exp.ListForComboBox(), "RotationLocation", "ExpeditionId");
                    FillExpedition();
                    ddlClass.SetDataSource<Classes>(con.ListForComboBox(), "ClassName", "ClassesId");
                    var item = user.SelectedItemUserTicket(id);
                    if (id > 0)
                    {
                        if (Convert.ToString(item.CustomerName) == kullaniciAdi)
                        {
                            FillAirplane(id);
                            FillAirports(id);
                            txtNumberOfSeats.Text = item.NumberOfSeats;
                            ddlAirplane.SelectedValue = Convert.ToString(item.AirplaneId);
                            ddlAirports.SelectedValue = Convert.ToString(item.AirportsId);
                            ddlExpedition.SelectedValue = Convert.ToString(item.ExpeditionId);
                            ddlClass.SelectedValue = Convert.ToString(item.ClassesId);
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
        private void Userlist(bool tt)
        {
            var a = client.GetUserTicket();
            dgwTicket.DataSource = a;
            dgwTicket.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (UserTicketKontrol())
            {
                var ticket = new UserTicket
                {
                    CustomerName = kullaniciAdi,
                    NumberOfSeats = txtNumberOfSeats.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    AirportsId = Convert.ToInt32(ddlAirports.Text),
                    ExpeditionId = Convert.ToInt32(ddlExpedition.Text),
                    ClassesId = Convert.ToInt32(ddlClass.Text),
                };
                client.AddUserTicket(ticket);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('EKLENDİ.')", true);
                    Userlist(true);
                    Clear();
                }
                return;
            }
            else
            {
                return;
            }
        }
        private bool UserTicketKontrol()
        {
            //Kontrol
            if (string.IsNullOrWhiteSpace(txtNumberOfSeats.Text) || string.IsNullOrWhiteSpace(ddlAirplane.Text) || string.IsNullOrWhiteSpace(ddlAirports.Text) || string.IsNullOrWhiteSpace(ddlExpedition.Text) || string.IsNullOrWhiteSpace(ddlClass.Text))
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

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                client.DeleteUserTicket(id);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('BİLET SİLİNİŞTİR.')", true);
                    Userlist(true);
                    Clear();
                }
            }
            else
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Silinecek bilet bulunamamıştır!')", true);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (UserTicketKontrol())
            {
                var ticket = new UserTicket
                {
                    TicketId = id,
                    CustomerName = kullaniciAdi,
                    NumberOfSeats = txtNumberOfSeats.Text,
                    AirplaneId = Convert.ToInt32(ddlAirplane.Text),
                    AirportsId = Convert.ToInt32(ddlAirports.Text),
                    ExpeditionId = Convert.ToInt32(ddlExpedition.Text),
                    ClassesId = Convert.ToInt32(ddlClass.Text),
                };
                client.EditUserTicket(ticket);
                string confirmValue = Request.Form["confirm_value"];
                if (confirmValue != "Yes")
                {
                    this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('GÜNCELLENDİ.')", true);
                    Userlist(true);
                    Clear();
                }
                return;
            }
            else
            {
                return;
            }
        }
        private void Clear()
        {
            txtNumberOfSeats.Text = string.Empty;
            ddlAirplane.SelectedIndex = -1;
            ddlAirports.SelectedIndex = -1;
            ddlClass.SelectedIndex = -1;
            ddlExpedition.SelectedIndex = -1;
        }

        private void FillAirports(int airportId)
        {
            string strConn = ConfigurationManager.ConnectionStrings["AirportDBConnectionConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT AirportId, AirportName FROM Airports";
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlAirports.DataSource = objDs.Tables[0];
                ddlAirports.DataTextField = "AirportName";
                ddlAirports.DataValueField = "AirportId";
                ddlAirports.DataBind();
                ddlAirports.Items.Insert(0, "Seçiniz..");
            }
            else
            {

            }
        }
        private void FillAirportss()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AirportDBConnectionConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT AirportId, AirportName FROM Airports";
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlAirports.DataSource = objDs.Tables[0];
                ddlAirports.DataTextField = "AirportName";
                ddlAirports.DataValueField = "AirportId";
                ddlAirports.DataBind();
                ddlAirports.Items.Insert(0, "Seçiniz..");
            }
            else
            {

            }
        }

        private void FillAirplane(int airplaneId)
        {
            string strConn = ConfigurationManager.ConnectionStrings["AirportDBConnectionConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT AirplaneId, AirplaneName FROM Airplane";
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlAirplane.DataSource = objDs.Tables[0];
                ddlAirplane.DataTextField = "AirplaneName";
                ddlAirplane.DataValueField = "AirplaneId";
                ddlAirplane.DataBind();
                ddlAirplane.Items.Insert(0, "Seçiniz..");
            }
            else
            {

            }

        }
        private void FillExpedition()
        {
            string strConn = ConfigurationManager.ConnectionStrings["AirportDBConnectionConnectionString"].ConnectionString;
            SqlConnection con = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ExpeditionId, RotationLocation FROM Expedition";
            DataSet objDs = new DataSet();
            SqlDataAdapter dAdapter = new SqlDataAdapter();
            dAdapter.SelectCommand = cmd;
            con.Open();
            dAdapter.Fill(objDs);
            con.Close();
            if (objDs.Tables[0].Rows.Count > 0)
            {
                ddlExpedition.DataSource = objDs.Tables[0];
                ddlExpedition.DataTextField = "RotationLocation";
                ddlExpedition.DataValueField = "ExpeditionId";
                ddlExpedition.DataBind();
                ddlExpedition.Items.Insert(0, "Seçiniz..");
            }
            else
            {

            }

        }


        protected void ddlAirports_SelectedIndexChanged1(object sender, EventArgs e)
        {
            var deger = Convert.ToInt32(ddlAirports.SelectedValue.ToString());
            var AirplaneId = Convert.ToInt32(ddlAirports.SelectedValue.ToString());
            FillAirplane(AirplaneId);
          
        }

        protected void ddlExpedition_SelectedIndexChanged(object sender, EventArgs e)
        {
            var AirportsId = Convert.ToInt32(ddlExpedition.SelectedValue.ToString());
            FillAirports(AirportsId);
        }
    }
}