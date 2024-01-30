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
namespace Core
{
    class supportServices
    {
        public static DataTable getQuestions(int fk_role_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = data.RunSelectProcedureByParameters("udsp_get_questions_by_role", new SqlClient.SqlParameter("@fk_role_id", fk_role_id), new SqlClient.SqlParameter("@fk_app_id", WebAppSettings.ApplicationID));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds.Tables(0);
        }


        public static DataTable insertUserFeedBack(string fk_user_id, int fk_question_id, int fk_ans_id, string fb_remarks)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable retTable;
            DataSet ds = data.RunSelectProcedureByParameters("udsp_user_vs_feedback_i", new SqlClient.SqlParameter("@fk_user_id", fk_user_id), new SqlClient.SqlParameter("@fk_question_id", fk_question_id), new SqlClient.SqlParameter("@fk_feedback_value_id", fk_ans_id), new SqlClient.SqlParameter("@feedback_remarks", fb_remarks));
            data = null/* TODO Change to default(_) if this is not a reference type */;
            if (ds.Tables.Count > 0)
                retTable = ds.Tables(0);
            else
                retTable = null/* TODO Change to default(_) if this is not a reference type */;
            return retTable;
        }
    }
}
