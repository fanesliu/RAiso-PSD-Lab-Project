using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Module;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class UpdateProfilePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = Session["user"] as MsUser;
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            if (!IsPostBack)
            {
                MsUser userSession = Session["user"] as MsUser;
                TxtName.Text = userSession.UserName;
                TxtDOB.Text = userSession.UserDOB.ToString("yyyy-MM-dd");
                DropDownListGender.Text = userSession.UserGender;
                TxtAddress.Text = userSession.UserAddress;
                TxtPassword.Text = userSession.UserPassword;
                TxtPhone.Text = userSession.UsePhone;

            }
        }

        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            String Name = TxtName.Text;
            String DOB = TxtDOB.Text;
            String Gender = DropDownListGender.Text;
            String Address = TxtAddress.Text;
            String Password = TxtPassword.Text;
            String Phone = TxtPhone.Text;

            MsUser userSession = Session["user"] as MsUser;

            Response<MsUser> response = UserController.doUpdate(userSession.UserId, Name, DOB, Gender, Address, Password, Phone);
            if (response.status == true)
            {
                LblWarning.Text = response.message;
                if (Request.Cookies["user_cookie"] != null)
                {
                    HttpCookie cookie = new HttpCookie("user_cookie");
                    cookie.Value = Name;
                    cookie.Expires = DateTime.Now.AddHours(1);
                    Response.Cookies.Add(cookie);
                }
            }
            else
            {
                LblWarning.Text = response.message;
            }
        }
    }
}