using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Repository
{
    public class MerchandiseRepository
    {
        public List<Merchandise> merchandises = new List<Merchandise>();

        public void AddMerchandise(Merchandise merchandise)
        {
            this.merchandises.Add(merchandise);
        }
        public Merchandise GetMerchandise(string itemId)
        {
            Merchandise merchandise = merchandises.FirstOrDefault(c => c.ItemId == itemId);

            if (merchandise != null)
            {
                return merchandise;
            }
            return merchandise;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Merchandise merchandise in merchandises)
            {
                double value = Utility.GetValueofMerchandise(merchandise);
                totalValue += value;
            }
            return totalValue;
         

        }





    }
}
