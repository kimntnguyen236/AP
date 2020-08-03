using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As10
{
    public class Engineer : Employee
    {
        public int Allowance;

        public override int CalcSalary()
        {
            return (pSalary * pDays) / 24 + Allowance;
        }

        public override void Input()
        {
            base.Input();
            while (true)
            {
                try
                {
                    Console.Write("Nhap Allowance: ");
                    Allowance = int.Parse(Console.ReadLine());
                    if (Allowance >= 0)
                    {
                        break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            }
        }

        public override void Display()
        {
            Console.WriteLine("Bang luong chi tiet");
            Console.WriteLine($"ID: {pID}");
            Console.WriteLine($"Ho ten: {Fullname}");
            Console.WriteLine($"Luong CB: {pSalary}");
            Console.WriteLine($"Phu cap: {Allowance}");
            Console.WriteLine($"So ngay lam viec: {pDays}");
            Console.WriteLine($">>> Luong : {CalcSalary()}");
        }
    }
}
