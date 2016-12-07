using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cswb_mmblog.Models;
using cswb_mmblog.Models.Interface;

namespace cswb_mmblog.Controller
{
    public abstract class ControllerUser
    {
        public abstract IWebMsg EmailLogin(string email,string pwd);
        public abstract IWebMsg PhoneLogin(string phone,string pwd);
        public abstract IWebMsg NicknameLogin(string nickname,string pwd);
    }
}
