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
    public partial class book_item_category : System.Web.UI.Page
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
            dt = Lead.get_items_cat_book();
            ddlcat.DataSource = dt;
            ddlcat.DataValueField = "item_fk_icat_id";
            ddlcat.DataTextField = "item_icat_name";
            ddlcat.DataBind();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            string item_icat_is_active = string.Empty;
            if (active.Checked)
            {
                item_icat_is_active = "1";

            }
            else
            {
                item_icat_is_active = "0";
            }
            DataTable dt1 = new DataTable();
            dt1 = Lead.book_item_cat_i_u(ddlcat.SelectedValue, txtcat.Text, item_icat_is_active, nameCookie.Value);

            if (dt1.Rows.Count > 0)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language='javascript'>");
                sb.Append("alert('" + dt1.Rows[0]["msg"] + "');");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", sb.ToString());
            }
            datafill();
        }

        protected void cat_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt2 = new DataTable();
            dt2 = Lead.get_book_items_cat_by_id(ddlcat.SelectedValue);

            if (dt2.Rows.Count > 0)
            {
                txtcat.Text = dt2.Rows[0]["item_icat_name"].ToString();

                if (dt2.Rows[0]["item_icat_is_active"].ToString() == "1")
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
                txtcat.Text = "";
                active.Checked = false;
                inactive.Checked = false;

            }

        }

    }
}