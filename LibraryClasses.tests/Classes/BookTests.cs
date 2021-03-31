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
    }
}
