using System;
using System.IO;
using System.Linq;
// ReSharper disable StringLiteralTypo

namespace Перечисление_имен_файлов_в_каталоге_и_подкаталогах
{
	internal static class Program
	{
		private static void Main()
		{
			try
			{
				var files = from file in Directory.EnumerateFiles(@"C:\Users\nikit\Desktop", "*.txt", SearchOption.AllDirectories)
							select new
							{
								File = file
							};

				var filesList = files.ToList();
				foreach (var file in filesList)
				{
					Console.WriteLine($"{Path.GetFileName(file.File)}");
				}
				Console.WriteLine($"{filesList.Count()} files found.");
			}
			catch (UnauthorizedAccessException uaEx)
			{
				Console.WriteLine(uaEx.Message);
			}
			catch (PathTooLongException pathEx)
			{
				Console.WriteLine(pathEx.Message);
			}
		}
	}
}
