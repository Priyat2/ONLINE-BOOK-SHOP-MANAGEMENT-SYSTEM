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
    public partial class citybook_to_mainbook_receive_item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }
                HttpCookie locationid = Request.Cookies["location"];
                getid.Value = Request.QueryString["id"];

                DataTable dt = new DataTable();
                dt = citywarehouse.city_to_mainbook_order_rec_rep(getid.Value, locationid.Value);

                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

                lblorderid1.Text = getid.Value;

                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.complete_bookreq_bind_data(getid.Value);

                lbltotalqty.Text = dt3.Rows[0]["otw_qty"].ToString();
                lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt3.Rows[0]["otw_price"].ToString();
                lbldate.Text = dt3.Rows[0]["otw_order_dt"].ToString();
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Citybook_to_mainbook_order_details.aspx");
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];
            foreach (RepeaterItem item in Repeater.Items)
            {
                TextBox txtqty = (TextBox)item.FindControl("txtrecieved");
                Label fk_id = (Label)item.FindControl("lblpoid");
                Label pk_id = (Label)item.FindControl("lbltrpoid");
                Label item_id = (Label)item.FindControl("lblitemid");

                {

                    DataTable dt1 = new DataTable();
                    dt1 = citywarehouse.city_to_mainbook_item_rec_i(pk_id.Text, txtqty.Text, fk_id.Text, locationid.Value, item_id.Text, nameCookie.Value);


                }
            }
            Response.Redirect("Citybook_to_mainbook_order_details.aspx");
        }
    }
}