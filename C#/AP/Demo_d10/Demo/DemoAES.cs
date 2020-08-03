using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Demo
{
    public class DemoAES
    {
        public void TestAES(string text)
        {
            Console.WriteLine("\n\t AES : ");
            using (AesCryptoServiceProvider alg = new AesCryptoServiceProvider())
            {
                //key = 32 bytes, IV = 16 bytes
                //Console.WriteLine("Key = {0} , size ={1}", Encoding.UTF8.GetString(alg.Key), alg.Key.Length);
                //Console.WriteLine("IV = {0} , size ={1}", Encoding.UTF8.GetString(alg.IV), alg.IV.Length);


                byte[] encryptedText = EncryptText(text, alg.Key, alg.IV);
                Console.WriteLine("\nEncrypted Text : {0}", Encoding.UTF8.GetString(encryptedText));

                string orgText = DecryptText(encryptedText, alg.Key, alg.IV);
                Console.WriteLine("Decryted text: {0}", orgText);

            }
        }

        private string DecryptText(byte[] encryptedText, byte[] key, byte[] iV)
        {
            string text = "";

            using(AesCryptoServiceProvider ap = new AesCryptoServiceProvider())
            {
                ICryptoTransform transform = ap.CreateDecryptor(key, iV);

                using(MemoryStream memory = new MemoryStream(encryptedText))
                {
                    using(CryptoStream crypto = new CryptoStream(memory, transform, CryptoStreamMode.Read))
                    {
                        using(StreamReader reader = new StreamReader(crypto))
                        {
                            text = reader.ReadToEnd();
                        }
                    }
                }
            }
            return text;
        }

        private byte[] EncryptText(string text, byte[] key, byte[] iV)
        {
            byte[] encText;
            using(AesCryptoServiceProvider ap = new AesCryptoServiceProvider())
            {
                ICryptoTransform transform = ap.CreateEncryptor(key, iV);
                using(MemoryStream memory = new MemoryStream())
                {
                    using(CryptoStream crypto = new CryptoStream(memory, transform, CryptoStreamMode.Write))
                    {
                        using(StreamWriter writer = new StreamWriter(crypto))
                        {
                            writer.Write(text);
                        }
                    }
                    encText = memory.ToArray();
                }

            }

            return encText;
        }
    }
}
