using System;

namespace AEGIS.Calculator.Core.Common
{
	public abstract class BasicCalculator:Calculator
	{
		#region Calculator implementation

		protected String _result = "0";
		public String Result {
			get 		{ return _result;}
			private set { _result = value;}
		}


		public virtual void Calculate (string input)
		{
			Result = input;
		}
		#endregion

	}
}

