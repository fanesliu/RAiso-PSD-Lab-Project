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
    public partial class UpdateCartPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = Session["user"] as MsUser;
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            else if (user.UserRole != "Customer")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            int stationid = Convert.ToInt32(Request.QueryString["stationid"]);
            MsStationery station = StationeryController.findStationery(stationid);

            LblName.Text = "Stationery Name : " + station.StationeryName;
            LblPrice.Text = "Stationery Price : " + station.StationeryPrice;

            if (!IsPostBack)
            {
                int quantity = CartController.findCartQuantity(user.UserId, stationid);
                TextBoxQuantity.Text = quantity.ToString();
            }
        }

        protected void BtnUpdate_Click(object sender, EventArgs e)
        {
            string quantity = TextBoxQuantity.Text;

            int stationid = Convert.ToInt32(Request.QueryString["stationid"]);
            MsUser user = Session["user"] as MsUser;
            string response = CartController.doUpdate(user.UserId, stationid, quantity);
            LblWarning.Text = response;

        }
    }
}