using System;

namespace OperatorsExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            Add();
            Subtract(); 
            Multiply();
            Modulus();
            Division();

            Console.WriteLine("Please enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = AreaOfCircle(radius);
            Console.WriteLine(area);
            Console.WriteLine($"The area of a circle with radius of {radius} is {area}");

        }

        static void Add()
        {
            int x = 5;
            int y = 10;
            x += y;
            Console.WriteLine(x + y);
        } 

        static void Subtract()
        {
            int x = 10;
            int y = 5;
            Console.WriteLine(x - y);
        }

        static void Multiply()
        {
            int x = 10;
            int y = 10;
            Console.Write(x * y);
        }
            
        static void Division()
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}");

        }

        static void Modulus()
        {
            int x = 10;
            int y = 7;
            Console.WriteLine(x % y);
        }
        
        static double AreaOfCircle(double r)
        {
            return Math.PI * Math.Pow(r, 2);
        }
 
    }
}
