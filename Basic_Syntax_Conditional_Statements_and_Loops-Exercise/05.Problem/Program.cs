using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int counter = 1;

            for (int i = username.Length - 1; i >= 0; i--)
            {

                password += username[i];

            }
            while (true)
            {
                string input = Console.ReadLine();

                if (input != password)
                {

                    Console.WriteLine("Incorrect password. Try again.");
                    counter++;
                    if (counter == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }

                }
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }


            }

        }
    }
}
