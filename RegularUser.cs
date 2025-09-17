using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class RegularUser : User
    {
        public LibraryCard Card { get; set; }

        public RegularUser(string username)
        {
              Name = username;
        }
        public void Borrow(Book book , Library library)
        {
            library.BorrowBook(book);
        }
    }
}
