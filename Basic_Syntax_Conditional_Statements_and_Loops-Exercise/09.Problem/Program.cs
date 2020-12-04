using System;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {

            double money = double.Parse(Console.ReadLine());
            int studentCount = int.Parse(Console.ReadLine());
            double lighSaberP = double.Parse(Console.ReadLine());
            double robeP = double.Parse(Console.ReadLine());
            double beltP = double.Parse(Console.ReadLine());
            int belts = studentCount / 6;
            double lightSaberTotal = Math.Ceiling(studentCount * 1.1);


            double total = (lightSaberTotal * lighSaberP) + robeP *
(studentCount) + beltP * (studentCount - belts);


            if (total <= money)
            {
                Console.WriteLine($"The money is enough - it would cost { total:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {total - money:F2}lv more. ");
            }


        }
    }
}


