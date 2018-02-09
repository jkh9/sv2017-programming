/*
Ex.352 - Circle, SetCursorPosition

Use the following expressions to draw a circle 
on screen using SetCursorPosition:

x = xc + r * cos (angle)

y = yc + r * sin angle

*/

using System;

public class DrawCircle
{
    public static void Main()
    {
        int xc = 40;
        int yc = 12;
        double horizScale = 1.8;
        int r = 10;

        for (int angleDegrees = 0; angleDegrees < 360; angleDegrees++) 
        {
            double angleRadians = angleDegrees * Math.PI / 180.0;
            double x = xc +
                horizScale * (r * Math.Cos(angleRadians));
            double y = yc + r * Math.Sin(angleRadians);
            Console.SetCursorPosition(
                (int) x,
                (int) y);
            Console.Write('*');
        }
    }
}
