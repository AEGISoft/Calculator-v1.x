using System;
using AEGIS.Calculator.Core.Common;
using System.Collections.Generic;

namespace AEGIS.Calculator.Core
{
	public class IntegerCalculator:BasicCalculator
	{
		public override void Calculate (string input)
		{
			var parameters = new List<String>(input.Split(' '));

			while (parameters.Count >= 3)
			{
				//read 3 first parameters and replace them by the calculated result
				var calcOperand1 = Convert.ToInt32 (Pop(ref parameters));
				var calcOperator = Pop(ref parameters);

				//read and replace by calculation
				var calcOperand2 = Convert.ToInt32 (Peek(parameters));
				var calcResult = calcOperand1;

				switch (calcOperator)
				{
					case "+": calcResult = calcOperand1 + calcOperand2; break;
					case "-": calcResult = calcOperand1 - calcOperand2; break;
				}

				parameters [0] = Convert.ToString (calcResult);
			}

			_result = parameters [0];
		}

		#region Underworld
		//read and pop off the top value
		private String Pop (ref List<String> stack)
		{
			var pop = Peek(stack);
			stack.RemoveAt (0);
			return pop;
		}

		//read the top value
		private String Peek(List<String> stack)
		{
			return stack [0];
		}
		#endregion
	}
}

