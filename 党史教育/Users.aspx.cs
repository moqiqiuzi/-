using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class Users1 : DbPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                //Conn.Open();
                //string sql1 = "select * from Users where UserID=" + id;
                String sql = string.Format("SELECT * FROM Users WHERE UserID ={0}", Request["id"]);
                SqlCommand cmd = new SqlCommand(sql, Conn);
                //ppp.Text = cmd.CommandText;
                //SqlDataReader dr1 = cmd.ExecuteReader();
                try
                {
                    Conn.Open();
                    SqlDataReader dr1 = cmd.ExecuteReader();
                    if (dr1.Read())
                    {
                        userName.Text = dr1["UserName"].ToString();
                        password.Text = dr1["Password"].ToString();
                        tel.Text = dr1["Phone"].ToString();
                        email.Text = dr1["Email"].ToString();
                    }
                    dr1.Close();
                }
                catch
                {
                    ppp.Text = "读取数据失败！";
                }
                finally
                {
                    Conn.Close();
                }
            }
        }

        protected void update_Click(object sender, EventArgs e)
        {
            ///string sql = "update Users set UserName='" + userName.Text + "',Password='" + password.Text + "',Phone='" + tel.Text + "',Email='" + email.Text + "'where UserID=122";
            string sql = string.Format("UPDATE Users SET UserName = '{0}',Password='{1}',Phone='{2}',Email='{3}' Where UserID={4}", userName.Text, password.Text , tel.Text, email.Text, Request["id"]);
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}