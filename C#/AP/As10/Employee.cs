using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace As10
{
    public abstract class Employee
    {
        private string ID;
        private int BaseSalary, WorkedDays;
        public string Fullname;

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
                    throw new Exception("ID khong hop le Exxxx");
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
                if (value>= 100 && value <=5000)
                {
                    BaseSalary = value;
                }
                else
                {
                    throw new Exception("BaseSalary khong hop le [100-5000]");
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
                    throw new Exception("WorkDays khong hop le (0-31]");
                }
            }
        }

        public abstract void Display();
        public abstract int CalcSalary();

        public virtual void Input()
        {
            while (true)
            {
try
            {
                Console.Write("Nhap ID: ");
                pID = Console.ReadLine().Trim();
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine("Loi: "+e.Message);
            }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap Name: ");
                    Fullname = Console.ReadLine().Trim();
                    if (Fullname.Length >0)
                    {
                    break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap luong: ");
                    pSalary = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.Write("Nhap so ngay lam viec: ");
                    pDays = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }
        }

        public override string ToString() => string.Format($"{ID},{Fullname},{BaseSalary},{WorkedDays}");

    }
}
