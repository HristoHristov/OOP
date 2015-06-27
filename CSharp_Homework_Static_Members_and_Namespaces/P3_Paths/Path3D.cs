using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P3_Paths
{
    class Path3D
    {
        private static List<Path3D> path3DPoints = new List<Path3D>();
        private double x;
        private double y;
        private double z;

        public Path3D(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            Path3D.path3DPoints.Add(this);
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return this.z;}
            set { this.z = value; }
        }
        public static IList<Path3D> Path3DPoints
        {
            get { return Path3D.path3DPoints; }
            set { Path3D.Path3DPoints = value; }
        }        
    }
}
