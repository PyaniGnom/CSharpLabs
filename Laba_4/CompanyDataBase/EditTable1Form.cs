using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CompanyDataBase
{
	public partial class EditTable1Form : Form
	{
		private int _selectedRow;
		private bool _isEditing;
		private const string ConnectionString =
			@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\myrep\C_Sharp\Laba_4\CompanyDataBase\LR4.accdb;Persist Security Info=True";

		private OleDbConnection _oleDbConnection;
		private OleDbCommandBuilder _oleDbBuilder;
		private OleDbDataAdapter _oleDbDataAdapter;
		private readonly DataSet _dataSet = new();
		private readonly Query _queries = new();

		public EditTable1Form()
		{
			InitializeComponent();
		}

		private void LoadData()
		{
			_oleDbDataAdapter = new OleDbDataAdapter(_queries.Table1(), _oleDbConnection);

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

			_oleDbDataAdapter = new OleDbDataAdapter(_queries.Table1(), _oleDbConnection);

			_oleDbBuilder = new OleDbCommandBuilder(_oleDbDataAdapter);

			_oleDbBuilder.GetInsertCommand();
			_oleDbBuilder.GetUpdateCommand();
			_oleDbBuilder.GetDeleteCommand();

			_oleDbDataAdapter.Fill(_dataSet);

			dataGridView.DataSource = _dataSet.Tables[0];
		}

		private void ClearField()
		{
			txtCode.Text = "";
			txtName.Text = "";
			txtAddress.Text = "";

			_isEditing = false;
		}

		private string IsFieldFilledCorrectly()
		{
			string errorString;

			if (txtCode.Text != "" && txtName.Text != "" && txtAddress.Text != "")
			{
				if (uint.TryParse(txtCode.Text, out _))
				{
					if (uint.Parse(txtCode.Text) <= 2147483647 && txtName.Text.Length <= 255 && txtAddress.Text.Length <= 255)
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

		private void EditTable1Form_Load(object sender, EventArgs e)
		{
			_oleDbConnection = new OleDbConnection(ConnectionString);

			_oleDbConnection.Open();

			LoadData();

			DataGridViewColumn column0 = dataGridView.Columns[0];
			column0.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column1 = dataGridView.Columns[1];
			column1.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column2 = dataGridView.Columns[2];
			column2.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			ReloadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ReloadData();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (_isEditing)
				{
					MessageBox.Show("Сначала закончите редактировнаие строки!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else
				{
					switch (IsFieldFilledCorrectly())
					{
						case "OK":
							_dataSet.Tables[0].Rows.Add();
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][0] = txtCode.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][1] = txtName.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][2] = txtAddress.Text;

							ClearField();

							_oleDbDataAdapter.Update(_dataSet.Tables[0]);
							break;

						case "BIG":
							MessageBox.Show("Введенное(ые) значение(я) слишком большое(ые)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;

						case "EMPTY":
							MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;

						case "ERROR":
							MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
					}
				}
			}
			catch
			{
				ReloadData();
				MessageBox.Show("Предприятие с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count != 0)
			{
				if (MessageBox.Show("Вы уверены, что хотите удалить эту строку(ки)?\nВсе связанные записи в таблице изделий тоже удалятся!",
						"Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
				MessageBox.Show("Сначала выберите строку(ки)!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			switch (dataGridView.SelectedRows.Count)
			{
				case 0:
					MessageBox.Show("Сначала выберите строку!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;

				case > 1:
					MessageBox.Show("Выберите только одну строку!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					break;

				default:
					_isEditing = true;
					_selectedRow = dataGridView.SelectedRows[0].Index;
					dataGridView.ClearSelection();

					txtCode.Text = _dataSet.Tables[0].Rows[_selectedRow][0].ToString();
					txtName.Text = _dataSet.Tables[0].Rows[_selectedRow][1].ToString();
					txtAddress.Text = _dataSet.Tables[0].Rows[_selectedRow][2].ToString();
					break;
			}
		}

		private void btnSaveEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (_isEditing)
				{
					switch (IsFieldFilledCorrectly())
					{
						case "OK":
							if (MessageBox.Show("Вы уверены, что хотите сохранить изменения? Изменения коснутся и таблицы изделий", "Вы уверены?",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
							{
								_dataSet.Tables[0].Rows[_selectedRow][0] = txtCode.Text;
								_dataSet.Tables[0].Rows[_selectedRow][1] = txtName.Text;
								_dataSet.Tables[0].Rows[_selectedRow][2] = txtAddress.Text;

								_oleDbDataAdapter.Update(_dataSet.Tables[0]);

								_isEditing = false;

								dataGridView.ClearSelection();

								ClearField();
							}
							break;

						case "BIG":
							MessageBox.Show("Введенное(ые) значение(я) слишком большое(ые)!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;

						case "EMPTY":
							MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;

						case "ERROR":
							MessageBox.Show("Введите корректные значения!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
							break;
					}
				}
				else
				{
					MessageBox.Show("Сначала выберите строку для редактирования!\nПодсказка: выберите строку в таблице\nи нажмите \"Изменить\"",
						"Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch
			{
				MessageBox.Show("Предприятие с таким кодом уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		private void txtCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}
	}
}
