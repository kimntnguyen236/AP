using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As10
{
    public class EmployeeCatalog
    {
        List<Engineer> eList = new List<Engineer>();

        public Engineer Add
        {
            set
            {
                eList.Add(value);
            }
        }

        public void DisplayAll()
        {
            if (eList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            Console.WriteLine("Danh sach ky su: ");
            eList.ForEach(item => Console.WriteLine(item));
        }

        public IEnumerable<Engineer> GetSenior()
        {
            if (eList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                yield break;
            }

            var x500 = eList.FindAll(ks => ks.CalcSalary() >= 500).ToList();
            if (x500.Count ==0)
            {
                Console.WriteLine("Khong tim thay ky su luong > 500");
                yield break;
            }

            foreach (var item in x500)
            {
                yield return item;
            }
        }
    }
}
