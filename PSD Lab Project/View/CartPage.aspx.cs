using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class CartPage : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                RefreshGrid();
            }
        }

        protected void RefreshGrid()
        {
            MsUser user = Session["user"] as MsUser;
            List<object> list = CartController.getCart(user.UserId);
            if (list.FirstOrDefault() == null)
            {
                BtnCheckOut.Visible = false;
            }
            else
            {
                BtnCheckOut.Visible = true;
            }
            GridViewCart.DataSource = list;
            GridViewCart.DataBind();
        }


        protected void GridViewCart_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewCart.Rows[e.RowIndex];
            int quantity = Convert.ToInt32(row.Cells[2].Text);
            int price = Convert.ToInt32(row.Cells[1].Text);
            string name = row.Cells[0].Text;
            MsUser user = Session["user"] as MsUser;
            CartController.deleteCart(user.UserId, name, price, quantity);
            RefreshGrid();

        }

        protected void GridViewCart_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewCart.Rows[e.NewEditIndex];
            int price = Convert.ToInt32(row.Cells[1].Text);
            string name = row.Cells[0].Text;
            int stationid = StationeryController.findStationeryId(name, price);
            Response.Redirect("~/View/UpdateCartPage.aspx?stationid=" + stationid);
        }

        protected void BtnCheckOut_Click(object sender, EventArgs e)
        {
            MsUser user = Session["user"] as MsUser;
            TransactionController.doTransaction(user.UserId);
            RefreshGrid();
        }
    }
}