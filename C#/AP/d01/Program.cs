using System;

namespace d01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, WORLD !");

            ArrayDemo ad = new ArrayDemo();
            ad.arrayInt();//dừng màn hình lại để xem thông tin hàm writeline

            Console.Clear();

            ad.arrayString();
            Console.ReadKey();
        }
    }
}
