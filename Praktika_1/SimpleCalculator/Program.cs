using System;
// ReSharper disable StringLiteralTypo

namespace SimpleCalculator
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
			double result;

			Console.Title = "Простой калькулятор | Practice01_Isaev.N.S_211-327";

		Input_firstValue:
			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Введите первое число: ");

			if (!double.TryParse(Console.ReadLine()?.Replace('.', ','), out double firstParsedValue))
			{
				RedText("\nОшибка! Введите корректное значение!\n");
				goto Input_firstValue;
			}

		Input_secondValue:
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("\nЕсли хотите вернуться к вводу первого числа, введите (без кавычек): 'go start'");

			Console.ForegroundColor = ConsoleColor.White;
			Console.Write("Введите второе число: ");
			string secondValue = Console.ReadLine();

			if (secondValue == "go start")
			{
				Console.Write("\n");
				goto Input_firstValue;
			}

			if (!double.TryParse(secondValue?.Replace('.', ','), out double secondParsedValue))
			{
				RedText("\nОшибка! Введите корректное значение!");
				goto Input_secondValue;
			}

		Input_operation:
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("\nЕсли хотите вернуться к вводу первого числа, введите (без кавычек): 'go start'");

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Теперь выберете одно из действий (введите без кавычек):\n'+', '-', '*', '/'");
			string action = Console.ReadLine();

			switch (action)
			{
				case "go start":
					Console.Write("\n");
					goto Input_firstValue;

				case "+":
					result = firstParsedValue + secondParsedValue;
					break;

				case "-":
					result = firstParsedValue - secondParsedValue;
					break;

				case "*":
					result = firstParsedValue * secondParsedValue;
					break;

				case "/":
					if (secondParsedValue == 0)
					{
						RedText("\nОшибка! Деление на ноль невозможно!");
						goto Input_operation;
					}
					result = firstParsedValue / secondParsedValue;
					break;

				default:
					RedText("\nОшибка! Введите корректное значение!");
					goto Input_operation;
			}

			Console.WriteLine("\nРезультат: " + result);

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
							goto Input_firstValue;

						case "n":
						case "N":
							Console.Write("\n");
							goto Input_firstValue;

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
