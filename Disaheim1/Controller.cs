using Disaheim1.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim1
{
    public class Controller
    {
        public List<Book> Books { get; set; }
       
        public List<Course> Course { get; set; }


        public Controller()
        {
           
            Course = new List<Course>();
        }
      
     
        public void AddToList(Course course)
        {
            Course.Add(course);
        }
    }



}

