using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Utility
    {
        private static double LowQualityValue = 12.5;
        private static double MediumQualityValue = 20.0;
        private static double HighQualityValue = 27.5;
        private static double CourseHourValue = 875.0;
        public static double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public static double GetValueOfAmulet(Amulet amulet)
        {
            switch (amulet.Quality)
            {
                case Level.medium:
                    return Utility.MediumQualityValue;
                case Level.low:
                    return Utility.LowQualityValue;
                case Level.high:
                    return Utility.HighQualityValue;
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

            return (hours * Utility.CourseHourValue);
        }
        
        public static double GetValueofMerchandise(Merchandise merchandise) 
        {
            Book book = null;
            Amulet amulet = null;

            if (merchandise.GetType() == typeof(Amulet)) 
            {
                amulet = (Amulet)merchandise;
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

            else if (merchandise.GetType() == typeof(Book)) 
            {
                book = (Book)merchandise;
                Console.WriteLine("bog");
                return book.Price;
            }

            return 0;
        }


    }
}
