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
    public partial class book_item_sub_cat : System.Web.UI.Page
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
            dt = Lead.get_items_subcat_book();
            ddlSubcat.DataSource = dt;
            ddlSubcat.DataValueField = "item_sub_cat_id";
            ddlSubcat.DataTextField = "item_sub_cat_name";
            ddlSubcat.DataBind();
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            string item_sub_cat_is_active = string.Empty;
            if (active.Checked)
            {
                item_sub_cat_is_active = "1";

            }
            else
            {
                item_sub_cat_is_active = "0";
            }
            DataTable dt = new DataTable();
            dt = Lead.book_item_subcat_i_u(ddlSubcat.SelectedValue, txtsub.Text, item_sub_cat_is_active, nameCookie.Value);

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

        protected void subcat_SelectedIndexChanged(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            dt = Lead.get_book_items_subcat_by_id(ddlSubcat.SelectedValue);

            if (dt.Rows.Count > 0)
            {
                txtsub.Text = dt.Rows[0]["item_sub_cat_name"].ToString();

                if (dt.Rows[0]["item_sub_cat_is_active"].ToString() == "1")
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
                txtsub.Text = "";
                active.Checked = false;
                inactive.Checked = false;

            }

        }
    }
}