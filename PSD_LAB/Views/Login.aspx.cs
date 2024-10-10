using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views
{
    public partial class Login : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Request.Cookies["user_cookie"] != null)
            {
                if (Session["Customer"] != null || Session["Admin"] != null)
                {
                    Response.Redirect("~/Views/HomePage.aspx");
                }
            }
        }

        protected void registerlink_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Register.aspx");
        }

        protected void loginbtn_Click(object sender, EventArgs e)
        {
            String username, password;
            bool isRemember = remember_me.Checked;
            username = username_tb.Text.ToString();
            password = password_tb.Text.ToString();
            

            User UserValidated = Ucon.LoginValidation(username, password);


            if (UserValidated != null)
            {
                int role = Ucon.RoleValidation(UserValidated);
                erroelbl.Text = role.ToString();
                rolename.Text = UserValidated.UserRole.ToString();
                if (role == 1)
                {
                    
                    if (isRemember)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = UserValidated.UserID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    Session["Admin"] = UserValidated;
                    int Id = UserValidated.UserID;
                    Response.Redirect("~/Views/Admin/Home.aspx");

                }
                else if (role == 2)
                {
                    
                    if (isRemember)
                    {
                        HttpCookie cookie = new HttpCookie("user_cookie");
                        cookie.Value = UserValidated.UserID.ToString();
                        cookie.Expires = DateTime.Now.AddHours(1);
                        Response.Cookies.Add(cookie);
                    }
                    Session["Customer"] = UserValidated;
                    Response.Redirect("~/Views/Customer/Home.aspx");
                }
            }
            else
            {
                erroelbl.Text = "kosong";
            }


        }
    }
}