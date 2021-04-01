using LibraryClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryClasses.tests.Classes
{
    public class LibraryTests
    {
        [Fact]
        public void Can_add_books_to_library()
        {
            // arrange
            Library library = new Library();

            // act
            library.Add("Moby Dick", "Herman", "Melville", 378);
            int count = library.Count;
            // assert
            Assert.Equal(1, count);
            // act
            library.Add("just test title", "boring", "right?", 378);
            count = library.Count;
            // assert
            Assert.Equal(2, count);
        }
        [Fact]
        public void Borrowing_existing_book_returns_book_and_removes_it()
        {
            // arrange
            Library library = new Library();
            library.Add("Moby Dick", "Herman", "Melville", 378);
            library.Add("just test title", "boring", "right?", 378);

            // act
            Book borrowed = library.Borrow("Moby Dick");
            int count = library.Count;

            // assert
            Assert.DoesNotContain(borrowed, library);
            Assert.Equal(1,count);

        }
        [Fact]
        public void Borrowing_nonexistant_book_returns_null()
        {
            // arrange
            Library library = new Library();

            // act
            Book book = library.Borrow("Moby Dick");

            // assert
            int count = library.Count;
            Assert.Null(book);
            Assert.Equal(0, count);
        }
        [Fact]
        public void Return_adds_book_to_library()
        {
            // arrange
            Library books = new Library();
            books.Add("Moby Dick", "Herman", "Melville", 378);
            books.Add("just test title", "boring", "right?", 378);
            Book book = books.Borrow("Moby Dick");

            // act
            books.Return(book);

            // assert
            int count = books.Count;
            Assert.Contains(book, books);
            Assert.Equal(2, count);
        }
    }
}
