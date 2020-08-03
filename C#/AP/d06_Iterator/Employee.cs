using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace d06_Iterator
{
    public class Employee
    {
        int salary; 
        string name, id;

        // property cho id - định dạng Exxx+
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^E\\d{3,}$"))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("ID khong hop le! (Exxx+) ");
                }
            }
        }// ket thuc pID

        // property cho name - tu 1 den 30 ki tu chu
        public string pNAME
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value, "^[a-z ]{1,30}$",RegexOptions.IgnoreCase))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name khong hop le! (1-30 ki tu chu hoac khoang trang) ");
                }
            }
        } // ket thuc pNAME

        // property cho salary - [100-10000]
        public int pSALARY
        {
            get
            {
                return salary;
            }
            set
            {
                if(value >=100 && value <= 10000)
                {
                    salary = value;
                }
                else
                {
                    throw new Exception("Salary khong hop le! [100-10000] ");
                }
            }
        } // ket thuc pSALARY

        public override string ToString()
        {
            return string.Format($"{id},{name},{salary}");
        }
    }
}
