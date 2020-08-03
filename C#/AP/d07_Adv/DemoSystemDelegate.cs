using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace d07_Adv
{
    public class DemoSystemDelegate
    {
        // ham tinh giai thua
        public long Factorial(int n)
        {
            long kq = 1;
            for (int i = 2; i <= n; i++)
            {
                kq *= i;
            }
            return kq;
        }

        // ham tinh binh phuong cua mot so nguyen
        public long square(int n)
        {
            return n*n;
        }

        // ham kiem tra chuoi s2 co xuat hien trong s1 khong? (Khong phan biet chu thuong - chu hoa)
        public bool Contains(string s1, string s2)
        {
            return Regex.IsMatch(s1, s2, RegexOptions.IgnoreCase);
        }

        public void Test()
        {
            Console.Clear();
            Console.WriteLine("Demo System-defined Generic Delegate");

            Console.Write(">>>>>Nhap vao 1 so nguyen >0: ");
            int n = int.Parse(Console.ReadLine().Trim());

            // tinh giai thua va binh phuong cua n thong qua delegate
            Func<int, long> ma = Factorial;
            long kq = ma(n);
            Console.WriteLine($"{n}! = {kq} ");

            ma = square;
            kq = ma(n);
            Console.WriteLine($"Binh Phuong cua {n} = {kq} ");

            Console.Write("Nhap chuoi ky tu thu 1: ");
            string s1 = Console.ReadLine().Trim();
            Console.Write("Nhap chuoi ky tu thu 2: ");
            string s2 = Console.ReadLine().Trim();
            // kiem tra s1 co chua s2 khong? thong qua delegate
            Func<string, string, bool> f2 = Contains;
            if (f2(s1,s2))
            {
                Console.WriteLine($"[{s1}] co chua [{s2}]!");
            }
            else
            {
                Console.WriteLine(">>>> Khong tim thay");
            }

            Console.ReadKey(true);
        }
    }
}
