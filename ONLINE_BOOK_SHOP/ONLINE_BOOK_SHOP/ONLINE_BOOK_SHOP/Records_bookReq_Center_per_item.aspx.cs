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
    public partial class Records_bookReq_Center_per_item : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                getid.Value = Request.QueryString["id"];

                DataTable dt = new DataTable();
                dt = citywarehouse.center_req_bookreport_per_item(getid.Value);
                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }

                lblorderid1.Text = getid.Value;



                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.complete_bookreq_bind_data(getid.Value);

                lbltotalqty.Text = dt3.Rows[0]["otw_qty"].ToString();
                lbllocation.Text = dt3.Rows[0]["center_name"].ToString();
                lbltotalprice.Text = "Rs." + dt3.Rows[0]["otw_price"].ToString();
                lbldesc.Text = dt3.Rows[0]["otw_desc"].ToString();
                lbldate.Text = dt3.Rows[0]["otw_order_dt"].ToString();
            }
        }

        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("Records_of_Req_Book_Centers.aspx");
        }
    }
}