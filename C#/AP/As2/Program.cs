using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace As2
{
    class Program
    {
        /*max (chứa tổng số nhân viên có thể lưu trữ tối đa), cnt (số lượng nv đang lưu trong hệ thống ), ds (array chứa các đối tượng nhân viên),*/

        // luu danh sach nhan vien vo Sorted List [ds]
        SortedList<string, Employee> ds = new SortedList<string, Employee>();

        // void add(): thêm 1 nhân viên mới vô danh sách ds, nếu ko còn chổ lưu trữ -> xuất thông báo lỗi
        public void add()
        {
            Employee emp = new Employee();

            Console.WriteLine("Nhap thong tin nhan vien:");

            // nhap id nhan vien
            while (true)
            {
                try
                {
                    Console.Write("Nhap id cua nhan vien: ");
                    emp.pID = Console.ReadLine().Trim();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            } // ket thuc nhap id

            // nhap name
            while (true)
            {
                try
                {
                    Console.Write("Nhap ten: ");
                    emp.pName = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            } // ket thuc nhap name

            // nhap position
            while (true)
            {
                try
                {
                    Console.Write("Nhap chuc vu: ");
                    emp.pPosition = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            } // ket thuc nhap position

            // nhap salary
            while (true)
            {
                try
                {
                    Console.Write("Nhap luong: ");
                    emp.pBaseSalary = int.Parse(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception: " + e.Message);
                }
            }
            ds.Add(emp.pID, emp);
            Console.WriteLine("Them nhan vien moi thanh cong");
        }

        // void display(): In toàn bộ danh sách nhân viên, và in thông báo nếu hệ thống chưa có dữ liệu
        public void display()
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            Console.WriteLine("Danh sach nhan vien ");
            foreach (var item in ds.Values)
            {
                Console.WriteLine(item);
            }
        }

        // void display(String sName) tìm kiếm nhân viên trong danh sách theo tên (sName) và in chi tiết cúa nhân viên đó ra nếu tìm thấy, ngược lại thông báo lỗi.
        public void display(string sName)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            int cntName = 0;
            foreach (var item in ds.Values)
            {
                if (Regex.IsMatch(item.pName, sName, RegexOptions.IgnoreCase))
                {
                    Console.WriteLine($">>> Thong tin cua nhan vien {item.name}");
                    Console.WriteLine(item);
                    cntName++;
                }
            } // ket thuc foreach
            if (cntName == 0)
            {
                Console.WriteLine("Khong tim thay !!!");
            }
        }

        // void display(int iSalary): đếm và in danh sách nhân viên có mức lương trên iSalary USD. CT sẽ in thông báo nếu hệ thống chưa có dữ liệu hoặc không tìm thấy nhân viên nào.
        public void displaySalary(int iSalary)
        {
            if (ds.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu");
                return;
            }
            int cntSalary = 0;
            Console.WriteLine("Danh sach nhan vien ");
            foreach (var item in ds.Values)
            {
                if (Regex.Equals(item.baseSalary, iSalary))
                {
                    Console.WriteLine(item);
                    cntSalary++;
                }
            } // ket thuc foreach
            if (cntSalary == 0)
            {
                Console.WriteLine("Khong tim thay !!!");
            }
        }

        // void menu (): xây dựng hệ thống thực đơn cho phép thêm, tìm kiếm và in danh sách các nhân viên theo yêu cầu.
        void menu()
        {
            string op = "";
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Them nhan vien");
                Console.WriteLine("2. In danh sach nhan vien");
                Console.WriteLine("3. In danh sach nhan vien theo ten");
                Console.WriteLine("4. In danh sach nhan vien theo luong");
                Console.WriteLine("5. Thoat");

                Console.Write("Nhap ma so chuc nang [1-5]: ");
                op = Console.ReadLine().Trim();

                switch (op)
                {
                    case "1":
                        add();
                        break;
                    case "2":
                        display();
                        break;
                    case "3":
                        Console.Write("Nhap ten nhan vien muon tim: ");
                        display(Console.ReadLine().Trim());
                        break;
                    case "4":
                        Console.Write("Nhap muc luong muon tim: ");
                        displaySalary(int.Parse(Console.ReadLine()));
                        break;
                    case "5": 
                        break;
                    default:return;
                }

                Console.Write("\n Bam phim bat ky de tiep tuc chuong trinh ...");
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
