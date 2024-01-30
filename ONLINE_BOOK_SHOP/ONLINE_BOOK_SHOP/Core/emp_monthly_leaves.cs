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
    class emp_monthly_leaves
    {
        public int pk_eml_id
        {
            get
            {
                return m_pk_eml_id;
            }
            set
            {
                m_pk_eml_id = value;
            }
        }
        private int m_pk_eml_id;
        public int eml_fk_emp_id
        {
            get
            {
                return m_eml_fk_emp_id;
            }
            set
            {
                m_eml_fk_emp_id = value;
            }
        }
        private int m_eml_fk_emp_id;
        public float eml_cl
        {
            get
            {
                return m_eml_cl;
            }
            set
            {
                m_eml_cl = value;
            }
        }
        private float m_eml_cl;
        public float eml_pl
        {
            get
            {
                return m_eml_pl;
            }
            set
            {
                m_eml_pl = value;
            }
        }
        private float m_eml_pl;
        public float eml_cre_by
        {
            get
            {
                return m_eml_cre_by;
            }
            set
            {
                m_eml_cre_by = value;
            }
        }
        private float m_eml_cre_by;
        public float eml_cre_dt
        {
            get
            {
                return m_eml_cre_dt;
            }
            set
            {
                m_eml_cre_dt = value;
            }
        }
        private float m_eml_cre_dt;
        public float eml_mod_by
        {
            get
            {
                return m_eml_mod_by;
            }
            set
            {
                m_eml_mod_by = value;
            }
        }
        private float m_eml_mod_by;
        public float eml_mod_dt
        {
            get
            {
                return m_eml_mod_dt;
            }
            set
            {
                m_eml_mod_dt = value;
            }
        }
        private float m_eml_mod_dt;

        public DataTable udsp_emp_monthly_leaves_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_emp_monthly_leaves_i", new System.Data.SqlClient.SqlParameter("@pk_eml_id", this.pk_eml_id), new System.Data.SqlClient.SqlParameter("@eml_fk_emp_id", this.eml_fk_emp_id), new System.Data.SqlClient.SqlParameter("@eml_cl", this.eml_cl), new System.Data.SqlClient.SqlParameter("@eml_pl", this.eml_pl), new System.Data.SqlClient.SqlParameter("@eml_cre_by", this.eml_cre_by));
            }
            catch (Exception ex)
            {
                dt = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return dt;
        }
        public DataTable udsp_emp_monthly_leaves_u()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_emp_monthly_leaves_u", new System.Data.SqlClient.SqlParameter("@pk_eml_id", this.pk_eml_id), new System.Data.SqlClient.SqlParameter("@eml_fk_emp_id", this.eml_fk_emp_id), new System.Data.SqlClient.SqlParameter("@eml_cl", this.eml_cl), new System.Data.SqlClient.SqlParameter("@eml_pl", this.eml_pl), new System.Data.SqlClient.SqlParameter("@eml_mod_by", this.eml_mod_by));
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
