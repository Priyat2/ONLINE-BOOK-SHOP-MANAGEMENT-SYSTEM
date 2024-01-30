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
    public partial class Records_of_book_PO_per_items : System.Web.UI.Page
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


                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.book_purchase_order_item_byid(getid.Value);

                lblsplrname.Text = dt3.Rows[0]["splr_name"].ToString();
                lbltotalqty.Text = dt3.Rows[0]["po_item_qty"].ToString();
                lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt3.Rows[0]["po_item_price"].ToString();
                lblorder.Text = dt3.Rows[0]["po_order_dt"].ToString();
                lblreceive.Text = dt3.Rows[0]["po_receive_dt"].ToString();
                lblinvoice.Text = dt3.Rows[0]["po_invoice_no"].ToString();
                lblgrn.Text = dt3.Rows[0]["po_grn"].ToString();
                lbldelch.Text = dt3.Rows[0]["po_delivery_charges"].ToString();
                lblpocode.Text = dt3.Rows[0]["po_code"].ToString();
            }
        }


    }
}