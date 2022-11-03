using System;

namespace Recursion
{
	internal class Program
	{
		/// <summary>
		/// Метод для вывода всех элементов массива, с помощью рекурсии.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="i"></param>
		private void PrintArray(int[] array, int i = 0)
		{
			if (i < array.Length)
			{
				Console.WriteLine(array[i]);

				PrintArray(array, i + 1);
			}
		}

		/// <summary>
		/// Метод для вычисления суммы элементов массива с помощью рекурсии.
		/// </summary>
		/// <param name="array"></param>
		/// <param name="i"></param>
		/// <returns></returns>
		private int SumArray(int[] array, int i = 0)
		{
			if (i >= array.Length)
				return 0;

			return array[i] + SumArray(array, i + 1);
		}

		/// <summary>
		/// Метод для вычисления суммы цифр числа с помощью рекурсии.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private int Sum(int value)
		{
			if (value < 10)
				return value;

			return value % 10 + Sum(value / 10);
		}

		/// <summary>
		/// Метод для вычисления суммы цифр числа с помощью цикла.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		private int Foo(int value)
		{
			int result = 0;

			while (value > 0)
			{
				result += value % 10;
				value /= 10;
			}

			return result;
		}

		static void Main()
		{
			int[] myArray = { 84, 37, 81, 63 };
			int value = 569;

			Program program = new Program();

			program.PrintArray(myArray);
			Console.WriteLine();

			Console.WriteLine(program.SumArray(myArray));
			Console.WriteLine();

			Console.WriteLine(program.Sum(value));
			Console.WriteLine();

			Console.WriteLine(program.Foo(value));
		}
	}
}
