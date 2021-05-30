using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class links : DbPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            int typeid = int.Parse(Request.QueryString["typeid"]);
            string sx=Tools.GetsxBytypeid(typeid, Conn);
            Tools.BuildlinkList(sx,typeid, 20,20, Literal1, Conn,true);
        }
    }
}