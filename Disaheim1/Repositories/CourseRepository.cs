using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim1.Repository
{
    public class CourseRepository
    {
        public List<Course> courses = new List<Course>();

        public void AddCourse(Course course) 
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            Course course = courses.FirstOrDefault(c => c.Name == name);

            if (course != null)
            {
                return course;
            }
            return course;
        }

        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (Course course in courses)
            {
                double value = 0;
                value = Utility.GetValueOfCourse(course);
                
                totalValue += value;
            }

            return totalValue;
        }
    }
}
