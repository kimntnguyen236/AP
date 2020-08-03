using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d05_event
{
    //1. Dinh nghia delegate DValid - co tham so la 1 chuoi 
    public delegate void DValid(string s);

    public class Laptop
    {
        //2. Dinh nghia event - kiem tra du lieu nhap
        public event DValid EValidation;

        //3. Dinh nghia ham xu ly event [EValidation]
        public void Rose(string thongbao)
        {
            throw new MyException(thongbao);
        }

        //4. Khoi tao event va dang ky ham xu ly event - trong ham dung
        public Laptop()
        {
            EValidation = new DValid(Rose);
        }

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
                if (System.Text.RegularExpressions.Regex.IsMatch(value, "^L-\\d{3}$"))
                {
                    id = value;
                }
                else
                {
                    //5. Raise event
                    EValidation("ID khong hop le: [L-xxx]");
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
                    //5. Raise event
                    EValidation("Ten khong hop le: khong dc rong va < 20 ky tu !");
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
                    //5. Raise event
                    EValidation("Price khong hop le: [100-1000000]");
                }
            }
        } //Ket thuc pPrice

        public void Input()
        {
            Console.WriteLine("\nNhap thong tin Laptop");
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

