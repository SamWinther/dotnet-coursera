public class Coords
{
    public Coords(double x, double y)
    {
        X = x;
        Y = y;
    }

    private double X { get; set; }
    public double Y { get; set;}

    public override string ToString() => $"({X}, {Y})";
}