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
    public partial class View_Local_order_Regionalwh : System.Web.UI.Page
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
                dt = citywarehouse.local_rec_rep(getid.Value);
              
                Repeater.DataSource = dt;
                Repeater.DataBind();
               
                lblorderid1.Text = getid.Value;

               
                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.local_rec_rep_get_by_id(getid.Value);

                lbllocalname.Text = dt3.Rows[0]["trlo_local_shop"].ToString();
                lbltotalqty.Text = dt3.Rows[0]["lo_item_qty"].ToString();
                lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt3.Rows[0]["lo_item_price"].ToString();
                
                lbldate.Text = dt3.Rows[0]["lo_order_dt"].ToString();
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
                Label fk_id = (Label)item.FindControl("lblloid");
                Label pk_id = (Label)item.FindControl("lbltrloid");
                Label item_id = (Label)item.FindControl("lblitemid");

                {
                    DataTable dt = new DataTable();
                    dt = citywarehouse.local_rec_save(txtqty.Text, fk_id.Text, pk_id.Text, txtexdt.Text, txtbacth.Text, locationid.Value,
                        txtbonusqty.Text, txtpriceper.Text, txtrate.Text, txtdisc.Text, finalprice.Text);


                    DataTable dt1 = new DataTable();
                    dt1 = citywarehouse.local_rec_stock(txtqty.Text, item_id.Text, locationid.Value, txtbonusqty.Text);
                    

                    DataTable dt2 = new DataTable();
                    dt2 = citywarehouse.local_rec_invoice(getid.Value, txtinvoice.Text, txtgrn.Text);


                }
            }

            
            DataTable dt3 = new DataTable();
            dt3 = citywarehouse.local_rec_delivery(getid.Value, locationid.Value, lbldelch.Text);

            Response.Redirect("Order_to_Local_Regionalwh_Approval.aspx");
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order_to_Local_Regionalwh_Approval.aspx");
        }
    }
}