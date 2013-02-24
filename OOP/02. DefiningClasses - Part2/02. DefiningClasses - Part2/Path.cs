/*04.Create a class Path to hold a sequence of points in the 3D space. 
* Create a static class PathStorage with static methods to save and 
* load paths from a text file. Use a file format of your choice. */

using System;
using System.Collections.Generic;
using System.IO;

public class Path
{
    public List<Point3D> points;
    public Point3D this[int index]
    {
        get
        {
            return points[index];
        }
    }
    public Path()
    {
        points = new List<Point3D>();        
    }
}
static class PathStorage
{
    private static List<Path> Paths= new List<Path>();
    public static string ToString()
    {
        string result = string.Empty;
        int index = 1;
        foreach (Path path in Paths)
        {
            result += index+" - path\n";
            foreach (Point3D point in path.points)
            {
                result+=point.X + ", " + point.Y + ", " + point.Z+'\n';
            }
            result += '\n';
            index++;
        }
        return result;
    }

    public static void LoadPaths()
    {
        StreamReader reader;
        using (reader = new StreamReader("..\\..\\PathsData.txt"))
        {            
            string line = reader.ReadLine();
            while (line!=null && line!="")
            {
                Path path = new Path();
                while (line != null && line!="")
                {
                    string[] rawCoord = line.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double x = double.Parse(rawCoord[0]),
                        y = double.Parse(rawCoord[1]),
                        z = double.Parse(rawCoord[2]);
                    path.points.Add(new Point3D(x, y, z));
                    line = reader.ReadLine();
                }
                line = reader.ReadLine();
                Paths.Add(path);
            }           
        }
    }

    public static void SavePaths()
    {
        StreamWriter writer;
        using (writer = new StreamWriter("..\\..\\PathsData.txt"))
        {
            foreach (Path path in Paths)
            {
                foreach (Point3D point in path.points)
                {
                    writer.WriteLine(point.X + ", " + point.Y + ", " + point.Z);
                }
                writer.WriteLine();
            }
        }        
    }
}