using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = @"Data Source=.;Initial Catalog=clique;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(connString);
            Tools.BuildlinkList("ywyl", 1, 5, 5, Literal1, Conn, false);
            Tools.BuildlinkList("dsbn", 2, 5, 5, Literal2, Conn, false);
            Tools.BuildlinkList("jnhd", 3, 5, 5, Literal3, Conn, false);
            Tools.BuildlinkList("zjyj", 4, 5, 5, Literal4, Conn, false);
            Tools.BuildlinkList("djsc", 5, 5, 5, Literal5, Conn, false);
        }
    }
}