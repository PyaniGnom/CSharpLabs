using System;
using System.Collections;

namespace Test
{

	class MyClass
	{
		private int a;

		private static void SetA()
		{
			
		} 
	}

	class Program
	{
		enum DayOfWeek : byte
		{
			Monday = 1,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}

		static void Main()
		{
			var values = Enum.GetValues(typeof(ConsoleKey));

			foreach (var value in values)
			{
				Console.WriteLine(value);
			}
		}

		private static DayOfWeek GetNextDay(DayOfWeek day)
		{
			if (day < DayOfWeek.Sunday)
			{
				return day + 1;
			}

			return DayOfWeek.Monday;
		}

		private void Hoo()
		{
			string words = "This  is a list of words, with punctuation";
			string[] split = words.Split(new char[] { ' ', ',' });
			foreach (string s in split)
			{

				if (s.Trim() != "")
				{
					Console.WriteLine(s);
				}
			}
		}
	}
}
