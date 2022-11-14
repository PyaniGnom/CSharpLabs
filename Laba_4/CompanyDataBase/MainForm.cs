using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CompanyDataBase
{
	public partial class MainForm : Form
	{
		private object[] _companyList;
		private object[] _productCodeList;
		private object[] _companyCodeList;

		private string _searchCompanyName;

		private OleDbConnection _oleDbConnection;
		private OleDbDataAdapter _oleDbDataAdapter;
		private readonly DataSet _dataSet = new();
		private readonly Query _queries = new();

		public MainForm()
		{
			InitializeComponent();

			_dataSet.Tables.Add("CodeCompany");
			_dataSet.Tables.Add("Company");
			_dataSet.Tables.Add("Default");
			_dataSet.Tables.Add("Task1");
			_dataSet.Tables.Add("Task2");
			_dataSet.Tables.Add("Task3");
		}

		private void LoadData()
		{
			_dataSet.Tables["Default"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(_queries.Default(), _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "Default");

			dataGridView.DataSource = _dataSet.Tables["Default"];
		}

		private void LoadDataTask1(string queryString)
		{
			_dataSet.Tables["Task1"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(queryString, _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "Task1");

			dataGridView.DataSource = _dataSet.Tables["Task1"];
		}

		private void LoadDataTask2(string queryString)
		{
			_dataSet.Tables["Task2"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(queryString, _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "Task2");

			dataGridView.DataSource = _dataSet.Tables["Task2"];
		}

		private void LoadDataTask3(string queryString)
		{
			_dataSet.Tables["Task3"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(queryString, _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "Task3");

			dataGridView.DataSource = _dataSet.Tables["Task3"];
		}

		private void UpdateData()
		{
			GetListCompany();
			GetRows(ref _companyList, "Company", 0);

			cbSecondTask.Items.Clear();
			cbSecondTask.Items.AddRange(_companyList);

			GetRows(ref _productCodeList, "Task2", 3);

			cbThirdTask.Items.Clear();
			cbThirdTask.Items.AddRange(_productCodeList);
			txtThirdTask.Text = "";

			if (dataGridView.DataSource == _dataSet.Tables["Task2"])
				cbSecondTask.Text = _searchCompanyName;
		}

		private void GetListCompany()
		{
			_dataSet.Tables["Company"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(_queries.ListCompany(), _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "Company");
		}

		private void GetListCodeCompany()
		{
			_dataSet.Tables["CodeCompany"].Clear();

			_oleDbDataAdapter = new OleDbDataAdapter(_queries.ListCodeCompany(), _oleDbConnection);

			_oleDbDataAdapter.Fill(_dataSet, "CodeCompany");
		}

		private void GetRows(ref object[] list, string tableTitle, int columnNumber)
		{
			DataTable dataTable = _dataSet.Tables[tableTitle];
			int length = dataTable.Rows.Count;

			list = new object[length];

			for (int i = 0; i < length; i++)
				list[i] = dataTable.Rows[i][columnNumber].ToString();
		}

		private void offOtherElements()
		{
			txtThirdTask.Enabled = false;
			cbThirdTask.Enabled = false;
			cbSecondTask.SelectedIndex = -1;
			cbThirdTask.SelectedIndex = -1;
			txtThirdTask.Text = "";
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblError.Visible = false;
			cbThirdTask.Enabled = false;
			txtThirdTask.Enabled = false;

			cbSecondTask.DropDownStyle = ComboBoxStyle.DropDownList;
			cbThirdTask.DropDownStyle = ComboBoxStyle.DropDownList;

			_oleDbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C_Sharp\Laba_4\CompanyDataBase\LR4.accdb;Persist Security Info=True");
			_oleDbConnection.Open();

			LoadData();

			UpdateData();
		}

		private void btnFirstTask_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
			offOtherElements();

			LoadDataTask1(_queries.FirstTask());
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (cbSecondTask.SelectedIndex != -1)
			{
				cbThirdTask.Enabled = true;
				txtThirdTask.Enabled = true;

				_searchCompanyName = cbSecondTask.Text;

				LoadDataTask2(_queries.SecondTask(ref _searchCompanyName));

				GetListCompany();
				GetRows(ref _productCodeList, "Task2", 3);

				cbThirdTask.Items.Clear();
				cbThirdTask.Items.AddRange(_productCodeList);
			}
			else
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите желаемое\nпредприятие!";
			}
		}

		private void btnThirdTask_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
			offOtherElements();

			LoadDataTask3(_queries.ThirdTask());
		}

		private void btnReplace_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (dataGridView.DataSource != _dataSet.Tables["Task2"])
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите желаемое\nпредприятие или\nвыполните поиск!";
			}
			else if (cbThirdTask.SelectedIndex == -1)
			{
				lblError.Text = "Сначала выберите изменяемое\nзначение!";
				lblError.Visible = true;
			}
			else if (!int.TryParse(txtThirdTask.Text, out _))
			{
				lblError.Text = "Введите корректное значение!";
				lblError.Visible = true;
			}
			else
			{
				LoadDataTask2(_queries.FourthTask(cbThirdTask.Text, txtThirdTask.Text));
				LoadDataTask2(_queries.SecondTask(ref _searchCompanyName));

				UpdateData();
			}
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
			offOtherElements();

			LoadData();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dataGridView.DataSource == _dataSet.Tables["Default"])
				LoadData();
			else if (dataGridView.DataSource == _dataSet.Tables["Task1"])
				LoadDataTask1(_queries.FirstTask());
			else if (dataGridView.DataSource == _dataSet.Tables["Task2"])
				LoadDataTask2(_queries.SecondTask(ref _searchCompanyName));
			else
				LoadDataTask3(_queries.ThirdTask());

			UpdateData();
		}

		private void EditCompanyDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			EditTable1Form editTable1Form = new();
			editTable1Form.ShowDialog();
		}

		private void EditProductDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GetListCodeCompany();
			GetRows(ref _companyCodeList, "CodeCompany", 0);

			EditTable2Form editTable2Form = new()
			{
				CodeList = _companyCodeList
			};
			editTable2Form.ShowDialog();
		}

		private void txtThirdTask_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void cbSecondTask_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void cbThirdTask_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtThirdTask_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblError.Visible = false;
		}

		private void FileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}
	}
}
