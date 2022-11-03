using System;

namespace Praktika_1
{
	class Program
	{
		public static void Main()
		{
			Calculator calculator = new Calculator();

			Console.Title = "Простой калькулятор | Practice01_Isaev.N.S_211-327";

			calculator.InputFirstVariable();
			calculator.InputSecondVariable();
			calculator.InputAction();
			calculator.OutputResult();
			calculator.InputContinue();

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nРабота завершена! Для закрытия консоли, нажмите клавишу ENTER");
			Console.ResetColor();
			Console.ReadLine();

			Environment.Exit(0);
		}
	}
}
