using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeNumber.Models
{
	public class ChangeNumberClass
	{
		public bool MultiPleOfThree(int num) => num % 3 == 0;
		public bool MultiPleOfFive(int num) => num % 5 == 0;
		public bool MultiPleOfFour(int num) => num % 4 == 0;
		public bool MultiPleOfSeven(int num) => num % 7 == 0;
		// * v1.0
		public object CheckNumberV1(int numb)
		{
			StringBuilder sb = new StringBuilder(28);

			CheckNumberV1Ref(ref sb, numb);

			if (sb.Length > 0)
				return sb.ToString();
			else
				return numb;
		}
		private void CheckNumberV1Ref(ref StringBuilder sb, int numb, string valueForThree = "fizz", string valueForFive = "buzz")
		{
			if (MultiPleOfThree(numb))
			{
				sb.Append(valueForThree);
			}
			if (MultiPleOfFive(numb))
			{
				sb.Append(sb.Length > 0 ? "-" + valueForFive : valueForFive);
			}
		}

		//* v2.0
		public object CheckNumberV2(int numb)
		{
			StringBuilder sb = new StringBuilder(28);

			CheckNumberV2Ref(ref sb, numb, "fizz", "buzz");


			if (sb.Length > 0)
				return sb.ToString();
			else
				return numb;
		}
		private void CheckNumberV2Ref(ref StringBuilder sb, int numb, string valueForThree, string valueForFive)
		{
			CheckNumberV1Ref(ref sb, numb, valueForThree, valueForFive);

			if (MultiPleOfFour(numb))
			{
				sb.Append(sb.Length > 0 ? "-muzz" : "muzz");
			}
			if (MultiPleOfSeven(numb))
			{
				sb.Append(sb.Length > 0 ? "-guzz" : "guzz");
			}
		}

		// v3.0
		public object CheckNumberV3(int numb)
		{
			StringBuilder sb = new StringBuilder(28);


			CheckNumberV2Ref(ref sb, numb, "dog", "cat");


			if (MultiPleOfThree(numb) && numb > 10)
			{
				sb.Replace("dog", "fizz");
			}
			if (MultiPleOfFive(numb) && numb > 10)
			{
				sb.Replace("cat", "buzz");
			}

			if (MultiPleOfThree(numb) && MultiPleOfFive(numb))
			{
				sb.Replace("fizz-buzz", "good-boy");
			}



			if (sb.Length > 0)
				return sb.ToString();
			else
				return numb;
		}
	}

}
