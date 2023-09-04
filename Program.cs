using ConsoleApp2;

class Program
{
    static void Main()
    {
        Distance d1=new Distance();

        d1.Feet = 10; // set
        d1.Inch = 5; // set
        Console.WriteLine($"Distance is {d1.Feet} Feet {d1.Inch} Inch.");

        Rect r1=new Rect();
        r1.Length = 5;
        r1.Breadth = 4;
        Console.WriteLine($"Rect1 Dimension is {r1.Length}x{r1.Breadth} and its area is {r1.Area()}");

    }
}