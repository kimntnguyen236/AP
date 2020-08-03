using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Computer c = new Computer();
            c.Input();

            Console.WriteLine("\nThong tin may tinh: {0}", c);

            Laptop lap = new Laptop();
            lap.Input();
            Console.WriteLine("\nThong tin Laptop: {0}", lap);

            Console.ReadKey();
            */

            ComputerArrayList ca = new ComputerArrayList();
            ca.Menu();
        }
    }
}

