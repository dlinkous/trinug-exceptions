using System;

namespace SecondCode
{
	public class Utility2
	{
		public (bool valid, int result) Average(int total, int quantity) =>
			quantity < 1 ? (false, 0) : (true, total / quantity);
	}
}
