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
    public partial class book_itemss_ms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack == false)
            {
                if (Request.Cookies["usersid"] == null)
                {
                    Response.Redirect("Login.aspx");
                }

                DataTable dt = new DataTable();
                dt = Lead.item_book_cat_get();
                ddlcat.DataSource = dt;
                ddlcat.DataValueField = "item_fk_icat_id";
                ddlcat.DataTextField = "item_icat_name";
                ddlcat.DataBind();



                DataTable dt1 = new DataTable();
                dt1 = Lead.book_item_types_get();
                ddlItemtype.DataSource = dt1;
                ddlItemtype.DataValueField = "item_fk_itype_id";
                ddlItemtype.DataTextField = "item_itype_name";
                ddlItemtype.DataBind();


                DataTable dt2 = new DataTable();
                dt2 = Lead.item_bookunit_get();
                ddlitemunit.DataSource = dt2;
                ddlitemunit.DataValueField = "item_fk_unit_id";
                ddlitemunit.DataTextField = "item_unit_name";
                ddlitemunit.DataBind();

                //SqlConnection connection3 = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                //SqlCommand cmnd3 = new SqlCommand("get_all_item_sub_cat", connection3);
                //cmnd3.CommandType = System.Data.CommandType.StoredProcedure;
                //SqlDataAdapter adapt3 = new SqlDataAdapter(cmnd3);
                //DataTable dt3 = new DataTable();
                //adapt3.Fill(dt3);
                //ddlitemsubcat.DataSource = dt3;
                //ddlitemsubcat.DataValueField = "item_sub_cat_id";
                //ddlitemsubcat.DataTextField = "item_sub_cat_name";
                //ddlitemsubcat.DataBind();


                getid1.Value = Request.QueryString["id"];
                if (getid1.Value == "")

                {
                }

                else
                {


                    DataTable dt4 = new DataTable();
                    dt4 = Lead.bookitem_details_get_by_id(getid1.Value);

                    txtitemname.Text = dt4.Rows[0]["book_item_name"].ToString();
                    txtitemdesc.Text = dt4.Rows[0]["item_desc"].ToString();
                    itemimagepath.Text = dt4.Rows[0]["item_image_path"].ToString();
                    ddlcat.SelectedValue = dt4.Rows[0]["item_fk_icat_id"].ToString();
                    ddlItemtype.SelectedValue = dt4.Rows[0]["item_fk_itype_id"].ToString();
                    itemshortname.Text = dt4.Rows[0]["item_short_name"].ToString();
                    txtitemcode.Text = dt4.Rows[0]["item_code"].ToString();
                    txtitemsortorder.Text = dt4.Rows[0]["item_sort_order"].ToString();
                    ddlitemunit.SelectedValue = dt4.Rows[0]["item_fk_unit_id"].ToString();
                    pcsperunit.Text = dt4.Rows[0]["item_pcs_per_unit"].ToString();
                    itemnotes.Text = dt4.Rows[0]["item_notes"].ToString();
                    itemsalecost.Text = dt4.Rows[0]["item_sale_cost"].ToString();
                    salecostout.Text = dt4.Rows[0]["item_sale_cost_out"].ToString();
                    salecostold.Text = dt4.Rows[0]["item_sale_cost_old"].ToString();
                    salecostoutold.Text = dt4.Rows[0]["item_sale_cost_out_old"].ToString();
                    purchasecost.Text = dt4.Rows[0]["item_purchase_cost"].ToString();
                    //showinwh.Text = dt4.Rows[0]["item_show_in_wh"].ToString();
                    //showinreport.Text = dt4.Rows[0]["item_show_in_report"].ToString();
                    //showinerp.Text = dt4.Rows[0]["item_show_in_erp"].ToString();
                    //showinentry.Text = dt4.Rows[0]["item_show_in_entry"].ToString();
                    //itemishf.Text = dt4.Rows[0]["item_ishf"].ToString();
                    ddlIGST.SelectedValue = dt4.Rows[0]["IGST"].ToString();
                    ddlCGST.SelectedValue = dt4.Rows[0]["CGST"].ToString();
                    ddlSGST.SelectedValue = dt4.Rows[0]["SGST"].ToString();
                    HSN.Text = dt4.Rows[0]["HSN"].ToString();
                    HSNDesc.Text = dt4.Rows[0]["HSNDesc"].ToString();
                    //IGSTPercentage.Text = dt4.Rows[0]["IGSTPercentage"].ToString();
                    //CGSTPercentage.Text = dt4.Rows[0]["CGSTPercentage"].ToString();
                    //SGSTPercentage.Text = dt4.Rows[0]["SGSTPercentage"].ToString();
                    //  ddlitemsubcat.SelectedValue = dt4.Rows[0]["item_sub_cat_id"].ToString();

                }

            }
        }

        protected void btnsubmit_Click(object sender, EventArgs e)
        {
            HttpCookie nameCookie = Request.Cookies["usersid"];
            DataTable dt3 = new DataTable();
            dt3 = Lead.book_item_tr_i_u(getid1.Value, txtitemname.Text, txtitemdesc.Text, ddlcat.SelectedValue, ddlItemtype.SelectedValue, itemshortname.Text,
               itemimagepath.Text, txtitemcode.Text, txtitemsortorder.Text, ddlitemunit.SelectedValue, pcsperunit.Text, itemnotes.Text, itemsalecost.Text,
              salecostout.Text, salecostold.Text, salecostoutold.Text, purchasecost.Text, ddlIGST.SelectedValue, ddlCGST.SelectedValue, ddlSGST.SelectedValue,
             HSN.Text, HSNDesc.Text, nameCookie.Value);

            {
                Response.Redirect("book_items_rp_ms.aspx");
            }
        }
    }
}