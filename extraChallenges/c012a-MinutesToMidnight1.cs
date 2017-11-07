//Almudena Lopez Sanchez
//Challenge 12: minutes to midnight
using System;
public class Challenge12
{
    public static void Main()
    {
        string enterHour;
        int min;
        do
        {
            enterHour = Console.ReadLine();
            if (enterHour != "00:00")
            {
                string[] hours = enterHour.Split(':');
                min = Convert.ToInt32(hours[1]);
                min += Convert.ToInt32(hours[0]) * 60;
                Console.WriteLine((24*60)-min);
            }
        }
        while(enterHour != "00:00");
    }
}
