namespace ConsoleApp1;

using static System.Math;

public record Circle(double Radius)
{
    public double Circumference => Radius * PI;

    public double Area => PI * Square(Radius);

    private static double Square(double d) => Pow(d, 2);
}