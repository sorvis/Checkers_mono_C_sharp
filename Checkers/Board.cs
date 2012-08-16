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

		}

		public IPiece GetPiece (int x, int y)
		{
			return _pieces[x,y];
		}

		IPiece[,] _pieces = new IPiece[8,8];
	}
}

