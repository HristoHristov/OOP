using System;
using P2_Distance_Calculator;
class TestingP2
{
    static void Main(string[] args)
    {
        Coordinates pointA = new Coordinates(1, 1, 0);
        Coordinates pointB = new Coordinates(4, 5, 0);
        Console.WriteLine(DistanceTwoPoints.CalculateDistance(pointA, pointB));        
    }
}
