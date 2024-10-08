using PSD_Lab_Project.Controller;
using PSD_Lab_Project.Dataset;
using PSD_Lab_Project.Model;
using PSD_Lab_Project.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace PSD_Lab_Project.View
{
    public partial class ReportingPage : System.Web.UI.Page
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
            CrystalReportTransaction report = new CrystalReportTransaction();
            CrystalReportViewer.ReportSource = report;
            DataSetTransaction ds = getData(TransactionController.getAllTransaction());
            report.SetDataSource(ds);

        }

        private DataSetTransaction getData(List<TransactionHeader> transactions)
        {
            DataSetTransaction data = new DataSetTransaction();
            var header = data.TransactionHeader;
            var detail = data.TransactionDetail;

            foreach (TransactionHeader t in transactions )
            {
                var hrow = header.NewRow();
                hrow["TransactionID"] = t.TransactionID;
                hrow["UserID"] = t.UserID;
                hrow["TransactionDate"] = t.TransactionDate;
                header.Rows.Add(hrow);

                int total = 0;

                foreach (TransactionDetail d in t.TransactionDetails)
                {
                    var drow = detail.NewRow();
                    drow["TransactionID"] =d.TransactionID;
                    drow["StationeryName"] = d.MsStationery.StationeryName;
                    drow["Quantity"] = d.Quantity;
                    drow["StationeryPrice"] = d.MsStationery.StationeryPrice;
                    drow["SubTotalValue"] = d.MsStationery.StationeryPrice * d.Quantity;

                    total += d.MsStationery.StationeryPrice * d.Quantity;

                    detail.Rows.Add(drow);
                    
                }
                hrow["GrandTotalValue"] = total;

            }

            return data;
        }
    }
}