using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
//build test release
//dliub tset esaeler
namespace Pradeep_1
{
	public static class Hello
	{
		public static string Reverse(this string v)
		{
			string istr = "";
			for (int i = v.Length - 1; i >= 0; i--)
			{
				istr += v[i];
			}
			return istr;
		}
	}
	public class Class1
	{
		public static void Main()
		{
			string input = " Hello World ";
			string[] abc = (input.Trim()).Split(' ');

			// string[] abc = ilist.SelectMany(x => x.Split(' ')).ToArray();
			string istroutput = "";
			for (int i = 0; i < abc.Length; i++)
			{
				istroutput += abc[i].Reverse();
				if (i < abc.Length - 1)
				{
					istroutput += " ";
				}
			}
			Console.WriteLine(istroutput);

		}
	}
}
