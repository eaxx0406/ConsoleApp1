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
        public List<Book> books = new List<Book>();
        public List<Amulet> amulets = new List<Amulet>();
        public List<Course> Course = new List<Course>();


        public Controller()
        {
            List<Book> Books = new List<Book>();
            List<Amulet> Amulets = new List<Amulet>();
            List<Course> Courses = new List<Course>();
    }


        public void AddAmulet(Book book)
        {
            books.Add(book);
        }
        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }
        public void AddAmulet(Course course)
        {
            Course.Add(course);
        }
    }



}

