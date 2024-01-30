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
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Configuration;
using S = System.Configuration.ConfigurationSettings;

namespace Core
{
    class SMSServices
    {
        public static string sendSMS(string Mobile, string SMSText, string peid, string templateid, ref string smsStatus)  // 1 - Address ; 2 - Appt Fixed ; 3 - Appt Remider
        {
            string strRetVal = "";
            try
            {
                string smsURl = "http://49.50.67.32/smsapi/httpapi.jsp?username=SDINSTA|%|password=SD@INSTA|%|from=DENTST|%|to=%mobile%|%|text=%msg%|%|coding=0|%|pe_id=%peid%|%|template_id=%templateid%|%|flash=1";
                // smsURl = "http://49.50.67.32/smsapi/httpapi.jsp?username=SDINSTA|%|password=SD@INSTA|%|from=DENTST|%|to=%mobile%|%|text=%msg%|%|coding=0|%|pe_id=%peid%|%|template_id=%templateid%|%|flash=1"
                smsURl = smsURl.Replace("|%|", "&");
                smsURl = smsURl.Replace("%mobile%", Mobile);
                smsURl = smsURl.Replace("%msg%", SMSText);
                smsURl = smsURl.Replace("%peid%", peid);
                smsURl = smsURl.Replace("%templateid%", templateid);
                WebRequest request = WebRequest.Create(smsURl);

                // smsURl = smsURl.Replace("|%|", "&");
                // smsURl = smsURl.Replace("%mobile%", Mobile);
                // smsURl = smsURl.Replace("%msg%", SMSText);
                // smsURl = smsURl.Replace("%peid%", peid);
                // smsURl = smsURl.Replace("%templateid%", templateid);
                // Create a request using a URL that can receive a post. 

                // Dim request As WebRequest = WebRequest.Create("http://49.50.67.32/smsapi/httpapi.jsp?username=SDINSTA|%|password=SD@INSTA|%|from=DENTST|%|to=%mobile%|%|text=%msg%|%|coding=0|%|pe_id=%peid%|%|template_id=%templateid%|%|flash=1";)
                // Dim request As WebRequest = WebRequest.Create("http://203.199.76.245/PUSHURL/SendSms.aspx?aggregatorname=TIL&clientname=Anjali%20Mukerjee%20Health%20Total&username=amht&password=amht@58888&messagetext=" & SMSText & "&msgtype=text&masking=Anjali M&delivery=true&clientuniqueid=xxxxx&dllurl=dlrurl&mobilenumber=" & Mobile)
                // Set the Method property of the request to POST.
                request.Method = "POST";
                // Create POST data and convert it to a byte array.
                string postData = "";
                ASCIIEncoding encoding = new ASCIIEncoding();
                byte[] byteArray = encoding.UTF8.GetBytes(postData);
                // Set the ContentType property of the WebRequest.
                request.ContentType = "application/x-www-form-urlencoded";
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;
                // Get the request stream.
                Stream dataStream = request.GetRequestStream();
                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);
                // Close the Stream object.
                dataStream.Close();
                // Get the response.
                WebResponse response = request.GetResponse();
                // Display the status.
                Console.WriteLine((HttpWebResponse)response.StatusDescription);
                // Get the stream containing content returned by the server.
                dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                // Display the content.
                // txtVerifyCode.Text = responseFromServer
                // Console.WriteLine(responseFromServer)

                strRetVal = responseFromServer;

                // Clean up the streams.
                reader.Close();
                dataStream.Close();
                response.Close();
                smsStatus = "success";
            }
            catch (Exception ex)
            {
                int a;
                a = 0;
                smsStatus = ex.ToString();
            }
            return strRetVal;
        }

        public static int sms_Transaction_insert(int fk_lead_id, string lead_mobile, int fk_sms_type_id, string gateway_response_id, string sms_text, string sms_delivery_status, int fk_user_id, string remarks
    )
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_sms_transaction_i", new System.Data.SqlClient.SqlParameter("@fk_lead_id", fk_lead_id), new System.Data.SqlClient.SqlParameter("@lead_mobile", lead_mobile), new System.Data.SqlClient.SqlParameter("@fk_sms_type_id", fk_sms_type_id), new System.Data.SqlClient.SqlParameter("@gateway_response_id", gateway_response_id), new System.Data.SqlClient.SqlParameter("@sms_text", sms_text), new System.Data.SqlClient.SqlParameter("@sms_delivery_status", sms_delivery_status), new System.Data.SqlClient.SqlParameter("@fk_user_id", fk_user_id), new System.Data.SqlClient.SqlParameter("@remarks", remarks)
    );
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return 1;
        }
        public static int sms_Transaction_insert_NameUpdate(int fk_lead_id, string lead_mobile, int fk_sms_type_id, string gateway_response_id, string sms_text, string sms_delivery_status, int fk_user_id, string remarks, int update_Name, string lead_name, string lead_surname)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_sms_transaction_i", new System.Data.SqlClient.SqlParameter("@fk_lead_id", fk_lead_id), new System.Data.SqlClient.SqlParameter("@lead_mobile", lead_mobile), new System.Data.SqlClient.SqlParameter("@fk_sms_type_id", fk_sms_type_id), new System.Data.SqlClient.SqlParameter("@gateway_response_id", gateway_response_id), new System.Data.SqlClient.SqlParameter("@sms_text", sms_text), new System.Data.SqlClient.SqlParameter("@sms_delivery_status", sms_delivery_status), new System.Data.SqlClient.SqlParameter("@fk_user_id", fk_user_id), new System.Data.SqlClient.SqlParameter("@remarks", remarks), new System.Data.SqlClient.SqlParameter("@update_Name", update_Name), new System.Data.SqlClient.SqlParameter("@lead_name", lead_name), new System.Data.SqlClient.SqlParameter("@lead_surname", lead_surname));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return 1;
        }
        public enum SMStpye
        {
            Address = 1,
            Appointment_Fixed = 2,
            Appointment_Reminder = 3
        }

        public static DataTable GetMessages_ForSMS()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res = data.RunSelectProcedure("udsp_getChat_Msgs_templates");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return res;
        }
    }
}
