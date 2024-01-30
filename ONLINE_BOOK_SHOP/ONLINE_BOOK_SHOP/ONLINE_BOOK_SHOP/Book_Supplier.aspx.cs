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
    public partial class Book_Supplier : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {

                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }


                //DataTable dt = new DataTable();
                //dt = Lead.get_state();
                //ddlsuplstate.DataSource = dt;
                //ddlsuplstate.DataBind();
                //ddlsuplstate.DataTextField = "state_name";
                //ddlsuplstate.DataValueField = "pk_state_id";
                //ddlsuplstate.DataBind();





                getid.Value = Request.QueryString["id"];

                if (getid.Value == "")
                {

                }
                else
                {

                    DataTable dt7 = new DataTable();
                    dt7 = Lead.get_all_splr_by_book_id(getid.Value);

                    txtsuplname.Text = dt7.Rows[0]["splr_name"].ToString();
                    txtshortname.Text = dt7.Rows[0]["splr_short_name"].ToString();
                    txtsuplcode.Text = dt7.Rows[0]["splr_code"].ToString();

                    txtsupldesc.Text = dt7.Rows[0]["splr_desc"].ToString();
                    ddlsupltype.SelectedValue = dt7.Rows[0]["splr_fk_type_id"].ToString();
                    txtsupladd.Text = dt7.Rows[0]["splr_address"].ToString();

                    //ddlsuplcity.SelectedValue = dt7.Rows[0]["splr_fk_city_id"].ToString();
                    //ddlsuplstate.SelectedValue = dt7.Rows[0]["splr_fk_state_id"].ToString();
                    ddlsuplcountry.SelectedValue = dt7.Rows[0]["splr_fk_country_id"].ToString();

                    txtsuplcontact.Text = dt7.Rows[0]["splr_contact"].ToString();
                    txtsuplphone.Text = dt7.Rows[0]["splr_phone"].ToString();
                    txtsuplemail.Text = dt7.Rows[0]["splr_email"].ToString();

                    txtimagepath.Text = dt7.Rows[0]["splr_image_path"].ToString();
                    txtwebadd.Text = dt7.Rows[0]["splr_web_address"].ToString();
                    txtzipcode.Text = dt7.Rows[0]["splr_zip_code"].ToString();

                    txtsuplfax.Text = dt7.Rows[0]["splr_fax_no"].ToString();
                    txtterms.Text = dt7.Rows[0]["splr_terms"].ToString();
                    txtsupllincense.Text = dt7.Rows[0]["splr_license"].ToString();

                    txtauthoper.Text = dt7.Rows[0]["splr_auth_person"].ToString();
                    txttaxdate.Text = dt7.Rows[0]["splr_taxation_det"].ToString();
                    txtdiscount.Text = dt7.Rows[0]["splr_discount"].ToString();
                    txtgstno.Text = dt7.Rows[0]["splr_gst_no"].ToString();
                }
            }

        }

        protected void ddlitemname_SelectedIndexChanged1(object sender, EventArgs e)
        {
            //string abc;
            //abc = ddlsuplstate.SelectedValue;

            //DataTable dt1 = new DataTable();
            //dt1 = Lead.get_cityby_state(abc);
            //ddlsuplcity.DataSource = dt1;
            //ddlsuplcity.DataBind();
            //ddlsuplcity.DataTextField = "city_name";
            //ddlsuplcity.DataValueField = "pk_city_id";
            //ddlsuplcity.DataBind();


        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            DataTable dt = new DataTable();
            dt = Lead.supplier_book_i_u(getid.Value, txtsuplname.Text, txtshortname.Text, txtsuplcode.Text, txtsupldesc.Text, ddlsupltype.SelectedValue, txtsupladd.Text,
                ddlsuplcountry.SelectedValue, txtsuplcontact.Text, txtsuplphone.Text, txtsuplemail.Text,
               txtimagepath.Text, txtwebadd.Text, txtzipcode.Text, txtsuplfax.Text, txtterms.Text, txtsupllincense.Text, txtauthoper.Text, txttaxdate.Text, txtdiscount.Text, nameCookie.Value, txtgstno.Text);

            Response.Redirect("Book_Show_Supplier.aspx");
        }
    }
}