using Disaheim1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Disaheim1.Repositories
{
    public class ValuableRepository : IPersistable
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
                double value = valuable.GetValue();
                totalValue += value;
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }

        public void Save(string filepath = "ValuableRepository.txt")
        {
            List<string> lines = new List<string>();

            foreach (IValuable valuable in valuables)
            {
                if (valuable.GetType() == typeof(Book))
                {
                    Book book = (Book)valuable;
                    string bookLine = $"Book;{book.ItemId};{book.Title};{book.Price}";
                    lines.Add(bookLine);
                }
                else if (valuable.GetType() == typeof(Amulet))
                {
                    Amulet amulet = (Amulet)valuable;
                    string amuletLine = $"Amulet;{amulet.ItemId};{amulet.Design};{amulet.Quality}";
                    lines.Add(amuletLine);
                }
                else if (valuable.GetType() == typeof(Course))
                {
                    Course course = (Course)valuable;
                    string courseLine = $"Course;{course.Name};{course.DurationInMinutes}";
                    lines.Add(courseLine);
                }
            }

            using (StreamWriter outputFile = new StreamWriter( filepath))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
                outputFile.Close();

            }
        }
        public void Load(string filepath = "ValuableRepository.txt")
        {
            //Pass the file path and file name to the StreamReader constructor
            StreamReader sr = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), filepath));
            //Read the first line of text
            string line = sr.ReadLine();
            //Continue to read until you reach end of file
            while (line != null)
            {
                //split ved semikolon
                string[] values = line.Split(';');

                //bøger
                if (values[0] == "Book")
                {
                    string itemId = values[1];
                    string title = values[2];
                    double price = double.Parse(values[3]);
                    valuables.Add(new Book(itemId, title, price));
                }
                else if (values[0] == "Amulet")
                {
                    Level quality = Level.medium;

                    string itemId = values[1];
                    string design = values[2];
                    if (values[3] == "low") { quality = Level.low; }
                    else if (values[3] == "medium") { quality = Level.medium; }
                    else if (values[3] == "high") { quality = Level.high; }

                    valuables.Add(new Amulet(itemId, quality, design));
                }
                else if (values[0] == "Course")
                {
                    string name = values[1];
                    int duration = int.Parse(values[2]);

                    valuables.Add(new Course(name, duration));
                }
                //Read the next line
                line = sr.ReadLine();
            }
            //close the file
            sr.Close();
        }
    }
}
