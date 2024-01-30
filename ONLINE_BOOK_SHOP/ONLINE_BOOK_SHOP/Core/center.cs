using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Encryption;

namespace Core
{
   public class center
    {

        public static DataTable get_cat_book()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_item_cat_books");
            return res;
        }

        public static DataTable get_all_book_item()
        {
            DataLayer.DataFunctions data = new DataLayer.DataFunctions(WebAppSettings.ConnectionString);
            DataTable res;
            res = data.SelectByParamDT("get_all_book_items");
            return res;

        }



    }
}
