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
    public partial class book_view_items : System.Web.UI.Page
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
                dt = citywarehouse.book_purchase_order_item(getid.Value);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

                lblorderid1.Text = getid.Value;


                DataTable dt1 = new DataTable();
                dt1 = citywarehouse.book_purchase_order_item_byid(getid.Value);

                lblsplrname.Text = dt1.Rows[0]["splr_name"].ToString();
                lbltotalqty.Text = dt1.Rows[0]["po_item_qty"].ToString();
                lbllocation.Text = dt1.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt1.Rows[0]["po_item_price"].ToString();

                lbldate.Text = dt1.Rows[0]["po_order_dt"].ToString();

                lblpocode.Text = dt1.Rows[0]["po_code"].ToString();
            }
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {

            getid.Value = Request.QueryString["id"];
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];

            foreach (RepeaterItem item in Repeater.Items)
            {

                TextBox txtexdt = (TextBox)item.FindControl("txtexpiry");
                TextBox txtbacth = (TextBox)item.FindControl("txtbatch");

                TextBox txtqty = (TextBox)item.FindControl("txtrecieved");
                TextBox txtbonusqty = (TextBox)item.FindControl("txtbonus");
                TextBox txtpriceper = (TextBox)item.FindControl("txtpriper");
                TextBox txtrate = (TextBox)item.FindControl("txtrate");
                TextBox txtdisc = (TextBox)item.FindControl("txtdisc");
                Label finalprice = (Label)item.FindControl("finalprice");
                Label fk_id = (Label)item.FindControl("lblpoid");
                Label pk_id = (Label)item.FindControl("lbltrpoid");
                Label item_id = (Label)item.FindControl("lblitemid");


                {

                    DataTable dt2 = new DataTable();
                    dt2 = citywarehouse.book_purchase_order_rec(txtqty.Text, fk_id.Text, pk_id.Text, txtexdt.Text, txtbacth.Text, locationid.Value, txtbonusqty.Text,
                       txtpriceper.Text, txtrate.Text, txtdisc.Text, finalprice.Text);


                    DataTable dt3 = new DataTable();
                    dt3 = citywarehouse.book_center_stock_u(txtqty.Text, item_id.Text, locationid.Value, txtbonusqty.Text);

                    DataTable dt4 = new DataTable();
                    dt4 = citywarehouse.purchase_order_bookinvoice_i(getid.Value, txtinvoice.Text);

                }

            }


            DataTable dt5 = new DataTable();
            dt5 = citywarehouse.book_add_total_purchase_order(getid.Value, nameCookie.Value, lbldelch.Text);


            Response.Redirect("book_Purchase_Order_Approval.aspx");
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("book_Purchase_Order_Approval.aspx");
        }
    }
}