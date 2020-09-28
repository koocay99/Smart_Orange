namespace Serial_Communication
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.logout_button = new Guna.UI.WinForms.GunaButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(406, 12);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(43, 42);
            this.gunaButton1.TabIndex = 14;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // logout_button
            // 
            this.logout_button.AnimationHoverSpeed = 0.07F;
            this.logout_button.AnimationSpeed = 0.03F;
            this.logout_button.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.logout_button.BorderColor = System.Drawing.Color.Black;
            this.logout_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.logout_button.FocusedColor = System.Drawing.Color.Empty;
            this.logout_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logout_button.ForeColor = System.Drawing.Color.White;
            this.logout_button.Image = null;
            this.logout_button.ImageSize = new System.Drawing.Size(20, 20);
            this.logout_button.Location = new System.Drawing.Point(155, 187);
            this.logout_button.Name = "logout_button";
            this.logout_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.logout_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.logout_button.OnHoverForeColor = System.Drawing.Color.White;
            this.logout_button.OnHoverImage = null;
            this.logout_button.OnPressedColor = System.Drawing.Color.Black;
            this.logout_button.Size = new System.Drawing.Size(160, 42);
            this.logout_button.TabIndex = 13;
            this.logout_button.Text = "로그아웃";
            this.logout_button.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.logout_button.Click += new System.EventHandler(this.logout_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(461, 309);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.logout_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton logout_button;
        private System.Windows.Forms.Label label1;
    }
}