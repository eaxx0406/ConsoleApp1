using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Course
    {
        public string Name;
        public int DurationInMinutes;

        public Course (string name)
        { 
            Name = name; 
        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }
        //Expected:<Name: How to Ying-Yang, Duration in Minutes: 413>. Actual:<Course: How to Ying-Yang, DurationInMinutes: 413>
        public virtual string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}";

        }
    }
}
