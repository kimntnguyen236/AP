using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienKim_Student1218312
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.BookTest();
        }

        public void BookTest()
        {
            string op = "";
            BookManage honManage = new BookManage();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== MENU ====");
                Console.WriteLine("1. Create New");
                Console.WriteLine("2. Find By isSale");
                Console.WriteLine("3. Find All");
                Console.WriteLine("4. Quit");
                Console.Write("Choose [1-4]: ");
                op = Console.ReadLine().Trim();
                switch (op)
                {
                    case "1":
                        Book book = new Book();
                        honManage.createBook(book);
                        break;
                    case "2":
                        honManage.findByIsSale();
                        break;
                    case "3":
                        foreach (var item in honManage)
                        {
                            //Console.WriteLine(item);
                            item.Display();
                        }
                        break;
                    case "4": return;
                    default:
                        break;
                }
                Console.WriteLine("\n Bam 1 phim bat ky de tiep tuc ...");
                Console.ReadKey(true);
            }
        }
    }
}
