using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Utility
    {

        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
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
        }

        public static double GetValueOfCourse(Course course)
        {
            double hours = course.DurationInMinutes / 60 ;
            int OM = course.DurationInMinutes % 60 ;
                if (OM != 0)
                hours++;

            return hours * 875;
        }
        

    
    }
}
