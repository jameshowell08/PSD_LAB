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
    public partial class Home : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
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
                username_lbl.Text = customer.Username;
                role_lbl.Text = customer.UserRole;
            }
        }
    }
}