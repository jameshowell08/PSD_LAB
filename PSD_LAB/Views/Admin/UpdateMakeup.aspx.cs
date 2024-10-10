using PSD_LAB.Controller;
using PSD_LAB.Model;
using PSD_LAB.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class UpdateMakeup : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        MakeupController MUC = new MakeupController();
        protected void Page_Load(object sender, EventArgs e)
        {
            Makeup makeup = new Makeup();
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
                int makeupId = Convert.ToInt32(MakeupId);
                makeup = MUC.GetMakeupByID(makeupId);
                name_tb.Text = makeup.MakeupName.Trim();
                price_tb.Text = Convert.ToString(makeup.MakeupPrice);
                weight_tb.Text = Convert.ToString(makeup.MakeupWeight);
                typeid_tb.Text = Convert.ToString(makeup.MakeupTypeID);
                brandid_tb.Text = Convert.ToString(makeup.MakeupBrandID);



            }
        }

        protected void updatemakeupbtn_Click(object sender, EventArgs e)
        {
           
            int price, weight, typeid, brandid;
            string MakeupId = Request.QueryString["Id"];
            int makeupId = Convert.ToInt32(MakeupId);
            string name = name_tb.Text.Trim();
            price = Convert.ToInt32(price_tb.Text);
            weight = Convert.ToInt32(weight_tb.Text);
            typeid = Convert.ToInt32(typeid_tb.Text);    
            brandid = Convert.ToInt32(brandid_tb.Text);

            
            int temp = MUC.UpdateMakeupValidation(makeupId,name, price, weight, typeid, brandid);
            if (temp == 0)
            {
                errorlbl.Text = "invalid input";
            }
            else
            {
                Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
                errorlbl.Text = "Makeup Updated";
            }
           


        }
    }
}