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

using System;
using System.IO;

public class SalesModule
{
    public void Run()
    {
        double[] dailyTransactions = new double[1000];
        int amountOfTransactions = 0;

        LoadFromFile(ref dailyTransactions,
            ref amountOfTransactions);

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
                    amount = Convert.ToDouble(answer);
                    sum += amount;
                    dailyTransactions[amountOfTransactions] = amount;
                    amountOfTransactions++;
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

            if ((answer == "total") || (answer == "total"))
            {
                double total = 0;
                for (int i = 0; i < amountOfTransactions; i++)
                {
                    total += dailyTransactions[i];
                }
                Console.WriteLine("Daily total: " + total);
            }
        }
        while (answer != "end");

        SaveToFile(dailyTransactions, amountOfTransactions);
    }


    public static void Management()
    {
        Console.WriteLine("Soon");
        Console.WriteLine();
    }


    public static void LoadFromFile(ref double[] dailyTransactions,
        ref int amountOfTransactions)
    {
        if (File.Exists("pos.dat"))
        {
            string[] dataFromFile = File.ReadAllLines("pos.dat");
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                dailyTransactions[i] = Convert.ToDouble(dataFromFile[i]);
            }
            amountOfTransactions = dataFromFile.Length;
        }
    }


    public static void SaveToFile(
        double[] dailyTransactions,
        int amountOfTransactions)
    {
        string[] dataToFile = new string[amountOfTransactions];
        for (int i = 0; i < amountOfTransactions; i++)
        {
            dataToFile[i] = Convert.ToString(dailyTransactions[i]);
        }
        File.WriteAllLines("pos.dat", dataToFile);
    }
}
