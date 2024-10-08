using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Model;
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
    public partial class InsertStationeryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = Session["user"] as MsUser;
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            else if (user.UserRole != "Admin")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

        }
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string price = TextBoxPrice.Text;
            string response = StationeryController.doInsert(name, price);
            LblWarning.Text = response;
        }
    }
}