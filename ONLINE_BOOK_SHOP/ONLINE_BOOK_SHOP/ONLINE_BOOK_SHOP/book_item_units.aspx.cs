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
using Core;

namespace ONLINE_BOOK_SHOP
{
    public partial class book_item_units : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                datafill();
            }

        }

        private void datafill()
        {

            DataTable dt = new DataTable();
            dt = Lead.get_items_unit_book();
            ddlunit.DataSource = dt;
            ddlunit.DataValueField = "item_fk_unit_id";
            ddlunit.DataTextField = "item_unit_name";
            ddlunit.DataBind();
        }

        protected void btnsubmit_Click1(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            string item_unit_is_active = string.Empty;
            if (active.Checked)
            {
                item_unit_is_active = "1";

            }
            else
            {
                item_unit_is_active = "0";
            }
            DataTable dt = new DataTable();
            dt = Lead.book_item_unit_i_u(ddlunit.SelectedValue, txtitemunit.Text, item_unit_is_active, nameCookie.Value);

            if (dt.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language='javascript'>");
                sb.Append("alert('" + dt.Rows[0]["msg"] + "');");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", sb.ToString());
            }
            datafill();
        }

        protected void unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Lead.get_book_items_unit_by_id(ddlunit.SelectedValue);

            if (dt.Rows.Count > 0)
            {
                txtitemunit.Text = dt.Rows[0]["item_unit_name"].ToString();

                if (dt.Rows[0]["item_unit_is_active"].ToString() == "1")
                {
                    active.Checked = true;
                }
                else
                {
                    inactive.Checked = true;
                }

            }

            else
            {
                txtitemunit.Text = "";
                active.Checked = false;
                inactive.Checked = false;

            }

        }
    }
}