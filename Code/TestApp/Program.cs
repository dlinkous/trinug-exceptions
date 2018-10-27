using System;
using FirstCode;
using SecondCode;
using SecondCode.BetterExceptions;
using ThirdCode;

namespace TestApp
{
	public class Program
	{
		public static void Main(string[] args)
		{
			FirstExamples();
			SecondExamples();
			ThirdExamples();
			FourthExamples();
		}

		private static void FirstExamples()
		{
			var utility = new FirstUtility();
			var even = utility.IsEven(40);
			//var average = utility.Average(20, 0);
			//var increased = utility.IncreaseValue(int.MaxValue);
			//var increasedMore = utility.IncreaseValueMore(100);
		}

		private static void SecondExamples()
		{
			var utility2 = new Utility2();
			var averageA = utility2.Average(20, 10);
			var averageB = utility2.Average(20, 0);
			var utility3 = new Utility3();
			var averageC = utility3.Average(20, 10);
			//var averageD = utility3.Average(20, 0);
			var utility4 = new Utility4();
			var averageE = utility4.Average(20, 10);
			//var averageF = utility4.Average(20, 0);
			var utility5 = new Utility5();
			var averageG = utility5.Average(20, 10);
			//var averageH = utility5.Average(20, 0);
			try
			{
				var averageToCatch1 = utility5.Average(20, 0);
			}
			catch (InvalidQuantityException ex)
			{
				Console.WriteLine($"Exception!  Message: {ex.Message} (Quantity is {ex.Quantity})");
			}
			try
			{
				var averageToCatch2 = utility5.Average(20, 0);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Exception!  Message: {ex.Message}");
			}
		}

		private static void ThirdExamples()
		{
			// Empty
		}

		private static void FourthExamples()
		{
			// Empty
		}
	}
}
