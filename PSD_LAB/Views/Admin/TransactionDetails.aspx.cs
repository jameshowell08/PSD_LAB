using PSD_LAB.Controller;
using PSD_LAB.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Util;

namespace PSD_LAB.Views.Admin
{
    public partial class TransactionDetails : System.Web.UI.Page
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
                string transactionid = Request.QueryString["Id"];
                int transactionId = Convert.ToInt32(transactionid);
                List<TransactionDetail> td;
                td = TC.GetTrDetailByID(transactionId);
                TransactionDetailsGV.DataSource = td;
                TransactionDetailsGV.DataBind();


            }

        }
    }
}