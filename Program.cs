using System;

namespace OperatorsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Add();
            Subtract(); 
            Multiply();
            Modulus();
            Division();
            


        }

        static void Add()
        {
            int x = 5;
            int y = 10;
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
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

        }

        static void Modulus()
        {
            int x = 10;
            int y = 7;
            Console.WriteLine(x % y);
        }

    }
}
