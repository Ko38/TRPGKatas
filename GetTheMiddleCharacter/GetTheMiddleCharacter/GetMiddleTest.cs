using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace GetTheMiddleCharacter
{
	[TestFixture]
    public class GetMiddleTest
    {
	    [Test]
	    public void GenericTests()
	    {
		    Assert.AreEqual("es",Kata.GetMiddle("test"));
		    Assert.AreEqual("t",Kata.GetMiddle("testing"));
		    Assert.AreEqual("dd",Kata.GetMiddle("middle"));
		    Assert.AreEqual("A",Kata.GetMiddle("A"));
	    }
    }

	public class Kata
	{
		public static string GetMiddle(string input)
		{
			var middleIndex = (double)(input.Length - 1)/ 2;
			if (IsInteger(middleIndex))
			{
				return input[(int)middleIndex].ToString();
			}
			return input[(int)(middleIndex - 0.5)].ToString() + input[(int)(middleIndex + 0.5)].ToString();
		}

		private static bool IsInteger(double middleIndex)
		{
			return middleIndex % 1 == 0;
		}
	}
}
