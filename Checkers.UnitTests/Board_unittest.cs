using System;
using NUnit.Framework;

namespace Checkers.UnitTests
{
	[TestFixture]
	public class Board_unittest
	{
		public Board_unittest ()
		{
		}

		[Test]
		public void board_should_add_a_given_piece()
		{
			int x = 0;
			int y = 0;
			Board board = new Board();
			IPiece expected = new Piece(PieceColor.Black, x, y);
			board.AddPiece(expected);
			IPiece actual = board.GetPiece(x, y);
			Assert.AreEqual(expected, actual);
		}
	}
}

