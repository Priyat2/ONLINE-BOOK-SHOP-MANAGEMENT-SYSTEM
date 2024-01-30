using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using System.Diagnostics;
using System.Globalization;
using System.IO;
 using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
 using Microsoft.VisualBasic;
using System.Web;
using System.Configuration;
using Core;
using System.Data;
using Encryption;
namespace Core
{
    public class citywarehouse



    {
        public static DataTable center_req_report_per_item(string orderid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_towh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", orderid));
            return res;

        }

        public static DataTable center_req_bookreport_per_item(string orderid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_to_book_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", orderid));
            return res;

        }

        public static DataTable center_order_towh_get(string orderid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", orderid));
            return res;

        }

        public static DataTable center_req_list(string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_req_from_center_get", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable book_center_req_list(string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_req_from_book_center", new System.Data.SqlClient.SqlParameter("@locid", locid));
            return res;

        }

        public static DataTable center_to_center_req(string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_to_center", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable center_to_center_book_req(string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_to_center_book", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable center_to_center_rep(string locid, string startdt, string enddt)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_to_center_report", new System.Data.SqlClient.SqlParameter("@loc_id", locid)
                , new System.Data.SqlClient.SqlParameter("@start_date", startdt), new System.Data.SqlClient.SqlParameter("@end_date", enddt));
            return res;

        }


        public static DataTable center_to_center_req_rej(string pk_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_req_reject", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id));
            return res;

        }

        public static DataTable center_to_center_book_req_rej(string pk_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_center_req_reject", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id));
            return res;

        }

        public static DataTable center_to_center_req_aproove(string pk_id, string center_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_center", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id), new System.Data.SqlClient.SqlParameter("@center_id", center_id));
            return res;

        }

        public static DataTable center_to_center_book_req_aproove(string pk_id, string center_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_book_center", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id), new System.Data.SqlClient.SqlParameter("@center_id", center_id));
            return res;

        }

        public static DataTable center_req_report(string startdate, string enddate, string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_ms_order_to_wh", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", locid)
               );
            return res;

        }

        public static DataTable center_req_book_report(string startdate, string enddate, string locid)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_ms_order_to_book", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", locid)
               );
            return res;

        }


        public static DataTable get_all_center_stock(string loc_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_stock_byid", new System.Data.SqlClient.SqlParameter("@fk_loc_id", loc_id));
            return res;

        }


        public static DataTable get_all_book_center_stock(string loc_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_center_stock_byid", new System.Data.SqlClient.SqlParameter("@fk_loc_id", loc_id));
            return res;

        }


        public static DataTable get_all_supplier_list()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier");
            return res;

        }

        public static DataTable get_all_splr_book_list()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_splr_book");
            return res;

        }

        public static DataTable get_warehouse_stock(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_clinic_stock_wh_get", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable get_book_stocks(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_stock_wh_get", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }



        public static DataTable get_all_item()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_items");
            return res;

        }

        public static DataTable get_all_book_item()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_book_items");
            return res;

        }

        public static DataTable get_order_rep(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_order_rep", new System.Data.SqlClient.SqlParameter("@order_created_by", locid));
            return res;

        }

        public static DataTable get_book_order_rep(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_order_rep", new System.Data.SqlClient.SqlParameter("@order_created_by", locid));
            return res;

        }

        public static DataTable get_item_detail_by_id(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;

        }

        public static DataTable get_book_item_detail_by_id(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_book_item_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_book_item_id", item_id));
            return res;

        }

        public static DataTable send_mail_warehouse(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_send_mail", new System.Data.SqlClient.SqlParameter("@order_id", order_id));
            return res;

        }

        public static DataTable get_available_stk_by_id(string item_id, string lodic)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", lodic));
            return res;

        }

        public static DataTable get_available_bookstk_by_id(string item_id, string lodic)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_bookitem_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", lodic));
            return res;

        }

        public static DataTable get_avai_main_stk_by_id(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_main_stock_by_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id));
            return res;

        }

        public static DataTable get_avai_main_bookstk_by_id(string item_id,string lodic)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("avail_main_stock_by_bookitem_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@loc_id", lodic));
            return res;

        }


        public static DataTable city_to_mainwh_order_i(string item_id, string qty, string purchase, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_center_order_i", new System.Data.SqlClient.SqlParameter("@item_name", item_id),
                new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", purchase),
                new System.Data.SqlClient.SqlParameter("@created_by", locid));
            return res;

        }


        public static DataTable city_to_mainwh_book_order_i(string item_id, string qty, string purchase, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_center_order_i", new System.Data.SqlClient.SqlParameter("@book_item_name", item_id),
                new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", purchase),
                new System.Data.SqlClient.SqlParameter("@created_by", locid));
            return res;

        }


        public static DataTable city_to_mainwh_order_u(string order_id, string qty, string price, string modified)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_order_update", new System.Data.SqlClient.SqlParameter("@orderid", order_id),
                new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", price),
                new System.Data.SqlClient.SqlParameter("@modified_by", modified));
            return res;

        }

        public static DataTable city_to_mainwh_book_order_u(string order_id, string qty, string price, string modified)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_order_update", new System.Data.SqlClient.SqlParameter("@orderid", order_id),
                new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", price),
                new System.Data.SqlClient.SqlParameter("@modified_by", modified));
            return res;

        }

        public static DataTable city_to_mainwh_place_order(string order_id, string order, string qty, string price, string center_loc, string order_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_transaction_order_i", new System.Data.SqlClient.SqlParameter("@pk_tr_order_id", order_id),
                new System.Data.SqlClient.SqlParameter("@pk_order_id", order), new System.Data.SqlClient.SqlParameter("@order_quantity", qty),
                new System.Data.SqlClient.SqlParameter("@order_price", price), new System.Data.SqlClient.SqlParameter("@center_loc", center_loc),
                new System.Data.SqlClient.SqlParameter("@order_by", order_by));
            return res;

        }

        public static DataTable city_to_mainbook_place_order(string order_id, string order, string qty, string price, string center_loc, string order_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_tr_order_i", new System.Data.SqlClient.SqlParameter("@pk_tr_order_book_id", order_id),
                new System.Data.SqlClient.SqlParameter("@pk_order_id", order), new System.Data.SqlClient.SqlParameter("@order_quantity", qty),
                new System.Data.SqlClient.SqlParameter("@order_price", price), new System.Data.SqlClient.SqlParameter("@center_loc", center_loc),
                new System.Data.SqlClient.SqlParameter("@order_by", order_by));
            return res;

        }

        public static DataTable city_to_mainwh_order_del(int order_id, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_order_delete", new System.Data.SqlClient.SqlParameter("@orderid", order_id),
                new System.Data.SqlClient.SqlParameter("@modified_by", locid));
            return res;

        }

        public static DataTable city_to_mainbook_order_del(int order_id, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_order_delete", new System.Data.SqlClient.SqlParameter("@orderid", order_id),
                new System.Data.SqlClient.SqlParameter("@modified_by", locid));
            return res;

        }

        public static DataTable city_to_mainwh_order_details(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_towh_get", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable city_to_mainbook_order_details(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_tobook_get", new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;

        }

        public static DataTable city_to_mainwh_order_rec_rep(string id ,string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_order_list_rep", new System.Data.SqlClient.SqlParameter("@fk_ms_id", id),
                new System.Data.SqlClient.SqlParameter("@center_id", locid));
            return res;

        }


        public static DataTable city_to_mainbook_order_rec_rep(string id, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_order_list_rep", new System.Data.SqlClient.SqlParameter("@fk_ms_id", id),
                new System.Data.SqlClient.SqlParameter("@center_id", locid));
            return res;

        }

        public static DataTable city_to_mainwh_item_get(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", id));
            return res;

        }

        public static DataTable city_to_mainwh_item_rec_i(string order_id, string rec_qty, string id, string loc_id , string item_id, string recieve_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_item_received", new System.Data.SqlClient.SqlParameter("@pk_tr_order_id", order_id), new System.Data.SqlClient.SqlParameter("@tr_order_receive_qty", rec_qty),
                 new System.Data.SqlClient.SqlParameter("@ms_order_id", id), new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@itemid", item_id)
                 , new System.Data.SqlClient.SqlParameter("@otw_recieve_name", recieve_name));
            return res;

        }

        public static DataTable city_to_mainbook_item_rec_i(string order_id, string rec_qty, string id, string loc_id, string item_id, string recieve_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_book_item_received", new System.Data.SqlClient.SqlParameter("@pk_tr_order_id", order_id), new System.Data.SqlClient.SqlParameter("@tr_order_receive_qty", rec_qty),
                 new System.Data.SqlClient.SqlParameter("@ms_order_id", id), new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@itemid", item_id)
                 , new System.Data.SqlClient.SqlParameter("@otw_recieve_name", recieve_name));
            return res;

        }

        public static DataTable get_city_to_mainwh_item_byid(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_towh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id));
            return res;

        }

        public static DataTable get_city_to_mainbook_item_byid(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_tobook_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id));
            return res;

        }

        public static DataTable get_citywh_item_byid(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", id));
            return res;

        }

        public static DataTable city_to_mainwh_item_detail(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_rec_ms_order_to_wh", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate),
                 new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable city_to_mainbook_item_detail(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_rec_ms_order_to_book", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate),
                 new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable get_purchase_order_rep()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_purchase_order_rpt");
            return res;

        }


        public static DataTable get_purchase_order_book_rep()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_purchase_order_book_rpt");
            return res;

        }


        public static DataTable get_item_by_supplier()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_by_supplier");
            return res;

        }

        public static DataTable get_item_by_splr_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_by_splr_book");
            return res;

        }


        public static DataTable get_item_details_byid(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;

        }

        public static DataTable get_available_stock_byid(string item_id,string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable get_avail_stock_byid(string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_avail_stock_by_book_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable purchase_order_add(string item_id,string qty,string price, string wh_id, string supplier_id, string tax, string discount, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_purchase_order_i", new System.Data.SqlClient.SqlParameter("@trpo_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@trpo_item_qty", qty), new System.Data.SqlClient.SqlParameter("@trpo_item_price", price),
                  new System.Data.SqlClient.SqlParameter("@trpo_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@trpo_splr_id", supplier_id),
                    new System.Data.SqlClient.SqlParameter("@trpo_tax_percent", tax), new System.Data.SqlClient.SqlParameter("@trpo_discount_percent", discount),
                      new System.Data.SqlClient.SqlParameter("@trpo_created_by", created_by));
            return res;

        }


        public static DataTable book_purchase_order_add(string item_id, string qty, string price, string wh_id, string supplier_id, string tax, string discount, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_book_purchase_order_i", new System.Data.SqlClient.SqlParameter("@trpo_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@trpo_item_qty", qty), new System.Data.SqlClient.SqlParameter("@trpo_item_price", price),
                  new System.Data.SqlClient.SqlParameter("@trpo_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@trpo_splr_id", supplier_id),
                    new System.Data.SqlClient.SqlParameter("@trpo_tax_percent", tax), new System.Data.SqlClient.SqlParameter("@trpo_discount_percent", discount),
                      new System.Data.SqlClient.SqlParameter("@trpo_created_by", created_by));
            return res;

        }

        public static DataTable purchase_order_u(string total_price, string discount, string gst, string order_id, string qty, string price, string modified_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_purchase_order_u", new System.Data.SqlClient.SqlParameter("@total_price", total_price),
                new System.Data.SqlClient.SqlParameter("@discount", discount), new System.Data.SqlClient.SqlParameter("@gst", gst),
                  new System.Data.SqlClient.SqlParameter("@orderid", order_id), new System.Data.SqlClient.SqlParameter("@quantity", qty),
                    new System.Data.SqlClient.SqlParameter("@price", price), new System.Data.SqlClient.SqlParameter("@modified_by", modified_by));
            return res;

        }

        public static DataTable book_purchase_order_u(string total_price, string discount, string gst, string order_id, string qty, string price, string modified_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_purchase_order_u", new System.Data.SqlClient.SqlParameter("@total_price", total_price),
                new System.Data.SqlClient.SqlParameter("@discount", discount), new System.Data.SqlClient.SqlParameter("@gst", gst),
                  new System.Data.SqlClient.SqlParameter("@orderid", order_id), new System.Data.SqlClient.SqlParameter("@quantity", qty),
                    new System.Data.SqlClient.SqlParameter("@price", price), new System.Data.SqlClient.SqlParameter("@modified_by", modified_by));
            return res;

        }

        public static DataTable purchase_order_del(int item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_purchase_order_del", new System.Data.SqlClient.SqlParameter("@CustomerId", item_id));
            return res;

        }

        public static DataTable book_purchase_order_del(int item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_purchase_order_del", new System.Data.SqlClient.SqlParameter("@CustomerId", item_id));
            return res;

        }

        public static DataTable complete_req_bind_data(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", id));
            return res;

        }


        public static DataTable complete_bookreq_bind_data(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_book_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_book_id", id));
            return res;

        }

        public static DataTable complete_center_req_rep(string id, string loc_id )
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_order_towh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable complete_bookcenter_req_rep(string id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_order_to_center", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable complete_center_req_save(string qty, string fk_id, string pk_id ,string confm_by, string confm_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_wh_confm_qty", new System.Data.SqlClient.SqlParameter("@confirm_qty", qty), new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", fk_id)
                , new System.Data.SqlClient.SqlParameter("@pk_tr_order_id", pk_id), new System.Data.SqlClient.SqlParameter("@confirm_by", confm_by)
                , new System.Data.SqlClient.SqlParameter("@confm_name", confm_name));
            return res;

        }

        public static DataTable complete_center_req_book_save(string qty, string fk_id, string pk_id, string confm_by, string confm_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_book_confm_qty", new System.Data.SqlClient.SqlParameter("@confirm_qty", qty), new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", fk_id)
                , new System.Data.SqlClient.SqlParameter("@pk_tr_order_book_id", pk_id), new System.Data.SqlClient.SqlParameter("@confirm_by", confm_by)
                , new System.Data.SqlClient.SqlParameter("@confm_name", confm_name));
            return res;

        }

        public static DataTable complete_center_req_stock_minus(string qty, string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_stock_minus", new System.Data.SqlClient.SqlParameter("@qty", qty), new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", loc_id));
            return res;

        }

        public static DataTable complete_book_center_req_stock_minus(string qty, string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_center_stock_minus", new System.Data.SqlClient.SqlParameter("@qty", qty), new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", loc_id));
            return res;

        }

        public static DataTable purchase_order_place(string po_id, string order_id, string qty, string wh_id, string supplier_id, string desc, string price, string total_price, string order_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_purchase_order_i_u", new System.Data.SqlClient.SqlParameter("@pk_trpo_id", po_id),
                new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id), new System.Data.SqlClient.SqlParameter("@po_item_qty", qty),
                  new System.Data.SqlClient.SqlParameter("@pk_fk_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@po_fk_supplier_id", supplier_id),
                    new System.Data.SqlClient.SqlParameter("@po_desc", desc), new System.Data.SqlClient.SqlParameter("@po_item_price", price),
                    new System.Data.SqlClient.SqlParameter("@totalpric", total_price), new System.Data.SqlClient.SqlParameter("@po_order_by", order_by));
            return res;

        }

        public static DataTable book_purchase_order_place(string po_id, string order_id, string qty, string wh_id, string supplier_id, string desc, string price, string total_price,  string order_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_purchase_order_i_u", new System.Data.SqlClient.SqlParameter("@pk_trpo_id", po_id),
                new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id), new System.Data.SqlClient.SqlParameter("@po_item_qty", qty),
                  new System.Data.SqlClient.SqlParameter("@fk_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@po_fk_supplier_id", supplier_id),
                    new System.Data.SqlClient.SqlParameter("@po_desc", desc), new System.Data.SqlClient.SqlParameter("@po_item_price", price),
                    new System.Data.SqlClient.SqlParameter("@totalpric", total_price), new System.Data.SqlClient.SqlParameter("@po_order_by", order_by));
            return res;

        }

        //public static DataTable book_purchase_order_place(string order_id, string order, string qty, string price, string center_loc, string order_by)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_ms_book_purchase_order_i_u", new System.Data.SqlClient.SqlParameter("@pk_trpo_id", order_id),
        //        new System.Data.SqlClient.SqlParameter("@pk_po_id", order), new System.Data.SqlClient.SqlParameter("@po_item_qty", qty),
        //        new System.Data.SqlClient.SqlParameter("@po_item_price", price), new System.Data.SqlClient.SqlParameter("@center_loc", center_loc),
        //        new System.Data.SqlClient.SqlParameter("@po_order_by", order_by));
        //    return res;

        //}

        public static DataTable get_purchase_order_list(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_purchase_order_get", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable get_book_purchase_order_list(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_purchase_order_get", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable get_purchase_order_item(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_purchase_order_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;

        }

        public static DataTable book_purchase_order_item(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_book_purchase_order_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;

        }

        public static DataTable get_purchase_order_item_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_purchase_order_get_byid", new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id));
            return res;

        }

        public static DataTable book_purchase_order_item_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_purchase_order_get_byid", new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id));
            return res;

        }

        public static DataTable add_total_purchase_order(string pk_id , string loc_id, string delivery)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_add_total_ms", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id),
                new System.Data.SqlClient.SqlParameter("@receive_by", loc_id) ,new System.Data.SqlClient.SqlParameter("@delivery", delivery));
            return res;

        }

        public static DataTable book_add_total_purchase_order(string pk_id, string loc_id, string delivery)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_add_total_ms", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id),
                new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@delivery", delivery));
            return res;

        }

        public static DataTable get_purchase_order_rec(string qty , string order_id, string id, string expiry_dt, string batch, string loc_id, string bonus,string price_per,
            string rate, string disc, string total)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_purchase_order_rec_u", new System.Data.SqlClient.SqlParameter("@available_qty", qty),
                new System.Data.SqlClient.SqlParameter("@trpo_fk_id", order_id), new System.Data.SqlClient.SqlParameter("@pk_trpo_id", id),
                new System.Data.SqlClient.SqlParameter("@expiry_dt", expiry_dt), new System.Data.SqlClient.SqlParameter("@batch_no", batch),
                new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus),
                new System.Data.SqlClient.SqlParameter("@price_per", price_per), new System.Data.SqlClient.SqlParameter("@rate", rate),
                new System.Data.SqlClient.SqlParameter("@disc", disc), new System.Data.SqlClient.SqlParameter("@total", total));
            return res;

        }


        public static DataTable book_purchase_order_rec(string qty, string order_id, string id, string expiry_dt, string batch, string loc_id, string bonus, string price_per,
           string rate, string disc, string total)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_purchase_order_rec_u", new System.Data.SqlClient.SqlParameter("@available_qty", qty),
                new System.Data.SqlClient.SqlParameter("@trpo_fk_id", order_id), new System.Data.SqlClient.SqlParameter("@pk_trpo_id", id),
                new System.Data.SqlClient.SqlParameter("@expiry_dt", expiry_dt), new System.Data.SqlClient.SqlParameter("@batch_no", batch),
                new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus),
                new System.Data.SqlClient.SqlParameter("@price_per", price_per), new System.Data.SqlClient.SqlParameter("@rate", rate),
                new System.Data.SqlClient.SqlParameter("@disc", disc), new System.Data.SqlClient.SqlParameter("@total", total));
            return res;

        }

        public static DataTable center_stock_u(string qty, string item_id, string loc_id,string bonus)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_stock_u", new System.Data.SqlClient.SqlParameter("@stk_available_qty", qty),
                new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id)
                , new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus));
            return res;

        }

        public static DataTable book_center_stock_u(string qty, string item_id, string loc_id, string bonus)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_center_stock_u", new System.Data.SqlClient.SqlParameter("@stk_available_qty", qty),
                new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id)
                , new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus));
            return res;

        }

        public static DataTable purchase_order_invoice_i(string id, string invoice)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_po_invoice", new System.Data.SqlClient.SqlParameter("@pk_id", id),
                new System.Data.SqlClient.SqlParameter("@invoice", invoice) /*, new System.Data.SqlClient.SqlParameter("@grn", grn)*/);
            return res;

        }

        public static DataTable purchase_order_bookinvoice_i(string id, string invoice)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_book_po_invoice", new System.Data.SqlClient.SqlParameter("@pk_id", id),
                new System.Data.SqlClient.SqlParameter("@invoice", invoice) /*, new System.Data.SqlClient.SqlParameter("@grn", grn)*/);
            return res;

        }

        //public static DataTable purchase_order_view(string order_id)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_records_of_tr_po_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
        //    return res;

        //}

        public static DataTable book_purchase_order_view(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_tr_bookpo_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;

        }

        //public static DataTable purchase_order_byid(string order_id)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_ms_purchase_order_get_byid", new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id));
        //    return res;

        //}

        public static DataTable receipt_rep(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_tr_po_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;

        }

        public static DataTable book_receipt_rep(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_records_of_tr_po_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;

        }


        public static DataTable centers_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_centers_get_drop");
            return res;

        }

        public static DataTable book_centers_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_centers_get_drop");
            return res;

        }

        public static DataTable receipt_details_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_purchase_order_get_byid", new System.Data.SqlClient.SqlParameter("@pk_po_id", order_id));
            return res;

        }

        public static DataTable records_of_purchase_order(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_ms_po_get", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
                 new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable book_records_of_purchase_order(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_records_of_ms_po_get", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
                 new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable transfer(string loc_id, int pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_transfer_order", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id),
                new System.Data.SqlClient.SqlParameter("@pk_id", pk_id));
            return res;
        }

        public static DataTable book_transfer(string loc_id, int pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_transfer_order", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id),
                new System.Data.SqlClient.SqlParameter("@pk_id", pk_id));
            return res;
        }


        public static DataTable citycenterspget()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("master_city_center_sp_get");
            return res;
        }

        public static DataTable getallsupplier()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier");
            return res;
        }

        public static DataTable centeritemmaster()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_item_master");
            return res;
        }

        public static DataTable mrnspreasonmaster()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_mrn_sp_reason_master");
            return res;
        }

        public static DataTable centerSPwarehouseget(string cmrnspid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("center_SP_warehouse_get", new System.Data.SqlClient.SqlParameter("@pk_cmrn_sp_id", cmrnspid));
            return res;
        }

        public static DataTable mrntosupplieri(string pksplrid, string fksplrid, string fkitemid, string rejectedqty, string returnedqty, string reason)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_city_mrn_to_supplier_i", new System.Data.SqlClient.SqlParameter("@pk_cmrn_sp_id", pksplrid), new System.Data.SqlClient.SqlParameter("@trsp_mrn_fk_supplier_id", fksplrid),
            new System.Data.SqlClient.SqlParameter("@trsp_mrn_fk_item_id", fkitemid), new System.Data.SqlClient.SqlParameter("@trsp_mrn_rejected_qty", rejectedqty), new System.Data.SqlClient.SqlParameter("@trsp_mrn_returned_qty", returnedqty),
            new System.Data.SqlClient.SqlParameter("@trsp_mrn_reason", reason));
            return res;
        }

        public static DataTable mrnspcenteru(string pkmrnspid, string returnedqty)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_mrnsp_for_center_u", new System.Data.SqlClient.SqlParameter("@pk_trsp_mrn_id", pkmrnspid), new System.Data.SqlClient.SqlParameter("@trsp_mrn_returned_qty", returnedqty));
            return res;
        }

        public static DataTable mrnspcitywhd(int pksplrmrnid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_mrnsp_for_citywh_d", new System.Data.SqlClient.SqlParameter("@pk_trsp_mrn_id", pksplrmrnid));
            return res;
        }

        public static DataTable centerstockget(string stkfkitemid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_stock_get", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", stkfkitemid));
            return res;
        }

        public static DataTable centerstockbookget(string stkfkitemid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_stock_bookget", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", stkfkitemid));
            return res;
        }

        public static DataTable mrntospiu(string pksplrid, string pkmrnid, string spreturnedqty, string sprejectedqty, string mrnreason, string spfklocid, string spfkwhid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_mrn_to_sp_i_u", new System.Data.SqlClient.SqlParameter("@pk_cmrn_sp_id", pksplrid), new System.Data.SqlClient.SqlParameter("@pk_trsp_mrn_id", pkmrnid),
            new System.Data.SqlClient.SqlParameter("@cmrn_sp_returned_qty", spreturnedqty), new System.Data.SqlClient.SqlParameter("@cmrn_sp_rejected_qty", sprejectedqty),
            new System.Data.SqlClient.SqlParameter("@trsp_mrn_reason", mrnreason), new System.Data.SqlClient.SqlParameter("@cmrn_sp_fk_loc_id", spfklocid),
            new System.Data.SqlClient.SqlParameter("@cmrn_sp_fk_wh_id", spfkwhid));
            return res;
        }

        public static DataTable sprejecteddetail(string startdate, string enddate,string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("ms_mrn_sp_rejected_detail", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate)
                , new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;
        }

        public static DataTable centerrejectedget(string fkmrnId)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("tr_center_rejected_get", new System.Data.SqlClient.SqlParameter("@trct_mrn_fk_mrn_Id", fkmrnId));
            return res;
        }

        public static DataTable trcentermrnget(string pkcmrnid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_center_mrn_get", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid));
            return res;
        }

        //public static DataTable citycenterget()
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("master_city_center_get");
        //    return res;
        //}

        public static DataTable citybookcenterget()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("master_city_book_center_get");
            return res;
        }

        //public static DataTable itemmaster()
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_center_item_master");
        //    return res;
        //}

        public static DataTable bookitemmaster()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_book_item_master");
            return res;
        }

        //public static DataTable centerwarehouseget()
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_mrn_reason_master");
        //    return res;
        //}

        public static DataTable centerbookwhget()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_mrn_book_reason_master");
            return res;
        }

        //public static DataTable centerwarehouseget(string pkcmrnid)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("center_warehouse_get", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid));
        //    return res;
        //}

        public static DataTable centerbookget(string pkcmrnid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("center_book_wh_get", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid));
            return res;
        }

        //public static DataTable spmrncenteri(string pkcmrnid, string mrnfkitemid, string mrnrejectedqty, string mrnreturnedqty,
        //    string mrnremarks, string mrnreason)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_mrncenter_i", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid), new System.Data.SqlClient.SqlParameter("@trct_mrn_fk_item_id", mrnfkitemid),
        //    new System.Data.SqlClient.SqlParameter("@trct_mrn_rejected_qty", mrnrejectedqty), new System.Data.SqlClient.SqlParameter("@trct_mrn_returned_qty", mrnreturnedqty),
        //    new System.Data.SqlClient.SqlParameter("@trct_mrn_remarks", mrnremarks), new System.Data.SqlClient.SqlParameter("@trct_mrn_reason", mrnreason));
        //    return res;
        //}

        public static DataTable spmrncenterbooki(string pkcmrnid, string mrnfkitemid, string mrnrejectedqty, string mrnreturnedqty,
          string mrnremarks, string mrnreason)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_mrncenterbook__i", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid), new System.Data.SqlClient.SqlParameter("@trct_mrn_fk_item_id", mrnfkitemid),
            new System.Data.SqlClient.SqlParameter("@trct_mrn_rejected_qty", mrnrejectedqty), new System.Data.SqlClient.SqlParameter("@trct_mrn_returned_qty", mrnreturnedqty),
            new System.Data.SqlClient.SqlParameter("@trct_mrn_remarks", mrnremarks), new System.Data.SqlClient.SqlParameter("@trct_mrn_reason", mrnreason));
            return res;
        }


        //public static DataTable mrnforcenteru(string pkmrnid, string mrnreturnedqty)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_tr_mrn_for_center_u", new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid), new System.Data.SqlClient.SqlParameter("@trct_mrn_returned_qty", mrnreturnedqty));
        //    return res;
        //}

        public static DataTable mrnforcenterbooku(string pkmrnid, string mrnreturnedqty)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_mrn_for_center_book_u", new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid), new System.Data.SqlClient.SqlParameter("@trct_mrn_returned_qty", mrnreturnedqty));
            return res;
        }

        //public static DataTable mrnforcenterd(int pkmrnid)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_tr_mrn_for_center_d", new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid));
        //    return res;
        //}


        public static DataTable mrnforcenterbookd(int pkmrnid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_mrn_for_center_book_d", new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid));
            return res;
        }

        //public static DataTable centerstockget(int stkfkitemid)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_center_stock_get", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", stkfkitemid));
        //    return res;
        //}

        //public static DataTable mrnforcenteriu(string pkcmrnid, string pkmrnid, string returnedqty, string rejectedqty, string remarks, string reason, string fklocid, string fkwhid)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_ms_mrn_for_center_i_u", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid),
        //    new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid), new System.Data.SqlClient.SqlParameter("@cmrn_returned_qty", returnedqty),
        //    new System.Data.SqlClient.SqlParameter("@cmrn_rejected_qty", rejectedqty), new System.Data.SqlClient.SqlParameter("@cmrn_remarks", remarks),
        //    new System.Data.SqlClient.SqlParameter("@trct_mrn_reason", reason), new System.Data.SqlClient.SqlParameter("@cmrn_fk_loc_id", fklocid),
        //    new System.Data.SqlClient.SqlParameter("@cmrn_fk_wh_id", fkwhid));
        //    return res;
        //}

        public static DataTable mrnforcenterbookiu(string pkcmrnid, string pkmrnid, string returnedqty, string rejectedqty, string remarks, string reason, string fklocid, string fkwhid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_mrn_for_center_book_i_u", new System.Data.SqlClient.SqlParameter("@pk_cmrn_id", pkcmrnid),
            new System.Data.SqlClient.SqlParameter("@pk_trct_mrn_id", pkmrnid), new System.Data.SqlClient.SqlParameter("@cmrn_returned_qty", returnedqty),
            new System.Data.SqlClient.SqlParameter("@cmrn_rejected_qty", rejectedqty), new System.Data.SqlClient.SqlParameter("@cmrn_remarks", remarks),
            new System.Data.SqlClient.SqlParameter("@trct_mrn_reason", reason), new System.Data.SqlClient.SqlParameter("@cmrn_fk_loc_id", fklocid),
            new System.Data.SqlClient.SqlParameter("@cmrn_fk_wh_id", fkwhid));
            return res;
        }

        public static DataTable rejecteddetail(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("ms_center_rejected_detail", new System.Data.SqlClient.SqlParameter("@start_date", startdate), new System.Data.SqlClient.SqlParameter("@end_date", enddate),
                new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }


        public static DataTable mrnsprejectedget(string fkmrnId)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("tr_mrn_to_sp_rejected_get", new System.Data.SqlClient.SqlParameter("@trsp_mrn_fk_mrn_Id", fkmrnId));
            return res;
        }


        public static DataTable mrntospget(string pksplrid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_mrn_to_sp_get", new System.Data.SqlClient.SqlParameter("@pk_cmrn_sp_id", pksplrid));
            return res;
        }

        public static DataTable local_add_dropdown()
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_center_item_master");
            return res;

        }

        public static DataTable local_add_rep()
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_local_order_Regionalwh");
            return res;

        }

        public static DataTable local_add_rep_book()
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_local_order_Regionalwh_book");
            return res;

        }

        public static DataTable local_add_book_item(string item_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_details_by_bookid", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;

        }

        public static DataTable local_add_item(string item_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;

        }

        public static DataTable local_add_item_stock(string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable local_add_item_stock_book(string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_book_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable local_add_save(string item_id, string loc_id, string qty , string local,string purchase, string disc, string gst, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_local_order_Regionalwh_i", new System.Data.SqlClient.SqlParameter("@trlo_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@trlo_wh_id", loc_id), new System.Data.SqlClient.SqlParameter("@trlo_item_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@trlo_local_shop", local), new System.Data.SqlClient.SqlParameter("@trlo_item_price", purchase)
               , new System.Data.SqlClient.SqlParameter("@trlo_discount_percent", disc), new System.Data.SqlClient.SqlParameter("@trlo_tax_percent", gst)
               , new System.Data.SqlClient.SqlParameter("@trlo_created_by", created_by));
            return res;
        }

        public static DataTable local_add_save_book(string item_id, string loc_id, string qty, string local, string purchase, string disc, string gst, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_local_order_Regionalwh_book_i", new System.Data.SqlClient.SqlParameter("@trlo_fk_item_id", item_id)
                , new System.Data.SqlClient.SqlParameter("@trlo_wh_id", loc_id), new System.Data.SqlClient.SqlParameter("@trlo_item_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@trlo_local_shop", local), new System.Data.SqlClient.SqlParameter("@trlo_item_price", purchase)
               , new System.Data.SqlClient.SqlParameter("@trlo_discount_percent", disc), new System.Data.SqlClient.SqlParameter("@trlo_tax_percent", gst)
               , new System.Data.SqlClient.SqlParameter("@trlo_created_by", created_by));
            return res;
        }

        public static DataTable local_add_update(string localid, string qty, string price, string disc, string gst, string total, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_local_order_Regionalwh_u", new System.Data.SqlClient.SqlParameter("@localorderid", localid)
                , new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", price)
                , new System.Data.SqlClient.SqlParameter("@discount", disc), new System.Data.SqlClient.SqlParameter("@gst", gst)
               , new System.Data.SqlClient.SqlParameter("@totalpric", total), new System.Data.SqlClient.SqlParameter("@modified_by", created_by));
            return res;
        }


        public static DataTable local_add_update_book(string localid, string qty, string price, string disc, string gst, string total, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_local_order_Regionalwhbook_u", new System.Data.SqlClient.SqlParameter("@localorderid", localid)
                , new System.Data.SqlClient.SqlParameter("@quantity", qty), new System.Data.SqlClient.SqlParameter("@price", price)
                , new System.Data.SqlClient.SqlParameter("@discount", disc), new System.Data.SqlClient.SqlParameter("@gst", gst)
               , new System.Data.SqlClient.SqlParameter("@totalpric", total), new System.Data.SqlClient.SqlParameter("@modified_by", created_by));
            return res;
        }

        public static DataTable local_add_delete(int id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_local_order_Regionalwh_del", new System.Data.SqlClient.SqlParameter("@CustomerId", id));
            return res;

        }

        public static DataTable local_add_delete_book(int id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_local_order_Regionalwh_bookdel", new System.Data.SqlClient.SqlParameter("@CustomerId", id));
            return res;

        }

        public static DataTable local_add_place(string pk_id, string fk_id, string qty, string wh_id, string local, string price, string disc, string gst,string total, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_Regionalwh_i_u", new System.Data.SqlClient.SqlParameter("@pk_trlo_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@pk_lo_id", fk_id), new System.Data.SqlClient.SqlParameter("@lo_item_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@lo_fk_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@lo_local_shop", local)
               , new System.Data.SqlClient.SqlParameter("@lo_item_price", price), new System.Data.SqlClient.SqlParameter("@lo_discount_percent", disc)
               , new System.Data.SqlClient.SqlParameter("@lo_tax_percent", gst), new System.Data.SqlClient.SqlParameter("@totalpric", total)
               , new System.Data.SqlClient.SqlParameter("@lo_order_by", created_by));
            return res;
        }


        public static DataTable local_add_place_book(string pk_id, string fk_id, string qty, string wh_id, string local, string price, string disc, string gst, string total, string created_by)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_Regionalwhbook_i_u", new System.Data.SqlClient.SqlParameter("@pk_trlo_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@pk_lo_id", fk_id), new System.Data.SqlClient.SqlParameter("@lo_item_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@lo_fk_wh_id", wh_id), new System.Data.SqlClient.SqlParameter("@lo_local_shop", local)
               , new System.Data.SqlClient.SqlParameter("@lo_item_price", price), new System.Data.SqlClient.SqlParameter("@lo_discount_percent", disc)
               , new System.Data.SqlClient.SqlParameter("@lo_tax_percent", gst), new System.Data.SqlClient.SqlParameter("@totalpric", total)
               , new System.Data.SqlClient.SqlParameter("@lo_order_by", created_by));
            return res;
        }

        public static DataTable local_list_rep(string loc_id)
        {

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_Local_Regionalwh_get", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable local_rec_rep(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_localorder_Regionalwh_get", new System.Data.SqlClient.SqlParameter("@trlo_fk_lo_id", id));
            return res;
        }

        public static DataTable local_rec_rep_get_by_id(string id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_localo_Regionalwh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_lo_id", id));
            return res;
        }

        public static DataTable local_rec_save(string qty, string fk_id, string pk_id, string expiry, string batch, string receive, string bonus, string price_per, string rate, string disc, string total)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_localo_Regwh_u", new System.Data.SqlClient.SqlParameter("@available_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@trlo_fk_id", fk_id), new System.Data.SqlClient.SqlParameter("@pk_trlo_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@expiry_dt", expiry), new System.Data.SqlClient.SqlParameter("@batch_no", batch)
               , new System.Data.SqlClient.SqlParameter("@receive_by", receive), new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus)
               , new System.Data.SqlClient.SqlParameter("@price_per", price_per), new System.Data.SqlClient.SqlParameter("@rate", rate)
               , new System.Data.SqlClient.SqlParameter("@disc", disc), new System.Data.SqlClient.SqlParameter("@total", total));
            return res;
        }

        public static DataTable local_rec_save_book(string qty, string fk_id, string pk_id, string expiry, string batch, string receive, string bonus, string price_per, string rate, string disc, string total)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_localo_Regwh_book_u", new System.Data.SqlClient.SqlParameter("@available_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@trlo_fk_id", fk_id), new System.Data.SqlClient.SqlParameter("@pk_trlo_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@expiry_dt", expiry), new System.Data.SqlClient.SqlParameter("@batch_no", batch)
               , new System.Data.SqlClient.SqlParameter("@receive_by", receive), new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus)
               , new System.Data.SqlClient.SqlParameter("@price_per", price_per), new System.Data.SqlClient.SqlParameter("@rate", rate)
               , new System.Data.SqlClient.SqlParameter("@disc", disc), new System.Data.SqlClient.SqlParameter("@total", total));
            return res;
        }

        public static DataTable local_rec_stock(string qty, string item_id , string loc_id , string bonus)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_stock_u", new System.Data.SqlClient.SqlParameter("@stk_available_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id)
                , new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus));
            return res;
        }

        public static DataTable local_rec_stock_book(string qty, string item_id, string loc_id, string bonus)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_stock_book_u", new System.Data.SqlClient.SqlParameter("@stk_available_qty", qty)
                , new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id)
                , new System.Data.SqlClient.SqlParameter("@bonus_qty", bonus));
            return res;
        }

        public static DataTable local_rec_invoice(string pk_id, string invoice, string grn)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_lo_Regwh_invoice", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@invoice", invoice), new System.Data.SqlClient.SqlParameter("@grn", grn));
            return res;
        }

        public static DataTable local_rec_delivery(string pk_id, string loc_id, string delivery)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_add_total_ms_lo", new System.Data.SqlClient.SqlParameter("@pk_id", pk_id)
                , new System.Data.SqlClient.SqlParameter("@receive_by", loc_id), new System.Data.SqlClient.SqlParameter("@delivery", delivery));
            return res;
        }

        public static DataTable local_view_rep(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_tr_lo_get", new System.Data.SqlClient.SqlParameter("@trlo_fk_lo_id", pk_id));
            return res;
        }


        public static DataTable local_view_rep_book(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_tr_lo_bookget", new System.Data.SqlClient.SqlParameter("@trlo_fk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_view_by_id(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_Regwh_get", new System.Data.SqlClient.SqlParameter("@pk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_view_by_id_book(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_Regwh_book_get", new System.Data.SqlClient.SqlParameter("@pk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_receipt_rep(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_trlo_get", new System.Data.SqlClient.SqlParameter("@trlo_fk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_receipt_rep_book(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_trlo_book_get", new System.Data.SqlClient.SqlParameter("@trlo_fk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_receipt_get_by_id(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_get_byid", new System.Data.SqlClient.SqlParameter("@pk_lo_id", pk_id));
            return res;
        }

        public static DataTable local_receipt_get_by_bookid(string pk_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_local_order_get_by_bookid", new System.Data.SqlClient.SqlParameter("@pk_lo_id", pk_id));
            return res;
        }

      

        public static DataTable local_receipt_report(string start_date, string end_date, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("ms_order_to_local_get", new System.Data.SqlClient.SqlParameter("@start_date", start_date)
                , new System.Data.SqlClient.SqlParameter("@end_date", end_date), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable local_receipt_report_book(string start_date, string end_date, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("ms_order_to_local_bookget", new System.Data.SqlClient.SqlParameter("@start_date", start_date)
                , new System.Data.SqlClient.SqlParameter("@end_date", end_date), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }
    }
}
