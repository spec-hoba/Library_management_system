using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        private List<Book> books = new List<Book>();
        private List<Book> borrowedBooks = new List<Book>();

        public void Add(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully");
        }

        public void Remove(Book book)
        {
            if (books.Remove(book))
                Console.WriteLine("Book removed successfully");
            else
                Console.WriteLine("Book not found");
        }

        public void Display()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the library");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} - {book.Author} ({book.PublishYear})");
            }
        }

        public void BorrowBook(Book book)
        {
            if (books.Contains(book))
            {
                books.Remove(book);
                borrowedBooks.Add(book);
                Console.WriteLine("Book borrowed successfully");
            }
            else
            {
                Console.WriteLine("Book not found in the library");
            }
        }
    }
}
