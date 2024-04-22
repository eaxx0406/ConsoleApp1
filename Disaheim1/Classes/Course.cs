using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Classes
{
    public class Course : IValuable
    {
        public static double CourseHourValue = 875.0;

        public string Name;
        public int DurationInMinutes;

        public Course(string name)
        {
            Name = name;
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public double GetValue()
        {
            double hours = DurationInMinutes / 60;
            int minuts = DurationInMinutes % 60;
            if (minuts > 0)
                hours++;

            return hours * CourseHourValue;

        }

        public virtual string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";

        }
    }
}
