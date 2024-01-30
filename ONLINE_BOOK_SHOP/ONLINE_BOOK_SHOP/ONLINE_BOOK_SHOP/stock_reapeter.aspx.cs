using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;
namespace ONLINE_BOOK_SHOP
{
    public partial class stock_reapeter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                HttpCookie locationid = Request.Cookies["location"];
                DataTable dt = new DataTable();
                dt = citywarehouse.get_warehouse_stock(locationid.Value);

                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();

                }

            }
        }
    }
}