using System.Collections.Generic;
using System;
using System.Linq;

namespace Kata_Training;
public class Kata
{
	public int DoubleInteger(int n)
	{
		//Double the input!
		return n *= n;
	}

	public string FindNeedle(object[] haystack)
	{
		//Code goes here!
		int result = 0;
		for (int i = 0; i < haystack.Length; i++)
		{
			if (haystack[i] == "needle")
			{
				result = i;
			}
		}

		string needle = $"found the needle at position {result}";

		return needle;
	}
	public string FindNeedle2(object[] haystack)
	{
		return $"found the needle at position {Array.IndexOf(haystack, "needle")}";
	}

	public string[] StringToArray(string str)
	{
		return str.Split(" ").ToArray();
	}
	public int OtherAngle(int a, int b)
	{
		return 180 - a - b;
	}
	public int GetVowelCount(string str)
	{
		int vowelCount = 0;
		string vowels = "aeiou";
		for (int i = 0; i < str.Length; i++)
		{
			char actualChar = str[i];
			if (vowels.Contains(actualChar))
			{
				vowelCount++;
			}
		}
		return vowelCount;
	}
	public int GetVowelCount2(string str)
	{
		return str.Count(i => "aeiou".Contains(i));
	}
	public int summation(int num)
	{
		int sum = 0;
		for (int i = 1; i <= num; i++)
		{
			sum += i;
		}
		return sum;
	}

	public int RentalCarCost(int d)
	{
		// your code
		int carRent = 40;
		int totalCost = 0;

		for (int i = 1; i <= d; i++)
		{
			totalCost = carRent * i;
		}
		if (d >= 3 && d < 7)
		{
			totalCost -= 20;
		}
		if (d >= 7)
		{
			totalCost -= 50;
		}

		return totalCost;
	}
	public static string AreYouPlayingBanjo(string name)
	{
		//Implement me
		if (name.Substring(0, 1) == "R" || name.Substring(0, 1) == "r")
		{
			return $"{name} plays banjo";
		}
		return $"{name} does not play banjo";
	}
	public static string boolToWord(bool word)
	{

		return (word == true) ? "Yes" : "No";

	}
	public static List<string> Number(List<string> lines)
	{
		for (int i = 0; i < lines.Count; i++)
		{
			string v = $"{i + 1}: {lines[i]}";
			lines[i] = v;
		}

		return lines;
	}

	public static int[] minMax(int[] lst) => new int[] { lst.Min(), lst.Max() };
	
		//return new int[] { lst.Min(), lst.Max() };
	
}
