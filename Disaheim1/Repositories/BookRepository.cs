using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Repository
{
    public class BookRepository
    {
        public List<Book> Books { get; set; }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public Book GetBook(string itemId)

        { 
            foreach (Book book in Books) 
            {
                if (book.ItemId == itemId) ;
               return book;
            }
            return null;

        }
        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Book book in Books)
            {
                // double value = Utility.GetValueOfAmulet();
                double value = 0;
                totalValue += value;
            }
            return totalValue;
         

        }





    }
}
