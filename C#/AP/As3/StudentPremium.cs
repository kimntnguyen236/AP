using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As3
{
    public class StudentPremium : Student
    {
        public int markofObj;
        public int markofPrac;

        public override void Accept()
        {
            base.Accept();
            Console.Write("Nhap diem ly thuyet: ");
            markofObj = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap diem thuc hanh: ");
            markofPrac = int.Parse(Console.ReadLine().Trim());
        }
        public override void Print()
        {
            int avgMark = (markofPrac + markofObj) / 2;
            string.Format($"\n Sinh vien: \n" +
                $"ID: {ID} \n" +
                $"Full name: {Fullname} \n" +
                $"Date of Birth: {DOB} \n" +
                $"Average mark: {avgMark}");
        }
    }
}
