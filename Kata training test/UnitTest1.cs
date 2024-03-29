using Kata_Training;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections.Generic;

namespace Solution
{
	[TestClass]
	public class CodeWarsTest
	{
		private static IEnumerable<TestCaseData> testCases
		{
			get
			{
				yield return new TestCaseData(2).Returns(4);
				yield return new TestCaseData(4).Returns(8);
				yield return new TestCaseData(-10).Returns(-20);
				yield return new TestCaseData(0).Returns(0);
				yield return new TestCaseData(100).Returns(200);
			}
		}

		[TestMethod, TestCaseSource("testCases")]
		public int Test(int n)
		{
			Kata kata = new Kata();
			return kata.DoubleInteger(n);

		}
	}

	[TestClass]
public class FindNeedleTest
{
	[TestMethod]
	public void GenericTests()
	{
		Kata kata = new Kata();
		var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
		var haystack_2 = new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };
		var haystack_3 = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };

		Assert.AreEqual("found the needle at position 3", kata.FindNeedle(haystack_1));
		Assert.AreEqual("found the needle at position 5", kata.FindNeedle(haystack_2));
		Assert.AreEqual("found the needle at position 30", kata.FindNeedle(haystack_3));
	}
}