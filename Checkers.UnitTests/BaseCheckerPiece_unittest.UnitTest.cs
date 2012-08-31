using System;
using NUnit.Framework;
using Checkers;

namespace Checkers.UnitTests
{
	[TestFixture]
	public class BaseCheckerPiece_unittest
	{
		[Test]
		public void Color_should_be_set_for_new_instance()
		{
			BlackWhiteColor expected = BlackWhiteColor.White;
			BaseCheckerPiece piece = new BaseCheckerPiece(expected, 0, 0);
			BlackWhiteColor actual = piece.PieceColor;
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void base_checker_should_be_able_to_move_from_1_0_to_2_1 ()
		{
			BoardLocation start = new BoardLocation(1,0);
			BoardLocation end = new BoardLocation(2,1);
			BaseCheckerPiece piece = new BaseCheckerPiece(BlackWhiteColor.Black, start);
			bool expected = true;
			bool actual = piece.CanPieceMove(end);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void base_checker_should_be_able_to_move_to_a_white_space ()
		{
			BoardLocation start = new BoardLocation(1,0);
			BoardLocation end = new BoardLocation(1,1);
			BaseCheckerPiece piece = new BaseCheckerPiece(BlackWhiteColor.Black, start);
			bool expected = false;
			bool actual = piece.CanPieceMove(end);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void base_checker_not_be_able_to_move_two_spaces_away ()
		{
			BoardLocation start = new BoardLocation(1,0);
			BoardLocation end = new BoardLocation(3,2);
			BaseCheckerPiece piece = new BaseCheckerPiece(BlackWhiteColor.Black, start);
			bool expected = false;
			bool actual = piece.CanPieceMove(end);
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void base_checker_not_be_able_to_move_to_its_same_row_horizontally ()
		{
			BoardLocation start = new BoardLocation(1,0);
			BoardLocation end = new BoardLocation(3,0);
			BaseCheckerPiece piece = new BaseCheckerPiece(BlackWhiteColor.Black, start);
			bool expected = false;
			bool actual = piece.CanPieceMove(end);
			Assert.AreEqual(expected, actual);
		}
	}
}

