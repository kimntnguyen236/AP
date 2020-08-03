using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d03.TruuTuong
{
    public abstract class Shape
    {
        public double PI = 3.1415;

        public abstract double Area();
        public abstract double Perimeter();
        public abstract void Input();

        public override string ToString()
        {
            return string.Format("Dien tich = {0,8:0.00}, Chu vi = {1,8:0.00}",Area(), Perimeter());
        }
    }
}
