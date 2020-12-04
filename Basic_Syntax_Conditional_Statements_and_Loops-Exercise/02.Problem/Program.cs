using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                if (number % 10 == 0 && number % 2 == 0)
                {
                    Console.WriteLine("The number is divisible by 10");
                    return;
                }
                else if (number % 3 == 0)
                {

                    if (number % 3 == 0 && number % 2 == 0)
                    {
                        Console.WriteLine("The number is divisible by 6");
                        return;
                    }
                    Console.WriteLine("The number is divisible by 3");
                }

                Console.WriteLine("The number is divisible by 2");
            }

            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
