using System;
using System.Linq;

namespace NET.S._2019.Markin._08
{
    public class Book : IComparable<Book>
    {
        private string isbn;

        private string author;

        private string name;

        private string publisher;

        private int year;

        private int pages;

        private int price;

        /// <summary>
        /// Initialize class Book
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="author"></param>
        /// <param name="name"></param>
        /// <param name="publishing"></param>
        /// <param name="year"></param>
        /// <param name="pages"></param>
        /// <param name="price"></param>
        public Book(string isbn, string author, string name, string publishing, int year, int pages, int price)
        {
            if (isbn == null || isbn.Length != 13 || !isbn.All(char.IsDigit) || author == null || publishing == null || year <= 1000 || year >= 2019 
                || pages <= 0 || price <= 0)
            {
                throw new ArgumentException("Invalid parametrs given");
            }

            this.isbn = isbn;
            this.author = author;
            this.name = name;
            this.publisher = publishing;
            this.year = year;
            this.pages = pages;
            this.price = price;
        }

        /// <summary>
        /// Property 
        /// </summary>
        public string Isbn
        {
            get
            {
                return isbn;
            }
        }

        /// <summary>
        /// Property for Name
        /// </summary>
        public string Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Property for author
        /// </summary>
        public string Author
        {
            get
            {
                return author;
            }
        }

        /// <summary>
        /// Property for publisher
        /// </summary>
        public string Publisher
        {
            get
            {
                return publisher;
            }
        }

        /// <summary>
        /// Property for year
        /// </summary>
        public int Year
        {
            get
            {
                return year;
            }
        }

        /// <summary>
        /// Property for pages
        /// </summary>
        public int Pages
        {
            get
            {
                return pages;
            }
        }

        /// <summary>
        /// Property for price
        /// </summary>
        public int Price
        {
            get
            {
                return price;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            var book = obj as Book;

            if (book.isbn == this.isbn && book.author == this.author && book.name == this.name && book.publisher == this.publisher &&
                book.year == this.year && book.pages == this.pages && book.price == this.price)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{name}, was writen in {year} by {author} and published by {publisher}. Contains {pages} and costs {price} \n ISBN:{isbn} \n ";
        }

        public override int GetHashCode()
        {
            int hashcode = 13;
            hashcode = (23 * hashcode) + isbn.GetHashCode();
            hashcode = (23 * hashcode) + author.GetHashCode();
            hashcode = (23 * hashcode) + name.GetHashCode();
            hashcode = (23 * hashcode) + publisher.GetHashCode();
            hashcode += price;
            hashcode += pages;
            hashcode += year;

            return hashcode;
        }

        /// <summary>
        /// Implements interface IComparable
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Book other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other));
            }

            return isbn.CompareTo(other.Isbn);
        }
    }
}
