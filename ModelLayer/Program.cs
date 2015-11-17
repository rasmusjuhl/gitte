using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer.DAL;

namespace ModelLayer
{
    public class Program
    {
        static void Main(string[] args)
        {
            var db = new SystemContext();
            Console.WriteLine(db.Database.Connection.ConnectionString);
            Console.ReadLine();
        }
    }
}
