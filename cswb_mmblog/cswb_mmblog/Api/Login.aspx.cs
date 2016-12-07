using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using cswb_mmblog.Models;
using Newtonsoft.Json;
using cswb_mmblog.Controller;
using cswb_mmblog.Helper;

namespace cswb_mmblog.Api
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    string email = Page.RouteData.Values["email"] as string;
                    string phonenumber = Page.RouteData.Values["email"] as string;
                    string pwd = Page.RouteData.Values["pwd"] as string;
                    DateTime dt = TimeHelper.StampToDateTime(Page.RouteData.Values["time"] as string);
                    string sign = Page.RouteData.Values["sign"] as string;
                    if (email != null && email != string.Empty)
                    {
                        Response.Write(JsonConvert.SerializeObject(new ControllerUser_MySql().EmailLogin(email, pwd)));
                    } else if (phonenumber != null && phonenumber != string.Empty)
                    {
                        Response.Write(JsonConvert.SerializeObject(new ControllerUser_MySql().PhoneLogin(email, pwd)));
                        Response.Write("{\"ret\":1}");
                    }
                    else
                    {
                        Response.Write("{\"ret\":0,\"msg\":\"Response parameter error.\"}");
                    }
                }
                catch(Exception ex)
                {
                    Response.Write("{\"ret\":0,\"msg\":\"Server code Exception." + ex.Message +"\"}");
                }
            }
            else
            {
                Response.Write("{\"ret\":0,\"msg\":\"Response is postback.\"}");
            }
        }
    }
}