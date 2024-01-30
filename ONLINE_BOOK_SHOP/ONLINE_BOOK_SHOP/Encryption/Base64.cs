using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Base64
    {
   

    public static string ConvertToBase64(byte[] inputBytes)
    {
        string sOutput;
        sOutput = Convert.ToBase64String(inputBytes, 0, inputBytes.Length);
        return sOutput;
    }

    public static byte[] ConvertFromBase64(string inputCharacters)
    {
        byte[] arrOutput;
        arrOutput = Convert.FromBase64String(inputCharacters);
        return arrOutput;
    }
}
 }