using Disaheim1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim1.Repositories
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();


        public void AddValuable(IValuable valuable)
        {
            this.valuables.Add(valuable);
        }

        public IValuable GetValuable(string Id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable.GetType() == typeof(Merchandise) || valuable.GetType() == typeof(Book) || valuable.GetType() == typeof(Amulet))
                {
                    Merchandise merchandise = (Merchandise)valuable;
                    if (merchandise.ItemId == Id)
                    {
                        return merchandise;
                    } 
                }
                else if (valuable.GetType() == typeof(Course))
                {
                    Course course = (Course)valuable;
                    if (course.Name == Id)
                    {
                        return course;
                    }
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (IValuable valuable in valuables)
            {
                double value =  valuable.GetValue();
                totalValue += value;
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }
    }
}
