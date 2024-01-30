using Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class Records_of_Lo_Regwhbook_per_items : System.Web.UI.Page
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
                dt = citywarehouse.local_view_rep_book(getid.Value);

                Repeater.DataSource = dt;
                Repeater.DataBind();

                lblorderid1.Text = getid.Value;


                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.local_view_by_id_book(getid.Value);

                lbllocalname.Text = dt3.Rows[0]["trlo_local_shop"].ToString();
                lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                lbltotalqty.Text = dt3.Rows[0]["lo_item_qty"].ToString();
                lbltotalprice.Text = "Rs." + dt3.Rows[0]["lo_item_price"].ToString();

                lbldate.Text = dt3.Rows[0]["lo_order_dt"].ToString();
                lblinvoice.Text = dt3.Rows[0]["lo_invoice_no"].ToString();
                lblgrn.Text = dt3.Rows[0]["lo_grn"].ToString();
                lbldelch.Text = dt3.Rows[0]["lo_delivery_charges"].ToString();
            }
        }
    }
    }
