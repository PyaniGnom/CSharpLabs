using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SreenSaver
{
	public partial class Form1 : Form
	{
		public class Star
		{
			public float X { get; set; }

			public float Y { get; set; }

			public float Z { get; set; }
		}

		private Star[] _stars = new Star[8000];

		private Random _random = new Random();

		private Graphics _graphics;

		private float Map(float n, float start1, float stop1, float start2, float stop2)
		{
			return ((n - start1) / (stop1 - start1)) * (stop2 - start2) + start2;
		}

		private void DrawStar(Star star)
		{
			float starSize = Map(star.Z, 0, pictureBox1.Height, 6, 0);

			float x = Map(star.X / star.Z, 0, 1, 0, pictureBox1.Width) + pictureBox1.Width / 2;

			float y = Map(star.Y / star.Z, 0, 1, 0, pictureBox1.Height) + pictureBox1.Height / 2;

			_graphics.FillEllipse(Brushes.White, x, y, starSize, starSize);
		}

		private void MoveStar(Star star)
		{
			star.Z -= 15;

			if (star.Z < 1)
			{
				star.X = _random.Next(-pictureBox1.Width, pictureBox1.Width);
				star.Y = _random.Next(-pictureBox1.Height, pictureBox1.Height);
				star.Z = _random.Next(1, pictureBox1.Height);
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			_graphics.Clear(Color.Black);

			foreach (var star in _stars)
			{
				DrawStar(star);

				MoveStar(star);
			}

			pictureBox1.Refresh();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);

			_graphics = Graphics.FromImage(pictureBox1.Image);

			for (int i = 0; i < _stars.Length; i++)
			{
				_stars[i] = new Star()
				{
					X = _random.Next(-pictureBox1.Width, pictureBox1.Width),
					Y = _random.Next(-pictureBox1.Height, pictureBox1.Height),
					Z = _random.Next(1, pictureBox1.Height)
				};
			}

			timer1.Start();
		}
	}
}
