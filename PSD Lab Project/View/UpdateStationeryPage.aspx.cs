using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class UpdateStationeryPage : System.Web.UI.Page
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
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);
                MsStationery station = StationeryController.findStationery(id);
                TextBoxName.Text = station.StationeryName;
                TextBoxPrice.Text = station.StationeryPrice.ToString();
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string name = TextBoxName.Text;
            string price = TextBoxPrice.Text;
            int id = Convert.ToInt32(Request.QueryString["id"]);

            string response = StationeryController.doUpdate(name, price, id);
            LblWarning.Text = response;

        }
    }
}