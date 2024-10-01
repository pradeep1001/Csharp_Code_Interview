using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Pradeep_1
{

	public class Program33
	{
		public static void Main()
		{
			string input1 = "John";
			string input2 = "Smith";
			string istroutput = "";
			int imax = input1.Length > input2.Length ? input1.Length : input2.Length;
			for (int i = 0; i < imax; i++)
			{
				if (i < input1.Length)
				{
					istroutput += input1[i];
				}
				if (i < input2.Length)
				{
					istroutput += input2[i];
				}
			}
			Console.WriteLine(istroutput);
		}


	}
}
