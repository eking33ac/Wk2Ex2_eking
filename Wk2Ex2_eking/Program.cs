using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk2Ex2_eking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Double variable declarations for length, width,
                 area, and permimeter of a rectangle */
            double length = 0;
            double width = 0;
            double area = 0;
            double perimeter = 0;
            
            
            // Output statement prompting user to input the length of a rectangle
            Console.Write("Enter the length of the rectangle: ");
            // Collect user input for length of rectangle
            length = double.Parse(Console.ReadLine());
            
            // Output statement prompting user to input the width of a rectangle
            Console.Write("Enter the width of the rectangle: ");
            // Collect user input for width of rectangle
            width = double.Parse(Console.ReadLine());
            
            
            // Calculate area of rectangle
            area = length * width;
            
            // Calculate perimeter of rectangle
            perimeter = (length * 2) + (width * 2);
            
            // Have a blank line between inputs and results
            Console.WriteLine();
            
            // Output statement for Results Title
            Console.WriteLine("Results:");
            
            // Output statement for  Area of rectangle
            Console.WriteLine($"Area of the rectangle: {area}");
            
            // Output statement for perimeter of rectangle
            Console.WriteLine($"Perimeter of the rectangle: {perimeter}");
            
            
            // Pause screen for user to read output
            Console.ReadLine();
        }
    }
}
