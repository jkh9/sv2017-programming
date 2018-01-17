// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Empty skeleton
// V0.09 20-Dic-2017 Santana & ?: Stats for a day
//       17-Ene-2018 Nacho: Date for each transaction is also saved

using System;
using System.IO;

public class AdminModule
{
    public void Run()
    {
        Console.WriteLine("1.- View totals for a day");
        Console.WriteLine("end.- Return to main menu");
    
        string answer;

        do  // Loop for a whole daily session
        {
            Console.Write("Option? ");
            answer = Console.ReadLine().ToLower();

            if (answer == "1")
            {
                string date;
                Console.Write("Enter the date to search (DD/MM/AAAA): ");
                date = Console.ReadLine();
                string[] dataFromFile = File.ReadAllLines("pos.dat");
                for (int i = 0; i < dataFromFile.Length; i++)
                {
                    string[] fields = dataFromFile[i].Split(' ');
                    if (fields[0] == date)
                        Console.WriteLine(dataFromFile[i].Replace("@", "  "));

                }
            }
        }
        while (answer != "end");

    }
}
