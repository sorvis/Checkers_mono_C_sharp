using System;
using NUnit.Framework;

namespace Checkers
{
	public class Piece : IPiece
	{
		public Piece (PieceColor color, int x, int y)
		{
			Color = color;
			Location = new BoardLocation();
			Location.x = x;
			Location.y = y;
		}

		public PieceColor Color{ get; private set; }
		public BoardLocation Location{ get; private set; }
	}

	public class BoardLocation
	{
		public int x;
		public int y;
	}

	public enum PieceColor
	{
		Undefined, White, Black
	};
}

