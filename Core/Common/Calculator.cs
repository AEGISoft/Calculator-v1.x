using System;

namespace AEGIS.Calculator.Core.Common
{
	public interface Calculator
	{
		String Result {
			get;
		}

		void Calculate (string input);
	}
}

