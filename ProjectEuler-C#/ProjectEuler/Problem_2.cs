using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
	public static class Problem_2
	{
		
		public static Int64 SumOfEvenFibNumber(int n)
		{
			Int64 sum = 0;
			Int64 firstNum = 1;
			Int64 secondNum = 1;
			Int64 result = 0;

			while(result < n)
			{ 
				result = firstNum + secondNum;
				firstNum = secondNum;
				secondNum = result;
				if (result % 2 == 0)
					sum += result;
			}
			return sum;
		}


	}
}
