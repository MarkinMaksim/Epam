using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NET.S._2019.Markin._08
{
    public class BookListStorage
    {
        private List<Book> listbooks;

        /// <summary>
        /// Initialize class
        /// </summary>
        /// <param name="localbooks"></param>
        public BookListStorage(List<Book> localbooks)
        {
            listbooks = new List<Book>();
            if (localbooks == null)
            {
                throw new ArgumentNullException("Parametr can't be null");
            }

            foreach (Book b in localbooks)
            {
                listbooks.Add(b);
            }
        }

        /// <summary>
        /// Update storage list
        /// </summary>
        /// <param name="list"></param>
        public void UpdateListBooks(List<Book> list)
        {
            listbooks = list;
        }

        /// <summary>
        /// Save all books to binary file
        /// </summary>
        /// <param name="filename"></param>
        public void SaveBooks(string filename)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(filename, FileMode.Create)))
            {
                foreach (Book b in listbooks)
                {
                    writer.Write(b.Isbn);
                    writer.Write(b.Name);
                    writer.Write(b.Author);
                    writer.Write(b.Publisher);
                    writer.Write(b.Year);
                    writer.Write(b.Pages);
                    writer.Write(b.Price);
                }
            }
        }

        /// <summary>
        /// Load books from binary
        /// </summary>
        /// <param name="filename"></param>
        public void LoadBooks(string filename)
        {
            if (File.Exists(filename))
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(filename)))
                {
                    List<Book> result = new List<Book>();

                    while (reader.PeekChar() > -1)
                    {
                        string isbn = reader.ReadString();
                        string author = reader.ReadString();
                        string name = reader.ReadString();
                        string publisher = reader.ReadString();
                        int year = reader.ReadInt32();
                        int pages = reader.ReadInt32();
                        int price = reader.ReadInt32();

                        result.Add(new Book(isbn, author, name, publisher, year, pages, price));
                    }

                    listbooks = result;
                }
            }
        }
    }
}
