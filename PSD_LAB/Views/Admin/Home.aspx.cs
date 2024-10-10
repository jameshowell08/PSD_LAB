using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class Home : System.Web.UI.Page
    {
        List<User> users = null;
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
                        User admin = Ucon.GetUserByID(userID);
                        Session["Admin"] = admin;
                    }
                    
                }
                User admn =(User)Session["Admin"];
                username_lbl.Text = admn.Username;
                role_lbl.Text  = admn.UserRole;
                

                users = Ucon.GetUsers();
                UserGV.DataSource = users;
                UserGV.DataBind();
            }





        }

        protected void UserGV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}