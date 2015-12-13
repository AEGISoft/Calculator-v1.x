using System;
using AEGIS.Specs.Framework;
using NUnit.Framework;
using AEGIS.Calculator.Core;

namespace AEGIS.Calculator.Core.Tests.BasicCalculations
{
	public class WhenCalculatingSingleInput:AaaStyleSpec
	{
		Common.Calculator _calculator;
		String _inputInteger;

		protected override void Arrange(){
			_calculator = new IntegerCalculator();
			_inputInteger = "123";
		}

		protected override void Act(){
			_calculator.Calculate(_inputInteger);
		}

		[Test]
		public void ItReturnsTheInputInteger(){
			Assert.That(_calculator.Result, Is.EqualTo(_inputInteger));
		}
	}
}

