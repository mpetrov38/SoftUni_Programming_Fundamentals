using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            if (age >= 0 && age < 3)
            {
                Console.WriteLine("baby");
            }
            else if (age > 2 && age < 14)
            {
                Console.WriteLine("child");
            }
            else if (age > 13 && age < 20)
            {
                Console.WriteLine("teenager");

            }
            else if (age > 19 && age < 66)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 66)
            {
                Console.WriteLine("elder");
            }

        }
    }
}
