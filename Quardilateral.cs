using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Quardilateral
    {
		private int _side1;

		public int Side1
		{
			get { return _side1; }
			set { _side1 = value; }
		}
		private int _side2;

		public int Side2
		{
			get { return _side2; }
			set { _side2 = value; }
		}

		private int _side3;

		public int Side3
		{
			get { return _side3; }
			set { _side3 = value; }
		}
		private int _side4;
				
		public int Side4
		{
			get { return _side4; }
			set { _side4 = value; }
		}
        public Quardilateral()
        {
			_side1 = 0;
			_side2 = 0;
			_side3 = 0;
			_side4 = 0;
        }
        public Quardilateral(int side1, int side2, int side3, int side4)
        {
			_side1=side1;
			_side2=side2;
			_side3=side3;
			_side4=side4;
        }
        public int GetParimeter()
		{
			return _side1+_side2+_side3+_side4;
		}
        public override string ToString()
        {
			return $"Quadrilateral Dimension is {_side1}x{_side2}x{_side3}x{_side4}";
        }
    }

}
