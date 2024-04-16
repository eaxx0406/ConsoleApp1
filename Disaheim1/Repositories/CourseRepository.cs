using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1.Repository
{
    public class CourseRepository
    {
        public List<Course> Courses { get; set; }

        public void AddCourse(Course course) { }

        public Course GetCourse(string name)
        {
            foreach (Course course in Courses)
            {
                if (course.Name == name) { return course; }

            }
            return null;

        }
        public double GetTotalValue()
        {

            double totalValue = 0;

            foreach (Course course in Courses)
            {
                // double value = Utility.GetValueOfAmulet();
                double value = 0;
                totalValue += value;
            }

            return totalValue;

        
        }
            




    }

}      