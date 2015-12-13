using System;

namespace AEGIS.Calculator.Core
{
	public interface Calculator
	{
		String Result {
			get;
		}

		void Calculate (string input);
	}
}

