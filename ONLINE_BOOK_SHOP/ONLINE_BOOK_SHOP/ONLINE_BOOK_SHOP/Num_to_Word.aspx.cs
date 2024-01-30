using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ONLINE_BOOK_SHOP
{
    public partial class Num_to_Word : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            int number = 0;
            if (int.TryParse(txtNumber.Text, out number))
            {
                string words = ConvertNumberToWords(number);
                lblResult.Text = words;
            }
            else
            {
                lblResult.Text = "Invalid number input";
            }
        }

        public string ConvertNumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            // Array of number names
            string[] units = {
                "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
            };

            string[] tens = {
                "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
            };

            // Convert the number to words
            if (number < 0)
            {
                return "minus " + ConvertNumberToWords(Math.Abs(number));
            }

            string words = "";

            if ((number / 10000000) > 0)
            {
                words += ConvertNumberToWords(number / 10000000) + " crore ";
                number %= 10000000;
            }

            if ((number / 100000) > 0)
            {
                words += ConvertNumberToWords(number / 100000) + " lakh ";
                number %= 100000;
            }

            if ((number / 1000) > 0)
            {
                words += ConvertNumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += ConvertNumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (number < 20)
                    words += units[number - 1];
                else
                {
                    words += tens[(number / 10) - 2];
                    if ((number % 10) > 0)
                        words += "-" + units[(number % 10) - 1];
                }
            }

            return words;
        }
    }
}