using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			this.KeyDown += newKeyDown;
		}

		private void newKeyDown(object sender, KeyEventArgs e)
		{
			label1.Text = Convert.ToString(e.KeyValue);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
