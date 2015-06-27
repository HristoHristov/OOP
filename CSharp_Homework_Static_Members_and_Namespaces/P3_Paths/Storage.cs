namespace P3_Paths
{
    using System;
    class Storage
    {
        public static void SavePath()
        {            
            System.IO.StreamWriter file = new System.IO.StreamWriter("Read.txt", true);
            foreach (Path3D b in Path3D.Path3DPoints)
            {
            file.WriteLine(b.X + " " + b.Y + " " + b.Z);
            }            
            file.Close();
            Path3D.Path3DPoints.Clear();
        }
        public static void LoadPath()
        {
            System.IO.StreamReader path3D = new System.IO.StreamReader(@"Read.txt");
            Console.WriteLine(path3D.ReadToEnd());
        }
    }
}
