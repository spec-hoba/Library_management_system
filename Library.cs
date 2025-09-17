using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Library
    {
        private Book[] books = new Book[100];
        private int currentBookCount = 0 ;
        private Book[] Borrowedbooks = new Book[50];
        private int currentBorrowedBookCount = 0;

        public void Add(Book book)
        {
            if (currentBookCount < books.Length)
            {
                books[currentBookCount] = book;
                currentBookCount++;
                Console.WriteLine("book added sucessfully");

            }
            else
                Console.WriteLine("the library is full , you can't add more books");
        }
        public void Remove(Book book)
        {
            for (int i = 0; i < currentBookCount; i++)
            {
                if (books[i] != null &&
                    books[i].Title == book.Title &&
                    books[i].Author == book.Author &&
                    books[i].PublishYear == book.PublishYear)
                {
                    // نزحلق العناصر
                    for (int j = i; j < currentBookCount - 1; j++)
                    {
                        books[j] = books[j + 1];
                    }
                    books[currentBookCount - 1] = null;
                    currentBookCount--;

                    Console.WriteLine("book removed successfully");
                    return;
                }
            }
            Console.WriteLine("book not found");
        }
        public void Display()
        {
           for (int  i = 0; i < currentBookCount; i++)
            {
                Console.WriteLine(books[i].Title);
            }
        }
        public void BorrowBook(Book book)
        {
            for (int i = 0; i < currentBookCount; i++)
            {
                if (books[i] != null &&
                    books[i].Title == book.Title &&
                    books[i].Author == book.Author &&
                    books[i].PublishYear == book.PublishYear)
                {
                    if (currentBorrowedBookCount < Borrowedbooks.Length)
                    {
                        Borrowedbooks[currentBorrowedBookCount] = books[i];
                        currentBorrowedBookCount++;

                        for (int j = i; j < currentBookCount - 1; j++)
                        {
                            books[j] = books[j + 1];
                        }
                        books[currentBookCount - 1] = null;
                        currentBookCount--;

                        Console.WriteLine("Book borrowed successfully");
                        return;
                    }
                    else  
                    {
                        Console.WriteLine("Sorry, borrowing list is full");
                        return;
                    }
                }
            }
            Console.WriteLine("Book not found in the library");
      
        
        
        
        }
    }
}
