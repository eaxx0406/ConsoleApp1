using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Repository
{
    public class  AmuletRepository
    {
        public List<Amulet> amulets = new List<Amulet>();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public  Amulet GetAmulet(string itemid)
        {
            Amulet amulet = amulets.FirstOrDefault(c => c.ItemId == itemid);

            if (amulet != null)
            {
                return amulet;
            }
            return amulet;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Amulet amulet in amulets)
            {
                // double value = Utility.GetValueOfAmulet();
                double value = 0;
                totalValue += value;
            }

            return totalValue;
        }
    }
}

