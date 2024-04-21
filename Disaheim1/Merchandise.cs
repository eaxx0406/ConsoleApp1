using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Disaheim1
{
    public abstract class Merchandise: IValuable
    {
        private string _itemId;
        
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }

        public double GetValue()
        {
            Book book = null;
            Amulet amulet = null;

            if (this.GetType() == typeof(Amulet))
            {
                amulet = (Amulet)this;
                switch (amulet.Quality)
                {
                    case Level.medium:
                        return 20;
                    case Level.low:
                        return 12.5;
                    case Level.high:
                        return 27.5;
                    default:
                        return 0;
                }
                throw new NotImplementedException();
            }
            else if (this.GetType() == typeof(Book))
            {
                book = (Book)this;
                Console.WriteLine("bog");
                return book.Price;
            }
            return 0;
        }

        //public Merchandise(string itemId) 
        //{
        //    this._itemId = itemId;
        //}

        public virtual  string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}
