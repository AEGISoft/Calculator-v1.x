using System;
using AEGIS.Specs.Framework;
using NUnit.Framework;
using AEGIS.Calculator.Core.Common;

namespace AEGIS.Calculator.Core.Tests.BasicCalculations
{
	public class WhenCalculatingNonNumericOperands:AaaStyleSpec
	{
		Common.Calculator _calculator;
		String _inputInteger;
		TestDelegate _calculatingLetters;

		protected override void Arrange(){
			_calculator = new IntegerCalculator();
			_inputInteger = "a";
		}

		protected override void Act()
		{
			_calculatingLetters = () => _calculator.Calculate(_inputInteger);
		}

		[Test]
		public void ItThrowsParseException(){
			Assert.Throws<ParseException>(_calculatingLetters);
		}
	}
}

