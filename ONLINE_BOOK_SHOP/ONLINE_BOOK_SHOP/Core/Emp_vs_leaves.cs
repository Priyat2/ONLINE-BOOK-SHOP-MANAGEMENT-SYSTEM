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
    class Emp_vs_leaves
    {
        public int pk_evl_id
        {
            get
            {
                return m_pk_evl_id;
            }
            set
            {
                m_pk_evl_id = Value;
            }
        }
        private int m_pk_evl_id;
        public int evl_fk_emp_id
        {
            get
            {
                return m_evl_fk_emp_id;
            }
            set
            {
                m_evl_fk_emp_id = Value;
            }
        }
        private int m_evl_fk_emp_id;
        public float evl_total_cl
        {
            get
            {
                return m_evl_total_cl;
            }
            set
            {
                m_evl_total_cl = Value;
            }
        }
        private float m_evl_total_cl;
        public float evl_used_cl
        {
            get
            {
                return m_evl_used_cl;
            }
            set
            {
                m_evl_used_cl = Value;
            }
        }
        private float m_evl_used_cl;
        public float evl_bal_cl
        {
            get
            {
                return m_evl_bal_cl;
            }
            set
            {
                m_evl_bal_cl = Value;
            }
        }
        private float m_evl_bal_cl;
        public float evl_total_pl
        {
            get
            {
                return m_evl_total_pl;
            }
            set
            {
                m_evl_total_pl = Value;
            }
        }
        private float m_evl_total_pl;
        public float evl_used_pl
        {
            get
            {
                return m_evl_used_pl;
            }
            set
            {
                m_evl_used_pl = Value;
            }
        }
        private float m_evl_used_pl;
        public float evl_bal_pl
        {
            get
            {
                return m_evl_bal_pl;
            }
            set
            {
                m_evl_bal_pl = Value;
            }
        }
        private float m_evl_bal_pl;
        public float evl_total_co
        {
            get
            {
                return m_evl_total_co;
            }
            set
            {
                m_evl_total_co = Value;
            }
        }
        private float m_evl_total_co;
        public float evl_used_co
        {
            get
            {
                return m_evl_used_co;
            }
            set
            {
                m_evl_used_co = Value;
            }
        }
        private float m_evl_used_co;
        public float evl_bal_co
        {
            get
            {
                return m_evl_bal_co;
            }
            set
            {
                m_evl_bal_co = Value;
            }
        }
        private float m_evl_bal_co;
        public float evl_taken_lwp
        {
            get
            {
                return m_evl_taken_lwp;
            }
            set
            {
                m_evl_taken_lwp = Value;
            }
        }
        private float m_evl_taken_lwp;
        public int evl_cre_by
        {
            get
            {
                return m_evl_cre_by;
            }
            set
            {
                m_evl_cre_by = Value;
            }
        }
        private int m_evl_cre_by;
        public int evl_mod_by
        {
            get
            {
                return m_evl_mod_by;
            }
            set
            {
                m_evl_mod_by = Value;
            }
        }
        private int m_evl_mod_by;

        public DataTable udsp_Emp_vs_leaves_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_Emp_vs_leaves_i", new System.Data.SqlClient.SqlParameter("@pk_evl_id", this.pk_evl_id), new System.Data.SqlClient.SqlParameter("@evl_fk_emp_id", this.evl_fk_emp_id), new System.Data.SqlClient.SqlParameter("@evl_total_cl", this.evl_total_cl), new System.Data.SqlClient.SqlParameter("@evl_used_cl", this.evl_used_cl), new System.Data.SqlClient.SqlParameter("@evl_bal_cl", this.evl_bal_cl), new System.Data.SqlClient.SqlParameter("@evl_total_pl", this.evl_total_pl), new System.Data.SqlClient.SqlParameter("@evl_used_pl", this.evl_used_pl), new System.Data.SqlClient.SqlParameter("@evl_bal_pl", this.evl_bal_pl), new System.Data.SqlClient.SqlParameter("@evl_total_co", this.evl_total_co), new System.Data.SqlClient.SqlParameter("@evl_used_co", this.evl_used_co), new System.Data.SqlClient.SqlParameter("@evl_bal_co", this.evl_bal_co), new System.Data.SqlClient.SqlParameter("@evl_taken_lwp", this.evl_taken_lwp), new System.Data.SqlClient.SqlParameter("@evl_cre_by", this.evl_cre_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_Emp_vs_leaves_u()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_Emp_vs_leaves_u", new System.Data.SqlClient.SqlParameter("@pk_evl_id", this.pk_evl_id), new System.Data.SqlClient.SqlParameter("@evl_fk_emp_id", this.evl_fk_emp_id), new System.Data.SqlClient.SqlParameter("@evl_total_cl", this.evl_total_cl), new System.Data.SqlClient.SqlParameter("@evl_used_cl", this.evl_used_cl), new System.Data.SqlClient.SqlParameter("@evl_bal_cl", this.evl_bal_cl), new System.Data.SqlClient.SqlParameter("@evl_total_pl", this.evl_total_pl), new System.Data.SqlClient.SqlParameter("@evl_used_pl", this.evl_used_pl), new System.Data.SqlClient.SqlParameter("@evl_bal_pl", this.evl_bal_pl), new System.Data.SqlClient.SqlParameter("@evl_total_co", this.evl_total_co), new System.Data.SqlClient.SqlParameter("@evl_used_co", this.evl_used_co), new System.Data.SqlClient.SqlParameter("@evl_bal_co", this.evl_bal_co), new System.Data.SqlClient.SqlParameter("@evl_taken_lwp", this.evl_taken_lwp), new System.Data.SqlClient.SqlParameter("@evl_mod_by", this.evl_mod_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_get_emp_leaves()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_get_emp_leaves");
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_get_total_bal_used_pl_cl_co()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionStringHR);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_get_total_bal_used_pl_cl_co", new System.Data.SqlClient.SqlParameter("@evl_fk_emp_id", this.evl_fk_emp_id));
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
