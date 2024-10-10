using PSD_LAB.Controller;
using PSD_LAB.Dataset;
using PSD_LAB.Model;
using PSD_LAB.Report;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class TransactionReport : System.Web.UI.Page
    {
        TransactionController TC = new TransactionController();
        UserController Ucon = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Admin"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
                else
                {

                    if (Session["Admin"] == null)
                    {
                        string Id = Request.Cookies["user_cookie"].Value;
                        int userID = Convert.ToInt32(Id);
                        User admn = Ucon.GetUserByID(userID);
                        Session["Admin"] = admn;
                    }
                }


                CrystalReport report = new CrystalReport();
                CrystalReportViewer1.ReportSource = report;
                List<TransactionHeader> transactions = TC.GetAllTrHeaderDone();
                DataSet data = GetData(transactions);

                report.SetDataSource(data);
            }
        }

        private DataSet GetData(List<TransactionHeader> transactions)
        {
            DataSet data = new DataSet();
            var headerTable = data.Transaction;
            var detailTable = data.Detail;

            foreach(var t in transactions)
            {

                int GrandTotal = 0;

                foreach(var d in t.TransactionDetails)
                {
                    var drow = detailTable.NewRow();
                    drow["TransactionId"] = d.TransactionID;
                    drow["Item"] = d.Makeup.MakeupName;
                    drow["Quantity"] = d.Quantity;
                    drow["Price"] = d.Makeup.MakeupPrice;
                    int totalprice = d.Quantity * d.Makeup.MakeupPrice;
                    drow["TotalPrice"] = totalprice;
                    GrandTotal = GrandTotal + totalprice;
                    detailTable.Rows.Add(drow);
                }
                var hrow = headerTable.NewRow();
                hrow["Id"] = t.TransactionID;
                hrow["Customer"] = t.User.Username;
                hrow["Date"] = t.TransactionDate;
                hrow["GrandTotal"] = GrandTotal;
                headerTable.Rows.Add(hrow);
            }

            return data;
        }
    }
}