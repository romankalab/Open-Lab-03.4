using System;
using EvenOrOdd;

namespace Open_Lab_03._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Numbers numbers = new Numbers();
            string result = numbers.EvenOrOdd(number);
            Console.WriteLine($"The number is {result}.");
        }
    }
}
