using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Bike
    {
		private static int x = 1001; // x is static variable and it retains itself last value in multiple function call
		private int _srno;
		private static double price=10000;
		public int SrNo
		{
			get { return _srno; }
			set { _srno = value; }
		}

		private string? _color;

		public string Color
		{
			get { return _color??"NA"; }
			set { _color = value; }
		}

        public double Price 
		{
			
			get { return price; } 
			 
		}
        public Bike()
        {
			_srno = x;
			x++;

        }
		public static void HikePrice(double hikeper)
		{
			double amnt;
			amnt = price * hikeper / 100;
			price=price+amnt;
			Console.WriteLine("Price Hiked");
		}
        public static void DownPrice(double downper)
        {
            double amnt;
            amnt = price * downper / 100;
            price = price - amnt;
            Console.WriteLine("Price Down");
        }
    }
}
/*

 Static(Shared) Data Member or Static(Shared) Member Function
 if you want to make a member common between all of the objects of a class that member should be defined static
 if any change made in static member that will affect all the objects of a class

Bike 

SrNo
Color

Price - common / shared 

*/