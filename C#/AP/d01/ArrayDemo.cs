using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d01
{
    public class ArrayDemo
    {
        public void arrayInt()
        {
            // khai báo mảng 1 chiều chứa các số nguyên
            int[] a = { 10, 20, 5, 6, 100, 300 };
            Console.WriteLine("Danh sach cac so nguyen: ");
            for(int i=0; i < a.GetLength(0); i++)
            {
                Console.Write("{0,8}", a[i]);
            }
            Console.ReadKey();
        }

        public void arrayString()
        {
            // khai bao mang chua ten cac sinh vien
            string[] ds = new string[5];

            // nhap ten 5 sv
            for(int i =0; i<ds.Length; i++)
            {
                Console.Write("Nhap sinh vien thu {0}: ",i+1);
                ds[i] = Console.ReadLine();
            }

            // in ds sinh vien
            Console.Write("\n Danh sach sinh vien \n1");
            foreach(var item in ds)
            {
                Console.WriteLine("\t {0}", item);
            }
            Console.ReadKey();
        }
    }
}
