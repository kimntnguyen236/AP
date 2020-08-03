using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As3
{
    class Program
    {
        List<StudentPremium> stList = new List<StudentPremium>();
        int max;
        int cntStudent;

        StudentPremium st = new StudentPremium();
        public void Add()
        {
            Console.WriteLine(">>>> Them mot sinh vien moi: ");
            st.Accept();
            stList.Add(st);
            Console.WriteLine("Them mot sinh vien moi thanh cong!");
        }

        public void Display()
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("Danh sach rong!!!");
                return;
            }
            Console.WriteLine(">>>>Danh sach sinh vien: ");
            //foreach (var item in stList)
            //{
            //    Console.WriteLine(item);
            //}
        }

        public void Display(string ID) { }
    public void DisplayMark(int avg) { }
void menu()
        {
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Them sinh vien moi");
                Console.WriteLine("2. In danh sach sinh vien");
                Console.WriteLine("3. In danh sach sinh vien theo ID");
                Console.WriteLine("4. In danh sach sinh vien theo diem trung binh");
                Console.WriteLine("5. Thoat");
                Console.Write("Nhap ma so chuc nang [1-5]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        Add();
                        break;
                    case "2":
                        Display();
                        break;
                    case "3":
                        Console.Write("Nhap ID sinh vien muon tim: ");
                        Display(Console.ReadLine().Trim());
                        break;
                    case "4":
                        Console.Write("Nhap diem trung binh muon tim: ");
                        DisplayMark(int.Parse(Console.ReadLine().Trim()));
                        break;
                    case "5":
                        break;
                    default:
                        break;
                }

                Console.Write("\n Nhan phim bat ky de tiep tuc chuong trinh ...");
                Console.ReadKey(true);
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.menu();
        }
    }
}
