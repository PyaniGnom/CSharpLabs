using System.Text;
using System.Globalization;

namespace Chetnost
{
	class Program
	{
		static void Main()
		{
			
		Input:
			Console.Write("Введите число: ");
			string? inputVariable = Console.ReadLine();
			inputVariable = inputVariable.Replace('.', ',');
			if (!double.TryParse(inputVariable, out double value))
			{
				Console.Beep();
				Console.WriteLine("Ошибка! Повторите ввод");
				goto Input;
			}
			if (value % 2 == 0) Console.WriteLine("Число {0} — чётное", value);
			else Console.WriteLine("Число {0} — нечётное", value);
		}
	}
}