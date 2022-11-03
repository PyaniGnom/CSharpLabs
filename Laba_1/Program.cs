using System;

namespace Laba_1
{
	class Program
	{
		public static void Main()
		{
			Console.Title = "Laba01_Isaev.N.S_211-327";

			CalculatorLaba1 calculator = new CalculatorLaba1();

			calculator.InputVariable();
			calculator.CalculateResult();
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
