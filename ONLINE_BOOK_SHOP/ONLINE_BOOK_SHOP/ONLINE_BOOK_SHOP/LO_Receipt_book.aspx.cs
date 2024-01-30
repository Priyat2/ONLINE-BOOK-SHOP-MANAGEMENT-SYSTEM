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
    public partial class LO_Receipt_book : System.Web.UI.Page
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

                DataTable dt1 = new DataTable();
                dt1 = citywarehouse.local_receipt_rep_book(getid.Value);
                repeater.DataSource = dt1;
                repeater.DataBind();



                string Appts;
                Appts = dt1.Compute("sum(gst_amt)", string.Empty).ToString();
                lbltotaltax.Text = Appts;

                string discount;
                discount = dt1.Compute("sum(discount_price)", string.Empty).ToString();
                lbldiscount.Text = discount;

                string gross;
                gross = dt1.Compute("sum(total_amt)", string.Empty).ToString();
                lblgrossamount.Text = gross;



                lbllono.Text = getid.Value;

                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.local_receipt_get_by_bookid(getid.Value);

                lbllocalname.Text = dt3.Rows[0]["trlo_local_shop"].ToString();
                lbldate.Text = dt3.Rows[0]["lo_order_dt"].ToString();
                lblnetvalue.Text = dt3.Rows[0]["lo_final_price"].ToString();

                lbldelch.Text = dt3.Rows[0]["lo_delivery_charges"].ToString();

            }
        }
    }
    }
