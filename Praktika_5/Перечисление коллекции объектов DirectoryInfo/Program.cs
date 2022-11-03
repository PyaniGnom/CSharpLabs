using System;
using System.IO;
using System.Linq;

namespace Перечисление_коллекции_объектов_DirectoryInfo
{
	internal class Program
	{
		static void Main()
		{
			DirectoryInfo dirPrograms = new DirectoryInfo(@"C:\Program Files");
			DateTime StartOf2022 = new DateTime(2022, 03, 01);

			var dirs = from dir in dirPrograms.EnumerateDirectories()
					   where dir.CreationTimeUtc < StartOf2022
					   select new
					   {
						   ProgDir = dir
					   };
			foreach (var di in dirs)
			{
				Console.WriteLine($"{di.ProgDir.Name}");
			}
		}
	}
}
