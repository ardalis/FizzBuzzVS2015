using FizzBuzzConsole.Model;
using System;

namespace FizzBuzzConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = 20;
            var fizzBuzzService = new FizzBuzzService();
            for (int i = 1; i <= maxNumber; ++i)
            {
                Console.WriteLine(fizzBuzzService.FormatNumber(i));
            }
            Console.ReadLine();
        }
    }
}
