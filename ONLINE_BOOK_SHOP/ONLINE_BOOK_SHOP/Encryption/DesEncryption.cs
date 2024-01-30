using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using System.Security.Cryptography;

namespace Encryption
{
    class DesEncryption
    {
        private byte[] _KeyBytes = new byte[8];
        private byte[] _IV = new byte[8];
        private string _Key = "DB2226E8EFE94D52BC711D7022BDF36D";

        public DesEncryption()
        {
            byte[] arrKey = new byte[_Key.Length + 1];
            arrKey = ConvertToByteArray(_Key);
            byte[] arrHash = new byte[arrKey.Length + 1];
            arrHash = ConvertToHash(arrKey);
            if (SetKeys(arrHash) == false)
                throw new ArgumentException("Couldn't Set Keys!");
        }

        public DesEncryption(string requestedKey)
        {
            _Key = requestedKey;
            byte[] arrKey = new byte[_Key.Length + 1];
            arrKey = ConvertToByteArray(_Key);
            byte[] arrHash = new byte[arrKey.Length + 1];
            arrHash = ConvertToHash(arrKey);
            if (SetKeys(arrHash) == false)
                throw new ArgumentException("Couldn't Set Keys!");
        }

        public string Encode(string message)
        {
            string sOutput = "";

            try
            {
                // Convert input to byte array
                byte[] arrInput = new byte[message.Length + 1];
                arrInput = ConvertToByteArray(message);

                DESCryptoServiceProvider DESProvider;

                ICryptoTransform DESEncryptor;
                CryptoStream DESStream;
                MemoryStream outStream;
                DESProvider = new DESCryptoServiceProvider();
                DESEncryptor = DESProvider.CreateEncryptor(_KeyBytes, _IV);
                outStream = new MemoryStream();
                DESStream = new CryptoStream(outStream, DESEncryptor, CryptoStreamMode.Write);
                DESStream.Write(arrInput, 0, arrInput.Length);
                DESStream.FlushFinalBlock();

                if ((outStream.Length == 0))
                    sOutput = "";
                else
                    sOutput = Base64.ConvertToBase64(outStream.ToArray());

                DESStream.Close();
            }
            catch (Exception Ex)
            {
                throw new ArgumentException("Couldn't Encode Message: " + Ex.Message);
            }

            return sOutput;
        }

        public string Decode(string message)
        {
            string sOutput = "";

            try
            {
                byte[] arrInput;
                arrInput = Base64.ConvertFromBase64(message);

                DESCryptoServiceProvider DESProvider;
                ICryptoTransform DESDecryptor;
                CryptoStream DESStream;
                MemoryStream outStream;

                DESProvider = new DESCryptoServiceProvider();
                DESDecryptor = DESProvider.CreateDecryptor(_KeyBytes, _IV);
                outStream = new MemoryStream();
                DESStream = new CryptoStream(outStream, DESDecryptor, CryptoStreamMode.Write);
                DESStream.Write(arrInput, 0, arrInput.Length);
                DESStream.FlushFinalBlock();

                if ((outStream.Length == 0))
                    sOutput = "";
                else
                    sOutput = ASCIIEncoding.ASCII.GetString(outStream.GetBuffer(), 0, Convert.ToInt32(outStream.Length));
            }

            catch (Exception Ex)
            {
                throw new ArgumentException("Couldn't Decode Message: " + Ex.Message);
            }

            return sOutput;
        }

        public byte[] ConvertToByteArray(string inputCharacters)
        {
            int iCounter = 0;
            char[] arrChar;

            arrChar = inputCharacters.ToCharArray();

            byte[] arrByte = new byte[arrChar.Length - 1 + 1];
            for (iCounter = 0; iCounter <= arrByte.Length - 1; iCounter++)
                arrByte[iCounter] = Convert.ToByte(arrChar[iCounter]);
            return arrByte;
        }

        private byte[] ConvertToHash(byte[] arraryInput)
        {
            byte[] arrOutput;
            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();
            arrOutput = sha.ComputeHash(arraryInput);
            return arrOutput;
        }

        private bool SetKeys(byte[] arraryHash)
        {
            try
            {
                int i = 0;
                for (i = 0; i <= 7; i += 1)
                    _KeyBytes[i] = arraryHash[i];
                for (i = 8; i <= 15; i += 1)
                    _IV[i - 8] = arraryHash[i];
                return true;
            }
            catch (IndexOutOfRangeException rangeEx)
            {
                return false;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
    }
}
