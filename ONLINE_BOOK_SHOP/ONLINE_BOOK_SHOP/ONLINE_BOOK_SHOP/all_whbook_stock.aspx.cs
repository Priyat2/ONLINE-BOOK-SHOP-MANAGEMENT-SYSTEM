using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace ONLINE_BOOK_SHOP
{
    public partial class all_whbook_stock : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                DataTable dt1 = new DataTable();
                dt1 = MainWarehouse.get_all_bookwh_get();
                ddlcenter.DataSource = dt1;
                ddlcenter.DataBind();
                ddlcenter.DataTextField = "user_display";
                ddlcenter.DataValueField = "location_id";
                ddlcenter.DataBind();
            }
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = MainWarehouse.get_all_bookwh_stock(ddlcenter.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                repeater.DataSource = dt;
                repeater.DataBind();
            }

        }
    }
}