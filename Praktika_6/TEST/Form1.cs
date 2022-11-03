using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST
{
	public partial class Form1 : Form
	{
		private Graphics _graphics;
		//private Font font = new Font("Century Gothic", 16);
		//private int chislo = 20;
		//Pen _pen = new Pen(Brushes.IndianRed, 5);
		//SolidBrush _brush = new SolidBrush(Color.HotPink);
		private float _fireWidth;
		private float _fireHeight;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			_graphics = Graphics.FromImage(pictureBox1.Image);
			_graphics.Clear(Color.Cyan);
			*/
			
			const int columnWidth = 40;
			const int rowHeight = 40;

			Bitmap chess = new Bitmap(columnWidth * 10, rowHeight * 10);

			for (int columns = 0; columns < 10; columns++)
			{
				for (int rows = 0; rows < 10; rows++)
				{
					Color color;
					if (columns % 2 == 0)
						color = rows % 2 == 0 ? Color.Black : Color.White;
					else
						color = rows % 2 == 0 ? Color.White : Color.Black;

					for (int j = columns * columnWidth; j < (columns * columnWidth) + columnWidth; j++)
					{
						for (int k = rows * rowHeight; k < (rows * rowHeight) + rowHeight; k++)
						{
							chess.SetPixel(j, k, color);
						}
					}
				}
				pictureBox1.Image = chess;
			}
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			
		}
	}
}
