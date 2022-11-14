using System;
// ReSharper disable StringLiteralTypo

namespace CalculatorLaba1
{
	internal static class Program
	{
		private static void RedText(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}

		private static void Main()
		{
			double variableY;

			Console.Title = "Laba01_Isaev.N.S_211-327";

		Input_ValueX:
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Введите значение для X: ");

			if (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out double variableX))
			{
				RedText("\nОшибка! Введите корректное значение!\n");
				goto Input_ValueX;
			}

			if (Math.Abs(variableX) > 3)
			{
				variableY = Math.Pow(Math.Pow(Math.Abs(variableX + 2), 1.45), 2) + 5;
				Console.WriteLine("При X = " + variableX + " функция вычисляется по формуле Y = Sqr(Abs(x + 2)^1.45) + 5. Результат = " + variableY);
			}
			else if (Math.Abs(variableX) <= 1)
			{
				variableY = Math.Pow(Math.Cos(variableX), -1.9) + 3;
				Console.WriteLine("При X = " + variableX + " функция вычисляется по формуле Y = Cos(x)^(-1.9) + 3. Результат = " + variableY);
			}
			else
			{
				Console.WriteLine("При X = " + variableX + " функция не определена");
			}

		Input_Continue:
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\nХотите продолжить? [Y/N]: ");

			switch (Console.ReadLine())
			{
				case "y":
				case "Y":
				Input_Clear:
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.Write("Очистить консоль перед началом? [Y/N]: ");

					switch (Console.ReadLine())
					{
						case "y":
						case "Y":
							Console.Clear();
							goto Input_ValueX;
						case "n":
						case "N":
							Console.Write("\n");
							goto Input_ValueX;
						default:
							RedText("\nОшибка! К вводу доступны только символы 'Y' и 'N'!\n");
							goto Input_Clear;
					}

				case "n":
				case "N":
					Console.ResetColor();
					break;

				default:
					RedText("\nОшибка! К вводу доступны только символы 'Y' и 'N'!");
					goto Input_Continue;
			}

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nРабота завершена! Для закрытия консоли, нажмите клавишу ENTER");
			Console.ReadLine();
		}
	}
}
