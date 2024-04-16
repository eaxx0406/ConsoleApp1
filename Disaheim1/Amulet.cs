using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Amulet : Merchandise
    {


        private string _itemId;
        private string _design;
        private Level _quality;

      
        public string Design
        {
            get { return _design; }
            set { _design = value; }
        }
        public Level Quality
        {
            get { return _quality; }
            set { _quality = value; }

        }
        //Constructor


        public Amulet(string itemId)
        {
            this.ItemId = itemId;
        }

        public Amulet(string itemId, Level quality)
        {
            this.ItemId = itemId;
            this.Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            this.ItemId = itemId;
            this.Quality = quality;
            this.Design = design;

        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }

}
