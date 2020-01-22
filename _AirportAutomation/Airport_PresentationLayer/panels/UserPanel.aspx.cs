using Airport.Business.CustomExtension;
using Airport.Business.Repository.Concrete;
using Airport.DataEntities.Context;
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
    public partial class UserPanel : System.Web.UI.Page
    {
        int id;
        AirportServiceClient client = new AirportServiceClient();
        AirplaneConcrete aircon = new AirplaneConcrete();
        AirportContext airportcontext = new AirportContext();
        ExpeditionConcrete exp = new ExpeditionConcrete();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            Userlist(true);
        }
        public void Userlist(bool tt)
        {
            dgwUserExpedition.DataSource = client.GetExpedition();
            dgwUserExpedition.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            var _result = Convert.ToDecimal(txtMoney.Text);
            var _result2 = Convert.ToDateTime(txtWhereDate.Text);
            var _result3 = Convert.ToDateTime(txtToDate.Text);
            var Search = airportcontext.Expedition.Where(x => x.DepartureLocation == txtWhere.Text && x.RotationLocation == txtTo.Text && (x.Price) == _result && x.DepartureDatetime==_result2 && x.RotationDatetime == _result3).ToList();
            if(Search.Count==0)
            {
                this.Page.ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('ARADIĞINIZ SEFER BULUNMAMAKTADIR.')", true);
                Userlist(true);
            }
            else
            {
                dgwUserExpedition.DataSource = Search;
                dgwUserExpedition.DataBind();
            }
                    

        }
    }
}