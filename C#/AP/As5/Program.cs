using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As5
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
            Console.ReadKey(true);
        }

        void menu()
        {
            ComputerCollection cc = new ComputerCollection();
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1.Them may tinh moi");
                Console.WriteLine("2.In danh sach may tinh");
                Console.WriteLine("3.In danh sach may tinh gia > 1500");
                Console.WriteLine("4.In danh sach may tinh theo ten");
                Console.WriteLine("5.Thoat");

                Console.WriteLine("Nhap chuc nang 1-5: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        cc.Add();
                        break;
                    case "2":
                        cc.DisplayAll();
                        break;
                    case "3":
                        cc.DisplayHighValue();
                        break;
                    case "4":
                        Console.Write("Nhap ten may tinh muon tim: ");
                        cc.Search(Console.ReadLine().Trim());
                        break;
                    case "5":
                        break;
                }
                Console.WriteLine("\n Bam 1 phim de tiep tuc chuong tirnh");
                Console.ReadKey();
            }
        }
    }
}
