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
    public partial class Change_Password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];

            DataTable dt = new DataTable();
            dt = Lead.change_password(oldpass.Text, newpass.Text, nameCookie.Value);
            
            Response.Redirect("Login.aspx");
        }
    }
}