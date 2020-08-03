using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d08_c7
{
    public class DemoREF
    {
        public ref string getName(int i, string[] names)
        {
            if (i >= 0 && names.Length > 0)
            {
                return ref names[i];
            }
            throw new IndexOutOfRangeException("Loi sai truy xuat !!!");
        }

        public void Test()
        {
            string[] ds = { "Thien Kim", "Doan Dung", "Minh Tam", "Phuong Huyen", "Buu Buu", "Tran Hoa", "Thanh An", "Thanh Tan", "Ba Hung", "Hoang Trung", "Minh Hieu" };
            Console.WriteLine(" Danh sach sinh vien: ");
            ds.ToList().ForEach(item => Console.Write($" {item},"));
            ref string tenSV = ref getName(3, ds); // lay ten cua sinh vien o vi tri index = 3

            Console.WriteLine($"\n \n Ten sinh vien (old name): {tenSV}");

            tenSV = "Ngoc Huyen";
            Console.WriteLine($"\n Ten sinh vien (new name): {tenSV}");

            Console.WriteLine("\n Danh sach sinh vien moi: ");
            ds.ToList().ForEach(item => Console.Write($"{item}, "));
        }
    }

    public class DemoOUT
    {
        public void getFullName(out string LastName, out string FirstName)
        {
            Console.Write("Nhap ho sinh vien: ");
            LastName = Console.ReadLine();
            Console.Write("Nhap ten sinh vien: ");
            FirstName = Console.ReadLine();
        }

        public void Test()
        {
            string ho, ten;
            getFullName(out ho,out ten);
            Console.WriteLine($"Ho va ten sinh vien: {ho} {ten}");
        }
    }
}
