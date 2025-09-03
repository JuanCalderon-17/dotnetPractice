    using System;

namespace dotnetPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            -------1 EXERCISE

            
            1- Write a program to count how many numbers
            between 1 and 100 are divisible by 3 with no remainder.
            Display the count on the console. 
            int conteo = 0;
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    conteo++;
                }

            }
            Console.WriteLine(conteo);
            

            -------2 EXERCISE

            int number = 0;
            var validation = "";
            var sum = 0;

            while (validation != "ok")
            {
                Console.Write("Write \"ok\" to exit or a number to add: ");
                validation = Console.ReadLine();
                if (validation == "ok")
                {
                    break;
                }

                bool booleano = int.TryParse(validation, out number);

                if (booleano)
                {
                    sum += number;
                }
            }

            Console.Write("The sum is " + sum);

             */
        }
    }
}