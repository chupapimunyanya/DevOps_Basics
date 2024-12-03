using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevOps_Basics
{
    public class Library : ILibrary
    {
        private List<IBook> books = new List<IBook>();
        public IReadOnlyList<IBook> Books => books;

        public void AddBook(IBook book)
        {
            books.Add(book);
            Console.WriteLine($"Book added: {book}");
        }

        public IBook FindBookByTitle(string title)
        {
            return books.Find(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        public void DisplayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("The library is empty.");
                return;
            }

            Console.WriteLine("Books in the library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
