using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IShape
    {
        void Area();
    }
    interface IGreet
    {
        void Msg();
    }
    class DishaRect : IShape, IGreet
    {
        public void Area()
        {
            Console.WriteLine("Area of Rect");
        }

        public void Msg()
        {
            Console.WriteLine("Hello User");    
        }
    }
    class Circle : IShape
    {
        public void Area()
        {
            Console.WriteLine("Area of Circle");
        }
    }
    class IshapeProgram
    {
       static void Main() 
        {
            IShape shape;
            DishaRect rect= new DishaRect();
           
            shape = rect;
            shape.Area();

            IGreet greet = rect;
            greet.Msg();


            shape= new Circle();    
            shape.Area();   

        }
    }
}
/*
 interface having some functions without body.
it is just like pure abstract class of c++
it sign a contract with a class that is "Interface said i will provide you 
declarations and you will (class) write the definitions"

 
 */