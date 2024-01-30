using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class Mainsite : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {

                HttpCookie adminloginuser = Request.Cookies["usersname"];
                HttpCookie adminname = Request.Cookies["name"];
                Label1.Text = adminloginuser.Value;
                Label2.Text = adminname.Value;

                HttpCookie roleid = Request.Cookies["roles"];

                if (roleid.Value == "city_book")
                {
                    citystock.Visible = true;
                    cityreport.Visible = true;
                    //citycenter.Visible = true;
                    citywh.Visible = true;
                    citysplr.Visible = true;
                    cityAU.Visible = true;
                    citylocal.Visible = true;

                    whstock.Visible = false;
                    whreport.Visible = false;
                    wh.Visible = false;
                    whsplr.Visible = false;
                    whUP.Visible = false;
                    whlocal.Visible = false;
                }
                else
                {
                    whstock.Visible = true;
                    whreport.Visible = true;
                    wh.Visible = true;
                    whsplr.Visible = true;
                    whUP.Visible = true;
                    whlocal.Visible = true;

                    citystock.Visible = false;
                    cityreport.Visible = false;
                    //citycenter.Visible = false;
                    citywh.Visible = false;
                    citysplr.Visible = false;
                    cityAU.Visible = false;
                    citylocal.Visible = false;
                }
            }
           
        }

        protected void btncheck_Click(object sender, EventArgs e)
        {
            //Fetch the Cookie using its Key.
            HttpCookie nameCookie = Request.Cookies["usersid"];

            //Set the Expiry date to past date.
            nameCookie.Expires = DateTime.Now.AddDays(-1);

            //Update the Cookie in Browser.
            Response.Cookies.Add(nameCookie);
            Response.Redirect("Login.aspx");
        }

        protected void btncheck_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Change_Password.aspx");
        }
    }
}