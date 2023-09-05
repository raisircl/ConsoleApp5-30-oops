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

        Box b1= new Box();  
        b1.Length = 5;  
        b1.Breadth = 4;
        b1.Height = 5;  
        Console.WriteLine($"Box dimension is {b1.Length}x{b1.Breadth}x{b1.Height}. Area is {b1.area()}. Volume is {b1.vol()} ");

    }
}
/*
 BankAcc 
AccNo - get/set
AccName  - get/set
AccBalance - ReadOnly
 
Deposit( int amnt)
Withdraw(int amnt)

 */
