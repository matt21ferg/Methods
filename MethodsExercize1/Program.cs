using System;

namespace MethodsExercize1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("what is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite Animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Hi, my name is {name} my favorite color is {color}.");
            Console.WriteLine($"My favorite band is {band} and my favorite animal is {animal}.");


        }
        public static int Add(int num1, int num2)
        {
            int add = num1 + num2;
            return add;
        }
        public static int multiply(int x, int y)
        {
        int Mult = x * y;
            return Mult;



        }
        

           
    }
}
