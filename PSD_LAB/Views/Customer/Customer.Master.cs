using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Customer
{
    public partial class Customer : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ordermakeupbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/OrderMakeup.aspx");
        }

        protected void historybtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/TransactionHistory.aspx");
        }

        protected void profilebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/ProfileCustomer.aspx");
        }

        protected void logoutbtn_Click(object sender, EventArgs e)
        {
            Session["Customer"] = null;
            if (Request.Cookies["user_cookie"] != null)
            {
                Response.Cookies["user_cookie"].Value = null;
                Response.Cookies["user_cookie"].Expires = DateTime.Now.AddDays(-1);
            }
            Response.Redirect("~/Views/Login.aspx");
        }

        protected void cartbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/Cart.aspx");
        }

        protected void homebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Customer/Home.aspx");
        }
    }
}
