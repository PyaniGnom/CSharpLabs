using System;
using System.IO;

namespace Перечисление_коллекции_объектов_FileInfo_во_всех_каталогах
{
	internal static class Program
	{
		private static void Main()
		{
			DirectoryInfo diTop = new(@"D:\");
			try
			{
				foreach (var fi in diTop.EnumerateFiles())
				{
					try
					{
						if (fi.Length > 10000000)
						{
							Console.WriteLine($"{fi.FullName}\t\t{fi.Length:N0}");
						}
					}
					catch (UnauthorizedAccessException unAuthDir)
					{
						Console.WriteLine($"{unAuthDir.Message}");
					}
				}

				foreach (var di in diTop.EnumerateDirectories("*"))
				{
					try
					{
						foreach (var fi in di.EnumerateFiles("*", SearchOption.AllDirectories))
						{
							try
							{
								if (fi.Length > 10000000)
								{
									Console.WriteLine($"{fi.FullName}\t\t{fi.Length:N0}");
								}
							}
							catch (UnauthorizedAccessException unAuthSubDir)
							{
								Console.WriteLine($"UnAuthSubDir: {unAuthSubDir.Message}");
							}
						}
					}
					catch (UnauthorizedAccessException unAuthSubDir)
					{
						Console.WriteLine($"UnAuthSubDir: {unAuthSubDir.Message}");
					}
				}
			}
			catch (DirectoryNotFoundException dirNotFound)
			{
				Console.WriteLine($"{dirNotFound.Message}");
			}
			catch (UnauthorizedAccessException unAuthDir)
			{
				Console.WriteLine($"UnAuthDir: {unAuthDir.Message}");
			}
			catch (PathTooLongException longPath)
			{
				Console.WriteLine($"{longPath.Message}");
			}
		}
	}
}
