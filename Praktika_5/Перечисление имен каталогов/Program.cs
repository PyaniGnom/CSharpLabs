using System;
using System.Collections.Generic;
using System.IO;

namespace Перечисление_имен_каталогов
{
	internal static class Program
	{
		private static void Main()
		{
			try
			{
				const string dirPath = @"C:\Windows\System32";

				List<string> dirs = new(Directory.EnumerateDirectories(dirPath));

				foreach (string dir in dirs)
				{
					Console.WriteLine($"{dir.Substring(dir.LastIndexOf("\\", StringComparison.Ordinal) + 1)}");
				}
				Console.WriteLine($"\n{dirs.Count} directories found.");
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
