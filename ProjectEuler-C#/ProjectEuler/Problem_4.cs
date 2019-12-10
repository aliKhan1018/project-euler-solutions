using System;

namespace ProjectEuler
{	
	class InputToSmallException : Exception
	{
		public InputToSmallException()
		{
			Console.WriteLine("Input should atleast have 2 digits.");
		}
	}

	class Problem_4
	{	
		public static bool IsPalindrome(Int64 n)
		{
			string toString = n.ToString();

			string reversedString = string.Empty;
			for (int i = toString.Length - 1; i >= 0; i--)
				reversedString += toString[i];
			int reverse = int.Parse(reversedString);

			return reverse == n;
		}

		/// <summary>
		/// Returns the largest palindrome product from n upto but not including m
		/// </summary>
		public static Int64 LargestPalindromeProduct(int from, int upto)
		{
			Int64 _largestPalindromeProduct = 0;
			Int64 product;

			for (int i = from; i < upto; i++)
				for (int j = from; j < upto; j++) {
					product = i * j;
					if (IsPalindrome(product) && product > _largestPalindromeProduct)
					{
						_largestPalindromeProduct = product;
					}
				}

			return _largestPalindromeProduct;
		}

	}
}
