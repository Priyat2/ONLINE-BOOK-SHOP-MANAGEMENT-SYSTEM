using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace Encryption
{
    public class MD5Encryption
    {
        public new string Encode(string message)
        {

            // The string we wish to encrypt
            string strPlainText = message;

            // The array of bytes that will contain the encrypted value of strPlainText
            byte[] hashedDataBytes;

            // The encoder class used to convert strPlainText to an array of bytes
            UTF8Encoding encoder = new UTF8Encoding();

            // Create an instance of the MD5CryptoServiceProvider class
            MD5CryptoServiceProvider md5Hasher = new MD5CryptoServiceProvider();

            // Call ComputeHash, passing in the plain-text string as an array of bytes
            // The return value is the encrypted value, as an array of bytes
            hashedDataBytes = md5Hasher.ComputeHash(encoder.GetBytes(strPlainText));

            return Base64.ConvertToBase64(hashedDataBytes);
        }

        public new string Encode(string message, string salt)
        {
            return Encode(salt + message);
        }
    }
}
