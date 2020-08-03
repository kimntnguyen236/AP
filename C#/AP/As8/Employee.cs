using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As8
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Loi sai nhap lieu");
        }
        public MyException(string s) : base(s)
        {

        }
    }
    // 1. Định nghĩa delegate - co tham so la chuoi
        public delegate void DValid(string str);
    public class Employee
    {
        // 2. Dinh nghia event - kiem tra du lieu nhap
        public event DValid EValidation;

        // 3. Dinh nghia ham xu ly event [EValidation]
        public void Rose(string thongbao)
        {
            throw new MyException(thongbao);
        }
        // 4. Khoi tao event va dang ky ham xu ly event - trong ham dung
        public Employee()
        {
            EValidation = new DValid(Rose);
        }

        private string ID, Fullname;
        private int BaseSalary, WorkedDays;

        public string pID
        {
            get
            {
                return ID;
            }
            set
            {
                if (Regex.IsMatch(value,"^E\\d{4}$"))
                {
                    ID = value;
                }
                else
                {
                    // 5. Raise event
                    EValidation("Exxxx, x: ky so");
                }
            }
        }

        public string pName
        {
            get
            {
                return Fullname;
            }
            set
            {
                if (value.Length >0)
                {
                    Fullname = value;
                }
                else
                {
                    // 5. Raise event
                    EValidation("Not null");
                }
            }
        }

        public int pSalary
        {
            get
            {
                return BaseSalary;
            }
            set
            {
                if (value > 100 && value < 5000)
                {
                    BaseSalary = value;
                }
                else
                {
                    // 5. Raise event
                    EValidation("> 100 && < 5000");
                }
            }
        }

        public int pDays
        {
            get
            {
                return WorkedDays;
            }
            set
            {
                if (value > 0 && value <= 31)
                {
                    WorkedDays = value;
                }
                else
                {
                    // 5. Raise event
                    EValidation("> 0 && <= 31");
                }
            }
        }

        //public abstract void Display();

        public void Input()
        {
            Console.WriteLine("Enter the information");
            while (true)
            {
                try
                {
                    Console.Write("Enter your ID: ");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your full name: ");
                    pName = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your salary: ");
                    pSalary = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Enter your workeddays: ");
                    pDays = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
        }

        public override string ToString()
        {
            return string.Format($"ID: {pID} \n" +
                $"Fullname: {pName} \n" +
                $"BaseSalary: {pSalary} \n" +
                $"WorkedDays: {pDays}");
        }

        public void Validate(string s)
        {

        }

    }
}
