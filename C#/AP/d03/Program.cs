using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using d03.KeThua;
using d03.TruuTuong;

namespace d03
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.demoTruuTuong();

            Console.ReadKey();
        }

        void demoKeThua()
        {
            Console.WriteLine("Demo Inheritance");
            d03.KeThua.Monitor m1 = new KeThua.Monitor();
            Console.WriteLine("Monitor 1: {0} ", m1);

            Monitor m2 = new Monitor();
            m2.Input();
            Console.WriteLine("Monitor 2: {0} ", m2);

            Console.ReadKey();
        }

        void demoTruuTuong()
        {
            Console.WriteLine("\n Demo Abstract class: ");
            Shape s1 = new Circle();
            Shape s2 = new Rectangle();
            s1.Input();
            s2.Input();

            string s = "";
            s = s1 is Circle?"HinhTron: ": "HinhChuNhat: ";
            Console.WriteLine("{0}: {1}\n", s,s1);

            s = s2 is Circle ? "HinhTron: " : "HinhChuNhat: ";
            Console.WriteLine("{0}: {1}\n", s,s2);
        }
    }
}
