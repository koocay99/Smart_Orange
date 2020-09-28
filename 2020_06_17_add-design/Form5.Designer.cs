namespace Serial_Communication
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton3 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.image_slide = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.write_btn = new Guna.UI.WinForms.GunaButton();
            this.search_btn = new Guna.UI.WinForms.GunaButton();
            this.minimize_button = new Guna.UI.WinForms.GunaButton();
            this.exit_button = new Guna.UI.WinForms.GunaButton();
            this.blinder_pb = new Guna.UI.WinForms.GunaPictureBox();
            this.Notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image_slide)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blinder_pb)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.gunaButton1);
            this.panel1.Controls.Add(this.gunaAdvenceButton1);
            this.panel1.Controls.Add(this.gunaAdvenceButton3);
            this.panel1.Controls.Add(this.gunaAdvenceButton2);
            this.panel1.Controls.Add(this.image_slide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(102, 822);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaButton1.Location = new System.Drawing.Point(30, 768);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(122)))), ((int)(((byte)(28)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 15;
            this.gunaButton1.Size = new System.Drawing.Size(46, 42);
            this.gunaButton1.TabIndex = 4;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(12, 38);
            this.gunaAdvenceButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(128)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 16;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(90, 52);
            this.gunaAdvenceButton1.TabIndex = 2;
            this.gunaAdvenceButton1.Text = "Edit";
            this.gunaAdvenceButton1.UseTransfarantBackground = true;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaAdvenceButton1_CheckedChanged);
            // 
            // gunaAdvenceButton3
            // 
            this.gunaAdvenceButton3.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton3.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton3.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton3.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.CheckedImage")));
            this.gunaAdvenceButton3.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton3.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton3.Image")));
            this.gunaAdvenceButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.Location = new System.Drawing.Point(12, 226);
            this.gunaAdvenceButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaAdvenceButton3.Name = "gunaAdvenceButton3";
            this.gunaAdvenceButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(128)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton3.OnHoverImage = null;
            this.gunaAdvenceButton3.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton3.Radius = 16;
            this.gunaAdvenceButton3.Size = new System.Drawing.Size(87, 52);
            this.gunaAdvenceButton3.TabIndex = 2;
            this.gunaAdvenceButton3.Text = "Edit";
            this.gunaAdvenceButton3.UseTransfarantBackground = true;
            this.gunaAdvenceButton3.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton3_CheckedChanged);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(12, 131);
            this.gunaAdvenceButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(128)))), ((int)(((byte)(36)))));
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Radius = 16;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(87, 52);
            this.gunaAdvenceButton2.TabIndex = 2;
            this.gunaAdvenceButton2.Text = "Edit";
            this.gunaAdvenceButton2.UseTransfarantBackground = true;
            this.gunaAdvenceButton2.CheckedChanged += new System.EventHandler(this.gunaAdvenceButton2_CheckedChanged);
            // 
            // image_slide
            // 
            this.image_slide.BackColor = System.Drawing.Color.White;
            this.image_slide.Location = new System.Drawing.Point(81, 38);
            this.image_slide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.image_slide.Name = "image_slide";
            this.image_slide.Size = new System.Drawing.Size(61, 52);
            this.image_slide.TabIndex = 3;
            this.image_slide.TabStop = false;
            this.image_slide.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.write_btn);
            this.panel2.Controls.Add(this.search_btn);
            this.panel2.Controls.Add(this.minimize_button);
            this.panel2.Controls.Add(this.exit_button);
            this.panel2.Controls.Add(this.blinder_pb);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(97, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(412, 822);
            this.panel2.TabIndex = 4;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // write_btn
            // 
            this.write_btn.AnimationHoverSpeed = 0.07F;
            this.write_btn.AnimationSpeed = 0.03F;
            this.write_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.write_btn.BorderColor = System.Drawing.Color.Black;
            this.write_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.write_btn.FocusedColor = System.Drawing.Color.Empty;
            this.write_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.write_btn.ForeColor = System.Drawing.Color.White;
            this.write_btn.Image = null;
            this.write_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.write_btn.Location = new System.Drawing.Point(84, 3);
            this.write_btn.Name = "write_btn";
            this.write_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(138)))), ((int)(((byte)(54)))));
            this.write_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.write_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.write_btn.OnHoverImage = null;
            this.write_btn.OnPressedColor = System.Drawing.Color.Black;
            this.write_btn.Size = new System.Drawing.Size(75, 43);
            this.write_btn.TabIndex = 3;
            this.write_btn.Text = "작성";
            this.write_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.write_btn.Visible = false;
            // 
            // search_btn
            // 
            this.search_btn.AnimationHoverSpeed = 0.07F;
            this.search_btn.AnimationSpeed = 0.03F;
            this.search_btn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.search_btn.BorderColor = System.Drawing.Color.Black;
            this.search_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search_btn.FocusedColor = System.Drawing.Color.Empty;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Image = null;
            this.search_btn.ImageSize = new System.Drawing.Size(20, 20);
            this.search_btn.Location = new System.Drawing.Point(3, 3);
            this.search_btn.Name = "search_btn";
            this.search_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(138)))), ((int)(((byte)(54)))));
            this.search_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.search_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.search_btn.OnHoverImage = null;
            this.search_btn.OnPressedColor = System.Drawing.Color.Black;
            this.search_btn.Size = new System.Drawing.Size(75, 43);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "조회";
            this.search_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.search_btn.Visible = false;
            // 
            // minimize_button
            // 
            this.minimize_button.AnimationHoverSpeed = 0.07F;
            this.minimize_button.AnimationSpeed = 0.03F;
            this.minimize_button.BaseColor = System.Drawing.Color.White;
            this.minimize_button.BorderColor = System.Drawing.Color.Black;
            this.minimize_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.minimize_button.FocusedColor = System.Drawing.Color.Empty;
            this.minimize_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimize_button.ForeColor = System.Drawing.Color.White;
            this.minimize_button.Image = ((System.Drawing.Image)(resources.GetObject("minimize_button.Image")));
            this.minimize_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.minimize_button.ImageSize = new System.Drawing.Size(30, 30);
            this.minimize_button.Location = new System.Drawing.Point(297, 3);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.minimize_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.minimize_button.OnHoverForeColor = System.Drawing.Color.White;
            this.minimize_button.OnHoverImage = null;
            this.minimize_button.OnPressedColor = System.Drawing.Color.Black;
            this.minimize_button.Size = new System.Drawing.Size(43, 43);
            this.minimize_button.TabIndex = 1;
            this.minimize_button.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // exit_button
            // 
            this.exit_button.AnimationHoverSpeed = 0.07F;
            this.exit_button.AnimationSpeed = 0.03F;
            this.exit_button.BaseColor = System.Drawing.Color.White;
            this.exit_button.BorderColor = System.Drawing.Color.Black;
            this.exit_button.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exit_button.FocusedColor = System.Drawing.Color.Empty;
            this.exit_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exit_button.ForeColor = System.Drawing.Color.White;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.exit_button.ImageSize = new System.Drawing.Size(30, 30);
            this.exit_button.Location = new System.Drawing.Point(349, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.exit_button.OnHoverBorderColor = System.Drawing.Color.Black;
            this.exit_button.OnHoverForeColor = System.Drawing.Color.White;
            this.exit_button.OnHoverImage = null;
            this.exit_button.OnPressedColor = System.Drawing.Color.Black;
            this.exit_button.Size = new System.Drawing.Size(43, 43);
            this.exit_button.TabIndex = 0;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // blinder_pb
            // 
            this.blinder_pb.BaseColor = System.Drawing.Color.White;
            this.blinder_pb.Location = new System.Drawing.Point(0, 0);
            this.blinder_pb.Name = "blinder_pb";
            this.blinder_pb.Size = new System.Drawing.Size(392, 50);
            this.blinder_pb.TabIndex = 4;
            this.blinder_pb.TabStop = false;
            // 
            // Notification
            // 
            this.Notification.Icon = ((System.Drawing.Icon)(resources.GetObject("Notification.Icon")));
            this.Notification.Text = "Project_Orange";
            this.Notification.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.contextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStrip1.RenderStyle.ColorTable = null;
            this.contextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.contextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.contextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(509, 822);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.image_slide)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blinder_pb)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        private System.Windows.Forms.PictureBox image_slide;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton exit_button;
        private System.Windows.Forms.NotifyIcon Notification;
        private Guna.UI.WinForms.GunaContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private Guna.UI.WinForms.GunaButton minimize_button;
        public Guna.UI.WinForms.GunaButton write_btn;
        public Guna.UI.WinForms.GunaButton search_btn;
        public Guna.UI.WinForms.GunaPictureBox blinder_pb;
    }
}