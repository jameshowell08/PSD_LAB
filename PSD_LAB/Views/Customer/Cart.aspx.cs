using PSD_LAB.Controller;
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
    public partial class Cart : System.Web.UI.Page
    {
        List<Model.Cart> carts;
        UserController Ucon = new UserController();
        CartController CC = new CartController();
        TransactionController TC = new TransactionController();
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

                User customer = (User)Session["Customer"];
                int id = customer.UserID;

            
                carts = CC.GetCartsByUserID(id);
                CartGv.DataSource = carts;
                CartGv.DataBind();




                
            }
        }

        protected void checkoutbtn_Click(object sender, EventArgs e)
        {
            
            User customer = (User)Session["Customer"];
            int id = customer.UserID;
            string errortext = TC.AddTransactionHeader(id);
            errorlbl.Text = errortext;
            carts = CC.GetCartsByUserID(id);
            CartGv.DataSource = carts;
            CartGv.DataBind();

        }

        protected void clearcartbtn_Click(object sender, EventArgs e)
        {
            User customer = (User)Session["Customer"];
            int id = customer.UserID;
            CC.ClearCart(id);
            carts = CC.GetCartsByUserID(id);
            CartGv.DataSource = carts;
            CartGv.DataBind();

        }
    }
}