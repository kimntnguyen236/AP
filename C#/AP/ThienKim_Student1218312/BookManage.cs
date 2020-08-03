using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThienKim_Student1218312
{
    public class MyException : Exception
    {
        public MyException()
        {
            Console.WriteLine("Loi sai!");
        }
        public MyException(string s) : base(s)
        {

        }
    }
    // 1. Dinh nghia delegate DMess - co tham so la mot chuoi
    public delegate void DMess(string str);
    public class BookManage: IEnumerable<Book>
    {
        // 2. Dinh nghia event - kiem tra du lieu nhap
        public event DMess EMess;

        // 3. Dinh nghia ham xu ly event [EValidation]
        public void ValidProcess(string s)
        {
            throw new MyException(s);
        }

        // 4. Khoi tao event va dang ky ham xu ly event - trong ham dung
        public BookManage()
        {
            EMess = new DMess(ValidProcess);
        }

        List<Book> honList = new List<Book>();
        public void createBook(Book book)
        {
            while (true)
            {
                try
                {
                    Console.Write("Nhap title: ");
                    book.pTitle = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi : " + e.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Nhap price: ");
                    book.pPrice = double.Parse(Console.ReadLine().Trim());
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi : " + e.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.Write("Sach co giam gia khong? [yes/no]: ");
                    book.pSale = Console.ReadLine().Trim();
                    break;

                }
                catch (Exception e)
                {
                    Console.WriteLine("Loi : " + e.Message);
                }
            }
            honList.Add(book);
            Console.WriteLine("Them moi thanh cong!");
        }

        public void findByIsSale()
        {
            if (honList.Count == 0)
            {
                Console.WriteLine("He thong chua co du lieu !");
                return;
            }
            var dsten = from item in honList
                        where item.isSale == true
                        select item;
            if (dsten.Count() == 0)
            {
                Console.WriteLine("Khong tim thay !!!");
            }
            else
            {
                Console.WriteLine($"\n Danh sach sach giam gia: ");
                foreach (var bk in dsten)
                {
                    Console.WriteLine(bk);
                }
            }
        }

        //public IEnumerable<Book> GetEnumerator()
        //{
        //    if (honList.Count == 0)
        //    {
        //        EMess("He thong chua co du lieu! ");
        //        yield break;
        //    }

            
        //    foreach (var item in honList)
        //    {
        //        yield return item;
        //    }
        //}

        IEnumerator<Book> IEnumerable<Book>.GetEnumerator()
        {
            if (honList.Count == 0)
            {
                EMess("He thong chua co du lieu! ");
                yield break;
            }


            foreach (var item in honList)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            if (honList.Count == 0)
            {
                EMess("He thong chua co du lieu! ");
                yield break;
            }


            foreach (var item in honList)
            {
                yield return item;
            }
        }
    }
}
