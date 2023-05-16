namespace Library_GitPairLab.Testing
{
    public class LibraryTesting
    {
        [Fact]
        public void Library_Constructor_InstantiatesLibraryObject()
        {
            Library libraryTest = new Library();

            Assert.Equal(new List<Book>(), libraryTest.Books);
            Assert.Equal(new List<Patron>(), libraryTest.Patrons);
        }

        [Fact]
        public void Library_AddBook_AddsBookToLibraryBookList()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");

            libraryTest.AddBook(book1);

            Assert.Equal(libraryTest.Books[0], book1);
        }

        [Fact]
        public void Library_RemoveBook_RemovesBookFromLibraryBookList()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");

            libraryTest.AddBook(book1);
            libraryTest.RemoveBook(book1);
            Assert.Empty(libraryTest.Books);
        }

        [Fact]
        public void Library_BooksInStock_ReturnsListofBooksWithNoPatron()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");

            libraryTest.AddBook(book1);
            libraryTest.AddBook(book2);

            var listOfBooks = libraryTest.BooksInStock();

            Assert.Equal(libraryTest.Books[0], listOfBooks[0]);
            Assert.Equal(libraryTest.Books[0], listOfBooks[0]);
        }
        [Fact]
        public void Library_Checkout_AssignsPatronToBook()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");
            Patron patron1 = new Patron("test1", "123-456-7890");
            Patron patron2 = new Patron("test2", "098-765-4321");

            Assert.Null(book1.Patron);
            Assert.Null(book2.Patron);

            book1.Checkout(patron1);
            book2.Checkout(patron2);

            Assert.NotNull(book1.Patron);
            Assert.NotNull(book2.Patron);
        }
        [Fact]
        public void Library_Return_ResetsBooksPatronToNull()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");
            Patron patron1 = new Patron("test1", "123-456-7890");
            Patron patron2 = new Patron("test2", "098-765-4321");

            book1.Checkout(patron1);
            book2.Checkout(patron2);

            Assert.NotNull(book1.Patron);
            Assert.NotNull(book2.Patron);

            book1.Return(book1);
            book2.Return(book2);

            Assert.Null(book1.Patron);
            Assert.Null(book2.Patron);
        }
        [Fact]
        public void Library_CheckedOutBooks_ReturnsListOfBooksPatronHasCheckedOut()
        {
            Library libraryTest = new Library();
            Book book1 = new Book("Book1", "Author1");
            Book book2 = new Book("Book2", "Author2");
            Patron patron1 = new Patron("test1", "123-456-7890");
            Patron patron2 = new Patron("test2", "098-765-4321");

            book1.Checkout(patron1);
            book2.Checkout(patron1);

            var bookList = libraryTest.CheckedOutBooks(patron1);

            Assert.Equal(libraryTest.Books[0], bookList[0]);
            Assert.Equal(libraryTest.Books[1], bookList[1]);
        }
    }
}