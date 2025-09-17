using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int PublishYear { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null || obj.GetType() != typeof(Book))
                return false;

            Book other = (Book)obj;
            if (Title == other.Title && Author == other.Author && PublishYear == other.PublishYear)
                return true;
            else
                return false;
        }
    }
}
