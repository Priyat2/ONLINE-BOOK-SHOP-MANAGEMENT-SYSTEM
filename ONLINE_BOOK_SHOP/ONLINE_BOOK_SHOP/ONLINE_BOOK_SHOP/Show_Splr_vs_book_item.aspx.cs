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
    public partial class Show_Splr_vs_book_item : System.Web.UI.Page
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
                dt = Lead.get_suppliers_book();
                ddlsuplier.DataSource = dt;
                ddlsuplier.DataBind();
                ddlsuplier.DataTextField = "splr_name";
                ddlsuplier.DataValueField = "pk_splr_id";
                ddlsuplier.DataBind();


            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            Response.Redirect("splr_vs_book_items.aspx");
        }
        protected void btnupdate_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = Lead.get_item_by_splr_book_id(ddlsuplier.SelectedValue);
            if (dt.Rows.Count > 0)
            {
                Repeater.DataSource = dt;
                Repeater.DataBind();
            }

        }

    }
}