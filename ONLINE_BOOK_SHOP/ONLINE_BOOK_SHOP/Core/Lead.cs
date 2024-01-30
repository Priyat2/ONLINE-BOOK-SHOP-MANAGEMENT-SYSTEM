using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Web;
using Core;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using static Core.UserManagement;




namespace Core
{
   public class Lead
    {
        public static DataTable clinic_details_i(string locid, string loc_name, string loc_address, string loc_landmark, string loc_contact, string loc_active, string loc_emailid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_center_details_i", new System.Data.SqlClient.SqlParameter("@locid", locid), new System.Data.SqlClient.SqlParameter("@loc_name", loc_name), new System.Data.SqlClient.SqlParameter("@loc_address", loc_address), new System.Data.SqlClient.SqlParameter("@loc_landmark", loc_landmark), new System.Data.SqlClient.SqlParameter("@loc_contact", loc_contact), new System.Data.SqlClient.SqlParameter("@loc_active", loc_active), new System.Data.SqlClient.SqlParameter("@loc_emailid", loc_emailid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables[0];
        }
 
        public static DataSet getmedical_info(int registeration_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.SelectDataSetByParameters("udsp_get_medical_info_byid", new System.Data.SqlClient.SqlParameter("@registeration_id", registeration_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }

        public static DataTable center_repeater_date(string startdate, string enddate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("center_consult_rep", new System.Data.SqlClient.SqlParameter("@startdate", startdate), new System.Data.SqlClient.SqlParameter("@enddate", enddate));
            return ds.Tables[0];
        }

        public static DataTable center_repeater()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("center_consult_rep");
            return ds.Tables[0];
        }

        public static DataTable consult_repeater()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_treat_rep", new SqlParameter("@doc_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        
        }
        public static DataTable consult_repeater2(string consult_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_doc_id_get", new SqlParameter("@pk_consultant_treatment_id", consult_id),
                new SqlParameter("@doc_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }

        public static DataTable consult_display(string consult_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_treat_done", new SqlParameter("@pk_consultant_treatment_id", consult_id), new SqlParameter("@doc_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }


        public static DataTable doc_repeater()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_doc_rep", new SqlParameter("@consult_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }
        public static DataTable doc_repeater2(string startdate, string enddate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_doc_rep", new SqlParameter("@startdate", startdate), new SqlParameter("@enddate", enddate), new SqlParameter("@consult_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }

       

        public static DataTable consult()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_service");
            return ds.Tables[0];
        }

        public static DataTable get_category_name()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_category_name");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable orderlist_center_order(int locid)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_center_order_get", new SqlParameter("@loc_id", getCurrentLocaionId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }

        public static DataTable get_item_name(int category_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_book_item_name", new SqlParameter("@category_id", category_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable itemlist_rep(int locid, int product_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_center_order_list_rep", new SqlParameter("@center_id", locid), new SqlParameter("@fk_ms_id", product_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable stock_available_item(int user_id, int item_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_get_stock_avaiable", new SqlParameter("@loc_id", user_id), new SqlParameter("@book_item_id", item_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable order_insert(string item_name, string quantity, string price, int created_by, int order_for)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_book_center_order_i", new SqlParameter("@book_item_name", item_name), new SqlParameter("@quantity", quantity), new SqlParameter("@price", price), new SqlParameter("@created_by", UserManagement.getCurrentUserId()), new SqlParameter("@order_for", order_for));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable delete_order(int orderid, int delete, int modified_by)
        {
            DataTable dt;
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_book_order_delete", new SqlParameter("@orderid", orderid), new SqlParameter("@delete", delete), new SqlParameter("@modified_by", modified_by));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable update_order(int orderid, int quantity, int price, int modified_by)
        {
            DataTable dt;
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_book_order_update", new SqlParameter("@orderid", orderid), new SqlParameter("@quantity", quantity), new SqlParameter("@price", price), new SqlParameter("@modified_by", modified_by));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }


        public static DataTable get_item_price(int item_id)
        {
            DataTable dt;
            DataView dtv = new DataView();
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_item_cost", new SqlParameter("@pk_book_item_id", item_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable order_rep(int user_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_book_order_rep", new SqlParameter("@order_created_by", user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }

        public static DataTable order_insert_transaction(string pk_order_id, string fk_order_id, string center_id, string order_qty, string price, string order_by, string order_for)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_book_tr_order_i", new SqlParameter("@pk_order_id", pk_order_id), new SqlParameter("@pk_tr_order_book_id", fk_order_id), new SqlParameter("@center_loc", getCurrentLocaionId()), new SqlParameter("@order_quantity", order_qty), new SqlParameter("@order_price", price), new SqlParameter("@order_by", order_by), new SqlParameter("@order_for", order_for));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }



        public static DataTable stock_book_available_item(int user_id, int item_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_get_book_stock_avaiable", new SqlParameter("@loc_id", user_id), new SqlParameter("@item_id", item_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }

       
        public static DataTable center_consult_lead_rep(string leadid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_patient_detail_get", new SqlParameter("@leadid", leadid));
            return ds.Tables[0];
        }
        
        public static DataTable consult2(string leadid, string service_name,
            string treatment_date, string treatment_time, string requirement)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consul_treat_i", new SqlParameter("@service_name", service_name),
                new SqlParameter("@treatment_date", treatment_date), new SqlParameter("@treatment_time", treatment_time),
                new SqlParameter("@requirement", requirement), new SqlParameter("@leadid", leadid), new SqlParameter("@created_by", UserManagement.getCurrentUserId()), new SqlParameter("@loc_id",UserManagement.getCurrentLocaionId()));
            return ds.Tables[0];
        }

        public static DataTable Login_User_ERP(string username, string password, string user_ip)
        {
            int leadid = 0;
           
                DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
                Encryption.MD5Encryption crypto = new Encryption.MD5Encryption();
                // udsp_latest_employee_login
                int userId = -1;
                DataTable res;
                res = data.SelectByParamDT("udsp_latest_employee_login", new SqlParameter("@user_name", username), new SqlParameter("@Password", crypto.Encode(password)), new SqlParameter("@appl_id", "3"));
                return res;
            
           
        }

        public static DataTable doctor_dropdown()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_doctor_select");

            return ds.Tables[0];
        }

        public static DataTable doctor_fill(string consultid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_doctor_bind", new SqlParameter("@fk_consult_id", consultid));
            return ds.Tables[0];
        }

        public static DataTable consult_doctor_insert(string consultid, string name, string service, string rating, string centerid, string city)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_doctor_i_u", new SqlParameter("@fk_consult_id", consultid), new SqlParameter("@consult_name", name),
                new SqlParameter("@service_name", service), new SqlParameter("@rating", rating), new SqlParameter("@center_id", centerid), new SqlParameter("@city", city), new SqlParameter("@modified_by", UserManagement.getCurrentLocaionId()),
                new SqlParameter("@created_by", UserManagement.getCurrentLocaionId()));

            return ds.Tables[0];
        }

        public static DataTable reschedule_insert(string leadid, string date, string time)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_reschedule_consult_treat", new SqlParameter("@leadid", leadid), new SqlParameter("@date", date),
              new SqlParameter("@time",time) ,new SqlParameter("@modified_by", UserManagement.getCurrentLocaionId()));
            return ds.Tables[0];
        }

        public static DataTable consult_confirm(string consult_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_confirm", new SqlParameter("@pk_consultant_treatment_id", consult_id), new SqlParameter("@doc_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }

        public static DataTable consult_cancel(string consult_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_cancel", new SqlParameter("@pk_consultant_treatment_id", consult_id), new SqlParameter("@doc_id", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }

        public static DataTable patient_view(string leadid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_patient_view", new SqlParameter("@fk_consult_treatment_id", leadid));
            return ds.Tables[0];
        }

        public static DataTable consult_treat_cancel(string leadid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consult_treat_cancel", new SqlParameter("@leadid", leadid));
            return ds.Tables[0];
        }

        public static DataTable appt_repeater(string leadid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("patient_consult_appt_get", new SqlParameter("@leadid", leadid));
            return ds.Tables[0];
        }

        public static DataTable reschedule_pat_rep(string leadid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_reschedule_rep", new SqlParameter("@leadid", leadid));
            return ds.Tables[0];
        }

        public static DataTable consult_report(string consultid,  string startdate, string enddate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consultant_detail_report", new SqlParameter("@consultid", UserManagement.getCurrentUserId()), new SqlParameter("@startdate", startdate),
                new SqlParameter("@enddate", enddate));
            return ds.Tables[0];
        }

        public static DataTable consult_reportp(string consultid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_consultant_detail_report", new SqlParameter("@consultid", UserManagement.getCurrentUserId()));
            return ds.Tables[0];
        }

        public static DataTable items_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_item_show");
            return res;
        }

        public static DataTable book_items_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_item_show");
            return res;
        }

        //public static DataTable items_get_by_search(string category_type, string item_type, string item_name)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("get_item_detail_by_cat_type_id", new System.Data.SqlClient.SqlParameter("@item_icat_name", category_type), new System.Data.SqlClient.SqlParameter("@item_itype_name", item_type)
        //        , new System.Data.SqlClient.SqlParameter("@item_name", item_name));
        //    return res;
        //}

        public static DataTable item_cat_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_cat");
            return res;
        }

        public static DataTable item_book_cat_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_book_all_item_cat");
            return res;
        }

        public static DataTable item_types_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_types");
            return res;
        }

        public static DataTable book_item_types_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_types_book");
            return res;
        }

        public static DataTable item_unit_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_unit");
            return res;
        }


        public static DataTable item_bookunit_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_book_item_unit");
            return res;
        }


        public static DataTable item_details_get_by_id(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_detail_by_id", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;
        }

        public static DataTable bookitem_details_get_by_id(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("book_item_detail_by_id", new System.Data.SqlClient.SqlParameter("@pk_book_item_id", item_id));
            return res;
        }


        public static DataTable item_transaction_i_u(string id, string item_name, string description, string category,string type, string short_name, string image_path,
            string item_code, string sort_order, string unit, string per_pc_unit, string notes, string sale_cost, string sale_cost_out,
            string sale_cost_old, string sale_cost_out_old, string purchase_cost, string IGST, string CGST, string SGST, string HSN, string HSNDesc,
             string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_itemss_transaction_i_u", new System.Data.SqlClient.SqlParameter("@pk_item_id", id), new System.Data.SqlClient.SqlParameter("@item_name", item_name),
                new System.Data.SqlClient.SqlParameter("@item_desc", description), new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", category),
               new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", type), new System.Data.SqlClient.SqlParameter("@item_short_name", short_name),
               new System.Data.SqlClient.SqlParameter("@item_image_path", image_path), new System.Data.SqlClient.SqlParameter("@item_code", item_code),
                new System.Data.SqlClient.SqlParameter("@item_sort_order", sort_order), new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", unit),
                new System.Data.SqlClient.SqlParameter("@item_pcs_per_unit", per_pc_unit), new System.Data.SqlClient.SqlParameter("@item_notes", notes),
                new System.Data.SqlClient.SqlParameter("@item_sale_cost", sale_cost), new System.Data.SqlClient.SqlParameter("@item_sale_cost_out", sale_cost_out),
               new System.Data.SqlClient.SqlParameter("@item_sale_cost_old", sale_cost_old), new System.Data.SqlClient.SqlParameter("@item_sale_cost_out_old", sale_cost_out_old),
               new System.Data.SqlClient.SqlParameter("@item_purchase_cost", purchase_cost), new System.Data.SqlClient.SqlParameter("@IGST", IGST),
               new System.Data.SqlClient.SqlParameter("@CGST", CGST), new System.Data.SqlClient.SqlParameter("@SGST", SGST),
               new System.Data.SqlClient.SqlParameter("@HSN", HSN), new System.Data.SqlClient.SqlParameter("@HSNDesc", HSNDesc), new System.Data.SqlClient.SqlParameter("@item_created_by", created_by));
            return res;
        }

        public static DataTable book_item_tr_i_u(string id, string book_item_name, string description, string category, string type, string short_name, string image_path,
           string item_code, string sort_order, string unit, string per_pc_unit, string notes, string sale_cost, string sale_cost_out,
           string sale_cost_old, string sale_cost_out_old, string purchase_cost, string IGST, string CGST, string SGST, string HSN, string HSNDesc,
            string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_itemss_tr_i_u", new System.Data.SqlClient.SqlParameter("@pk_book_item_id", id), new System.Data.SqlClient.SqlParameter("@book_item_name", book_item_name),
                new System.Data.SqlClient.SqlParameter("@item_desc", description), new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", category),
               new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", type), new System.Data.SqlClient.SqlParameter("@item_short_name", short_name),
               new System.Data.SqlClient.SqlParameter("@item_image_path", image_path), new System.Data.SqlClient.SqlParameter("@item_code", item_code),
                new System.Data.SqlClient.SqlParameter("@item_sort_order", sort_order), new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", unit),
                new System.Data.SqlClient.SqlParameter("@item_pcs_per_unit", per_pc_unit), new System.Data.SqlClient.SqlParameter("@item_notes", notes),
                new System.Data.SqlClient.SqlParameter("@item_sale_cost", sale_cost), new System.Data.SqlClient.SqlParameter("@item_sale_cost_out", sale_cost_out),
               new System.Data.SqlClient.SqlParameter("@item_sale_cost_old", sale_cost_old), new System.Data.SqlClient.SqlParameter("@item_sale_cost_out_old", sale_cost_out_old),
               new System.Data.SqlClient.SqlParameter("@item_purchase_cost", purchase_cost), new System.Data.SqlClient.SqlParameter("@IGST", IGST),
               new System.Data.SqlClient.SqlParameter("@CGST", CGST), new System.Data.SqlClient.SqlParameter("@SGST", SGST),
               new System.Data.SqlClient.SqlParameter("@HSN", HSN), new System.Data.SqlClient.SqlParameter("@HSNDesc", HSNDesc), new System.Data.SqlClient.SqlParameter("@item_created_by", created_by));
            return res;
        }

        public static DataTable get_all_supplier()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_all_supplier_rpt");
            return res;
        }

        public static DataTable get_all_supplier_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_all_splr_book_rpt");
            return res;
        }

        public static DataTable get_all_supplier_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_supplier_detail_by_id", new System.Data.SqlClient.SqlParameter("@pk_splr_id", id));
            return res;
        }

        public static DataTable get_all_splr_by_book_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_splr_detail_by_book_id", new System.Data.SqlClient.SqlParameter("@pk_splr_id", id));
            return res;
        }

        public static DataTable supplier_i_u(string id, string name , string short_name, string code, string desc, string type, string address,
           string country_id ,string contact, string phone, string email, string img_path , string web_add, string zip,
            string fax, string terms, string license, string autho_per , string tax_dt, string discount , string created_by, string gstno)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_suppliers_i_u", new System.Data.SqlClient.SqlParameter("@pk_splr_id", id), new System.Data.SqlClient.SqlParameter("@splr_name", name),
                new System.Data.SqlClient.SqlParameter("@splr_short_name", short_name), new System.Data.SqlClient.SqlParameter("@splr_code", code), new System.Data.SqlClient.SqlParameter("@splr_desc", desc),
                 new System.Data.SqlClient.SqlParameter("@splr_fk_type_id", type), new System.Data.SqlClient.SqlParameter("@splr_address", address),
                 new System.Data.SqlClient.SqlParameter("@splr_fk_country_id", country_id), new System.Data.SqlClient.SqlParameter("@splr_contact", contact),
                 new System.Data.SqlClient.SqlParameter("@splr_phone", phone), new System.Data.SqlClient.SqlParameter("@splr_email", email), new System.Data.SqlClient.SqlParameter("@splr_image_path", img_path),
                 new System.Data.SqlClient.SqlParameter("@splr_web_address", web_add), new System.Data.SqlClient.SqlParameter("@splr_zip_code", zip), new System.Data.SqlClient.SqlParameter("@splr_fax_no", fax),
                  new System.Data.SqlClient.SqlParameter("@splr_terms", terms), new System.Data.SqlClient.SqlParameter("@splr_license", license), new System.Data.SqlClient.SqlParameter("@splr_auth_person", autho_per),
                   new System.Data.SqlClient.SqlParameter("@splr_taxation_det", tax_dt), new System.Data.SqlClient.SqlParameter("@splr_discount", discount), new System.Data.SqlClient.SqlParameter("@admin_created_by", created_by)
                   , new System.Data.SqlClient.SqlParameter("@splr_gst_no", gstno));
            return res;
        }


        public static DataTable supplier_book_i_u(string id, string name, string short_name, string code, string desc, string type, string address,
           string country_id, string contact, string phone, string email, string img_path, string web_add, string zip,
            string fax, string terms, string license, string autho_per, string tax_dt, string discount, string created_by, string gstno)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_suppliers_book_i_u", new System.Data.SqlClient.SqlParameter("@pk_splr_id", id), new System.Data.SqlClient.SqlParameter("@splr_name", name),
                new System.Data.SqlClient.SqlParameter("@splr_short_name", short_name), new System.Data.SqlClient.SqlParameter("@splr_code", code), new System.Data.SqlClient.SqlParameter("@splr_desc", desc),
                 new System.Data.SqlClient.SqlParameter("@splr_fk_type_id", type), new System.Data.SqlClient.SqlParameter("@splr_address", address),
                 new System.Data.SqlClient.SqlParameter("@splr_fk_country_id", country_id), new System.Data.SqlClient.SqlParameter("@splr_contact", contact),
                 new System.Data.SqlClient.SqlParameter("@splr_phone", phone), new System.Data.SqlClient.SqlParameter("@splr_email", email), new System.Data.SqlClient.SqlParameter("@splr_image_path", img_path),
                 new System.Data.SqlClient.SqlParameter("@splr_web_address", web_add), new System.Data.SqlClient.SqlParameter("@splr_zip_code", zip), new System.Data.SqlClient.SqlParameter("@splr_fax_no", fax),
                  new System.Data.SqlClient.SqlParameter("@splr_terms", terms), new System.Data.SqlClient.SqlParameter("@splr_license", license), new System.Data.SqlClient.SqlParameter("@splr_auth_person", autho_per),
                   new System.Data.SqlClient.SqlParameter("@splr_taxation_det", tax_dt), new System.Data.SqlClient.SqlParameter("@splr_discount", discount), new System.Data.SqlClient.SqlParameter("@admin_created_by", created_by)
                   , new System.Data.SqlClient.SqlParameter("@splr_gst_no", gstno));
            return res;
        }

        public static DataTable get_suppliers()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier");
            return res;
        }

        public static DataTable get_suppliers_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier_book");
            return res;
        }

        public static DataTable get_item_by_splr_id(string supplier_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_by_supplier_id", new System.Data.SqlClient.SqlParameter("@svi_splr_id", supplier_id));
            return res;
        }

        public static DataTable get_item_by_splr_book_id(string supplier_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_by_splr_book_id", new System.Data.SqlClient.SqlParameter("@svi_splr_id", supplier_id));
            return res;
        }

        public static DataTable get_items()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_items");
            return res;
        }

        public static DataTable get_items_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_book_items");
            return res;
        }

        public static DataTable get_items_vs_item_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_supplier_vs_item_detail_by_id", new System.Data.SqlClient.SqlParameter("@pk_splr_item_id", id));
            return res;
        }

        public static DataTable get_items_vs_book_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_splr_vs_item_detail_by_id", new System.Data.SqlClient.SqlParameter("@pk_splr_item_id", id));
            return res;
        }

        public static DataTable splr_vs_item_i_u(string id, string city, string supplier, string item, string created_by )
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_supplier_vs_item_i_u", new System.Data.SqlClient.SqlParameter("@pk_splr_item_id", id),
                new System.Data.SqlClient.SqlParameter("@svi_city_id", city),new System.Data.SqlClient.SqlParameter("@svi_splr_id", supplier),
                new System.Data.SqlClient.SqlParameter("@svi_item_id", item), new System.Data.SqlClient.SqlParameter("@admin_created_by", created_by));
            return res;
        }

        public static DataTable splr_vs_item_book_i_u(string id, string city, string supplier, string item, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_splr_vs_book_item_i_u", new System.Data.SqlClient.SqlParameter("@pk_splr_item_id", id),
                new System.Data.SqlClient.SqlParameter("@svi_city_id", city), new System.Data.SqlClient.SqlParameter("@svi_splr_id", supplier),
                new System.Data.SqlClient.SqlParameter("@svi_item_id", item), new System.Data.SqlClient.SqlParameter("@admin_created_by", created_by));
            return res;
        }

        public static DataTable get_items_type_admin()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_type_admin");
            return res;
        }

        public static DataTable get_items_type_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_type_book");
            return res;
        }


        public static DataTable item_type_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_items_type_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_itype_name", type_name), new System.Data.SqlClient.SqlParameter("@item_itype_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_itype_created_by", created_by));
            return res;
        }

        public static DataTable book_item_type_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_items_type_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_itype_name", type_name), new System.Data.SqlClient.SqlParameter("@item_itype_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_itype_created_by", created_by));
            return res;
        }

        public static DataTable get_items_type_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_type_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", id));
            return res;
        }

        public static DataTable get_book_items_type_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_book_item_type_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_itype_id", id));
            return res;
        }

        public static DataTable get_items_unit_admin()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_unit_admin");
            return res;
        }

        public static DataTable get_items_unit_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_unit_book");
            return res;
        }

        public static DataTable item_unit_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_item_unit_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_unit_name", type_name), new System.Data.SqlClient.SqlParameter("@item_unit_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_unit_created_by", created_by));
            return res;
        }

        public static DataTable book_item_unit_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_item_unit_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_unit_name", type_name), new System.Data.SqlClient.SqlParameter("@item_unit_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_unit_created_by", created_by));
            return res;
        }

        public static DataTable get_items_unit_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_unit_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", id));
            return res;
        }

        public static DataTable get_book_items_unit_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_book_item_unit_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_unit_id", id));
            return res;
        }

        public static DataTable get_items_subcat_admin()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_sub_cat_admin");
            return res;
        }

        public static DataTable get_items_subcat_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_sub_cat_book");
            return res;
        }

        public static DataTable item_subcat_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_itemss_itemsubcat_i_u", new System.Data.SqlClient.SqlParameter("@item_sub_cat_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_sub_cat_name", type_name), new System.Data.SqlClient.SqlParameter("@item_sub_cat_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_sub_cat_created_by", created_by));
            return res;
        }


        public static DataTable book_item_subcat_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_itemss_itemsubcat_i_u", new System.Data.SqlClient.SqlParameter("@item_sub_cat_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_sub_cat_name", type_name), new System.Data.SqlClient.SqlParameter("@item_sub_cat_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_sub_cat_created_by", created_by));
            return res;
        }

        public static DataTable get_items_subcat_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_itemss_itemsubcat", new System.Data.SqlClient.SqlParameter("@item_sub_cat_id", id));
            return res;
        }

        public static DataTable get_book_items_subcat_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_itemss_itemsubcat", new System.Data.SqlClient.SqlParameter("@item_sub_cat_id", id));
            return res;
        }

        public static DataTable get_items_cat_admin()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_cat_admin");
            return res;
        }

        public static DataTable get_items_cat_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_cat_book");
            return res;
        }

        public static DataTable get_cat_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_cat_books");
            return res;
        }

        public static DataTable item_cat_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_item_category_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_icat_name", type_name), new System.Data.SqlClient.SqlParameter("@item_icat_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_icat_created_by", created_by));
            return res;
        }


        public static DataTable book_item_cat_i_u(string type_id, string type_name, string is_active, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_item_category_i_u", new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", type_id)
                , new System.Data.SqlClient.SqlParameter("@item_icat_name", type_name), new System.Data.SqlClient.SqlParameter("@item_icat_is_active", is_active)
                , new System.Data.SqlClient.SqlParameter("@item_icat_created_by", created_by));
            return res;
        }

        public static DataTable get_items_cat_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_cat_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", id));
            return res;
        }

        public static DataTable get_book_items_cat_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_book_item_cat_detail_by_id", new System.Data.SqlClient.SqlParameter("@item_fk_icat_id", id));
            return res;
        }

        public static DataTable change_password(string old_pass, string new_pass, string user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_user_master_u", new System.Data.SqlClient.SqlParameter("@old_pass", old_pass),
                new System.Data.SqlClient.SqlParameter("@new_password", new_pass), new System.Data.SqlClient.SqlParameter("@pk_user_id", user_id));
            return res;
        }

        public static DataTable get_state()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_all_state");
            return res;
        }

        public static DataTable get_cityby_state(string state)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString1);
            DataTable res;
            res = data.SelectByParamDT("get_allcity_by_stateid", new System.Data.SqlClient.SqlParameter("@pk_state_id ", state));
            return res;
        }
    }

}
