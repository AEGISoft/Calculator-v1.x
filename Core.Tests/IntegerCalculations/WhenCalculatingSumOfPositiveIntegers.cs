using NUnit.Framework;

namespace AEGIS.Calculator.Core.Tests.IntegerCalculations
{
	public class WhenCalculatingSumOfPositiveIntegers: AaaStyleIntegerCalculationTest
	{

		protected override void Arrange ()
		{
			base.Arrange ();
			_input = "1 + 3";
			_expectedResult = "4";
		}

		[Test]
		public void ItReturnsTheSum(){
			Assert.That (_calculator.Result, Is.EqualTo(_expectedResult));
		}
	}
}

