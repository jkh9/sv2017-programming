using System;

public class DrawHeart
{
    public static void Main()
    {
        Console.SetWindowSize(80, 24);
        int xc = 40;
        int yc = 12;
        double horizScale = 1.8;
        double r = 0.75;

        for (int angleDegrees = 0; angleDegrees < 360; angleDegrees++)
        {
            // http://mathworld.wolfram.com/HeartCurve.html
            // x = 16 sin^3t
            // y = 13cost-5cos(2t)-2cos(3t)-cos(4t)
            double angleRadians = angleDegrees * Math.PI / 180.0;
            double x = xc +
                horizScale * (r * 16 * Math.Pow(Math.Sin(angleRadians), 3));
            double y = yc - r * (
                13 * Math.Cos(angleRadians)
                - 5 * Math.Cos(angleRadians * 2)
                - 2 * Math.Cos(angleRadians * 3)
                - Math.Cos(angleRadians * 4)
                );
            Console.SetCursorPosition(
                (int)x,
                (int)y);
            Console.Write('*');
        }
        Console.SetCursorPosition(1, 23);
        Console.ReadLine();
    }
}
