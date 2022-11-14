using System;
using System.IO;

namespace DirectoryCopyExample
{
	internal static class Program
	{
		private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
		{
			DirectoryInfo directory = new(sourceDirName);
			DirectoryInfo[] directories = directory.GetDirectories();

			if (!directory.Exists)
			{
				throw new DirectoryNotFoundException($"Source directory does not exist or could not be found: {sourceDirName}");
			}

			if (!Directory.Exists(destDirName))
			{
				Directory.CreateDirectory(destDirName);
			}

			FileInfo[] files = directory.GetFiles();
			foreach (var file in files)
			{
				string tempPath = Path.Combine(destDirName, file.Name);
				file.CopyTo(tempPath, false);
			}

			if (copySubDirs)
			{
				foreach (var subDir in directories)
				{
					string tempPath = Path.Combine(destDirName, subDir.Name);
					DirectoryCopy(subDir.FullName, tempPath, true);
				}
			}
		}

		private static void Main()
		{
			/*
			Program program = new();
			program.DirectoryCopy(@"C:\Users\nikit\Desktop\NIKITA\Фото", @"C:\Users\nikit\Desktop", true);
			*/
			/*
			DirectoryInfo directoryInfo = new(@"C:\Users\nikit\Desktop\NIKITA\Фото");
			directoryInfo.EnumerateDirectories();
			*/
			string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
		}
	}
}
