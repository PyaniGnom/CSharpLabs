using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ProductGrid
{
	public partial class HelpForm : Form
	{
		[DllImport("user32.dll")]
		private static extern bool HideCaret(IntPtr hWnd);

		public string NameHelp;
		public uint CountHelp;
		public float StorageCostsHelp;
		public float PreparationCostsHelp;

		private float _unitCosts;
		private bool _countIsNull;

		private void UnitCostsCalculation()
		{
			if (CountHelp == 0)
			{
				lblError.Visible = true;

				_countIsNull = true;
			}
			else
			{
				_unitCosts = (StorageCostsHelp + PreparationCostsHelp) / CountHelp;
			}
		}

		public HelpForm()
		{
			InitializeComponent();
		}

		private void HelpForm_Load(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void HelpForm_Paint(object sender, PaintEventArgs e)
		{
			HideCaret(textBox1.Handle);
			HideCaret(textBox2.Handle);
		}

		private void HelpForm_Shown(object sender, EventArgs e)
		{
			UnitCostsCalculation();

			textBox1.Text = NameHelp;

			textBox2.Text = _countIsNull ? "" : Convert.ToString(_unitCosts, CultureInfo.InvariantCulture);
		}
	}
}
