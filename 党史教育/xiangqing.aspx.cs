using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public partial class xiangqing : DbPage
    {
            protected void Page_Load(object sender, EventArgs e)
            {
                int typeid = int.Parse(Request.QueryString["typeid"]);
                int id = int.Parse(Request.QueryString["id"]);
                
                
                string sx = Tools.GetsxBytypeid(typeid, Conn);
      
                SqlCommand cmd = new SqlCommand();  //Sql命令对象
                cmd.Connection = Conn; //设置数据库连接属性
                try
                {
                    Conn.Open();  //打开连接
                    String sql = "SELECT  title, date,article,id FROM "+sx+" where id="+id;
                    cmd.CommandText = sql;
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        LbName.Text = dr.GetString(0); //"Name"
                        LbTime.Text = dr.IsDBNull(1) ? "" : dr.GetDateTime(1).ToShortDateString();
                        Lbarticle.Text = dr.IsDBNull(2) ? "" : dr.GetString(2);
                        
                    }

                    dr.Close();
                }
            finally
                {
                    Conn.Close();
                }

            SqlCommand cmd1 = new SqlCommand();
            SqlCommand cmd2 = new SqlCommand(); //Sql命令对象
            cmd1.Connection = Conn; //设置数据库连接属性
            try
            {
                Conn.Open();  //打开连接
                String sql1="select sourceid from " + sx + " where id =" +id;
                cmd1.CommandText = sql1;
                string sourceid =cmd1.ExecuteScalar().ToString();
                Conn.Close();
                cmd2.Connection = Conn;
                Conn.Open();
                String sql2 = "select source from " + sx + " join relation on " + sx + ".sourceid=relation.id where " + sx + ".id=" + id;
                cmd2.CommandText = sql2;
                if (sourceid!=null && sourceid!="")
                {
                    LbSourse.Text = "| 来源："+ cmd2.ExecuteScalar().ToString();
                }
                else
                {
                    LbSourse.Text = "";
                }
                
                
            }
            finally
            {
                Conn.Close();
            }

            ShowType(typeid);
        }

    private void ShowType(int typeid)
    {
        String sql = String.Format("select type from type where id={0}", typeid);
        SqlCommand cmd = new SqlCommand(sql, Conn);
        try
        {
            Conn.Open();
                lnkClassification.Text = cmd.ExecuteScalar().ToString();
        }
        finally
        {
            Conn.Close();
        }
    }

}
}
