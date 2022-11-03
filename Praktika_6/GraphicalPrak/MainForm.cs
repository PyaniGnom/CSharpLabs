using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.FileIO;

namespace GraphicalPrak
{
	public partial class MainForm : Form
	{
		private Graphics _graphics;

		public MainForm()
		{
			InitializeComponent();
		}

		private void ReadConfig()
		{
			try
			{
				dataGridView.Rows.Clear();

				using (TextFieldParser parser = new TextFieldParser("Figure.csv"))
				{
					parser.TextFieldType = FieldType.Delimited;
					parser.SetDelimiters(";");
					while (!parser.EndOfData)
					{
						string[] fields = parser.ReadFields();

						dataGridView.Rows.Add();
						for (int i = 0; i < fields.Length; i++)
						{
							dataGridView[i, dataGridView.Rows.Count - 1].Value = fields[i];
						}
					}
				}
			}
			catch (Exception Exc)
			{
				MessageBox.Show(Exc.Message);
			}
		}

		private void DrawImage()
		{
			if (dataGridView.SelectedRows.Count == 0)
			{
				MessageBox.Show("Сначала выберите объект в таблице", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else if (dataGridView.SelectedRows.Count > 1)
			{
				dataGridView.ClearSelection();
				MessageBox.Show("Выберите только один объект (запись)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				_graphics.Clear(Color.LightBlue);
				switch (dataGridView.SelectedRows[0].Cells[0].Value)
				{
					case "TEXT":
						{
							string color = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
							string message = dataGridView.SelectedRows[0].Cells[2].Value.ToString();
							string fontFamily = dataGridView.SelectedRows[0].Cells[3].Value.ToString();
							float messageSize = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[4].Value);

							float corX = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[5].Value);
							float corY = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[6].Value);


							Font font = new Font(fontFamily, messageSize);
							SolidBrush brush = new SolidBrush(Color.FromName(color));

							_graphics.DrawString(message, font, brush, corX, corY);
							font.Dispose();
							brush.Dispose();

							break;
						}
					case "CIRCLE/ELLIPSE":
						{
							string color = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

							float width = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[2].Value);
							float height = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[3].Value);

							float corX = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[4].Value);
							float corY = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[5].Value);

							SolidBrush bursh = new SolidBrush(Color.FromName(color));

							_graphics.FillEllipse(bursh, corX, corY, width, height);
							bursh.Dispose();

							break;
						}
					case "RECTANGLE":
						{
							string color = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

							float width = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[2].Value);
							float height = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[3].Value);

							float corX = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[4].Value);
							float corY = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[5].Value);

							SolidBrush bursh = new SolidBrush(Color.FromName(color));

							_graphics.FillRectangle(bursh, corX, corY, width, height);
							bursh.Dispose();

							break;
						}
					case "LINE":
						{
							string color = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
							float width = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[2].Value);

							float corX1 = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[3].Value);
							float corY1 = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[4].Value);
							float corX2 = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[5].Value);
							float corY2 = Convert.ToSingle(dataGridView.SelectedRows[0].Cells[6].Value);

							SolidBrush bursh = new SolidBrush(Color.FromName(color));
							Pen pen = new Pen(bursh, width);

							_graphics.DrawLine(pen, corX1, corY1, corX2, corY2);
							bursh.Dispose();

							break;
						}
					case "TRIANGLE":
						{
							string color = dataGridView.SelectedRows[0].Cells[1].Value.ToString();

							Point[] points = new Point[3];
							points[0].X = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[2].Value); points[0].Y = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[3].Value);
							points[1].X = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[4].Value); points[1].Y = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[5].Value);
							points[2].X = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[6].Value); points[2].Y = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[7].Value);

							SolidBrush bursh = new SolidBrush(Color.FromName(color));

							_graphics.FillPolygon(bursh, points);
							bursh.Dispose();

							break;
						}
					default:
						break;
				}
			}

			pictureBox.Refresh();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
			_graphics = Graphics.FromImage(pictureBox.Image);

			_graphics.Clear(Color.LightBlue);

			ReadConfig();
		}

        private void btnDraw_Click(object sender, EventArgs e)
        {
			DrawImage();
        }

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			ReadConfig();
		}

		private void btnSaveCopy_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Сохранить копию";
			saveFileDialog.OverwritePrompt = true;
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.FilterIndex = 3;
			saveFileDialog.InitialDirectory = "D:\\C_Sharp\\Praktika_6\\GraphicalPrak\\bin\\Debug";

			saveFileDialog.Filter = "BMP (*.BMP)|*.bmp|GIF (*.GIF)|*.gif|JPEG (*.JPG)|*.jpg|PNG (*.PNG)|*.png";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					pictureBox.Image.Save(saveFileDialog.FileName);
				}
				catch (Exception Exc)
				{
					MessageBox.Show(Exc.Message);
				}
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			_graphics.Clear(Color.LightBlue);
			pictureBox.Refresh();
		}
	}
}
