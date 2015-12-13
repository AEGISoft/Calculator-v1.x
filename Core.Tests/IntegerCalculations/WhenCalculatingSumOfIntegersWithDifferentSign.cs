﻿using NUnit.Framework;

namespace AEGIS.Calculator.Core.Tests.IntegerCalculations
{
	public class WhenCalculatingSumOfIntegersWithDifferentSign: AaaStyleIntegerCalculationTest
	{

		protected override void Arrange ()
		{
			base.Arrange ();
			_input = "-1 + 5";
			_expectedResult = "4";
		}

		[Test]
		public void ItReturnsTheSum(){
			Assert.That (_calculator.Result, Is.EqualTo(_expectedResult));
		}
	}
}

