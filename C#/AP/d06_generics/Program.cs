using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generics
{
    class Program
    {
        static void Main(string[] args)
        {
            // demo generic class
            Console.WriteLine("Demo generic class: ");
            Student<string, int, bool> sv1 = new Student<string, int, bool>
            {
                id = "SV001",
                name = "Vo Minh Thu",
                dob = 2002,
                gender = false
            };
            Student<int, DateTime, int> sv2 = new Student<int, DateTime, int>
            {
                id = 100,
                name = "Dinh Hung",
                dob = DateTime.Parse("2001-10-02"),
                gender = 1
            };

            Console.WriteLine($"Sinh vien 1: {sv1}");
            Console.WriteLine($"Sinh vien 2: {sv2}");

            // demo generic delegate
            Console.WriteLine("\n Demo generic method: ");
            DemoGenericDelegate d = new DemoGenericDelegate();
            d.Test();


            Console.ReadKey(true);
        }
    }
}
