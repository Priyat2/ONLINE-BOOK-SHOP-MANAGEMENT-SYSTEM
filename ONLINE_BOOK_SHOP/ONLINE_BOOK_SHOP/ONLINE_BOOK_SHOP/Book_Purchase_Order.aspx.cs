using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using System.Web.Services;
using System.Text;
using Core;

namespace ONLINE_BOOK_SHOP
{
    public partial class Book_Purchase_Order : System.Web.UI.Page
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
                dt = citywarehouse.get_all_splr_book_list();

                ddlsupplier.DataSource = dt;
                ddlsupplier.DataBind();
                ddlsupplier.DataTextField = "splr_name";
                ddlsupplier.DataValueField = "pk_splr_id";
                ddlsupplier.DataBind();


                DataTable dt1 = new DataTable();
                dt1 = citywarehouse.get_item_by_splr_book();

                ddlitemname.DataSource = dt1;
                ddlitemname.DataBind();
                ddlitemname.DataTextField = "book_item_name";
                ddlitemname.DataValueField = "svi_item_id";               
                ddlitemname.DataBind();

               

                datafill();

            }
        }

        protected void datafill()
        {
            DataTable dt2 = new DataTable();
            dt2 = citywarehouse.get_purchase_order_book_rep();
            if (dt2.Rows.Count > 0)
            {
                repeater1.DataSource = dt2;
                repeater1.DataBind();
            }



            if (dt2.Rows.Count > 0)
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

            DataTable dt3 = new DataTable();
            dt3 = citywarehouse.get_book_item_detail_by_id(abc);
            lblsalecost.Text = dt3.Rows[0]["item_sale_cost"].ToString();
            lblpurchasecost.Text = dt3.Rows[0]["item_purchase_cost"].ToString();
            lblunits.Text = dt3.Rows[0]["item_unit_name"].ToString();

            DataTable dt4 = new DataTable();
            dt4 = citywarehouse.get_avail_stock_byid(abc, locationid.Value);
            lblqty.Text = dt4.Rows[0]["stk_available_qty"].ToString();

        }

        protected void btnadd_Click(object sender, EventArgs e)
        {
            HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];

            DataTable dt5 = new DataTable();
            dt5 = citywarehouse.book_purchase_order_add(ddlitemname.SelectedValue, txtqty.Text, lblpurchasecost.Text, locationid.Value,
                ddlsupplier.SelectedValue, ddlgst.SelectedValue, txtdiscount.Text, nameCookie.Value);

            datafill();
        }



        protected void btnUpdateCart_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            foreach (RepeaterItem item in repeater1.Items)
            {
                TextBox txtdisc = (TextBox)item.FindControl("txtdiscount");
                DropDownList ddlgst = (DropDownList)item.FindControl("ddlgstre");
                TextBox txtqty = (TextBox)item.FindControl("txtquantity1");
                Label lblprodId = (Label)item.FindControl("orderid");
                Label lbltotalprice = (Label)item.FindControl("lblprice");
                Label lblfinalprice = (Label)item.FindControl("lblfinalprice");
                {
                    DataTable dt6 = new DataTable();
                    dt6 = citywarehouse.book_purchase_order_u(lblfinalprice.Text, txtdisc.Text, ddlgst.SelectedValue, lblprodId.Text,
                        txtqty.Text, lbltotalprice.Text, nameCookie.Value);


                }


            }
            datafill();
        }


        protected void DeleteCustomer(object sender, EventArgs e)
        {
            int customerId = int.Parse(((sender as LinkButton).NamingContainer.FindControl("orderid") as Label).Text);

            {
                DataTable dt7 = new DataTable();
                dt7 = citywarehouse.book_purchase_order_del(customerId);

            }

            datafill();
        }

        protected void btnplace_Click(object sender, EventArgs e)
        {
            //HttpCookie locationid = Request.Cookies["location"];
            HttpCookie nameCookie = Request.Cookies["usersid"];
            String order_id = "0";
            foreach (RepeaterItem item in repeater1.Items)
            {

                Label customerid = (Label)item.FindControl("orderid");
                TextBox txtqty = (TextBox)item.FindControl("txtquantity1");
                Label lblfinalprice = (Label)item.FindControl("lblfinalprice");
                Label warehouse = (Label)item.FindControl("lblwh");
                Label supplier = (Label)item.FindControl("lblsplr");
                Label desc = (Label)item.FindControl("lbldesc");
                Label price = (Label)item.FindControl("lblprice");
                {
                    DataTable dt8 = new DataTable();
                    dt8 = citywarehouse.book_purchase_order_place(customerid.Text, order_id, txtqty.Text, warehouse.Text, supplier.Text, desc.Text,
                        price.Text, lblfinalprice.Text, nameCookie.Value);
       

                    order_id = dt8.Rows[0]["order_id"].ToString();

                }


            }
            Response.Redirect("book_Purchase_Order_Approval.aspx");
        }

        protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DropDownList ddlstatus = (e.Item.FindControl("ddlgstre") as DropDownList);
                HiddenField hdstatus = (e.Item.FindControl("hdstatus") as HiddenField);
                ddlstatus.SelectedValue = hdstatus.Value;
               
            }
        }

      


    }
}