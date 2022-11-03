using System;
using System.Linq;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		private double _firstValue;
		private double _secondValue;
		private double _result;

		public Form1()
		{
			InitializeComponent();
		}

		private bool FillingFields()
		{
			if (tFirstValue.Text == "" || tSecondValue.Text == "")
			{
				MessageBox.Show("Заполните все поля!");
				return false;
			}
			else
			{
				return true;
			}
		}

		private bool Converting()
		{
			if (double.TryParse(tFirstValue.Text.Replace('.', ','), out _firstValue))
			{
				if(double.TryParse(tSecondValue.Text.Replace('.', ','), out _secondValue))
				{
					return true;
				}
				else
				{
					MessageBox.Show("Введите второе значение корректно!");
					return false;
				}
			}
			else
			{
				MessageBox.Show("Введите первое значение корректно!");
				return false;
			}
		}

		private void tFirstValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else if ((e.KeyChar == '.' || e.KeyChar == ',') && !tFirstValue.Text.Contains('.') && !tFirstValue.Text.Contains(','))
			{
				if (tFirstValue.Text == "" || tFirstValue.Text == "-")
				{
					tFirstValue.Text = "0,";
					tFirstValue.SelectionStart = tFirstValue.TextLength;
					e.Handled = true;
					return;
				}
				e.KeyChar = ',';
				return;
			}
			else if (e.KeyChar == '-' && tFirstValue.Text == "")
			{
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void tSecondValue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else if ((e.KeyChar == '.' || e.KeyChar == ',') && !tSecondValue.Text.Contains('.') && !tSecondValue.Text.Contains(','))
			{
				if (tSecondValue.Text == "" || tSecondValue.Text == "-")
				{
					tSecondValue.Text = "0,";
					tSecondValue.SelectionStart = tSecondValue.TextLength;
					e.Handled = true;
					return;
				}
				e.KeyChar = ',';
				return;
			}
			else if (e.KeyChar == '-' && tSecondValue.Text == "")
			{
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void bAddiction_Click(object sender, EventArgs e)
		{
			if (FillingFields())
			{
				if (Converting())
				{
					_result = _firstValue + _secondValue;
					tResult.Text = Convert.ToString(_result);
				}
				else
				{
					tResult.Text = "";
				}
			}
		}

		private void bSubtraction_Click(object sender, EventArgs e)
		{
			if (FillingFields())
			{
				if (Converting())
				{
					_result = _firstValue - _secondValue;
					tResult.Text = Convert.ToString(_result);
				}
				else
				{
					tResult.Text = "";
				}
			}			
		}

		private void bMultiply_Click(object sender, EventArgs e)
		{
			if (FillingFields())
			{
				if (Converting())
				{
					_result = _firstValue * _secondValue;
					tResult.Text = Convert.ToString(_result);
				}
				else
				{
					tResult.Text = "";
				}
			}			
		}

		private void bDivide_Click(object sender, EventArgs e)
		{
			if (FillingFields())
			{
				if (Converting())
				{
					if (_secondValue == 0)
					{
						MessageBox.Show("На ноль делить нельзя!");
						tResult.Text = "";
					}
					else
					{
						_result = _firstValue / _secondValue;
						tResult.Text = Convert.ToString(_result);
					}
				}
				else
				{
					tResult.Text = "";
				}
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