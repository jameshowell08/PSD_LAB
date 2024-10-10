using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Customer
{
    public partial class ProfileCustomer : System.Web.UI.Page
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
                username_tb.Text = customer.Username.Trim();
                email_tb.Text = customer.UserEmail.Trim();
                GenderRadioList.SelectedValue = customer.UserGender;
                dob_input.SelectedDate = customer.UserDOB;
            }
        }

        protected void updatepasswordbtn_Click(object sender, EventArgs e)
        {
            User customer = (User)Session["Customer"];
            int Id = customer.UserID;
            string oldpassword = oldpassword_tb.Text.Trim();
            string newpassword = newpassword_tb.Text.Trim();
            int temp = Ucon.UpdatePassword(Id, oldpassword, newpassword);
            if (temp == 0)
            {
                errorpasslbl.Text = "Password must be alphanumeric";
            }
            else
            {
                errorpasslbl.Text = "Password updated";
            }

        }

        protected void updateprofilebtn_Click(object sender, EventArgs e)
        {
            User customer = (User)Session["Customer"];
            string username, email, gender;
            DateTime dob;
            int Id = customer.UserID;
            username = username_tb.Text.Trim();
            email = email_tb.Text.Trim();
            gender = GenderRadioList.SelectedValue;
            dob = dob_input.SelectedDate;
            int temp = Ucon.UpdateProfile(Id, username, email, gender, dob);
            if (temp == 0)
            {
                errorprofilelbl.Text = "Invalid input";
            }
            else
            {
                errorprofilelbl.Text = "Profile Updated";
            }
        }
    }
}