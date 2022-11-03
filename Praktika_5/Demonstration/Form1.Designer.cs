namespace Demonstration
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnTask4 = new System.Windows.Forms.Button();
			this.txtTask4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtTask3Year = new System.Windows.Forms.TextBox();
			this.txtTask3Month = new System.Windows.Forms.TextBox();
			this.txtTask3Day = new System.Windows.Forms.TextBox();
			this.btnTask3 = new System.Windows.Forms.Button();
			this.lblTask3 = new System.Windows.Forms.Label();
			this.btnTask2 = new System.Windows.Forms.Button();
			this.txtTask2 = new System.Windows.Forms.TextBox();
			this.lblTask2 = new System.Windows.Forms.Label();
			this.btnTask1 = new System.Windows.Forms.Button();
			this.lblTask1 = new System.Windows.Forms.Label();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.lblPath = new System.Windows.Forms.Label();
			this.richTextBox = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.btnTask4);
			this.splitContainer1.Panel1.Controls.Add(this.txtTask4);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.txtTask3Year);
			this.splitContainer1.Panel1.Controls.Add(this.txtTask3Month);
			this.splitContainer1.Panel1.Controls.Add(this.txtTask3Day);
			this.splitContainer1.Panel1.Controls.Add(this.btnTask3);
			this.splitContainer1.Panel1.Controls.Add(this.lblTask3);
			this.splitContainer1.Panel1.Controls.Add(this.btnTask2);
			this.splitContainer1.Panel1.Controls.Add(this.txtTask2);
			this.splitContainer1.Panel1.Controls.Add(this.lblTask2);
			this.splitContainer1.Panel1.Controls.Add(this.btnTask1);
			this.splitContainer1.Panel1.Controls.Add(this.lblTask1);
			this.splitContainer1.Panel1.Controls.Add(this.txtPath);
			this.splitContainer1.Panel1.Controls.Add(this.lblPath);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.richTextBox);
			this.splitContainer1.Size = new System.Drawing.Size(1077, 585);
			this.splitContainer1.SplitterDistance = 503;
			this.splitContainer1.TabIndex = 0;
			// 
			// btnTask4
			// 
			this.btnTask4.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.btnTask4.Location = new System.Drawing.Point(260, 523);
			this.btnTask4.Name = "btnTask4";
			this.btnTask4.Size = new System.Drawing.Size(100, 30);
			this.btnTask4.TabIndex = 58;
			this.btnTask4.Text = "Показать";
			this.btnTask4.UseVisualStyleBackColor = true;
			this.btnTask4.Click += new System.EventHandler(this.btnTask4_Click);
			// 
			// txtTask4
			// 
			this.txtTask4.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTask4.Location = new System.Drawing.Point(140, 525);
			this.txtTask4.Name = "txtTask4";
			this.txtTask4.Size = new System.Drawing.Size(95, 26);
			this.txtTask4.TabIndex = 57;
			this.txtTask4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTask4_KeyPress);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.label4.Location = new System.Drawing.Point(25, 460);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(386, 42);
			this.label4.TabIndex = 56;
			this.label4.Text = "Поиск файлов по заданному пути, вес которых\r\nбольше заданного размера в МБ:";
			// 
			// txtTask3Year
			// 
			this.txtTask3Year.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTask3Year.Location = new System.Drawing.Point(192, 405);
			this.txtTask3Year.Name = "txtTask3Year";
			this.txtTask3Year.Size = new System.Drawing.Size(80, 26);
			this.txtTask3Year.TabIndex = 55;
			this.txtTask3Year.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTask3Year_KeyPress);
			// 
			// txtTask3Month
			// 
			this.txtTask3Month.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTask3Month.Location = new System.Drawing.Point(146, 405);
			this.txtTask3Month.Name = "txtTask3Month";
			this.txtTask3Month.Size = new System.Drawing.Size(40, 26);
			this.txtTask3Month.TabIndex = 54;
			this.txtTask3Month.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTask3Month_KeyPress);
			// 
			// txtTask3Day
			// 
			this.txtTask3Day.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTask3Day.Location = new System.Drawing.Point(100, 405);
			this.txtTask3Day.Name = "txtTask3Day";
			this.txtTask3Day.Size = new System.Drawing.Size(40, 26);
			this.txtTask3Day.TabIndex = 53;
			this.txtTask3Day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTask3Day_KeyPress);
			// 
			// btnTask3
			// 
			this.btnTask3.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.btnTask3.Location = new System.Drawing.Point(300, 403);
			this.btnTask3.Name = "btnTask3";
			this.btnTask3.Size = new System.Drawing.Size(100, 30);
			this.btnTask3.TabIndex = 52;
			this.btnTask3.Text = "Показать";
			this.btnTask3.UseVisualStyleBackColor = true;
			this.btnTask3.Click += new System.EventHandler(this.btnTask3_Click);
			// 
			// lblTask3
			// 
			this.lblTask3.AutoSize = true;
			this.lblTask3.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.lblTask3.Location = new System.Drawing.Point(25, 325);
			this.lblTask3.Name = "lblTask3";
			this.lblTask3.Size = new System.Drawing.Size(423, 63);
			this.lblTask3.TabIndex = 51;
			this.lblTask3.Text = "Поиск катлогов верхнего уровня по заданному пути,\r\nсозданных после выбранной даты" +
    ".\r\n(Пример даты: 20 05 2022)";
			// 
			// btnTask2
			// 
			this.btnTask2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.btnTask2.Location = new System.Drawing.Point(260, 268);
			this.btnTask2.Name = "btnTask2";
			this.btnTask2.Size = new System.Drawing.Size(100, 30);
			this.btnTask2.TabIndex = 50;
			this.btnTask2.Text = "Показать";
			this.btnTask2.UseVisualStyleBackColor = true;
			this.btnTask2.Click += new System.EventHandler(this.btnTask2_Click);
			// 
			// txtTask2
			// 
			this.txtTask2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtTask2.Location = new System.Drawing.Point(140, 270);
			this.txtTask2.Name = "txtTask2";
			this.txtTask2.Size = new System.Drawing.Size(95, 26);
			this.txtTask2.TabIndex = 49;
			// 
			// lblTask2
			// 
			this.lblTask2.AutoSize = true;
			this.lblTask2.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.lblTask2.Location = new System.Drawing.Point(25, 205);
			this.lblTask2.Name = "lblTask2";
			this.lblTask2.Size = new System.Drawing.Size(410, 42);
			this.lblTask2.TabIndex = 48;
			this.lblTask2.Text = "Поиск и перечисление имён файлов в каталоге и\r\nподкаталогах по заданному расширен" +
    "ию:";
			// 
			// btnTask1
			// 
			this.btnTask1.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.btnTask1.Location = new System.Drawing.Point(200, 145);
			this.btnTask1.Name = "btnTask1";
			this.btnTask1.Size = new System.Drawing.Size(100, 30);
			this.btnTask1.TabIndex = 47;
			this.btnTask1.Text = "Показать";
			this.btnTask1.UseVisualStyleBackColor = true;
			this.btnTask1.Click += new System.EventHandler(this.btnTask1_Click);
			// 
			// lblTask1
			// 
			this.lblTask1.AutoSize = true;
			this.lblTask1.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.lblTask1.Location = new System.Drawing.Point(25, 90);
			this.lblTask1.Name = "lblTask1";
			this.lblTask1.Size = new System.Drawing.Size(423, 42);
			this.lblTask1.TabIndex = 46;
			this.lblTask1.Text = "Показать список имен каталогов первого уровня по\r\nзаданному пути:";
			// 
			// txtPath
			// 
			this.txtPath.Font = new System.Drawing.Font("Century Gothic", 11.5F);
			this.txtPath.Location = new System.Drawing.Point(91, 27);
			this.txtPath.Name = "txtPath";
			this.txtPath.Size = new System.Drawing.Size(370, 26);
			this.txtPath.TabIndex = 45;
			// 
			// lblPath
			// 
			this.lblPath.AutoSize = true;
			this.lblPath.Font = new System.Drawing.Font("Century Gothic", 11.75F);
			this.lblPath.Location = new System.Drawing.Point(25, 30);
			this.lblPath.Name = "lblPath";
			this.lblPath.Size = new System.Drawing.Size(47, 21);
			this.lblPath.TabIndex = 44;
			this.lblPath.Text = "Путь:";
			// 
			// richTextBox
			// 
			this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox.Font = new System.Drawing.Font("Century Gothic", 9.5F);
			this.richTextBox.Location = new System.Drawing.Point(0, 0);
			this.richTextBox.Name = "richTextBox";
			this.richTextBox.ReadOnly = true;
			this.richTextBox.Size = new System.Drawing.Size(568, 583);
			this.richTextBox.TabIndex = 0;
			this.richTextBox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1077, 585);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice05.1_Isaev.N.S_211-327";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnTask1;
		private System.Windows.Forms.Label lblTask1;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.RichTextBox richTextBox;
		private System.Windows.Forms.Label lblTask2;
		private System.Windows.Forms.Button btnTask2;
		private System.Windows.Forms.TextBox txtTask2;
		private System.Windows.Forms.Label lblTask3;
		private System.Windows.Forms.Button btnTask4;
		private System.Windows.Forms.TextBox txtTask4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtTask3Year;
		private System.Windows.Forms.TextBox txtTask3Month;
		private System.Windows.Forms.TextBox txtTask3Day;
		private System.Windows.Forms.Button btnTask3;
	}
}

