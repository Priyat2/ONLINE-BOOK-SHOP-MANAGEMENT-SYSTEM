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
    class tr_emp_leave
    {
        public int pk_tr_el_id
        {
            get
            {
                return m_pk_tr_el_id;
            }
            set
            {
                m_pk_tr_el_id = value;
            }
        }
        private int m_pk_tr_el_id;
        public int el_fk_leave_id
        {
            get
            {
                return m_el_fk_leave_id;
            }
            set
            {
                m_el_fk_leave_id = value;
            }
        }
        private int m_el_fk_leave_id;
        public int el_fk_emp_id
        {
            get
            {
                return m_el_fk_emp_id;
            }
            set
            {
                m_el_fk_emp_id = value;
            }
        }
        private int m_el_fk_emp_id;
        public int el_days_count
        {
            get
            {
                return m_el_days_count;
            }
            set
            {
                m_el_days_count = value;
            }
        }
        private int m_el_days_count;
        public string el_remark
        {
            get
            {
                return m_el_remark;
            }
            set
            {
                m_el_remark = value;
            }
        }
        private string m_el_remark;

        public int el_status
        {
            get
            {
                return m_el_status;
            }
            set
            {
                m_el_status = value;
            }
        }
        private int m_el_status;
        public int el_level
        {
            get
            {
                return m_el_level;
            }
            set
            {
                m_el_level = value;
            }
        }
        private int m_el_level;
        public int el_appr_by
        {
            get
            {
                return m_el_appr_by;
            }
            set
            {
                m_el_appr_by = value;
            }
        }
        private int m_el_appr_by;
        public DateTime el_appr_dt
        {
            get
            {
                return m_el_appr_dt;
            }
            set
            {
                m_el_appr_dt = value;
            }
        }
        private DateTime m_el_appr_dt;
        public int el_cre_by
        {
            get
            {
                return m_el_cre_by;
            }
            set
            {
                m_el_cre_by = value;
            }
        }
        private int m_el_cre_by;
        public DateTime el_cre_dt
        {
            get
            {
                return m_el_cre_dt;
            }
            set
            {
                m_el_cre_dt = value;
            }
        }
        private DateTime m_el_cre_dt;

        public DataTable udsp_tr_emp_leave_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_tr_emp_leave_i", new System.Data.SqlClient.SqlParameter("@pk_tr_el_id", this.pk_tr_el_id), new System.Data.SqlClient.SqlParameter("@el_fk_leave_id", this.el_fk_leave_id), new System.Data.SqlClient.SqlParameter("@el_fk_emp_id", this.el_fk_emp_id), new System.Data.SqlClient.SqlParameter("@el_days_count", this.el_days_count), new System.Data.SqlClient.SqlParameter("@el_remark", this.el_remark), new System.Data.SqlClient.SqlParameter("@el_status", this.el_status), new System.Data.SqlClient.SqlParameter("@el_appr_by", this.el_appr_by), new System.Data.SqlClient.SqlParameter("@el_appr_dt", this.el_appr_dt), new System.Data.SqlClient.SqlParameter("@el_cre_by", this.el_cre_by));
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
