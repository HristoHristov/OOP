namespace P2_Distance_Calculator
{
    using System;

    class Coordinates
    {
        public Coordinates(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }
        public double X{ get; set; }
        public double Y { get; set; }
        public double Z{ get; set; }
    }
}
