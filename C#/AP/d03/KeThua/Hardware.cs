using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03.KeThua
{
    public class Hardware
    {
        public string id, name;
        public int price;

        // ham dung khong tham so
        public Hardware()
        {
            id = "P01";
            name = "Linh kien";
            price = 100;
        }

        // neu viet ham dung cos tham so phai viet ham dung k tham so

        public virtual void Input()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap name: ");
            name = Console.ReadLine().Trim();
            Console.Write("Nhap price: ");
            price = Convert.ToInt32(Console.ReadLine().Trim());
        }
    }
}
