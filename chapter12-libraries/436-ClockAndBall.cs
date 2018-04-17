// Clock and ball

using System;

public class DateTest
{
    public static void Main()
    {
        int x=40, y=12;
        int maxX=0, minX=79;
        int maxY=0, minY=24;
        int incrX=1, incrY=1;
        
        bool exit = false;
        do
        {
            // Update and display clock
            DateTime date = DateTime.Now;

            Console.Clear();
            Console.SetCursorPosition(71, 0);
            Console.Write(
                date.Hour.ToString("00") + ":" +
                date.Minute.ToString("00") + ":" + 
                date.Second.ToString("00"));

            // Update and display ball
            Console.SetCursorPosition(x, y);
            Console.Write("O");
            
            y += incrY;
            if ((y == maxY) || (y == minY))
                incrY = -incrY;
            
            x += incrX;
            if ((x == maxX) || (x == minX))
                incrX = -incrX;
            
            // And wait till next frame
            System.Threading.Thread.Sleep(200);
            
            // And let's check if we must exit
            if (Console.KeyAvailable)
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    exit = true;
        }
        while (!exit);
    }
}
