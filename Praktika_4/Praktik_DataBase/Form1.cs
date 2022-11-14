using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
// ReSharper disable StringLiteralTypo

namespace Praktik_DataBase
{
	public partial class Form1 : Form
	{
		private string _sourceTable = "Отечественные_авторы";

		private int _selectedRow;
		private bool _isEditing;

		private OleDbConnection _oleDbConnection;
		private OleDbCommandBuilder _oleDbBuilder;
		private OleDbDataAdapter _oleDbDataAdapter;
		private readonly DataSet _dataSet = new();

		public Form1()
		{
			InitializeComponent();
		}

		private void LoadData()
		{
			_oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM {_sourceTable} ORDER BY [Код_книги]", _oleDbConnection);

			_oleDbBuilder = new OleDbCommandBuilder(_oleDbDataAdapter);

			_oleDbBuilder.GetInsertCommand();
			_oleDbBuilder.GetUpdateCommand();
			_oleDbBuilder.GetDeleteCommand();

			_oleDbDataAdapter.Fill(_dataSet);

			dataGridView.DataSource = _dataSet.Tables[0];
		}

		private void ReloadData()
		{
			_dataSet.Tables[0].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM {_sourceTable}  ORDER BY [Код_книги]", _oleDbConnection);

			_oleDbBuilder = new OleDbCommandBuilder(_oleDbDataAdapter);

			_oleDbBuilder.GetInsertCommand();
			_oleDbBuilder.GetUpdateCommand();
			_oleDbBuilder.GetDeleteCommand();

			_oleDbDataAdapter.Fill(_dataSet);

			dataGridView.DataSource = _dataSet.Tables[0];
		}

		private void ClearField()
		{
			txtSearch.Text = "";
			txtCode.Text = "";
			txtAuthor.Text = "";
			txtTitle.Text = "";
			txtYear.Text = "";

			dataGridView.ClearSelection();
			_isEditing = false;
		}

		private string IsFieldFilledCorrectly()
		{
			string errorString;

			if (txtCode.Text != "" && txtAuthor.Text != "" && txtTitle.Text != "" && txtYear.Text != "")
			{
				if (uint.TryParse(txtCode.Text, out _) && uint.TryParse(txtYear.Text, out _))
				{
					if (uint.Parse(txtCode.Text) <= 2147483647 && uint.Parse(txtYear.Text) <= DateTime.Now.Year &&
						txtAuthor.Text.Length <= 255 && txtTitle.Text.Length <= 255)
					{
						errorString = "OK";
					}
					else
					{
						errorString = "BIG";
					}
				}
				else
				{
					errorString = "ERROR";
				}
			}
			else
			{
				errorString = "EMPTY";
			}

			return errorString;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblError.Visible = false;

			_oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C_Sharp\Praktika_4\Praktik_DataBase\Microsoft Access Database.accdb;Persist Security Info=True");

			_oleDbConnection.Open();

			LoadData();

			DataGridViewColumn column0 = dataGridView.Columns[0];
			column0.Width = 95;
			column0.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			column0.Resizable = DataGridViewTriState.False;

			DataGridViewColumn column1 = dataGridView.Columns[1];
			column1.Width = 215;
			column1.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			column1.Resizable = DataGridViewTriState.False;

			DataGridViewColumn column2 = dataGridView.Columns[2];
			column2.Width = 232;
			column2.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
			column2.Resizable = DataGridViewTriState.False;

			DataGridViewColumn column3 = dataGridView.Columns[3];
			column3.Width = 140;
			column3.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
			column3.Resizable = DataGridViewTriState.False;

			ReloadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			ReloadData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			try
			{
				if (_isEditing)
				{
					lblError.Visible = true;
					lblError.Text = "Сначала закончите редактировнаие строки!";
				}
				else
				{
					switch (IsFieldFilledCorrectly())
					{
						case "OK":
							_dataSet.Tables[0].Rows.Add();
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][0] = txtCode.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][1] = txtAuthor.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][2] = txtTitle.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][3] = txtYear.Text;

							ClearField();

							_oleDbDataAdapter.Update(_dataSet.Tables[0]);
							break;

						case "BIG":
							lblError.Visible = true;
							lblError.Text = "Введенное(ые) значение(я)\nслишком большое(ые)!";
							break;

						case "EMPTY":
							lblError.Visible = true;
							lblError.Text = "Заполните все поля!";
							break;

						case "ERROR":
							lblError.Visible = true;
							lblError.Text = "Введите корректные значения!";
							break;
					}
				}
			}
			catch
			{
				ReloadData();
				lblError.Visible = true;
				lblError.Text = "Книга с таким кодом уже существует!";
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (dataGridView.SelectedRows.Count != 0)
			{
				if (MessageBox.Show("Вы уверены, что хотите удалить эту строку(ки)?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
					== DialogResult.Yes)
				{
					foreach (DataGridViewRow rows in dataGridView.SelectedRows)
						dataGridView.Rows.RemoveAt(rows.Index);

					_oleDbDataAdapter.Update(_dataSet.Tables[0]);
				}
				else
				{
					dataGridView.ClearSelection();
				}
			}
			else
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите строку(ки)!";
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (dataGridView.SelectedRows.Count == 0)
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите строку!";
			}
			else if (dataGridView.SelectedRows.Count > 1)
			{
				lblError.Visible = true;
				lblError.Text = "Выберите только одну строку!";
			}
			else
			{
				_isEditing = true;
				_selectedRow = dataGridView.SelectedRows[0].Index;
				dataGridView.ClearSelection();

				txtCode.Text = _dataSet.Tables[0].Rows[_selectedRow][0].ToString();
				txtAuthor.Text = _dataSet.Tables[0].Rows[_selectedRow][1].ToString();
				txtTitle.Text = _dataSet.Tables[0].Rows[_selectedRow][2].ToString();
				txtYear.Text = _dataSet.Tables[0].Rows[_selectedRow][3].ToString();
			}
		}

		private void btnSaveEdit_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			try
			{
				if (_isEditing)
				{
					switch (IsFieldFilledCorrectly())
					{
						case "OK":
							if (MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Вы уверены?",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							{
								_dataSet.Tables[0].Rows[_selectedRow][0] = txtCode.Text;
								_dataSet.Tables[0].Rows[_selectedRow][1] = txtAuthor.Text;
								_dataSet.Tables[0].Rows[_selectedRow][2] = txtTitle.Text;
								_dataSet.Tables[0].Rows[_selectedRow][3] = txtYear.Text;

								_oleDbDataAdapter.Update(_dataSet.Tables[0]);

								_isEditing = false;

								ClearField();
							}
							break;

						case "BIG":
							lblError.Visible = true;
							lblError.Text = "Введенное(ые) значение(я)\nслишком большое(ые)!";
							break;

						case "EMPTY":
							lblError.Visible = true;
							lblError.Text = "Заполните все поля!";
							break;

						case "ERROR":
							lblError.Visible = true;
							lblError.Text = "Введите корректные значения!";
							break;
					}
				}
				else
				{
					lblError.Visible = true;
					lblError.Text = "Сначала выберите строку для\nредактирования! Подсказка:\nвыберите строку в таблице\nи нажмите\"Изменить\"";
				}
			}
			catch
			{
				lblError.Visible = true;
				lblError.Text = "Книга с таким кодом уже\nсуществует!";
				ReloadData();
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			ClearField();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (txtSearch.Text != "")
			{
				_dataSet.Clear();

				_oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM {_sourceTable} WHERE Автор LIKE '%{txtSearch.Text}%'", _oleDbConnection);

				_oleDbBuilder = new OleDbCommandBuilder(_oleDbDataAdapter);

				_oleDbBuilder.GetInsertCommand();
				_oleDbBuilder.GetUpdateCommand();
				_oleDbBuilder.GetDeleteCommand();

				_oleDbDataAdapter.Fill(_dataSet);

				dataGridView.DataSource = _dataSet.Tables[0];
			}
			else
			{
				lblError.Visible = true;
				lblError.Text = "Сначала введите запрос";
			}

		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			_dataSet.Clear();
			txtSearch.Text = "";
			LoadData();
		}

		private void tsmTable1_Click(object sender, EventArgs e)
		{
			_dataSet.Clear();

			_sourceTable = "Отечественные_авторы";
			LoadData();
		}

		private void tsmTable2_Click(object sender, EventArgs e)
		{
			_dataSet.Clear();

			_sourceTable = "Зарубежные_авторы";
			ReloadData();
		}

		private void tsmExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtSearch_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void ToolStripMenuItemFile_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtCode_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtAuthor_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtTitle_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtYear_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}
	}
}
