using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.menu();

            Console.ReadKey();


        }
        void menu()
        {
            ATMaccount atm = new ATMaccount();
            int amt = 0;
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Menu");
                Console.WriteLine("1.Rut tien");
                Console.WriteLine("2.Nap tien");
                Console.WriteLine("3.Xem so du");
                Console.WriteLine("4.Thoat");

                Console.WriteLine("Nhap chuc nang 1-4: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        Console.WriteLine("Rut tien: ");
                        amt = int.Parse(Console.ReadLine().Trim());
                        atm.pWithdraw = amt;
                        Console.WriteLine("Giao dich thanh cong: ");
                        break;
                    case "2":
                        Console.WriteLine("Nhap so tien nap : ");
                        amt = int.Parse(Console.ReadLine().Trim());
                        atm.pDeposit = amt;
                        Console.WriteLine("Giao dich thanh cong: ");
                        break;
                    case "3":
                        Console.WriteLine("So du: {0} ", atm);
                        break;
                }
                Console.WriteLine("\n Bam 1 phim de tiep tuc chuong tirnh");
                Console.ReadKey();
            }
        }
    }
}

