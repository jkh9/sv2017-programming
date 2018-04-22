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
// V0.12 02-Mar-2018 Nacho: Changed List<Sell> to List<Transaction>
// V0.13 20-Apr-2018 Nacho: 
//      Screen is cleared when entering. Title is displayed
//      Total is displayed as big numbers
// V0.14 20-Apr-2018 Guillermo, Brandon, Javier.C: 
//      Minor changes
//      Command "total" display the totals for today

using System;
using System.IO;
using System.Collections.Generic;

public class SalesModule
{
    protected static List<Transaction> transactions;

    public void Run()
    {
        transactions = new List<Transaction>();
        LoadFromFile();
        Console.Clear();
        Console.WriteLine("POINT OF SALE - SELL");
        Console.WriteLine();

        Console.WriteLine("Hint: Enter the amount sold,");
        Console.WriteLine("press Enter to get the total,");
        Console.WriteLine(" or type \"total\" or \"end\"");
        string answer;

        do  // Loop for a whole daily session
        {
            double amount = 0;
            double sum = 0;

            do  // Loop for a single sell
            {
                Console.SetCursorPosition(3, 6);
                String space = new String(' ', 20);
                Console.Write(space);  // Blank last input
                Console.SetCursorPosition(3, 6);
                Console.Write("Amount? ");
                answer = Console.ReadLine();
                
            if (answer.Contains("."))
                answer = answer.Replace(".", ",");

            try
                {
                    amount = Convert.ToDouble(answer);
                    sum += amount;
                    DateTime d = DateTime.Now;
                    transactions.Add(new Transaction(d, amount));
                    BigNumbers.ShowAmount(sum.ToString("N2"), 35, 4);
                }
                catch (Exception) { /* Nothing to do if it is not a valid number */ }
            }
            while ((answer != "") && (answer != "total")
                && (answer != "end"));
            Console.WriteLine();

            // Position in Screen -> 8

            string text = "Total: " + sum;
            Draw(text, 8);

            sum = 0;

            if (answer == "total")
                DisplayTotal(DateTime.Now); 
        }
        while (answer != "end");

        SaveToFile();
    }

    // Position in Screen -> 9

    private static void GlobalTotal()
    {
        double total = 0;
        for (int i = 0; i < transactions.Count; i++)
            total += transactions[i].GetAmount();

        string text = "Global total: " + total;

        Draw(text, 9);
    }

    private static void DisplayTotal(DateTime date)
    {
        double total = 0;
        for (int i = 0; i < transactions.Count; i++)
            if (date.Day == transactions[i].GetDate().Day
                && date.Month == transactions[i].GetDate().Month
                && date.Year == transactions[i].GetDate().Year)
                total += transactions[i].GetAmount();

        string text = "Daily total: " + total;

        Draw(text, 9);
    }

    private static void Draw(string text, int position)
    {
        Console.SetCursorPosition(0, position);
        String reset = new String(' ', (Console.WindowWidth / 2) - text.Length - 10);
        Console.WriteLine(text + reset);
    }


    public static void Management()
    {
        Console.WriteLine("Soon");
        Console.WriteLine();
    }


    public static void LoadFromFile()
    {
        if (File.Exists("pos.dat"))
        {
            string[] dataFromFile = File.ReadAllLines("pos.dat");
            StreamReader file = new StreamReader("pos.dat");
            string line = file.ReadLine();
            while (line != null)
            {
                DateTime d = Convert.ToDateTime(line.Split('@')[0]);
                double amount = Convert.ToDouble(line.Split('@')[1]);
                transactions.Add(new Transaction(d, amount));
                line = file.ReadLine();
            }
            file.Close();
        }
    }


    public static void SaveToFile()
    {
        StreamWriter file = new StreamWriter("pos.dat");
        foreach (Transaction t in transactions)
        {
            file.WriteLine(t.GetDate() + "@" +
                t.GetAmount());
        }
        file.Close();
    }
}
