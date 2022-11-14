using System;
using System.IO;

namespace Создание_приложения_для_считывания_данных_из_файла
{
	internal static class Program
	{
		private static void Main()
		{
			try
			{
				using StreamReader sr = new(@"C:\Users\nikit\Desktop\Presentation.txt");
				string line = sr.ReadToEnd();
				Console.WriteLine(line);
			}
			catch (Exception e)
			{
				Console.WriteLine("The file could not be read:");
				Console.WriteLine(e.Message);
			}
		}
	}
}
