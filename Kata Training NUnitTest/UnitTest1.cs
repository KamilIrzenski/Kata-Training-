using Kata_Training;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Kata_Training_NUnitTest
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			Assert.Pass();
		}
	}
	[TestFixture]
	public class FindNeedleTest
	{
		[Test]
		public void GenericTests()
		{
			Kata kata = new Kata();
			var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
			var haystack_2 = new object[] { "283497238987234", "a dog", "a cat", "some random junk", "a piece of hay", "needle", "something somebody lost a while ago" };
			var haystack_3 = new object[] { 1, 2, 3, 4, 5, 6, 7, 8, 8, 7, 5, 4, 3, 4, 5, 6, 67, 5, 5, 3, 3, 4, 2, 34, 234, 23, 4, 234, 324, 324, "needle", 1, 2, 3, 4, 5, 5, 6, 5, 4, 32, 3, 45, 54 };

			Assert.AreEqual("found the needle at position 3", kata.FindNeedle(haystack_1));
			Assert.AreEqual("found the needle at position 5", kata.FindNeedle(haystack_2));
			Assert.AreEqual("found the needle at position 30", kata.FindNeedle(haystack_3));
			Assert.AreEqual("found the needle at position 3", kata.FindNeedle2(haystack_1));
			Assert.AreEqual("found the needle at position 5", kata.FindNeedle2(haystack_2));
			Assert.AreEqual("found the needle at position 30", kata.FindNeedle2(haystack_3));

		}
	}

	[TestFixture]
	public class SolutionTest
	{
		Kata kata = new Kata();
		[Test]
		public void _1_Example()
		{
			Assert.AreEqual(new string[] { "Robin", "Singh" }, kata.StringToArray("Robin Singh"));
		}

		[Test]
		public void _2_Example()
		{
			Assert.AreEqual(new string[] { "I", "love", "arrays", "they", "are", "my", "favorite" }, kata.StringToArray("I love arrays they are my favorite"));
		}
	}
	[TestFixture]
	public class SolutionTest2
	{
		[Test]
		public void SampleTest()
		{
			Kata kata = new Kata();
			Assert.That(kata.OtherAngle(30, 60), Is.EqualTo(90));
			Assert.That(kata.OtherAngle(60, 60), Is.EqualTo(60));
			Assert.That(kata.OtherAngle(43, 78), Is.EqualTo(59));
			Assert.That(kata.OtherAngle(10, 20), Is.EqualTo(150));

		}
	}
	[TestFixture]
	public class KataTests
	{
		[Test]
		public void TestCase1()
		{
			Kata kata = new Kata();
			Assert.AreEqual(5, kata.GetVowelCount("abracadabra"), "Nope!");
			Assert.AreEqual(5, kata.GetVowelCount2("abracadabra"), "Nope!");
		}
	}
	[TestFixture]
	public class KataTestsSummation
	{
		[Test]
		public static void BasicTests()
		{
			Kata kata = new Kata();
			Assert.AreEqual(1, kata.summation(1));
			Assert.AreEqual(36, kata.summation(8));
			Assert.AreEqual(253, kata.summation(22));
			Assert.AreEqual(5050, kata.summation(100));
			Assert.AreEqual(22791, kata.summation(213));
		}
	}

	[TestFixture]
	public static class RentalCarTests
	{

		private static void testing(int actual, int expected)
		{
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public static void test1()
		{
			Kata kata = new Kata();
			testing(kata.RentalCarCost(1), 40);
			testing(kata.RentalCarCost(3), 100);
			testing(kata.RentalCarCost(7), 230);
		}
	}
	[TestFixture]
	public class AreYouPlayingBanjo
	{
		[Test]
		public static void Martin()
		{
			Assert.AreEqual("Martin does not play banjo", Kata.AreYouPlayingBanjo("Martin"));
		}

		[Test]
		public static void Rikke()
		{
			Assert.AreEqual("Rikke plays banjo", Kata.AreYouPlayingBanjo("Rikke"));
		}

		[Test]
		public static void bravo()
		{
			Assert.AreEqual("bravo does not play banjo", Kata.AreYouPlayingBanjo("bravo"));
		}

		[Test]
		public static void rolf()
		{
			Assert.AreEqual("rolf plays banjo", Kata.AreYouPlayingBanjo("rolf"));
		}
	}
	[TestFixture]
	public class boolToWordTest
	{

		[Test]
		public void boolToWordReturned1()
		{
			Assert.AreEqual("Yes", Kata.boolToWord(true));
			Console.WriteLine("Expected Yes");
		}

		[Test]
		public void boolToWordReturned2()
		{
			Assert.AreEqual("No", Kata.boolToWord(false));
			Console.WriteLine("Expected No");
		}

		[Test]
		public void boolToWordReturned3()
		{
			Assert.AreEqual("Yes", Kata.boolToWord(true));
			Console.WriteLine("Expected Yes");
		}
	}
	[TestFixture]
	public class LineNumberingTest
	{
		[TestCase]
		public void basicTests()
		{
			Assert.AreEqual(new List<string>(), Kata.Number(new List<string>()));
			Assert.AreEqual(new List<string> { "1: a", "2: b", "3: c" }, Kata.Number(new List<string> { "a", "b", "c" }));
			Assert.AreEqual(new List<string> { "1: ", "2: ", "3: ", "4: ", "5: " }, Kata.Number(new List<string> { "", "", "", "", "" }));
		}
	}
	[TestFixture]
	public class MinMaxTests
	{

		[Test]
		public static void BasicTest()
		{
			Assert.AreEqual(new int[] { -1, 20 }, Kata.minMax(new int[] { 1, 2, 5, -1, 12, 20 }));
			Assert.AreEqual(new int[] { 1, 5 }, Kata.minMax(new int[] { 1, 2, 3, 4, 5 }));
			Assert.AreEqual(new int[] { -3, 5 }, Kata.minMax(new int[] { 1, 2, -3, 4, 5 }));
		}
	}

}