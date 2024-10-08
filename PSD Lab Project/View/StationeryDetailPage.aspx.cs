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
    public partial class StationeryDetailPage : System.Web.UI.Page
    {
        DatabaseEntities db = DatabaseSingleton.GetInstances();
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(Request.QueryString["id"]);
            MsStationery station = StationeryController.findStationery(id);
            LblStationName.Text = station.StationeryName;
            LblStationPrice.Text = station.StationeryPrice.ToString();

            MsUser user = Session["user"] as MsUser;
            if (Session["user"] == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }

            if (user.UserRole == "Customer")
            {
                BtnCart.Visible = true;
                LblQuantity.Visible = true;
                TextBoxQuantity.Visible = true;
            }
            else if (user.UserRole == "Admin")
            {
                BtnCart.Visible = false;
                LblQuantity.Visible = false;
                TextBoxQuantity.Visible = false;
            }

        }

        protected void BtnCart_Click(object sender, EventArgs e)
        {
            string quantity = TextBoxQuantity.Text;
            int stationid = Convert.ToInt32(Request.QueryString["id"]);
            MsUser user = Session["user"] as MsUser;
            string response = CartController.doInsert(user.UserId, stationid, quantity);
            LblWarning.Text = response;
        }
    }
}