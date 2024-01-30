using Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class Order_to_Local_Regionalwh_book_report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (startdate.Text == "" & enddate.Text == "")
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language='javascript'>");
                sb.Append("alert('Select Start and End Date');");
                sb.Append("history.back();");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", sb.ToString());
            }
            else
            {
                HttpCookie locationid = Request.Cookies["location"];
                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.local_receipt_report_book(startdate.Text, enddate.Text, locationid.Value);

                Repeat.DataSource = dt3;
                Repeat.DataBind();

            }


        }



    }
}