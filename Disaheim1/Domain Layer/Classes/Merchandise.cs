using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Disaheim1.Classes
{
    public abstract class Merchandise : IValuable
    {
        private string _itemId;

        public string ItemId
        {
            get { return _itemId; }
            set { _itemId = value; }
        }


        public abstract double GetValue();

        public virtual string ToString()
        {
            return $"ItemId: {ItemId}";
        }

    }
}
