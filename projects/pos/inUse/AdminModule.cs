// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Empty skeleton
// V0.09 20-Dic-2017 Santana & ?: Stats for a day
//       17-Ene-2018 Nacho: Date for each transaction is also saved
// V0.12 02-Mar-2018 Nacho: The "view totals" option now shows the totals ;-)
// V0.13 20-Apr-2018 Nacho: Option 0 to quit. Screen is cleared when entering

using System;
using System.IO;

public class AdminModule
{
    public void Run()
    {
        Console.Clear();
        Console.WriteLine("MANAGEMENT CONSOLE");
        string answer;

        do
        {
            Console.WriteLine();
            Console.WriteLine("1.- View totals for a day");
            Console.WriteLine("0.- Return to main menu");

            Console.Write("Option? ");
            answer = Console.ReadLine().ToLower();

            if (answer == "1")
            {
                string date;
                Console.Write("Enter the date to search (DD/MM/AAAA): ");
                double total = 0;
                date = Console.ReadLine();
                string[] dataFromFile = File.ReadAllLines("pos.dat");
                for (int i = 0; i < dataFromFile.Length; i++)
                {
                    string[] parts = dataFromFile[i].Split('@');
                    string[] dateAndTime = parts[0].Split(' ');
                    if (dateAndTime[0] == date)
                    {
                        Console.WriteLine(dataFromFile[i].Replace("@", "  "));
                        total += Convert.ToDouble(parts[1]);
                    }
                }
                Console.WriteLine("Total: "+total);
            }
        }
        while (answer != "0");

    }
}
