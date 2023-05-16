using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_GitPairLab
{
    public class Library
    {
        public List<Book> Books;
        public List<Patron> Patrons;

        public Library()
        {
            List<Book> Books = new List<Book>();
            List<Patron> Patrons = new List<Patron>();
        }

        public List<Book> BooksInStock()
        {
            List<Book> returnBookList = new List<Book>();
            foreach (Book book in Books)
            {
                if (book.Patron == null)
                {
                    returnBookList.Add(book);
                }
            }
            return returnBookList;
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }


        public void Checkout(Book book, Patron patron)
        {
            book.Patron = patron;
        }

        public void Return(Book book)
        {
            book.Patron = null;
        }

        public List<Book> CheckedOutBooks(Patron patron)
        {
            List<Book> returnBookList = new List<Book>();
            foreach(Book book in Books)
            {
                if(book.Patron == patron)
                {
                    returnBookList.Add(book);
                }
            }
            return returnBookList();
        }

    }
}
