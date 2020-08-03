using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As3
{
    public abstract class Student
    {
        public string ID;
        public string Fullname;
        public DateTime DOB;
        public bool Gender;

        public abstract void Print();
        public virtual void Accept()
        {
            Console.Write("Nhap id: ");
            ID = Console.ReadLine().Trim();
            Console.Write("Nhap ho ten: ");
            Fullname = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            DOB = DateTime.Parse(Console.ReadLine());
            //while (true)
            //{
            //    try
            //    {
            //if (Regex.IsMatch(ID, "^[a-zA-Z0-9]{1,10}$"))
            //{
            //    break;
            //}
            //else
            //{
            //    Console.WriteLine("ID khong hop le!!!");
            //}
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Loi: " + e.Message);
            //}
            //}
        }
    }
}
