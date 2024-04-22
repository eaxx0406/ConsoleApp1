using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Classes
{
    public class Amulet : Merchandise
    {
        private static double LowQualityValue = 12.5;
        private static double MediumQualityValue = 20.0;
        private static double HighQualityValue = 27.5;

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
            ItemId = itemId;
        }

        public Amulet(string itemId, Level quality)
        {
            ItemId = itemId;
            Quality = quality;
        }
        public Amulet(string itemId, Level quality, string design)
        {
            ItemId = itemId;
            Quality = quality;
            Design = design;

        }
        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }

        public override double GetValue()
        {
            switch (Quality)
            {
                case Level.medium:
                    return MediumQualityValue;
                case Level.low:
                    return LowQualityValue;
                case Level.high:
                    return HighQualityValue;
                default:
                    return 0;
            }

        }
    }

}
