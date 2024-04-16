using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Repository
{
    public class BookRepository
    {
        public List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            this.books.Add(book);
        }
        public Book GetBook(string itemId)
        {
            Book book = books.FirstOrDefault(c => c.ItemId == itemId);

            if (book != null)
            {
                return book;
            }
            return book;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Book book in books)
            {
                // double value = Utility.GetValueOfAmulet();
                double value = 0;
                totalValue += value;
            }
            return totalValue;
         

        }





    }
}
