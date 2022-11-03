namespace CompanyDataBase
{
	partial class EditTable2Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTable2Form));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnUpdate = new System.Windows.Forms.ToolStripButton();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnSaveEdit = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtCost4 = new System.Windows.Forms.TextBox();
			this.lblCost4 = new System.Windows.Forms.Label();
			this.txtCost3 = new System.Windows.Forms.TextBox();
			this.lblCost3 = new System.Windows.Forms.Label();
			this.txtCost2 = new System.Windows.Forms.TextBox();
			this.lblCost2 = new System.Windows.Forms.Label();
			this.txtCost1 = new System.Windows.Forms.TextBox();
			this.lblCost1 = new System.Windows.Forms.Label();
			this.lblProductCode = new System.Windows.Forms.Label();
			this.cbCompanyCode = new System.Windows.Forms.ComboBox();
			this.lblRelease = new System.Windows.Forms.Label();
			this.txtRelease = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblCompanyCode = new System.Windows.Forms.Label();
			this.txtProductCode = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnAdd,
            this.btnDelete,
            this.btnEdit,
            this.btnSaveEdit,
            this.btnClear});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1432, 25);
			this.toolStrip1.TabIndex = 1;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnUpdate
			// 
			this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(71, 22);
			this.btnUpdate.Text = "Обновить";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
			this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(70, 22);
			this.btnAdd.Text = "Добавить";
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
			this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(59, 22);
			this.btnDelete.Text = "Удалить";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
			this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(70, 22);
			this.btnEdit.Text = "Изменить";
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnSaveEdit
			// 
			this.btnSaveEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnSaveEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEdit.Image")));
			this.btnSaveEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSaveEdit.Name = "btnSaveEdit";
			this.btnSaveEdit.Size = new System.Drawing.Size(143, 22);
			this.btnSaveEdit.Text = "Сохранить изменения";
			this.btnSaveEdit.Click += new System.EventHandler(this.btnSaveEdit_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 25);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtCost4);
			this.splitContainer1.Panel1.Controls.Add(this.lblCost4);
			this.splitContainer1.Panel1.Controls.Add(this.txtCost3);
			this.splitContainer1.Panel1.Controls.Add(this.lblCost3);
			this.splitContainer1.Panel1.Controls.Add(this.txtCost2);
			this.splitContainer1.Panel1.Controls.Add(this.lblCost2);
			this.splitContainer1.Panel1.Controls.Add(this.txtCost1);
			this.splitContainer1.Panel1.Controls.Add(this.lblCost1);
			this.splitContainer1.Panel1.Controls.Add(this.lblProductCode);
			this.splitContainer1.Panel1.Controls.Add(this.cbCompanyCode);
			this.splitContainer1.Panel1.Controls.Add(this.lblRelease);
			this.splitContainer1.Panel1.Controls.Add(this.txtRelease);
			this.splitContainer1.Panel1.Controls.Add(this.lblName);
			this.splitContainer1.Panel1.Controls.Add(this.txtName);
			this.splitContainer1.Panel1.Controls.Add(this.lblCompanyCode);
			this.splitContainer1.Panel1.Controls.Add(this.txtProductCode);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Size = new System.Drawing.Size(1432, 686);
			this.splitContainer1.SplitterDistance = 99;
			this.splitContainer1.TabIndex = 2;
			// 
			// txtCost4
			// 
			this.txtCost4.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtCost4.Location = new System.Drawing.Point(1110, 50);
			this.txtCost4.Name = "txtCost4";
			this.txtCost4.Size = new System.Drawing.Size(151, 26);
			this.txtCost4.TabIndex = 44;
			this.txtCost4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost4_KeyPress);
			// 
			// lblCost4
			// 
			this.lblCost4.AutoSize = true;
			this.lblCost4.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCost4.Location = new System.Drawing.Point(1106, 19);
			this.lblCost4.Name = "lblCost4";
			this.lblCost4.Size = new System.Drawing.Size(155, 21);
			this.lblCost4.TabIndex = 52;
			this.lblCost4.Text = "Цена_квартала_4:";
			// 
			// txtCost3
			// 
			this.txtCost3.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtCost3.Location = new System.Drawing.Point(939, 50);
			this.txtCost3.Name = "txtCost3";
			this.txtCost3.Size = new System.Drawing.Size(151, 26);
			this.txtCost3.TabIndex = 43;
			this.txtCost3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost3_KeyPress);
			// 
			// lblCost3
			// 
			this.lblCost3.AutoSize = true;
			this.lblCost3.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCost3.Location = new System.Drawing.Point(935, 19);
			this.lblCost3.Name = "lblCost3";
			this.lblCost3.Size = new System.Drawing.Size(155, 21);
			this.lblCost3.TabIndex = 51;
			this.lblCost3.Text = "Цена_квартала_3:";
			// 
			// txtCost2
			// 
			this.txtCost2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtCost2.Location = new System.Drawing.Point(768, 50);
			this.txtCost2.Name = "txtCost2";
			this.txtCost2.Size = new System.Drawing.Size(151, 26);
			this.txtCost2.TabIndex = 42;
			this.txtCost2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost2_KeyPress);
			// 
			// lblCost2
			// 
			this.lblCost2.AutoSize = true;
			this.lblCost2.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCost2.Location = new System.Drawing.Point(764, 19);
			this.lblCost2.Name = "lblCost2";
			this.lblCost2.Size = new System.Drawing.Size(155, 21);
			this.lblCost2.TabIndex = 50;
			this.lblCost2.Text = "Цена_квартала_2:";
			// 
			// txtCost1
			// 
			this.txtCost1.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtCost1.Location = new System.Drawing.Point(597, 50);
			this.txtCost1.Name = "txtCost1";
			this.txtCost1.Size = new System.Drawing.Size(151, 26);
			this.txtCost1.TabIndex = 41;
			this.txtCost1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCost1_KeyPress);
			// 
			// lblCost1
			// 
			this.lblCost1.AutoSize = true;
			this.lblCost1.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCost1.Location = new System.Drawing.Point(593, 19);
			this.lblCost1.Name = "lblCost1";
			this.lblCost1.Size = new System.Drawing.Size(155, 21);
			this.lblCost1.TabIndex = 49;
			this.lblCost1.Text = "Цена_квартала_1:";
			// 
			// lblProductCode
			// 
			this.lblProductCode.AutoSize = true;
			this.lblProductCode.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblProductCode.Location = new System.Drawing.Point(439, 19);
			this.lblProductCode.Name = "lblProductCode";
			this.lblProductCode.Size = new System.Drawing.Size(138, 21);
			this.lblProductCode.TabIndex = 48;
			this.lblProductCode.Text = "Шифр_изделия:";
			// 
			// cbCompanyCode
			// 
			this.cbCompanyCode.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.cbCompanyCode.FormattingEnabled = true;
			this.cbCompanyCode.Location = new System.Drawing.Point(18, 49);
			this.cbCompanyCode.Name = "cbCompanyCode";
			this.cbCompanyCode.Size = new System.Drawing.Size(185, 28);
			this.cbCompanyCode.TabIndex = 38;
			// 
			// lblRelease
			// 
			this.lblRelease.AutoSize = true;
			this.lblRelease.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblRelease.Location = new System.Drawing.Point(1277, 19);
			this.lblRelease.Name = "lblRelease";
			this.lblRelease.Size = new System.Drawing.Size(139, 21);
			this.lblRelease.TabIndex = 53;
			this.lblRelease.Text = "Годовой_выпуск:";
			// 
			// txtRelease
			// 
			this.txtRelease.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtRelease.Location = new System.Drawing.Point(1281, 50);
			this.txtRelease.Name = "txtRelease";
			this.txtRelease.Size = new System.Drawing.Size(135, 26);
			this.txtRelease.TabIndex = 45;
			this.txtRelease.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblName.Location = new System.Drawing.Point(219, 19);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(161, 21);
			this.lblName.TabIndex = 47;
			this.lblName.Text = "Название_изделия:";
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtName.Location = new System.Drawing.Point(223, 50);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(200, 26);
			this.txtName.TabIndex = 39;
			// 
			// lblCompanyCode
			// 
			this.lblCompanyCode.AutoSize = true;
			this.lblCompanyCode.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCompanyCode.Location = new System.Drawing.Point(14, 19);
			this.lblCompanyCode.Name = "lblCompanyCode";
			this.lblCompanyCode.Size = new System.Drawing.Size(151, 21);
			this.lblCompanyCode.TabIndex = 46;
			this.lblCompanyCode.Text = "Код_предприятия:";
			// 
			// txtProductCode
			// 
			this.txtProductCode.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtProductCode.Location = new System.Drawing.Point(443, 50);
			this.txtProductCode.Name = "txtProductCode";
			this.txtProductCode.Size = new System.Drawing.Size(134, 26);
			this.txtProductCode.TabIndex = 40;
			this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EnableHeadersVisualStyles = false;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.25F);
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.Size = new System.Drawing.Size(1430, 581);
			this.dataGridView.TabIndex = 6;
			// 
			// btnClear
			// 
			this.btnClear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
			this.btnClear.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(66, 22);
			this.btnClear.Text = "Очистить";
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// EditTable2Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1432, 711);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "EditTable2Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Редактирование таблицы изделий";
			this.Load += new System.EventHandler(this.EditTable2Form_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnUpdate;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnSaveEdit;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Label lblRelease;
		private System.Windows.Forms.TextBox txtRelease;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblCompanyCode;
		private System.Windows.Forms.TextBox txtProductCode;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ComboBox cbCompanyCode;
		private System.Windows.Forms.Label lblProductCode;
		private System.Windows.Forms.Label lblCost1;
		private System.Windows.Forms.TextBox txtCost2;
		private System.Windows.Forms.Label lblCost2;
		private System.Windows.Forms.TextBox txtCost1;
		private System.Windows.Forms.TextBox txtCost4;
		private System.Windows.Forms.Label lblCost4;
		private System.Windows.Forms.TextBox txtCost3;
		private System.Windows.Forms.Label lblCost3;
		private System.Windows.Forms.ToolStripButton btnClear;
	}
}