namespace ProductGrid
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.scrollPrep = new System.Windows.Forms.HScrollBar();
			this.scrollStorage = new System.Windows.Forms.HScrollBar();
			this.scrollCount = new System.Windows.Forms.HScrollBar();
			this.lblError = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnHelp = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtPreparationCosts = new System.Windows.Forms.TextBox();
			this.txtStorageCosts = new System.Windows.Forms.TextBox();
			this.txtProductCount = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblPreparationCosts = new System.Windows.Forms.Label();
			this.lblStorageCosts = new System.Windows.Forms.Label();
			this.lblProductCount = new System.Windows.Forms.Label();
			this.lblName = new System.Windows.Forms.Label();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.СolumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnStorageCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPreparationCosts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.scrollPrep);
			this.splitContainer1.Panel1.Controls.Add(this.scrollStorage);
			this.splitContainer1.Panel1.Controls.Add(this.scrollCount);
			this.splitContainer1.Panel1.Controls.Add(this.lblError);
			this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
			this.splitContainer1.Panel1.Controls.Add(this.btnHelp);
			this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
			this.splitContainer1.Panel1.Controls.Add(this.txtPreparationCosts);
			this.splitContainer1.Panel1.Controls.Add(this.txtStorageCosts);
			this.splitContainer1.Panel1.Controls.Add(this.txtProductCount);
			this.splitContainer1.Panel1.Controls.Add(this.txtName);
			this.splitContainer1.Panel1.Controls.Add(this.lblPreparationCosts);
			this.splitContainer1.Panel1.Controls.Add(this.lblStorageCosts);
			this.splitContainer1.Panel1.Controls.Add(this.lblProductCount);
			this.splitContainer1.Panel1.Controls.Add(this.lblName);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Size = new System.Drawing.Size(1184, 661);
			this.splitContainer1.SplitterDistance = 380;
			this.splitContainer1.TabIndex = 0;
			// 
			// scrollPrep
			// 
			this.scrollPrep.LargeChange = 1;
			this.scrollPrep.Location = new System.Drawing.Point(215, 384);
			this.scrollPrep.Maximum = 999;
			this.scrollPrep.Name = "scrollPrep";
			this.scrollPrep.Size = new System.Drawing.Size(155, 20);
			this.scrollPrep.TabIndex = 14;
			this.scrollPrep.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollPrep_Scroll);
			// 
			// scrollStorage
			// 
			this.scrollStorage.LargeChange = 1;
			this.scrollStorage.Location = new System.Drawing.Point(215, 263);
			this.scrollStorage.Maximum = 999;
			this.scrollStorage.Name = "scrollStorage";
			this.scrollStorage.Size = new System.Drawing.Size(155, 20);
			this.scrollStorage.TabIndex = 13;
			this.scrollStorage.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollStorage_Scroll);
			// 
			// scrollCount
			// 
			this.scrollCount.LargeChange = 1;
			this.scrollCount.Location = new System.Drawing.Point(215, 163);
			this.scrollCount.Maximum = 999;
			this.scrollCount.Name = "scrollCount";
			this.scrollCount.Size = new System.Drawing.Size(155, 20);
			this.scrollCount.TabIndex = 12;
			this.scrollCount.Value = 1;
			this.scrollCount.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollCount_Scroll);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblError.ForeColor = System.Drawing.Color.IndianRed;
			this.lblError.Location = new System.Drawing.Point(40, 520);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(153, 18);
			this.lblError.TabIndex = 11;
			this.lblError.Text = "*поле для ошибки*";
			// 
			// btnDelete
			// 
			this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnDelete.Location = new System.Drawing.Point(222, 460);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 30);
			this.btnDelete.TabIndex = 10;
			this.btnDelete.Text = "Удалить";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnHelp
			// 
			this.btnHelp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnHelp.Location = new System.Drawing.Point(117, 460);
			this.btnHelp.Name = "btnHelp";
			this.btnHelp.Size = new System.Drawing.Size(100, 30);
			this.btnHelp.TabIndex = 9;
			this.btnHelp.Text = "Справка";
			this.btnHelp.UseVisualStyleBackColor = true;
			this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnAdd.Location = new System.Drawing.Point(12, 460);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(100, 30);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtPreparationCosts
			// 
			this.txtPreparationCosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtPreparationCosts.Location = new System.Drawing.Point(34, 381);
			this.txtPreparationCosts.Name = "txtPreparationCosts";
			this.txtPreparationCosts.Size = new System.Drawing.Size(170, 27);
			this.txtPreparationCosts.TabIndex = 7;
			this.txtPreparationCosts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPreparationCosts_MouseClick);
			this.txtPreparationCosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreparationCosts_KeyPress);
			// 
			// txtStorageCosts
			// 
			this.txtStorageCosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtStorageCosts.Location = new System.Drawing.Point(34, 260);
			this.txtStorageCosts.Name = "txtStorageCosts";
			this.txtStorageCosts.Size = new System.Drawing.Size(170, 27);
			this.txtStorageCosts.TabIndex = 6;
			this.txtStorageCosts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtStorageCosts_MouseClick);
			this.txtStorageCosts.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStorageCosts_KeyPress);
			// 
			// txtProductCount
			// 
			this.txtProductCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtProductCount.Location = new System.Drawing.Point(34, 160);
			this.txtProductCount.Name = "txtProductCount";
			this.txtProductCount.Size = new System.Drawing.Size(170, 27);
			this.txtProductCount.TabIndex = 5;
			this.txtProductCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtProductCount_MouseClick);
			this.txtProductCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCount_KeyPress);
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtName.Location = new System.Drawing.Point(34, 60);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(220, 27);
			this.txtName.TabIndex = 4;
			this.txtName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtName_MouseClick);
			// 
			// lblPreparationCosts
			// 
			this.lblPreparationCosts.AutoSize = true;
			this.lblPreparationCosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPreparationCosts.Location = new System.Drawing.Point(30, 330);
			this.lblPreparationCosts.Name = "lblPreparationCosts";
			this.lblPreparationCosts.Size = new System.Drawing.Size(188, 42);
			this.lblPreparationCosts.TabIndex = 3;
			this.lblPreparationCosts.Text = "Затраты на подготовку\r\nк производству:";
			// 
			// lblStorageCosts
			// 
			this.lblStorageCosts.AutoSize = true;
			this.lblStorageCosts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblStorageCosts.Location = new System.Drawing.Point(30, 230);
			this.lblStorageCosts.Name = "lblStorageCosts";
			this.lblStorageCosts.Size = new System.Drawing.Size(188, 21);
			this.lblStorageCosts.TabIndex = 2;
			this.lblStorageCosts.Text = "Затраты на хранение:";
			// 
			// lblProductCount
			// 
			this.lblProductCount.AutoSize = true;
			this.lblProductCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblProductCount.Location = new System.Drawing.Point(30, 130);
			this.lblProductCount.Name = "lblProductCount";
			this.lblProductCount.Size = new System.Drawing.Size(171, 21);
			this.lblProductCount.TabIndex = 1;
			this.lblProductCount.Text = "Количество изделий:";
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblName.Location = new System.Drawing.Point(30, 30);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(157, 21);
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Название изделия:";
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.75F);
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.СolumnName, this.ColumnProductCount, this.ColumnStorageCosts, this.ColumnPreparationCosts });
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
			this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.RowTemplate.Height = 28;
			this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.Size = new System.Drawing.Size(798, 659);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// СolumnName
			// 
			this.СolumnName.Frozen = true;
			this.СolumnName.HeaderText = "Название изделия";
			this.СolumnName.Name = "СolumnName";
			this.СolumnName.ReadOnly = true;
			this.СolumnName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.СolumnName.Width = 180;
			// 
			// ColumnProductCount
			// 
			this.ColumnProductCount.Frozen = true;
			this.ColumnProductCount.HeaderText = "Количество изделий";
			this.ColumnProductCount.Name = "ColumnProductCount";
			this.ColumnProductCount.ReadOnly = true;
			this.ColumnProductCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnProductCount.Width = 177;
			// 
			// ColumnStorageCosts
			// 
			this.ColumnStorageCosts.Frozen = true;
			this.ColumnStorageCosts.HeaderText = "Затраты на хранение";
			this.ColumnStorageCosts.Name = "ColumnStorageCosts";
			this.ColumnStorageCosts.ReadOnly = true;
			this.ColumnStorageCosts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnStorageCosts.Width = 177;
			// 
			// ColumnPreparationCosts
			// 
			this.ColumnPreparationCosts.Frozen = true;
			this.ColumnPreparationCosts.HeaderText = "Затраты на подготовку к производству";
			this.ColumnPreparationCosts.Name = "ColumnPreparationCosts";
			this.ColumnPreparationCosts.ReadOnly = true;
			this.ColumnPreparationCosts.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.ColumnPreparationCosts.Width = 221;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1184, 661);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lab03_Isaev.N.S_211-327";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.Label lblStorageCosts;
		private System.Windows.Forms.Label lblProductCount;
		private System.Windows.Forms.Label lblPreparationCosts;
		private System.Windows.Forms.TextBox txtProductCount;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtPreparationCosts;
		private System.Windows.Forms.TextBox txtStorageCosts;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnHelp;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.HScrollBar scrollCount;
		private System.Windows.Forms.HScrollBar scrollPrep;
		private System.Windows.Forms.HScrollBar scrollStorage;
		private System.Windows.Forms.DataGridViewTextBoxColumn СolumnName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductCount;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStorageCosts;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPreparationCosts;
	}
}

