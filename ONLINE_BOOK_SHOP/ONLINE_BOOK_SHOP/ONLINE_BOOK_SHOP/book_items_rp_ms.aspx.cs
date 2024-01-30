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
    public partial class book_items_rp_ms : System.Web.UI.Page
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
                dt = Lead.book_items_get();

                if (dt.Rows.Count > 0)
                {
                    repeater.DataSource = dt;
                    repeater.DataBind(); /*get_item_detail_by_cat_type_id*/
                }

            }
        }


        protected void btnsubmit_Click1(object sender, EventArgs e)
        {
            Response.Redirect("book_itemss_ms.aspx");
        }
    }

}