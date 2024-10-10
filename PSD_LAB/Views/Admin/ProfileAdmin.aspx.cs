using PSD_LAB.Controller;
using PSD_LAB.Handler;
using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class ProfileAdmin : System.Web.UI.Page
    {
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

                User admin = (User)Session["Admin"];
                username_tb.Text = admin.Username.Trim();
                email_tb.Text = admin.UserEmail.Trim();
                GenderRadioList.SelectedValue = admin.UserGender;
                dob_input.SelectedDate = admin.UserDOB;
            }

        }
        
        protected void updateprofilebtn_Click(object sender, EventArgs e)
        {
            User admin = (User)Session["Admin"];
            string username, email, gender;
            DateTime dob;
            int Id = admin.UserID;
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

        protected void updatepasswordbtn_Click(object sender, EventArgs e)
        {
            User admin = (User)Session["Admin"];
            int Id = admin.UserID;
            string oldpassword = oldpassword_tb.Text.Trim();
            string newpassword = newpassword_tb.Text.Trim();
            int temp = Ucon.UpdatePassword(Id, oldpassword, newpassword);
            if(temp == 0)
            {
                errorpasslbl.Text = "Password must be alphanumeric";
            }
            else
            {
                errorpasslbl.Text = "Password updated";
            }


        }
    }
}