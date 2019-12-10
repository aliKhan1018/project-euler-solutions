
namespace ProjectEuler
{
	class Problem_6
	{
		public static int SumSquareDiff(int upto)
		{
			return SquareOfSum(upto) - SumOfSquare(upto);
		}

		private static int SquareOfSum(int upto)
		{
			int sum = 0;

			for (int i = 1; i <= upto; i++)
				sum += i;

			return sum * sum;
		}

		private static int SumOfSquare(int upto)
		{
			int sumOfSq = 0;

			for (int i = 1; i <= upto; i++)
			{
				int sq = i * i;
				sumOfSq += sq;
			}

			return sumOfSq;
		}
	}
}
