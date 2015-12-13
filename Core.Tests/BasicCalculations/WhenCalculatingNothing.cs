using NUnit.Framework;
using System;
using AEGIS.Specs.Framework;
using AEGIS.Calculator.Core;

namespace AEGIS.Calculator.Core.Tests.BasicCalculations
{
	[TestFixture ()]
	public class WhenCalculatingNothing: AaaStyleSpec
	{
		Common.Calculator _calculator;

		protected override void Arrange ()
		{
			_calculator = new IntegerCalculator ();
		}

		[Test ()]
		public void ItReturnsZero ()
		{
			Assert.That(_calculator.Result, Is.EqualTo("0"));
		}
	}
}

