using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class audit :DbPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            string sql1 = "select h.* ,t.type from daishenhe h JOIN type t ON h.typeid = t.id where h.id=" + id;
            SqlCommand cmd1 = new SqlCommand(sql1, Conn);
            Conn.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                title.Text = dr1["title"].ToString();
                leixing.Text = dr1["type"].ToString();
                article.Text = dr1["article"].ToString();
                source.Text = dr1["source"].ToString();
                date.Text = Convert.ToDateTime(dr1["date"]).ToShortDateString();
                tel.Text = dr1["tel"].ToString();
                email.Text = dr1["email"].ToString();
            }
            dr1.Close();
            Conn.Close();
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string id = Request.QueryString["id"];
            int typeid = 0;
            string sx = null;
            //string date = null;
            Conn.Open();
            string sql = "select h.typeid from daishenhe h JOIN type t ON h.typeid = t.id where h.id="+id;
            SqlCommand cmd = new SqlCommand(sql, Conn);
            typeid = (int)cmd.ExecuteScalar();
            Conn.Close();
            Tools.GetsxBytypeid(typeid, Conn);
            
            string dat = Convert.ToDateTime(date.Text).ToShortDateString();
            if (agree.Checked == true)
            {
                Conn.Open();
                string sql5 = "select * from relation where source = '" + source.Text + "'";
                SqlCommand cmd5 = new SqlCommand(sql5, Conn);
                SqlDataReader dr1 = cmd5.ExecuteReader();
               
                if (dr1.Read())
                {
                    dr1.Close();
                    string sql6 = "delete from daishenhe where id=" + id;
                    SqlCommand cmd6 = new SqlCommand(sql6, Conn);
                    cmd6.ExecuteNonQuery();
                    Conn.Close();
                }
                else
                {
                    
                    string sql1 = "insert into " + sx + " values('" + title.Text + "','" + dat + "','" + article.Text + "','" + source.Text + "'," + typeid + ")";
                    SqlCommand cmd1 = new SqlCommand(sql1, Conn);
                    cmd1.ExecuteNonQuery();
                    Conn.Close();

                    Conn.Open();
                    string sql2 = "insert into relation values( '" + source.Text + "','" + tel.Text + "','" + email.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(sql2, Conn);
                    cmd2.ExecuteNonQuery();
                    Conn.Close();

                    Conn.Open();
                    string sql3 = "delete from daishenhe where id=" + id;
                    SqlCommand cmd3 = new SqlCommand(sql3, Conn);
                    cmd3.ExecuteNonQuery();
                    Conn.Close();
                }
                    Response.Redirect("auditlinks.aspx");
            }   
            else
            {
                Conn.Open();
                string sql4 = "delete from daishenhe where id=" + id;
                SqlCommand cmd4 = new SqlCommand(sql4, Conn);
                cmd4.ExecuteNonQuery();
                Conn.Close();

                Response.Redirect("auditlinks.aspx");
            }
        }
    }
}