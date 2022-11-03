namespace ClimateControlSystem
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.lblRoomStatus3 = new System.Windows.Forms.Label();
			this.lblRoomStatus2 = new System.Windows.Forms.Label();
			this.lblRoomStatus1 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.txtCoolingFlow3 = new System.Windows.Forms.TextBox();
			this.txtCoolingFlow2 = new System.Windows.Forms.TextBox();
			this.txtCoolingFlow1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtTemp3 = new System.Windows.Forms.TextBox();
			this.txtTemp2 = new System.Windows.Forms.TextBox();
			this.txtTemp1 = new System.Windows.Forms.TextBox();
			this.txtCoolingTemp3 = new System.Windows.Forms.TextBox();
			this.txtCoolingTemp2 = new System.Windows.Forms.TextBox();
			this.txtCoolingTemp1 = new System.Windows.Forms.TextBox();
			this.txtInletTemp3 = new System.Windows.Forms.TextBox();
			this.txtInletTemp2 = new System.Windows.Forms.TextBox();
			this.txtInletTemp1 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDataOutput = new System.Windows.Forms.Button();
			this.label18 = new System.Windows.Forms.Label();
			this.txtStopDate = new System.Windows.Forms.TextBox();
			this.txtStartDate = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.btnCooling = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.timerRandTemp = new System.Windows.Forms.Timer(this.components);
			this.timerCalcData = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
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
			this.splitContainer1.Panel1.Controls.Add(this.lblRoomStatus3);
			this.splitContainer1.Panel1.Controls.Add(this.lblRoomStatus2);
			this.splitContainer1.Panel1.Controls.Add(this.lblRoomStatus1);
			this.splitContainer1.Panel1.Controls.Add(this.label16);
			this.splitContainer1.Panel1.Controls.Add(this.label15);
			this.splitContainer1.Panel1.Controls.Add(this.label14);
			this.splitContainer1.Panel1.Controls.Add(this.label13);
			this.splitContainer1.Panel1.Controls.Add(this.label12);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingFlow3);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingFlow2);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingFlow1);
			this.splitContainer1.Panel1.Controls.Add(this.label9);
			this.splitContainer1.Panel1.Controls.Add(this.label10);
			this.splitContainer1.Panel1.Controls.Add(this.label11);
			this.splitContainer1.Panel1.Controls.Add(this.label8);
			this.splitContainer1.Panel1.Controls.Add(this.txtTemp3);
			this.splitContainer1.Panel1.Controls.Add(this.txtTemp2);
			this.splitContainer1.Panel1.Controls.Add(this.txtTemp1);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingTemp3);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingTemp2);
			this.splitContainer1.Panel1.Controls.Add(this.txtCoolingTemp1);
			this.splitContainer1.Panel1.Controls.Add(this.txtInletTemp3);
			this.splitContainer1.Panel1.Controls.Add(this.txtInletTemp2);
			this.splitContainer1.Panel1.Controls.Add(this.txtInletTemp1);
			this.splitContainer1.Panel1.Controls.Add(this.label7);
			this.splitContainer1.Panel1.Controls.Add(this.label6);
			this.splitContainer1.Panel1.Controls.Add(this.label5);
			this.splitContainer1.Panel1.Controls.Add(this.label4);
			this.splitContainer1.Panel1.Controls.Add(this.label3);
			this.splitContainer1.Panel1.Controls.Add(this.label2);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.btnDataOutput);
			this.splitContainer1.Panel2.Controls.Add(this.label18);
			this.splitContainer1.Panel2.Controls.Add(this.txtStopDate);
			this.splitContainer1.Panel2.Controls.Add(this.txtStartDate);
			this.splitContainer1.Panel2.Controls.Add(this.label17);
			this.splitContainer1.Panel2.Controls.Add(this.btnCooling);
			this.splitContainer1.Panel2.Controls.Add(this.chart1);
			this.splitContainer1.Size = new System.Drawing.Size(1180, 650);
			this.splitContainer1.SplitterDistance = 600;
			this.splitContainer1.TabIndex = 50;
			// 
			// lblRoomStatus3
			// 
			this.lblRoomStatus3.AutoSize = true;
			this.lblRoomStatus3.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
			this.lblRoomStatus3.Location = new System.Drawing.Point(160, 596);
			this.lblRoomStatus3.Name = "lblRoomStatus3";
			this.lblRoomStatus3.Size = new System.Drawing.Size(73, 20);
			this.lblRoomStatus3.TabIndex = 118;
			this.lblRoomStatus3.Text = "*статус*";
			// 
			// lblRoomStatus2
			// 
			this.lblRoomStatus2.AutoSize = true;
			this.lblRoomStatus2.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
			this.lblRoomStatus2.Location = new System.Drawing.Point(160, 551);
			this.lblRoomStatus2.Name = "lblRoomStatus2";
			this.lblRoomStatus2.Size = new System.Drawing.Size(73, 20);
			this.lblRoomStatus2.TabIndex = 117;
			this.lblRoomStatus2.Text = "*статус*";
			// 
			// lblRoomStatus1
			// 
			this.lblRoomStatus1.AutoSize = true;
			this.lblRoomStatus1.Font = new System.Drawing.Font("Microsoft JhengHei", 12F);
			this.lblRoomStatus1.Location = new System.Drawing.Point(160, 506);
			this.lblRoomStatus1.Name = "lblRoomStatus1";
			this.lblRoomStatus1.Size = new System.Drawing.Size(73, 20);
			this.lblRoomStatus1.TabIndex = 116;
			this.lblRoomStatus1.Text = "*статус*";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(15, 597);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(104, 19);
			this.label16.TabIndex = 115;
			this.label16.Text = "Помещение 3";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(15, 552);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(104, 19);
			this.label15.TabIndex = 114;
			this.label15.Text = "Помещение 2";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(15, 507);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(104, 19);
			this.label14.TabIndex = 113;
			this.label14.Text = "Помещение 1";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(71, 467);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(57, 19);
			this.label13.TabIndex = 112;
			this.label13.Text = "Статус";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(15, 355);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(223, 19);
			this.label12.TabIndex = 11;
			this.label12.Text = "Поток охлаждающего воздуха";
			// 
			// txtCoolingFlow3
			// 
			this.txtCoolingFlow3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingFlow3.Location = new System.Drawing.Point(487, 351);
			this.txtCoolingFlow3.Name = "txtCoolingFlow3";
			this.txtCoolingFlow3.ReadOnly = true;
			this.txtCoolingFlow3.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingFlow3.TabIndex = 2;
			this.txtCoolingFlow3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCoolingFlow2
			// 
			this.txtCoolingFlow2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingFlow2.Location = new System.Drawing.Point(372, 351);
			this.txtCoolingFlow2.Name = "txtCoolingFlow2";
			this.txtCoolingFlow2.ReadOnly = true;
			this.txtCoolingFlow2.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingFlow2.TabIndex = 1;
			this.txtCoolingFlow2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCoolingFlow1
			// 
			this.txtCoolingFlow1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingFlow1.Location = new System.Drawing.Point(262, 351);
			this.txtCoolingFlow1.Name = "txtCoolingFlow1";
			this.txtCoolingFlow1.ReadOnly = true;
			this.txtCoolingFlow1.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingFlow1.TabIndex = 0;
			this.txtCoolingFlow1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(480, 315);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(104, 19);
			this.label9.TabIndex = 10;
			this.label9.Text = "Помещение 3";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(365, 315);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(104, 19);
			this.label10.TabIndex = 9;
			this.label10.Text = "Помещение 2";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.Location = new System.Drawing.Point(255, 315);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(104, 19);
			this.label11.TabIndex = 8;
			this.label11.Text = "Помещение 1";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(26, 315);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(157, 19);
			this.label8.TabIndex = 7;
			this.label8.Text = "Расчитанные данные";
			// 
			// txtTemp3
			// 
			this.txtTemp3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTemp3.Location = new System.Drawing.Point(487, 159);
			this.txtTemp3.Name = "txtTemp3";
			this.txtTemp3.ReadOnly = true;
			this.txtTemp3.Size = new System.Drawing.Size(90, 26);
			this.txtTemp3.TabIndex = 11;
			this.txtTemp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTemp3.TextChanged += new System.EventHandler(this.txtTemp3_TextChanged);
			// 
			// txtTemp2
			// 
			this.txtTemp2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTemp2.Location = new System.Drawing.Point(372, 159);
			this.txtTemp2.Name = "txtTemp2";
			this.txtTemp2.ReadOnly = true;
			this.txtTemp2.Size = new System.Drawing.Size(90, 26);
			this.txtTemp2.TabIndex = 10;
			this.txtTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTemp2.TextChanged += new System.EventHandler(this.txtTemp2_TextChanged);
			// 
			// txtTemp1
			// 
			this.txtTemp1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtTemp1.Location = new System.Drawing.Point(262, 159);
			this.txtTemp1.Name = "txtTemp1";
			this.txtTemp1.ReadOnly = true;
			this.txtTemp1.Size = new System.Drawing.Size(90, 26);
			this.txtTemp1.TabIndex = 9;
			this.txtTemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtTemp1.TextChanged += new System.EventHandler(this.txtTemp1_TextChanged);
			// 
			// txtCoolingTemp3
			// 
			this.txtCoolingTemp3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingTemp3.Location = new System.Drawing.Point(487, 115);
			this.txtCoolingTemp3.Name = "txtCoolingTemp3";
			this.txtCoolingTemp3.ReadOnly = true;
			this.txtCoolingTemp3.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingTemp3.TabIndex = 8;
			this.txtCoolingTemp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCoolingTemp2
			// 
			this.txtCoolingTemp2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingTemp2.Location = new System.Drawing.Point(372, 115);
			this.txtCoolingTemp2.Name = "txtCoolingTemp2";
			this.txtCoolingTemp2.ReadOnly = true;
			this.txtCoolingTemp2.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingTemp2.TabIndex = 7;
			this.txtCoolingTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCoolingTemp1
			// 
			this.txtCoolingTemp1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtCoolingTemp1.Location = new System.Drawing.Point(262, 115);
			this.txtCoolingTemp1.Name = "txtCoolingTemp1";
			this.txtCoolingTemp1.ReadOnly = true;
			this.txtCoolingTemp1.Size = new System.Drawing.Size(90, 26);
			this.txtCoolingTemp1.TabIndex = 6;
			this.txtCoolingTemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtInletTemp3
			// 
			this.txtInletTemp3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtInletTemp3.Location = new System.Drawing.Point(487, 61);
			this.txtInletTemp3.Name = "txtInletTemp3";
			this.txtInletTemp3.ReadOnly = true;
			this.txtInletTemp3.Size = new System.Drawing.Size(90, 26);
			this.txtInletTemp3.TabIndex = 5;
			this.txtInletTemp3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtInletTemp2
			// 
			this.txtInletTemp2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtInletTemp2.Location = new System.Drawing.Point(372, 61);
			this.txtInletTemp2.Name = "txtInletTemp2";
			this.txtInletTemp2.ReadOnly = true;
			this.txtInletTemp2.Size = new System.Drawing.Size(90, 26);
			this.txtInletTemp2.TabIndex = 4;
			this.txtInletTemp2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtInletTemp1
			// 
			this.txtInletTemp1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtInletTemp1.Location = new System.Drawing.Point(262, 61);
			this.txtInletTemp1.Name = "txtInletTemp1";
			this.txtInletTemp1.ReadOnly = true;
			this.txtInletTemp1.Size = new System.Drawing.Size(90, 26);
			this.txtInletTemp1.TabIndex = 3;
			this.txtInletTemp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(480, 15);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 19);
			this.label7.TabIndex = 3;
			this.label7.Text = "Помещение 3";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(365, 15);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(104, 19);
			this.label6.TabIndex = 2;
			this.label6.Text = "Помещение 2";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(255, 15);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(104, 19);
			this.label5.TabIndex = 1;
			this.label5.Text = "Помещение 1";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(15, 163);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(99, 19);
			this.label4.TabIndex = 6;
			this.label4.Text = "Температура";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 109);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 38);
			this.label3.TabIndex = 5;
			this.label3.Text = "Температура охлаждающего\r\nпотока";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 55);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(168, 38);
			this.label2.TabIndex = 4;
			this.label2.Text = "Температура входного\r\nвоздуха";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft JhengHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(65, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 19);
			this.label1.TabIndex = 0;
			this.label1.Text = "Датчики";
			// 
			// btnDataOutput
			// 
			this.btnDataOutput.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDataOutput.Location = new System.Drawing.Point(232, 540);
			this.btnDataOutput.Name = "btnDataOutput";
			this.btnDataOutput.Size = new System.Drawing.Size(110, 35);
			this.btnDataOutput.TabIndex = 3;
			this.btnDataOutput.Text = "Вывести";
			this.btnDataOutput.UseVisualStyleBackColor = true;
			this.btnDataOutput.Click += new System.EventHandler(this.btnDataOutput_Click);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft JhengHei", 11.75F);
			this.label18.Location = new System.Drawing.Point(386, 490);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(27, 20);
			this.label18.TabIndex = 205;
			this.label18.Text = "по";
			// 
			// txtStopDate
			// 
			this.txtStopDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtStopDate.Location = new System.Drawing.Point(416, 487);
			this.txtStopDate.Name = "txtStopDate";
			this.txtStopDate.Size = new System.Drawing.Size(145, 26);
			this.txtStopDate.TabIndex = 2;
			// 
			// txtStartDate
			// 
			this.txtStartDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.txtStartDate.Location = new System.Drawing.Point(238, 487);
			this.txtStartDate.Name = "txtStartDate";
			this.txtStartDate.Size = new System.Drawing.Size(145, 26);
			this.txtStartDate.TabIndex = 1;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft JhengHei", 11.75F);
			this.label17.Location = new System.Drawing.Point(30, 490);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(205, 20);
			this.label17.TabIndex = 202;
			this.label17.Text = "Вывод данных в период с";
			// 
			// btnCooling
			// 
			this.btnCooling.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCooling.Location = new System.Drawing.Point(182, 360);
			this.btnCooling.Name = "btnCooling";
			this.btnCooling.Size = new System.Drawing.Size(210, 55);
			this.btnCooling.TabIndex = 0;
			this.btnCooling.Text = "Включить охлаждение";
			this.btnCooling.UseVisualStyleBackColor = true;
			this.btnCooling.BackColorChanged += new System.EventHandler(this.btnCooling_BackColorChanged);
			this.btnCooling.Click += new System.EventHandler(this.btnCooling_Click);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			this.chart1.Dock = System.Windows.Forms.DockStyle.Top;
			this.chart1.Enabled = false;
			legend1.AutoFitMinFontSize = 5;
			legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
			legend1.Font = new System.Drawing.Font("Microsoft JhengHei", 10F);
			legend1.HeaderSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
			legend1.IsTextAutoFit = false;
			legend1.ItemColumnSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.Line;
			legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
			legend1.Name = "Legend1";
			legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(0, 0);
			this.chart1.Name = "chart1";
			series1.BorderWidth = 4;
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Color = System.Drawing.Color.LimeGreen;
			series1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			series1.Legend = "Legend1";
			series1.LegendText = "Температура";
			series1.Name = "Series1";
			series2.BorderWidth = 3;
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series2.Color = System.Drawing.Color.DeepSkyBlue;
			series2.LabelBorderWidth = 3;
			series2.Legend = "Legend1";
			series2.LegendText = "Поток охлаждающего воздуха";
			series2.Name = "Series2";
			this.chart1.Series.Add(series1);
			this.chart1.Series.Add(series2);
			this.chart1.Size = new System.Drawing.Size(574, 331);
			this.chart1.TabIndex = 200;
			this.chart1.Text = "chart1";
			// 
			// timerRandTemp
			// 
			this.timerRandTemp.Enabled = true;
			this.timerRandTemp.Interval = 1000;
			this.timerRandTemp.Tick += new System.EventHandler(this.timerRandTemp_Tick);
			// 
			// timerCalcData
			// 
			this.timerCalcData.Enabled = true;
			this.timerCalcData.Interval = 2000;
			this.timerCalcData.Tick += new System.EventHandler(this.timerCalcData_Tick);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1180, 650);
			this.Controls.Add(this.splitContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Laba05_Isaev.N.S_211-327";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);

		}

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInletTemp3;
        private System.Windows.Forms.TextBox txtInletTemp2;
        private System.Windows.Forms.TextBox txtInletTemp1;
        private System.Windows.Forms.TextBox txtTemp3;
        private System.Windows.Forms.TextBox txtTemp2;
        private System.Windows.Forms.TextBox txtTemp1;
        private System.Windows.Forms.TextBox txtCoolingTemp3;
        private System.Windows.Forms.TextBox txtCoolingTemp2;
        private System.Windows.Forms.TextBox txtCoolingTemp1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCoolingFlow3;
        private System.Windows.Forms.TextBox txtCoolingFlow2;
        private System.Windows.Forms.TextBox txtCoolingFlow1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblRoomStatus3;
        private System.Windows.Forms.Label lblRoomStatus2;
        private System.Windows.Forms.Label lblRoomStatus1;
        private System.Windows.Forms.Button btnCooling;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtStartDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtStopDate;
        private System.Windows.Forms.Button btnDataOutput;
        private System.Windows.Forms.Timer timerRandTemp;
        private System.Windows.Forms.Timer timerCalcData;
    }
}

