using System;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		private float _firstValue;
		private float _secondValue;
		private float _result;

		public Form1()
		{
			InitializeComponent();
		}

		private bool FillingFields()
		{
			if (tFirstValue.Text != "" && tSecondValue.Text != "")
			{
				return true;
			}

			MessageBox.Show("Заполните все поля!");
			return false;
		}

		private bool CheckingConverting()
		{
			if (float.TryParse(tFirstValue.Text.Replace('.', ','), out _firstValue))
			{
				if(float.TryParse(tSecondValue.Text.Replace('.', ','), out _secondValue))
				{
					return true;
				}

				MessageBox.Show("Введите второе значение корректно!");
				return false;
			}

			MessageBox.Show("Введите первое значение корректно!");
			return false;
		}

		private void tFirstValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			switch (e.KeyChar)
			{
				case '.' or ',' when !tFirstValue.Text.Contains('.') && !tFirstValue.Text.Contains(','):
					{
						if (tFirstValue.Text == "" || tFirstValue.Text == "-")
						{
							if (tFirstValue.Text == "-")
							{
								tFirstValue.Text = "-0,";
								tFirstValue.SelectionStart = tFirstValue.TextLength;
								e.Handled = true;
								return;
							}

							tFirstValue.Text = "0,";
							tFirstValue.SelectionStart = tFirstValue.TextLength;
							e.Handled = true;
							return;
						}
						e.KeyChar = ',';
						break;
					}

				case '-' when tFirstValue.Text == "":
					return;

				default:
					e.Handled = true;
					break;
			}
		}

		private void tSecondValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}

			switch (e.KeyChar)
			{
				case '.' or ',' when !tSecondValue.Text.Contains('.') && !tSecondValue.Text.Contains(','):
					{
						if (tSecondValue.Text == "" || tSecondValue.Text == "-")
						{
							if (tSecondValue.Text == "-")
							{
								tSecondValue.Text = "-0,";
								tSecondValue.SelectionStart = tSecondValue.TextLength;
								e.Handled = true;
								return;
							}

							tSecondValue.Text = "0,";
							tSecondValue.SelectionStart = tSecondValue.TextLength;
							e.Handled = true;
							return;
						}
						e.KeyChar = ',';
						break;
					}

				case '-' when tSecondValue.Text == "":
					return;

				default:
					e.Handled = true;
					break;
			}
		}

		private void bAddiction_Click(object sender, EventArgs e)
		{
			if (!FillingFields())
			{
				return;
			}

			if (CheckingConverting())
			{
				_result = _firstValue + _secondValue;
				tResult.Text = Convert.ToString(_result, CultureInfo.InvariantCulture);
			}
			else
			{
				tResult.Text = "";
			}
		}

		private void bSubtraction_Click(object sender, EventArgs e)
		{
			if (!FillingFields())
			{
				return;
			}

			if (CheckingConverting())
			{
				_result = _firstValue - _secondValue;
				tResult.Text = Convert.ToString(_result, CultureInfo.InvariantCulture);
			}
			else
			{
				tResult.Text = "";
			}
		}

		private void bMultiply_Click(object sender, EventArgs e)
		{
			if (!FillingFields())
			{
				return;
			}

			if (CheckingConverting())
			{
				_result = _firstValue * _secondValue;
				tResult.Text = Convert.ToString(_result, CultureInfo.InvariantCulture);
			}
			else
			{
				tResult.Text = "";
			}
		}

		private void bDivide_Click(object sender, EventArgs e)
		{
			if (!FillingFields())
			{
				return;
			}

			if (CheckingConverting())
			{
				if (_secondValue == 0)
				{
					MessageBox.Show("На ноль делить нельзя!");
					tResult.Text = "";
				}
				else
				{
					_result = _firstValue / _secondValue;
					tResult.Text = Convert.ToString(_result, CultureInfo.InvariantCulture);
				}
			}
			else
			{
				tResult.Text = "";
			}
		}

		private void bClearAll_Click(object sender, EventArgs e)
		{
			tFirstValue.ResetText();
			tSecondValue.ResetText();
			tResult.ResetText();
		}
	}
}
