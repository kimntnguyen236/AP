using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d08_c7
{
    public class DemoTuples
    {
        public void Test()
        {
            string name = "Thien Kim";
            int yob = 2001;

            var SinhVien = (HoTen: name, NamSinh: yob);
            Console.WriteLine("Thong tin sinh vien: ");
            Console.WriteLine($"Ho ten: {SinhVien.HoTen}");
            //int age = DateTime.Now.Year - yob;
            //Console.WriteLine($"Tuoi: {age}");
            Console.WriteLine($"Tuoi : "+(DateTime.Now.Year - SinhVien.NamSinh));
        }
    }
}
