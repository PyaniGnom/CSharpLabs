namespace PingPong
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
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsmGame = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmNewGame = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmEndGame = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.lblScore = new System.Windows.Forms.Label();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.tbPlatformSize = new System.Windows.Forms.TrackBar();
			this.lblPlatformSize = new System.Windows.Forms.Label();
			this.lblBallSpeed = new System.Windows.Forms.Label();
			this.tbBallSpeed = new System.Windows.Forms.TrackBar();
			this.lblBallSize = new System.Windows.Forms.Label();
			this.tbBallSize = new System.Windows.Forms.TrackBar();
			this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmGameInfo = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlatformSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBallSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBallSize)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGame,
            this.tsmHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(964, 27);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// tsmGame
			// 
			this.tsmGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNewGame,
            this.tsmEndGame,
            this.tsmExit});
			this.tsmGame.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tsmGame.Name = "tsmGame";
			this.tsmGame.Size = new System.Drawing.Size(51, 23);
			this.tsmGame.Text = "Игра";
			// 
			// tsmNewGame
			// 
			this.tsmNewGame.Name = "tsmNewGame";
			this.tsmNewGame.ShortcutKeys = System.Windows.Forms.Keys.F5;
			this.tsmNewGame.Size = new System.Drawing.Size(203, 24);
			this.tsmNewGame.Text = "Новая игра";
			this.tsmNewGame.Click += new System.EventHandler(this.tsmNewGame_Click);
			// 
			// tsmEndGame
			// 
			this.tsmEndGame.Name = "tsmEndGame";
			this.tsmEndGame.ShortcutKeys = System.Windows.Forms.Keys.F9;
			this.tsmEndGame.Size = new System.Drawing.Size(203, 24);
			this.tsmEndGame.Text = "Завершить игру";
			this.tsmEndGame.Click += new System.EventHandler(this.tsmEndGame_Click);
			// 
			// tsmExit
			// 
			this.tsmExit.Name = "tsmExit";
			this.tsmExit.Size = new System.Drawing.Size(203, 24);
			this.tsmExit.Text = "Выход";
			this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(0, 27);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.BackColor = System.Drawing.Color.Black;
			this.splitContainer.Panel1.Controls.Add(this.lblScore);
			this.splitContainer.Panel1.Controls.Add(this.pictureBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.tbPlatformSize);
			this.splitContainer.Panel2.Controls.Add(this.lblPlatformSize);
			this.splitContainer.Panel2.Controls.Add(this.lblBallSpeed);
			this.splitContainer.Panel2.Controls.Add(this.tbBallSpeed);
			this.splitContainer.Panel2.Controls.Add(this.lblBallSize);
			this.splitContainer.Panel2.Controls.Add(this.tbBallSize);
			this.splitContainer.Size = new System.Drawing.Size(964, 574);
			this.splitContainer.SplitterDistance = 642;
			this.splitContainer.TabIndex = 1;
			// 
			// lblScore
			// 
			this.lblScore.AutoSize = true;
			this.lblScore.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 42F);
			this.lblScore.ForeColor = System.Drawing.Color.White;
			this.lblScore.Location = new System.Drawing.Point(242, 21);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(164, 56);
			this.lblScore.TabIndex = 2;
			this.lblScore.Text = "0 – 0";
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.White;
			this.pictureBox.BackgroundImage = global::PingPong.Properties.Resources.BackgroundPingPong;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox.Location = new System.Drawing.Point(0, 92);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(640, 480);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			// 
			// tbPlatformSize
			// 
			this.tbPlatformSize.LargeChange = 2;
			this.tbPlatformSize.Location = new System.Drawing.Point(3, 210);
			this.tbPlatformSize.Maximum = 100;
			this.tbPlatformSize.Minimum = 30;
			this.tbPlatformSize.Name = "tbPlatformSize";
			this.tbPlatformSize.Size = new System.Drawing.Size(310, 45);
			this.tbPlatformSize.SmallChange = 2;
			this.tbPlatformSize.TabIndex = 4;
			this.tbPlatformSize.TabStop = false;
			this.tbPlatformSize.TickFrequency = 2;
			this.tbPlatformSize.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tbPlatformSize.Value = 50;
			// 
			// lblPlatformSize
			// 
			this.lblPlatformSize.AutoSize = true;
			this.lblPlatformSize.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 16F);
			this.lblPlatformSize.Location = new System.Drawing.Point(3, 180);
			this.lblPlatformSize.Name = "lblPlatformSize";
			this.lblPlatformSize.Size = new System.Drawing.Size(186, 22);
			this.lblPlatformSize.TabIndex = 4;
			this.lblPlatformSize.Text = "Размер платформ:";
			// 
			// lblBallSpeed
			// 
			this.lblBallSpeed.AutoSize = true;
			this.lblBallSpeed.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 16F);
			this.lblBallSpeed.Location = new System.Drawing.Point(3, 280);
			this.lblBallSpeed.Name = "lblBallSpeed";
			this.lblBallSpeed.Size = new System.Drawing.Size(164, 22);
			this.lblBallSpeed.TabIndex = 3;
			this.lblBallSpeed.Text = "Скорость мяча:";
			// 
			// tbBallSpeed
			// 
			this.tbBallSpeed.LargeChange = 1;
			this.tbBallSpeed.Location = new System.Drawing.Point(3, 310);
			this.tbBallSpeed.Minimum = 1;
			this.tbBallSpeed.Name = "tbBallSpeed";
			this.tbBallSpeed.Size = new System.Drawing.Size(310, 45);
			this.tbBallSpeed.TabIndex = 9;
			this.tbBallSpeed.TabStop = false;
			this.tbBallSpeed.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tbBallSpeed.Value = 3;
			// 
			// lblBallSize
			// 
			this.lblBallSize.AutoSize = true;
			this.lblBallSize.Font = new System.Drawing.Font("Fifaks 1.0 dev1", 16F);
			this.lblBallSize.Location = new System.Drawing.Point(3, 80);
			this.lblBallSize.Name = "lblBallSize";
			this.lblBallSize.Size = new System.Drawing.Size(142, 22);
			this.lblBallSize.TabIndex = 1;
			this.lblBallSize.Text = "Размер мяча:";
			// 
			// tbBallSize
			// 
			this.tbBallSize.LargeChange = 1;
			this.tbBallSize.Location = new System.Drawing.Point(3, 110);
			this.tbBallSize.Maximum = 30;
			this.tbBallSize.Minimum = 10;
			this.tbBallSize.Name = "tbBallSize";
			this.tbBallSize.Size = new System.Drawing.Size(310, 45);
			this.tbBallSize.TabIndex = 3;
			this.tbBallSize.TabStop = false;
			this.tbBallSize.TickStyle = System.Windows.Forms.TickStyle.Both;
			this.tbBallSize.Value = 10;
			// 
			// tsmHelp
			// 
			this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmGameInfo});
			this.tsmHelp.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.tsmHelp.Name = "tsmHelp";
			this.tsmHelp.Size = new System.Drawing.Size(74, 23);
			this.tsmHelp.Text = "Справка";
			// 
			// tsmGameInfo
			// 
			this.tsmGameInfo.Name = "tsmGameInfo";
			this.tsmGameInfo.Size = new System.Drawing.Size(180, 24);
			this.tsmGameInfo.Text = "Об игре";
			this.tsmGameInfo.Click += new System.EventHandler(this.tsmGameInfo_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(964, 601);
			this.Controls.Add(this.splitContainer);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laba06_Isaev.N.S_211-327";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbPlatformSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBallSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tbBallSize)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmGame;
        private System.Windows.Forms.ToolStripMenuItem tsmNewGame;
        private System.Windows.Forms.ToolStripMenuItem tsmEndGame;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TrackBar tbPlatformSize;
        private System.Windows.Forms.Label lblPlatformSize;
        private System.Windows.Forms.Label lblBallSpeed;
        private System.Windows.Forms.TrackBar tbBallSpeed;
        private System.Windows.Forms.Label lblBallSize;
        private System.Windows.Forms.TrackBar tbBallSize;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmGameInfo;
    }
}

