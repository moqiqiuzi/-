using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class adminUsersMessage : DbPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BuildCategoryList();
        }


        private void BuildCategoryList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<table>");
            sb.Append("<tr>");
            sb.Append("<th>用户ID</th>");
            sb.Append("<th>用户名</th>");
            sb.Append("<th>电话号码</th>");
            sb.Append("<th>电子邮箱</th>");
            sb.Append("<th></th><th></th>");
            sb.Append("</tr>");
            string sql = "SELECT * FROM Users";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
            Conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                sb.Append("<tr>");
                sb.AppendFormat("<td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td>", dr["UserID"], dr["UserName"], dr["Phone"], dr["Email"]);
                sb.AppendFormat("<td><a href = 'Users.aspx?id={0}'>查看</a>", dr["UserID"]);
                sb.Append("</tr>");
            }
            dr.Close();
             }
             catch
             {
                 sb.Append("<tr><td colspan='5'>读取数据库失败!</td></tr>");
             }
             finally
             {
                 Conn.Close();
             }
            sb.Append("</table>");
            userMessage.Text = sb.ToString();
        }
    }
}