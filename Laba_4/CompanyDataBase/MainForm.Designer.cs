namespace CompanyDataBase
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditCompanyDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditProductDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnUpdate = new System.Windows.Forms.ToolStripButton();
			this.btnReset = new System.Windows.Forms.ToolStripButton();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtThirdTask = new System.Windows.Forms.TextBox();
			this.btnReplace = new System.Windows.Forms.Button();
			this.cbThirdTask = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnFirstTask = new System.Windows.Forms.Button();
			this.lblError = new System.Windows.Forms.Label();
			this.btnSearch = new System.Windows.Forms.Button();
			this.cbSecondTask = new System.Windows.Forms.ComboBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.label6 = new System.Windows.Forms.Label();
			this.btnThirdTask = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1504, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditCompanyDBToolStripMenuItem,
            this.EditProductDBToolStripMenuItem,
            this.ExitToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.FileToolStripMenuItem.Text = "Файл";
			this.FileToolStripMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
			// 
			// EditCompanyDBToolStripMenuItem
			// 
			this.EditCompanyDBToolStripMenuItem.Name = "EditCompanyDBToolStripMenuItem";
			this.EditCompanyDBToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
			this.EditCompanyDBToolStripMenuItem.Text = "Редактирование таблицы предприятий";
			this.EditCompanyDBToolStripMenuItem.Click += new System.EventHandler(this.EditCompanyDBToolStripMenuItem_Click);
			// 
			// EditProductDBToolStripMenuItem
			// 
			this.EditProductDBToolStripMenuItem.Name = "EditProductDBToolStripMenuItem";
			this.EditProductDBToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
			this.EditProductDBToolStripMenuItem.Text = "Редактировать таблицу изделий";
			this.EditProductDBToolStripMenuItem.Click += new System.EventHandler(this.EditProductDBToolStripMenuItem_Click);
			// 
			// ExitToolStripMenuItem
			// 
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(289, 22);
			this.ExitToolStripMenuItem.Text = "Выход";
			this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnReset});
			this.toolStrip1.Location = new System.Drawing.Point(0, 24);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1504, 25);
			this.toolStrip1.TabIndex = 2;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnUpdate
			// 
			this.btnUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
			this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(65, 22);
			this.btnUpdate.Text = "Обновить";
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnReset
			// 
			this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
			this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(64, 22);
			this.btnReset.Text = "Сбросить";
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 49);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.btnThirdTask);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.txtThirdTask);
			this.splitContainer1.Panel1.Controls.Add(this.btnReplace);
			this.splitContainer1.Panel1.Controls.Add(this.cbThirdTask);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.btnFirstTask);
			this.splitContainer1.Panel1.Controls.Add(this.lblError);
			this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel1.Controls.Add(this.cbSecondTask);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Size = new System.Drawing.Size(1504, 732);
			this.splitContainer1.SplitterDistance = 286;
			this.splitContainer1.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.label5.Location = new System.Drawing.Point(14, 530);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 21);
			this.label5.TabIndex = 27;
			this.label5.Text = "Введите желаемый:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.label4.Location = new System.Drawing.Point(14, 430);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(222, 42);
			this.label4.TabIndex = 26;
			this.label4.Text = "Выберите шифр продукта\r\nдля замены:";
			// 
			// txtThirdTask
			// 
			this.txtThirdTask.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtThirdTask.Location = new System.Drawing.Point(18, 560);
			this.txtThirdTask.Name = "txtThirdTask";
			this.txtThirdTask.Size = new System.Drawing.Size(185, 26);
			this.txtThirdTask.TabIndex = 25;
			this.txtThirdTask.Click += new System.EventHandler(this.txtThirdTask_Click);
			this.txtThirdTask.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtThirdTask_KeyPress);
			// 
			// btnReplace
			// 
			this.btnReplace.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnReplace.Location = new System.Drawing.Point(92, 620);
			this.btnReplace.Name = "btnReplace";
			this.btnReplace.Size = new System.Drawing.Size(96, 30);
			this.btnReplace.TabIndex = 24;
			this.btnReplace.Text = "Заменить";
			this.btnReplace.UseVisualStyleBackColor = true;
			this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
			// 
			// cbThirdTask
			// 
			this.cbThirdTask.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.cbThirdTask.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.cbThirdTask.FormattingEnabled = true;
			this.cbThirdTask.Location = new System.Drawing.Point(18, 480);
			this.cbThirdTask.Name = "cbThirdTask";
			this.cbThirdTask.Size = new System.Drawing.Size(185, 28);
			this.cbThirdTask.TabIndex = 23;
			this.cbThirdTask.Click += new System.EventHandler(this.cbThirdTask_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(-2, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(295, 19);
			this.label3.TabIndex = 22;
			this.label3.Text = "Задание 3___________________________";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(-2, 130);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(295, 19);
			this.label2.TabIndex = 21;
			this.label2.Text = "Задание 2___________________________";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(-2, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(295, 19);
			this.label1.TabIndex = 20;
			this.label1.Text = "Задание 1___________________________";
			// 
			// btnFirstTask
			// 
			this.btnFirstTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFirstTask.Location = new System.Drawing.Point(92, 65);
			this.btnFirstTask.Name = "btnFirstTask";
			this.btnFirstTask.Size = new System.Drawing.Size(100, 30);
			this.btnFirstTask.TabIndex = 19;
			this.btnFirstTask.Text = "Выполнить";
			this.btnFirstTask.UseVisualStyleBackColor = true;
			this.btnFirstTask.Click += new System.EventHandler(this.btnFirstTask_Click);
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblError.ForeColor = System.Drawing.Color.IndianRed;
			this.lblError.Location = new System.Drawing.Point(18, 670);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(153, 18);
			this.lblError.TabIndex = 18;
			this.lblError.Text = "*поле для ошибки*";
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSearch.Location = new System.Drawing.Point(202, 194);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(75, 30);
			this.btnSearch.TabIndex = 17;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// cbSecondTask
			// 
			this.cbSecondTask.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.cbSecondTask.FormattingEnabled = true;
			this.cbSecondTask.Location = new System.Drawing.Point(10, 195);
			this.cbSecondTask.Name = "cbSecondTask";
			this.cbSecondTask.Size = new System.Drawing.Size(185, 28);
			this.cbSecondTask.TabIndex = 16;
			this.cbSecondTask.Click += new System.EventHandler(this.cbSecondTask_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10.75F);
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EnableHeadersVisualStyles = false;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 10.25F);
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.RowTemplate.ReadOnly = true;
			this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.Size = new System.Drawing.Size(1212, 730);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(-2, 390);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(295, 19);
			this.label6.TabIndex = 28;
			this.label6.Text = "Задание 4___________________________";
			// 
			// btnThirdTask
			// 
			this.btnThirdTask.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThirdTask.Location = new System.Drawing.Point(92, 325);
			this.btnThirdTask.Name = "btnThirdTask";
			this.btnThirdTask.Size = new System.Drawing.Size(100, 30);
			this.btnThirdTask.TabIndex = 29;
			this.btnThirdTask.Text = "Выполнить";
			this.btnThirdTask.UseVisualStyleBackColor = true;
			this.btnThirdTask.Click += new System.EventHandler(this.btnThirdTask_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1504, 781);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.toolStrip1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laba04_Isaev.N.S_211-327";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem EditCompanyDBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton btnReset;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.ComboBox cbSecondTask;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Button btnFirstTask;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ToolStripButton btnUpdate;
		private System.Windows.Forms.Button btnReplace;
		private System.Windows.Forms.ComboBox cbThirdTask;
		private System.Windows.Forms.TextBox txtThirdTask;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ToolStripMenuItem EditProductDBToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThirdTask;
    }
}