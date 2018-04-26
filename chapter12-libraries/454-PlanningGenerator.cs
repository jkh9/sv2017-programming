using System;
using System.IO;

class Agenda
{
    static void Main(string[] args)
    {
        string[] months = {"January", "February", "March", "April",
            "May", "June", "July", "August", "September", "October",
            "November", "December"};
        
        string year;
        string month;

        if (args.Length != 2)
        {
            Console.WriteLine("No parameters specified");
            Console.Write("Enter year: ");
            year = Console.ReadLine();
            Console.Write("Enter month: ");
            month = Console.ReadLine();
        }
        else
        {
            year = args[0];
            month = args[1];
        }
        try
        {
            StreamWriter planning = new StreamWriter("planning.html");

            planning.WriteLine("<html>");
            planning.WriteLine("<head></head>");
            planning.WriteLine("<body>");

            int monthN = Convert.ToInt32(month);
            int yearN = Convert.ToInt32(year);

            DateTime date = new DateTime(yearN, monthN, 1);

            planning.WriteLine("<h1>" + months[date.Month-1] + " " + year);
            planning.WriteLine("<table border>");
            for (int i = 0; i < 31; i++)
            {
                if  (date.Month == monthN)
                    planning.WriteLine("<tr>" + "<td>" + (date.DayOfWeek) +
                        "  "+ date.Day + "</td>" +
                        "<td>   </td></tr>");
                date = date.AddDays(1);
            }

            planning.WriteLine("</table>");
            planning.WriteLine("</body>");
            planning.WriteLine("</html>");

            planning.Close();
            Console.WriteLine("Planning generated");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("Path too long");
        }
        catch (IOException e)
        {
            Console.WriteLine("I/O Error: " + e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Unexpected Error: " + e.Message);
        }
    }
}

