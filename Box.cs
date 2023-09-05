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
		public int vol()
		{
			return _length * _breadth * _height;
		}

	}
}
