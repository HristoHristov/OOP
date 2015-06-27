using System;
using P1_Point3D;

class TestingP1
{
    static void Main()
    {
        Point3D point = new Point3D(2, 10, 5);
        Point3D point2 = new Point3D(20, 40, 60);
        Console.WriteLine(point.ToString());
        Console.WriteLine(point2.ToString());
        Console.WriteLine(Point3D.GetStartingPoints);
            
    }
}
