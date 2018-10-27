using System;

namespace FirstCode
{
	public class FirstUtility
	{
		public bool IsEven(int value) =>
			value % 2 == 0;

		public int Average(int total, int quantity) =>
			total / quantity;

		public int IncreaseValue(int value) =>
			value + 100;

		public int IncreaseValueMore(int value) =>
			IncreaseValueMore(value + 1);
	}
}
