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

        public void AddBook(Book book)
        {
            books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].ItemId == itemId)
                {
                    return books[i];
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double value = 0;
            for (int i = 0; i < books.Count; i++)
            {
                value += books[i].Price;
            }
            return value;
        }

    }
}
