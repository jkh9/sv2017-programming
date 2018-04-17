using System;

class DateTimeNow3
{
    static void Main(string[] args)
    { 
        string[] month = { "January", "February", "March", "April", "May",
            "June", "July", "August", "September", "October",
            "November", "December" };

        Console.SetCursorPosition(0, 0);
        Console.Write(DateTime.Now.Day.ToString("00") + "-" + 
            month[DateTime.Now.Month - 1] + "-" + 
            DateTime.Now.Year.ToString("00"));
        Console.WriteLine(" " + DateTime.Now.Hour + ":" 
            + DateTime.Now.Minute + ":" + DateTime.Now.Second);
    }
}
