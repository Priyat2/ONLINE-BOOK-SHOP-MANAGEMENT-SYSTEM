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
    public partial class Complete_req_from_wh_to_centerwh : System.Web.UI.Page
    {

        protected void Page_Load(object sender,EventArgs e)
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
                dt = MainWarehouse.item_get_by_id_from_bookcitywh(getid.Value, locationid.Value);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

                lblorderid1.Text = getid.Value;

                DataTable dt3 = new DataTable();
                dt3 = MainWarehouse.item_get_by_bookid(getid.Value);

                if (dt3.Rows.Count > 0)
                {
                    lbltotalqty.Text = dt3.Rows[0]["otw_qty"].ToString();
                    lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                    lbltotalprice.Text = "Rs." + dt3.Rows[0]["otw_price"].ToString();
                    lbldate.Text = dt3.Rows[0]["otw_order_dt"].ToString();

                }
                
            }
        }  
        protected void btnsave_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            HttpCookie locationid = Request.Cookies["location"];

            foreach (RepeaterItem item in Repeater.Items)
            {
                TextBox txtqty = (TextBox)item.FindControl("txtconfirm");
                Label fk_id = (Label)item.FindControl("lblfkid");
                Label pk_id = (Label)item.FindControl("lblpkid");
                Label item_id = (Label)item.FindControl("lblitemid");
                {
                    DataTable dt1 = MainWarehouse.bookconfirm_qty_i(txtqty.Text, fk_id.Text, pk_id.Text, locationid.Value, nameCookie.Value);

                }


                DataTable dt2 = MainWarehouse.complete_book_center_req_stock_minus(txtqty.Text, item_id.Text, locationid.Value);

               
            }

            Response.Redirect("Req_from_center_bookwh_order.aspx");

        }


        protected void btnback_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Req_from_center_bookwh_order.aspx");
        }
    }
}