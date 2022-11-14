using System;
using System.Text;
using System.IO;

namespace Создание_приложения_для_записи_файла
{
	internal static class Program
	{
		private static void Main()
		{
			string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			StringBuilder sb = new();

			foreach (string txtName in Directory.EnumerateFiles(myDocPath, "*.txt"))
			{
				using (StreamReader sr = new(txtName))
				{
					sb.AppendLine(txtName);
					sb.AppendLine("= = = = = =");
					sb.Append(sr.ReadToEnd());
					sb.AppendLine();
					sb.AppendLine();
				}

				using (StreamWriter outFile = new(myDocPath + @"\AllTxtFiles.txt"))
				{
					outFile.Write(sb.ToString());
				}
			}
		}
	}
}
