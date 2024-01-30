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
    public partial class Citybookwh_to_mainbookwh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


                DataTable dt = new DataTable();
                dt = citywarehouse.get_all_book_item();
                ddlitemname.DataSource = dt;
                ddlitemname.DataValueField = "pk_book_item_id";
                ddlitemname.DataTextField = "book_item_name";
                ddlitemname.DataBind();

                datafill();
            }

        }

        protected void datafill()
        {
            HttpCookie locationid = Request.Cookies["location"];
            DataTable dt1 = new DataTable();
            dt1 = citywarehouse.get_book_order_rep(locationid.Value);
            if (dt1.Rows.Count > 0)
            {
                repeater.DataSource = dt1;
                repeater.DataBind();
            }


            if (dt1.Rows.Count > 0)
            {
                hidepanel.Visible = true;
            }
            else
            {
                hidepanel.Visible = false;
            }
        }

        protected void ddlitemname_SelectedIndexChanged1(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            string abc;
            abc = ddlitemname.SelectedValue;

            DataTable dt2 = new DataTable();
            dt2 = citywarehouse.get_book_item_detail_by_id(abc);
            lblsalecost.Text = dt2.Rows[0]["item_sale_cost"].ToString();
            lblpurchasecost.Text = dt2.Rows[0]["item_purchase_cost"].ToString();
            lblunits.Text = dt2.Rows[0]["item_unit_name"].ToString();

            DataTable dt3 = new DataTable();
            dt3 = citywarehouse.get_available_bookstk_by_id(abc, locationid.Value);
            lblqty.Text = dt3.Rows[0]["stk_available_qty"].ToString();


            DataTable dt4 = new DataTable();
            dt4 = citywarehouse.get_avai_main_bookstk_by_id(abc, locationid.Value);
            //cmd5.Parameters.AddWithValue("@loc_id", locationid.Value);        
             lblmainqty.Text = dt4.Rows[0]["stk_available_qty"].ToString();

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];
            DataTable dt5 = new DataTable();
            dt5 = citywarehouse.city_to_mainwh_book_order_i(ddlitemname.SelectedValue, txtqty.Text, lblpurchasecost.Text, locationid.Value);

            datafill();
        }

        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            foreach (RepeaterItem item in repeater.Items)
            {
                TextBox txtqty = (TextBox)item.FindControl("txtquantity1");
                Label lblprodId = (Label)item.FindControl("orderid");
                Label lbltotalprice = (Label)item.FindControl("lblprice");
                {
                    DataTable dt6 = new DataTable();
                    dt6 = citywarehouse.city_to_mainwh_book_order_u(lblprodId.Text, txtqty.Text, lbltotalprice.Text, locationid.Value);

                }

            }
            datafill();
        }

        protected void btnplace_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];
            String order_id = "0";
            foreach (RepeaterItem item in repeater.Items)
            {

                Label orderID = (Label)item.FindControl("orderid");
                TextBox txtqty = (TextBox)item.FindControl("txtquantity1");
                Label price = (Label)item.FindControl("lblprice");
                {
                    DataTable dt7 = new DataTable();
                    dt7 = citywarehouse.city_to_mainbook_place_order(orderID.Text, order_id, txtqty.Text, price.Text, locationid.Value, nameCookie.Value);
                    order_id = dt7.Rows[0]["order_id"].ToString();

                }

            }
           
            Response.Redirect("Citybook_to_mainbook_order_details.aspx");
        }

        protected void DeleteCustomer(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            int orderId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("orderid") as Label).Text);

            {
                DataTable dt8 = new DataTable();
                dt8 = citywarehouse.city_to_mainbook_order_del(orderId, locationid.Value);

            }

            datafill();
        }


    }
}