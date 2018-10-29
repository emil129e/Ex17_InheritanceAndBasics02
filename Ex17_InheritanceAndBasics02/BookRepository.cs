using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17_InheritanceAndBasics02
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book) { }
        public Book GetBook(string itemId) { return books[0]; }
        public double GetTotalValue() { return 1; }
    }
}
