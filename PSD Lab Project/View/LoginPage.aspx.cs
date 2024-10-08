using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Module;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            string Name = TxtName.Text;
            string Password = TxtPassword.Text;

            Response<MsUser> ableToLogin = UserController.doLogin(Name, Password);

            if (ableToLogin.status == true)
            {
                Session["user"] = ableToLogin.payload;
                if (CheckBoxCookies.Checked == true)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = Name;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
                Response.Redirect("~/View/HomePage.aspx");
            }
            else
            {
                LblWarning.Text = ableToLogin.message;
            }
        }
    }
}