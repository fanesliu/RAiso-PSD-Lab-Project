using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class NavigationBar : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                BtnHomePage.Visible = true;
                BtnLogin.Visible = true;
                BtnRegister.Visible = true;
                BtnCart.Visible = false;
                BtnTransaction.Visible = false;
                BtnTransactionReport.Visible = false;
                BtnUpdate.Visible = false;
                BtnLogOut.Visible = false;

            }
            else
            {
                MsUser user;
                if (Session["user"] == null)
                {
                    string username = Request.Cookies["user_cookie"].Value;
                    user = UserController.findUserbyUsername(username);
                    Session["user"] = user;
                }
                else
                {
                    user = Session["user"] as MsUser;
                }

                if (user.UserRole == "Customer")
                {
                    BtnHomePage.Visible = true;
                    BtnLogin.Visible = false;
                    BtnRegister.Visible = false;
                    BtnCart.Visible = true;
                    BtnTransaction.Visible = true;
                    BtnTransactionReport.Visible = false;
                    BtnUpdate.Visible = true;
                    BtnLogOut.Visible = true;
                }
                else if (user.UserRole == "Admin")
                {
                    BtnHomePage.Visible = true;
                    BtnLogin.Visible = false;
                    BtnRegister.Visible = false;
                    BtnCart.Visible = false;
                    BtnTransaction.Visible = false;
                    BtnTransactionReport.Visible = true;
                    BtnUpdate.Visible = true;
                    BtnLogOut.Visible = true;
                }
            }
        }

        protected void BtnHomePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/RegisterPage.aspx");

        }

        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/LoginPage.aspx");
        }

        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            HttpCookie cookie = Request.Cookies["user_cookie"];
            if (cookie != null)
            {
                cookie = Request.Cookies["user_cookie"];
                cookie.Expires = DateTime.Now.AddDays(-1);
                Response.Cookies.Add(cookie);
            }

            Response.Redirect("~/View/HomePage.aspx");
        }

        protected void BtnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/CartPage.aspx");
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/UpdateProfilePage.aspx");
        }

        protected void BtnTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/TransactionHistoryPage.aspx");
        }

        protected void BtnTransactionReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/ReportingPage.aspx");
        }
    }
}