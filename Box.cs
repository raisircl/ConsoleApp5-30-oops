using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Box
    {
		private int _length;

		public int Length
		{
			get { return _length; }
			set { _length = value; }
		}
		private int _breadth;

		public int Breadth
		{
			get { return _breadth; }
			set { _breadth = value; }
		}
		private int _height;

		public int Height
		{
			get { return _height; }
			set { _height = value; }
		}
		public int area()
		{
			return _length * _breadth;
		}
		public Box() {
			_length = 0;
			_breadth = 0;	
			_height = 0;	
		}
		public Box(int l,int b,int h)
		{
			_length = l;
			_breadth = b;
			_height = h;
		}
		public Box(Box box)
		{
			_length = box.Length;
			_breadth = box.Breadth;
			_height = box.Height;	
		}
		public int vol()
		{
			return _length * _breadth * _height;
		}
		public static bool operator==(Box b1,Box b2)
		{
				return b1.vol() == b2.vol();		
		}
        public static bool operator !=(Box b1, Box b2)
        {
            return b1.vol() != b2.vol();
        }
        public static bool operator >(Box b1, Box b2)
        {
            return b1.vol() > b2.vol();
        }
        public static bool operator <(Box b1, Box b2)
        {
            return b1.vol() < b2.vol();
        }
    }
}
