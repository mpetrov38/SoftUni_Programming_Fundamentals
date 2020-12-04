using System;

namespace BasicSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            int numStudents = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string date = Console.ReadLine();
            
            double ticketPrice = 0.0;

            
            if (date == "Friday")
            {
                switch (type)
                {
                    case "Students":
                        ticketPrice = numStudents * 8.45;
                        break;

                    case "Business":
                        ticketPrice = 10.90;
                        break;
                    case "Regular":
                        ticketPrice = numStudents * 15;
                        break;
                }
            }
            if (date == "Saturday")
            {
                switch (type)
                {
                    case "Students":
                        ticketPrice = numStudents * 9.80;
                        break;

                    case "Business":
                        ticketPrice = 15.60;
                        break;
                    case "Regular":
                        ticketPrice = numStudents * 20;
                        break;
                }
            }
            if (date == "Sunday")
            {
                switch (type)
                {
                    case "Students":
                        ticketPrice = numStudents * 10.46;
                        break;

                    case "Business":
                        ticketPrice = 16;
                        break;
                    case "Regular":
                        ticketPrice = numStudents * 22.50;
                        break;
                }
            }
            if (numStudents >= 30 && type == "Students")
            {
                ticketPrice *= 0.85;

            }
            else if (type == "Business")
            {
                if (numStudents >= 100)
                {
                    numStudents -= 10;
                    ticketPrice = ticketPrice * numStudents;
                }
                else
                {
                    ticketPrice = ticketPrice * numStudents;
                }
            }
            else if (type == "Regular")
            {
                if (numStudents >= 10 && numStudents <= 20)
                {
                    ticketPrice *= 0.95;

                }
            }
            Console.WriteLine($"Total price: {ticketPrice:F2}");
        }
    }
}
