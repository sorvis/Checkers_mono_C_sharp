using System;

namespace Checkers
{
	public class Board
	{
		public Board ()
		{
		}

		public void AddPiece(IPiece piece)
		{
			_pieces[piece.Location.X,piece.Location.X] = piece;
		}

		public IPiece GetPiece (int x, int y)
		{
			return _pieces[x,y];
		}

		public bool MovePiece (IPiece piece, BoardLocation newLocation)
		{
			RemovePiece (piece);
			piece.Location = newLocation;
			AddPiece (piece);
			return true;
//			if (piece.CanPieceMove (newLocation))
//			{
//				RemovePiece (piece);
//				piece.Location = newLocation;
//				AddPiece (piece);
//				return true;
//			}
//			else
//			{
//				return false;
//			}
		}

		public void RemovePiece(IPiece piece)
		{
			_pieces[piece.Location.X, piece.Location.Y] = null;
		}

		IPiece[,] _pieces = new IPiece[8,8];
	}
}

