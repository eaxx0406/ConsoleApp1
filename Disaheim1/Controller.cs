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
        public List<Amulet> Amulets { get; set; }
        public List<Course> Course { get; set; }


        public Controller()
        {
            Books = new List<Book>();
            Amulets = new List<Amulet>();
            Course = new List<Course>();
        }

        public void AddToList(Book book)
        {
            Books.Add(book);
        }

        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
        public void AddToList(Course course)
        {
            Course.Add(course);
        }
    }



}

