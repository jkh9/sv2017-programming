// 
// Point of sale
//

// Versions:
// V0.01 20-Sep-2017 Lucía Navarro Vélez, Main menu
// V0.02 27-Sep-2017 Javier Herreros, Analyse user input
// V0.03 27-Sep-2017 Brandon Blasco, Main loop
// V0.04 11-Oct-2017 Guillermo Pastor, Switch
// V0.05 10-Nov-2017 Moises+Miguel+Gonzalo: Sell option


using System;
public class PointOfSale
{
    public static void Main()
    {
        double[] dailyTransactions = new double[1000];
        int amountOfTrasactions = 0;
        int option;

        do
        {
            Console.WriteLine("1 - Sell");
            Console.WriteLine("2 - Management");
            Console.WriteLine("0 - Exit");
            Console.WriteLine();

            Console.WriteLine("Choose one option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
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
                                dailyTransactions[amountOfTrasactions] = amount;
                                amountOfTrasactions++;
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
                            for (int i = 0; i < amountOfTrasactions; i++)
                            {
                                total += dailyTransactions[i];
                            }
                            Console.WriteLine("Daily total: "+total);
                        }
                    }
                    while (answer != "end") ;
                    break;
                case 2:
                    Console.WriteLine("Soon");
                    Console.WriteLine();
                    break;
                case 0:
                    Console.WriteLine("Bye!");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong option");
                    Console.WriteLine();
                    break;
            }
        }
        while (option != 0);
    }
}
