using System;
using System.IO;
using System.Security.Cryptography;

namespace Lab07V2_Herasymchuk
{
    class TripleDESSample
    {

        public static byte[] Encrypt(string plainText, byte[] Key, byte[] IV)
        {
            byte[] encrypted;
            // Create a new TripleDESCryptoServiceProvider.  
            using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
            {
                // Create encryptor  
                ICryptoTransform encryptor = tdes.CreateEncryptor(Key, IV);
                // Create MemoryStream  
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption  
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream  
                    // to encrypt  
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream  
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }
            // Return encrypted data  
            return encrypted;
        }
        public static string Decrypt(byte[] cipherText, byte[] Key, byte[] IV)
        {
            string plaintext = null;
            // Create TripleDESCryptoServiceProvider  
            using (TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider())
            {
                // Create a decryptor  
                ICryptoTransform decryptor = tdes.CreateDecryptor(Key, IV);
                // Create the streams used for decryption.  
                using (MemoryStream ms = new MemoryStream(cipherText))
                {
                    // Create crypto stream  
                    using (CryptoStream cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    {
                        // Read crypto stream  
                        using (StreamReader reader = new StreamReader(cs))
                            plaintext = reader.ReadToEnd();
                    }
                }
            }
            return plaintext;
        }
    }
}