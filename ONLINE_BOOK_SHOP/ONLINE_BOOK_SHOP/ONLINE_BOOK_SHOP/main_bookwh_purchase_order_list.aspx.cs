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
    public partial class main_bookwh_purchase_order_list : System.Web.UI.Page
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

                DataTable dt = new DataTable();
                dt = MainWarehouse.get_book_purchase_order_list(locationid.Value);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();

                }
            }

        }

        //protected void btndash_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Main_bookwh_purchase_order.aspx");
        //}
    }
}