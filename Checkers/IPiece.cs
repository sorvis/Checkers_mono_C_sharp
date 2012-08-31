using System;

namespace Checkers
{
	public interface IPiece
	{
		BoardLocation Location{ get; set;}
		bool CanPieceMove(BoardLocation newLocation);
	}
}

