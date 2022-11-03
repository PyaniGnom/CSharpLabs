using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Перечисление_коллекции_объектов_FileInfo_во_всех_каталогах
{
	internal class Program
	{
		static void Main()
		{
			DirectoryInfo diTop = new DirectoryInfo(@"D:\");
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
					catch (UnauthorizedAccessException UnAuthDir)
					{
						Console.WriteLine($"{UnAuthDir.Message}");
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
							catch (UnauthorizedAccessException UnAuthSubDir)
							{
								Console.WriteLine($"UnAuthSubDir: {UnAuthSubDir.Message}");
							}
						}
					}
					catch (UnauthorizedAccessException UnAuthSubDir)
					{
						Console.WriteLine($"UnAuthSubDir: {UnAuthSubDir.Message}");
					}
				}
			}
			catch (DirectoryNotFoundException DirNotFound)
			{
				Console.WriteLine($"{DirNotFound.Message}");
			}
			catch (UnauthorizedAccessException UnAuthDir)
			{
				Console.WriteLine($"UnAuthDir: {UnAuthDir.Message}");
			}
			catch (PathTooLongException LongPath)
			{
				Console.WriteLine($"{LongPath.Message}");
			}
		}
	}
}
