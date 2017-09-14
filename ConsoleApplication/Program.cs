using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Bryan McNeil");
            Console.WriteLine("Idaho");
            String name = "Bryan";
            Console.WriteLine("Hello " + name);
            Console.WriteLine(DateTime.Today);
            DateTime Christmas = new DateTime(2017, 12, 25);
            DateTime today = DateTime.Today;
            Console.WriteLine("There is " + ((Christmas - today).Days - 1) + " days before Christmas");
        }
    }
}
