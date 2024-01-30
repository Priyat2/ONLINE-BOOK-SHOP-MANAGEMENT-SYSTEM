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
using System.Xml;
using System.Configuration;
using System.Web;
using System.Xml.Serialization;
using System.Data; 
using System.Data.SqlClient;
 
namespace Core
{
    class WebAppSettings
    {
        
        public static System.Globalization.CultureInfo WebAppSettingsDateCulture
        {
            get
            {
                System.Globalization.CultureInfo tempCulture;
                tempCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");

                return tempCulture;
            }
        }

        private WebAppSettings()
        {
        }

        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
        }

        public static string ConnectionString1
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString;
            }
        }

        public static string ConnectionStringHR
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionStringHR"].ConnectionString;
            }
        }
        public static string ConnectionStringWebsite
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["ConnectionStringWebsite"].ConnectionString;
            }
        }

        public static string ConnectionStrings { get; internal set; }
    }
}