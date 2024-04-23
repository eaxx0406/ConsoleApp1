using Disaheim1.Classes;
using Disaheim1.Repositories;

namespace Disaheim1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Hello, World!");


            Amulet a1 = new Amulet("No. A1");

            Amulet a2 = new Amulet("No. A2", Level.high);

            Amulet a3 = new Amulet("No. A3", Level.low, "Modern");

            Console.WriteLine(a3.ToString());
        }
    }
}
