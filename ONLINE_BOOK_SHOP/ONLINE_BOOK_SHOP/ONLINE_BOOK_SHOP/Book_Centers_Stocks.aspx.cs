using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;
using System.Data;


namespace ONLINE_BOOK_SHOP
{
    public partial class Book_Centers_Stocks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                DataTable dt = new DataTable();
                dt = citywarehouse.book_centers_get();
                ddlcenetrs.DataSource = dt;
                ddlcenetrs.DataValueField = "wvl_fk_loc_id";
                ddlcenetrs.DataTextField = "center_name";
                ddlcenetrs.DataBind();
            }

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            dt1 = citywarehouse.get_all_book_center_stock(ddlcenetrs.SelectedValue);
            if (dt1.Rows.Count > 0)
            {
                repeater.DataSource = dt1;
                repeater.DataBind();
            }

        }
    }
}