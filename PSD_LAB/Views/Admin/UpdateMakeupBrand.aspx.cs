using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class UpdateMakeupBrand : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        MakeupBrandController MBC = new MakeupBrandController();
        protected void Page_Load(object sender, EventArgs e)
        {
            MakeupBrand makeupbrand = new MakeupBrand();
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
                string MakeupId = Request.QueryString["Id"];
                int makeupbrandId = Convert.ToInt32(MakeupId);
                makeupbrand = MBC.GetMakeupBrandByID(makeupbrandId);
                name_tb.Text = makeupbrand.MakeupBrandName.Trim();
                rating_tb.Text = Convert.ToString(makeupbrand.MakeupBrandRating);
            }

        }

        protected void updatemakeupbrandbtn_Click(object sender, EventArgs e)
        {
            string MakeupbrandId = Request.QueryString["Id"];
            int makeupbrandId = Convert.ToInt32(MakeupbrandId);
            string name = name_tb.Text.Trim();
            int rating = Convert.ToInt32(rating_tb.Text);
            int temp = MBC.UpdateMakeupBrandValidation(makeupbrandId,name, rating);
            if (temp == 0)
            {
                errorlbl.Text = "invalid input";
            }
            else
            {
                Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
                errorlbl.Text = "MakeupBrand Updated";
            }

        }
    }
}