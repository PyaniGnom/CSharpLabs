namespace Web_Browser
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
			this.bgoButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.sNavigate = new System.Windows.Forms.ToolStripMenuItem();
			this.sHome = new System.Windows.Forms.ToolStripMenuItem();
			this.sgoBack = new System.Windows.Forms.ToolStripMenuItem();
			this.sgoForward = new System.Windows.Forms.ToolStripMenuItem();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.webBrowser1 = new System.Windows.Forms.WebBrowser();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.menuStrip1.SuspendLayout();
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
			this.splitContainer1.Panel1.Controls.Add(this.comboBox1);
			this.splitContainer1.Panel1.Controls.Add(this.bgoButton);
			this.splitContainer1.Panel1.Controls.Add(this.menuStrip1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
			this.splitContainer1.Size = new System.Drawing.Size(960, 540);
			this.splitContainer1.SplitterDistance = 56;
			this.splitContainer1.TabIndex = 0;
			// 
			// bgoButton
			// 
			this.bgoButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.bgoButton.Location = new System.Drawing.Point(445, 27);
			this.bgoButton.Name = "bgoButton";
			this.bgoButton.Size = new System.Drawing.Size(75, 25);
			this.bgoButton.TabIndex = 1;
			this.bgoButton.Text = "Перейти";
			this.bgoButton.UseVisualStyleBackColor = true;
			this.bgoButton.Click += new System.EventHandler(this.bgoButton_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sNavigate});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(958, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// sNavigate
			// 
			this.sNavigate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sHome,
            this.sgoBack,
            this.sgoForward});
			this.sNavigate.Name = "sNavigate";
			this.sNavigate.Size = new System.Drawing.Size(66, 20);
			this.sNavigate.Text = "Переход";
			// 
			// sHome
			// 
			this.sHome.Name = "sHome";
			this.sHome.Size = new System.Drawing.Size(188, 22);
			this.sHome.Text = "Домашняя страница";
			this.sHome.Click += new System.EventHandler(this.sHome_Click);
			// 
			// sgoBack
			// 
			this.sgoBack.Name = "sgoBack";
			this.sgoBack.Size = new System.Drawing.Size(188, 22);
			this.sgoBack.Text = "Назад";
			this.sgoBack.Click += new System.EventHandler(this.sgoBack_Click);
			// 
			// sgoForward
			// 
			this.sgoForward.Name = "sgoForward";
			this.sgoForward.Size = new System.Drawing.Size(188, 22);
			this.sgoForward.Text = "Далее";
			this.sgoForward.Click += new System.EventHandler(this.sgoForward_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "https://habr.com/ru/post/573434/",
            "https://www.twitch.tv/des0ut",
            "https://socialblade.com/twitch/user/buster/realtime",
            "https://www.minecraft.net/ru-ru/store/minecraft-java-edition",
            "https://ulearn.me/",
            "https://ru.wikipedia.org/wiki/Alt-%D0%BA%D0%BE%D0%B4",
            resources.GetString("comboBox1.Items")});
			this.comboBox1.Location = new System.Drawing.Point(318, 29);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 2;
			// 
			// webBrowser1
			// 
			this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.webBrowser1.Location = new System.Drawing.Point(0, 0);
			this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser1.Name = "webBrowser1";
			this.webBrowser1.Size = new System.Drawing.Size(958, 478);
			this.webBrowser1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 540);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Веб-обозреватель";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem sNavigate;
		private System.Windows.Forms.ToolStripMenuItem sHome;
		private System.Windows.Forms.ToolStripMenuItem sgoBack;
		private System.Windows.Forms.ToolStripMenuItem sgoForward;
		private System.Windows.Forms.Button bgoButton;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.WebBrowser webBrowser1;
	}
}

