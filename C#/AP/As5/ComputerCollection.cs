using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace As5
{
    public class ComputerCollection
    {
        SortedList<string, Computer> cList = new SortedList<string, Computer>();

        public void Add()
        {
            Computer c = new Computer();

            //Nhap ID 
            while (true)
            {
                try
                {
                    Console.Write("Nhap ID : ");
                    c.pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc nhap pID

            //Nhap Name 
            while (true)
            {
                try
                {
                    Console.Write("Nhap Name : ");
                    c.pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc nhap pName

            //Nhap UnitPrice 
            while (true)
            {
                try
                {
                    Console.Write("Nhap UnitPrice : ");
                    c.pUnitPrice = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }//Ket thuc nhap pUnitPrice

            cList.Add(c.pID, c);
            Console.WriteLine("Them may tinh moi thanh cong !");
        } // Ket thuc Add()

        public void DisplayAll()
        {
            if (cList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            Console.WriteLine("Danh sach may tinh ");
            foreach (var item in cList.Values)
            {
                Console.WriteLine(item);
            }
        }

        public void DisplayHighValue()
        {
            
        }

        public void Search(string name)
        {
            if (cList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            int cntTen = 0;
            Console.WriteLine("Danh sach nhan vien ");
            foreach (var item in cList.Values)
            {
                if (Regex.IsMatch(item.pName, name, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine(item);
                    cntTen++;
                }

            }//Ket thuc foreach

            if (cntTen == 0)
            {
                Console.WriteLine("Khong tim thay !!");
            }
        }
    }
}
