using System;

namespace AEGIS.Calculator.Core.Common
{
	public class ParseException : Exception
	{
		public ParseException ():base()
		{
			
		}

		public ParseException (String message):base(message)
		{

		}
	}
}

