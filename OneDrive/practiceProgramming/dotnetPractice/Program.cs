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

            


            //ite a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
            // For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.



            -------2 EXERCISE 
            int number = 0;
            Console.Write("Enter a number: ");
            bool userInput = int.TryParse(Console.ReadLine(), out number);
            var result = 1;

            if (userInput)
            {
                for (int i = 1; i <= number; i++)
                {
                    result = result * i;
                }
            }
            else
            {
                Console.WriteLine("Write an acual integer");
            }
            Console.WriteLine($"{number}! = {result}");
        
        */

        }
        
    }
}