namespace Calculator
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lResult = new System.Windows.Forms.Label();
			this.lSecondValue = new System.Windows.Forms.Label();
			this.lFirstValue = new System.Windows.Forms.Label();
			this.tResult = new System.Windows.Forms.TextBox();
			this.tSecondValue = new System.Windows.Forms.TextBox();
			this.tFirstValue = new System.Windows.Forms.TextBox();
			this.bClearAll = new System.Windows.Forms.Button();
			this.bDivide = new System.Windows.Forms.Button();
			this.bMultiply = new System.Windows.Forms.Button();
			this.bSubtraction = new System.Windows.Forms.Button();
			this.bAddiction = new System.Windows.Forms.Button();
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
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lResult);
			this.splitContainer1.Panel1.Controls.Add(this.lSecondValue);
			this.splitContainer1.Panel1.Controls.Add(this.lFirstValue);
			this.splitContainer1.Panel1.Controls.Add(this.tResult);
			this.splitContainer1.Panel1.Controls.Add(this.tSecondValue);
			this.splitContainer1.Panel1.Controls.Add(this.tFirstValue);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.bClearAll);
			this.splitContainer1.Panel2.Controls.Add(this.bDivide);
			this.splitContainer1.Panel2.Controls.Add(this.bMultiply);
			this.splitContainer1.Panel2.Controls.Add(this.bSubtraction);
			this.splitContainer1.Panel2.Controls.Add(this.bAddiction);
			this.splitContainer1.Size = new System.Drawing.Size(348, 414);
			this.splitContainer1.SplitterDistance = 260;
			this.splitContainer1.TabIndex = 0;
			// 
			// lResult
			// 
			this.lResult.AutoSize = true;
			this.lResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lResult.Location = new System.Drawing.Point(65, 175);
			this.lResult.Name = "lResult";
			this.lResult.Size = new System.Drawing.Size(88, 21);
			this.lResult.TabIndex = 4;
			this.lResult.Text = "Результат:";
			// 
			// lSecondValue
			// 
			this.lSecondValue.AutoSize = true;
			this.lSecondValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lSecondValue.Location = new System.Drawing.Point(65, 95);
			this.lSecondValue.Name = "lSecondValue";
			this.lSecondValue.Size = new System.Drawing.Size(149, 21);
			this.lSecondValue.TabIndex = 3;
			this.lSecondValue.Text = "Второе значение:";
			// 
			// lFirstValue
			// 
			this.lFirstValue.AutoSize = true;
			this.lFirstValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lFirstValue.Location = new System.Drawing.Point(65, 15);
			this.lFirstValue.Name = "lFirstValue";
			this.lFirstValue.Size = new System.Drawing.Size(152, 21);
			this.lFirstValue.TabIndex = 0;
			this.lFirstValue.Text = "Первое значение:";
			// 
			// tResult
			// 
			this.tResult.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tResult.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tResult.Location = new System.Drawing.Point(64, 205);
			this.tResult.Name = "tResult";
			this.tResult.ReadOnly = true;
			this.tResult.Size = new System.Drawing.Size(218, 27);
			this.tResult.TabIndex = 2;
			// 
			// tSecondValue
			// 
			this.tSecondValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tSecondValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tSecondValue.Location = new System.Drawing.Point(64, 125);
			this.tSecondValue.Name = "tSecondValue";
			this.tSecondValue.Size = new System.Drawing.Size(218, 27);
			this.tSecondValue.TabIndex = 1;
			this.tSecondValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSecondValue_KeyPress);
			// 
			// tFirstValue
			// 
			this.tFirstValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.tFirstValue.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tFirstValue.Location = new System.Drawing.Point(64, 45);
			this.tFirstValue.Name = "tFirstValue";
			this.tFirstValue.Size = new System.Drawing.Size(218, 27);
			this.tFirstValue.TabIndex = 0;
			this.tFirstValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tFirstValue_KeyPress);
			// 
			// bClearAll
			// 
			this.bClearAll.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bClearAll.Location = new System.Drawing.Point(222, 31);
			this.bClearAll.Name = "bClearAll";
			this.bClearAll.Size = new System.Drawing.Size(96, 86);
			this.bClearAll.TabIndex = 4;
			this.bClearAll.Text = "Очистить всё";
			this.bClearAll.UseVisualStyleBackColor = true;
			this.bClearAll.Click += new System.EventHandler(this.bClearAll_Click);
			// 
			// bDivide
			// 
			this.bDivide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bDivide.Location = new System.Drawing.Point(122, 77);
			this.bDivide.Name = "bDivide";
			this.bDivide.Size = new System.Drawing.Size(70, 40);
			this.bDivide.TabIndex = 3;
			this.bDivide.Text = "/";
			this.bDivide.UseVisualStyleBackColor = true;
			this.bDivide.Click += new System.EventHandler(this.bDivide_Click);
			// 
			// bMultiply
			// 
			this.bMultiply.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bMultiply.Location = new System.Drawing.Point(46, 77);
			this.bMultiply.Name = "bMultiply";
			this.bMultiply.Size = new System.Drawing.Size(70, 40);
			this.bMultiply.TabIndex = 2;
			this.bMultiply.Text = "×";
			this.bMultiply.UseVisualStyleBackColor = true;
			this.bMultiply.Click += new System.EventHandler(this.bMultiply_Click);
			// 
			// bSubtraction
			// 
			this.bSubtraction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bSubtraction.Location = new System.Drawing.Point(122, 31);
			this.bSubtraction.Name = "bSubtraction";
			this.bSubtraction.Size = new System.Drawing.Size(70, 40);
			this.bSubtraction.TabIndex = 1;
			this.bSubtraction.Text = "-";
			this.bSubtraction.UseVisualStyleBackColor = true;
			this.bSubtraction.Click += new System.EventHandler(this.bSubtraction_Click);
			// 
			// bAddiction
			// 
			this.bAddiction.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bAddiction.Location = new System.Drawing.Point(46, 31);
			this.bAddiction.Name = "bAddiction";
			this.bAddiction.Size = new System.Drawing.Size(70, 40);
			this.bAddiction.TabIndex = 0;
			this.bAddiction.Text = "+";
			this.bAddiction.UseVisualStyleBackColor = true;
			this.bAddiction.Click += new System.EventHandler(this.bAddiction_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 414);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Practice02_Isaev.N.S_211-327";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox tFirstValue;
		private System.Windows.Forms.TextBox tResult;
		private System.Windows.Forms.TextBox tSecondValue;
		private System.Windows.Forms.Label lResult;
		private System.Windows.Forms.Label lSecondValue;
		private System.Windows.Forms.Label lFirstValue;
		private System.Windows.Forms.Button bDivide;
		private System.Windows.Forms.Button bMultiply;
		private System.Windows.Forms.Button bSubtraction;
		private System.Windows.Forms.Button bAddiction;
		private System.Windows.Forms.Button bClearAll;
	}
}