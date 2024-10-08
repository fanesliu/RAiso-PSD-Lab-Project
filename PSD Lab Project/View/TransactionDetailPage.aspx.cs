using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Handler;
using PSD_Lab_Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_Lab_Project.View
{
    public partial class TransactionDetailPage : System.Web.UI.Page
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
            int id = Convert.ToInt32(Request.QueryString["id"]);
            List<object> list = TransactionController.getTransactionDetail(id);
            GridViewCart.DataSource = list;
            GridViewCart.DataBind();
        }
    }
}