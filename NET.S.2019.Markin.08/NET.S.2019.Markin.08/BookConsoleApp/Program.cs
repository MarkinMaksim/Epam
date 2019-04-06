using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NET.S._2019.Markin._08;

namespace BookConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book("1111111111111", "Max", "Dark1","Minsk", 1980, 100, 100);
            Book b2 = new Book("2222222222222", "Max", "Dark1", "Minsk", 1980, 100, 100);
            Book b3 = new Book("3333333333333", "Max", "Dark1", "Minsk", 1980, 100, 100);
            BookListService service = new BookListService();
            service.AddBook(b2);
            service.AddBook(b1);
            service.AddBook(b3);
            Console.WriteLine(service.PrintBooks());
            Console.WriteLine("_______________________________________________________");
            service.SortBooksByTag();
            Console.WriteLine(service.PrintBooks());
            Console.ReadLine();
            BookListStorage storage = new BookListStorage(service.ListBooks);
            storage.SaveBooks("Books");
            BookListStorage storage2 = new BookListStorage(new List<Book>());
            storage2.LoadBooks("Books");

        }
    }
}
