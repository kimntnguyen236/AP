using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ThienKim_Student1218312
{
    public class Book : Library
    {
        public override void bookInfo()
        {
            throw new NotImplementedException();
        }
        public string title;
        public double price;
        public bool isSale;

        public string pTitle
        {
            get
            {
                return title;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z0-9 ]{1,}$"))
                {
                    title = value;
                }
                else
                {
                    throw new Exception("Title chi nhan chu, so va khoang trang");
                }
            }
        }
        public double pPrice
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Price > 0");
                }
            }
        }
        public string pSale
        {
            set
            {
                if (Regex.IsMatch(value, "yes", RegexOptions.IgnoreCase))
                {
                    isSale = true;
                }
                else if (Regex.IsMatch(value, "no", RegexOptions.IgnoreCase))
                {
                    isSale = false;
                }
                else
                {
                    throw new Exception("Nhap khong hop le [yes/no]");
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Detailed Information: ");
            Console.WriteLine($"Title: {pTitle}");
            Console.WriteLine($"Price: {pPrice}");
            Console.WriteLine($"Sale: {isSale}");
        }
        public override string ToString()
        {
            return string.Format($"Title: {pTitle} \n" +
                $"Price: {pPrice} \n" +
                $"Sale: {isSale}");
        }
    }
}
