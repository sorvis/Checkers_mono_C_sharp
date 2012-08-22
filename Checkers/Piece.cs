using System;
using NUnit.Framework;

namespace Checkers
{
	public class Piece : IPiece
	{
		public Piece (PieceColor color, int x, int y)
		{
			Color = color;
			Location = new BoardLocation(x, y);
		}

		public PieceColor Color{ get; private set; }
		public BoardLocation Location{ get; set; }
	}

	public class BoardLocation
	{
		public BoardLocation (int x, int y)
		{
			this.X=x;
			this.Y=y;
		}
		public int X{ get; set; }
		public int Y{ get; set; }
	}


}

