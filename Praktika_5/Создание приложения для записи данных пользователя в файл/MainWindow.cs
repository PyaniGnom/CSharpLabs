using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Создание_приложения_для_записи_данных_пользователя_в_файл
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private async void button1_Click(object sender, EventArgs e)
		{
			string myDocPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			StringBuilder sb = new StringBuilder();

			sb.AppendLine("New User Input");
			sb.AppendLine("= = = = = =");
			sb.AppendLine(textBox1.Text);
			sb.AppendLine();
			sb.AppendLine();

			using (StreamWriter outfile = new StreamWriter(myDocPath + @"\UserInputFile.txt", true))
			{
				await outfile.WriteAsync(sb.ToString());
			}
		}
	}
}
