namespace P2_Distance_Calculator
{
    using System;

    static class DistanceTwoPoints
    {
        private static double distance;       
        public static double CalculateDistance(Coordinates point1, Coordinates point2)
        {
            double xd = point2.X - point1.X;
            double yd = point2.Y - point1.Y;
            double zd = point2.Z - point1.Z;
            DistanceTwoPoints.distance = (xd * xd) + (yd * yd) + (zd * zd);
            DistanceTwoPoints.distance = Math.Sqrt(DistanceTwoPoints.distance);
            return DistanceTwoPoints.distance;
        }        
    }
}
