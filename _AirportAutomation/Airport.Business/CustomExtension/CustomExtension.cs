using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace Airport.Business.CustomExtension
{
    public static class CustomExtension
    {
        public static void SetDataSource<T>(this DropDownList ddl, List<T> dataSource, string displayMember, string valueMember)
        {
            ddl.DataSource = dataSource;
            ddl.DataTextField= displayMember;
            ddl.DataValueField = valueMember;
            ddl.DataBind();
        }
    }
}
