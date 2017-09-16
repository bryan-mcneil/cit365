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
            Console.WriteLine("There is " + ((Christmas - today).Days) + " days before Christmas");
            String mystring = String.Empty;

            double width, height, woodLength, glassArea;
            string widthString, heightString;
            Console.WriteLine("Please enter a width: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Please enter a height: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square metres");            Console.ReadLine();
        }
    }
}
