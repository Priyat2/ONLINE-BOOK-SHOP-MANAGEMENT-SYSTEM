using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class New_Recript : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false) { 
            if (Request.Cookies["usersid"] == null)
            {
                Response.Redirect("Login.aspx");
            }

            getid.Value = Request.QueryString["id"];
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_records_of_tr_po_get", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@trpo_fk_po_id", getid.Value);
            cmd.Connection.Open();
            repeater.DataSource = cmd.ExecuteReader();
            repeater.DataBind();
            cmd.Connection.Close();

                lblpono.Text = getid.Value;

                SqlConnection con3 = new SqlConnection(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
                SqlCommand cmd3 = new SqlCommand("sp_ms_purchase_order_get_byid", con3);
                cmd3.CommandType = System.Data.CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@pk_po_id", getid.Value);
                DataTable dt3 = new DataTable();
                SqlDataAdapter da3 = new SqlDataAdapter(cmd3);
                da3.Fill(dt3);

                lblpatname.Text = dt3.Rows[0]["splr_name"].ToString();
                lbldate.Text = dt3.Rows[0]["po_order_dt"].ToString();
                lbladdress.Text = dt3.Rows[0]["splr_address"].ToString();
                lblgrossamount.Text = dt3.Rows[0]["po_item_price"].ToString();
            }
        }
    }
}