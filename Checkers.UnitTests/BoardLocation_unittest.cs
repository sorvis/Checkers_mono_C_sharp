using System;
using NUnit.Framework;

namespace Checkers.UnitTests
{
	public class BoardLocation_unittest
	{
		[Test]
		public void board_should_return_black_when_asked_for_color_of_top_right_square()
		{
			BoardLocation board = new BoardLocation(7,0);
			BlackWhiteColor expected = BlackWhiteColor.Black;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_black_when_asked_for_color_of_bottom_left_square()
		{
			BoardLocation board = new BoardLocation(0,7);
			BlackWhiteColor expected = BlackWhiteColor.Black;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_color_of_top_left_square()
		{
			BoardLocation board = new BoardLocation(0,0);
			BlackWhiteColor expected = BlackWhiteColor.White;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_third_from_left_top_square()
		{
			BoardLocation board = new BoardLocation(2,0);
			BlackWhiteColor expected = BlackWhiteColor.White;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_second_from_left_second_down_square()
		{
			BoardLocation board = new BoardLocation(1,1);
			BlackWhiteColor expected = BlackWhiteColor.White;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_white_when_asked_for_fourth_from_left_second_down_square()
		{
			BoardLocation board = new BoardLocation(3,1);
			BlackWhiteColor expected = BlackWhiteColor.White;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void board_should_return_black_when_asked_for_0_1()
		{
			BoardLocation board = new BoardLocation(0,1);
			BlackWhiteColor expected = BlackWhiteColor.Black;
			BlackWhiteColor actual = board.GetSquareColor();
			Assert.AreEqual(expected, actual);
		}
	}
}

