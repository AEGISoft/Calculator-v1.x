using System;
using AEGIS.Calculator.Core.Tests.IntegerCalculations;
using NUnit.Framework;

namespace AEGIS.Calculator.Core.Tests.IntegerCalculations
{
	public class WhenCalculatingSumOfMultipleIntegersOfDifferentSign: AaaStyleIntegerCalculationTest
	{
		protected override void Arrange ()
		{
			base.Arrange ();
			_input = "1 - 5 + 6";
			_expectedResult = "2";
		}

		[Test]
		public void ItReturnsTheSum()
		{
			Assert.That(_calculator.Result, Is.EqualTo(_expectedResult));
		}
	}
}

