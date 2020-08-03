using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace d07_Adv
{
    class DemoLambda
    {
        // dinh nghia 1 delegate co 1 tham so kieu int va gia tri tra ve kieu long
        public delegate long DelegateMath(int n);
        public void Test()
        {
            Console.Clear();
            Console.WriteLine("Demo Lambda");

            Console.Write(">>>>>Nhap vao 1 so nguyen >0: ");
            int n = int.Parse(Console.ReadLine().Trim());
            // khai bao bien delegate [ma] - ket hop bieu thuc lambda tinh giai thua
            DelegateMath ma = (int x) =>
            {
                long r = 1;
                for (int i = 2; i <= x; i++)
                {
                    r *= i;
                }
                return r;
            };

            long kq = ma(n);
            Console.WriteLine($"{n}! = {kq} ");

            // khai bao bien delegate [ma] - ket hop bieu thuc lambda tinh binh phuong
            ma = x => x * x;
            kq = ma(n);
            Console.WriteLine($"Binh Phuong cua {n} = {kq} ");


            Console.Write("Nhap chuoi ky tu thu 1: ");
            string s1 = Console.ReadLine().Trim();
            Console.Write("Nhap chuoi ky tu thu 2: ");
            string s2 = Console.ReadLine().Trim();
            // kiem tra s1 co chua s2 khong? thong qua delegate - ket hop bieu thuc lambda
            Func<string, string, bool> f2 = (x1, x2) => Regex.IsMatch(s1, s2, RegexOptions.IgnoreCase);
            if (f2(s1, s2))
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
