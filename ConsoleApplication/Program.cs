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
            var name = "Jonathan Smith";
            var location = "Hillsboro, OR";

            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from { location}");

            DateTime currentDate = DateTime.Now;
            DateTime christmas = new DateTime(currentDate.Year, 12, 25);

            Console.WriteLine($"Today's date is: {currentDate.ToString("MM/dd/yyyy")}");
            Console.WriteLine($"Days till Christmas: { (christmas - currentDate).Days + 1}");

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            Console.WriteLine("Please provide the width of the window: ");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please provide the height of the window: ");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square meters");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
