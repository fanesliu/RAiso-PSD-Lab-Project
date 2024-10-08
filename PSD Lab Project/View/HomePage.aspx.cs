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
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            MsUser user;
            if (Session["user"] == null && Request.Cookies["user_cookie"] == null)
            {
                LblWellcome.Text = "Hello Guest";
                BtnInsert.Visible = false;
                GridViewStationery.Visible = false;
            }
            else
            {
                BtnInsert.Visible = true;
                GridViewStationery.Visible = true;
                RefreshGrid();
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
                    BtnInsert.Visible = false;
                }
                else if (user.UserRole == "Admin")
                {
                    BtnInsert.Visible = true;
                }
                LblWellcome.Text = "Hello " + user.UserName;
            }
        }

        protected void RefreshGrid()
        {
            List<MsStationery> stationery = StationeryController.getAllStationey();
            if (stationery != null)
            {
                GridViewStationery.DataSource = stationery;
                GridViewStationery.DataBind();
            }

        }

        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/InsertStationeryPage.aspx");
        }

        protected void BtnDetail_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/View/StationeryDetailPage.aspx");
        }

        protected void GridViewStationery_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
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
                    Button btnUpdate = (Button)e.Row.FindControl("BtnUpdate");
                    btnUpdate.Visible = false;
                    Button btnDelete = (Button)e.Row.FindControl("BtnDelete");
                    btnDelete.Visible = false;
                }
                else if (user.UserRole == "Admin")
                {
                    Button btnUpdate = (Button)e.Row.FindControl("BtnUpdate");
                    btnUpdate.Visible = true;
                    Button btnDelete = (Button)e.Row.FindControl("BtnDelete");
                    btnDelete.Visible = true;
                }

            }
        }

        protected void GridViewStationery_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = GridViewStationery.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            StationeryController.doDeleteStationery(id);
            RefreshGrid();
        }

        protected void GridViewStationery_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = GridViewStationery.Rows[e.NewEditIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/View/UpdateStationeryPage.aspx?id=" + id);
        }

        protected void GridViewStationery_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridViewStationery.Rows[e.RowIndex];
            int id = Convert.ToInt32(row.Cells[0].Text);
            Response.Redirect("~/View/StationeryDetailPage.aspx?id=" + id);
        }
    }
}