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
using Core.UserManagement;
using System.Data;

namespace Core
{
    class Report
    {
        public static DataTable getvouchercallingdetails(string sdate, string edate, int status)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_voucher_calling_details", new SqlClient.SqlParameter("@sdate", sdate), new SqlClient.SqlParameter("@edate", edate), new SqlClient.SqlParameter("@statusid", status), new SqlClient.SqlParameter("@userid", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getvouchercallingsummary(string sdate, string edate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_voucher_calling_summary", new SqlClient.SqlParameter("@sdate", sdate), new SqlClient.SqlParameter("@edate", edate), new SqlClient.SqlParameter("@userid", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getvoucherListbyfilter(string filtertype, string searchtext, string sdate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_voucher_list_by_filter", new SqlClient.SqlParameter("@filtertype", filtertype), new SqlClient.SqlParameter("@searchtext", searchtext), new SqlClient.SqlParameter("@sdate", sdate), new SqlClient.SqlParameter("@userid", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable getvoucherList(string voucherno)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_voucher_list", new SqlClient.SqlParameter("@flag", voucherno), new SqlClient.SqlParameter("@userid", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getvoucherListbyclientid(string clientid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_voucher_list_by_clientid", new SqlClient.SqlParameter("@clientid", clientid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getredeemvoucherdetails(string sdate, string edate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_voucher_redeem_details", new SqlClient.SqlParameter("@startdate", sdate), new SqlClient.SqlParameter("@enddate", edate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable getappointmentvoucherdetails(string sdate, string edate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_voucher_Appointment_details", new SqlClient.SqlParameter("@startdate", sdate), new SqlClient.SqlParameter("@enddate", edate), new SqlClient.SqlParameter("@userid", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getvoucherdetailonvoucherno(string voucherno)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_voucher_client_detail_by_voucherno", new SqlClient.SqlParameter("@voucher_no", voucherno));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getdailydashboard(string cityname, string sdate, string edate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_test_daily_report", new SqlClient.SqlParameter("@cityname", cityname), new SqlClient.SqlParameter("@startdate", sdate), new SqlClient.SqlParameter("@enddate", edate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getdailyalignerdata(string sdate, string edate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_ortho_data", new SqlClient.SqlParameter("@startdate", sdate), new SqlClient.SqlParameter("@enddate", edate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable USP_get_DoatHomeAgentsSlotNew(string fromdt, string todt)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("USP_get_DoatHomeAgentsSlotNew", new SqlClient.SqlParameter("@fromdt", fromdt), new SqlClient.SqlParameter("@todate", todt));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable USP_apptdetails_HC_Location(int Appdate, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("USP_apptdetails_HC_Location", new SqlClient.SqlParameter("@FromDate", StartDate), new SqlClient.SqlParameter("@Todate", EndDate), new SqlClient.SqlParameter("@Appdate", Appdate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable GetDepositesForCenter(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_center_cm_deposites", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet GetDepositesForCenterWithCashInHand(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_center_cm_deposites", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetHFSummaryForCenter(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_hf_collection_deposite", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet GetHFSummaryForCenterWithCashInHand(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_hf_collection_deposite", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetSalesRegisterForCenter(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_c_sales_register", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetJoinedClientsRegister(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_joined_clients_register", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetOutstandingCustomersForCenter(int pk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_getOutStandingOfCustomers", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetFCDetailsForCenter(int pk_loc_id, DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_getCenterFCDetails", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetexcuativeReport(DateTime StartDate, DateTime EndDate, int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_CE_joined_token_count", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable getcallist_followup(DateTime StartDate, DateTime EndDate, int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_calllist_followup", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getcallist_appts(DateTime StartDate, DateTime EndDate, int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_calllist_appts", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getcallist_all(DateTime StartDate, int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_calllist_all", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@fk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable Getcenterexcuativereport(int pk_loc_id, DateTime StartDate, DateTime EndDate, int fk_exec_id, int fk_status_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_lms_getExecutive_FC_Details", new SqlClient.SqlParameter("@pk_loc_id", pk_loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_exec_id", fk_exec_id), new SqlClient.SqlParameter("@fk_user_id", getCurrentUserId()), new SqlClient.SqlParameter("@fk_role_id", getCurrentUserRoleId()), new SqlClient.SqlParameter("@fk_status_id", fk_status_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCollectionsForCenter()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_center_wise_collection");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetJoinedCLientsSummary()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_clients_by_joined_date");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCenterTargetVsPerf(string strDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_target_vs_perf", new SqlClient.SqlParameter("@s_date", strDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet GetCallExecTodaysDetails(int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_getCall_Exec_details", new SqlClient.SqlParameter("@pk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetcenterExecTodaysDetails()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_getcenter_Exec_details");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCenterProgDailyOpening(string strDate, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_center_daily_opening", new SqlClient.SqlParameter("@month_start_date", strDate), new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCenterprog_hf_summary(string strDate, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_center_prog_hf_summary", new SqlClient.SqlParameter("@month_start_date", strDate), new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable GetinceativeDetails(DateTime startdate, DateTime enddate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_Insentive_Display", new SqlClient.SqlParameter("@startDate", startdate), new SqlClient.SqlParameter("@endDate", enddate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCenterHFDailyOpening(string strDate, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_center_daily_opening_hf", new SqlClient.SqlParameter("@month_start_date", strDate), new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetSourceWiseCollection(DateTime StartDate, DateTime EndDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_sourcewise_collection", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetinceativeDetails(DateTime StartDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_Insentive_Display", new SqlClient.SqlParameter("@sDate", StartDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetIncentiveBSummary(string strDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_incentive_b_summary_display", new SqlClient.SqlParameter("@start_Date", strDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet GetIncentiveBDetails(string strDate, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_Incentives_B_detail", new SqlClient.SqlParameter("@start_Date", strDate), new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetIncentiveCSummary(string strDate)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_incentive_c_summary_display", new SqlClient.SqlParameter("@start_Date", strDate));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet GetIncentiveCDetails(string strDate, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_Incentives_C_detail", new SqlClient.SqlParameter("@start_Date", strDate), new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetCallExecutiveWiseCalls(int fk_source_id, int loc_id, DateTime StartDate, DateTime EndDate, int fk_user_id, int fromERP)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_call_executive_Transaction", new SqlClient.SqlParameter("@pk_loc_id", loc_id), new SqlClient.SqlParameter("@pk_source_id", fk_source_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fromERP", fromERP));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetCallExecutiveWiseCalls(int fk_source_id, int loc_id, int fk_user_id, int fromERP)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_call_executive_Transaction", new SqlClient.SqlParameter("@pk_loc_id", loc_id), new SqlClient.SqlParameter("@pk_source_id", fk_source_id), new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fromERP", fromERP));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getcallexecutivequota(int pk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_cc_quota", new SqlClient.SqlParameter("@fk_user_id", pk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getIncentiveReferance_userwise_summary(string strDate, string locid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_incentive_referance_userwise_summary", new SqlClient.SqlParameter("@start_Date", strDate), new SqlClient.SqlParameter("@fk_loc_id", locid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable checkCCEOD(string eod_date, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_cc_getUserwise_EOD_Details", new SqlClient.SqlParameter("@fk_loc_id", fk_loc_id), new SqlClient.SqlParameter("@eodDate", eod_date));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetMisCallsToJoined_Performance(DateTime StartDate, int sHrs, int sMins, DateTime EndDate, int eHrs, int eMins, int fk_user_id, int c2c_loc_id, int user_loc_id, int user_loc_type)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_cc_CallsToJoin_Performance", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@sHrs", sHrs), new SqlClient.SqlParameter("@sMins", sMins), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@eHrs", eHrs), new SqlClient.SqlParameter("@eMins", eMins), new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fk_cc_loc_id", c2c_loc_id), new SqlClient.SqlParameter("@user_loc_id", user_loc_id), new SqlClient.SqlParameter("@user_loc_type", user_loc_type));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getCallExecutiveJoinedSummary(DateTime StartDate, DateTime EndDate, int fk_cc_loc_id, int user_loc_id, int user_loc_type)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_callExecutiveWise_joined_token_summary", new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@user_loc_id", user_loc_id), new SqlClient.SqlParameter("@user_loc_type", user_loc_type), new SqlClient.SqlParameter("@fk_cc_loc_id", fk_cc_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataSet getPoolDetailsLocWise(int fk_user_id, string fk_cc_loc_id, string url_accesed, string user_ip)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_Get_Lead_Pools_summary_locWise", new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fk_cc_loc_id", fk_cc_loc_id), new SqlClient.SqlParameter("@url_accesed", url_accesed), new SqlClient.SqlParameter("@user_ip", user_ip));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable GetCallExecutiveWiseAppts(int loc_id, DateTime StartDate, DateTime EndDate, int fk_user_id, int c2c_loc_id, int user_loc_id, int user_loc_type)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_lms_executiveWise_apptsToJoin", new SqlClient.SqlParameter("@pk_loc_id", loc_id), new SqlClient.SqlParameter("@startDate", StartDate), new SqlClient.SqlParameter("@endDate", EndDate), new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fk_cc_loc_id", c2c_loc_id), new SqlClient.SqlParameter("@user_loc_id", user_loc_id), new SqlClient.SqlParameter("@user_loc_type", user_loc_type));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable getUserWiseCallsDetails(int sHrs, int sMins, int eHrs, int eMins, string startDate, int fk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_lms_cc_Calls_HoursWise", new SqlClient.SqlParameter("@sHrs", sHrs), new SqlClient.SqlParameter("@sMins", sMins), new SqlClient.SqlParameter("@eHrs", eHrs), new SqlClient.SqlParameter("@eMins", eMins), new SqlClient.SqlParameter("@startDate", startDate), new SqlClient.SqlParameter("@fk_user_id", fk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable GetCallExecutiveLeadTrTime(DateTime SDate, int fk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_callExecutiveLeadTrTime", new SqlClient.SqlParameter("@date", SDate), new SqlClient.SqlParameter("@fk_user_id", fk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
        public static DataTable GetFUPDetails(string SearchQuery, string SearchDate, string totalOut)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_fup_userwise", new SqlClient.SqlParameter("@user_id", SearchQuery), new SqlClient.SqlParameter("@date", SearchDate), new SqlClient.SqlParameter("@outTime", totalOut));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            DataTable res;
            if (ds.Tables.Count > 0)
                res = ds.Tables(0);
            else
                res = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable GetDoatHomeCallerSummary(string SDate, string EDate, int fk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_lms_doathome_callerSummary_s", new SqlClient.SqlParameter("@sdate", SDate), new SqlClient.SqlParameter("@edate", EDate), new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fk_loc_id", getCurrentLocaionId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable GetLeadBifurcationCCwise(string sDate, string edate, int Source, int publisher, int cc_loc_id, int fk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_mis_cc_wise_lead_bifurcation", new SqlClient.SqlParameter("@sdate", sDate), new SqlClient.SqlParameter("@edate", edate), new SqlClient.SqlParameter("@Source_id", Source), new SqlClient.SqlParameter("@publisher_id", publisher), new SqlClient.SqlParameter("@fk_cc_loc_id", cc_loc_id), new SqlClient.SqlParameter("@fk_user_id", fk_user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }
    }
}
