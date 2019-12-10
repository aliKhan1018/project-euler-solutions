using System;
using System.Diagnostics;

namespace ProjectEuler
{
	class Problem_8
	{
		
		public static ulong LargestProduct(string num, uint adj)
		{
			Stopwatch s = new Stopwatch();
			
			s.Start();
			
			ulong m_product = 1;
			ulong m_largestProduct = 0;
			
			 
			int n = 0;

			while (n < num.Length - (adj - 1))
			{
				for (int i = n; i < n+adj; i++)
				{
					m_product *= ulong.Parse(num[i].ToString());
				}
				if (m_product > m_largestProduct)
					m_largestProduct = m_product;
				m_product = 1;
				n++;
				
			}
			s.Stop();
			Console.WriteLine("Time Elapsed: " + s.Elapsed);
			Console.Write("The largest product is: ");
			
			return m_largestProduct;
			
		}

		public static ulong LargestProduct(ulong num, uint adj)
		{
			string m_numToString = num.ToString();
			ulong m_product = 1;
			ulong m_largestProduct = 0;


			int n = 0;

			while (n < m_numToString.Length - (adj - 1))
			{
				for (int i = n; i < n + adj; i++)
				{
					m_product *= ulong.Parse(m_numToString[i].ToString());
				}
				if (m_product > m_largestProduct)
					m_largestProduct = m_product;
				m_product = 1;
				n++;

			}

			System.Console.Write("The largest product is: ");
			return m_largestProduct;

		}
	}
}
