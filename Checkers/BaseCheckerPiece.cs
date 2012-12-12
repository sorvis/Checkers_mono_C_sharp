using System;
using NUnit.Framework;

namespace Checkers
{
	public class BaseCheckerPiece : IPiece
	{
		public BaseCheckerPiece (BlackWhiteColor color, int x, int y)
		{
			PieceColor = color;
			Location = new BoardLocation(x, y);
		}

		public BaseCheckerPiece (BlackWhiteColor color, BoardLocation location)
		{
			PieceColor = color;
			Location = location;
		}

		public bool CanPieceMove (BoardLocation newLocation)
		{
			int moveDistance = Math.Abs (newLocation.Y) - Math.Abs (Location.Y);
			if (newLocation.GetSquareColor () == BlackWhiteColor.White
				|| moveDistance > 1 
				|| moveDistance == 0)
			{
				return false;
			}
			else
			{
				return true;
			}
		}

		public BlackWhiteColor PieceColor{ get; private set; }
		public BoardLocation Location{ get; set; }
	}




}

