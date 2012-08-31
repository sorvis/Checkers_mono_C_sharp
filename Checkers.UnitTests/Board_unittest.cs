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
			IPiece expected = new BaseCheckerPiece(BlackWhiteColor.Black, x, y);
			board.AddPiece(expected);
			IPiece actual = board.GetPiece(x, y);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_move_a_given_piece()
		{
			int x = 0;
			int x_new = 1;
			int y = 0;
			int y_new = 1;
			Board board = new Board();
			IPiece expected = new BaseCheckerPiece(BlackWhiteColor.Black, x, y);
			board.AddPiece(expected);
			board.MovePiece(expected, x_new, y_new);
			IPiece actual = board.GetPiece(x_new, y_new);
			Assert.AreEqual(expected, actual);
			Assert.IsNull(board.GetPiece(x, y));
		}
	}
}

