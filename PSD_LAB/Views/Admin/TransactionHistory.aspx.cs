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
    public partial class TransactionHistory : System.Web.UI.Page
    {
        UserController Ucon = new UserController();
        TransactionController TC = new TransactionController();
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
                int id = admin.UserID;

                List<TransactionHeader> th;
                th = TC.GetAllTrHeaderDone();
                TransactionGV.DataSource = th;
                TransactionGV.DataBind();





            }
        }

        protected void TransactionGV_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            GridViewRow row = TransactionGV.Rows[rowIndex];
            int Id = int.Parse(row.Cells[0].Text);
            Response.Redirect("~/Views/Customer/TransactionDetails.aspx?Id=" + Id);
        }
    }
}