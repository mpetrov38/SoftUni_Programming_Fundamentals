using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Programming_Fundamentals_Final_Exam_Retake___15_August_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"@#+(?<string>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+";
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Regex regex = new Regex(pattern);
                bool change = false;
                string tupchenka = string.Empty;

                Match matches = regex.Match(barcode);

                if (matches.Success)
                {
                    string product = matches.Groups["string"].Value;
                    for (int j = 0; j < product.Length; j++)
                    {
                        if (char.IsDigit(product[j]))
                        {
                            tupchenka += product[j];
                            change = true;
                        }
                    }
                    if (change)
                    {
                        Console.WriteLine($"Product group: {tupchenka}");
                       
                       
                    }
                    else
                    {
                        Console.WriteLine($"Product group: 00");
                    }

                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }

        }
    }
}
