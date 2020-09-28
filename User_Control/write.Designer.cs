namespace Serial_Communication.User_Control
{
    partial class write
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(write));
            this.CB_category = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TB_title = new Guna.UI2.WinForms.Guna2TextBox();
            this.BT_upload = new Guna.UI2.WinForms.Guna2Button();
            this.preset_1 = new Guna.UI2.WinForms.Guna2Button();
            this.comboBox1_preset = new Guna.UI2.WinForms.Guna2ComboBox();
            this.previousbtn = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TB_context = new System.Windows.Forms.TextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_category
            // 
            this.CB_category.BackColor = System.Drawing.Color.Transparent;
            this.CB_category.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.CB_category.BorderRadius = 4;
            this.CB_category.BorderThickness = 4;
            this.CB_category.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CB_category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_category.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.CB_category.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.CB_category.FocusedState.Parent = this.CB_category;
            this.CB_category.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CB_category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CB_category.HoverState.Parent = this.CB_category;
            this.CB_category.ItemHeight = 30;
            this.CB_category.ItemsAppearance.Parent = this.CB_category;
            this.CB_category.Location = new System.Drawing.Point(15, 98);
            this.CB_category.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CB_category.Name = "CB_category";
            this.CB_category.ShadowDecoration.Parent = this.CB_category;
            this.CB_category.Size = new System.Drawing.Size(182, 36);
            this.CB_category.TabIndex = 1;
            this.CB_category.SelectedIndexChanged += new System.EventHandler(this.comboBox1_category_SelectedIndexChanged);
            // 
            // TB_title
            // 
            this.TB_title.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.TB_title.BorderRadius = 4;
            this.TB_title.BorderThickness = 4;
            this.TB_title.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_title.DefaultText = "";
            this.TB_title.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TB_title.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TB_title.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_title.DisabledState.Parent = this.TB_title;
            this.TB_title.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TB_title.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.TB_title.FocusedState.Parent = this.TB_title;
            this.TB_title.ForeColor = System.Drawing.Color.Black;
            this.TB_title.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.TB_title.HoverState.Parent = this.TB_title;
            this.TB_title.Location = new System.Drawing.Point(15, 170);
            this.TB_title.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TB_title.Name = "TB_title";
            this.TB_title.PasswordChar = '\0';
            this.TB_title.PlaceholderText = "";
            this.TB_title.SelectedText = "";
            this.TB_title.ShadowDecoration.Parent = this.TB_title;
            this.TB_title.Size = new System.Drawing.Size(390, 44);
            this.TB_title.TabIndex = 2;
            this.TB_title.VisibleChanged += new System.EventHandler(this.TB_title_VisibleChanged);
            // 
            // BT_upload
            // 
            this.BT_upload.CheckedState.Parent = this.BT_upload;
            this.BT_upload.CustomImages.Parent = this.BT_upload;
            this.BT_upload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_upload.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_upload.ForeColor = System.Drawing.Color.White;
            this.BT_upload.HoverState.Parent = this.BT_upload;
            this.BT_upload.Location = new System.Drawing.Point(15, 774);
            this.BT_upload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BT_upload.Name = "BT_upload";
            this.BT_upload.ShadowDecoration.Parent = this.BT_upload;
            this.BT_upload.Size = new System.Drawing.Size(390, 44);
            this.BT_upload.TabIndex = 3;
            this.BT_upload.Text = "등록하기";
            this.BT_upload.Click += new System.EventHandler(this.button1_Click);
            // 
            // preset_1
            // 
            this.preset_1.CheckedState.Parent = this.preset_1;
            this.preset_1.CustomImages.Parent = this.preset_1;
            this.preset_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.preset_1.ForeColor = System.Drawing.Color.White;
            this.preset_1.HoverState.Parent = this.preset_1;
            this.preset_1.Location = new System.Drawing.Point(15, 38);
            this.preset_1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.preset_1.Name = "preset_1";
            this.preset_1.ShadowDecoration.Parent = this.preset_1;
            this.preset_1.Size = new System.Drawing.Size(111, 30);
            this.preset_1.TabIndex = 4;
            this.preset_1.Text = "guna2Button1";
            this.preset_1.Visible = false;
            this.preset_1.Click += new System.EventHandler(this.preset_1_Click);
            // 
            // comboBox1_preset
            // 
            this.comboBox1_preset.BackColor = System.Drawing.Color.Transparent;
            this.comboBox1_preset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.comboBox1_preset.BorderRadius = 4;
            this.comboBox1_preset.BorderThickness = 4;
            this.comboBox1_preset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox1_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1_preset.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.comboBox1_preset.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.comboBox1_preset.FocusedState.Parent = this.comboBox1_preset;
            this.comboBox1_preset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox1_preset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboBox1_preset.HoverState.Parent = this.comboBox1_preset;
            this.comboBox1_preset.ItemHeight = 30;
            this.comboBox1_preset.ItemsAppearance.Parent = this.comboBox1_preset;
            this.comboBox1_preset.Location = new System.Drawing.Point(223, 98);
            this.comboBox1_preset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1_preset.Name = "comboBox1_preset";
            this.comboBox1_preset.ShadowDecoration.Parent = this.comboBox1_preset;
            this.comboBox1_preset.Size = new System.Drawing.Size(182, 36);
            this.comboBox1_preset.TabIndex = 5;
            // 
            // previousbtn
            // 
            this.previousbtn.AnimationHoverSpeed = 0.07F;
            this.previousbtn.AnimationSpeed = 0.03F;
            this.previousbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.previousbtn.BorderColor = System.Drawing.Color.Black;
            this.previousbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.previousbtn.FocusedColor = System.Drawing.Color.Empty;
            this.previousbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.previousbtn.ForeColor = System.Drawing.Color.White;
            this.previousbtn.Image = ((System.Drawing.Image)(resources.GetObject("previousbtn.Image")));
            this.previousbtn.ImageSize = new System.Drawing.Size(30, 30);
            this.previousbtn.Location = new System.Drawing.Point(15, 17);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.previousbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.previousbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.previousbtn.OnHoverImage = null;
            this.previousbtn.OnPressedColor = System.Drawing.Color.Black;
            this.previousbtn.Size = new System.Drawing.Size(182, 40);
            this.previousbtn.TabIndex = 8;
            this.previousbtn.Text = "이전페이지";
            this.previousbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(15, 222);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel1.TabIndex = 9;
            this.gunaLabel1.Text = "내용";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(15, 146);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel2.TabIndex = 10;
            this.gunaLabel2.Text = "제목";
            // 
            // TB_context
            // 
            this.TB_context.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_context.Location = new System.Drawing.Point(19, 249);
            this.TB_context.Multiline = true;
            this.TB_context.Name = "TB_context";
            this.TB_context.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_context.Size = new System.Drawing.Size(382, 514);
            this.TB_context.TabIndex = 12;
            this.TB_context.TextChanged += new System.EventHandler(this.TB_context_TextChanged);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.Location = new System.Drawing.Point(15, 245);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(390, 522);
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
            // 
            // write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TB_context);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.comboBox1_preset);
            this.Controls.Add(this.preset_1);
            this.Controls.Add(this.BT_upload);
            this.Controls.Add(this.TB_title);
            this.Controls.Add(this.CB_category);
            this.Controls.Add(this.gunaPictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "write";
            this.Size = new System.Drawing.Size(421, 822);
            this.Load += new System.EventHandler(this.write_Load);
            this.Enter += new System.EventHandler(this.write_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox CB_category;
        private Guna.UI2.WinForms.Guna2Button BT_upload;
        private Guna.UI2.WinForms.Guna2Button preset_1;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox1_preset;
        public Guna.UI.WinForms.GunaButton previousbtn;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        public Guna.UI2.WinForms.Guna2TextBox TB_title;
        public System.Windows.Forms.TextBox TB_context;
    }
}
