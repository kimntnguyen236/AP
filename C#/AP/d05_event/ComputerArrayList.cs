using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    //Quan ly danh sach cac may tinh trong ArrayList
    public class ComputerArrayList
    {
        System.Collections.ArrayList ds = new System.Collections.ArrayList();

        //Ham them 1 computer
        public void Add()
        {
            Computer c = new Computer();
            c.Input();
            ds.Add(c);
        }

        //Ham in danh sach cac may tinh
        public void Display()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("HT chua co du lieu !!!");
                return;
            }

            Console.WriteLine("Danh sach cac may tinh: ");
            foreach (var item in ds)
            {
                Console.WriteLine(item);
            }
        }

        //Ham in danh sach cac may tinh co don gia > 100
        public void Display100()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("HT chua co du lieu !!!");
                return;
            }

            int count100 = 0;

            Console.WriteLine("Danh sach cac may tinh co don gia > 100: ");
            foreach (var item in ds)
            {
                Computer c = (Computer)item;
                if (c.pPrice > 100)
                {
                    Console.WriteLine(item);
                    count100++;
                }
            } //Ket thuc for

            if (count100 == 0)
            {
                Console.WriteLine("KHONG TIM THAY MAY TINH NAO CO DON GIA > 100 !!!");
            }
        }

        public void Menu()
        {
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("MENU");
                Console.WriteLine("1. Them computer");
                Console.WriteLine("2. In danh sach");
                Console.WriteLine("3. In computer co don gia > 100");
                Console.WriteLine("4. Thoat");
                Console.Write("Vui long nhap chuc nang [1-4]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        Add(); break;
                    case "2":
                        Display(); break;
                    case "3":
                        Display100(); break;
                    case "4":
                        return;
                }

                Console.Write("Bam phim bat ky de tie tuc chuong trinh...");
                Console.ReadKey();
            }
        }
    }
}
