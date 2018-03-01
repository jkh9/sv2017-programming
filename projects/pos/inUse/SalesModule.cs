// 
// Point of sale
//

// Versions:
// V0.01 20-Sep-2017 Lucía Navarro Vélez, Main menu
// V0.02 27-Sep-2017 Javier Herreros, Analyse user input
// V0.03 27-Sep-2017 Brandon Blasco, Main loop
// V0.04 11-Oct-2017 Guillermo Pastor, Switch
// V0.05 10-Nov-2017 Moises+Miguel+Gonzalo: Sell option
// V0.06 29-Nov-2017 Miguel Puerta: Functions
// V0.07 29-Nov-2017 Nacho: Simple file usage
// V0.08 19-Dic-2017 Nacho: Split into classes, most content moved to SalesModule
// V0.09 17-Ene-2018 Nacho: Date for each transaction is also saved
// V0.11 28-Feb-2018 Guillermo Pastor, Pedro Luis Coloma, Renata Pestana, Javier Cases: 
//         Arrays replaced for Lists<struct>

using System;
using System.IO;
using System.Collections.Generic;

public struct Sells
{
    public double dailyTransaction;
    public DateTime date;
}

public class SalesModule
{
    public void Run()
    {
        List<Sells> transaction = new List<Sells>();

        transaction = LoadFromFile(transaction);

        Console.WriteLine("Hint: Enter the amount sold, "
            + "press Enter to get the total, or "
            + "type \"total\" or \"end\"");
        string answer;

        do  // Loop for a whole daily session
        {
            double amount = 0;
            double sum = 0;

            do  // Loop for a single sell
            {
                Console.Write("Amount? ");
                answer = Console.ReadLine();

                try
                {
                    Sells s;
                    amount = Convert.ToDouble(answer);
                    sum += amount;
                    s.dailyTransaction = amount;
                    s.date = DateTime.Now;
                }
                catch (Exception)
                {
                    // Nothing to do if it is not a valid number
                }
            }
            while ((answer != "") && (answer != "total")
                && (answer != "end"));
            Console.WriteLine("Total: " + sum);
            sum = 0;

            if (answer == "total")
            {
                double total = 0;
                for (int i = 0; i < transaction.Count; i++)
                {
                    total += transaction[i].dailyTransaction;
                }
                Console.WriteLine("Daily total: " + total);
            }
        }
        while (answer != "end");

        SaveToFile(transaction);
    }


    public static void Management()
    {
        Console.WriteLine("Soon");
        Console.WriteLine();
    }


    public static List<Sells> LoadFromFile(List<Sells> temp)
    {
        if (File.Exists("pos.dat"))
        {
            string[] dataFromFile = File.ReadAllLines("pos.dat");
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                Sells s;
                s.dailyTransaction = Convert.ToDouble(dataFromFile[i].Split('@')[1]);
                s.date = Convert.ToDateTime(dataFromFile[i].Split('@')[0]);
                temp.Add(s);
            }
            return temp;
        }
        return temp;
    }


    public static void SaveToFile(List<Sells> temp)
    {
        string[] dataToFile = new string[temp.Count];
        for (int i = 0; i < temp.Count; i++)
        {
            dataToFile[i] = temp[i].date + "@" +
                Convert.ToString(temp[i].dailyTransaction);
        }
        File.WriteAllLines("pos.dat", dataToFile);
    }
}
