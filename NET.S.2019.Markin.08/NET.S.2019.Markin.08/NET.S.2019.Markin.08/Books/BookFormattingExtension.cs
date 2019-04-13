using System;
using System.Collections.Generic;
using System.Text;

namespace NET.S._2019.Markin._08.Books
{
    /// <summary>
    /// 
    /// </summary>
    public static class BookFormattingExtension
    {
        /// <summary>
        /// Return book author and name like a string
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static string GetAuthorName(this Book book)
        {
            return $"{book.Author},{book.Name}";
        }

        /// <summary>
        /// Return book author and name like a string
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static string GetAuthNamePubYear(this Book book)
        {
            return $"{book.Author},{book.Name},{book.Publisher},{book.Year}";
        }

        /// <summary>
        /// Return information of book without price
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static string GetWithoutPrice(this Book book)
        {
            return $"{book.Name}, was writen in {book.Year} by {book.Author} and published by {book.Publisher}. Contains {book.Pages} \n ISBN:{book.Isbn} \n ";
        }

        /// <summary>
        /// Return book author, name, price
        /// </summary>
        /// <param name="book"></param>
        /// <returns></returns>
        public static string GetAuthNamePrice(this Book book)
        {
            return $"{book.Name}, was writen by {book.Author}. Costs {book.Price} \n ";
        }
    }
}
