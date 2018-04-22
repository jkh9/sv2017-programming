// 
// Point of sale
//

// Versions:
// V0.08 19-Dic-2017 Nacho: Empty skeleton
// V0.09 20-Dic-2017 Santana & ?: Stats for a day
//       17-Ene-2018 Nacho: Date for each transaction is also saved
// V0.12 02-Mar-2018 Nacho: The "view totals" option now shows the totals ;-)
// V0.13 20-Apr-2018 Nacho: Option 0 to quit. Screen is cleared when entering
// V0.14 20-Apr-2018 
//      Cesar Martín: Option 2 to view totals for a month
//      Jose Vilaplana: Option 3 to view totals for a month
//      Miguel García: Today as a default.

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
            ShowMenu();
            Console.Write("Option? ");
            answer = Console.ReadLine().ToLower();
            string date = "";
            if (answer == "1") //Total a day
            {
                ShowTotalsForADay(date);
            }
        

            if (answer == "2") //Total a month
            {
                ShowTotalsForAMonth(date, answer);
            }

            if (answer == "3") //Total a day in a moth
            {
                ShowPartialsForAMonth(date, answer);
            }
        }
        while (answer != "0");

    }
    public static string GetDate(string answer, ref string date)
    {
        switch(answer)
        {
            case "1":
            Console.Write("Enter the date to search or press enter"
                +"for today (DD/MM/AAAA): ");
            date = Console.ReadLine();
                return date;
                

            case "2":
            case "3":
                Console.Write("Enter the date to search (MM/AAAA): ");
                date = Console.ReadLine();
                return date;

            default:
                return "";
                
        }
    }
    public  void ShowMenu()
    {
        Console.WriteLine();
        Console.WriteLine("1.- View totals for a day");
        Console.WriteLine("2.- View totals for a month");
        Console.WriteLine("3.- View totals for a month, each day");
        Console.WriteLine("0.- Return to main menu");
    }

    public void ShowTotalsForADay(string date)
    {
        double total = 0;
        Console.Write("Enter date (DD/MM/YYYY): ");
        date = Console.ReadLine();
        string[] dataFromFile = File.ReadAllLines("pos.dat");
        {
            for (int i = 0; i < dataFromFile.Length; i++)
            {
                string[] parts = dataFromFile[i].Split('@');
                string[] dateAndTime = parts[0].Split(' ');
                if (dateAndTime[0] == date)
                {
                    Console.WriteLine(dataFromFile[i].Replace("@", "  "));
                    total += Convert.ToDouble(parts[1]);
                }
                else if (date == "")
                {
                    Console.WriteLine(dataFromFile[i].Replace("@", "  "));
                    total += Convert.ToDouble(parts[1]);
                }
            }
        }
        Console.WriteLine("Total: " + total);
    }
    public void ShowTotalsForAMonth(string date, string answer)
    {
        GetDate(answer, ref date);
        double totalM = 0;
        string[] dataFromFile = File.ReadAllLines("pos.dat");
        for (int i = 0; i < dataFromFile.Length; i++)
        {
            string[] parts = dataFromFile[i].Split('@');
            string[] dateAndTime = parts[0].Split(' ');
            string[] dateSplitted = dateAndTime[0].Split('/');
            if (dateSplitted[1] + "/" + dateSplitted[2] == date)
            {
                Console.WriteLine(dataFromFile[i].Replace("@", "  "));
                totalM += Convert.ToDouble(parts[1]);
            }
        }
        Console.WriteLine("Total month: " + totalM);
    }
    
    public void ShowPartialsForAMonth(string date, string answer)
    {
        GetDate(answer, ref date);
        double total = 0;
        double day = 0;
        string[] dataFromFile = File.ReadAllLines("pos.dat");
        for (int i = 0; i < dataFromFile.Length; i++)
        {
            string[] parts = dataFromFile[i].Split('@');
            string[] dateAndTime = parts[0].Split(' ');
            string[] dateSplitted = dateAndTime[0].Split('/');

            if (dateSplitted[1] + "/" + dateSplitted[2] == date)
            {

                Console.WriteLine(dataFromFile[i].Replace("@", "  "));
                total += Convert.ToDouble(parts[1]);
                day = Convert.ToDouble(parts[1]);
                Console.WriteLine(dateSplitted[0] + " " + day);
            }
        }
        Console.WriteLine("Total: " + total);
    }
}
