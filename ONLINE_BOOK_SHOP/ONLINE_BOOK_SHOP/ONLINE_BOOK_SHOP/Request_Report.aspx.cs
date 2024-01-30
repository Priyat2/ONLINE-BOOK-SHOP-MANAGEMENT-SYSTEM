using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Warehouse
{
    public partial class Request_Report : System.Web.UI.Page
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
                dt = citywarehouse.center_to_center_rep(locationid.Value, txtstartdate.Text, txtenddate.Text);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }
            }
        }
    }
}