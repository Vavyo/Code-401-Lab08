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
            // assert
            Assert.Contains<Book>()
        }
    }
}
