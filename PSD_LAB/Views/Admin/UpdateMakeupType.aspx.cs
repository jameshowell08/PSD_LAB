using PSD_LAB.Controller;
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
    public partial class UpdateMakeupType : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        MakeupTypeController MTC = new MakeupTypeController();
        protected void Page_Load(object sender, EventArgs e)
        {
            MakeupType makeuptype = new MakeupType();
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
                string MakeupTypeId = Request.QueryString["Id"];
                int makeuptypeId = Convert.ToInt32(MakeupTypeId);
                makeuptype = MTC.GetMakeupTypeByID(makeuptypeId);
                name_tb.Text = makeuptype.MakeupTypeName.Trim();
            }
        }

        protected void updatemakeupTypebtn_Click(object sender, EventArgs e)
        {
            string MakeupTypeId = Request.QueryString["Id"];
            int makeuptypeId = Convert.ToInt32(MakeupTypeId);
            string name = name_tb.Text.Trim();
            int temp = MTC.UpdateMakeupTypeValidation(makeuptypeId, name);
            if (temp == 0)
            {
                errorlbl.Text = "invalid input";
            }
            else
            {
                Response.Redirect("~/Views/Admin/ManageMakeup.aspx");
                errorlbl.Text = "MakeupType Updated";
            }
        }
    }
}