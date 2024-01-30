using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;
using System.Data;


namespace ONLINE_BOOK_SHOP
{
    public partial class All_po_for_main_bookwh_list : System.Web.UI.Page
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

        protected void btnreport_Click(object sender, EventArgs e)
        {
            if (txtstartdate.Text == "" & txtenddate.Text == "")
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
                DataTable dt = new DataTable();
                dt = MainWarehouse.supplier_order_bookdetails(txtstartdate.Text, txtenddate.Text, locationid.Value);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }


            }
        }

    }
}