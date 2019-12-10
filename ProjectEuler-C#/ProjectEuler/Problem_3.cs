using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Problem_3
	{
		public static int FindLargestPrimeFactorOf(int n)
		{
			if (n < 2)
				return 1;

			int _largestPrimeFactor;

			for (int i = 2; i < n; i++)
			{
				if (n % i == 0)
				{
					Console.Write(i + ", ");
				}
			}

			return 0;
		}
	}
}
