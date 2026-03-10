namespace PasswordGenerator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TrackBar sliderLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.CheckBox chkUppercase;
        private System.Windows.Forms.CheckBox chkLowercase;
        private System.Windows.Forms.CheckBox chkDigits;
        private System.Windows.Forms.CheckBox chkSpecial;
        private System.Windows.Forms.ListView lstHistory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Panel panelSettings;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ColumnHeader colPassword;
        private System.Windows.Forms.ColumnHeader colLength;
        private System.Windows.Forms.ColumnHeader colRules;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.sliderLength = new System.Windows.Forms.TrackBar();
            this.lblLength = new System.Windows.Forms.Label();
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.chkUppercase = new System.Windows.Forms.CheckBox();
            this.chkLowercase = new System.Windows.Forms.CheckBox();
            this.chkDigits = new System.Windows.Forms.CheckBox();
            this.chkSpecial = new System.Windows.Forms.CheckBox();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelHistory = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.colTime = new System.Windows.Forms.ColumnHeader();
            this.colPassword = new System.Windows.Forms.ColumnHeader();
            this.colLength = new System.Windows.Forms.ColumnHeader();
            this.colRules = new System.Windows.Forms.ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)(this.sliderLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.panelPassword.SuspendLayout();
            this.panelSettings.SuspendLayout();
            this.panelHistory.SuspendLayout();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 650);
            this.MinimumSize = new System.Drawing.Size(450, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "随机密码生成器";
            this.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(180, 30);
            this.lblTitle.Text = "随机密码生成器";
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.panelPassword.Controls.Add(this.txtPassword);
            this.panelPassword.Controls.Add(this.btnCopy);
            this.panelPassword.Controls.Add(this.btnGenerate);
            this.panelPassword.Controls.Add(this.btnSave);
            this.panelPassword.Location = new System.Drawing.Point(16, 55);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(468, 140);
            this.panelPassword.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(16, 185, 129);
            this.txtPassword.Location = new System.Drawing.Point(15, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(350, 32);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.Location = new System.Drawing.Point(375, 15);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(78, 32);
            this.btnCopy.TabIndex = 1;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(124, 58, 237);
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Location = new System.Drawing.Point(15, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(220, 36);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "生成密码";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(61, 61, 92);
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.btnSave.Location = new System.Drawing.Point(245, 60);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(208, 36);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "保存密码";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.panelSettings.Controls.Add(this.lblLength);
            this.panelSettings.Controls.Add(this.numLength);
            this.panelSettings.Controls.Add(this.sliderLength);
            this.panelSettings.Controls.Add(this.chkUppercase);
            this.panelSettings.Controls.Add(this.chkLowercase);
            this.panelSettings.Controls.Add(this.chkDigits);
            this.panelSettings.Controls.Add(this.chkSpecial);
            this.panelSettings.Location = new System.Drawing.Point(16, 205);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(468, 160);
            this.panelSettings.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblLength.ForeColor = System.Drawing.Color.FromArgb(160, 160, 176);
            this.lblLength.Location = new System.Drawing.Point(15, 15);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(60, 17);
            this.lblLength.Text = "密码长度:";
            // 
            // numLength
            // 
            this.numLength.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.numLength.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numLength.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.numLength.Location = new System.Drawing.Point(380, 12);
            this.numLength.Maximum = new decimal(new int[] { 64, 0, 0, 0 });
            this.numLength.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(60, 25);
            this.numLength.TabIndex = 0;
            this.numLength.Value = new decimal(new int[] { 16, 0, 0, 0 });
            this.numLength.ValueChanged += new System.EventHandler(this.numLength_ValueChanged);
            // 
            // sliderLength
            // 
            this.sliderLength.BackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.sliderLength.Location = new System.Drawing.Point(85, 12);
            this.sliderLength.Maximum = 64;
            this.sliderLength.Minimum = 8;
            this.sliderLength.Name = "sliderLength";
            this.sliderLength.Size = new System.Drawing.Size(290, 42);
            this.sliderLength.TabIndex = 1;
            this.sliderLength.Value = 16;
            this.sliderLength.Scroll += new System.EventHandler(this.sliderLength_Scroll);
            // 
            // chkUppercase
            // 
            this.chkUppercase.AutoSize = true;
            this.chkUppercase.Checked = true;
            this.chkUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkUppercase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkUppercase.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.chkUppercase.Location = new System.Drawing.Point(15, 65);
            this.chkUppercase.Name = "chkUppercase";
            this.chkUppercase.Size = new System.Drawing.Size(100, 21);
            this.chkUppercase.TabIndex = 2;
            this.chkUppercase.Text = "大写字母 (A-Z)";
            this.chkUppercase.UseVisualStyleBackColor = true;
            // 
            // chkLowercase
            // 
            this.chkLowercase.AutoSize = true;
            this.chkLowercase.Checked = true;
            this.chkLowercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLowercase.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkLowercase.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.chkLowercase.Location = new System.Drawing.Point(15, 95);
            this.chkLowercase.Name = "chkLowercase";
            this.chkLowercase.Size = new System.Drawing.Size(100, 21);
            this.chkLowercase.TabIndex = 3;
            this.chkLowercase.Text = "小写字母 (a-z)";
            this.chkLowercase.UseVisualStyleBackColor = true;
            // 
            // chkDigits
            // 
            this.chkDigits.AutoSize = true;
            this.chkDigits.Checked = true;
            this.chkDigits.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDigits.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkDigits.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.chkDigits.Location = new System.Drawing.Point(220, 65);
            this.chkDigits.Name = "chkDigits";
            this.chkDigits.Size = new System.Drawing.Size(75, 21);
            this.chkDigits.TabIndex = 4;
            this.chkDigits.Text = "数字 (0-9)";
            this.chkDigits.UseVisualStyleBackColor = true;
            // 
            // chkSpecial
            // 
            this.chkSpecial.AutoSize = true;
            this.chkSpecial.Checked = true;
            this.chkSpecial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSpecial.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chkSpecial.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.chkSpecial.Location = new System.Drawing.Point(220, 95);
            this.chkSpecial.Name = "chkSpecial";
            this.chkSpecial.Size = new System.Drawing.Size(95, 21);
            this.chkSpecial.TabIndex = 5;
            this.chkSpecial.Text = "特殊字符";
            this.chkSpecial.UseVisualStyleBackColor = true;
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(45, 45, 68);
            this.panelHistory.Controls.Add(this.lstHistory);
            this.panelHistory.Controls.Add(this.btnDelete);
            this.panelHistory.Controls.Add(this.btnClearAll);
            this.panelHistory.Location = new System.Drawing.Point(16, 375);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(468, 250);
            this.panelHistory.TabIndex = 2;
            // 
            // lstHistory
            // 
            this.lstHistory.BackColor = System.Drawing.Color.FromArgb(30, 30, 46);
            this.lstHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTime,
            this.colPassword,
            this.colLength,
            this.colRules});
            this.lstHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstHistory.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.lstHistory.FullRowSelect = true;
            this.lstHistory.GridLines = true;
            this.lstHistory.Location = new System.Drawing.Point(15, 15);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(438, 170);
            this.lstHistory.TabIndex = 0;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            this.lstHistory.View = System.Windows.Forms.View.Details;
            this.lstHistory.DoubleClick += new System.EventHandler(this.lstHistory_DoubleClick);
            // 
            // colTime
            // 
            this.colTime.Text = "时间";
            this.colTime.Width = 140;
            // 
            // colPassword
            // 
            this.colPassword.Text = "密码";
            this.colPassword.Width = 160;
            // 
            // colLength
            // 
            this.colLength.Text = "长度";
            this.colLength.Width = 50;
            // 
            // colRules
            // 
            this.colRules.Text = "规则";
            this.colRules.Width = 70;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(239, 68, 68);
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(15, 195);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删除选中";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BackColor = System.Drawing.Color.FromArgb(61, 61, 92);
            this.btnClearAll.FlatAppearance.BorderSize = 0;
            this.btnClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearAll.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(248, 248, 242);
            this.btnClearAll.Location = new System.Drawing.Point(125, 195);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(100, 30);
            this.btnClearAll.TabIndex = 2;
            this.btnClearAll.Text = "清空历史";
            this.btnClearAll.UseVisualStyleBackColor = false;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // Form1
            // 
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.panelSettings);
            this.Controls.Add(this.panelHistory);
            ((System.ComponentModel.ISupportInitialize)(this.sliderLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.panelHistory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
