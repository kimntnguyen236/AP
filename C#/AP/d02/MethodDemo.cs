using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d02
{
    class MethodDemo
    {
        internal string message = "This is instance message";
        static string message2 = "This is static";
        // phạm vi internal nằm trong 1 solution
          internal void method1(string mess="Hello, CSharp !")
        {
            Console.WriteLine(mess);
        }

        internal static void method2()
        {
            Console.WriteLine("Static Method");
            Console.WriteLine("=========");
            MethodDemo o = new MethodDemo();
            Console.WriteLine("Thong bao 1: {0}", o.message);
            Console.WriteLine("Thong bao 2: {0}", MethodDemo.message2);
        }

        public bool ptb2(int a, int b, int c, double x1, double x2)
        {
            bool CoNghiem = false ;

            double delta = b * b - 4 * a * c;
            if (delta >= 0)
            {

                CoNghiem = true;
                delta = Math.Sqrt(delta);
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
            }
            return CoNghiem;
        }

        public bool ptb2bis(int a, int b, int c,ref double x1, ref double x2)
        {
            bool CoNghiem = false;

            double delta = b * b - 4 * a * c;
            if (delta >= 0)
            {

                CoNghiem = true;
                delta = Math.Sqrt(delta);
                x1 = (-b - delta) / (2 * a);
                x2 = (-b + delta) / (2 * a);
            }
            return CoNghiem;
        }
    }
}
