using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As2
{
    public class Employee
    {
        public string id, name, position;
        public int baseSalary;

        public Employee()
        {
        }

        public Employee(string id, string name, string position, int baseSalary)
        {
            this.id = id;
            this.name = name;
            this.position = position;
            this.baseSalary = baseSalary;
        }

        // Property cho field id
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (Regex.IsMatch(value.Trim(),"^[a-zA-Z0-9]{1,10}$"))
                {
                    id = value.Trim();
                }
                else
                {
                    throw new Exception("ID khong hop le. (Khong chua ky tu dac biet va khoang trang)");
                }
            }
        } // ket thuc property cho id

        // property cho name 
        public string pName
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-z ]{1,30}$", RegexOptions.IgnoreCase))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name khong hop le. (1-30 ki tu chu hoac khoang trang)");
                }
            }
        } // ket thuc property cho name

        // property cho position
        public string pPosition
        {
            get
            {
                return position;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-z ]{1,}$",RegexOptions.IgnoreCase))
                {
                    position = value;
                }
                else
                {
                    throw new Exception("Position khong hop le.");
                }
            }
        } // ket thuc property cho position

        // property cho baseSalary
        public int pBaseSalary
        {
            get
            {
                return baseSalary;
            }
            set
            {
                if(value >= 100 && value <= 2000)
                {
                    baseSalary = value;
                }
                else
                {
                    throw new Exception("baseSalary khong hop le. [100-2000]USD");
                }
            }
        } // ket thuc property cho baseSalary

        // public void input()
        //{
        //    Console.WriteLine("Nhap thong tin nhan vien:");

        //    // nhap id nhan vien
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Nhap id cua nhan vien: ");
        //            pID = Console.ReadLine().Trim();
        //            break;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Exception: " + e.Message);
        //        }
        //    } // ket thuc nhap id

        //    // nhap name
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Nhap ten: ");
        //            pName = Console.ReadLine();
        //            break;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Exception: "+e.Message);
        //        }
        //    } // ket thuc nhap name

        //    // nhap position
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Nhap chuc vu: ");
        //            pPosition = Console.ReadLine();
        //            break;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Exception: "+e.Message);
        //        }
        //    } // ket thuc nhap position

        //    // nhap salary
        //    while (true)
        //    {
        //        try
        //        {
        //            Console.Write("Nhap luong: ");
        //            pBaseSalary = int.Parse(Console.ReadLine().Trim());
        //            break;
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Exception: "+e.Message);
        //        }
        //    }
        //}

        public override string ToString()
        {
            return string.Format($"ID: {id} \n" +
                $"Name: {name}\n" +
                $"Position: {position}\n" +
                $"Salary: {baseSalary} USD \n");
        }

    }
}
