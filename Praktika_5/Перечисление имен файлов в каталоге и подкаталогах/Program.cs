using System;
using System.IO;
using System.Linq;

namespace Перечисление_имен_файлов_в_каталоге_и_подкаталогах
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				var files = from file in Directory.EnumerateFiles(@"C:\Users\nikit\Desktop", "*.txt", SearchOption.AllDirectories)
							select new
							{
								File = file
							};

				foreach (var f in files)
				{
					Console.WriteLine($"{Path.GetFileName(f.File)}");
				}
				Console.WriteLine($"{files.Count()} files found.");
			}
			catch (UnauthorizedAccessException UAEx)
			{
				Console.WriteLine(UAEx.Message);
			}
			catch (PathTooLongException PathEx)
			{
				Console.WriteLine(PathEx.Message);
			}
		}
	}
}
