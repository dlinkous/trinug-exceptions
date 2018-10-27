using System;

namespace SecondCode
{
	public class Utility3
	{
		public int Average(int total, int quantity) =>
			quantity < 1 ? throw new ArgumentOutOfRangeException(nameof(quantity)) : total / quantity;
	}
}
