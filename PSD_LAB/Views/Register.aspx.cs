using PSD_LAB.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PSD_LAB.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registerbtn_Click(object sender, EventArgs e)
        {
            string username, email, gender, password,confirmpassword;
            DateTime dob;
            username = username_tb.Text.ToString();
            email = email_tb.Text.ToString();
            gender = GenderRadioList.SelectedValue;
            dob = dob_input.SelectedDate;
            password = password_tb.Text.ToString() ;
            confirmpassword = confirmpassword_tb.Text.ToString();
            int tempBool = Ucon.RegisterValidation(username,email,gender,dob,password,confirmpassword);

            if (tempBool == 1)
            {
                
                Response.Redirect("~/Views/Login.aspx");
            }
            else
            {
                output.Text = "gagalregister";
            }
            
        }

      

        protected void loginlink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Login.aspx");
        }
    }
}