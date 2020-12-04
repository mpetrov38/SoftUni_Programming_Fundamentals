using System;

namespace Programming_Fundamentals_Final_Exam___04_April_2020_Group_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            string password = input;
            string subsring = string.Empty;
            while (command!="Done")
            {
                
                string[] cmdArgs = command.Split();
                if (cmdArgs[0] == "TakeOdd")
                {
                    for (int i = 0; i < input.Length; i++)
                    {
                        if (i%2!=0)
                        {
                             subsring+= input[i];
                        }
                    }
                    password = password.Replace(password, subsring);
                    Console.WriteLine(password);
                }
                else if (cmdArgs[0]=="Cut")
                {
                    int index = int.Parse(cmdArgs[1]);
                    int lenght = int.Parse(cmdArgs[2]);
                    //string substring = password.Substring(index, lenght);
                    password = password.Remove(index, lenght);
                    Console.WriteLine(password);
                }
                else if(cmdArgs[0]=="Substitute")
                {
                    string substring = cmdArgs[1];
                    string substitute = cmdArgs[2];
                    if (password.Contains(substring))
                    {
                        password = password.Replace(substring, substitute);
                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
    }
}
