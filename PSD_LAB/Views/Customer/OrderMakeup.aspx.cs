using PSD_LAB.Controller;
using PSD_LAB.Handler;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Customer
{
    public partial class OrderMakeup : System.Web.UI.Page
    {
        List<Makeup> makeups;
        UserController Ucon = new UserController();
        MakeupController MUC = new MakeupController();
        CartController CC = new CartController();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Customer"] == null && Request.Cookies["user_cookie"] == null)
                {
                    Response.Redirect("~/Views/Login.aspx");
                }
                else
                {

                    if (Session["Customer"] == null)
                    {
                        string Id = Request.Cookies["user_cookie"].Value;
                        int userID = Convert.ToInt32(Id);
                        User cstmr = Ucon.GetUserByID(userID);
                        Session["Customer"] = cstmr;
                    }

                }

                makeups = MUC.GetMakeups();
                MakeupGV.DataSource = makeups;
                MakeupGV.DataBind();
            }
        }
        protected void addtocartbtn_Click(object sender, EventArgs e)
        {
            User customer = (User)Session["Customer"];
            int customerId = customer.UserID;

            Button btn = (Button)sender;
            GridViewRow row = (GridViewRow)btn.NamingContainer;

            TextBox txtQuantity = (TextBox)row.FindControl("quantity_tb");

            if (txtQuantity != null && int.TryParse(txtQuantity.Text, out int quantity))
            {
                int makeupID = Convert.ToInt32(btn.CommandArgument);
                int temp = CC.AddCart(customerId, makeupID, quantity);
                if (temp == 0)
                {
                    errorlbl.Text = "Quantity must be ebigger than 0";
                }
                else
                {
                    errorlbl.Text = "Item added to cart";
                }


            }
        }
    }
}