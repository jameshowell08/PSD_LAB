using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/Home.aspx");
        }

        protected void managemakeupbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
        }

        protected void orderqueue_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/OrderQueue.aspx");
        }

        protected void profilebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/ProfileAdmin.aspx");
        }

        protected void transactionreportbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionReport.aspx");
        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            Session["Admin"] = null;
            if (Request.Cookies["user_cookie"] != null)
            {
                Response.Cookies["user_cookie"].Value = null;
                Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("~/Views/Login.aspx");

        }

        protected void history_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/TransactionHistory.aspx");
        }
    }
}