using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace d06_AdvMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" **** Anonymous Method **** ");
            DemoAnoMethod d1 = new DemoAnoMethod();
            d1.test();


            Console.WriteLine(" **** Extension Method **** ");
            Console.Write("Nhap ho ten cua ban: ");
            string hoten = Console.ReadLine().Trim();
            Console.Write("Nhap chuoi ky tu bat ky: ");
            string m = Console.ReadLine().Trim();
            if (hoten.ContainsIgnoreCase(m))
            {
                Console.WriteLine($"[{m}] co xuat hien trong [{hoten}]");
            }
            else
            {
                Console.WriteLine($">>> Khong tim thay !!! [{m}] khong xuat hien trong [{hoten}]");
            }


            Console.ReadKey(true);
        }
    }
}
