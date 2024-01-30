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
    class emp_leave
    {
        public int pk_leave_id
        {
            get
            {
                return m_pk_leave_id;
            }
            set
            {
                m_pk_leave_id = value;
            }
        }
        private int m_pk_leave_id;
        public string evl_leave_code
        {
            get
            {
                return m_evl_leave_code;
            }
            set
            {
                m_evl_leave_code = value;
            }
        }
        private string m_evl_leave_code;
        public int evl_fk_employee_id
        {
            get
            {
                return m_evl_fk_employee_id;
            }
            set
            {
                m_evl_fk_employee_id = value;
            }
        }
        private int m_evl_fk_employee_id;
        public int ev_fk_leave_type_id
        {
            get
            {
                return m_ev_fk_leave_type_id;
            }
            set
            {
                m_ev_fk_leave_type_id = value;
            }
        }
        private int m_ev_fk_leave_type_id;
        public DateTime evl_start_date
        {
            get
            {
                return m_evl_start_date;
            }
            set
            {
                m_evl_start_date = value;
            }
        }
        private DateTime m_evl_start_date;
        public DateTime evl_end_date
        {
            get
            {
                return m_evl_end_date;
            }
            set
            {
                m_evl_end_date = value;
            }
        }
        private DateTime m_evl_end_date;
        public string evl_reason
        {
            get
            {
                return m_evl_reason;
            }
            set
            {
                m_evl_reason = value;
            }
        }
        private string m_evl_reason;
        public int evl_status
        {
            get
            {
                return m_evl_status;
            }
            set
            {
                m_evl_status = value;
            }
        }
        private int m_evl_status;
        public int evl_approval_level
        {
            get
            {
                return m_evl_approval_level;
            }
            set
            {
                m_evl_approval_level = value;
            }
        }
        private int m_evl_approval_level;
        public int evl_days_count
        {
            get
            {
                return m_evl_days_count;
            }
            set
            {
                m_evl_days_count = value;
            }
        }
        private int m_evl_days_count;
        public string evl_cont_add
        {
            get
            {
                return m_evl_cont_add;
            }
            set
            {
                m_evl_cont_add = value;
            }
        }
        private string m_evl_cont_add;
        public string evl_cont_no
        {
            get
            {
                return m_evl_cont_no;
            }
            set
            {
                m_evl_cont_no = value;
            }
        }
        private string m_evl_cont_no;
        public int evl_is_del
        {
            get
            {
                return m_evl_is_del;
            }
            set
            {
                m_evl_is_del = value;
            }
        }
        private int m_evl_is_del;
        public int evl_is_actv
        {
            get
            {
                return m_evl_is_actv;
            }
            set
            {
                m_evl_is_actv = value;
            }
        }
        private int m_evl_is_actv;
        public DateTime evl_cre_dt
        {
            get
            {
                return m_evl_cre_dt;
            }
            set
            {
                m_evl_cre_dt = value;
            }
        }
        private DateTime m_evl_cre_dt;
        public int evl_cre_by
        {
            get
            {
                return m_evl_cre_by;
            }
            set
            {
                m_evl_cre_by = value;
            }
        }
        private int m_evl_cre_by;
        public DateTime evl_mod_dt
        {
            get
            {
                return m_evl_mod_dt;
            }
            set
            {
                m_evl_mod_dt = value;
            }
        }
        private DateTime m_evl_mod_dt;
        public int evl_mod_by
        {
            get
            {
                return m_evl_mod_by;
            }
            set
            {
                m_evl_mod_by = value;
            }
        }
        private int m_evl_mod_by;


        public DataTable udsp_emp_leave_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_emp_leave_i", new System.Data.SqlClient.SqlParameter("@pk_leave_id", this.pk_leave_id), new System.Data.SqlClient.SqlParameter("@evl_leave_code", this.evl_leave_code), new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id), new System.Data.SqlClient.SqlParameter("@ev_fk_leave_type_id", this.ev_fk_leave_type_id), new System.Data.SqlClient.SqlParameter("@evl_start_date", this.evl_start_date), new System.Data.SqlClient.SqlParameter("@evl_end_date", this.evl_end_date), new System.Data.SqlClient.SqlParameter("@evl_reason", this.evl_reason), new System.Data.SqlClient.SqlParameter("@evl_status", this.evl_status), new System.Data.SqlClient.SqlParameter("@evl_approval_level", this.evl_approval_level), new System.Data.SqlClient.SqlParameter("@evl_days_count", this.evl_days_count), new System.Data.SqlClient.SqlParameter("@evl_cont_add", this.evl_cont_add), new System.Data.SqlClient.SqlParameter("@evl_cont_no", this.evl_cont_no), new System.Data.SqlClient.SqlParameter("@evl_is_del", this.evl_is_del), new System.Data.SqlClient.SqlParameter("@evl_is_actv", this.evl_is_actv), new System.Data.SqlClient.SqlParameter("@evl_cre_by", this.evl_cre_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_emp_leave_u()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_emp_leave_u", new System.Data.SqlClient.SqlParameter("@pk_leave_id", this.pk_leave_id), new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id), new System.Data.SqlClient.SqlParameter("@ev_fk_leave_type_id", this.ev_fk_leave_type_id), new System.Data.SqlClient.SqlParameter("@evl_start_date", this.evl_start_date), new System.Data.SqlClient.SqlParameter("@evl_end_date", this.evl_end_date), new System.Data.SqlClient.SqlParameter("@evl_reason", this.evl_reason), new System.Data.SqlClient.SqlParameter("@evl_status", this.evl_status), new System.Data.SqlClient.SqlParameter("@evl_approval_level", this.evl_approval_level), new System.Data.SqlClient.SqlParameter("@evl_days_count", this.evl_days_count), new System.Data.SqlClient.SqlParameter("@evl_is_actv", this.evl_is_actv), new System.Data.SqlClient.SqlParameter("@evl_mod_by", this.evl_mod_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_get_employee_details()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_get_employee_details", new System.Data.SqlClient.SqlParameter("@emp_fk_user_id_db", UserManagement.getCurrentUserId()));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_emp_leave_Request()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_emp_leave_Request", new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataSet udsp_emp_leave_Request_by_id()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataSet ds = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                ds = data.SelectDataSetByParameters("udsp_emp_leave_Request_by_id", new System.Data.SqlClient.SqlParameter("@pk_leave_id", this.pk_leave_id), new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id));
            }
            catch (Exception ex)
            {
                ds = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public DataTable udsp_get_leave_to_approve()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_get_leave_to_approve", new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataSet udsp_emp_leave_cancel()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataSet ds = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                ds = data.SelectDataSetByParameters("udsp_emp_leave_cancel", new System.Data.SqlClient.SqlParameter("@pk_leave_id", this.pk_leave_id), new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id), new System.Data.SqlClient.SqlParameter("@ev_fk_leave_type_id", this.ev_fk_leave_type_id), new System.Data.SqlClient.SqlParameter("@evl_reason", this.evl_reason), new System.Data.SqlClient.SqlParameter("@evl_status", this.evl_status), new System.Data.SqlClient.SqlParameter("@evl_approval_level", this.evl_approval_level), new System.Data.SqlClient.SqlParameter("@evl_mod_by", this.evl_mod_by));
            }
            catch (Exception ex)
            {
                ds = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public DataSet udsp_emp_leave_Approve()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataSet ds = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                ds = data.SelectDataSetByParameters("udsp_emp_leave_cancel", new System.Data.SqlClient.SqlParameter("@pk_leave_id", this.pk_leave_id), new System.Data.SqlClient.SqlParameter("@evl_fk_employee_id", this.evl_fk_employee_id), new System.Data.SqlClient.SqlParameter("@evl_reason", this.evl_reason), new System.Data.SqlClient.SqlParameter("@evl_status", this.evl_status), new System.Data.SqlClient.SqlParameter("@evl_approval_level", this.evl_approval_level), new System.Data.SqlClient.SqlParameter("@evl_mod_by", this.evl_mod_by));
            }
            catch (Exception ex)
            {
                ds = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
        public static DataTable getAllMonths(int fk_emp_id)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt;
            try
            {
                dt = data.SelectByParamDT("udsp_get_all_months", new SqlClient.SqlParameter("@fk_emp_id", fk_emp_id));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public static DataTable GetSubordinateLevaeReport(int fk_emp_id, int MontId)
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt;
            try
            {
                dt = data.SelectByParamDT("udsp_get_subordinate_levae_report_month_wise", new SqlClient.SqlParameter("@mgrId", fk_emp_id), new SqlClient.SqlParameter("@month", MontId));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
    }
}
