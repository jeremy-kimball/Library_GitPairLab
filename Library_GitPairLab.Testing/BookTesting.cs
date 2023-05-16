using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_GitPairLab.Testing
{
    public class BookTesting
    {
        public void Book_Constructor_CorrectlySetsPropertyValues()
        {
            var hobbit = new Book("The Hobbit", "J. R. R. Tolkien");

            Assert.Equal("The Hobbit", hobbit.Title);
            Assert.Equal("J. R R. Tolkien", hobbit.Author);
            Assert.Null(hobbit.Patron);
        }

        public void Book_Checkout_AssignsPatrontoBook()
        {
            var hobbit = new Book("The Hobbit", "J. R. R. Tolkien");
            var patron1 = new Patron("Skylar Sandler", "123-456-7890");

            hobbit.Checkout(patron1);

            Assert.Equal(patron1, hobbit.Patron);
        }

        public void Book_Return_ResetsPatrontoNull()
        {
            var hobbit = new Book("The Hobbit", "J. R. R. Tolkien");
            var patron1 = new Patron("Skylar Sandler", "123-456-7890");

            hobbit.Checkout(patron1);

            hobbit.Return();

            Assert.Null(hobbit.Patron);
        }
    }
}
