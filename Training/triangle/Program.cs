using System;

namespace triangle
{
	internal class Program
	{
		static void Main()
		{		
			Console.Write("Введите высоту треугольника: ");
			int height = int.Parse(Console.ReadLine());
			Console.WriteLine();

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j <= i; j++)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n");

			for (int i = 0; i < height; i++)
			{
				for (int j = height; j > i; j--)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n");

			for (int i = 0; i < height; i++)
			{
				for (int j = height - 1; j > i; j--)
				{
					Console.Write(" ");
				}

				for (int j = 0; j <= i; j++)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n");

			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < i; j++)
				{
					Console.Write(" ");
				}

				for (int j = height; j > i; j--)
				{
					Console.Write("#");
				}
				Console.WriteLine();
			}
			Console.WriteLine("\n");
		}
	}
}
