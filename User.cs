using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal abstract class User
    {
        public string Name { get; set; }
        public void Display(Library library)
        {
            library.Display();
        }
    }
}
