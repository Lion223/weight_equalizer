namespace WeightEqualizer
{
    partial class EnterForm
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
            this.birthDt = new MetroFramework.Controls.MetroDateTime();
            this.genderCb = new MetroFramework.Controls.MetroComboBox();
            this.signupBtn = new System.Windows.Forms.Label();
            this.separator = new System.Windows.Forms.Label();
            this.exitLb = new System.Windows.Forms.Label();
            this.loginTb = new MetroFramework.Controls.MetroTextBox();
            this.signinBtn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // birthDt
            // 
            this.birthDt.CalendarFont = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDt.Location = new System.Drawing.Point(62, 80);
            this.birthDt.MaxDate = new System.DateTime(2018, 1, 10, 0, 0, 0, 0);
            this.birthDt.MinimumSize = new System.Drawing.Size(0, 29);
            this.birthDt.Name = "birthDt";
            this.birthDt.Size = new System.Drawing.Size(161, 29);
            this.birthDt.Style = MetroFramework.MetroColorStyle.Red;
            this.birthDt.TabIndex = 6;
            this.birthDt.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.birthDt.Value = new System.DateTime(2018, 1, 10, 0, 0, 0, 0);
            // 
            // genderCb
            // 
            this.genderCb.FormattingEnabled = true;
            this.genderCb.ItemHeight = 23;
            this.genderCb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.genderCb.Location = new System.Drawing.Point(62, 130);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(161, 29);
            this.genderCb.Style = MetroFramework.MetroColorStyle.Red;
            this.genderCb.TabIndex = 7;
            this.genderCb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.genderCb.UseSelectable = true;
            // 
            // signupBtn
            // 
            this.signupBtn.AutoSize = true;
            this.signupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupBtn.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signupBtn.ForeColor = System.Drawing.Color.White;
            this.signupBtn.Location = new System.Drawing.Point(91, 258);
            this.signupBtn.Name = "signupBtn";
            this.signupBtn.Size = new System.Drawing.Size(51, 16);
            this.signupBtn.TabIndex = 10;
            this.signupBtn.Text = "Sign Up";
            this.signupBtn.Click += new System.EventHandler(this.signupBtn_Click);
            this.signupBtn.MouseEnter += new System.EventHandler(this.signupBtn_MouseEnter);
            this.signupBtn.MouseLeave += new System.EventHandler(this.signupBtn_MouseLeave);
            // 
            // separator
            // 
            this.separator.AutoSize = true;
            this.separator.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.separator.ForeColor = System.Drawing.Color.White;
            this.separator.Location = new System.Drawing.Point(138, 258);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(16, 16);
            this.separator.TabIndex = 11;
            this.separator.Text = "|";
            // 
            // exitLb
            // 
            this.exitLb.AutoSize = true;
            this.exitLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitLb.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitLb.ForeColor = System.Drawing.Color.White;
            this.exitLb.Location = new System.Drawing.Point(150, 258);
            this.exitLb.Name = "exitLb";
            this.exitLb.Size = new System.Drawing.Size(28, 16);
            this.exitLb.TabIndex = 12;
            this.exitLb.Text = "Exit";
            this.exitLb.Click += new System.EventHandler(this.exitLb_Click);
            this.exitLb.MouseEnter += new System.EventHandler(this.exitLb_MouseEnter);
            this.exitLb.MouseLeave += new System.EventHandler(this.exitLb_MouseLeave);
            // 
            // loginTb
            // 
            // 
            // 
            // 
            this.loginTb.CustomButton.Image = null;
            this.loginTb.CustomButton.Location = new System.Drawing.Point(133, 2);
            this.loginTb.CustomButton.Name = "";
            this.loginTb.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.loginTb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginTb.CustomButton.TabIndex = 1;
            this.loginTb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.loginTb.CustomButton.UseSelectable = true;
            this.loginTb.CustomButton.Visible = false;
            this.loginTb.DisplayIcon = true;
            this.loginTb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.loginTb.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.loginTb.Lines = new string[0];
            this.loginTb.Location = new System.Drawing.Point(62, 29);
            this.loginTb.MaxLength = 32767;
            this.loginTb.Name = "loginTb";
            this.loginTb.PasswordChar = '\0';
            this.loginTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.loginTb.SelectedText = "";
            this.loginTb.SelectionLength = 0;
            this.loginTb.SelectionStart = 0;
            this.loginTb.ShortcutsEnabled = true;
            this.loginTb.Size = new System.Drawing.Size(161, 30);
            this.loginTb.Style = MetroFramework.MetroColorStyle.Red;
            this.loginTb.TabIndex = 13;
            this.loginTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.loginTb.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginTb.UseSelectable = true;
            this.loginTb.UseStyleColors = true;
            this.loginTb.WaterMark = "Login";
            this.loginTb.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.loginTb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginTb_KeyDown);
            this.loginTb.MouseEnter += new System.EventHandler(this.loginTb_MouseEnter);
            // 
            // signinBtn
            // 
            this.signinBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.signinBtn.ForeColor = System.Drawing.Color.White;
            this.signinBtn.Highlight = true;
            this.signinBtn.Location = new System.Drawing.Point(62, 183);
            this.signinBtn.Name = "signinBtn";
            this.signinBtn.Size = new System.Drawing.Size(161, 58);
            this.signinBtn.Style = MetroFramework.MetroColorStyle.White;
            this.signinBtn.TabIndex = 14;
            this.signinBtn.Text = "Sign in";
            this.signinBtn.UseCustomBackColor = true;
            this.signinBtn.UseCustomForeColor = true;
            this.signinBtn.UseSelectable = true;
            this.signinBtn.UseStyleColors = true;
            this.signinBtn.Click += new System.EventHandler(this.signinBtn_Click);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(284, 287);
            this.Controls.Add(this.signinBtn);
            this.Controls.Add(this.loginTb);
            this.Controls.Add(this.exitLb);
            this.Controls.Add(this.separator);
            this.Controls.Add(this.signupBtn);
            this.Controls.Add(this.genderCb);
            this.Controls.Add(this.birthDt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enter";
            this.Load += new System.EventHandler(this.Enter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime birthDt;
        private MetroFramework.Controls.MetroComboBox genderCb;
        private System.Windows.Forms.Label signupBtn;
        private System.Windows.Forms.Label exitLb;
        private System.Windows.Forms.Label separator;
        private MetroFramework.Controls.MetroTextBox loginTb;
        private MetroFramework.Controls.MetroButton signinBtn;
    }
}