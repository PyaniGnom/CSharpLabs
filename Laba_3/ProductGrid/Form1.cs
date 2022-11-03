using System;
using System.Linq;
using System.Windows.Forms;

namespace ProductGrid
{
	public partial class Form1 : Form
	{
		private string _name;
		private uint _count;
		private double _storageCosts;
		private double _preparationCosts;

		public Form1()
		{
			InitializeComponent();
		}

		private bool CountConverting()
		{
			return uint.TryParse(txtProductCount.Text, out _count);
		}

		private bool StorageCostsConverting()
		{
			return double.TryParse(txtStorageCosts.Text.Replace('.', ','), out _storageCosts);
		}

		private bool PreparationCostsConverting()
		{
			return double.TryParse(txtPreparationCosts.Text.Replace('.', ','), out _preparationCosts);
		}

		private bool TxtFilling()
		{
			return txtName.Text == "" || txtProductCount.Text == "" || txtStorageCosts.Text == "" || txtPreparationCosts.Text == "" ? false : true;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			lblError.Visible = false;
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (!TxtFilling())
			{
				lblError.Text = "Сначала заполните все поля!";
				lblError.Visible = true;
			}
			else if (!(CountConverting() && StorageCostsConverting() && PreparationCostsConverting()))
			{
				lblError.Text = "Заполните все поля корректно!";
				lblError.Visible = true;
			}
			else
			{
				dataGridView.Rows.Add();

				_name = txtName.Text;

				dataGridView[0, dataGridView.RowCount - 2].Value = _name;
				dataGridView[1, dataGridView.RowCount - 2].Value = _count;
				dataGridView[2, dataGridView.RowCount - 2].Value = _storageCosts;
				dataGridView[3, dataGridView.RowCount - 2].Value = _preparationCosts;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (dataGridView.SelectedRows.Count == 1 && dataGridView.SelectedRows.Contains(dataGridView.Rows[dataGridView.RowCount - 1]))
			{
				lblError.Text = "Эту строку нельзя удалить!";
				lblError.Visible = true;

				dataGridView.ClearSelection();
			}
			else if (dataGridView.SelectedRows.Count != 0)
			{
				DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить эту строку(ки)?", "Вы уверены?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				
				if (dialogResult == DialogResult.Yes)
				{
					foreach (DataGridViewRow rows in dataGridView.SelectedRows)
					{
						if (rows.Index != dataGridView.RowCount - 1)
						{
							dataGridView.Rows.RemoveAt(rows.Index);
						}
						else
						{
							lblError.Text = "Эту строку нельзя удалить!";
							lblError.Visible = true;

							dataGridView.ClearSelection();
						}
					}
				}
				else
				{
					dataGridView.ClearSelection();
				}
			}
			else
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите строку(ки)!";
			}
		}

		private void btnHelp_Click(object sender, EventArgs e)
		{
			lblError.Visible = false;

			if (dataGridView.SelectedRows.Count == 0)
			{
				lblError.Visible = true;
				lblError.Text = "Сначала выберите строку!";
			}
			else if (dataGridView.SelectedRows.Count > 1)
			{
				lblError.Visible = true;
				lblError.Text = "Выберите только одну строку!";

				dataGridView.ClearSelection();
			}
			else if (dataGridView.SelectedRows.Contains(dataGridView.Rows[dataGridView.RowCount - 1]))
			{
				lblError.Visible = true;
				lblError.Text = "Для этой строки нельзя\nвывести справку!";

				dataGridView.ClearSelection();
			}
			else
			{
				HelpForm helpForm = new HelpForm();

				var rows = dataGridView.SelectedRows[0];

				helpForm.NameHelp = (string)dataGridView[0, rows.Index].Value;
				helpForm.CountHelp = Convert.ToUInt32(dataGridView[1, rows.Index].Value);
				helpForm.StorageCostsHelp = Convert.ToDouble(dataGridView[2, rows.Index].Value);
				helpForm.PreparationCostsHelp = Convert.ToDouble(dataGridView[3, rows.Index].Value);

				helpForm.ShowDialog();
			}
		}

		private void txtProductCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtStorageCosts_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtStorageCosts.Text.Contains('.') && !txtStorageCosts.Text.Contains(','))
			{
				if (txtStorageCosts.Text == "")
				{
					txtStorageCosts.Text = "0,";
					txtStorageCosts.SelectionStart = txtStorageCosts.TextLength;

					e.Handled = true;
					return;
				}

				e.KeyChar = ',';
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtPreparationCosts_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			else if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtPreparationCosts.Text.Contains('.') && !txtPreparationCosts.Text.Contains(','))
			{
				if (txtPreparationCosts.Text == "")
				{
					txtPreparationCosts.Text = "0,";
					txtPreparationCosts.SelectionStart = txtPreparationCosts.TextLength;

					e.Handled = true;
					return;
				}

				e.KeyChar = ',';
				return;
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtName_MouseClick(object sender, MouseEventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtProductCount_MouseClick(object sender, MouseEventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtStorageCosts_MouseClick(object sender, MouseEventArgs e)
		{
			lblError.Visible = false;
		}

		private void txtPreparationCosts_MouseClick(object sender, MouseEventArgs e)
		{
			lblError.Visible = false;
		}

		private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			lblError.Visible = false;
		}

		private void scrllCount_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtProductCount.Text = scrllCount.Value.ToString();
		}

		private void scrllStorage_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtStorageCosts.Text = scrllStorage.Value.ToString();
		}

		private void scrllPrep_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtPreparationCosts.Text = scrllPrep.Value.ToString();
		}
	}
}