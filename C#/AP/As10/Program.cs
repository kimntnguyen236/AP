using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As10
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Menu();
        }

        void Menu()
        {
            string op = "";
            EmployeeCatalog ec = new EmployeeCatalog();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Them ky su");
                Console.WriteLine("2. In ds ks");
                Console.WriteLine("3. In ds ks luong > 500");
                Console.WriteLine("4. Thoat");
                Console.Write("Nhap ma so chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Engineer kysu = new Engineer();
                        kysu.Input();
                        ec.Add = kysu;
                        break;
                    case "2":
                        ec.DisplayAll();
                        break;
                    case "3":
                        foreach (var item in ec.GetSenior())
                        {
                            //Console.WriteLine(item);
                            item.Display();
                        }
                        break;
                    case "4": return;
                    default:
                        break;
                }
                Console.WriteLine("\n Bam 1 phim bat ky de tiep tuc ...");
                Console.ReadKey(true);
            }
        }
    }
}
