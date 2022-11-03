using System;

namespace Laba_1
{
	class CalculatorLaba1
	{
		private double _variable;
		private double _result;

		/// <summary>
		/// Запрашивает ввод зачения с консоли.
		/// </summary>
		public void InputVariable()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Введите значение для X: ");

				_variable = double.Parse(Console.ReadLine().Replace('.', ','));
			}
			catch
			{
				ErrorOutput("\nОшибка! Введите корректное значение!\n");
				InputVariable();
			}
		}

		/// <summary>
		/// Вычисляет итоговое значение по формуле (зависит от входного значения).
		/// </summary>
		public void CalculateResult()
		{
			if (Math.Abs(_variable) > 3)
				_result = Math.Pow(Math.Pow(Math.Abs(_variable + 2), 1.45), 2) + 5;

			else if (Math.Abs(_variable) <= 1)
				_result = Math.Pow(Math.Cos(_variable), -1.9) + 3;
		}

		/// <summary>
		/// Выводит итоговое значение на консоль.
		/// </summary>
		public void OutputResult()
		{
			Console.ForegroundColor = ConsoleColor.White;

			if (Math.Abs(_variable) > 3)
			{
				Console.WriteLine($"При X = {_variable} функция вычисляется по формуле Y = Sqr(Abs(x + 2)^1.45) + 5. Результат = {_result}");
			}
			else if (Math.Abs(_variable) <= 1)
			{
				Console.WriteLine($"При X = {_variable} функция вычисляется по формуле Y = Cos(x)^(-1.9) + 3. Результат = {_result}");
			}
			else
			{
				Console.WriteLine($"При X = {_variable} функция не определена");
			}
		}

		/// <summary>
		/// Запрашивает ввод на согласие продолжить с консоли.
		/// </summary>
		public void InputContinue()
		{
			Console.ForegroundColor = ConsoleColor.Green;
			Console.Write("\nХотите продолжить? [Y/N]: ");

			switch (Console.ReadLine())
			{
				case "y":
				case "Y":
					InputClear();
					break;

				case "n":
				case "N":
					Console.ResetColor();
					break;

				default:
					ErrorOutput("\nОшибка! К вводу доступны только символы 'Y' и 'N'!");
					InputContinue();
					break;
			}
		}

		private void InputClear()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.Write("Очистить консоль перед началом? [Y/N]: ");

			switch (Console.ReadLine())
			{
				case "y":
				case "Y":
					{
						Console.Clear();
						Program.Main();
						break;
					}

				case "n":
				case "N":
					{
						Console.Write("\n");
						Program.Main();
						break;
					}
				default:
					{
						ErrorOutput("\nОшибка! К вводу доступны только символы 'Y' и 'N'!\n");
						InputClear();
						break;
					}
			}
		}

		private void ErrorOutput(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}
}
