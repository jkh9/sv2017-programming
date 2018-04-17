// Javier Saorín Vidal

using System;

public class DateTest
{
    public static void Main()
    {
        bool exit = false;
        do
        {
            DateTime date = DateTime.Now;

            Console.SetCursorPosition(71, 0);
            Console.WriteLine(
                date.Hour.ToString("00") + ":" +
                date.Minute.ToString("00") + ":" + 
                date.Second.ToString("00"));

            System.Threading.Thread.Sleep(1000);
        }
        while (!exit);
    }
}
