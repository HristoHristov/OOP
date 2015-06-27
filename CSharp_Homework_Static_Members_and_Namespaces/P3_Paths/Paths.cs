using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P3_Paths
{
    class Paths
    {
        static void Main(string[] args)
        {
            Path3D pointA = new Path3D(1, 1, 3);
            Path3D pointB = new Path3D(2, 4, 6);
            Storage.SavePath();

            Path3D pointc = new Path3D(5, 1, 3);
            Path3D pointv = new Path3D(9, 4, 6);
            Storage.SavePath();

            Storage.LoadPath();


            
        }
    }
}
