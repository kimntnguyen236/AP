using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03.TruuTuong
{
    public class Rectangle : Shape
    {
        public double w, h;
        public override double Area()
        {
            return (w * h);
        }

        public override void Input()
        {
            Console.Write("Nhap chieu dai HCN: ");
            h = Convert.ToDouble(Console.ReadLine().Trim());
            Console.Write("Nhap chieu rong HCN: ");
            w = Double.Parse(Console.ReadLine().Trim());
        }

        public override double Perimeter()
        {
            return (w + h) * 2;
        }
    }
}
