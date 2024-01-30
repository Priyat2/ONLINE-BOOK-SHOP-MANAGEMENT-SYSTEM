using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Core;

namespace ONLINE_BOOK_SHOP
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack == false)
            {



            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtuserpass.Text;
           
            DataTable dt = new DataTable();
            dt = UserManagement.Login_User_Warehouse(username, password);

            if (dt.Rows[0]["flag"].ToString() == "1")
            {
                HttpCookie nameCookie = new HttpCookie("usersid");
                nameCookie.Value = dt.Rows[0]["userid"].ToString();
                nameCookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(nameCookie);

                HttpCookie adminloginuser = new HttpCookie("usersname");
                adminloginuser.Value = dt.Rows[0]["username"].ToString();
                adminloginuser.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(adminloginuser);

                HttpCookie adminname = new HttpCookie("name");
                adminname.Value = dt.Rows[0]["name"].ToString();
                adminname.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(adminname);

                HttpCookie locationid = new HttpCookie("location");
                locationid.Value = dt.Rows[0]["locid"].ToString();
                locationid.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(locationid);

                HttpCookie roleid = new HttpCookie("roles");
                roleid.Value = dt.Rows[0]["role"].ToString();
                roleid.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(roleid);

                if (dt.Rows[0]["role"].ToString() == "Main_Center")
                {
                    Response.Redirect("Req_from_city_book_Wh.aspx");
                }
                else
                {
                    Response.Redirect("book_stocks.aspx");
                }

            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language='javascript'>");
                sb.Append("alert('Something Went Wrong!');");
                sb.Append("</script>");
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", sb.ToString());
            }
        }
    }
}