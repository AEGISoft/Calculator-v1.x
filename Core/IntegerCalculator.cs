using System;

namespace AEGIS.Calculator.Core
{
	public class IntegerCalculator:Calculator
	{
		#region Calculator implementation

		public string Result {
			get {
				return "0";
			}
		}


		public void Calculate (string input)
		{
			throw new NotImplementedException ();
		}
		#endregion

	}
}

