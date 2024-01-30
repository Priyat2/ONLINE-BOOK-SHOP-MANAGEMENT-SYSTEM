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
using Website.Core.UserManagement;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Core
{
    class masters
    {

        // ----- one mobile no with mulitiple services start -----------
        public static DataTable getservice_type()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_service_type");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }


        public static DataTable GetAllPublishers_bySourceID(int showAll, int fk_source_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_getAllPublishers_bySourceID", new SqlClient.SqlParameter("@showAll", showAll), new SqlClient.SqlParameter("@fk_source_id", fk_source_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable GetAllPublishers_citywise_bySourceID(int showAll, int fk_source_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_getAllPublishers_bySourceID", new SqlClient.SqlParameter("@showAll", showAll), new SqlClient.SqlParameter("@fk_source_id", fk_source_id));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        public static DataTable GetAllFinancialYears()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_financial_years");
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }

        // Public Shared Function GetAllmonth() As DataTable
        // Dim data As New DataLayer.DataFunctions(WebAppSettings.ConnectionString)
        // Dim ds As DataSet = data.RunSelectProcedureByParameters("udsp_get_months")
        // data = Nothing
        // Return ds.Tables(0)
        // End Function

        public static DataTable getcenterLocationsCity(int showAll)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getCenter_Cities", new SqlClient.SqlParameter("@showAll", showAll));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable getAllSource(int selectedValue)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = data.SelectByParamDT("udsp_getAllsource", new SqlClient.SqlParameter("@selectedValue", selectedValue));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable get_Allsubcampaign_byCampaignID(int fk_campaign_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_allsubcampaign_bycampaign", new SqlClient.SqlParameter("@fk_campaign_id", fk_campaign_id), new SqlClient.SqlParameter("@showAllOption", 1));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }


        public static string ExportDataTableToExcel(DataTable dt, string strFrom)
        {
            HttpResponse response = HttpContext.Current.Response;
            // first let's clean up the response.object   
            response.Clear();
            response.Charset = "";
            // set the response mime type for excel   
            response.ContentType = "application/vnd.ms-excel";
            response.AddHeader("Content-Disposition", "attachment;filename=\"" + strFrom + ".xls");
            // create a string writer   
            using (StringWriter sw = new StringWriter())
            {
                using (HtmlTextWriter htw = new HtmlTextWriter(sw))
                {
                    DataGrid dg = new DataGrid();
                    dg.DataSource = dt;
                    dg.DataBind();
                    dg.RenderControl(htw);
                    response.Write(sw.ToString());
                    response.End();
                }
            }
        }
    }
}
