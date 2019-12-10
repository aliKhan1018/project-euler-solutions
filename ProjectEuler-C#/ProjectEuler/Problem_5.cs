using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	class Problem_5
	{
		/* 
		2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

		What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
		 */

		public static void SmallestMultiple()
		{
			bool isDivisible = false;
			int n = 0;

			while (true)
			{
				n++;
				for (int i = 1; i <= 20; i++)
				{
					if (n % i == 0)
						isDivisible = true;
					else
					{
						isDivisible = false;
						break;
					}
				}
				if (isDivisible)
				{
					Console.WriteLine("Answer is " + n);
					break;
				}
			}

		}

	}
}
