using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class BoxProgram
    {
        static void Main()
        {
            Box box1 = new Box(6, 3, 2);
            Box box2 = new Box(4, 1, 4);
            
            Box b3 = new Box(box2);

            if(box1>box2)
            {
                Console.WriteLine("Boxe1 is big");

            }
            else
            {
                Console.WriteLine("Box2 is Big");
            }

        }
    }
}
