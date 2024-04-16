using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Book : Merchandise
    {
        private string _title;
        private double _price;

        
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public Book(string itemId)
        {
            this.ItemId = itemId;
        }

        public Book(string itemId, string title)
        {
            this.ItemId= itemId;
            this.Title = title;
        }
        public Book(string itemId, string title, double price)
        {
            this.ItemId = itemId;
            this.Title = title;
            this.Price = price;
        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }
    }

}
