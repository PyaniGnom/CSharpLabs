using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace ReadAndWriteCSV
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void ReadFile()
		{
			try
			{
				dataGridView.Rows.Clear();
				using (TextFieldParser parser = new TextFieldParser(cbFiles.Text))
				{
					parser.TextFieldType = FieldType.Delimited;
					parser.SetDelimiters(";");
					while (!parser.EndOfData)
					{
						string[] fields = parser.ReadFields();
						dataGridView.Rows.Add(fields[0], fields[1]);
					}
				}
			}
			catch (Exception Exc)
			{
				MessageBox.Show(Exc.Message);
			}
		}

		private void GetFiles()
		{
			try
			{
				var files = from file in Directory.EnumerateFiles(@"D:\C_Sharp\Praktika_5\ReadAndWriteCSV\bin\Debug", "*.csv", System.IO.SearchOption.AllDirectories)
							select new
							{
								File = file
							};

				foreach (var f in files)
				{
					cbFiles.Items.Add(Path.GetFileName(f.File));
				}
			}
			catch (Exception Exc)
			{
				MessageBox.Show(Exc.Message);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			cbFiles.DropDownStyle = ComboBoxStyle.DropDownList;

			GetFiles();
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			if (cbFiles.SelectedIndex != -1)
			{
				ReadFile();
			}
			else
			{
				MessageBox.Show("Сначала выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnWrite_Click(object sender, EventArgs e)
		{
			if (cbFiles.SelectedIndex == -1)
			{
				MessageBox.Show("Сначала выберите файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else if (txtSurname.Text == "" && txtName.Text == "")
			{
				MessageBox.Show("Сначала зааполните поля \"Фамилия\" и \"Имя\"", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				StringBuilder stringBuilder = new StringBuilder();

				stringBuilder.AppendLine();
				stringBuilder.AppendLine($"{txtSurname.Text};{txtName.Text}");

				using (StreamWriter outLine = new StreamWriter(cbFiles.Text, true))
				{
					outLine.Write(stringBuilder.ToString());
				}

				ReadFile();
			}
		}
	}
}
