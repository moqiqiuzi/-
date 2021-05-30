using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btRegister_Click(object sender, EventArgs e)
        {
            UserEntity ue = new UserEntity();
            ue.UserName = tbUsernameForRegister.Text.Trim();
            ue.Password = tbPassword1.Text.Trim();
            ue.Phone = tbPhone.Text.Trim();
            ue.Email = tbEmail.Text.Trim();

            UserBusiness ub = new UserBusiness();
            int i = ub.InsertUser(ue);
            if (i > 0)
            {
                Response.Write("<script>alert('注册成功！'),location.href='Index.aspx'</script>");
            }
        }

        protected void btCancel_Click(object sender, EventArgs e)
        {
            tbUsernameForRegister.Text = "";
            tbPassword1.Text = "";
            tbPassword2.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}