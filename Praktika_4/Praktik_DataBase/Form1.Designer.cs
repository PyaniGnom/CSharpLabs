namespace Praktik_DataBase
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTable1 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmTable2 = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblSearch = new System.Windows.Forms.Label();
			this.lblError = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.btnUpdate = new System.Windows.Forms.ToolStripButton();
			this.btnAdd = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnEdit = new System.Windows.Forms.ToolStripButton();
			this.btnSaveEdit = new System.Windows.Forms.ToolStripButton();
			this.btnClear = new System.Windows.Forms.ToolStripButton();
			this.lblCode = new System.Windows.Forms.Label();
			this.txtCode = new System.Windows.Forms.TextBox();
			this.lblAuthor = new System.Windows.Forms.Label();
			this.txtAuthor = new System.Windows.Forms.TextBox();
			this.lblTitle = new System.Windows.Forms.Label();
			this.txtTitle = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblYear = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.toolStrip2.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1122, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// tsmFile
			// 
			this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTable1,
            this.tsmTable2,
            this.tsmExit});
			this.tsmFile.Name = "tsmFile";
			this.tsmFile.Size = new System.Drawing.Size(48, 20);
			this.tsmFile.Text = "Файл";
			this.tsmFile.Click += new System.EventHandler(this.ToolStripMenuItemFile_Click);
			// 
			// tsmTable1
			// 
			this.tsmTable1.Name = "tsmTable1";
			this.tsmTable1.Size = new System.Drawing.Size(202, 22);
			this.tsmTable1.Text = "Отечественные авторы";
			this.tsmTable1.Click += new System.EventHandler(this.tsmTable1_Click);
			// 
			// tsmTable2
			// 
			this.tsmTable2.Name = "tsmTable2";
			this.tsmTable2.Size = new System.Drawing.Size(202, 22);
			this.tsmTable2.Text = "Зарубежные авторы";
			this.tsmTable2.Click += new System.EventHandler(this.tsmTable2_Click);
			// 
			// tsmExit
			// 
			this.tsmExit.Name = "tsmExit";
			this.tsmExit.Size = new System.Drawing.Size(202, 22);
			this.tsmExit.Text = "Выход";
			this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 52);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lblYear);
			this.splitContainer1.Panel1.Controls.Add(this.txtYear);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.lblTitle);
			this.splitContainer1.Panel1.Controls.Add(this.txtTitle);
			this.splitContainer1.Panel1.Controls.Add(this.lblAuthor);
			this.splitContainer1.Panel1.Controls.Add(this.txtAuthor);
			this.splitContainer1.Panel1.Controls.Add(this.lblCode);
			this.splitContainer1.Panel1.Controls.Add(this.txtCode);
			this.splitContainer1.Panel1.Controls.Add(this.lblSearch);
			this.splitContainer1.Panel1.Controls.Add(this.lblError);
			this.splitContainer1.Panel1.Controls.Add(this.btnReset);
			this.splitContainer1.Panel1.Controls.Add(this.btnSearch);
			this.splitContainer1.Panel1.Controls.Add(this.txtSearch);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Size = new System.Drawing.Size(1122, 609);
			this.splitContainer1.SplitterDistance = 322;
			this.splitContainer1.TabIndex = 2;
			// 
			// lblSearch
			// 
			this.lblSearch.AutoSize = true;
			this.lblSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblSearch.Location = new System.Drawing.Point(20, 21);
			this.lblSearch.Name = "lblSearch";
			this.lblSearch.Size = new System.Drawing.Size(144, 21);
			this.lblSearch.TabIndex = 14;
			this.lblSearch.Text = "Поиск по автору:";
			// 
			// lblError
			// 
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblError.ForeColor = System.Drawing.Color.IndianRed;
			this.lblError.Location = new System.Drawing.Point(35, 515);
			this.lblError.Name = "lblError";
			this.lblError.Size = new System.Drawing.Size(153, 18);
			this.lblError.TabIndex = 12;
			this.lblError.Text = "*поле для ошибки*";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.Location = new System.Drawing.Point(110, 95);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(100, 28);
			this.btnReset.TabIndex = 4;
			this.btnReset.Text = "Сбросить";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSearch.Location = new System.Drawing.Point(220, 50);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(80, 28);
			this.btnSearch.TabIndex = 2;
			this.btnSearch.Text = "Поиск";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtSearch.Location = new System.Drawing.Point(24, 51);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(190, 26);
			this.txtSearch.TabIndex = 1;
			this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
			dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle12.BackColor = System.Drawing.Color.PaleTurquoise;
			dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.GrayText;
			dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EnableHeadersVisualStyles = false;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.ControlText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.Size = new System.Drawing.Size(794, 607);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
			// 
			// toolStrip2
			// 
			this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
			this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnAdd,
            this.btnDelete,
            this.btnEdit,
            this.btnSaveEdit,
            this.btnClear});
			this.toolStrip2.Location = new System.Drawing.Point(0, 24);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1122, 25);
			this.toolStrip2.TabIndex = 3;
			this.toolStrip2.Text = "toolStrip2";
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
			// lblCode
			// 
			this.lblCode.AutoSize = true;
			this.lblCode.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblCode.Location = new System.Drawing.Point(20, 170);
			this.lblCode.Name = "lblCode";
			this.lblCode.Size = new System.Drawing.Size(94, 21);
			this.lblCode.TabIndex = 41;
			this.lblCode.Text = "Код_книги:";
			// 
			// txtCode
			// 
			this.txtCode.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtCode.Location = new System.Drawing.Point(24, 200);
			this.txtCode.Name = "txtCode";
			this.txtCode.Size = new System.Drawing.Size(147, 26);
			this.txtCode.TabIndex = 40;
			this.txtCode.Click += new System.EventHandler(this.txtCode_Click);
			this.txtCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
			// 
			// lblAuthor
			// 
			this.lblAuthor.AutoSize = true;
			this.lblAuthor.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblAuthor.Location = new System.Drawing.Point(20, 250);
			this.lblAuthor.Name = "lblAuthor";
			this.lblAuthor.Size = new System.Drawing.Size(61, 21);
			this.lblAuthor.TabIndex = 43;
			this.lblAuthor.Text = "Автор:";
			// 
			// txtAuthor
			// 
			this.txtAuthor.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtAuthor.Location = new System.Drawing.Point(24, 280);
			this.txtAuthor.Name = "txtAuthor";
			this.txtAuthor.Size = new System.Drawing.Size(200, 26);
			this.txtAuthor.TabIndex = 42;
			this.txtAuthor.Click += new System.EventHandler(this.txtAuthor_Click);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblTitle.Location = new System.Drawing.Point(20, 330);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(210, 21);
			this.lblTitle.TabIndex = 45;
			this.lblTitle.Text = "Название_произведения:";
			// 
			// txtTitle
			// 
			this.txtTitle.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTitle.Location = new System.Drawing.Point(24, 360);
			this.txtTitle.Name = "txtTitle";
			this.txtTitle.Size = new System.Drawing.Size(200, 26);
			this.txtTitle.TabIndex = 44;
			this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(-3, 130);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(332, 18);
			this.label1.TabIndex = 46;
			this.label1.Text = "____________________________________";
			// 
			// lblYear
			// 
			this.lblYear.AutoSize = true;
			this.lblYear.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblYear.Location = new System.Drawing.Point(20, 410);
			this.lblYear.Name = "lblYear";
			this.lblYear.Size = new System.Drawing.Size(113, 21);
			this.lblYear.TabIndex = 48;
			this.lblYear.Text = "Год_выпуска:";
			// 
			// txtYear
			// 
			this.txtYear.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtYear.Location = new System.Drawing.Point(24, 440);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(147, 26);
			this.txtYear.TabIndex = 47;
			this.txtYear.Click += new System.EventHandler(this.txtYear_Click);
			this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCode_KeyPress);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1122, 661);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice04_Isaev.N.S_211-327";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.toolStrip2.ResumeLayout(false);
			this.toolStrip2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem tsmFile;
		private System.Windows.Forms.ToolStripMenuItem tsmTable1;
		private System.Windows.Forms.ToolStripMenuItem tsmTable2;
		private System.Windows.Forms.ToolStripMenuItem tsmExit;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblError;
		private System.Windows.Forms.Label lblSearch;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripButton btnUpdate;
		private System.Windows.Forms.ToolStripButton btnAdd;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnEdit;
		private System.Windows.Forms.ToolStripButton btnSaveEdit;
		private System.Windows.Forms.ToolStripButton btnClear;
		private System.Windows.Forms.Label lblCode;
		private System.Windows.Forms.TextBox txtCode;
		private System.Windows.Forms.Label lblAuthor;
		private System.Windows.Forms.TextBox txtAuthor;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.TextBox txtTitle;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblYear;
		private System.Windows.Forms.TextBox txtYear;
	}
}

