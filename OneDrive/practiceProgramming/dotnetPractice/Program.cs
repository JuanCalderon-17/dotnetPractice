using System;

namespace dotnetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            foreach (var numero in numbers)
            {
                Console.WriteLine(numero);
            }
        }
    }
}