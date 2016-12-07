using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Routing;

namespace cswb_mmblog
{
    public class Global : System.Web.HttpApplication
    {
        void RegisterRouters(RouteCollection routes)
        {
            //参数含义:  
            //第一个参数：路由名称--随便自己起  
            //第二个参数：路由规则  
            //第三个参数：该路由规则交给哪一个页面来处理  
            //routes.MapPageRoute("api", "api/{version}/user/get_uinfo/{id}", "~/Api/api_test.aspx");
            //...当然，您还可以添加更多路由规则

            //用户相关
            //routes.MapPageRoute("api", "api/{version}/blog/user/get_uinfo/{id}", "~/Api/UserInfo.aspx");
            routes.MapPageRoute("api_email_login", "api/{version}/blog/user/login/email={email}&pwd={pwd}&time={time}&sign={sign}", "~/Api/Login.aspx");
            routes.MapPageRoute("api_phone_login", "api/{version}/blog/user/login/phone={phone}&pwd={pwd}&time={time}&sign={sign}", "~/Api/Login.aspx");

            //文章相关
            routes.MapPageRoute("api_put_article", "api/{version}/blog/article/put_article", "~/Api/NewArticle.aspx");
            routes.MapPageRoute("api_get_article_by_id", "api/{version}/blog/article/get_article/{id}", "~/Api/Article.aspx");
            routes.MapPageRoute("api_get_articles", "api/{version}/blog/article/get_article", "~/Api/ArticleList.aspx");
            routes.MapPageRoute("api_get_articles_by_limits", "api/{version}/blog/article/get_article/limts={limts}", "~/Api/ArticleList.aspx");
        }

        protected void Application_Start(object sender, EventArgs e)
        {
            RegisterRouters(RouteTable.Routes);
        }
    }
}