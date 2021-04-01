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
    }
}
