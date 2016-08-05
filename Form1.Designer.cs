namespace ComputerMetricsWinForms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonComputerSummary = new System.Windows.Forms.Button();
            this.labelComputerName = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelCpu = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxCpu = new System.Windows.Forms.TextBox();
            this.labelRam = new System.Windows.Forms.Label();
            this.labelVideoCard = new System.Windows.Forms.Label();
            this.labelIpAddress = new System.Windows.Forms.Label();
            this.labelCpuUsage = new System.Windows.Forms.Label();
            this.labelRamUsage = new System.Windows.Forms.Label();
            this.labelAvailableDiskSpace = new System.Windows.Forms.Label();
            this.labelAverageDiskQueueLength = new System.Windows.Forms.Label();
            this.textBoxRam = new System.Windows.Forms.TextBox();
            this.textBoxVideoCard = new System.Windows.Forms.TextBox();
            this.textBoxIpAddress = new System.Windows.Forms.TextBox();
            this.textBoxCpuUsage = new System.Windows.Forms.TextBox();
            this.textBoxRamUsage = new System.Windows.Forms.TextBox();
            this.textBoxAvailableDiskSpace = new System.Windows.Forms.TextBox();
            this.textBoxAverageDiskQueueLength = new System.Windows.Forms.TextBox();
            this.chartUsage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timerChartUsage = new System.Windows.Forms.Timer(this.components);
            this.chartAverageDiskQueueLength = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageDiskQueueLength)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComputerSummary
            // 
            this.buttonComputerSummary.Location = new System.Drawing.Point(12, 12);
            this.buttonComputerSummary.Name = "buttonComputerSummary";
            this.buttonComputerSummary.Size = new System.Drawing.Size(108, 23);
            this.buttonComputerSummary.TabIndex = 0;
            this.buttonComputerSummary.Text = "Computer Summary";
            this.buttonComputerSummary.UseVisualStyleBackColor = true;
            this.buttonComputerSummary.Click += new System.EventHandler(this.buttonComputerSummary_Click);
            // 
            // labelComputerName
            // 
            this.labelComputerName.AutoSize = true;
            this.labelComputerName.Location = new System.Drawing.Point(12, 49);
            this.labelComputerName.Name = "labelComputerName";
            this.labelComputerName.Size = new System.Drawing.Size(35, 13);
            this.labelComputerName.TabIndex = 1;
            this.labelComputerName.Text = "Name";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(12, 74);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "User";
            // 
            // labelCpu
            // 
            this.labelCpu.AutoSize = true;
            this.labelCpu.Location = new System.Drawing.Point(12, 99);
            this.labelCpu.Name = "labelCpu";
            this.labelCpu.Size = new System.Drawing.Size(26, 13);
            this.labelCpu.TabIndex = 3;
            this.labelCpu.Text = "Cpu";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(173, 46);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(248, 20);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(173, 71);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(248, 20);
            this.textBoxUser.TabIndex = 5;
            // 
            // textBoxCpu
            // 
            this.textBoxCpu.Location = new System.Drawing.Point(173, 96);
            this.textBoxCpu.Name = "textBoxCpu";
            this.textBoxCpu.Size = new System.Drawing.Size(248, 20);
            this.textBoxCpu.TabIndex = 6;
            // 
            // labelRam
            // 
            this.labelRam.AutoSize = true;
            this.labelRam.Location = new System.Drawing.Point(12, 124);
            this.labelRam.Name = "labelRam";
            this.labelRam.Size = new System.Drawing.Size(53, 13);
            this.labelRam.TabIndex = 7;
            this.labelRam.Text = "Ram (Mb)";
            // 
            // labelVideoCard
            // 
            this.labelVideoCard.AutoSize = true;
            this.labelVideoCard.Location = new System.Drawing.Point(12, 149);
            this.labelVideoCard.Name = "labelVideoCard";
            this.labelVideoCard.Size = new System.Drawing.Size(59, 13);
            this.labelVideoCard.TabIndex = 8;
            this.labelVideoCard.Text = "Video Card";
            // 
            // labelIpAddress
            // 
            this.labelIpAddress.AutoSize = true;
            this.labelIpAddress.Location = new System.Drawing.Point(12, 174);
            this.labelIpAddress.Name = "labelIpAddress";
            this.labelIpAddress.Size = new System.Drawing.Size(57, 13);
            this.labelIpAddress.TabIndex = 9;
            this.labelIpAddress.Text = "Ip Address";
            // 
            // labelCpuUsage
            // 
            this.labelCpuUsage.AutoSize = true;
            this.labelCpuUsage.Location = new System.Drawing.Point(12, 199);
            this.labelCpuUsage.Name = "labelCpuUsage";
            this.labelCpuUsage.Size = new System.Drawing.Size(60, 13);
            this.labelCpuUsage.TabIndex = 10;
            this.labelCpuUsage.Text = "Cpu Usage";
            // 
            // labelRamUsage
            // 
            this.labelRamUsage.AutoSize = true;
            this.labelRamUsage.Location = new System.Drawing.Point(12, 224);
            this.labelRamUsage.Name = "labelRamUsage";
            this.labelRamUsage.Size = new System.Drawing.Size(63, 13);
            this.labelRamUsage.TabIndex = 11;
            this.labelRamUsage.Text = "Ram Usage";
            // 
            // labelAvailableDiskSpace
            // 
            this.labelAvailableDiskSpace.AutoSize = true;
            this.labelAvailableDiskSpace.Location = new System.Drawing.Point(12, 249);
            this.labelAvailableDiskSpace.Name = "labelAvailableDiskSpace";
            this.labelAvailableDiskSpace.Size = new System.Drawing.Size(131, 13);
            this.labelAvailableDiskSpace.TabIndex = 12;
            this.labelAvailableDiskSpace.Text = "Available Disk Space (Gb)";
            // 
            // labelAverageDiskQueueLength
            // 
            this.labelAverageDiskQueueLength.AutoSize = true;
            this.labelAverageDiskQueueLength.Location = new System.Drawing.Point(12, 274);
            this.labelAverageDiskQueueLength.Name = "labelAverageDiskQueueLength";
            this.labelAverageDiskQueueLength.Size = new System.Drawing.Size(134, 13);
            this.labelAverageDiskQueueLength.TabIndex = 13;
            this.labelAverageDiskQueueLength.Text = "Average disk queue length";
            // 
            // textBoxRam
            // 
            this.textBoxRam.Location = new System.Drawing.Point(173, 121);
            this.textBoxRam.Name = "textBoxRam";
            this.textBoxRam.Size = new System.Drawing.Size(248, 20);
            this.textBoxRam.TabIndex = 14;
            // 
            // textBoxVideoCard
            // 
            this.textBoxVideoCard.Location = new System.Drawing.Point(173, 146);
            this.textBoxVideoCard.Name = "textBoxVideoCard";
            this.textBoxVideoCard.Size = new System.Drawing.Size(248, 20);
            this.textBoxVideoCard.TabIndex = 15;
            // 
            // textBoxIpAddress
            // 
            this.textBoxIpAddress.Location = new System.Drawing.Point(173, 171);
            this.textBoxIpAddress.Name = "textBoxIpAddress";
            this.textBoxIpAddress.Size = new System.Drawing.Size(248, 20);
            this.textBoxIpAddress.TabIndex = 16;
            // 
            // textBoxCpuUsage
            // 
            this.textBoxCpuUsage.Location = new System.Drawing.Point(173, 196);
            this.textBoxCpuUsage.Name = "textBoxCpuUsage";
            this.textBoxCpuUsage.Size = new System.Drawing.Size(248, 20);
            this.textBoxCpuUsage.TabIndex = 17;
            // 
            // textBoxRamUsage
            // 
            this.textBoxRamUsage.Location = new System.Drawing.Point(173, 221);
            this.textBoxRamUsage.Name = "textBoxRamUsage";
            this.textBoxRamUsage.Size = new System.Drawing.Size(248, 20);
            this.textBoxRamUsage.TabIndex = 18;
            // 
            // textBoxAvailableDiskSpace
            // 
            this.textBoxAvailableDiskSpace.Location = new System.Drawing.Point(173, 246);
            this.textBoxAvailableDiskSpace.Name = "textBoxAvailableDiskSpace";
            this.textBoxAvailableDiskSpace.Size = new System.Drawing.Size(248, 20);
            this.textBoxAvailableDiskSpace.TabIndex = 19;
            // 
            // textBoxAverageDiskQueueLength
            // 
            this.textBoxAverageDiskQueueLength.Location = new System.Drawing.Point(173, 271);
            this.textBoxAverageDiskQueueLength.Name = "textBoxAverageDiskQueueLength";
            this.textBoxAverageDiskQueueLength.Size = new System.Drawing.Size(248, 20);
            this.textBoxAverageDiskQueueLength.TabIndex = 20;
            // 
            // chartUsage
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUsage.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUsage.Legends.Add(legend1);
            this.chartUsage.Location = new System.Drawing.Point(468, 12);
            this.chartUsage.Name = "chartUsage";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartUsage.Series.Add(series1);
            this.chartUsage.Size = new System.Drawing.Size(300, 280);
            this.chartUsage.TabIndex = 21;
            this.chartUsage.Text = "chart1";
            // 
            // timerChartUsage
            // 
            this.timerChartUsage.Interval = 5000;
            this.timerChartUsage.Tick += new System.EventHandler(this.timerChartUsage_Tick);
            // 
            // chartAverageDiskQueueLength
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAverageDiskQueueLength.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAverageDiskQueueLength.Legends.Add(legend2);
            this.chartAverageDiskQueueLength.Location = new System.Drawing.Point(774, 12);
            this.chartAverageDiskQueueLength.Name = "chartAverageDiskQueueLength";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAverageDiskQueueLength.Series.Add(series2);
            this.chartAverageDiskQueueLength.Size = new System.Drawing.Size(300, 280);
            this.chartAverageDiskQueueLength.TabIndex = 22;
            this.chartAverageDiskQueueLength.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 304);
            this.Controls.Add(this.chartAverageDiskQueueLength);
            this.Controls.Add(this.chartUsage);
            this.Controls.Add(this.textBoxAverageDiskQueueLength);
            this.Controls.Add(this.textBoxAvailableDiskSpace);
            this.Controls.Add(this.textBoxRamUsage);
            this.Controls.Add(this.textBoxCpuUsage);
            this.Controls.Add(this.textBoxIpAddress);
            this.Controls.Add(this.textBoxVideoCard);
            this.Controls.Add(this.textBoxRam);
            this.Controls.Add(this.labelAverageDiskQueueLength);
            this.Controls.Add(this.labelAvailableDiskSpace);
            this.Controls.Add(this.labelRamUsage);
            this.Controls.Add(this.labelCpuUsage);
            this.Controls.Add(this.labelIpAddress);
            this.Controls.Add(this.labelVideoCard);
            this.Controls.Add(this.labelRam);
            this.Controls.Add(this.labelCpu);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelComputerName);
            this.Controls.Add(this.textBoxCpu);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.buttonComputerSummary);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartUsage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAverageDiskQueueLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComputerSummary;
        private System.Windows.Forms.Label labelComputerName;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelCpu;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxCpu;
        private System.Windows.Forms.Label labelRam;
        private System.Windows.Forms.Label labelVideoCard;
        private System.Windows.Forms.Label labelIpAddress;
        private System.Windows.Forms.Label labelCpuUsage;
        private System.Windows.Forms.Label labelRamUsage;
        private System.Windows.Forms.Label labelAvailableDiskSpace;
        private System.Windows.Forms.Label labelAverageDiskQueueLength;
        private System.Windows.Forms.TextBox textBoxRam;
        private System.Windows.Forms.TextBox textBoxVideoCard;
        private System.Windows.Forms.TextBox textBoxIpAddress;
        private System.Windows.Forms.TextBox textBoxCpuUsage;
        private System.Windows.Forms.TextBox textBoxRamUsage;
        private System.Windows.Forms.TextBox textBoxAvailableDiskSpace;
        private System.Windows.Forms.TextBox textBoxAverageDiskQueueLength;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAverageDiskQueueLength;
        public System.Windows.Forms.Timer timerChartUsage;
    }
}

