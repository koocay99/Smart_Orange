namespace Serial_Communication
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.login_button = new Guna.UI.WinForms.GunaButton();
            this.regist_button = new Guna.UI.WinForms.GunaButton();
            this.overlap_button = new Guna.UI.WinForms.GunaButton();
            this.checkBox1 = new Guna.UI.WinForms.GunaCheckBox();
            this.ID_TB = new Guna.UI.WinForms.GunaLineTextBox();
            this.PW_TB = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(52, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15F);
            this.label2.Location = new System.Drawing.Point(8, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // login_button
            // 
            this.login_button.AnimationHoverSpeed = 0.07F;
            this.login_button.AnimationSpeed = 0.03F;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.login_button.BorderColor = System.Drawing.Color.Black;
            this.login_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.login_button.FocusedColor = System.Drawing.Color.Empty;
            this.login_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_button.ForeColor = System.Drawing.Color.White;
            this.login_button.Image = null;
            this.login_button.ImageSize = new System.Drawing.Size(20, 20);
            this.login_button.Location = new System.Drawing.Point(59, 269);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.login_button.Name = "login_button";
            this.login_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.login_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.login_button.OnHoverForeColor = System.Drawing.Color.White;
            this.login_button.OnHoverImage = null;
            this.login_button.OnPressedColor = System.Drawing.Color.Black;
            this.login_button.Size = new System.Drawing.Size(200, 50);
            this.login_button.TabIndex = 8;
            this.login_button.Text = "로그인";
            this.login_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // regist_button
            // 
            this.regist_button.AnimationHoverSpeed = 0.07F;
            this.regist_button.AnimationSpeed = 0.03F;
            this.regist_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.regist_button.BorderColor = System.Drawing.Color.Black;
            this.regist_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.regist_button.FocusedColor = System.Drawing.Color.Empty;
            this.regist_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.regist_button.ForeColor = System.Drawing.Color.White;
            this.regist_button.Image = null;
            this.regist_button.ImageSize = new System.Drawing.Size(20, 20);
            this.regist_button.Location = new System.Drawing.Point(311, 269);
            this.regist_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.regist_button.Name = "regist_button";
            this.regist_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.regist_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.regist_button.OnHoverForeColor = System.Drawing.Color.White;
            this.regist_button.OnHoverImage = null;
            this.regist_button.OnPressedColor = System.Drawing.Color.Black;
            this.regist_button.Size = new System.Drawing.Size(200, 50);
            this.regist_button.TabIndex = 8;
            this.regist_button.Text = "회원가입";
            this.regist_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regist_button.Click += new System.EventHandler(this.regist_button_Click);
            // 
            // overlap_button
            // 
            this.overlap_button.AnimationHoverSpeed = 0.07F;
            this.overlap_button.AnimationSpeed = 0.03F;
            this.overlap_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.overlap_button.BorderColor = System.Drawing.Color.Black;
            this.overlap_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.overlap_button.FocusedColor = System.Drawing.Color.Empty;
            this.overlap_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.overlap_button.ForeColor = System.Drawing.Color.White;
            this.overlap_button.Image = null;
            this.overlap_button.ImageSize = new System.Drawing.Size(20, 20);
            this.overlap_button.Location = new System.Drawing.Point(435, 84);
            this.overlap_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.overlap_button.Name = "overlap_button";
            this.overlap_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.overlap_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.overlap_button.OnHoverForeColor = System.Drawing.Color.White;
            this.overlap_button.OnHoverImage = null;
            this.overlap_button.OnPressedColor = System.Drawing.Color.Black;
            this.overlap_button.Size = new System.Drawing.Size(102, 50);
            this.overlap_button.TabIndex = 8;
            this.overlap_button.Text = "중복확인";
            this.overlap_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.overlap_button.Click += new System.EventHandler(this.overlap_button_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.BaseColor = System.Drawing.Color.White;
            this.checkBox1.CheckedOffColor = System.Drawing.Color.Gray;
            this.checkBox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.checkBox1.FillColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(162, 191);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 25);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "로그인 유지";
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ID_TB
            // 
            this.ID_TB.BackColor = System.Drawing.Color.White;
            this.ID_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_TB.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.ID_TB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ID_TB.LineColor = System.Drawing.Color.Gainsboro;
            this.ID_TB.Location = new System.Drawing.Point(168, 78);
            this.ID_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.PasswordChar = '\0';
            this.ID_TB.SelectedText = "";
            this.ID_TB.Size = new System.Drawing.Size(242, 41);
            this.ID_TB.TabIndex = 10;
            this.ID_TB.TextChanged += new System.EventHandler(this.ID_TB_TextChanged);
            // 
            // PW_TB
            // 
            this.PW_TB.BackColor = System.Drawing.Color.White;
            this.PW_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PW_TB.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.PW_TB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PW_TB.LineColor = System.Drawing.Color.Gainsboro;
            this.PW_TB.Location = new System.Drawing.Point(168, 136);
            this.PW_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PW_TB.Name = "PW_TB";
            this.PW_TB.PasswordChar = '*';
            this.PW_TB.SelectedText = "";
            this.PW_TB.Size = new System.Drawing.Size(242, 41);
            this.PW_TB.TabIndex = 11;
            this.PW_TB.TextChanged += new System.EventHandler(this.PW_TB_TextChanged);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaButton1.BackgroundImage")));
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(496, 2);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(54, 50);
            this.gunaButton1.TabIndex = 12;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(552, 378);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.PW_TB);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.overlap_button);
            this.Controls.Add(this.regist_button);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form3";
            this.Text = "login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form3_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaButton login_button;
        private Guna.UI.WinForms.GunaButton regist_button;
        private Guna.UI.WinForms.GunaButton overlap_button;
        private Guna.UI.WinForms.GunaCheckBox checkBox1;
        private Guna.UI.WinForms.GunaLineTextBox ID_TB;
        private Guna.UI.WinForms.GunaLineTextBox PW_TB;
        private Guna.UI.WinForms.GunaButton gunaButton1;
    }
}