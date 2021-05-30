using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class auditlinks : DbPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string sx = "daishenhe";
            Tools.BuildauditlinkList(sx, Literal1, Conn);
        }
    }
}