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

        [Test]
        public void Test_Book_Print()
        {
            string expected = "Dark1, was writen in 1980 by Max and published by Minsk. Contains 100 and costs 100 \n ISBN:1111111111111 \n ";       
            BookListService actual = new BookListService();
            actual.AddBook(b1);
            Assert.AreEqual(expected, actual.PrintBooks());
        }

        [Test]
        public void Test_Book_Print_AuthorName()
        {
            string expected = "Max,Dark1";
            BookListService actual = new BookListService();
            Assert.AreEqual(expected, b1.GetAuthorName());
        }

        [Test]
        public void Test_Book_Print_AuthorNamePrice()
        {
            string expected = "Dark1, was writen by Max. Costs 100 \n ";
            BookListService actual = new BookListService();
            Assert.AreEqual(expected, b1.GetAuthNamePrice());
        }

    }
}
