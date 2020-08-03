using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d06_generics
{
    //dinh nghia class generics Student co 3 tham so kieu T,U,V (type parameters)
    public class Student<T,U,V>
    {
        public T id;
        public string name;
        public U dob;
        public V gender;

        public override string ToString()
        {
            return string.Format($"{id}, {name},{dob},{gender}");
        }
    }
}
