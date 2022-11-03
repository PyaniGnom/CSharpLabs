using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Создание_приложения_для_записи_файла
{
	internal class Program
	{
		static void Main()
		{
			string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			StringBuilder sb = new StringBuilder();

			foreach (string txtName in Directory.EnumerateFiles(myDocPath, "*.txt"))
			{
				using (StreamReader sr = new StreamReader(txtName))
				{
					sb.AppendLine(txtName.ToString());
					sb.AppendLine("= = = = = =");
					sb.Append(sr.ReadToEnd());
					sb.AppendLine();
					sb.AppendLine();
				}

				using (StreamWriter outFile = new StreamWriter(myDocPath + @"\AllTxtFiles.txt"))
				{
					outFile.Write(sb.ToString());
				}
			}
		}
	}
}
