/*
Use the following expressions to draw a circle on screen 
using and array and dumping it to file with WriteAllLines:

x = xc + r * cos (angle)

y = yc + r * sin angle
*/

// Javier Saorín Vidal
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        double r = 10;
        double xCenter = 40;
        double yCenter = 12;

        char[,] screen = new char[80,24];
        for(int col=0; col<80; col++)
            for(int row=0; row<24; row++)
                screen[col, row] = ' ';

        for (int i = 0; i < 360; i++)
        {
            double angleRad = i * Math.PI / 180.0;
            double x = (xCenter) +  2 * (r * Math.Cos(angleRad));
            double y = (yCenter) + (r * Math.Sin(angleRad));
            screen[(int) x, (int) y] = '*';
        }

        List<string> dataToFile = new List<string>();
        for (int i = 0; i < 24; i++)
        {
            string line = "";
            for (int j = 0; j < 80; j++)
            {
                line += screen[j, i];
            }
            dataToFile.Add(line);
        }


        File.WriteAllLines("circle.txt", dataToFile);
    }
}
