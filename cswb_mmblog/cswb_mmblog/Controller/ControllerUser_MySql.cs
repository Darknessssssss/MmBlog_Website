using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cswb_mmblog.Models.Interface;
using cswb_mmblog.Models;
using MySql.Data.MySqlClient;
using cswb_mmblog.Helper;

namespace cswb_mmblog.Controller
{
    public class ControllerUser_MySql : ControllerUser
    {
        public override IWebMsg EmailLogin(string email, string pwd)
        {
            user usr = new user();
            usr.val = new Dictionary<string, string>();
            string reqSQL = "SELECT* FROM `t_user` where email = '" + email + "' AND password = '" + pwd + "'";
            using (MySqlConnection connection = new MySqlConnection(System.Web.Configuration.WebConfigurationManager.AppSettings["MySqlCon"]))
            {
                using (MySqlCommand cmd = new MySqlCommand(reqSQL, connection))
                {
                    try
                    {
                        connection.Open();
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            if (reader.HasRows)
                            {
                                usr.id = reader.GetInt32(0);
                                usr.email = reader.GetString(1);
                                usr.phone = reader.GetString(2);
                                usr.nickname = reader.GetString(3);
                                usr.password = reader.GetString(4);
                                usr.type = reader.GetInt32(5);
                                usr.faceurl = reader.GetString(6);
                                usr.regtime = TimeHelper.StampToDateTime(reader.GetString(7));
                                usr.llitime = TimeHelper.StampToDateTime(reader.GetString(8));
                                usr.llide = reader.GetString(9);
                                usr.lliip = reader.GetString(10);
                                //成功
                                usr.msg = "success";
                                usr.ret = 1;
                                return usr;
                            }
                        }
                        return new rmsg() { ret = 0 ,msg = "cant find target.",val = new Dictionary<string, string>()};
                    }
                    catch (MySql.Data.MySqlClient.MySqlException exp)
                    {
                        connection.Close();
                        throw exp;
                    }
                }
            }
        }

        public override IWebMsg NicknameLogin(string nickname, string pwd)
        {
            throw new NotImplementedException();
        }

        public override IWebMsg PhoneLogin(string phone, string pwd)
        {
            return new user();
            throw new NotImplementedException();
        }
    }
}
