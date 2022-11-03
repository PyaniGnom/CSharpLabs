namespace RandomTableGrid
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
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tColumnsCount = new System.Windows.Forms.TextBox();
			this.lColumnsCount = new System.Windows.Forms.Label();
			this.lRowsCount = new System.Windows.Forms.Label();
			this.tRowsCount = new System.Windows.Forms.TextBox();
			this.bCreateTable = new System.Windows.Forms.Button();
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
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dataGridView);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tColumnsCount);
			this.splitContainer1.Panel2.Controls.Add(this.lColumnsCount);
			this.splitContainer1.Panel2.Controls.Add(this.lRowsCount);
			this.splitContainer1.Panel2.Controls.Add(this.tRowsCount);
			this.splitContainer1.Panel2.Controls.Add(this.bCreateTable);
			this.splitContainer1.Size = new System.Drawing.Size(864, 501);
			this.splitContainer1.SplitterDistance = 374;
			this.splitContainer1.TabIndex = 0;
			// 
			// dataGridView
			// 
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.75F);
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.RowTemplate.ReadOnly = true;
			this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.Size = new System.Drawing.Size(862, 372);
			this.dataGridView.TabIndex = 0;
			// 
			// tColumnsCount
			// 
			this.tColumnsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tColumnsCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tColumnsCount.Location = new System.Drawing.Point(414, 64);
			this.tColumnsCount.Name = "tColumnsCount";
			this.tColumnsCount.Size = new System.Drawing.Size(240, 27);
			this.tColumnsCount.TabIndex = 4;
			this.tColumnsCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tColumnsCount_MouseClick);
			this.tColumnsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tColumnsCount_KeyPress);
			// 
			// lColumnsCount
			// 
			this.lColumnsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lColumnsCount.AutoSize = true;
			this.lColumnsCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lColumnsCount.Location = new System.Drawing.Point(410, 29);
			this.lColumnsCount.Name = "lColumnsCount";
			this.lColumnsCount.Size = new System.Drawing.Size(213, 22);
			this.lColumnsCount.TabIndex = 3;
			this.lColumnsCount.Text = "Количество столбцов:";
			// 
			// lRowsCount
			// 
			this.lRowsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lRowsCount.AutoSize = true;
			this.lRowsCount.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lRowsCount.Location = new System.Drawing.Point(90, 29);
			this.lRowsCount.Name = "lRowsCount";
			this.lRowsCount.Size = new System.Drawing.Size(180, 22);
			this.lRowsCount.TabIndex = 2;
			this.lRowsCount.Text = "Количество строк:";
			// 
			// tRowsCount
			// 
			this.tRowsCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tRowsCount.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tRowsCount.Location = new System.Drawing.Point(94, 64);
			this.tRowsCount.Name = "tRowsCount";
			this.tRowsCount.Size = new System.Drawing.Size(240, 27);
			this.tRowsCount.TabIndex = 1;
			this.tRowsCount.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tRowsCount_MouseClick);
			this.tRowsCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tRowsCount_KeyPress);
			// 
			// bCreateTable
			// 
			this.bCreateTable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.bCreateTable.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bCreateTable.Location = new System.Drawing.Point(693, 40);
			this.bCreateTable.Name = "bCreateTable";
			this.bCreateTable.Size = new System.Drawing.Size(130, 40);
			this.bCreateTable.TabIndex = 0;
			this.bCreateTable.Text = "Создать";
			this.bCreateTable.UseVisualStyleBackColor = true;
			this.bCreateTable.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 501);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice02_Isaev.N.S_211-327";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button bCreateTable;
		private System.Windows.Forms.TextBox tRowsCount;
		private System.Windows.Forms.Label lRowsCount;
		private System.Windows.Forms.Label lColumnsCount;
		private System.Windows.Forms.TextBox tColumnsCount;
		private System.Windows.Forms.DataGridView dataGridView;
	}
}

