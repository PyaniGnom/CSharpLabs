using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CompanyDataBase
{
	public partial class EditTable2Form : Form
	{
		public object[] CodeList;

		private int _selectedRow;
		private bool _isEditing;
		private const string ConnectionString =
			@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C_Sharp\Laba_4\CompanyDataBase\LR4.accdb;Persist Security Info=True";

		private OleDbConnection _oleDbConnection;
		private OleDbCommandBuilder _oleDbBuilder;
		private OleDbDataAdapter _oleDbDataAdapter;
		private readonly DataSet _dataSet = new();
		private readonly Query _queries = new();

		public EditTable2Form()
		{
			InitializeComponent();
		}

		private void LoadData()
		{
			_oleDbDataAdapter = new OleDbDataAdapter(_queries.Table2(), _oleDbConnection);

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

			_oleDbDataAdapter = new OleDbDataAdapter(_queries.Table2(), _oleDbConnection);

			_oleDbBuilder = new OleDbCommandBuilder(_oleDbDataAdapter);

			_oleDbBuilder.GetInsertCommand();
			_oleDbBuilder.GetUpdateCommand();
			_oleDbBuilder.GetDeleteCommand();

			_oleDbDataAdapter.Fill(_dataSet);

			dataGridView.DataSource = _dataSet.Tables[0];
		}

		private void ClearField()
		{
			cbCompanyCode.SelectedIndex = -1;
			txtName.Text = "";
			txtProductCode.Text = "";
			txtCost1.Text = "";
			txtCost2.Text = "";
			txtCost3.Text = "";
			txtCost4.Text = "";
			txtRelease.Text = "";

			_isEditing = false;
		}

		private string IsFieldFilledCorrectly()
		{
			string errorString;

			if (cbCompanyCode.SelectedIndex != -1 && txtName.Text != "" && txtProductCode.Text != "" && txtCost1.Text != "" &&
				txtCost2.Text != "" && txtCost3.Text != "" && txtCost4.Text != "" && txtRelease.Text != "")
			{
				if (uint.TryParse(txtProductCode.Text, out _) && float.TryParse(txtCost1.Text, out _) && float.TryParse(txtCost2.Text, out _) &&
					float.TryParse(txtCost3.Text, out _) && float.TryParse(txtCost4.Text, out _) && uint.TryParse(txtRelease.Text, out _))
				{
					if (uint.Parse(txtProductCode.Text) <= 2147483647 && uint.Parse(txtRelease.Text) <= 2147483647 &&
						float.Parse(txtCost1.Text) <= 922337203685477.5807 && float.Parse(txtCost2.Text) <= 922337203685477.5807 &&
						float.Parse(txtCost3.Text) <= 922337203685477.5807 && float.Parse(txtCost4.Text) <= 922337203685477.5807 && txtName.Text.Length <=255)
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

		private void EditTable2Form_Load(object sender, EventArgs e)
		{
			_oleDbConnection = new OleDbConnection(ConnectionString);

			_oleDbConnection.Open();

			LoadData();

			cbCompanyCode.DropDownStyle = ComboBoxStyle.DropDownList;
			cbCompanyCode.Items.Clear();
			cbCompanyCode.Items.AddRange(CodeList);

			DataGridViewColumn column0 = dataGridView.Columns[0];
			column0.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

			DataGridViewColumn column1 = dataGridView.Columns[1];
			column1.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;

			DataGridViewColumn column2 = dataGridView.Columns[2];
			column2.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			DataGridViewColumn column3 = dataGridView.Columns[3];
			column3.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			DataGridViewColumn column4 = dataGridView.Columns[4];
			column4.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			DataGridViewColumn column5 = dataGridView.Columns[5];
			column5.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			DataGridViewColumn column6 = dataGridView.Columns[6];
			column6.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

			DataGridViewColumn column7 = dataGridView.Columns[7];
			column7.CellTemplate.Style.Alignment = DataGridViewContentAlignment.MiddleRight;

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
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][0] = cbCompanyCode.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][1] = txtName.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][2] = txtProductCode.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][3] = txtCost1.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][4] = txtCost2.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][5] = txtCost3.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][6] = txtCost4.Text;
							_dataSet.Tables[0].Rows[_dataSet.Tables[0].Rows.Count - 1][7] = txtRelease.Text;

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
				MessageBox.Show("Изделие с таким именем уже существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView.SelectedRows.Count != 0)
			{
				if (MessageBox.Show("Вы уверены, что хотите удалить эту строку(ки)?", "Вы уверены?", MessageBoxButtons.YesNo,
						MessageBoxIcon.Question) == DialogResult.Yes)
				{
					foreach (DataGridViewRow rows in dataGridView.SelectedRows)
						dataGridView.Rows.RemoveAt(rows.Index);

					_oleDbDataAdapter.Update(_dataSet.Tables[0]);
					ClearField();
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

					cbCompanyCode.Enabled = false;

					cbCompanyCode.Text = _dataSet.Tables[0].Rows[_selectedRow][0].ToString();
					txtName.Text = _dataSet.Tables[0].Rows[_selectedRow][1].ToString();
					txtProductCode.Text = _dataSet.Tables[0].Rows[_selectedRow][2].ToString();
					txtCost1.Text = _dataSet.Tables[0].Rows[_selectedRow][3].ToString();
					txtCost2.Text = _dataSet.Tables[0].Rows[_selectedRow][4].ToString();
					txtCost3.Text = _dataSet.Tables[0].Rows[_selectedRow][5].ToString();
					txtCost4.Text = _dataSet.Tables[0].Rows[_selectedRow][6].ToString();
					txtRelease.Text = _dataSet.Tables[0].Rows[_selectedRow][7].ToString();
					break;
			}
		}

		private void btnSaveEdit_Click(object sender, EventArgs e)
		{
			if (_isEditing)
			{
				switch (IsFieldFilledCorrectly())
				{
					case "OK":
						if (MessageBox.Show("Вы уверены, что хотите сохранить изменения?", "Вы уверены?",
								MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
						{
							_dataSet.Tables[0].Rows[_selectedRow][0] = cbCompanyCode.Text;
							_dataSet.Tables[0].Rows[_selectedRow][1] = txtName.Text;
							_dataSet.Tables[0].Rows[_selectedRow][2] = txtProductCode.Text;
							_dataSet.Tables[0].Rows[_selectedRow][3] = txtCost1.Text;
							_dataSet.Tables[0].Rows[_selectedRow][4] = txtCost2.Text;
							_dataSet.Tables[0].Rows[_selectedRow][5] = txtCost3.Text;
							_dataSet.Tables[0].Rows[_selectedRow][6] = txtCost4.Text;
							_dataSet.Tables[0].Rows[_selectedRow][7] = txtRelease.Text;

							_oleDbDataAdapter.Update(_dataSet.Tables[0]);

							_isEditing = false;

							ClearField();
							cbCompanyCode.Enabled = true;
							dataGridView.ClearSelection();
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
				MessageBox.Show("Сначала выберите строку для редактирования!\nПодсказка: выберите строку в таблице\nи нажмите \"Изменить\"", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearField();
		}

		private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtCost1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtCost1.Text.Contains(".") && !txtCost1.Text.Contains(","))
			{
				if (txtCost1.Text == "")
				{
					txtCost1.Text = "0,";
					txtCost1.SelectionStart = txtCost1.TextLength;

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

		private void txtCost2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtCost2.Text.Contains(".") && !txtCost2.Text.Contains(","))
			{
				if (txtCost2.Text == "")
				{
					txtCost2.Text = "0,";
					txtCost2.SelectionStart = txtCost1.TextLength;

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

		private void txtCost3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtCost3.Text.Contains(".") && !txtCost3.Text.Contains(","))
			{
				if (txtCost3.Text == "")
				{
					txtCost3.Text = "0,";
					txtCost3.SelectionStart = txtCost3.TextLength;

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

		private void txtCost4_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtCost4.Text.Contains(".") && !txtCost4.Text.Contains(","))
			{
				if (txtCost4.Text == "")
				{
					txtCost4.Text = "0,";
					txtCost4.SelectionStart = txtCost4.TextLength;

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
