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
    public partial class All_po_for_main_bookwh_by_item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                getid.Value = Request.QueryString["id"];

                DataTable dt = new DataTable();
                dt = citywarehouse.book_purchase_order_view(getid.Value);

                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

                lblorderid1.Text = getid.Value;

                DataTable dt2 = new DataTable();
                dt2 = citywarehouse.book_purchase_order_item_byid(getid.Value);


                lblsplrname.Text = dt2.Rows[0]["splr_name"].ToString();
                lbltotalqty.Text = dt2.Rows[0]["po_item_qty"].ToString();
                lbllocation.Text = dt2.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt2.Rows[0]["po_item_price"].ToString();
                lblreceive.Text = dt2.Rows[0]["po_receive_dt"].ToString();
                lbldate.Text = dt2.Rows[0]["po_order_dt"].ToString();
                lblinvoice.Text = dt2.Rows[0]["po_invoice_no"].ToString();
                lblgrn.Text = dt2.Rows[0]["po_grn"].ToString();
                lbldelch.Text = dt2.Rows[0]["po_delivery_charges"].ToString();
                lblpocode.Text = dt2.Rows[0]["po_code"].ToString();
            }
        }
    }
}