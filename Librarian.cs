using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Librarian : User
    {
        public int EmpolyeeNumber { get; set; }
        public Librarian(string name)
        {
            Name = name;
        }
        public void AddBook(Book newBook , Library library)
        {
            library.Add(newBook);
        }
        public void RemoveBook(Book newBook , Library library)
        {
            library.Remove(newBook);
        }
    }
}
