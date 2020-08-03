using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello, kitty !";
            Console.WriteLine("Plain Text : {0}", s);
            DemoDES o1 = new DemoDES();
            o1.TestDES(s);


            DemoAES o2 = new DemoAES();
            o2.TestAES(s);

            DemoRSA o3 = new DemoRSA();
            o3.TestRSA(s);

            Console.ReadKey();
        }
    }
}
