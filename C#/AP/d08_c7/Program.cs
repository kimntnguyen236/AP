using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d08_c7
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoREF demo1 = new DemoREF();
            DemoOUT demo2 = new DemoOUT();
            DemoTuples demo3 = new DemoTuples();

            // demo1.Test();
            //demo2.Test();
            demo3.Test();

            Console.ReadKey(true);
        }
    }
}
