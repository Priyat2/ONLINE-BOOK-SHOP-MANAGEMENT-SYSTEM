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
    public partial class center_to_center_book_req : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                datafill();



            }
        }

        protected void datafill()
        {
            HttpCookie locationid = Request.Cookies["location"];
            DataTable dt = new DataTable();
            dt = citywarehouse.center_to_center_book_req(locationid.Value);
            if (dt.Rows.Count > 0)
            {
                Repeater.DataSource = dt;
                Repeater.DataBind();
            }
        }

        protected void Repeater_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            if (e.CommandName == "reject")
            {

                Label id = e.Item.FindControl("lblcheck") as Label;

                DataTable dt1 = new DataTable();
                dt1 = citywarehouse.center_to_center_book_req_rej(id.Text);

                datafill();
            }

            if (e.CommandName == "approve")
            {

                Label id = e.Item.FindControl("lblcheck") as Label;
                DropDownList center_id = e.Item.FindControl("ddlcenters") as DropDownList;


                DataTable dt2 = new DataTable();
                dt2 = citywarehouse.center_to_center_book_req_aproove(id.Text, center_id.SelectedValue);

                datafill();
            }
        }


        protected void OnItemDataBound(object sender, RepeaterItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {

                DropDownList ddlcenters = (e.Item.FindControl("ddlcenters") as DropDownList);
                DataTable dt3 = new DataTable();
                dt3 = citywarehouse.book_centers_get();
                ddlcenters.DataSource = dt3;
                ddlcenters.DataValueField = "wvl_fk_loc_id";
                ddlcenters.DataTextField = "center_name";
                ddlcenters.DataBind();
            }
        }
    }
}