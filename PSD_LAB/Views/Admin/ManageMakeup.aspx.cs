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
    public partial class ManageMakeup : System.Web.UI.Page
    {
        List<Makeup> makeups;
        List<MakeupType> makeuptypes;
        List<MakeupBrand> makeupbrands;
        UserController Ucon = new UserController();
        MakeupController MUC = new MakeupController();
        MakeupBrandController MBC = new MakeupBrandController();
        MakeupTypeController MTC = new MakeupTypeController();
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
               

                makeups = MUC.GetMakeups();
                MakeupGV.DataSource = makeups;
                MakeupGV.DataBind();

                makeupbrands = MBC.GetMakeupBrands();
                MakeupBrandGV.DataSource = makeupbrands;
                MakeupBrandGV.DataBind();

                makeuptypes = MTC.GetMakeupTypes();
                MakeupTypeGV.DataSource = makeuptypes;
                MakeupTypeGV.DataBind();


               
            }
        }

        protected void insertmkupbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeup.aspx");
        }

        protected void insertmkupbrndbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeupBrand.aspx");
        }

        protected void insertmkuptypebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Views/Admin/InsertMakeupType.aspx");
        }

        protected void MakeupGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupGV.Rows[e.NewEditIndex];
            string Id = row.Cells[0].Text;
            Response.Redirect("~/Views/Admin/UpdateMakeup.aspx?Id=" + Id);
        }

        protected void MakeupGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MakeupGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text;
            MUC.RemoveMakeup(Convert.ToInt32(id));
            makeups = MUC.GetMakeups();
            MakeupGV.DataSource = makeups;
            MakeupGV.DataBind();
        }

        protected void MakeupBrandGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupBrandGV.Rows[e.NewEditIndex];
            string Id = row.Cells[0].Text;
            Response.Redirect("~/Views/Admin/UpdateMakeupBrand.aspx?Id=" + Id);
        }

        protected void MakeupBrandGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

            GridViewRow row = MakeupBrandGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text;
            MBC.RemoveMakeupBrand(Convert.ToInt32(id));
            makeupbrands = MBC.GetMakeupBrands();
            MakeupBrandGV.DataSource = makeupbrands;
            MakeupBrandGV.DataBind();

        }

        protected void MakeupTypeGV_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow row = MakeupTypeGV.Rows[e.RowIndex];
            string id = row.Cells[0].Text;
            MTC.RemoveMakeupType(Convert.ToInt32(id));
            makeuptypes = MTC.GetMakeupTypes();
            MakeupTypeGV.DataSource = makeuptypes;
            MakeupTypeGV.DataBind();

        }

        protected void MakeupTypeGV_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridViewRow row = MakeupTypeGV.Rows[e.NewEditIndex];
            string Id = row.Cells[0].Text;
            Response.Redirect("~/Views/Admin/UpdateMakeupType.aspx?Id=" + Id);
        }
    }
}