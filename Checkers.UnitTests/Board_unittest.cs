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

		[Test]
		public void board_should_move_a_given_piece()
		{
			int x = 0;
			int x_new = 1;
			int y = 0;
			int y_new = 1;
			Board board = new Board();
			IPiece expected = new Piece(PieceColor.Black, x, y);
			board.AddPiece(expected);
			board.MovePiece(expected, x_new, y_new);
			IPiece actual = board.GetPiece(x_new, y_new);
			Assert.AreEqual(expected, actual);
			Assert.IsNull(board.GetPiece(x, y));
		}

		[Test]
		public void board_should_return_black_when_asked_for_color_of_top_right_square()
		{
			Board board = new Board();
			PieceColor expected = PieceColor.Black;
			PieceColor actual = board.GetSquareColor(new BoardLocation(7,0));
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_black_when_asked_for_color_of_bottom_left_square()
		{
			Board board = new Board();
			PieceColor expected = PieceColor.Black;
			PieceColor actual = board.GetSquareColor(new BoardLocation(0,7));
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_color_of_top_left_square()
		{
			Board board = new Board();
			PieceColor expected = PieceColor.White;
			PieceColor actual = board.GetSquareColor(new BoardLocation(0,0));
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_second_from_left_top_square()
		{
			Board board = new Board();
			PieceColor expected = PieceColor.White;
			PieceColor actual = board.GetSquareColor(new BoardLocation(2,0));
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_second_from_left_second_down_square()
		{
			Board board = new Board();
			PieceColor expected = PieceColor.White;
			PieceColor actual = board.GetSquareColor(new BoardLocation(2,1));
			Assert.AreEqual(expected, actual);
		}
	}
}

