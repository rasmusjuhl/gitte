using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Location loc = new Location("9000", "Aalborg");
            Console.WriteLine(loc.ZipCode + " " + loc.City);
            Console.ReadLine();



        }
    }
}
