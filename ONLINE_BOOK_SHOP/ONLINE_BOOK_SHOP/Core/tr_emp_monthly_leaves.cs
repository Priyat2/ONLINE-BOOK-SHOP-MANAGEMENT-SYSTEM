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
    class tr_emp_monthly_leaves
    {
        public int pk_tr_eml_id
        {
            get
            {
                return m_pk_tr_eml_id;
            }
            set
            {
                m_pk_tr_eml_id = value;
            }
        }
        private int m_pk_tr_eml_id;
        public int tr_fk_eml_id
        {
            get
            {
                return m_tr_fk_eml_id;
            }
            set
            {
                m_tr_fk_eml_id = value;
            }
        }
        private int m_tr_fk_eml_id;
        public int tr_eml_fk_emp_id
        {
            get
            {
                return m_tr_eml_fk_emp_id;
            }
            set
            {
                m_tr_eml_fk_emp_id = value;
            }
        }
        private int m_tr_eml_fk_emp_id;
        public float tr_eml_cl
        {
            get
            {
                return m_tr_eml_cl;
            }
            set
            {
                m_tr_eml_cl = value;
            }
        }
        private float m_tr_eml_cl;
        public float tr_eml_pl
        {
            get
            {
                return m_tr_eml_pl;
            }
            set
            {
                m_tr_eml_pl = value;
            }
        }
        private float m_tr_eml_pl;
        public int tr_eml_cre_by
        {
            get
            {
                return m_tr_eml_cre_by;
            }
            set
            {
                m_tr_eml_cre_by = value;
            }
        }
        private int m_tr_eml_cre_by;
        public DateTime tr_eml_cre_dt
        {
            get
            {
                return m_tr_eml_cre_dt;
            }
            set
            {
                m_tr_eml_cre_dt = value;
            }
        }
        private DateTime m_tr_eml_cre_dt;

        public DataTable udsp_tr_emp_monthly_leaves_i()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable dt = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                dt = data.SelectByParamDT("udsp_tr_emp_monthly_leaves_i", new System.Data.SqlClient.SqlParameter("@pk_tr_eml_id", this.pk_tr_eml_id), new System.Data.SqlClient.SqlParameter("@tr_fk_eml_id", this.tr_fk_eml_id), new System.Data.SqlClient.SqlParameter("@tr_eml_fk_emp_id", this.tr_eml_fk_emp_id), new System.Data.SqlClient.SqlParameter("@tr_eml_cl", this.tr_eml_cl), new System.Data.SqlClient.SqlParameter("@tr_eml_pl", this.tr_eml_pl), new System.Data.SqlClient.SqlParameter("@tr_eml_cre_by", this.tr_eml_cre_by), new System.Data.SqlClient.SqlParameter("@tr_eml_cre_dt", this.tr_eml_cre_dt));
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
