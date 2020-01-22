using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Airport_PresentationLayer
{
    public partial class AdminPanel : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnCustomerEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerPanel.aspx");
        }

        protected void btnExpeditionEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("ExpeditionPanel.aspx");
        }

        protected void btnTicketEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("TicketPanel.aspx");
        }

        protected void btnAirplaneEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AirplanePanel.aspx");
        }

        protected void btnPersonelEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("PersonelPanel.aspx");
        }

        protected void btnAboutUsEdit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AboutUs.aspx");
        }
    }
}