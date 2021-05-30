using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace 党史教育
{
    public class DA
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;
        static SqlDataAdapter sda = null;
        static DataSet ds = null;
        static DA()
        {
            conn = new SqlConnection(@"server=.;database=clique;trusted_connection=true;");
            cmd = new SqlCommand();
            cmd.Connection = conn;
        }


        public static object GetOneData(string sqlText, CommandType commandType, string[] paraNames, object[] paraValues)
        {
            object result;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            result = cmd.ExecuteScalar();
            cmd.Parameters.Clear();
            conn.Close();
            return result;
        }
        public static int ExecuteSql(string sqlText, CommandType commandType, string[] paraNames, object[] paraValues)
        {
            int count;
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.CommandType = commandType;
            cmd.CommandText = sqlText;
            if (paraNames != null)
            {
                for (int i = 0; i < paraNames.Length; i++)
                    cmd.Parameters.AddWithValue(paraNames[i], paraValues[i]);
            }
            count = cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            conn.Close();
            return count;
        }

    }

}