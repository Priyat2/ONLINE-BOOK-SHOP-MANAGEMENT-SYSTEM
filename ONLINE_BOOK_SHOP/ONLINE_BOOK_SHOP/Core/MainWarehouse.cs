using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MainWarehouse
    {
        public static DataTable getallsupplier()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier");
            return res;
        }


        public static DataTable getallbooksupplier()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_supplier_book");
            return res;
        }

        public static DataTable warehouse_item_rep()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_purchase_order_rpt");
            return res;
        }

        public static DataTable warehouse_bookitem_rep()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("udsp_get_book_purchase_order_rpt");
            return res;
        }

        public static DataTable get_items_cat_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_cat_book");
            return res;
        }


        public static DataTable item_get_by_supplier_id()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_item_by_supplier");
            return res;
        }

        public static DataTable bookitem_get_by_splr_id()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_bookitem_by_splr");
            return res;
        }

        public static DataTable get_details_by_item(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_item_id", item_id));
            return res;
        }

        public static DataTable get_details_by_book_item(string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_bookitem_details_by_id", new System.Data.SqlClient.SqlParameter("@pk_book_item_id", item_id));
            return res;
        }



        public static DataTable get_stock_by_item(string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_available_stock_by_item_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable get_stock_by_bookitem(string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_avail_stock_by_bookitem_id", new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id),
                new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable get_order_list_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_purchase_order_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;
        }


        public static DataTable get_order_list_bookbyid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_book_purchase_order_get", new System.Data.SqlClient.SqlParameter("@trpo_fk_po_id", order_id));
            return res;
        }


        public static DataTable get_order_list_item_byid(string order_id)
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

        //public static DataTable supplier_order_details(string startdate, string enddate, string loc_id)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_records_of_ms_po_get", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
        //         new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
        //    return res;
        //}


        public static DataTable supplier_order_bookdetails(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_of_ms_bookpo_get", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
                 new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }


        public static DataTable sppurchaseorderget(string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_purchase_order_get",new System.Data.SqlClient.SqlParameter("@loc_id", locid));
            return res;
        }


        public static DataTable get_book_purchase_order_list(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_book_purchase_order_get", new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;

        }

        public static DataTable get_all_wh_stock_byid(string supplier_id, string item_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_all_wh_stock_get_byid", new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", supplier_id),
                new System.Data.SqlClient.SqlParameter("@item_name", item_id));
            return res;
        }

        //public static DataTable get_all_wh_stock(string supplier_id)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_all_wh_stock_get", new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", supplier_id));
        //    return res;
        //}


        public static DataTable get_all_bookwh_stock(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_all_bookwh_stock_get", new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", loc_id));
            return res;
        }

        //public static DataTable get_all_wh_get()
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_city_wh_get");
        //    return res;
        //}

        public static DataTable get_all_bookwh_get()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_city_bookwh_get");
            return res;
        }


        public static DataTable get_pending_req_from_cithwh(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_whid", new System.Data.SqlClient.SqlParameter("@otw_fk_wh_id", loc_id));
            return res;
        }


        public static DataTable get_pending_req_from_bookcithwh(string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_bookwhid", new System.Data.SqlClient.SqlParameter("@otw_fk_wh_id", loc_id));
            return res;
        }

        public static DataTable get_pending_whreq_from_center(int users_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_whorder", new System.Data.SqlClient.SqlParameter("@center_id", UserManagement.getCurrentLocaionId()));
            return res;
        }

        public static DataTable item_get_by_id_from_citywh(string order_id ,string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_order_towh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", order_id),
               new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }


        public static DataTable item_get_by_id_from_bookcitywh(string order_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_order_towh_bookget", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", order_id),
               new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable item_get_by_id_from_bookwh(string order_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_tr_order_towh", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", order_id),
               new System.Data.SqlClient.SqlParameter("@center_id", loc_id));
            return res;
        }



        public static DataTable itemlist_rep(int locid, int product_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_center_order_list_rep", new System.Data.SqlClient.SqlParameter("@center_id", locid), new System.Data.SqlClient.SqlParameter("@fk_ms_id", product_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }


        public static DataTable item_get_by_id(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", order_id));
            return res;
        }


        public static DataTable item_get_by_bookid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_bookwh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_book_id", order_id));
            return res;
        }

        public static DataTable wh_itemlist_rep(int locid, int product_id)
        {
            DataTable dt;

            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_center_order_rep", new System.Data.SqlClient.SqlParameter("@center_id", locid), new System.Data.SqlClient.SqlParameter("@fk_ms_id", product_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;

            return dt;
        }



        public static DataTable confirm_qty_i(string qty, string id, string order_id , string confirm_by, string confirm_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_wh_confm_qty", new System.Data.SqlClient.SqlParameter("@confirm_qty", qty),
                new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id), new System.Data.SqlClient.SqlParameter("@pk_tr_order_id", order_id),
                new System.Data.SqlClient.SqlParameter("@confirm_by", confirm_by), new System.Data.SqlClient.SqlParameter("@confm_name", confirm_name));
            return res;
        }

        public static DataTable bookconfirm_qty_i(string qty, string id, string order_id, string confirm_by, string confirm_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_bookwh_confm_qty",
                new System.Data.SqlClient.SqlParameter("@pk_tr_order_book_id", order_id),
                new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id),
                new System.Data.SqlClient.SqlParameter("@confirm_qty", qty),
                new System.Data.SqlClient.SqlParameter("@confirm_by", confirm_by),
                new System.Data.SqlClient.SqlParameter("@confm_name", confirm_name));
            return res;
        }

        public static DataTable order_to_bookwh_confm_qty(string qty, string id, string order_id, string confirm_by, string confirm_name)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_order_to_bookwh_confm_qty",
                new System.Data.SqlClient.SqlParameter("@pk_tr_order_book_id", order_id),
                new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", id),
                new System.Data.SqlClient.SqlParameter("@confirm_qty", qty),
                new System.Data.SqlClient.SqlParameter("@confirm_by", confirm_by),
                new System.Data.SqlClient.SqlParameter("@confm_name", confirm_name));
            return res;
        }



        public static DataTable center_stock_minus(string qty, string item_id, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_center_stock_minus", new System.Data.SqlClient.SqlParameter("@qty", qty),
                new System.Data.SqlClient.SqlParameter("@stk_fk_item_id", item_id), new System.Data.SqlClient.SqlParameter("@stk_fk_loc_id", loc_id));
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

        //public static DataTable get_all_orders_from_citywh(string startdate, string enddate, string loc_id)
        //{
        //    DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
        //    DataTable res;
        //    res = data.SelectByParamDT("sp_records_ms_order_to_wh", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
        //        new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
        //    return res;
        //}

        public static DataTable get_all_orders_from_bookcitywh(string startdate, string enddate, string loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_records_ms_order_to_bookwh", new System.Data.SqlClient.SqlParameter("@start_date", startdate),
                new System.Data.SqlClient.SqlParameter("@end_date", enddate), new System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            return res;
        }

        public static DataTable get_item_view_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_towh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", order_id));
            return res;
        }

        public static DataTable get_bookitem_view_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_record_tr_order_to_bookwh_get", new System.Data.SqlClient.SqlParameter("@tr_order_fk_otw_id", order_id));
            return res;
        }

        public static DataTable get_item_details_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_wh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_wh_id", order_id));
            return res;
        }

        public static DataTable get_bookitem_details_byid(string order_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("sp_ms_order_to_bookwh_get_byid", new System.Data.SqlClient.SqlParameter("@pk_order_to_book_id", order_id));
            return res;
        }
    }
}
