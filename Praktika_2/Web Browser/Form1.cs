using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Web_Browser
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bgoButton_Click(object sender, EventArgs e)
		{
			webBrowser1.Navigate(new Uri(comboBox1.SelectedItem.ToString()));
		}

		private void sHome_Click(object sender, EventArgs e)
		{
			webBrowser1.GoHome();
		}

		private void sgoBack_Click(object sender, EventArgs e)
		{
			webBrowser1.GoBack();
		}

		private void sgoForward_Click(object sender, EventArgs e)
		{
			webBrowser1.GoForward();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			comboBox1.SelectedIndex = 1;
			webBrowser1.GoHome();
		}
	}
}
