using System;

namespace d08_core
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so nguyen duong: ");
            int n = int.Parse(Console.ReadLine().Trim());
            GiaiThua(n);

            Console.ReadKey(true);
        }

        static void GiaiThua(int n)
        {
            long kq = 1;
            for (int i = 1; i <= n; i++)
            {
                kq = kq * i;
            }

            Console.WriteLine($"{n} giai thua = {kq}");
        }
    }
}
