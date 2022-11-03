using System;

namespace Praktika_1
{
	/// <summary>
	/// Предоставляет инструменты для выполнения 1 Практики.
	/// </summary>
	class Calculator
	{
		public double FirstVariable { get { return _firstVariable; } }
		public double SecondVariable { get { return _secondVariable; } }
		public double Result { get { return _result; } }

		private double _firstVariable;
		private double _secondVariable;
		private double _result;

		/// <summary>
		/// Запрашивает ввод первой переменной с консоли.
		/// </summary>
		public void InputFirstVariable()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Введите первое число: ");

				_firstVariable = double.Parse(Console.ReadLine().Replace('.', ','));
			}
			catch
			{
				ErrorOutput("\nОшибка! Введите корректное значение!\n");
				InputFirstVariable();
			}
		}

		/// <summary>
		/// Запрашивает ввод второй переменной с консоли.
		/// </summary>
		public void InputSecondVariable()
		{
			try
			{
				Console.ForegroundColor = ConsoleColor.DarkGray;
				Console.WriteLine("\nЕсли хотите вернуться к вводу первого числа, введите (без кавычек): 'go start'");

				Console.ForegroundColor = ConsoleColor.White;
				Console.Write("Введите второе число: ");

				string input = Console.ReadLine().Replace('.', ',');

				if (input == "go start")
				{
					Console.Write("\n");
					Program.Main();
				}

				_secondVariable = double.Parse(input);
			}
			catch
			{
				ErrorOutput("\nОшибка! Введите корректное значение!");
				InputSecondVariable();
			}
		}

		/// <summary>
		/// Запрашивает ввод математического действия с консоли.
		/// </summary>
		public void InputAction()
		{
			Console.ForegroundColor = ConsoleColor.DarkGray;
			Console.WriteLine("\nЕсли хотите вернуться к вводу первого числа, введите (без кавычек): 'go start'");

			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("Теперь выберете одно из действий (введите без кавычек):\n'+', '-', '*', '/'");

			switch (Console.ReadLine())
			{
				case "go start":
					{
						Console.WriteLine();
						Program.Main();
						break;
					}

				case "+":
					{
						Add();
						break;
					}

				case "-":
					{
						Subtract();
						break;
					}

				case "*":
					{
						Multiply();
						break;
					}

				case "/":
					{
						try
						{
							Divide();
						}
						catch
						{
							ErrorOutput("\nДелить на ноль нельзя! Выберете другое действие или введите другие значения");
							InputAction();
						}
						break;
					}

				default:
					{
						ErrorOutput("\nОшибка! Введите корректное значение!");
						InputAction();
						break;
					}
			}
		}

		/// <summary>
		/// Выводит итоговое значение на консоль.
		/// </summary>
		public void OutputResult()
		{
			Console.WriteLine($"\nРезультат: {_result}");
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
					{
						InputClear();
						break;
					}

				case "n":
				case "N":
					{
						Console.ResetColor();
						break;
					}

				default:
					{
						ErrorOutput("\nОшибка! К вводу доступны только символы 'Y' и 'N'!");
						InputContinue();
						break;
					}
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

		private double Add()
		{
			_result = _firstVariable + _secondVariable;
			return _result;
		}

		private double Subtract()
		{
			_result = _firstVariable - _secondVariable;
			return _result;
		}

		private double Multiply()
		{
			_result = _firstVariable * _secondVariable;
			return _result;
		}

		private double Divide()
		{
			if (_secondVariable == 0)
			{
				throw new ArgumentOutOfRangeException(nameof(_secondVariable));
			}
			else
			{
				_result = _firstVariable + _secondVariable;
				return _result;
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
