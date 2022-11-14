using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
// ReSharper disable StringLiteralTypo

namespace ClimateControlSystem
{
	public partial class Form1 : Form
	{
		private bool _isCooling;
		private readonly int _coolingTemp = 20;

		private const string ConnectionString =
			@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C_Sharp\Laba_5\ClimateControlSystem\DataInformation.accdb;Persist Security Info=True";

		private double _temp1;
		private double _temp2;
		private double _temp3;
		private double _inletTemp1;
		private double _inletTemp2;
		private double _inletTemp3;

		private readonly double[] _tempArray = new double[5];
		private readonly double[] _powerArray = new double[5];

		private readonly Random _random = new();
		private OleDbConnection _oleDbConnection;
		private OleDbDataAdapter _oleDbDataAdapter = new();
		private OleDbCommand _oleDbCommand;
		private readonly DataTable _dataTable = new();

		public Form1()
		{
			InitializeComponent();
		}

		private bool DatesQuery(string table)
		{
			try
			{
				_dataTable.Clear();

				_oleDbDataAdapter = new OleDbDataAdapter($"SELECT * FROM {table} WHERE (Дата BETWEEN #{txtStartDate.Text.Replace('.', '/')}# AND #{txtStopDate.Text.Replace('.', '/')}#) ORDER BY Дата", _oleDbConnection);
				_oleDbDataAdapter.Fill(_dataTable);

				return true;
			}
			catch (Exception)
			{
				MessageBox.Show("Введите корректные даты!\nПример: 01.01.2022 21:12:22", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return false;
			}
		}

		private void WriteFile(string table, bool append)
		{
			StringBuilder sb = new();

			sb.AppendLine($"{table}");
			sb.AppendLine("————————————————————————————————————————————————————————————————————————————————————————————————————————————————");
			sb.AppendLine("Дата | Температура_входного_воздуха | Температура_охлаждающего_потока | Температура | Поток_охлаждающего_воздуха");
			sb.AppendLine();

			for (int i = 0; i < _dataTable.Rows.Count; i++)
			{
				if (_dataTable.Rows[i][4].ToString() == "0,0000")
				{
					_dataTable.Rows[i][4] = 0;
				}
				sb.AppendLine($"{_dataTable.Rows[i][0]} | {_dataTable.Rows[i][1]} | {_dataTable.Rows[i][2]} | {_dataTable.Rows[i][3]} | {_dataTable.Rows[i][4]}");
			}

			sb.AppendLine();
			sb.AppendLine("================================================================================================================");
			sb.AppendLine();

			using (StreamWriter outfile = new("DataInformation.txt", append))
			{
				outfile.Write(sb.ToString());
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ActiveControl = btnCooling;

			btnCooling.BackColor = Color.Red;

			lblRoomStatus1.Text = "Всё в норме";
			lblRoomStatus2.Text = "Всё в норме";
			lblRoomStatus3.Text = "Всё в норме";
			txtCoolingTemp1.Text = _coolingTemp.ToString();
			txtCoolingTemp2.Text = _coolingTemp.ToString();
			txtCoolingTemp3.Text = _coolingTemp.ToString();
			txtCoolingFlow1.Text = "0";
			txtCoolingFlow2.Text = "0";
			txtCoolingFlow3.Text = "0";

			int value = _random.Next(15, 25);
			txtInletTemp1.Text = value.ToString();

			value = _random.Next(15, 25);
			txtInletTemp2.Text = value.ToString();

			value = _random.Next(15, 25);
			txtInletTemp3.Text = value.ToString();

			value = _random.Next(25, 50);
			txtTemp1.Text = value.ToString();

			value = _random.Next(25, 50);
			txtTemp2.Text = value.ToString();

			value = _random.Next(25, 50);
			txtTemp3.Text = value.ToString();

			_oleDbConnection = new OleDbConnection(ConnectionString);
			_oleDbConnection.Open();
		}

		private void timerRandTemp_Tick(object sender, EventArgs e)
		{
			// Room 1 temperature values.

			double value = _random.Next(100);
			value /= 100;

			_temp1 = double.Parse(txtTemp1.Text) + value;
			txtTemp1.Text = _temp1.ToString(CultureInfo.InvariantCulture);

			int action = _random.Next(2);

			switch (action)
			{
				case 0 when double.Parse(txtInletTemp1.Text) <= 25:
					_inletTemp1 = double.Parse(txtInletTemp1.Text) + value;
					txtInletTemp1.Text = _inletTemp1.ToString(CultureInfo.InvariantCulture);
					break;

				case 1 when double.Parse(txtInletTemp1.Text) >= 15:
					_inletTemp1 = double.Parse(txtInletTemp1.Text) - value;
					txtInletTemp1.Text = _inletTemp1.ToString(CultureInfo.InvariantCulture);
					break;
			}

			_oleDbCommand = new OleDbCommand($"INSERT INTO Помещение1 (Дата, Температура_входного_воздуха, Температура_охлаждающего_потока, Температура, Поток_охлаждающего_воздуха) VALUES ('{DateTime.Now}', '{double.Parse(txtInletTemp1.Text)}', '{_coolingTemp}', '{double.Parse(txtTemp1.Text)}', '{double.Parse(txtCoolingFlow1.Text)}')", _oleDbConnection);
			_oleDbCommand.ExecuteNonQuery();


			// Room 2 temperature values.

			value = _random.Next(100);
			value /= 100;

			_temp2 = double.Parse(txtTemp2.Text) + value;
			txtTemp2.Text = _temp2.ToString(CultureInfo.InvariantCulture);

			action = _random.Next(2);
			switch (action)
			{
				case 0 when double.Parse(txtInletTemp2.Text) <= 25:
					_inletTemp2 = double.Parse(txtInletTemp2.Text) + value;
					txtInletTemp2.Text = _inletTemp2.ToString(CultureInfo.InvariantCulture);
					break;

				case 1 when double.Parse(txtInletTemp2.Text) >= 15:
					_inletTemp2 = double.Parse(txtInletTemp2.Text) - value;
					txtInletTemp2.Text = _inletTemp2.ToString(CultureInfo.InvariantCulture);
					break;
			}

			_oleDbCommand = new OleDbCommand($"INSERT INTO Помещение2 (Дата, Температура_входного_воздуха, Температура_охлаждающего_потока, Температура, Поток_охлаждающего_воздуха) VALUES ('{DateTime.Now}', '{double.Parse(txtInletTemp2.Text)}', '{_coolingTemp}', '{double.Parse(txtTemp2.Text)}', '{double.Parse(txtCoolingFlow2.Text)}')", _oleDbConnection);
			_oleDbCommand.ExecuteNonQuery();


			// Room 3 temperature values.

			value = _random.Next(100);
			value /= 100;

			_temp3 = double.Parse(txtTemp3.Text) + value;
			txtTemp3.Text = _temp3.ToString(CultureInfo.InvariantCulture);

			action = _random.Next(2);
			switch (action)
			{
				case 0 when double.Parse(txtInletTemp3.Text) <= 25:
					_inletTemp3 = double.Parse(txtInletTemp3.Text) + value;
					txtInletTemp3.Text = _inletTemp3.ToString(CultureInfo.InvariantCulture);
					break;

				case 1 when double.Parse(txtInletTemp3.Text) >= 15:
					_inletTemp3 = double.Parse(txtInletTemp3.Text) - value;
					txtInletTemp3.Text = _inletTemp3.ToString(CultureInfo.InvariantCulture);
					break;
			}

			_oleDbCommand = new OleDbCommand($"INSERT INTO Помещение3 (Дата, Температура_входного_воздуха, Температура_охлаждающего_потока, Температура, Поток_охлаждающего_воздуха) VALUES ('{DateTime.Now}', '{double.Parse(txtInletTemp3.Text)}', '{_coolingTemp}', '{double.Parse(txtTemp3.Text)}', '{double.Parse(txtCoolingFlow3.Text)}')", _oleDbConnection);
			_oleDbCommand.ExecuteNonQuery();


			// Plotting chart.

			for (int i = 0; i < _tempArray.Length - 1; i++)
			{
				_tempArray[i] = _tempArray[i + 1];
				_powerArray[i] = _powerArray[i + 1];
			}

			_tempArray[_tempArray.Length - 1] = (Convert.ToDouble(txtTemp1.Text) + Convert.ToDouble(txtTemp2.Text) + Convert.ToDouble(txtTemp3.Text)) / 3;
			_powerArray[_powerArray.Length - 1] = (Convert.ToDouble(txtCoolingFlow1.Text) + Convert.ToDouble(txtCoolingFlow2.Text) + Convert.ToDouble(txtCoolingFlow3.Text)) / 3;

			chart1.Series[0].Points.Clear();
			for (int i = 0; i < _tempArray.Length; i++)
			{
				chart1.Series[0].Points.AddXY(i, _tempArray[i]);
			}

			chart1.Series[1].Points.Clear();
			for (int i = 0; i < _powerArray.Length; i++)
			{
				chart1.Series[1].Points.AddXY(i, _powerArray[i]);
			}
		}

		private void timerCalcData_Tick(object sender, EventArgs e)
		{
			// Calculation of values for Room 1.

			double qIn = 120 * _temp1;
			double qCool = _inletTemp1;
			txtCoolingFlow1.Text = "0";

			switch (_temp1)
			{
				case > 40 when _isCooling:
					qCool = _coolingTemp * 6;
					txtCoolingFlow1.Text = "5";
					break;

				case > 35 when _isCooling:
					qCool = _coolingTemp * 4;
					txtCoolingFlow1.Text = "3";
					break;

				case > 30 when _isCooling:
					qCool = _coolingTemp * 3;
					txtCoolingFlow1.Text = "2";
					break;

				case > 25 when _isCooling:
					qCool = _coolingTemp * 2;
					txtCoolingFlow1.Text = "1";
					break;
			}

			double qResult = qIn - qCool;
			txtTemp1.Text = (double.Parse(txtTemp1.Text) * (qResult / qIn)).ToString(CultureInfo.InvariantCulture);

			qResult = double.Parse(txtTemp1.Text) * 120 - qCool;
			txtTemp1.Text = Math.Round((double.Parse(txtTemp1.Text) * (qResult / qIn)), 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);

			// Calculation of values for Room 1.

			qIn = 120 * _temp2;
			qCool = _inletTemp2;
			txtCoolingFlow2.Text = "0";

			switch (_temp2)
			{
				case > 40 when _isCooling:
					qCool = _coolingTemp * 6;
					txtCoolingFlow2.Text = "5";
					break;

				case > 35 when _isCooling:
					qCool = _coolingTemp * 4;
					txtCoolingFlow2.Text = "3";
					break;

				case > 30 when _isCooling:
					qCool = _coolingTemp * 3;
					txtCoolingFlow2.Text = "2";
					break;

				case > 25 when _isCooling:
					qCool = _coolingTemp * 2;
					txtCoolingFlow2.Text = "1";
					break;
			}

			qResult = qIn - qCool;
			txtTemp2.Text = (double.Parse(txtTemp2.Text) * (qResult / qIn)).ToString(CultureInfo.InvariantCulture);

			qResult = double.Parse(txtTemp2.Text) * 120 - qCool;
			txtTemp2.Text = Math.Round((double.Parse(txtTemp2.Text) * (qResult / qIn)), 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);


			// Calculation of values for Room 3.

			qIn = 120 * _temp3;
			qCool = _inletTemp3;
			txtCoolingFlow3.Text = "0";

			if (_temp3 > 40 && _isCooling)
			{
				qCool = _coolingTemp * 6;
				txtCoolingFlow3.Text = "5";
			}
			else if (_temp3 > 35 && _isCooling)
			{
				qCool = _coolingTemp * 4;
				txtCoolingFlow3.Text = "3";
			}
			else if (_temp3 > 30 && _isCooling)
			{
				qCool = _coolingTemp * 3;
				txtCoolingFlow3.Text = "2";
			}
			else if (_temp3 > 25 && _isCooling)
			{
				qCool = _coolingTemp * 2;
				txtCoolingFlow3.Text = "1";
			}

			qResult = qIn - qCool;
			txtTemp3.Text = (double.Parse(txtTemp3.Text) * (qResult / qIn)).ToString(CultureInfo.InvariantCulture);

			qResult = double.Parse(txtTemp3.Text) * 120 - qCool;
			txtTemp3.Text = Math.Round((double.Parse(txtTemp3.Text) * (qResult / qIn)), 2, MidpointRounding.AwayFromZero).ToString(CultureInfo.InvariantCulture);
		}

		private void txtTemp1_TextChanged(object sender, EventArgs e)
		{
			switch (double.Parse(txtTemp1.Text))
			{
				case > 50:
					_isCooling = true;

					btnCooling.BackColor = Color.Green;
					txtTemp1.BackColor = Color.Red;
					lblRoomStatus1.Text = "В первом помещении слишком высокая темпераура!\nОхлаждение включено";
					break;

				case > 40:
					txtTemp1.BackColor = Color.Red;
					lblRoomStatus1.Text = "В первом помещении высокая темпераура!\nОбратите внимание!";
					break;

				case < 25:
					_isCooling = false;

					btnCooling.BackColor = Color.Red;
					txtTemp1.BackColor = Color.DeepSkyBlue;
					lblRoomStatus1.Text = "В первом помещении низкая температура!\nОхлаждение отключено";
					break;

				default:
					txtTemp1.BackColor = Color.Green;
					lblRoomStatus1.Text = "Всё в норме";
					break;
			}
		}

		private void txtTemp2_TextChanged(object sender, EventArgs e)
		{
			switch (double.Parse(txtTemp2.Text))
			{
				case > 50:
					_isCooling = true;

					btnCooling.BackColor = Color.Green;
					txtTemp2.BackColor = Color.Red;
					lblRoomStatus2.Text = "Во втором помещении слишком высокая темпераура!\nОхлаждение включено";
					break;

				case > 40:
					txtTemp2.BackColor = Color.Red;
					lblRoomStatus2.Text = "Во втором помещении высокая темпераура!\nОбратите внимание!";
					break;

				case < 25:
					_isCooling = false;

					btnCooling.BackColor = Color.Red;
					txtTemp2.BackColor = Color.DeepSkyBlue;
					lblRoomStatus2.Text = "Во втором помещении низкая температура!\nОхлаждение отключено";
					break;

				default:
					txtTemp2.BackColor = Color.Green;
					lblRoomStatus2.Text = "Всё в норме";
					break;
			}
		}

		private void txtTemp3_TextChanged(object sender, EventArgs e)
		{
			switch (double.Parse(txtTemp3.Text))
			{
				case > 50:
					_isCooling = true;

					btnCooling.BackColor = Color.Green;
					txtTemp3.BackColor = Color.Red;
					lblRoomStatus3.Text = "В третьем помещении слишком высокая темпераура!\nОхлаждение включено";
					break;

				case > 40:
					txtTemp3.BackColor = Color.Red;
					lblRoomStatus3.Text = "В третьем помещении высокая темпераура!\nОбратите внимание!";
					break;

				case < 25:
					_isCooling = false;

					btnCooling.BackColor = Color.Red;
					txtTemp3.BackColor = Color.DeepSkyBlue;
					lblRoomStatus3.Text = "В третьем помещении низкая температура!\nОхлаждение отключено";
					break;

				default:
					txtTemp3.BackColor = Color.Green;
					lblRoomStatus3.Text = "Всё в норме";
					break;
			}
		}

		private void btnCooling_BackColorChanged(object sender, EventArgs e)
		{
			btnCooling.Text = _isCooling ? "Выключить вентиляцию" : "Включить вентиляцию";
		}

		private void btnCooling_Click(object sender, EventArgs e)
		{
			if (_isCooling)
			{
				_isCooling = false;
				btnCooling.BackColor = Color.Red;
			}
			else
			{
				_isCooling = true;
				btnCooling.BackColor = Color.Green;
			}
		}

		private void btnDataOutput_Click(object sender, EventArgs e)
		{
			if (DatesQuery("Помещение1"))
			{
				WriteFile("Помещение 1", false);

				DatesQuery("Помещение2");
				WriteFile("Помещение 2", true);

				DatesQuery("Помещение3");
				WriteFile("Помещение 3", true);

				txtStartDate.Text = "";
				txtStopDate.Text = "";
			}
		}
	}
}
