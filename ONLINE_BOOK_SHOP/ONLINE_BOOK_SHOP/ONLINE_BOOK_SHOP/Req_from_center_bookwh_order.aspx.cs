using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Core;

namespace ONLINE_BOOK_SHOP
{
    public partial class Req_from_center_bookwh_order : System.Web.UI.Page
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

             
                dt = MainWarehouse.get_pending_whreq_from_center(UserManagement.getCurrentLocaionId());

                if (dt.Rows.Count > 0)
                {
                    repeater.DataSource = dt;
                    repeater.DataBind();
                }
            }
        }
     }
 }
