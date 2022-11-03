using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireSimulation
{
	public partial class Form1 : Form
	{
		private float _fireWidth;
		private float _fireHeight;

		private Graphics _graphics;
		private Color[] _colors =
		{
			Color.FromArgb(0, 0, 0),
			Color.FromArgb(7, 7, 7),
			Color.FromArgb(31, 7, 7),
			Color.FromArgb(47, 15, 7),
			Color.FromArgb(71, 15, 7),
			Color.FromArgb(87, 23, 7),
			Color.FromArgb(103, 31, 7),
			Color.FromArgb(119, 31, 7),
			Color.FromArgb(143, 39, 7),
			Color.FromArgb(159, 47, 7),
			Color.FromArgb(175, 63, 7),
			Color.FromArgb(191, 71, 7),
			Color.FromArgb(199, 71, 7),
			Color.FromArgb(223, 79, 7),
			Color.FromArgb(223, 87, 7),
			Color.FromArgb(223, 87, 7),
			Color.FromArgb(215, 95, 7),
			Color.FromArgb(215, 103, 15),
			Color.FromArgb(207, 111, 15),
			Color.FromArgb(207, 119, 15),
			Color.FromArgb(207, 127, 15),
			Color.FromArgb(207, 135, 23),
			Color.FromArgb(199, 135, 23),
			Color.FromArgb(199, 143, 23),
			Color.FromArgb(199, 151, 31),
			Color.FromArgb(191, 159, 31),
			Color.FromArgb(191, 159, 31),
			Color.FromArgb(191, 167, 39),
			Color.FromArgb(191, 167, 39),
			Color.FromArgb(191, 175, 47),
			Color.FromArgb(183, 175, 47),
			Color.FromArgb(183, 183, 47),
			Color.FromArgb(183, 183, 55),
			Color.FromArgb(207, 207, 111),
			Color.FromArgb(223, 223, 159),
			Color.FromArgb(239, 239, 199),
			Color.FromArgb(255, 255, 255),
		};

		private void doFire()
		{
			for (int x = 0; x < _fireWidth; x++)
			{

			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			/*
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);

			_graphics = Graphics.FromImage(pictureBox.Image);

			_graphics.Clear(_colors[36]);
			*/
			/*
			int width = pictureBox.Width;
			int height = pictureBox.Height / 37;
			Bitmap fire = new Bitmap(pictureBox.Width, pictureBox.Height);

			for (int rows = 36; rows >= 0; rows--)
			{
				for (int j = 0; j < width; j++)
				{
					for (int k = rows * height; k < (rows * height) + height; k++)
					{
						fire.SetPixel(j, k, _colors[rows]);
					}
				}
			}
			pictureBox.Image = fire;
			*/

			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
			_graphics = Graphics.FromImage(pictureBox.Image);
			_graphics.Clear(Color.Black);
			

			pictureBox.Refresh();
		}
	}
}
