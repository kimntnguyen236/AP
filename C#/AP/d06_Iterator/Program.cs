using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace d06_Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            // p.TestEmployeeList();
            p.TestEmployeeIterator();
        }

        void TestEmployeeList()
        {
            string op = "";
            EmployeeList elist = new EmployeeList();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" **MENU** ");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. In danh sach");
                Console.WriteLine("3. Tim va in ds nv theo ten");
                Console.WriteLine("4. Thoat");

                Console.Write("Nhap ma so chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        elist.Add();
                        break;
                    case "2":
                        elist.Display();
                        break;
                    case "3":
                        Console.Write("Nhap ten nv muon tim: ");
                        elist.Display(Console.ReadLine().Trim());
                        break;
                    case "4":
                        break;
                }

                Console.Write("\nBam phim bat ky de tieo tuc chuong trinh ....");
                Console.ReadKey(true);
            }
        }

        void TestEmployeeIterator()
        {
            string op = "";
            EmployeeIterator elist = new EmployeeIterator();

            while (true)
            {
                Console.Clear();
                Console.WriteLine(" **MENU (ITERATOR)** ");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. In danh sach");
                Console.WriteLine("3. Tim va in ds nv theo ten");
                Console.WriteLine("4. Thoat");

                Console.Write("Nhap ma so chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                case "1":
                    elist.Add();
                    break;
                case "2":
                    foreach(var item in elist)
                    {
                        Console.WriteLine(item);
                    }
                    break;
                case "3":
                    Console.Write("Nhap ten nv muon tim: ");
                    string ten = Console.ReadLine().Trim();
                    int cntTen = 0;
                    foreach(var item in elist)
                    {
                        if (Regex.IsMatch(item.pNAME, ten, RegexOptions.IgnoreCase))
                        {
                            Console.WriteLine(item);
                            cntTen++;
                        }
                    }
                    if (cntTen == 0)
                    {
                        Console.WriteLine("Khong tim thay !!!");
                    }
                    break;
                case "4":
                    break;
                }

                Console.Write("\nBam phim bat ky de tieo tuc chuong trinh ....");
                Console.ReadKey(true);
            }
        }
    }
}


