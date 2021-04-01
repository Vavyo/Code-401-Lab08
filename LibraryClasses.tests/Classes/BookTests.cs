using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using LibraryClasses.Classes;

namespace LibraryClasses.tests.Classes
{
    public class BookTests
    {
        [Fact]
        public void Can_create_book()
        {
            //arrange
            Book book = new Book("Moby Dick", "Herman", "Melville", 378);
            //assert
            Assert.NotNull(book);
        }
        [Fact]
        public void Author_is_firstname_and_lastname()
        {
            //arrange
            Book book = new Book("Moby Dick", "Herman", "Melville", 378);
            // act
            string result = book.Author;
            //assert
            Assert.Equal("Herman Melville", result);
        }

    }
}
