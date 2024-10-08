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
    public partial class TransactionHistoryPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MsUser user = Session["user"] as MsUser;
            if(user == null)
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            if(user.UserRole != "Customer")
            {
                Response.Redirect("~/View/HomePage.aspx");
            }
            LblUsername.Text = user.UserName;
            if (!IsPostBack)
            {
                RefreshGrid();
            }
        }

        protected void RefreshGrid()
        {
            MsUser user = Session["user"] as MsUser;
            List<TransactionHeader> transaction = TransactionController.getTransactionHeader(user.UserId);
            if (transaction != null)
            {
                GridViewStationery.DataSource = transaction;
                GridViewStationery.DataBind();
            }
        }

        protected void GridViewStationery_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewStationery.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/View/TransactionDetailPage.aspx?id=" + id);
        }
    }
}