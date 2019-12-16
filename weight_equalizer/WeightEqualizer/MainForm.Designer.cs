namespace WeightEqualizer
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.weightChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.emptyChartLbl = new MetroFramework.Controls.MetroLabel();
            this.enterCurrWeightLbl = new MetroFramework.Controls.MetroLabel();
            this.currWeightTb = new MetroFramework.Controls.MetroTextBox();
            this.separator2 = new System.Windows.Forms.Label();
            this.yoTb = new MetroFramework.Controls.MetroTextBox();
            this.subWeightTb = new MetroFramework.Controls.MetroTextBox();
            this.enterCurrWeightTb = new MetroFramework.Controls.MetroTextBox();
            this.nameTb = new MetroFramework.Controls.MetroTextBox();
            this.exitBtn = new System.Windows.Forms.PictureBox();
            this.minBtn = new System.Windows.Forms.PictureBox();
            this.userBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // weightChart
            // 
            this.weightChart.BackColor = System.Drawing.Color.Transparent;
            this.weightChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea5.AxisX.LabelAutoFitMaxFontSize = 12;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisX.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea5.AxisX.MajorGrid.LineWidth = 2;
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MajorTickMark.LineWidth = 2;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorGrid.LineWidth = 2;
            chartArea5.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisX.MinorTickMark.LineWidth = 2;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea5.AxisX2.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.InterlacedColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.IsStartedFromZero = false;
            chartArea5.AxisY.LabelAutoFitMaxFontSize = 12;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea5.AxisY.LineColor = System.Drawing.Color.Transparent;
            chartArea5.AxisY.LineWidth = 2;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorGrid.LineWidth = 2;
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MajorTickMark.LineWidth = 2;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MinorGrid.LineWidth = 2;
            chartArea5.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea5.AxisY.MinorTickMark.LineWidth = 2;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            chartArea5.AxisY2.LineColor = System.Drawing.Color.Transparent;
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.Transparent;
            chartArea5.Name = "ChartArea1";
            this.weightChart.ChartAreas.Add(chartArea5);
            this.weightChart.Location = new System.Drawing.Point(-20, 60);
            this.weightChart.Name = "weightChart";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series5.IsValueShownAsLabel = true;
            series5.IsVisibleInLegend = false;
            series5.IsXValueIndexed = true;
            series5.LabelBackColor = System.Drawing.Color.White;
            series5.LabelBorderColor = System.Drawing.Color.Transparent;
            series5.MarkerBorderColor = System.Drawing.Color.White;
            series5.MarkerColor = System.Drawing.Color.White;
            series5.MarkerSize = 10;
            series5.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series5.Name = "Series1";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series5.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.weightChart.Series.Add(series5);
            this.weightChart.Size = new System.Drawing.Size(723, 441);
            this.weightChart.TabIndex = 9;
            this.weightChart.Text = "weightChart";
            // 
            // emptyChartLbl
            // 
            this.emptyChartLbl.AutoSize = true;
            this.emptyChartLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.emptyChartLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.emptyChartLbl.ForeColor = System.Drawing.Color.White;
            this.emptyChartLbl.Location = new System.Drawing.Point(274, 274);
            this.emptyChartLbl.Name = "emptyChartLbl";
            this.emptyChartLbl.Size = new System.Drawing.Size(151, 25);
            this.emptyChartLbl.TabIndex = 25;
            this.emptyChartLbl.Text = "Enter your weight";
            this.emptyChartLbl.UseCustomBackColor = true;
            this.emptyChartLbl.UseCustomForeColor = true;
            // 
            // enterCurrWeightLbl
            // 
            this.enterCurrWeightLbl.AutoSize = true;
            this.enterCurrWeightLbl.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.enterCurrWeightLbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.enterCurrWeightLbl.ForeColor = System.Drawing.Color.White;
            this.enterCurrWeightLbl.Location = new System.Drawing.Point(16, 524);
            this.enterCurrWeightLbl.Name = "enterCurrWeightLbl";
            this.enterCurrWeightLbl.Size = new System.Drawing.Size(215, 25);
            this.enterCurrWeightLbl.TabIndex = 26;
            this.enterCurrWeightLbl.Text = "Enter your current weight:";
            this.enterCurrWeightLbl.UseCustomBackColor = true;
            this.enterCurrWeightLbl.UseCustomForeColor = true;
            // 
            // currWeightTb
            // 
            // 
            // 
            // 
            this.currWeightTb.CustomButton.Image = null;
            this.currWeightTb.CustomButton.Location = new System.Drawing.Point(51, 1);
            this.currWeightTb.CustomButton.Name = "";
            this.currWeightTb.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.currWeightTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.currWeightTb.CustomButton.TabIndex = 1;
            this.currWeightTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.currWeightTb.CustomButton.UseSelectable = true;
            this.currWeightTb.ForeColor = System.Drawing.Color.White;
            this.currWeightTb.Lines = new string[0];
            this.currWeightTb.Location = new System.Drawing.Point(237, 527);
            this.currWeightTb.MaxLength = 32767;
            this.currWeightTb.Name = "currWeightTb";
            this.currWeightTb.PasswordChar = '\0';
            this.currWeightTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.currWeightTb.SelectedText = "";
            this.currWeightTb.SelectionLength = 0;
            this.currWeightTb.SelectionStart = 0;
            this.currWeightTb.ShortcutsEnabled = true;
            this.currWeightTb.ShowButton = true;
            this.currWeightTb.Size = new System.Drawing.Size(73, 23);
            this.currWeightTb.Style = MetroFramework.MetroColorStyle.Red;
            this.currWeightTb.TabIndex = 27;
            this.currWeightTb.UseCustomBackColor = true;
            this.currWeightTb.UseCustomForeColor = true;
            this.currWeightTb.UseSelectable = true;
            this.currWeightTb.UseStyleColors = true;
            this.currWeightTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.currWeightTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.currWeightTb.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.currWeightTb_ButtonClick);
            this.currWeightTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.currWeightTb_KeyDown);
            // 
            // separator2
            // 
            this.separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator2.Location = new System.Drawing.Point(-2, 504);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(705, 2);
            this.separator2.TabIndex = 29;
            // 
            // yoTb
            // 
            // 
            // 
            // 
            this.yoTb.CustomButton.Image = null;
            this.yoTb.CustomButton.Location = new System.Drawing.Point(28, 2);
            this.yoTb.CustomButton.Name = "";
            this.yoTb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.yoTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.yoTb.CustomButton.TabIndex = 1;
            this.yoTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.yoTb.CustomButton.UseSelectable = true;
            this.yoTb.CustomButton.Visible = false;
            this.yoTb.DisplayIcon = true;
            this.yoTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.yoTb.ForeColor = System.Drawing.Color.White;
            this.yoTb.Lines = new string[0];
            this.yoTb.Location = new System.Drawing.Point(212, 24);
            this.yoTb.MaxLength = 32767;
            this.yoTb.Name = "yoTb";
            this.yoTb.PasswordChar = '\0';
            this.yoTb.PromptText = "y.o";
            this.yoTb.ReadOnly = true;
            this.yoTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.yoTb.SelectedText = "";
            this.yoTb.SelectionLength = 0;
            this.yoTb.SelectionStart = 0;
            this.yoTb.ShortcutsEnabled = true;
            this.yoTb.Size = new System.Drawing.Size(56, 30);
            this.yoTb.Style = MetroFramework.MetroColorStyle.Red;
            this.yoTb.TabIndex = 30;
            this.yoTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.yoTb.UseCustomBackColor = true;
            this.yoTb.UseCustomForeColor = true;
            this.yoTb.UseSelectable = true;
            this.yoTb.WaterMark = "y.o";
            this.yoTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.yoTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // subWeightTb
            // 
            // 
            // 
            // 
            this.subWeightTb.CustomButton.Image = null;
            this.subWeightTb.CustomButton.Location = new System.Drawing.Point(28, 2);
            this.subWeightTb.CustomButton.Name = "";
            this.subWeightTb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.subWeightTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subWeightTb.CustomButton.TabIndex = 1;
            this.subWeightTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subWeightTb.CustomButton.UseSelectable = true;
            this.subWeightTb.CustomButton.Visible = false;
            this.subWeightTb.DisplayIcon = true;
            this.subWeightTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.subWeightTb.ForeColor = System.Drawing.Color.White;
            this.subWeightTb.Lines = new string[0];
            this.subWeightTb.Location = new System.Drawing.Point(336, 24);
            this.subWeightTb.MaxLength = 32767;
            this.subWeightTb.Name = "subWeightTb";
            this.subWeightTb.PasswordChar = '\0';
            this.subWeightTb.PromptText = "G/L";
            this.subWeightTb.ReadOnly = true;
            this.subWeightTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subWeightTb.SelectedText = "";
            this.subWeightTb.SelectionLength = 0;
            this.subWeightTb.SelectionStart = 0;
            this.subWeightTb.ShortcutsEnabled = true;
            this.subWeightTb.Size = new System.Drawing.Size(56, 30);
            this.subWeightTb.Style = MetroFramework.MetroColorStyle.Red;
            this.subWeightTb.TabIndex = 31;
            this.subWeightTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.subWeightTb.UseCustomBackColor = true;
            this.subWeightTb.UseCustomForeColor = true;
            this.subWeightTb.UseSelectable = true;
            this.subWeightTb.WaterMark = "G/L";
            this.subWeightTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subWeightTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // enterCurrWeightTb
            // 
            // 
            // 
            // 
            this.enterCurrWeightTb.CustomButton.Image = null;
            this.enterCurrWeightTb.CustomButton.Location = new System.Drawing.Point(28, 2);
            this.enterCurrWeightTb.CustomButton.Name = "";
            this.enterCurrWeightTb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.enterCurrWeightTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.enterCurrWeightTb.CustomButton.TabIndex = 1;
            this.enterCurrWeightTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.enterCurrWeightTb.CustomButton.UseSelectable = true;
            this.enterCurrWeightTb.CustomButton.Visible = false;
            this.enterCurrWeightTb.DisplayIcon = true;
            this.enterCurrWeightTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.enterCurrWeightTb.ForeColor = System.Drawing.Color.White;
            this.enterCurrWeightTb.Lines = new string[0];
            this.enterCurrWeightTb.Location = new System.Drawing.Point(274, 24);
            this.enterCurrWeightTb.MaxLength = 32767;
            this.enterCurrWeightTb.Name = "enterCurrWeightTb";
            this.enterCurrWeightTb.PasswordChar = '\0';
            this.enterCurrWeightTb.PromptText = "Wt";
            this.enterCurrWeightTb.ReadOnly = true;
            this.enterCurrWeightTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.enterCurrWeightTb.SelectedText = "";
            this.enterCurrWeightTb.SelectionLength = 0;
            this.enterCurrWeightTb.SelectionStart = 0;
            this.enterCurrWeightTb.ShortcutsEnabled = true;
            this.enterCurrWeightTb.Size = new System.Drawing.Size(56, 30);
            this.enterCurrWeightTb.Style = MetroFramework.MetroColorStyle.Red;
            this.enterCurrWeightTb.TabIndex = 32;
            this.enterCurrWeightTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enterCurrWeightTb.UseCustomBackColor = true;
            this.enterCurrWeightTb.UseCustomForeColor = true;
            this.enterCurrWeightTb.UseSelectable = true;
            this.enterCurrWeightTb.WaterMark = "Wt";
            this.enterCurrWeightTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.enterCurrWeightTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.nameTb.CustomButton.Image = null;
            this.nameTb.CustomButton.Location = new System.Drawing.Point(152, 2);
            this.nameTb.CustomButton.Name = "";
            this.nameTb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.nameTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTb.CustomButton.TabIndex = 1;
            this.nameTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTb.CustomButton.UseSelectable = true;
            this.nameTb.CustomButton.Visible = false;
            this.nameTb.DisplayIcon = true;
            this.nameTb.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.nameTb.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.nameTb.ForeColor = System.Drawing.Color.Black;
            this.nameTb.Icon = global::WeightEqualizer.Properties.Resources.male;
            this.nameTb.IconRight = true;
            this.nameTb.Lines = new string[] {
        "dasdsa"};
            this.nameTb.Location = new System.Drawing.Point(16, 24);
            this.nameTb.MaxLength = 32767;
            this.nameTb.Name = "nameTb";
            this.nameTb.PasswordChar = '\0';
            this.nameTb.PromptText = "Wt";
            this.nameTb.ReadOnly = true;
            this.nameTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTb.SelectedText = "";
            this.nameTb.SelectionLength = 0;
            this.nameTb.SelectionStart = 0;
            this.nameTb.ShortcutsEnabled = true;
            this.nameTb.Size = new System.Drawing.Size(180, 30);
            this.nameTb.Style = MetroFramework.MetroColorStyle.Red;
            this.nameTb.TabIndex = 33;
            this.nameTb.Text = "dasdsa";
            this.nameTb.UseCustomBackColor = true;
            this.nameTb.UseCustomForeColor = true;
            this.nameTb.UseSelectable = true;
            this.nameTb.WaterMark = "Wt";
            this.nameTb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // exitBtn
            // 
            this.exitBtn.Image = global::WeightEqualizer.Properties.Resources.cancel;
            this.exitBtn.Location = new System.Drawing.Point(652, 22);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 32);
            this.exitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.exitBtn.TabIndex = 19;
            this.exitBtn.TabStop = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minBtn
            // 
            this.minBtn.Image = global::WeightEqualizer.Properties.Resources.diminish;
            this.minBtn.Location = new System.Drawing.Point(614, 22);
            this.minBtn.Name = "minBtn";
            this.minBtn.Size = new System.Drawing.Size(32, 32);
            this.minBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.minBtn.TabIndex = 18;
            this.minBtn.TabStop = false;
            this.minBtn.Click += new System.EventHandler(this.minBtn_Click);
            // 
            // userBtn
            // 
            this.userBtn.Image = global::WeightEqualizer.Properties.Resources.avatar_inside_a_circle;
            this.userBtn.Location = new System.Drawing.Point(576, 22);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(32, 32);
            this.userBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.userBtn.TabIndex = 17;
            this.userBtn.TabStop = false;
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(700, 572);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.enterCurrWeightTb);
            this.Controls.Add(this.subWeightTb);
            this.Controls.Add(this.yoTb);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.currWeightTb);
            this.Controls.Add(this.enterCurrWeightLbl);
            this.Controls.Add(this.emptyChartLbl);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.minBtn);
            this.Controls.Add(this.userBtn);
            this.Controls.Add(this.weightChart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.weightChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart weightChart;
        private System.Windows.Forms.PictureBox userBtn;
        private System.Windows.Forms.PictureBox minBtn;
        private System.Windows.Forms.PictureBox exitBtn;
        private MetroFramework.Controls.MetroLabel emptyChartLbl;
        private MetroFramework.Controls.MetroLabel enterCurrWeightLbl;
        private MetroFramework.Controls.MetroTextBox currWeightTb;
        private System.Windows.Forms.Label separator2;
        private MetroFramework.Controls.MetroTextBox yoTb;
        private MetroFramework.Controls.MetroTextBox subWeightTb;
        private MetroFramework.Controls.MetroTextBox enterCurrWeightTb;
        private MetroFramework.Controls.MetroTextBox nameTb;
    }
}

