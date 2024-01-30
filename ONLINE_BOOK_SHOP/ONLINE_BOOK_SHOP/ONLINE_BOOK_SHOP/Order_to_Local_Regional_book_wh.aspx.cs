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
    public partial class Order_to_Local_Regional_book_wh : System.Web.UI.Page
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
                dt = citywarehouse.centeritemmaster();
                ddlitemname.DataSource = dt;
                ddlitemname.DataBind();
                ddlitemname.DataValueField = "pk_book_item_id";
                ddlitemname.DataTextField = "book_item_name";
                ddlitemname.DataBind();

                datafill();


            }
        }

        protected void datafill()
        {
            DataTable dt1 = new DataTable();
            dt1 = citywarehouse.local_add_rep_book();
            repeater.DataSource = dt1;
            repeater.DataBind();

            if
            (dt1.Rows.Count > 0)
            {
                panelid.Visible = true;
            }
            else
            {
                panelid.Visible = false;
            }

        }

        protected void ddlitemname_SelectedIndexChanged1(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            string abc;
            abc = ddlitemname.SelectedValue;

            DataTable dt2 = new DataTable();
            dt2 = citywarehouse.local_add_book_item(abc);

            txtpurchasecost.Text = dt2.Rows[0]["item_purchase_cost"].ToString();
            lblunits.Text = dt2.Rows[0]["item_unit_name"].ToString();

            DataTable dt3 = new DataTable();
            dt3 = citywarehouse.local_add_item_stock_book(abc, locationid.Value);

            lblqty.Text = dt3.Rows[0]["stk_available_qty"].ToString();


        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];

            DataTable dt4 = new DataTable();
            dt4 = citywarehouse.local_add_save_book(ddlitemname.SelectedValue, locationid.Value, txtqty.Text, txtlocal.Text, txtpurchasecost.Text, txtdiscount.Text,
               txtGSTs.Text, nameCookie.Value);


            datafill();
        }


        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];
            foreach (RepeaterItem item in repeater.Items)
            {
                Label lblprodId = (Label)item.FindControl("localorderid");
                TextBox txtqty1 = (TextBox)item.FindControl("txtqty");
                //TextBox txtlocal1 = (TextBox)item.FindControl("txtlocal");
                TextBox txttotalprice = (TextBox)item.FindControl("txtprice");
                TextBox txtdiscount1 = (TextBox)item.FindControl("txtdiscount");
                TextBox txtGST1 = (TextBox)item.FindControl("txtGST");
                Label lblfinalprice1 = (Label)item.FindControl("lblfinalprice");

                {
                    DataTable dt5 = new DataTable();
                    dt5 = citywarehouse.local_add_update_book(lblprodId.Text, txtqty1.Text, txttotalprice.Text, txtdiscount1.Text, txtGST1.Text, lblfinalprice1.Text, nameCookie.Value);

                }

            }
            datafill();
        }

        protected void DeleteCustomer(object sender, EventArgs e)
        {
            int customerId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("localorderid") as Label).Text);

            {
                DataTable dt6 = new DataTable();
                dt6 = citywarehouse.local_add_delete_book(customerId);

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

                Label customerid = (Label)item.FindControl("localorderid");
                TextBox txtqty1 = (TextBox)item.FindControl("txtqty");
                TextBox txtlocal1 = (TextBox)item.FindControl("txtlocal");
                TextBox txttotalprice = (TextBox)item.FindControl("txtprice");
                TextBox txtdiscount1 = (TextBox)item.FindControl("txtdiscount");
                TextBox txtGST1 = (TextBox)item.FindControl("txtGST");
                Label lblfinalprice1 = (Label)item.FindControl("lblfinalprice");
                Label item_id = (Label)item.FindControl("lblitem_id");

                {
                    DataTable dt7 = new DataTable();
                    dt7 = citywarehouse.local_add_place_book(customerid.Text, order_id, txtqty1.Text, locationid.Value, txtlocal1.Text, txttotalprice.Text
                        , txtdiscount1.Text, txtGST1.Text, lblfinalprice1.Text, nameCookie.Value);

                    order_id = dt7.Rows[0]["order_id"].ToString();

                }
                {
                    DataTable dt8 = new DataTable();
                    dt8 = citywarehouse.local_rec_save_book(txtqty.Text, order_id, customerid.Text, txtexdt.Text, "", locationid.Value,
                        "", txtpurchasecost.Text, txtGST1.Text, txtdiscount1.Text, lblfinalprice1.Text);


                    DataTable dt9 = new DataTable();
                    dt9 = citywarehouse.local_rec_stock_book(txtqty.Text, item_id.Text, locationid.Value, "");

                }

            }

            datafill();
        }

    }
}