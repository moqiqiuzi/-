using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace 党史教育
{
    public static class Tools
    {
        public static string GetsxBytypeid(int typeid, SqlConnection Conn)
        {
            string sx = null;
            string sqlstring = "select sx from type where id=" + typeid;
            SqlCommand cmdstring = new SqlCommand(sqlstring, Conn);
            try
            {
                Conn.Open();
                sx = cmdstring.ExecuteScalar().ToString();
            }
            catch
            {

            }
            finally
            {
                Conn.Close();
            }
            return sx;
        }
        public static void BuildlinkList(string sx,int typeid,int num, int position, Literal literal,SqlConnection Conn, bool datebool)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>");
            string sql = "select top " + num + " * from (select top " + position + " * from " + sx + " order by date desc) as o order by date asc";
            //"select top " + num + "* from " + sx+" order by date desc";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(datebool==true)
                {
                    while (dr.Read())
                    {
                        string date = Convert.ToDateTime(dr["date"]).ToShortDateString();
                        sb.AppendFormat("<li><a href='xiangqing.aspx?typeid={0}&id={1}' target=_blank>{2}</a>{3}</li>", typeid, dr["id"], dr["title"], date);
                    }
                }
                else
                {
                    while (dr.Read())
                    {
                        sb.AppendFormat("<li><a href='xiangqing.aspx?typeid={0}&id={1}' target=_blank>{2}</a></li>", typeid, dr["id"], dr["title"]);
                    }
                }
                dr.Close();
                
            }
            catch
            {

            }
            finally
            {
                Conn.Close();
            }
            sb.Append("</ul>");
            literal.Text += sb.ToString();
        }

        public static string TrimByLenth(Object strObj, int maxLength)
        {
            string str = strObj == null ? string.Empty : strObj.ToString();
            if (str.Length > maxLength)
            {
                str = str.Substring(0, maxLength) + "...";
            }
            return str;
        }

        public static void BuildHomePhotoLink(string sx, int typeid,int position, Literal literal, SqlConnection Conn,string photo,int width,int height,bool titlebool)
        {
            StringBuilder sb = new StringBuilder();
            string sql = "select top 1 * from (select top " + position + " * from " + sx + " order by date desc) as o order by date asc";
            //"select top " + num + "* from " + sx+" order by date desc";
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //<a href="#" target=_blank></a>
                    sb.AppendFormat("<a href='xiangqing.aspx?typeid={0}&id={1}' target=_blank><img src='{2}' width='{3}' height='{4}' alt={5}/></a>", typeid, dr["id"], photo, width, height, dr["title"]);
                    if (titlebool == true)
                    {
                        sb.AppendFormat("<div style='width:200px;float:right;line-height:20px;'><a href='xiangqing.aspx?typeid={0}&id={1}' target=_blank>{2}</a><br /><a href='xiangqing.aspx?typeid={0}&id={1}' target=_blank>{3}</a></div>", typeid, dr["id"], dr["title"],TrimByLenth(dr["article"],65));
                    }
                }
                dr.Close();
                
            }
            catch
            {

            }
            finally
            {
                Conn.Close();
            }
            literal.Text += sb.ToString();
        }

       

        public static void BuildauditlinkList(string sx, Literal literal, SqlConnection Conn)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<ul>");
            string sql = "select * from " + sx;
            SqlCommand cmd = new SqlCommand(sql, Conn);
            try
            {
                Conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string date = Convert.ToDateTime(dr["date"]).ToShortDateString();
                    sb.AppendFormat("<li><a href='audit.aspx?id={0}' target=_blank>{1}</a>{2}</li>", dr["id"], dr["title"],date);
                }
                dr.Close();

            }
            catch
            {

            }
            finally
            {
                Conn.Close();
            }
            sb.Append("</ul>");
            literal.Text += sb.ToString();
        }

    }
}