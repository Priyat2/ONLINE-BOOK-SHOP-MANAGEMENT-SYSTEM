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
    public partial class Order_to_Local_Regionalwh_Approval : System.Web.UI.Page
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
                dt = citywarehouse.local_list_rep(locationid.Value);
                
                Repeater.DataSource= dt;
                Repeater.DataBind();
             
            }
        }

        protected void btndash_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order_to_Local_Regional_wh.aspx");
        }
    }
    }
