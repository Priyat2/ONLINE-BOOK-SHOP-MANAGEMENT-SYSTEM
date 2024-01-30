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
    public partial class splr_vs_book_items : System.Web.UI.Page
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
                dt = Lead.get_suppliers_book();
                ddlsuplier.DataSource = dt;
                ddlsuplier.DataBind();
                ddlsuplier.DataTextField = "splr_name";
                ddlsuplier.DataValueField = "pk_splr_id";
                ddlsuplier.DataBind();



                DataTable dt1 = new DataTable();
                dt1 = Lead.get_items_book();
                ddlitem.DataSource = dt1;
                ddlitem.DataBind();
                ddlitem.DataTextField = "book_item_name";
                ddlitem.DataValueField = "pk_book_item_id";
                ddlitem.DataBind();


                getid.Value = Request.QueryString["id"];

                if (getid.Value == "")
                {

                }
                else
                {

                    DataTable dt7 = new DataTable();
                    dt7 = Lead.get_items_vs_book_by_id(getid.Value);

                    //ddlcity.SelectedValue = dt7.Rows[0]["svi_city_id"].ToString();
                    ddlsuplier.SelectedValue = dt7.Rows[0]["svi_splr_id"].ToString();
                    ddlitem.SelectedValue = dt7.Rows[0]["svi_item_id"].ToString();


                }
            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string abc = "0";

            HttpCookie nameCookie = Request.Cookies["usersid"];
            DataTable dt = new DataTable();
            dt = Lead.splr_vs_item_book_i_u(getid.Value, abc, ddlsuplier.SelectedValue, ddlitem.SelectedValue, nameCookie.Value);

            Response.Redirect("Show_Splr_vs_book_item.aspx");
        }
    }
}