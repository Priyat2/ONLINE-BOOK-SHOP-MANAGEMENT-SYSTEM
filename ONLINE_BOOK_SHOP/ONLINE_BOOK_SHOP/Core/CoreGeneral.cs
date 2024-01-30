using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Core
{
    public class CoreGeneral
    {
        public static string ChangeDateFormat1(string strDate)
        {
            string day, month, year;
            string strNewDate;
            string[] strTempDate = strDate.Split('-');
            day = strTempDate[0];
            month = strTempDate[1];
            year = strTempDate[2].PadLeft( 4);
            // strNewDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString()
            strNewDate = day.ToString() + "/" + month.ToString() + "/" + year.ToString();
            return strNewDate;
        }

        public static string currentDateInDDMMYYYY1()
        {
            string strDate;
            strDate = ChangeDateFormat1(DateTime.Now.ToString("MM/dd/yyyy"));
            return strDate;
        }


        public static string ChangeDateFormatnew(string strDate)
        {
            string day, month, year;
            string strNewDate;
            string[] strTempDate = strDate.Split('-');
            year = strTempDate[0];
            month = strTempDate[1];
            day = strTempDate[2];
            strNewDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
            return strNewDate;
        }
        public static string ChangeDateFormat(string strDate)
        {
            string day, month, year;
            string strNewDate;
            string[] strTempDate = strDate.Split( '/');
            day = strTempDate[0];
            month = strTempDate[1];
            year = strTempDate[2].PadLeft(4);
            strNewDate = month.ToString() + "/" + day.ToString() + "/" + year.ToString();
            return strNewDate;
        }
        public static string getDateBefore30Days()
        {
            string strOldDate = currentDateInMMDDYYYY().ToShortDateString();
            return strOldDate;
        }
        public static DateTime currentDateInMMDDYYYY()
        {
            DateTime dtDate;
            dtDate = DateTime.Now;
            return dtDate;
        }
        public static string currentDateInDDMMYYYY()
        {
            string strDate;
            strDate = ChangeDateFormat(DateTime.Now.ToString("MM/dd/yyyy"));
            return strDate;
        }
        public static string currentDateInDDMMYYYYWithTime()
        {
            string strDate;
            strDate = ChangeDateFormat(DateTime.Now.ToString("MM/dd/yyyy")) + DateTime.Now.ToShortTimeString();
            return strDate;
        }

        public static DataTable getAllCountries()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getAllCountries");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable getStatesByCountry(int fk_country_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getStates_By_Country", new System.Data.SqlClient.SqlParameter("@fk_country_id", fk_country_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getCitiesByState(int fk_state_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getCities_By_State_ltst", new System.Data.SqlClient.SqlParameter("@fk_state_id", fk_state_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getSuburbByCity(int fk_city_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getSuburbs_By_City", new System.Data.SqlClient.SqlParameter("@fk_city_id", fk_city_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }

        public static DataTable getSuburbByCityId(int fk_city_id)
        {
            DataTable dt;
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            dt = data.SelectByParamDT("udsp_getSuburbs_By_City", new System.Data.SqlClient.SqlParameter("@fk_city_id", fk_city_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable getCentersByCity(int fk_city_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getCenters_By_City", new System.Data.SqlClient.SqlParameter("@fk_city_id", fk_city_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataSet getmyoperation(int fk_lead_id, int userid, int roleid, int locid, int applid, int pageid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_myoperation_api_details", new System.Data.SqlClient.SqlParameter("@leadid", fk_lead_id), new  System.Data.SqlClient.SqlParameter("@userid", userid), new  System.Data.SqlClient.SqlParameter("@applid", applid), new  System.Data.SqlClient.SqlParameter("@roleid", roleid), new  System.Data.SqlClient.SqlParameter("@pageid", pageid), new  System.Data.SqlClient.SqlParameter("@locid", locid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }


        // Public Shared Function getmyoperation(ByVal fk_lead_id As Integer, ByVal userid As Integer, roleid As Integer, locid As Integer) As DataSet
        // Dim data As New DataLayer.DataFunctions(WebAppSettings.ConnectionString)
        // Dim ds As DataSet = data.RunSelectProcedureByParameters("udsp_get_myoperation_api_details", new  System.Data.SqlClient.SqlParameter("@leadid", fk_lead_id), _
        // new  System.Data.SqlClient.SqlParameter("@userid", userid), _
        // new  System.Data.SqlClient.SqlParameter("@applid", "4"), _
        // new  System.Data.SqlClient.SqlParameter("@roleid", roleid), _
        // new  System.Data.SqlClient.SqlParameter("@pageid", "1"), _
        // new  System.Data.SqlClient.SqlParameter("@locid", locid))
        // data = Nothing
        // Return ds
        // End Function

        public static DataTable GetAllCenters(int is_Erp)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt;
            dt = data.SelectByParamDT("udsp_getAllCenters", new  System.Data.SqlClient.SqlParameter("@is_Erp", is_Erp));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable getpackagelist()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt;
            dt = data.SelectByParamDT("udsp_get_package_list");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable GetAllCenters(int is_Erp, int showAll)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getAllCenters", new  System.Data.SqlClient.SqlParameter("@is_Erp", is_Erp), new  System.Data.SqlClient.SqlParameter("@showAll", showAll));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }

        public static DataTable GetAllCenters()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getAllCenters");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }

        public static DataTable getLocationDetailsByLocId(int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getlocationaddress_bylocid", new  System.Data.SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable GetLocationById(int loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getLocationById", new  System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable GetLocDetailByLocId(int loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getloc_detail_by_locId", new  System.Data.SqlClient.SqlParameter("@loc_id", loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable getAllStates()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getallStates");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getAllCities()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getAllCities");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getAllSuburb()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getAllSuburb");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getAllArea()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getAllArea");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        public static DataTable getGender(int id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getGenders", new  System.Data.SqlClient.SqlParameter("@id", id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable getAllNamePreFix(int allStatus_Filter)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getAllNamePreFix", new  System.Data.SqlClient.SqlParameter("@allStatus_Filter", allStatus_Filter));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static string Alert(string msg)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<script language='javascript'>alert('");
            sb.Append(msg);
            sb.Append("');</script>");
            return sb.ToString();
        }
        public static DataTable getOwnerByLoc(int fk_user_id, int fk_loc_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.SelectByParamDT("udsp_getCenters_By_City", new  System.Data.SqlClient.SqlParameter("@fk_user_id", fk_user_id), new  System.Data.SqlClient.SqlParameter("@fk_loc_id", fk_loc_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
        //public static string GetJSONString(DataTable Dt)
        //{
        //    StringBuilder Sb = new StringBuilder();
        //    if (Dt.Rows.Count > 0)
        //    {
        //        string[] StrDc = new string[Dt.Columns.Count - 1 + 1];
        //        string HeadStr = string.Empty;
        //        for (int i = 0; i <= Dt.Columns.Count - 1; i++)
        //        {
        //            StrDc[i] = Dt.Columns[i].Caption;
        //            HeadStr += "\"" + StrDc[i] + "\" : \"" + StrDc[i] + i.ToString() + "¾" + "\",";
        //        }
        //        HeadStr = HeadStr.Substring(0, HeadStr.Length - 1);

        //        Sb.Append("{\"" + Convert.ToString(Dt.TableName) + "\" : [");

        //        for (int i = 0; i <= Dt.Rows.Count - 1; i++)
        //        {
        //            string TempStr = HeadStr;
        //            Sb.Append("{");
        //            for (int j = 0; j <= Dt.Columns.Count - 1; j++)
        //                TempStr = TempStr.Replace(Dt.Columns[j].ToString + [j].ToString() + "¾", Dt.Rows[i][j].ToString());
        //            Sb.Append(TempStr + "},");
        //        }

        //        Sb = new StringBuilder(Sb.ToString().Substring(0, Sb.ToString().Length - 1));
        //        Sb.Append("]}");
        //    }
        //    else
        //        Sb.Append("");

        //    return Sb.ToString();
        //}
    }
}