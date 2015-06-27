namespace P1_Point3D
{
    using System;
    class Point3D
    {
        private double pointX;
        private double pointY;
        private double pointZ;       
        private static readonly string coordinates= "{0,0,0}";

        public Point3D(double X, double Y, double Z)
        {
            this.pointX = X;            
            this.pointY = Y;            
            this.pointZ = Z;            
        }

        public static string GetStartingPoints
        {
            get { return Point3D.coordinates; }
        }
        public override string ToString()
        {
            return String.Format("Point coorinate: X: {0}, Y: {1}, Z: {2}", this.pointX, this.pointY, this.pointZ);
        }
    }   
}
