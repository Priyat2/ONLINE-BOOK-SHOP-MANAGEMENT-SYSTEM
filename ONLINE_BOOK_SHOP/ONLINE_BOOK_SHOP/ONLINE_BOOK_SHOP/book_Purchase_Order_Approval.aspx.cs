using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;
using System.Data;

namespace ONLINE_BOOK_SHOP
{
    public partial class book_Purchase_Order_Approval : System.Web.UI.Page
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
                dt = citywarehouse.get_book_purchase_order_list(locationid.Value);

                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

            }

        }

        protected void btndash_Click(object sender, EventArgs e)
        {
            Response.Redirect("Book_Purchase_Order.aspx");
        }
    }
}