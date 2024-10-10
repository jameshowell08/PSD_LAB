﻿using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PSD_LAB.Views.Admin
{
    public partial class InsertMakeupBrand : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        MakeupBrandController MBC = new MakeupBrandController();
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

            }
        }

        protected void insertmakeupbrandbtn_Click(object sender, EventArgs e)
        {
            string name = name_tb.Text;
            int price = Convert.ToInt32(rating_tb.Text);
            
            int temp = MBC.InsertMakeupBrandValidation(name, price);
            if (temp == 0)
            {
                errorlbl.Text = "insert gagal";
            }
            else
            {
                errorlbl.Text = "insert succes";
                Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
            }

        }
    }
}