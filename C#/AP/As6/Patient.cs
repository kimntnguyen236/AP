using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As6
{
    public class Patient
    {
        private string id, name, contact, gender;
        private int yob;
        private readonly int age;
        public int CurrentYear = DateTime.Now.Year;

        // pID: has format Pxxxxx , x: digits
        // property cho id
        public string pID
        {
            get
            {
                return id;
            }
            set
            {
                if (Regex.IsMatch(value, "^P\\d{5}$"))
                {
                    id = value;
                }
                else
                {
                    throw new Exception("ID khong hop le! (Pxxxxx, x la so)");
                }
            }
        } // ket thuc property cho id

        // pName at least 2 characters but not excess 30.
        // property cho name
        public string pName
        {
            get
            {
                return name;
            }
            set
            {
                if (Regex.IsMatch(value,"^[a-zA-Z ]{2,30}$"))
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Name khong hop le. ([2-30] ky tu)");
                }
            }
        } // ket thuc property cho name


        // pGender just accept male or female
        // property cho gender
        public string pGender
        {
            get
            {
                return gender;
            }
            set
            {
                if (value == "Female" || value == "female" ||  value == "male" || value == "Male")
                {
                    gender = value;
                }
                else
                {
                    throw new Exception("Chi nhan gia tri [male] hay [female]");
                }
            }
        } // ket thuc property cho gender

        // pYOB (write only): from 1900 to now
        // property cho yob
        public int pYOB
        {
            get
            {
                return yob;
            }
            set
            {
                if (value > 1900 && value <= CurrentYear)
                {
                    yob = value;
                }
                else
                {
                    throw new Exception("Nam sinh khong hop le. (1900 - nam nay)");
                }
            }
        } // ket thuc property cho yob

        // pContact doesn’t accept an empty string
        // property cho contact
        public string pContact
        {
            get
            {
                return contact;
            }
            set
            {
                if(value != null && Regex.IsMatch(value, "^[a-zA-Z0-9 ]{1,}$"))
                {
                    contact = value;
                }
                else
                {
                    throw new Exception("Contact khong hop le. (Khong nhan chuoi rong)");
                }
            }
        } // ket thuc property cho contact

        // pAge (read only): return the patient’s age
        // property cho age
        public int pAge
        {
            get
            {
                return age;
            }
            set
            {
                value = CurrentYear - yob;
            }
        } // ket thuc property cho age

        public void Accept()
        {
            Console.Write("Nhap id: ");
            id = Console.ReadLine().Trim();
            Console.Write("Nhap name: ");
            name = Console.ReadLine();
            Console.Write("Nhap gioi tinh [male/female]: ");
            gender = Console.ReadLine().Trim();
            Console.Write("Nhap nam sinh: ");
            yob = int.Parse(Console.ReadLine().Trim());
            Console.Write("Nhap contact: ");
            contact = Console.ReadLine();
        }

        public override string ToString()
        {
            return string.Format($"ID: {id}\n" +
                $"Name: {name}\n" +
                $"Gender: {gender}\n" +
                $"YOB: {yob} - Age: {age} \n" +
                $"Contact: {contact} \n");
        }

        public void PrintInfo()
        {

        }
    }
}
