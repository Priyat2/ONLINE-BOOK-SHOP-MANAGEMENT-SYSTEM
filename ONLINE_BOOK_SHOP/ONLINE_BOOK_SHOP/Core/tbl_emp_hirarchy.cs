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
    class tbl_emp_hirarchy
    {
        public int pk_hierarchy_id
        {
            get
            {
                return m_pk_hierarchy_id;
            }
            set
            {
                m_pk_hierarchy_id = value;
            }
        }
        private int m_pk_hierarchy_id;
        public int fk_emp_id
        {
            get
            {
                return m_fk_emp_id;
            }
            set
            {
                m_fk_emp_id = value;
            }
        }
        private int m_fk_emp_id;
        public int fk_role_id
        {
            get
            {
                return m_fk_role_id;
            }
            set
            {
                m_fk_role_id = value;
            }
        }
        private int m_fk_role_id;
        public int fk_loc_id
        {
            get
            {
                return m_fk_loc_id;
            }
            set
            {
                m_fk_loc_id = value;
            }
        }
        private int m_fk_loc_id;
        public int fk_sr_emp_id
        {
            get
            {
                return m_fk_sr_emp_id;
            }
            set
            {
                m_fk_sr_emp_id = value;
            }
        }
        private int m_fk_sr_emp_id;
        public int fk_ssr_emp_id
        {
            get
            {
                return m_fk_ssr_emp_id;
            }
            set
            {
                m_fk_ssr_emp_id = value;
            }
        }
        private int m_fk_ssr_emp_id;
        public int fk_hr_id
        {
            get
            {
                return m_fk_hr_id;
            }
            set
            {
                m_fk_hr_id = value;
            }
        }
        private int m_fk_hr_id;
        public int hierarchy_mod_by
        {
            get
            {
                return m_hierarchy_mod_by;
            }
            set
            {
                m_hierarchy_mod_by = value;
            }
        }
        private int m_hierarchy_mod_by;
        public DateTime hierarchy_mod_dt
        {
            get
            {
                return m_hierarchy_mod_dt;
            }
            set
            {
                m_hierarchy_mod_dt = value;
            }
        }
        private DateTime m_hierarchy_mod_dt;
        public int hierarchy_cre_by
        {
            get
            {
                return m_hierarchy_cre_by;
            }
            set
            {
                m_hierarchy_cre_by = value;
            }
        }
        private int m_hierarchy_cre_by;
        public DateTime hierarchy_cre_dt
        {
            get
            {
                return m_hierarchy_cre_dt;
            }
            set
            {
                m_hierarchy_cre_dt = value;
            }
        }
        private DateTime m_hierarchy_cre_dt;



        public DataTable udsp_tbl_emp_hirarchy_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_tbl_emp_hirarchy_i", new System.Data.SqlClient.SqlParameter("@pk_hierarchy_id", this.pk_hierarchy_id), new System.Data.SqlClient.SqlParameter("@fk_emp_id", this.fk_emp_id), new System.Data.SqlClient.SqlParameter("@fk_role_id", this.fk_role_id), new System.Data.SqlClient.SqlParameter("@fk_loc_id", this.fk_loc_id), new System.Data.SqlClient.SqlParameter("@fk_sr_emp_id", this.fk_sr_emp_id), new System.Data.SqlClient.SqlParameter("@fk_ssr_emp_id", this.fk_ssr_emp_id), new System.Data.SqlClient.SqlParameter("@fk_hr_id", this.fk_hr_id), new System.Data.SqlClient.SqlParameter("@hierarchy_cre_by", this.hierarchy_cre_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_tbl_emp_hirarchy_u()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_tbl_emp_hirarchy_u", new System.Data.SqlClient.SqlParameter("@pk_hierarchy_id", this.pk_hierarchy_id), new System.Data.SqlClient.SqlParameter("@fk_emp_id", this.fk_emp_id), new System.Data.SqlClient.SqlParameter("@fk_role_id", this.fk_role_id), new System.Data.SqlClient.SqlParameter("@fk_loc_id", this.fk_loc_id), new System.Data.SqlClient.SqlParameter("@fk_sr_emp_id", this.fk_sr_emp_id), new System.Data.SqlClient.SqlParameter("@fk_ssr_emp_id", this.fk_ssr_emp_id), new System.Data.SqlClient.SqlParameter("@fk_hr_id", this.fk_hr_id), new System.Data.SqlClient.SqlParameter("@hierarchy_mod_by", this.hierarchy_mod_by));
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

