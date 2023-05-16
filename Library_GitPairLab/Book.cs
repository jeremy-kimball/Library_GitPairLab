using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_GitPairLab
{
    public class Book
    {
        public string Title;
        public string Author;
        public Patron? Patron { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            Patron = null;
        }

        public void Checkout(Patron newPatron)
        {
            Patron = newPatron;
        }

        public void Return()
        {
            Patron = null;
        }
    }
}
