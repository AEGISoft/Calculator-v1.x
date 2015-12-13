using AEGIS.Specs.Framework;
using System;

namespace AEGIS.Calculator.Core.Tests.IntegerCalculations
{
	public class AaaStyleIntegerCalculationTest: AaaStyleSpec
	{
		protected Common.Calculator _calculator;
		protected String _input;
		protected String _expectedResult;

		protected override void Arrange ()
		{
			_calculator = new IntegerCalculator();
		}

		protected override void Act ()
		{
			_calculator.Calculate(_input);
		}
			
	}
}

