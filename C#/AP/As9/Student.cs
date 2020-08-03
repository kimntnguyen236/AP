using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As9
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Loi sai nhap lieu !");
        }
        public MyException(string s) : base(s)
        {

        }
    }
    // 1. Dinh nghia delegate DMess - co tham so la mot chuoi
    public delegate void DMess(string str);
    public class Student
    {
        // 2. Dinh nghia event - kiem tra du lieu nhap
        public event DMess EMess;

        // 3. Dinh nghia ham xu ly event [EValidation]
        public void ValidProcess(string s)
        {
            throw new MyException(s);
        }

        // 4. Khoi tao event va dang ky ham xu ly event - trong ham dung
        public Student()
        {
            EMess = new DMess(ValidProcess);
        }
        private string ID;
        private int Maths, English;

        public string Fullname;

        public string pID
        {
            get
            {
                return ID;
            }
            set
            {
                if (Regex.IsMatch(value,"^ST-\\d{3,5}$"))
                {
                    ID = value;
                }
                else
                {
                    // 5. Raise event
                    EMess("ST-xxx[xx], x: ky so");
                }
            }
        }

        public int pMaths
        {
            set
            {
                if (value >0 && value <100)
                {
                    Maths = value;
                }
                else
                {
                    EMess("Between 0-100");
                }
            }
        }

        public int pEnglish
        {
            set
            {
                if (value > 0 && value < 100)
                {
                    English = value;
                }
                else
                {
                    EMess("Between 0-100");
                }
            }
        }

        public int pAvg
        {
            get
            {
                return (Maths + English) / 2;
            }
        }

        public void Display()
        {
            Console.WriteLine("Detailed Information: ");
            Console.WriteLine($"ID: {pID}");
            Console.WriteLine($"Fullname: {Fullname}");
            Console.WriteLine($"Maths: {Maths}");
            Console.WriteLine($"English: {English}");
            Console.WriteLine($"Average: {pAvg}");
        }

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
                    Console.Write("Enter your name: ");
                    Fullname = Console.ReadLine();
                    if (Fullname.Length > 0)
                    {
                        break;
                    }
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
                    Console.Write("Enter your Maths score: ");
                    pMaths = int.Parse(Console.ReadLine().Trim());
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
                    Console.Write("Enter your English score: ");
                    pEnglish = int.Parse(Console.ReadLine().Trim());
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
                $"Fullname: {Fullname} \n" +
                $"Score of Maths: {Maths} \n" +
                $"Score of English: {English} \n" +
                $"Avg: {pAvg}");
        }
    }
}
