using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DirectoryCopyExample
{
	internal class Program
	{
		private void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
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
				string temppath = Path.Combine(destDirName, file.Name);
				file.CopyTo(temppath, false);
			}
			
			if (copySubDirs)
			{
				foreach (var subdir in directories)
				{
					string temppath = Path.Combine(destDirName, subdir.Name);
					DirectoryCopy(subdir.FullName, temppath, copySubDirs);
				}
			}
		}

		static void Main()
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
