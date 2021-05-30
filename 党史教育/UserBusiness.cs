using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace 党史教育
{
    public class UserBusiness
    {
        public int UserAndPWD(UserEntity ue)
        {
            string sqlText = "select count(*)from Users where username=@username and password=@password";
            string[] paras = { "@username", "@password" };
            object[] values = { ue.UserName, ue.Password };
            int i = Convert.ToInt32(DA.GetOneData(sqlText, CommandType.Text, paras, values));
            return i;
        }
        public int InsertUser(UserEntity ue)
        {
            string sqlText = "insert into tb_user values(@username,@password,@phone,@email)";
            string[] paras = { "@username", "@password", "@address", "@phone", "@email" };
            object[] values = { ue.UserName, ue.Password, ue.Phone, ue.Email };
            int i = DA.ExecuteSql(sqlText, CommandType.Text, paras, values);
            return i;
        }
    }
}