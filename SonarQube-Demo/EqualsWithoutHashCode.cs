namespace SonarQube_Demo;

public class Point
{
    public int X { get; set; }
    public int Y { get; set; }

    public override bool Equals(object obj)
    {
        if (obj is Point p)
        {
            return X == p.X && Y == p.Y;
        }
        return false;
    }
}