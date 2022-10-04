namespace GUI.Screens
{
    partial class StatisticScreen
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartTurnover = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ChartBooking = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NumboxMonth = new System.Windows.Forms.NumericUpDown();
            this.BtnMonthAgo = new ReaLTaiizor.Controls.MaterialButton();
            this.BtnInMonth = new ReaLTaiizor.Controls.MaterialButton();
            this.BtnNextMonth = new ReaLTaiizor.Controls.MaterialButton();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurnover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBooking)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumboxMonth)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChartTurnover
            // 
            this.ChartTurnover.BackColor = System.Drawing.Color.OldLace;
            this.ChartTurnover.BorderlineColor = System.Drawing.Color.Black;
            this.ChartTurnover.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.ChartTurnover.ChartAreas.Add(chartArea1);
            this.ChartTurnover.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ChartTurnover.Legends.Add(legend1);
            this.ChartTurnover.Location = new System.Drawing.Point(0, 0);
            this.ChartTurnover.Name = "ChartTurnover";
            this.ChartTurnover.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BorderColor = System.Drawing.Color.Fuchsia;
            series1.BorderWidth = 8;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "a";
            series1.YValuesPerPoint = 10;
            this.ChartTurnover.Series.Add(series1);
            this.ChartTurnover.Size = new System.Drawing.Size(1101, 448);
            this.ChartTurnover.TabIndex = 7;
            this.ChartTurnover.Text = "chart1";
            this.ChartTurnover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartTurnover_MouseMove);
            // 
            // ChartBooking
            // 
            this.ChartBooking.BackColor = System.Drawing.Color.OldLace;
            chartArea2.Name = "ChartArea1";
            this.ChartBooking.ChartAreas.Add(chartArea2);
            this.ChartBooking.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ChartBooking.Legends.Add(legend2);
            this.ChartBooking.Location = new System.Drawing.Point(0, 20);
            this.ChartBooking.Name = "ChartBooking";
            series2.BorderWidth = 8;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "All";
            series3.BorderWidth = 8;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Canceled";
            this.ChartBooking.Series.Add(series2);
            this.ChartBooking.Series.Add(series3);
            this.ChartBooking.Size = new System.Drawing.Size(1287, 394);
            this.ChartBooking.TabIndex = 8;
            this.ChartBooking.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChartTurnover);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 448);
            this.panel1.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.NumboxMonth);
            this.panel3.Controls.Add(this.BtnMonthAgo);
            this.panel3.Controls.Add(this.BtnInMonth);
            this.panel3.Controls.Add(this.BtnNextMonth);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1101, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(186, 448);
            this.panel3.TabIndex = 12;
            // 
            // NumboxMonth
            // 
            this.NumboxMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumboxMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumboxMonth.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumboxMonth.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NumboxMonth.Location = new System.Drawing.Point(4, 37);
            this.NumboxMonth.Name = "NumboxMonth";
            this.NumboxMonth.Size = new System.Drawing.Size(178, 35);
            this.NumboxMonth.TabIndex = 16;
            this.NumboxMonth.ValueChanged += new System.EventHandler(this.NumboxMonth_ValueChanged);
            // 
            // BtnMonthAgo
            // 
            this.BtnMonthAgo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMonthAgo.AutoSize = false;
            this.BtnMonthAgo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnMonthAgo.BackColor = System.Drawing.Color.DeepPink;
            this.BtnMonthAgo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnMonthAgo.Depth = 0;
            this.BtnMonthAgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMonthAgo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonthAgo.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.BtnMonthAgo.HighEmphasis = true;
            this.BtnMonthAgo.Icon = null;
            this.BtnMonthAgo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnMonthAgo.Location = new System.Drawing.Point(4, 109);
            this.BtnMonthAgo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnMonthAgo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnMonthAgo.Name = "BtnMonthAgo";
            this.BtnMonthAgo.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnMonthAgo.Size = new System.Drawing.Size(178, 50);
            this.BtnMonthAgo.TabIndex = 11;
            this.BtnMonthAgo.Text = "6 tháng trước";
            this.BtnMonthAgo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnMonthAgo.UseAccentColor = false;
            this.BtnMonthAgo.UseVisualStyleBackColor = false;
            this.BtnMonthAgo.Click += new System.EventHandler(this.BtnMonthAgo_Click);
            // 
            // BtnInMonth
            // 
            this.BtnInMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnInMonth.AutoSize = false;
            this.BtnInMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnInMonth.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnInMonth.Depth = 0;
            this.BtnInMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInMonth.HighEmphasis = true;
            this.BtnInMonth.Icon = null;
            this.BtnInMonth.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnInMonth.Location = new System.Drawing.Point(4, 222);
            this.BtnInMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnInMonth.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnInMonth.Name = "BtnInMonth";
            this.BtnInMonth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnInMonth.Size = new System.Drawing.Size(178, 52);
            this.BtnInMonth.TabIndex = 9;
            this.BtnInMonth.Text = "Trong 6 tháng";
            this.BtnInMonth.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnInMonth.UseAccentColor = false;
            this.BtnInMonth.UseVisualStyleBackColor = true;
            this.BtnInMonth.Click += new System.EventHandler(this.BtnInMonth_Click);
            // 
            // BtnNextMonth
            // 
            this.BtnNextMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNextMonth.AutoSize = false;
            this.BtnNextMonth.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BtnNextMonth.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BtnNextMonth.Depth = 0;
            this.BtnNextMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNextMonth.HighEmphasis = true;
            this.BtnNextMonth.Icon = null;
            this.BtnNextMonth.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            this.BtnNextMonth.Location = new System.Drawing.Point(4, 296);
            this.BtnNextMonth.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BtnNextMonth.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.BtnNextMonth.Name = "BtnNextMonth";
            this.BtnNextMonth.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BtnNextMonth.Size = new System.Drawing.Size(178, 51);
            this.BtnNextMonth.TabIndex = 10;
            this.BtnNextMonth.Text = "3 tháng tới";
            this.BtnNextMonth.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.BtnNextMonth.UseAccentColor = false;
            this.BtnNextMonth.UseVisualStyleBackColor = true;
            this.BtnNextMonth.Click += new System.EventHandler(this.BtnNextMonth_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ChartBooking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 458);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.panel2.Size = new System.Drawing.Size(1287, 414);
            this.panel2.TabIndex = 10;
            // 
            // StatisticScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1328, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StatisticScreen";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "TurnoverForm";
            this.Load += new System.EventHandler(this.StatisticScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ChartTurnover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChartBooking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumboxMonth)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartTurnover;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartBooking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.MaterialButton BtnMonthAgo;
        private ReaLTaiizor.Controls.MaterialButton BtnNextMonth;
        private ReaLTaiizor.Controls.MaterialButton BtnInMonth;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.NumericUpDown NumboxMonth;
    }
}