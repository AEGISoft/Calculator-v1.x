using System;
using AEGIS.Calculator.Core.Common;

namespace AEGIS.Calculator.Core
{
	public class IntegerCalculator:BasicCalculator
	{
		public override void Calculate (string input)
		{
			var parameters = input.Split(' ');

			if (parameters.Length<3) 				
				base.Calculate (input);
			else
				_result = Convert.ToString(Convert.ToInt32(parameters[0]) + Convert.ToInt32(parameters [2]));

		}
	}
}

