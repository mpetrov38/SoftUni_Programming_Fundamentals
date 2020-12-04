using System;

namespace Programming_Fundamentals_Final_Exam___04_April_2020_Group_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringToManipulate = Console.ReadLine();
            string[] input = Console.ReadLine().Split(">>>");
            while (input[0]!="Generate")
            {
                string command = input[0];
                if (command=="Contains")
                {
                    string subString = input[1];
                    if (stringToManipulate.Contains(subString))
                    {
                        Console.WriteLine($"{stringToManipulate} contains {subString}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command=="Flip")
                {
                    string toWhere = input[1];
                    int startIndex = int.Parse(input[2]);
                    int endIndex = int.Parse(input[3]);
                    int length = endIndex - startIndex;
                    if (toWhere=="Upper")
                    {
                        string oldString = stringToManipulate.Substring(startIndex, length);
                        string toUpper = stringToManipulate.Substring(startIndex, length).ToUpper();
                        stringToManipulate = stringToManipulate.Replace(oldString, toUpper);
                        
                        Console.WriteLine(stringToManipulate);
                    }
                    else if (toWhere=="Lower")
                    {
                        string oldString = stringToManipulate.Substring(startIndex, length);
                        string toLower = stringToManipulate.Substring(startIndex, length).ToLower();
                        stringToManipulate = stringToManipulate.Replace(oldString, toLower);
                        Console.WriteLine(stringToManipulate);
                    }
                    
                    
                }
                else if (command=="Slice")
                {
                    int startIndex = int.Parse(input[1]);
                    int endIndex = int.Parse(input[2]);
                    int count = endIndex - startIndex;
                    
                    stringToManipulate =stringToManipulate.Remove(startIndex,count);
                    Console.WriteLine(stringToManipulate);

                }
                input = Console.ReadLine().Split(">>>");
            }
            Console.WriteLine($"Your activation key is: {stringToManipulate}");

        }
    }
}
