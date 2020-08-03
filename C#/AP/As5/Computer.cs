using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace As5
{
    public delegate void DValid(string str);
    public class Computer
    {
        private string ID, Name;
        private int UnitPrice;

        // property cho ID
        public string pID
        {
            get
            {
                return ID;
            }
            set
            {
                if (Regex.IsMatch(value.Trim(), "^C\\d{3,5}$"))
                {
                    ID = value;  //Value là dữ liệu gán cho property pID
                }
                else
                {
                    Console.WriteLine("ID khong hop le ! (Cxxx[xx], x: chu so)");
                }
            }
        } // ket thuc property cho ID

        // property cho Name
        public string pName
        {
            get
            {
                return Name;
            }
            set
            {
                if (Regex.IsMatch(value.Trim(), "^[a-zA-Z0-9 ]{3,}$"))
                {
                    Name = value;  //Value là dữ liệu gán cho property pName
                }
                else
                {
                    Console.WriteLine("Name khong hop le ! (Chi nhan chu hoac so hoac khoang trang va >3 ky tu)");
                }
            }
        } // ket thuc property cho Name

        // property cho UnitPrice
        public int pUnitPrice
        {
            get
            {
                return UnitPrice;
            }
            set
            {
                if (value >=100 && value <= 3000)
                {
                    UnitPrice = value;
                }
                else
                {
                    Console.WriteLine("UnitPrice khong hop le ! ([100-3000])");
                }
            }
        } // ket thuc property cho UnitPrice

        public override string ToString()
        {
            return string.Format($"ID: {ID} \n" +
                $"Name: {Name} \n" +
                $"UnitPrice: {UnitPrice}");
        }

        public void Validation(string str)
        {
            throw new Exception("");
        }
    }
}
