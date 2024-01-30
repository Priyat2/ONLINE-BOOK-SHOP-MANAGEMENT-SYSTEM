using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;
using System.Data;
using Core;


namespace ONLINE_BOOK_SHOP
{
    public partial class Order_to_Center : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            if (IsPostBack == false)
            {

                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                string ipaddress = Request.ServerVariables["remote_addr"];
                int isAuthStatus1 = 0;

                
                string authResult = UserManagement.Is_User_Authenticate(UserManagement.getCurrentUserId(), "ServiceSummary ", ipaddress, ipaddress, Request.Url.ToString());

                
                if (int.TryParse(authResult, out isAuthStatus1))
                {
                   
                    databind();
                }
                else
                {
                    
                    Response.Write("Error converting authentication status to integer.");
                }
            }


        }


        public void databind()
        {
            
            DataTable dt;
            dt = Lead.orderlist_center_order(UserManagement.getCurrentUserId());

            if (dt.Rows.Count > 0)
            {
                repeater1.DataSource = dt;
                repeater1.DataBind();
            }
            else
            {
                repeater1.DataSource = "";
                repeater1.DataBind();
                repeater1.Visible = false;
                StringBuilder sb = new StringBuilder();
                sb.Append("<script language='javascript'>");
                sb.Append("Swal.fire({icon: 'error',title: 'No order request found from centers.',text: '',})");
                sb.Append("</script>");
                Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Alert", sb.ToString());
            }
        }
    }
}
