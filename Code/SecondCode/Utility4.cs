using System;
using SecondCode.BasicExceptions;

namespace SecondCode
{
	public class Utility4
	{
		public int Average(int total, int quantity) =>
			quantity < 1 ? throw new InvalidQuantityException(nameof(quantity)) : total / quantity;
	}
}
