using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to the Grand Circus Room Detail Generator!");
            string answer = "y";

            while (answer == "y" || answer == "Y")
            {
                Console.Write("Enter Length: ");
                string length = Console.ReadLine();
                double lengthNum = double.Parse(length);

                Console.Write("Enter Width: ");
                string width = Console.ReadLine();
                double widthNum = double.Parse(width);

                Console.Write("Enter Height: " );
                string height = Console.ReadLine();
                double heightNum = double.Parse(height);
                
                double area = (lengthNum * widthNum);
                double perimeter = ((2 * lengthNum) + (2 * widthNum));
                double volume = (lengthNum * widthNum * heightNum);
                
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Perimeter: " + perimeter);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("Continue? (y/n) ");
                answer = Console.ReadLine();
            }
            
            

            

            
        
        
        
        
        
        
        
        
        }
    }
}
