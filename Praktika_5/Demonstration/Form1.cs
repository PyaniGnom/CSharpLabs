using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
// ReSharper disable StringLiteralTypo

namespace Demonstration
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnTask1_Click(object sender, EventArgs e)
		{
			try
			{
				richTextBox.Clear();

				string dirPath = $@"{txtPath.Text}";

				List<string> dirs = new(Directory.EnumerateDirectories(dirPath));

				foreach (string dir in dirs)
				{
					richTextBox.Text += $"{dir.Substring(dir.LastIndexOf("\\", StringComparison.Ordinal) + 1)}\n";
				}
				richTextBox.Text += $"\n{dirs.Count} каталогов найдено.";
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show($"\nНе удалось найти указанный путь: {txtPath.Text}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (UnauthorizedAccessException uaEx)
			{
				richTextBox.Text += $"\n{uaEx.Message}";
			}
			catch (PathTooLongException)
			{
				MessageBox.Show("Путь файла слишком большой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTask2_Click(object sender, EventArgs e)
		{
			try
			{
				richTextBox.Clear();

				var files = from file in Directory.EnumerateFiles($@"{txtPath.Text}", $"*.{txtTask2.Text}", SearchOption.AllDirectories)
							select new
							{
								File = file
							};

				var filesList = files.ToList();
				foreach (var file in filesList)
				{
					richTextBox.Text += $"{Path.GetFileName(file.File)}\n";
				}
				richTextBox.Text += $"\n{filesList.Count()} файлов найдено.";
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show($"\nНе удалось найти указанный путь: {txtPath.Text}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			catch (UnauthorizedAccessException uaEx)
			{
				richTextBox.Text += $"\n{uaEx.Message}";
			}
			catch (PathTooLongException)
			{
				MessageBox.Show("Путь файла слишком большой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTask3_Click(object sender, EventArgs e)
		{
			richTextBox.Clear();

			try
			{
				DirectoryInfo dirPrograms = new($@"{txtPath.Text}");

				if (int.TryParse(txtTask3Year.Text, out _) && int.TryParse(txtTask3Month.Text, out _) && int.TryParse(txtTask3Day.Text, out _))
				{
					try
					{
						DateTime startOf = new(int.Parse(txtTask3Year.Text), int.Parse(txtTask3Month.Text), int.Parse(txtTask3Day.Text));

						var dirs = from dir in dirPrograms.EnumerateDirectories()
								   where dir.CreationTimeUtc > startOf
								   select new
								   {
									   ProgDir = dir
								   };
						foreach (var dir in dirs)
						{
							richTextBox.Text += $"{dir.ProgDir.Name}\n";
						}
					}
					catch (UnauthorizedAccessException uaEx)
					{
						richTextBox.Text += $"\n{uaEx.Message}";
					}
					catch (PathTooLongException)
					{
						MessageBox.Show("Путь файла слишком большой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					catch (ArgumentOutOfRangeException)
					{
						MessageBox.Show("Введите дату в правильном формате!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("Введите корректные значения в поля даты", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (DirectoryNotFoundException)
			{
				MessageBox.Show($"\nНе удалось найти указанный путь: {txtPath.Text}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnTask4_Click(object sender, EventArgs e)
		{
			richTextBox.Clear();

			DirectoryInfo dirTop = new($@"{txtPath.Text}");

			if (double.TryParse(txtTask4.Text, out _))
			{
				try
				{
					foreach (var file in dirTop.EnumerateFiles())
					{
						try
						{
							if (file.Length > double.Parse(txtTask4.Text) * 1000000)
							{
								richTextBox.Text += $"{file.FullName}\t\t{file.Length:N0}\n";
							}
						}
						catch (UnauthorizedAccessException uaEx)
						{
							richTextBox.Text += $"\n{uaEx.Message}";
						}
					}

					foreach (var dir in dirTop.EnumerateDirectories("*"))
					{
						try
						{
							foreach (var file in dir.EnumerateFiles("*", SearchOption.AllDirectories))
							{
								try
								{
									if (file.Length > double.Parse(txtTask4.Text) * 1000000)
									{
										richTextBox.Text += $"{file.FullName}\t\t{file.Length:N0}\n";
									}
								}
								catch (UnauthorizedAccessException uaEx)
								{
									richTextBox.Text += $"\n{uaEx.Message}";
								}
							}
						}
						catch (UnauthorizedAccessException uaEx)
						{
							richTextBox.Text += $"\n{uaEx.Message}";
						}
					}
				}
				catch (DirectoryNotFoundException)
				{
					MessageBox.Show($"\nНе удалось найти указанный путь: {txtPath.Text}!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (UnauthorizedAccessException uaEx)
				{
					richTextBox.Text += $"\n{uaEx.Message}";
				}
				catch (PathTooLongException)
				{
					MessageBox.Show("Путь файла слишком большой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Введите корректное значение в поле размера", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void txtTask3Day_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			else if (txtTask3Day.TextLength == 2)
			{
				if (e.KeyChar == (char)Keys.Back)
				{
					return;
				}
				e.Handled = true;
			}
		}

		private void txtTask3Month_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			else if (txtTask3Month.TextLength == 2)
			{
				if (e.KeyChar == (char)Keys.Back)
				{
					return;
				}
				e.Handled = true;
			}
		}

		private void txtTask3Year_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
			else if (txtTask3Year.TextLength == 4)
			{
				if (e.KeyChar == (char)Keys.Back)
				{
					return;
				}
				e.Handled = true;
			}
		}

		private void txtTask4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtTask4.Text.Contains('.') && !txtTask4.Text.Contains(','))
			{
				if (txtTask4.Text == "")
				{
					txtTask4.Text = "0,";
					txtTask4.SelectionStart = txtTask4.TextLength;
					e.Handled = true;
					return;
				}
				e.KeyChar = ',';
			}
			else
			{
				e.Handled = true;
			}
		}
	}
}
