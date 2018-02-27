using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
	public class StringOperations
	{
		public void ReverseString(string value = "sample string")
		{
			var stringBuilder = new StringBuilder();

			for (int i = value.Length - 1; i >= 0; i--)
			{
				stringBuilder.Append(value[i]);
			}

			Console.WriteLine(stringBuilder);
		}
	}
}
