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
    class Health_Pramoter
    {
        private int _pk_htpr_id;
        private int _fk_lead_id;
        private int _fk_htbuddy_id;
        private string _htpr_name;
        private string _htpr_mobile;
        private string _htpr_email;
        private string _htpr_cust_id;
        private string _htpr_address;
        private string _htpr_acc_no;
        private string _htpr_bank_name;
        private string _htpr_bank_ifsi_code;
        private string _htpr_branch_name;
        private string _htpr_branch_address;

        private string _htpr_remarks;
        private string _htpr_img1;
        private string _htpr_img2;
        private string _htpr_img3;
        private bool _htpr_is_approved;
        private bool _htpr_is_active;
        private int _htpr_created_by;
        private DateTime _htpr_created_dt;
        private int _htpr_modify_by;
        private DateTime _htpr_modify_dt;
        private string _htpr_pan_no;

        public string htpr_pan_no
        {
            get
            {
                return _htpr_pan_no;
            }
            set
            {
                _htpr_pan_no = value;
            }
        }

        public string htpr_remarks
        {
            get
            {
                return _htpr_remarks;
            }
            set
            {
                _htpr_remarks = value;
            }
        }

        public int pk_htpr_id
        {
            get
            {
                return _pk_htpr_id;
            }
            set
            {
                _pk_htpr_id = value;
            }
        }
        public int fk_lead_id
        {
            get
            {
                return _fk_lead_id;
            }
            set
            {
                _fk_lead_id = value;
            }
        }
        public int fk_htbuddy_id
        {
            get
            {
                return _fk_htbuddy_id;
            }
            set
            {
                _fk_htbuddy_id = value;
            }
        }
        public string htpr_name
        {
            get
            {
                return _htpr_name;
            }
            set
            {
                _htpr_name = value;
            }
        }
        public string htpr_mobile
        {
            get
            {
                return _htpr_mobile;
            }
            set
            {
                _htpr_mobile = value;
            }
        }
        public string htpr_email
        {
            get
            {
                return _htpr_email;
            }
            set
            {
                _htpr_email = value;
            }
        }

        public string htpr_cust_id
        {
            get
            {
                return _htpr_cust_id;
            }
            set
            {
                _htpr_cust_id = value;
            }
        }

        public string htpr_address
        {
            get
            {
                return _htpr_address;
            }
            set
            {
                _htpr_address = value;
            }
        }

        public string htpr_acc_no
        {
            get
            {
                return _htpr_acc_no;
            }
            set
            {
                _htpr_acc_no = value;
            }
        }

        public string htpr_bank_name
        {
            get
            {
                return _htpr_bank_name;
            }
            set
            {
                _htpr_bank_name = value;
            }
        }
        public string htpr_bank_ifsi_code
        {
            get
            {
                return _htpr_bank_ifsi_code;
            }
            set
            {
                _htpr_bank_ifsi_code = value;
            }
        }
        public string htpr_branch_name
        {
            get
            {
                return _htpr_branch_name;
            }
            set
            {
                _htpr_branch_name = value;
            }
        }
        public string htpr_branch_address
        {
            get
            {
                return _htpr_branch_address;
            }
            set
            {
                _htpr_branch_address = value;
            }
        }
        public string htpr_img1
        {
            get
            {
                return _htpr_img1;
            }
            set
            {
                _htpr_img1 = value;
            }
        }
        public string htpr_img2
        {
            get
            {
                return _htpr_img2;
            }
            set
            {
                _htpr_img2 = value;
            }
        }
        public string htpr_img3
        {
            get
            {
                return _htpr_img3;
            }
            set
            {
                _htpr_img3 = value;
            }
        }
        public bool htpr_is_approved
        {
            get
            {
                return _htpr_is_approved;
            }
            set
            {
                _htpr_is_approved = value;
            }
        }
        public bool htpr_is_active
        {
            get
            {
                return _htpr_is_active;
            }
            set
            {
                _htpr_is_active = value;
            }
        }
        public int htpr_created_by
        {
            get
            {
                return _htpr_created_by;
            }
            set
            {
                _htpr_created_by = value;
            }
        }
        public int htpr_modify_by
        {
            get
            {
                return _htpr_modify_by;
            }
            set
            {
                _htpr_modify_by = value;
            }
        }

        public DataSet health_pramoter_insert()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataSet ds = null/* TODO Change to default(_) if this is not a reference type */;
            try
            {
                ds = data.RunSelectProcedureByParameters("udsp_health_pramoter_i_LMS", new SqlClient.SqlParameter("@fk_htbuddy_id", this.fk_htbuddy_id), new SqlClient.SqlParameter("@htpr_name", this.htpr_name), new SqlClient.SqlParameter("@htpr_mobile", this.htpr_mobile), new SqlClient.SqlParameter("@htpr_email", this.htpr_email), new SqlClient.SqlParameter("@htpr_cust_id", this.htpr_cust_id), new SqlClient.SqlParameter("@htpr_address", this.htpr_address), new SqlClient.SqlParameter("@htpr_acc_no", this.htpr_acc_no), new SqlClient.SqlParameter("@htpr_bank_name", this.htpr_bank_name), new SqlClient.SqlParameter("@htpr_bank_ifsi_code", this.htpr_bank_ifsi_code), new SqlClient.SqlParameter("@htpr_branch_name", this.htpr_branch_name), new SqlClient.SqlParameter("@htpr_branch_address", this.htpr_branch_address), new SqlClient.SqlParameter("@htpr_img1", this.htpr_img1), new SqlClient.SqlParameter("@htpr_img2", this.htpr_img2), new SqlClient.SqlParameter("@htpr_img3", this.htpr_img3), new SqlClient.SqlParameter("@htpr_is_approved", this.htpr_is_approved), new SqlClient.SqlParameter("@htpr_is_active", this.htpr_is_active), new SqlClient.SqlParameter("@htpr_created_by", this.htpr_created_by), new SqlClient.SqlParameter("@htpr_modify_by", this.htpr_modify_by), new SqlClient.SqlParameter("@htpr_remark", this.htpr_remarks), new SqlClient.SqlParameter("@htpr_pan_no", this.htpr_pan_no));
            }
            catch
            {
                ds = null/* TODO Change to default(_) if this is not a reference type */;
            }
            data = null/* TODO Change to default(_) if this is not a reference type */;
            return ds;
        }
    }
}
