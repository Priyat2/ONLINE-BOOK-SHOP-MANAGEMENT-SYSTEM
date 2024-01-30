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
    public partial class book_Req_from_Center : System.Web.UI.Page
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
                dt = citywarehouse.book_center_req_list(locationid.Value);

                if (dt.Rows.Count > 0)
                {
                    Repeater.DataSource = dt;
                    Repeater.DataBind();
                }
                //datafill();


            }

        }

        //protected void datafill()
        //{

        //    HttpCookie locationid = Request.Cookies["location"];
        //    DataTable dt = new DataTable();        
        //    dt = citywarehouse.book_center_req_list(locationid.Value);

        //    if (dt.Rows.Count > 0)
        //    {
        //        Repeater.DataSource = dt;
        //        Repeater.DataBind();
        //    }
        //}


        //protected void transfer(object sender, EventArgs e)
        //{
        //    HttpCookie nameCookie = Request.Cookies["usersid"];
        //    int id = int.Parse(((sender as LinkButton).NamingContainer.FindControl("lblcheck") as Label).Text);


        //    DataTable dt1 = new DataTable();
        //    dt1 = citywarehouse.book_transfer(nameCookie.Value, id);

        //    datafill();

        //}


    }
}