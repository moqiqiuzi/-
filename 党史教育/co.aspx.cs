using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class co : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            contribution.flag = true;
            title.Text = Session["atitle"].ToString();
            article.Text = Session["aarticle"].ToString();
        }

        protected void Unnamed2_Click(object sender, EventArgs e)
        {

            Response.Redirect("contribution.aspx");
        }
    }
}