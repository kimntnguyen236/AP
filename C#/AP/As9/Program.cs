using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace As9
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TestStudents();
        }
        public void TestStudents()
        {
            string op = "";
            StudentCollection stc = new StudentCollection();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Add new student");
                Console.WriteLine("2. Display all students");
                Console.WriteLine("3. Display passed students");
                Console.WriteLine("4. Search students by name");
                Console.WriteLine("5. Remove a student by ID");
                Console.WriteLine("6. Quit");
                Console.Write("Choose [1-6]: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        stc.Add();
                        break;
                    case "2":
                        stc.DisplayAll();
                        break;
                    case "3":
                        foreach (var item in stc.GetEnumerator())
                        {
                            //Console.WriteLine(item);
                            item.Display();
                        }
                        break;
                    case "4":
                        Console.Write("Nhap ten sinh vien muon tim: ");
                        stc.Search(Console.ReadLine().Trim());
                        break;
                    case "5":
                        Console.Write("Nhap ID muon xoa: ");
                        stc.Remove(Console.ReadLine().Trim());
                        break;
                    case "6": return;
                    default:
                        break;
                }
                Console.WriteLine("\n Bam 1 phim bat ky de tiep tuc ...");
                Console.ReadKey(true);
            }
        }
    }
}
