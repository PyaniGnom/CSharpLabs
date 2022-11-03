using System;
using System.Collections.Generic;
using System.IO;

namespace Перечисление_имен_каталогов
{
	internal class Program
	{
		static void Main()
		{
			try
			{
				string dirPath = @"C:\Windows\System32";

				List<string> dirs = new List<string>(Directory.EnumerateDirectories(dirPath));

				foreach (var dir in dirs)
				{
					Console.WriteLine($"{dir.Substring(dir.LastIndexOf("\\") + 1)}");
				}
				Console.WriteLine($"\n{dirs.Count} directories found.");
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
