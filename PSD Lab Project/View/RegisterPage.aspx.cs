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
    public partial class RegisterPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("~/View/HomePage.aspx");
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

            Response<MsUser> Response = UserController.doRegister(Name, DOB, Gender, Address, Password, Phone);
            if(Response.status == true)
            {
                LblWarning.Text = Response.message;
            }
            else
            {
                LblWarning.Text = Response.message;
            }
        }
    }
}