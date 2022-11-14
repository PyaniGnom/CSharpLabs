using System;
using System.IO;
using System.Linq;

namespace Перечисление_коллекции_объектов_DirectoryInfo
{
	internal static class Program
	{
		private static void Main()
		{
			DirectoryInfo dirPrograms = new(@"C:\Program Files");
			DateTime startOf = new(2022, 03, 01);

			var dirs = from dir in dirPrograms.EnumerateDirectories()
					   where dir.CreationTimeUtc < startOf
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
