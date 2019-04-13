using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2019.Markin._08.Books.Tests
{
    [TestFixture]
    public class BookTests
    {
        Book b1 = new Book("1111111111111", "Max", "Dark1", "Minsk", 1980, 100, 100);
        Book b2 = new Book("2222222222222", "Max", "Dark1", "Minsk", 1980, 100, 100);
        Book b3 = new Book("3333333333333", "Max", "Dark1", "Minsk", 1980, 100, 100);
        [Test]
        public void Test_Book_Add()
        {
            List<Book> expected = new List<Book>();
            expected.Add(b1);
            expected.Add(b2);
            expected.Add(b3);
            BookListService actual = new BookListService();
            actual.AddBook(b1);
            actual.AddBook(b2);
            actual.AddBook(b3);
            Assert.AreEqual(expected, actual.ListBooks);
        }

    }
}
