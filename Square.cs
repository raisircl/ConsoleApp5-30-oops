using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Square:MyRect
    {
        public Square():base() 
        { 
        }
        public Square(int side):base(side,side)
        {

        }
        public override int Area()
        {
            return Side1 * Side1;
        }
        public override string ToString()
        {
            return $"Square Dimension is {Side1}";
        }
    }
}
