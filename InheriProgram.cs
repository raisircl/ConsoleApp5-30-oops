using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class InheriProgram
    {
        static void Main()
        {
            //Quardilateral q1=new Quardilateral(1,2,3,4);
            //Console.WriteLine(q1.ToString());
            Square s1=new Square(5);
            Console.WriteLine($"{s1.ToString()} and area is {s1.Area()}");

        }
    }
}
