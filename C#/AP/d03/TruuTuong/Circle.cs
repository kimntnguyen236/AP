using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03.TruuTuong
{
    class Circle : Shape
    {
        public double radius;
        public override double Area()
        {
            return (PI * radius * radius);
        }

        public override void Input()
        {
            Console.Write("Nhap ban kinh: ");
            radius = Convert.ToDouble(Console.ReadLine().Trim());
        }

        public override double Perimeter()
        {
            return (PI * radius * 2);
        }
    }
}
