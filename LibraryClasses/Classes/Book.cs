using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryClasses.Classes
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int PageCount { get; }
        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            Author = $"{firstName} {lastName}";
            PageCount = numberOfPages;
        }
    }
}
