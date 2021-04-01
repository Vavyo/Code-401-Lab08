using LibraryClasses.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LibraryClasses.tests.Classes
{
    public class BackpackTests
    {
        [Fact]
        public void Pack_adds_item_to_backpack()
        {
            // arrange
            Backpack<int> bag = new Backpack<int>();

            // act
            bag.Pack(3);

            // assert
            Assert.Contains(3, bag);
        }
    }
}
