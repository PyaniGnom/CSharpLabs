namespace ReadAndWriteCSV
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cbFiles = new System.Windows.Forms.ComboBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.txtSurname = new System.Windows.Forms.TextBox();
			this.lblSurname = new System.Windows.Forms.Label();
			this.lblPath = new System.Windows.Forms.Label();
			this.btnWrite = new System.Windows.Forms.Button();
			this.btnRead = new System.Windows.Forms.Button();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.PeopleSurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PeopleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.cbFiles);
			this.splitContainer1.Panel1.Controls.Add(this.txtName);
			this.splitContainer1.Panel1.Controls.Add(this.lblName);
			this.splitContainer1.Panel1.Controls.Add(this.txtSurname);
			this.splitContainer1.Panel1.Controls.Add(this.lblSurname);
			this.splitContainer1.Panel1.Controls.Add(this.lblPath);
			this.splitContainer1.Panel1.Controls.Add(this.btnWrite);
			this.splitContainer1.Panel1.Controls.Add(this.btnRead);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dataGridView);
			this.splitContainer1.Size = new System.Drawing.Size(952, 556);
			this.splitContainer1.SplitterDistance = 422;
			this.splitContainer1.TabIndex = 0;
			// 
			// cbFiles
			// 
			this.cbFiles.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.cbFiles.FormattingEnabled = true;
			this.cbFiles.Location = new System.Drawing.Point(140, 63);
			this.cbFiles.Name = "cbFiles";
			this.cbFiles.Size = new System.Drawing.Size(150, 29);
			this.cbFiles.TabIndex = 53;
			// 
			// txtName
			// 
			this.txtName.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtName.Location = new System.Drawing.Point(233, 204);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(160, 26);
			this.txtName.TabIndex = 51;
			// 
			// lblName
			// 
			this.lblName.AutoSize = true;
			this.lblName.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblName.Location = new System.Drawing.Point(229, 174);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(47, 21);
			this.lblName.TabIndex = 50;
			this.lblName.Text = "Имя:";
			// 
			// txtSurname
			// 
			this.txtSurname.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtSurname.Location = new System.Drawing.Point(32, 204);
			this.txtSurname.Name = "txtSurname";
			this.txtSurname.Size = new System.Drawing.Size(160, 26);
			this.txtSurname.TabIndex = 49;
			// 
			// lblSurname
			// 
			this.lblSurname.AutoSize = true;
			this.lblSurname.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblSurname.Location = new System.Drawing.Point(28, 174);
			this.lblSurname.Name = "lblSurname";
			this.lblSurname.Size = new System.Drawing.Size(89, 21);
			this.lblSurname.TabIndex = 48;
			this.lblSurname.Text = "Фамилия:";
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblPath.Location = new System.Drawing.Point(80, 67);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(58, 21);
			this.lblPath.TabIndex = 46;
			this.lblPath.Text = "Файл:";
			// 
			// btnWrite
			// 
			this.btnWrite.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnWrite.Location = new System.Drawing.Point(97, 353);
			this.btnWrite.Name = "btnWrite";
			this.btnWrite.Size = new System.Drawing.Size(100, 35);
			this.btnWrite.TabIndex = 0;
			this.btnWrite.Text = "Запись";
			this.btnWrite.UseVisualStyleBackColor = true;
			this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
			// 
			// btnRead
			// 
			this.btnRead.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnRead.Location = new System.Drawing.Point(224, 353);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(100, 35);
			this.btnRead.TabIndex = 1;
			this.btnRead.Text = "Чтение";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToAddRows = false;
			this.dataGridView.AllowUserToDeleteRows = false;
			this.dataGridView.AllowUserToResizeColumns = false;
			this.dataGridView.AllowUserToResizeRows = false;
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeopleSurname,
            this.PeopleName});
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.EnableHeadersVisualStyles = false;
			this.dataGridView.Location = new System.Drawing.Point(0, 0);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Control;
			this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.dataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			this.dataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			this.dataGridView.Size = new System.Drawing.Size(524, 554);
			this.dataGridView.TabIndex = 1;
			// 
			// PeopleSurname
			// 
			this.PeopleSurname.HeaderText = "Фамилия";
			this.PeopleSurname.Name = "PeopleSurname";
			// 
			// PeopleName
			// 
			this.PeopleName.HeaderText = "Имя";
			this.PeopleName.Name = "PeopleName";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(952, 556);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice05.2_Isaev.N.S_211-327";
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
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnWrite;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label lblName;
		private System.Windows.Forms.TextBox txtSurname;
		private System.Windows.Forms.Label lblSurname;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.ComboBox cbFiles;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleSurname;
		private System.Windows.Forms.DataGridViewTextBoxColumn PeopleName;
	}
}

