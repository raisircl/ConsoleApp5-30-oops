using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MyRect:Quardilateral
    {
        public MyRect():base()
        {
                
        }
        public  MyRect(int l, int b):base(l,b,l,b)
        {

        }
        public virtual int Area()
        {
            return Side1 * Side2;
        }
        public override string ToString()
        {
            return $"Rect Dimension is {Side1}x{Side2}";
        }
    }

}
