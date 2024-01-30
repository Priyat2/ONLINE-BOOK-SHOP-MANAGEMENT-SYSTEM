using Core;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class Book_Po_Generate_Receipt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("login_page.aspx");
                }

                getid.Value = Request.QueryString["id"];

                DataTable dt = new DataTable();
                dt = citywarehouse.book_receipt_rep(getid.Value);
                if (dt.Rows.Count > 0)
                {
                    repeater.DataSource = dt;
                    repeater.DataBind();
                }

                string Appts;
                Appts = dt.Compute("sum(gst_amt)", string.Empty).ToString();
                lbltotaltax.Text = Appts;

                string discount;
                discount = dt.Compute("sum(discount_price)", string.Empty).ToString();
                lbldiscount.Text = discount;

                string gross;
                gross = dt.Compute("sum(total_amt)", string.Empty).ToString();
                lblgrossamount.Text = gross;



                lblpono.Text = getid.Value;


                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.book_purchase_order_item_byid(getid.Value);

                lblsplrname.Text = dt3.Rows[0]["splr_name"].ToString();
                lbldate.Text = dt3.Rows[0]["po_order_dt"].ToString();
                lblsplradd.Text = dt3.Rows[0]["splr_address"].ToString();
                lblnetvalue.Text = dt3.Rows[0]["po_final_price"].ToString();
                lblpono.Text = dt3.Rows[0]["po_code"].ToString();

            }
        }


    }
}