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

		public void MovePiece(IPiece piece, int x, int y)
		{
			RemovePiece(piece);
			piece.Location = new BoardLocation(x, y);
			AddPiece(piece);
		}

		public void RemovePiece(IPiece piece)
		{
			_pieces[piece.Location.X, piece.Location.Y] = null;
		}

		IPiece[,] _pieces = new IPiece[8,8];
	}
}

