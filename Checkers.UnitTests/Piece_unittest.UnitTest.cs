using System;
using NUnit.Framework;
using Checkers;

namespace Checkers.UnitTests
{
	[TestFixture]
	public class Piece_unittest
	{
		[Test]
		public void Color_should_be_set_for_new_instance()
		{
			PieceColor expected = PieceColor.White;
			Piece piece = new Piece(expected, 0, 0);
			PieceColor actual = piece.Color;
			Assert.AreEqual(expected, actual);
		}
	}
}

