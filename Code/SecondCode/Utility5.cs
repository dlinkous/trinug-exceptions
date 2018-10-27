using System;
using SecondCode.BetterExceptions;

namespace SecondCode
{
	public class Utility5
	{
		public int Average(int total, int quantity) =>
			quantity < 1 ? throw new InvalidQuantityException(quantity) : total / quantity;
	}
}
