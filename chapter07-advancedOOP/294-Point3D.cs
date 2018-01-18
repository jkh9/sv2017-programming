/*
Create a class "Point3D", to represent a point in 3-D space, with coordinates 
X, Y and Z. It must contain the following methods:

Only one constructor, to set the values for X, Y and Z
MoveTo(x,y,z), which will change the coordinates in which the point is.
DistanceTo(Point3D p2), to calculate the distance to another point.
ToString, which will return a string similar to "(2,-7,0)"
And, of course, getters and setters.

The test program must create an array of 5 points, get data for them, and 
calculate (and display) the distance from the first point to the remaining four 
ones.
*/

//Pedro Luis Coloma

using System;

public class PointTest
{
    public static void Main()
    {
        Point3D[] p = new Point3D[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Enter x");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter z");
            double z = Convert.ToDouble(Console.ReadLine());
            p[i] = new Point3D(x, y, z);
        }

        for (int i = 1; i < 5; i++)
        {
            Console.WriteLine(
              "Distance to p1 = " +
              p[0].DistanceTo(p[i]));
        }
    }
}

class Point3D
{
    protected double x;
    protected double y;
    protected double z;

    public Point3D(double x, double y, double z)
    {
        MoveTo(x, y, z);
    }

    public void MoveTo(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }

    public override string ToString()
    {
        return "(" + x + "," + y + "," + z + ")";
    }

    public void SetX(double newX)
    {
        x = newX;
    }

    public double GetX()
    {
        return x;
    }
    public void SetY(double newY)
    {
        y = newY;
    }

    public double GetY()
    {
        return y;
    }

    public void SetZ(double newZ)
    {
        z = newZ;
    }

    public double GetZ()
    {
        return z;
    }

    public double DistanceTo(Point3D p2)
    {
        double DX = this.x - p2.x;
        double DY = this.y - p2.y;
        double DZ = this.z - p2.z;
        return Math.Sqrt(DX*DX + DY*DY + DZ*DZ);
    }
}
