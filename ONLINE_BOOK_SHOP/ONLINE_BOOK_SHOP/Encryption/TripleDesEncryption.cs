using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
  public  class TripleDesEncryption
    {
        private byte[] _KeyBytes = new byte[24];
        private byte[] _IV = new byte[8];
        private string _Key = "EDBE6BF8A92A417cBCD3DB23120861B5DE780BA44DB44166888707607A2A16FBBADFD3E111D54396A5701CE43E0EC3FFAE5543370AF54228B65CB87D7E346048";

        public TripleDesEncryption()
        {
            byte[] arrKey = new byte[_Key.Length + 1];
            arrKey = ConvertToByteArray(_Key);
            byte[] arrHash = new byte[arrKey.Length + 1];
            arrHash = ConvertToHash(arrKey);
            if (SetKeys(arrHash) == false)
                throw new ArgumentException("Couldn't Set Keys!");
        }

        public TripleDesEncryption(string requestedKey)
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

                TripleDESCryptoServiceProvider TripleDESProvider;

                ICryptoTransform TripleDESEncryptor;
                CryptoStream TripleDESStream;
                MemoryStream outStream;
                TripleDESProvider = new TripleDESCryptoServiceProvider();
                TripleDESEncryptor = TripleDESProvider.CreateEncryptor(_KeyBytes, _IV);
                outStream = new MemoryStream();
                TripleDESStream = new CryptoStream(outStream, TripleDESEncryptor, CryptoStreamMode.Write);
                TripleDESStream.Write(arrInput, 0, arrInput.Length);
                TripleDESStream.FlushFinalBlock();

                if ((outStream.Length == 0))
                    sOutput = "";
                else
                    sOutput = Base64.ConvertToBase64(outStream.ToArray());

                TripleDESStream.Close();
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

                TripleDESCryptoServiceProvider TripleDESProvider;
                ICryptoTransform TripleDESDecryptor;
                CryptoStream TripleDESStream;
                MemoryStream outStream;

                TripleDESProvider = new TripleDESCryptoServiceProvider();
                TripleDESDecryptor = TripleDESProvider.CreateDecryptor(_KeyBytes, _IV);
                outStream = new MemoryStream();
                TripleDESStream = new CryptoStream(outStream, TripleDESDecryptor, CryptoStreamMode.Write);
                TripleDESStream.Write(arrInput, 0, arrInput.Length);
                TripleDESStream.FlushFinalBlock();

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
            SHA256Managed sha = new SHA256Managed();
            arrOutput = sha.ComputeHash(arraryInput);
            return arrOutput;
        }

        private bool SetKeys(byte[] arraryHash)
        {
            if (arraryHash.Length < 32)
                throw new ArgumentOutOfRangeException("Encryption Key must be 32 bytes long");
            try
            {
                int i = 0;
                for (i = 0; i <= 7; i += 1)
                    _IV[i] = arraryHash[i];
                for (i = 8; i <= 31; i += 1)
                    _KeyBytes[i - 8] = arraryHash[i];
                return true;
            }
            catch (Exception Ex)
            {
                return false;
            }
        }
    }
}