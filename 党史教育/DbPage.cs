using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace 党史教育
{
    public class DbPage : System.Web.UI.Page
    {
        private SqlConnection conn = null;
        protected SqlConnection Conn
        {
            get
            {
                if(conn == null)
                {
                    string connString = @"Server=.;Database=clique;User Id=dsjy;Password=123456";
                    conn = new SqlConnection(connString);
                }
                return conn;
            }
           
        }
    }
}