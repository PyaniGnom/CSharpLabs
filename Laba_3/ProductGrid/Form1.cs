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
			return txtName.Text != "" && txtProductCount.Text != "" && txtStorageCosts.Text != "" && txtPreparationCosts.Text != "";
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

			switch (dataGridView.SelectedRows.Count)
			{
				case 0:
					lblError.Visible = true;
					lblError.Text = "Сначала выберите строку!";
					break;

				case > 1:
					lblError.Visible = true;
					lblError.Text = "Выберите только одну строку!";

					dataGridView.ClearSelection();
					break;

				default:
					{
						if (dataGridView.SelectedRows.Contains(dataGridView.Rows[dataGridView.RowCount - 1]))
						{
							lblError.Visible = true;
							lblError.Text = "Для этой строки нельзя\nвывести справку!";

							dataGridView.ClearSelection();
						}
						else
						{
							var row = dataGridView.SelectedRows[0];
							HelpForm helpForm = new()
							{
								NameHelp = (string)dataGridView[0, row.Index].Value,
								CountHelp = (uint)dataGridView[1, row.Index].Value,
								StorageCostsHelp = (float)dataGridView[2, row.Index].Value,
								PreparationCostsHelp = (float)dataGridView[3, row.Index].Value
							};

							helpForm.ShowDialog();
						}

						break;
					}
			}
		}

		private void txtProductCount_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
				e.Handled = true;
		}

		private void txtStorageCosts_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtStorageCosts.Text.Contains('.') && !txtStorageCosts.Text.Contains(','))
			{
				if (txtStorageCosts.Text == "")
				{
					txtStorageCosts.Text = "0,";
					txtStorageCosts.SelectionStart = txtStorageCosts.TextLength;

					e.Handled = true;
					return;
				}

				e.KeyChar = ',';
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
			if ((e.KeyChar == '.' || e.KeyChar == ',') && !txtPreparationCosts.Text.Contains('.') && !txtPreparationCosts.Text.Contains(','))
			{
				if (txtPreparationCosts.Text == "")
				{
					txtPreparationCosts.Text = "0,";
					txtPreparationCosts.SelectionStart = txtPreparationCosts.TextLength;

					e.Handled = true;
					return;
				}

				e.KeyChar = ',';
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

		private void scrollCount_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtProductCount.Text = scrollCount.Value.ToString();
		}

		private void scrollStorage_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtStorageCosts.Text = scrollStorage.Value.ToString();
		}

		private void scrollPrep_Scroll(object sender, ScrollEventArgs e)
		{
			lblError.Visible = false;
			txtPreparationCosts.Text = scrollPrep.Value.ToString();
		}
	}
}
