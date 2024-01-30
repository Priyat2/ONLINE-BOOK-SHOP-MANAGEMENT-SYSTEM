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
using System.Configuration;
using Core;
using System.Data;
using Encryption;



namespace Core
{
   public class UserManagement
    {

        private static string LogoutURL = "";
        // = ConfigurationManager.AppSettings("LogoutURL").ToString()
        public static DataTable Login_User_ERP(string username, string password, string user_ip)
        {
            int leadid = 0;
            
                DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
                Encryption.MD5Encryption crypto = new Encryption.MD5Encryption();
                // udsp_latest_employee_login
                int userId = -1;
                DataTable res;
                res = data.SelectByParamDT("udsp_latest_employee_login", new System.Data.SqlClient.SqlParameter("@user_name", username), new System.Data.SqlClient.SqlParameter("@Password", crypto.Encode(password)), new System.Data.SqlClient.SqlParameter("@appl_id", "3"));
                return res;
           
        }
        public static DataTable Login_User_Warehouse(string username, string password)
        {
            
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            Encryption.MD5Encryption crypto = new Encryption.MD5Encryption(); 
            DataTable res;
            res = data.SelectByParamDT("sp_user_master_get", new System.Data.SqlClient.SqlParameter("@user_name", username), new System.Data.SqlClient.SqlParameter("@user_password", (password)));
            return res;

        }
        public static string getcurrentlocationname()
        {
            string strLocationName;
            strLocationName = getCookieValue("LocationName");
            if (strLocationName != "")
                return strLocationName;
            else
                HttpContext.Current.Response.Redirect(LogoutURL);
            return "";
        }


        public static DataTable Login_User_LMS(string username, string password, string user_ip)
        {
            int leadid = 0;
          
                DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);


                Encryption.MD5Encryption crypto = new Encryption.MD5Encryption();
                // udsp_latest_employee_login
                int userId = -1;
                DataTable res;
                res = data.SelectByParamDT("udsp_latest_employee_login", new System.Data.SqlClient.SqlParameter("@user_name", username), new System.Data.SqlClient.SqlParameter("@Password", crypto.Encode(password)), new System.Data.SqlClient.SqlParameter("@fk_role_id", "3"), new System.Data.SqlClient.SqlParameter("@appl_id", "2"));
                return res;
           
        }

      

        public static DataTable get_User_NextCall_By_UserID(int leadid, int userid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_get_User_NextCall_By_UserID", new System.Data.SqlClient.SqlParameter("@fk_user_id", userid), new System.Data.SqlClient.SqlParameter("@old_fk_lead_id", leadid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }

        public static DataTable get_User_NextCall_xpool_By_UserID(int leadid, int userid)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("get_udsp_x_pool_lead_for_callcenter", new System.Data.SqlClient.SqlParameter("@fk_user_id", userid), new System.Data.SqlClient.SqlParameter("@leadid", leadid));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }


        


        public static bool setCookie(string cookieName, string cookieValue, DateTime cookieExpVal)
        {
            try
            {
                Encryption.TripleDesEncryption crypto = new Encryption.TripleDesEncryption();
                System.Web.HttpCookie saveCookie = new System.Web.HttpCookie(cookieName, crypto.Encode(cookieValue));
                saveCookie.Expires = cookieExpVal;
                // saveCookie.Domain = "health-total.com"
                HttpContext.Current.Response.Cookies.Add(saveCookie);
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                return false;
            }
            return true;
        }
        //public static string getCookieValue(string cookieName)
        //{
        //    string strCookieVal;
        //    try
        //    {
        //        Encryption.TripleDesEncryption crypto = new Encryption.TripleDesEncryption();
        //        strCookieVal = crypto.Decode(HttpContext.Current.Request[cookieName].ToString());
        //    }
        //     //Response.Cookies.Item(cookieName).Value
        //    catch (Exception Ex)
        //    {
        //        HttpContext.Current.Trace.Warn(Ex.Message);
        //        strCookieVal = "0";
        //    }
        //    return strCookieVal;
        //}



        public static string getCookieValue(string cookieName)
        {
            string strCookieVal;
            try
            {
                if (HttpContext.Current.Request.Cookies[cookieName] != null)
                {
                    Encryption.TripleDesEncryption crypto = new Encryption.TripleDesEncryption();
                    strCookieVal = crypto.Decode(HttpContext.Current.Request.Cookies[cookieName].Value);
                }
                else
                {
                    strCookieVal = "0";
                }
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                strCookieVal = "0";
            }
            return strCookieVal;
        }


        public static int getCurrentLocaionId()
        {
            string strLocationId = getCookieValue("LocationId");

            if (!string.IsNullOrEmpty(strLocationId))
            {
                return System.Convert.ToInt32(strLocationId);
            }
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                //// return a default value or throw an exception
                //return -1; // You can replace -1 with any default value suitable for your application
                return 0;
            }
        }



        public static bool clearAllCookieValue()
        {
            try
            {
                setCookie("UserName", "", DateTime.Now.Date);
                setCookie("UserId", "", DateTime.Now.Date);
                setCookie("UserDesignation", "", DateTime.Now.Date);
                setCookie("LocationId", "", DateTime.Now.Date);
                setCookie("LocationName", "", DateTime.Now.Date);
                setCookie("RoleId", "", DateTime.Now.Date);
                setCookie("LeadId", "", DateTime.Now.Date);
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                return false;
            }
            return true;
        }
        public static bool deleteAllCookieValue()
        {
            try
            {
                HttpContext.Current.Request.Cookies.Remove("UserName");
                HttpContext.Current.Request.Cookies.Remove("UserId");
                HttpContext.Current.Request.Cookies.Remove("UserDesignation");
                HttpContext.Current.Request.Cookies.Remove("LocationId");
                HttpContext.Current.Request.Cookies.Remove("LocationName");
                HttpContext.Current.Request.Cookies.Remove("RoleId");
                HttpContext.Current.Request.Cookies.Remove("LeadId");
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                return false;
            }
            return true;
        }
        public static bool deleteCookie(string cookieName)
        {
            try
            {
                HttpContext.Current.Request.Cookies.Remove(cookieName);
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                return false;
            }
            return true;
        }

        public static string getCurrentOffer()
        {
            string strUserID;

            try
            {
                strUserID = getCookieValue("OfferDetail");
                if (strUserID == "0")
                    strUserID = "";
            }
            catch (Exception ex)
            {
                strUserID = "";
            }

            return strUserID;
        }

        public static int getCurrentUserId()
        {
            string strUserID;
            strUserID = getCookieValue("UserId");
            if (strUserID != "" & strUserID != "0")
                return System.Convert.ToInt32(strUserID);
            else
                HttpContext.Current.Response.Redirect("/Login.aspx");
            return 1;
        }

       
        public static int getCurrentRoleType()
        {
            string strRoleType;
            strRoleType = getCookieValue("RoleType");
            if (strRoleType != "")
                return System.Convert.ToInt32(strRoleType);
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                return 0;
            }
        }
        public static int getCurrentApproveRole()
        {
            string strUserID;
            strUserID = getCookieValue("approve_role");
            if (strUserID != "")
                return System.Convert.ToInt32(strUserID);
            else
                return 0;
        }
        public static int getCurrentemployee_id()
        {
            string strUserID;
            strUserID = getCookieValue("employee_id");
            if (strUserID != "")
                return System.Convert.ToInt32(strUserID);
            else
                return 0;
        }
        public static string getCurrentUserName()
        {
            string strUserName;
            strUserName = getCookieValue("UserName");
            if (strUserName != "")
                return strUserName.ToString();
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                return "";
            }
        }

       


        
        public static int getCurrentUserRoleId()
        {
            string strRoleId;
            strRoleId = getCookieValue("RoleId");
            if (strRoleId != "")
                return System.Convert.ToInt32(strRoleId);
            else
                HttpContext.Current.Response.Redirect(LogoutURL);
            return 0;
        }


        public static string getcurrentdesigantion()
        {
            string strdesig;
            strdesig = getCookieValue("UserDesignation");
            if (strdesig != "")
                strdesig = strdesig.ToString();
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                strdesig = "";
            }
            return strdesig.ToString();
        }


        public static int IsEODPending()
        {
            string strPendingEOD;
            int isPending;
            strPendingEOD = getCookieValue("PendingEOD");
            if (strPendingEOD != "")
                isPending = System.Convert.ToInt32(strPendingEOD);
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                isPending = 1;
            }
            return isPending;
        }

        public static string EODDate()
        {
            string strEODDate;
            strEODDate = getCookieValue("EODDate");
            if (strEODDate != "")
                strEODDate = strEODDate.ToString();
            else
            {
                HttpContext.Current.Response.Redirect(LogoutURL);
                strEODDate = "";
            }
            return strEODDate.ToString();
        }

        public static int getCurrentLeadId()
        {
            int currentLeadId = 0;
            if (getCookieValue("LeadId") == "")
                currentLeadId = 0;
            else if (getCookieValue("LeadId") == "-1")
                currentLeadId = 0;
            else
                currentLeadId = System.Convert.ToInt32(getCookieValue("LeadId"));
            return currentLeadId;
        }


        public static string Is_User_Authenticate(int user_id, string from_name, string local_ip, string public_ip, string url_accessed)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);

            Encryption.MD5Encryption crypto = new Encryption.MD5Encryption();

            string intAuthStatus = "";
            DataTable res;
            res = data.SelectByParamDT("udsp_user_log_i", new System.Data.SqlClient.SqlParameter("@fk_user_id", user_id), new System.Data.SqlClient.SqlParameter("@local_ip", local_ip), new System.Data.SqlClient.SqlParameter("@public_ip", public_ip), new System.Data.SqlClient.SqlParameter("@url_accessed", url_accessed));
            if (res.Rows.Count > 0)
                intAuthStatus = res.Rows[0][0].ToString();
            return intAuthStatus;
        }

        public static DataTable getUserByUserId(int user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_getUserByUserId", new System.Data.SqlClient.SqlParameter("@pk_user_id", user_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables[0];
        }
        public static bool setCookieLeadID(string cookieValue)
        {
            try
            {
                Encryption.TripleDesEncryption crypto = new Encryption.TripleDesEncryption();
                System.Web.HttpCookie saveCookie = new System.Web.HttpCookie("LeadId", crypto.Encode(cookieValue));
                saveCookie.Expires = CoreGeneral.currentDateInMMDDYYYY().AddHours(9);
                // saveCookie.Domain = "health-total.com"
                HttpContext.Current.Response.Cookies.Add(saveCookie);
            }
            catch (Exception Ex)
            {
                HttpContext.Current.Trace.Warn(Ex.Message);
                return false;
            }
            return true;
        }

        public static DataTable makeCCEOD(int fk_user_id, string eod_date)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_cc_end_of_day", new System.Data.SqlClient.SqlParameter("@fk_user_id", fk_user_id), new System.Data.SqlClient.SqlParameter("@eod_date", eod_date));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables[0];
        }

        public static string ChangePassword(string user_oldpwd, string user_newpwd)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            string intRetVal = "";
            DataTable dt = data.SelectByParamDT("udsp_change_password", new System.Data.SqlClient.SqlParameter("@user_oldpwd", user_oldpwd), new System.Data.SqlClient.SqlParameter("@user_newpwd", user_newpwd), new System.Data.SqlClient.SqlParameter("@fk_user_id", getCurrentUserId()));
            intRetVal = dt.Rows[0]["retmsg"].ToString();
            
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return intRetVal;
        }

        public static string UserLoggedInOut()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            string retVal = "";
            DataTable res = data.SelectByParamDT("udsp_user_loggedOut_u", new System.Data.SqlClient.SqlParameter("@fk_user_id", getCurrentUserId()));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            if (res.Rows.Count > 0)
                retVal = res.Rows[0]["retMsg"].ToString();
            else
                retVal = "";
            return retVal;
        }
        public static int getCurrentLocaionType()
        {
            string strLocationId;
            strLocationId = getCookieValue("LocType");
            if (strLocationId != "")
                return System.Convert.ToInt32(strLocationId);
            else
               return 0;
        }
        
        public static string getCurrentUserLogInTime()
        {
            string strUserName;
            try
            {
                strUserName = getCookieValue("att_in_time");
            }
            catch (Exception ex)
            {
                strUserName = "";
            }
            return strUserName.ToString();
        }


        public static string getCurrentUserLogOutTime()
        {
            string strUserName;
            try
            {
                strUserName = getCookieValue("att_out_time");
            }
            catch (Exception ex)
            {
                strUserName = "";
            }
            return strUserName.ToString();
        }

        public static string getCurrentShitfStartTime()
        {
            string strUserName;
            try
            {
                strUserName = getCookieValue("ShftStartTime");
            }
            catch (Exception ex)
            {
                strUserName = "";
            }
            return strUserName.ToString();
        }


        public static string getCurrentShitfEndTime()
        {
            string strUserName;
            try
            {
                strUserName = getCookieValue("ShftEndTime");
            }
            catch (Exception ex)
            {
                strUserName = "";
            }
            return strUserName.ToString();
        }
        public static DataTable AllowExecLogin(int fk_user_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            try
            {
                DataTable dt = data.SelectByParamDT("udsp_executive_loggedin_u", new System.Data.SqlClient.SqlParameter("@user_id", fk_user_id));
                data = null/* TODO Change to default(_) if this is not a reference type */;
                return dt;
            }
            catch (Exception ex)
            {
                return null/* TODO Change to default(_) if this is not a reference type */;
            }
        }
        
    }

}
