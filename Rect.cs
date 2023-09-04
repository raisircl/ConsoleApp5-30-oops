using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Rect
    {
        private int _l, _b;
        public int Length
        {
            get { return _l; }
            set { _l = value; }
        }
        public int Breadth
        {
            get
            {
                return _b;
            }
            set { _b = value; } 
        }
        public int Area()
        {
            return _l*_b;
        }
    }
}
