using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Loi sai nhap lieu !");
        }
        public MyException(string s) : base(s)
        {

        }
    }
    public class Computer
    {
        private string id, name;
        private int price;

        //Property pID cho id - id co format "C-xxx"
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^C-\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    throw new MyException("ID khong hop le: [C-xxx]");
                }
            }
        } //Ket thuc pID

        //Property pName cho name - khong dc de trong va nhieu nhat 20 ky tu
        public string pName
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Trim().Length > 0 && value.Trim().Length <= 20)
                {
                    name = value.Trim();
                }
                else
                {
                    throw new MyException("Ten khong hop le: khong dc rong va < 20 ky tu !");
                }
            }
        } //Ket thuc pName

        //Property pPrice cho price : [100-100000]
        public int pPrice
        {
            get
            {
                return price;
            }
            set
            {
                if (value >= 100 && value <= 1000000)
                {
                    price = value;
                }
                else
                {
                    throw new MyException("Price khong hop le: [100-1000000]");
                }
            }
        } //Ket thuc pPrice

        public void Input()
        {
            Console.WriteLine("Nhap thong tin Computer");
            //Nhap ID
            while (true)
            {
                try
                {
                    Console.Write("Nhap ID: ");
                    pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            } //Ket thuc ID

            //Nhap Name
            while (true)
            {
                try
                {
                    Console.Write("Nhap Name: ");
                    pName = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            } //Ket thuc Name

            //Nhap Price
            while (true)
            {
                try
                {
                    Console.Write("Nhap Price: ");
                    pPrice = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi: " + e.Message);
                }
            } //Ket thuc Price
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", id, name, price);
        }
    }
}

