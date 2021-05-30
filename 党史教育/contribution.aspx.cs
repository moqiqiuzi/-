using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class contribution : DbPage
    {
        public static Boolean flag = false;
        protected void Page_Load(object sender, EventArgs e)
        { 
            if(flag)
            {
                    title.Text = Session["atitle"].ToString();
                    article.Text = Session["aarticle"].ToString();
                    author.Text = Session["aauthor"].ToString();
                    ddlType.SelectedValue = Session["addlType"].ToString();
                    phone.Text = Session["aphone"].ToString();
                    email.Text = Session["aemail"].ToString();
                    flag = false;
            }
            String sql = "SELECT ID,TYPE FROM type";
            FillDropDownList(sql, ddlType, Conn);
        }

        public static void FillDropDownList(String sql, DropDownList ddl, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                ddl.Items.Clear();
                while (dr.Read())
                {
                    ddl.Items.Add(new ListItem(dr[1].ToString(), dr[0].ToString()));
                }
                dr.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            flag = true;
            Session["atitle"] = title.Text;
            Session["aarticle"] = article.Text;
            Session["aauthor"] = author.Text;
            Session["addlType"] = ddlType.SelectedValue;
            Session["aphone"] = phone.Text;
            Session["aemail"] = email.Text;
            Response.Redirect("co.aspx");
        }

        protected void btn2_Click(object sender, EventArgs e)
        {
            /*这里写标签，和数据库连，用asp:DropDownList*/
            long ArticleId = -1;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Conn;
            Conn.Open();
            ArticleId = AddArticle(cmd);
            if (ArticleId != -1)
            {
                Response.Write("<script>alert('已提交');window.location.href='index.aspx'</script>");
            }
            else
            {
                Response.Write("<script>alert('提交失败！');window.location.href='contribution.aspx'</script>");
            }
        }

        private long AddArticle(SqlCommand cmd)
        {
            try
            {
                long ArticleId = -1;
                cmd.CommandText = String.Format(@"INSERT INTO daishenhe (title, date, article, source, 
                        typeid, tel, email)
                      VALUES ('{0}', '{1}', '{2}','{3}', 
                        '{4}', '{5}', '{6}');
                      SELECT @@IDENTITY",
                  title.Text, DateTime.Now.ToString(), article.Text, author.Text,
                  ddlType.SelectedValue, phone.Text, email.Text);
                object newId = cmd.ExecuteScalar();
                if (newId != null)
                {
                    ArticleId = Convert.ToInt64(newId);
                }
                return ArticleId;
            }
            catch
            {
                return -1;
            }
        }
    }
}