//Daniel Miquel Sirera

using System;

class DateTimeNow2
{
    static void Main(string[] args)
    {
        DateTime now = DateTime.Now;

        Console.WriteLine("Now: "+now.Day.ToString("00")+
            "-"+now.Month.ToString("00")+
            "-"+now.Year+
            "   "+now.Hour.ToString("00")+
            ":"+now.Minute.ToString("00"));
    }
}
