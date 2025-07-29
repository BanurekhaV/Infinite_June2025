using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Models;

namespace CodeFirst
{
    class Program
    {
        static BooksContext db = new BooksContext();

        static void ShowAllBooks()
        {
            var bk = from b in db.book 
                     select b;

            foreach(var item in bk)
            {
                Console.WriteLine($"{item.BookId},  {item.BookName}, {item.Price}, {item.YearPublished}");
            }
        }
        static void AddBooks()
        {
            Books books = new Books();
            Console.WriteLine("Enter Bookid, Bookname, price, Yr Published ");
            books.BookId = int.Parse(Console.ReadLine());
            books.BookName = Console.ReadLine();
            books.Price = Convert.ToDouble(Console.ReadLine());
            books.YearPublished = Convert.ToDateTime(Console.ReadLine());

            db.book.Add(books);
            db.SaveChanges();
        }
        static void Main(string[] args)
        {
            AddBooks();
            ShowAllBooks();
            Console.Read();
        }
    }
}
