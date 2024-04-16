using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Disaheim1
{
    public abstract class Merchandise
    {
        private string _itemId;
        
        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
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
