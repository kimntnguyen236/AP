using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As9
{
    public class StudentCollection
    {
        List<Student> stList = new List<Student>();
        Student st = new Student();
        public void Add()
        {
            Student st = new Student();
            st.Input();
            stList.Add(st);
            Console.WriteLine("Add a new student to success");
        }

        public IEnumerable<Student> GetEnumerator()
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !");
                yield break;
            }

            var x40 = stList.FindAll(sv => sv.pAvg >= 40).ToList();
            if (x40.Count == 0)
            {
                Console.WriteLine("Khong tim thay sinh vien co diem TB >= 40");
                yield break;
            }

            foreach (var item in x40)
            {
                yield return item;
            }
        }

        public void Search(string Name)
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !");
                return;
            }
            int cntName = 0;
            var dsten = from item in stList
                        where item.Fullname.Contains(Name)
                        orderby item.pAvg descending
                        select item;
            if (dsten.Count() == 0)
            {
                Console.WriteLine("Khong tim thay !!!");
            }
            else
            {
                Console.WriteLine($"\n Danh sach sinh vien co ten {Name}");
                foreach (var sv in dsten)
                {
                    Console.WriteLine(sv);
                }
            }
        }

        public void Remove(string ID)
        {
            foreach (var n in stList.Where(sv => sv.pID == ID).ToArray())
                stList.Remove(n);
        }

        public void DisplayAll()
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !");
                return;
            }
            Console.WriteLine("List of students: ");
            foreach (var sv in stList)
            {
                Console.WriteLine(sv);
            }
        }

        //public void TestStudents()
        //{
        //    string op = "";
        //    StudentCollection stc = new StudentCollection();
        //    while (true)
        //    {
        //        Console.Clear();
        //        Console.WriteLine("==== MENU ====");
        //        Console.WriteLine("1. Add new student");
        //        Console.WriteLine("2. Display all students");
        //        Console.WriteLine("3. Display passed students");
        //        Console.WriteLine("4. Search students by name");
        //        Console.WriteLine("5. Remove a student by ID");
        //        Console.WriteLine("6. Quit");
        //        Console.Write("Choose [1-6]: ");
        //        op = Console.ReadLine().Trim();
        //        switch (op)
        //        {
        //            case "1":
        //                Add();
        //                break;
        //            case "2":
        //                DisplayAll();
        //                break;
        //            case "3":
        //                foreach (var item in stc.GetEnumerator())
        //                {
        //                    Console.WriteLine(item);
        //                    item.Display();
        //                }
        //                break;
        //            case "4":
        //                Console.Write("Nhap ten sinh vien muon tim: ");
        //                Search(Console.ReadLine().Trim());
        //                break;
        //            case "5":
        //                Console.Write("Nhap ID muon xoa: ");
        //                Remove(Console.ReadLine().Trim());
        //                break;
        //            case "6": return;
        //            default:
        //                break;
        //        }
        //        Console.WriteLine("\n Bam 1 phim bat ky de tiep tuc ...");
        //        Console.ReadKey(true);
        //    }
        //}
    }
}
