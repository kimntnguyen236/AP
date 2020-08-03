using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Demo
{
    public class DemoRSA
    {
        public void TestRSA(string text)
        {
            Console.WriteLine("\n\tRSA : ");
            using (RSACryptoServiceProvider rp = new RSACryptoServiceProvider())
            {
                //fasle : w/t private parameter (only public key information)
                //chuyển đổi mã hóa bất đối xứng tối ưu(Optimal Asymmetric Encryption Padding) được khuyến cáo sử dụng
                byte[] encryptedText = EncryptText(text, rp.ExportParameters(false), true);
                Console.WriteLine("\nEncrypted Text : {0}", Encoding.UTF8.GetString(encryptedText));


                byte[] orgText = DecryptText(encryptedText, rp.ExportParameters(true), true);
                Console.WriteLine("Decryted text: {0}", Encoding.UTF8.GetString(orgText));
            }
        }

        private byte[] DecryptText(byte[] encryptedText, RSAParameters parameters, bool oAEP)
        {
            RSACryptoServiceProvider rp = new RSACryptoServiceProvider();
            rp.ImportParameters(parameters);
            return rp.Decrypt(encryptedText, oAEP);
        }

        private byte[] EncryptText(string text, RSAParameters parameters, bool oAEP)
        {
            RSACryptoServiceProvider rp = new RSACryptoServiceProvider();
            rp.ImportParameters(parameters);

            //a boolean flag specifying OAEP(Optimal Asymmetric Encryption Padding).
            return rp.Encrypt(Encoding.UTF8.GetBytes(text), oAEP);
        }
    }
}
