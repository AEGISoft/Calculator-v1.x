using System;
using AEGIS.Specs.Framework;
using NUnit.Framework;

namespace AEGIS.Calculator.Core.Tests.IntegerCalculations
{
	public class WhenCalculatingSumOfPositiveIntegers: AaaStyleSpec
	{
		Common.Calculator _calculator;
		String _input;
		String _expectedResult;

		protected override void Arrange ()
		{
			_calculator = new IntegerCalculator();
			_input = "1 + 3";
			_expectedResult = "4";
		}

		protected override void Act ()
		{
			_calculator.Calculate(_input);
		}

		[Test]
		public void ItReturnsTheSum(){
			Assert.That (_calculator.Result, Is.EqualTo(_expectedResult));
		}
	}
}

