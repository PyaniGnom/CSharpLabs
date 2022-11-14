using System;
using System.IO;
using System.Text;
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
			StringBuilder sb = new();

			sb.AppendLine("New User Input");
			sb.AppendLine("= = = = = =");
			sb.AppendLine(textBox1.Text);
			sb.AppendLine();
			sb.AppendLine();

			using StreamWriter outfile = new(myDocPath + @"\UserInputFile.txt", true);
			await outfile.WriteAsync(sb.ToString());
		}
	}
}
