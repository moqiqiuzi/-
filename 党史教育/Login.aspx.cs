using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text.Trim() == "" || tbPassword.Text.Trim() == "")
            {
                Response.Write("<script>alert('用户名和密码不能为空！')</script>");
            }
            else
            {
                UserEntity ue = new UserEntity();
                ue.UserName = tbUsername.Text.Trim();
                ue.Password = tbPassword.Text.Trim();
                UserBusiness ub = new UserBusiness();
                int count = ub.UserAndPWD(ue);
                if (count > 0)
                {
                    Session["user"] = tbUsername.Text.Trim();
                    Response.Write("<script>alert('登录成功'),location.href='index.aspx'</script>");

                }
                else
                {
                    Response.Write("<script>alert('用户名或密码错误')</script>");
                }
            }
        }

        protected void btRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void btBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
    }
}