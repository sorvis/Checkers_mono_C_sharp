using System;

namespace Checkers
{
	public class BoardLocation
	{
		public BoardLocation (int x, int y)
		{
			this.X=x;
			this.Y=y;
		}

		public BlackWhiteColor GetSquareColor ()
		{
			if (this.X % 2 == 0 && this.Y % 2 == 0)
			{
				return BlackWhiteColor.White;
			} 
			else if (this.X % 2 != 0 && this.Y % 2 != 0)
			{
				return BlackWhiteColor.White;
			} 
			else
			{
				return BlackWhiteColor.Black;
			}
		}

		public int X{ get; set; }
		public int Y{ get; set; }
	}
}

