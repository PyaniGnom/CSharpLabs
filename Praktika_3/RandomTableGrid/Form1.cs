﻿using System;
using System.Windows.Forms;

namespace RandomTableGrid
{
	public partial class Form1 : Form
	{
		private int _rowsCount;
		private int _columnsCount;

		public Form1()
		{
			InitializeComponent();
		}

		private int[,] CreateArray()
		{
			int[,] myArray = new int[_rowsCount, _columnsCount];

			Random random = new Random();

			for (int y = 0; y < myArray.GetLength(0); y++)
			{
				for (int x = 0; x < myArray.GetLength(1); x++)
				{
					myArray[y, x] = random.Next(0, 100);
				}
			}

			return myArray;
		}

		private void CreateGrid(int[,] Array)
		{
			dataGridView.RowCount = _rowsCount;
			dataGridView.ColumnCount = _columnsCount;

			for (int y = 0; y < dataGridView.RowCount; y++)
			{
				for (int x = 0; x < dataGridView.ColumnCount; x++)
				{
					dataGridView[x, y].Value = Array[y, x];
				}
			}
		}

		private bool RowsConverting()
		{
			if (int.TryParse(tRowsCount.Text, out _rowsCount) && _rowsCount > 0 && _rowsCount <= 500)
			{
				return true;
			}
			else
			{
				tRowsCount.Text = "Введите значение от 1 до 500!";
				return false;
			}
		}

		private bool ColumnsConverting()
		{
			if (int.TryParse(tColumnsCount.Text, out _columnsCount) && _columnsCount > 0 && _columnsCount <= 500)
			{
				return true;
			}
			else
			{
				tColumnsCount.Text = "Введите значение от 1 до 500!";
				return false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (RowsConverting() & ColumnsConverting())
			{
				CreateGrid(CreateArray());
			}
		}

		private void tRowsCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
				return;
			else
				e.Handled = true;
		}

		private void tColumnsCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
				return;
			else
				e.Handled = true;
		}

		private void tRowsCount_MouseClick(object sender, MouseEventArgs e)
		{
			if (tRowsCount.Text == "Введите значение от 1 до 500!")
			{
				tRowsCount.Text = "";
			}
		}

		private void tColumnsCount_MouseClick(object sender, MouseEventArgs e)
		{
			if (tColumnsCount.Text == "Введите значение от 1 до 500!")
			{
				tColumnsCount.Text = "";
			}
		}

	}
}
