using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2019.Markin._08
{
    public class BookListService
    {
        private List<Book> listbooks = new List<Book>();

        /// <summary>
        /// enumeration for search
        /// </summary>
        public enum Crit
        {
            isbn,
            author,
            name,
            publisher,
            year,
            pages,
            price
        }

        /// <summary>
        /// Property for list of books
        /// </summary>
        public List<Book> ListBooks
        {
            get
            {
                return listbooks;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Value can't be null");
                }
                else
                {
                    listbooks = value;
                }
            }
        }

        /// <summary>
        /// Add book to list
        /// </summary>
        /// <param name="book"></param>
        public void AddBook(Book book)
        {
            bool exists = false;
            
            if (book == null)
            {
                throw new ArgumentNullException("Book can't be null");
            }

            foreach (Book b in listbooks)
            {
                if (b.Equals(book))
                {
                    exists = true;
                }
            }

            if (exists == false)
            {
                listbooks.Add(book);
            }
            else
            {
                throw new Exception("Book already exist");
            }
        }

        /// <summary>
        /// Remove book from list if it exist
        /// </summary>
        /// <param name="book"></param>
        public void RemoveBook(Book book)
        {
            bool exists = false;

            if (book == null)
            {
                throw new ArgumentNullException("Book can't be null");
            }

            foreach (Book b in listbooks)
            {
                if (b.Equals(book))
                {
                    exists = true;
                }
            }

            if (exists == true)
            {
                listbooks.Remove(book);
            }
            else
            {
                throw new Exception("Book not exist");
            }
        }

        /// <summary>
        /// Find book by tag from list
        /// </summary>
        /// <param name="value"></param>
        /// <param name="crit"></param>
        /// <returns></returns>
        public Book FindBookByTag(string value, Crit crit)
        {
            switch (crit)
            {
                case Crit.isbn:
                    return listbooks.Find(book => book.Isbn == value);
                case Crit.author:
                    return listbooks.Find(book => book.Author == value);
                case Crit.name:
                    return listbooks.Find(book => book.Name == value);
                case Crit.publisher:
                    return listbooks.Find(book => book.Publisher == value);
                case Crit.year:
                    return listbooks.Find(book => book.Year == int.Parse(value));
                case Crit.price:
                    return listbooks.Find(book => book.Price == int.Parse(value));
                case Crit.pages:
                    return listbooks.Find(book => book.Pages == int.Parse(value));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Sort list of books
        /// </summary>
        public void SortBooksByTag()
        {
            listbooks.Sort();
        }

        /// <summary>
        /// Print all books from list
        /// </summary>
        /// <returns></returns>
        public string PrintBooks()
        {
            string result = string.Empty;

            foreach (Book b in listbooks)
            {
                result += b.ToString();
            }

            return result;
        }
    }
}
