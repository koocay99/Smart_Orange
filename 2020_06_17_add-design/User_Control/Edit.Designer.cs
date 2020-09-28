namespace Serial_Communication.User_Control
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            this.Name_label = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.guna_splitbtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna_preset_1_save = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna_Delbtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna_preset_1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna_changebtn = new Guna.UI.WinForms.GunaAdvenceButton();
            this.guna_comboBox1_preset = new Guna.UI.WinForms.GunaComboBox();
            this.guna_pie_split_cb = new Guna.UI.WinForms.GunaComboBox();
            this.guna_preset_name = new Guna.UI.WinForms.GunaLineTextBox();
            this.contextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.keydownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VolumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FuncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubkeyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Font = new System.Drawing.Font("굴림", 12F);
            this.Name_label.Location = new System.Drawing.Point(21, 733);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(49, 20);
            this.Name_label.TabIndex = 19;
            this.Name_label.Text = "이름";
            this.Name_label.Visible = false;
            // 
            // guna_splitbtn
            // 
            this.guna_splitbtn.AnimationHoverSpeed = 0.07F;
            this.guna_splitbtn.AnimationSpeed = 0.03F;
            this.guna_splitbtn.BackColor = System.Drawing.Color.Transparent;
            this.guna_splitbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_splitbtn.BorderColor = System.Drawing.Color.Black;
            this.guna_splitbtn.CausesValidation = false;
            this.guna_splitbtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.guna_splitbtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.guna_splitbtn.CheckedForeColor = System.Drawing.Color.White;
            this.guna_splitbtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna_splitbtn.CheckedImage")));
            this.guna_splitbtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.guna_splitbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna_splitbtn.FocusedColor = System.Drawing.Color.Empty;
            this.guna_splitbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_splitbtn.ForeColor = System.Drawing.Color.White;
            this.guna_splitbtn.Image = ((System.Drawing.Image)(resources.GetObject("guna_splitbtn.Image")));
            this.guna_splitbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.guna_splitbtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_splitbtn.Location = new System.Drawing.Point(286, 765);
            this.guna_splitbtn.Name = "guna_splitbtn";
            this.guna_splitbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_splitbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guna_splitbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.guna_splitbtn.OnHoverImage = null;
            this.guna_splitbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_splitbtn.OnPressedColor = System.Drawing.Color.Black;
            this.guna_splitbtn.Radius = 15;
            this.guna_splitbtn.Size = new System.Drawing.Size(109, 42);
            this.guna_splitbtn.TabIndex = 20;
            this.guna_splitbtn.Text = "   나누기";
            this.guna_splitbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_splitbtn.Click += new System.EventHandler(this.splitbtn_Click);
            // 
            // guna_preset_1_save
            // 
            this.guna_preset_1_save.AnimationHoverSpeed = 0.07F;
            this.guna_preset_1_save.AnimationSpeed = 0.03F;
            this.guna_preset_1_save.BackColor = System.Drawing.Color.Transparent;
            this.guna_preset_1_save.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_preset_1_save.BorderColor = System.Drawing.Color.Black;
            this.guna_preset_1_save.CausesValidation = false;
            this.guna_preset_1_save.CheckedBaseColor = System.Drawing.Color.Gray;
            this.guna_preset_1_save.CheckedBorderColor = System.Drawing.Color.Black;
            this.guna_preset_1_save.CheckedForeColor = System.Drawing.Color.White;
            this.guna_preset_1_save.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna_preset_1_save.CheckedImage")));
            this.guna_preset_1_save.CheckedLineColor = System.Drawing.Color.DimGray;
            this.guna_preset_1_save.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna_preset_1_save.FocusedColor = System.Drawing.Color.Empty;
            this.guna_preset_1_save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_preset_1_save.ForeColor = System.Drawing.Color.White;
            this.guna_preset_1_save.Image = ((System.Drawing.Image)(resources.GetObject("guna_preset_1_save.Image")));
            this.guna_preset_1_save.ImageSize = new System.Drawing.Size(20, 20);
            this.guna_preset_1_save.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_preset_1_save.Location = new System.Drawing.Point(286, 717);
            this.guna_preset_1_save.Name = "guna_preset_1_save";
            this.guna_preset_1_save.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_preset_1_save.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guna_preset_1_save.OnHoverForeColor = System.Drawing.Color.White;
            this.guna_preset_1_save.OnHoverImage = null;
            this.guna_preset_1_save.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_preset_1_save.OnPressedColor = System.Drawing.Color.Black;
            this.guna_preset_1_save.Radius = 15;
            this.guna_preset_1_save.Size = new System.Drawing.Size(109, 42);
            this.guna_preset_1_save.TabIndex = 20;
            this.guna_preset_1_save.Text = "      새로저장";
            this.guna_preset_1_save.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_preset_1_save.Click += new System.EventHandler(this.preset_1_save_Click);
            // 
            // guna_Delbtn
            // 
            this.guna_Delbtn.AnimationHoverSpeed = 0.07F;
            this.guna_Delbtn.AnimationSpeed = 0.03F;
            this.guna_Delbtn.BackColor = System.Drawing.Color.Transparent;
            this.guna_Delbtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_Delbtn.BorderColor = System.Drawing.Color.Black;
            this.guna_Delbtn.CausesValidation = false;
            this.guna_Delbtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.guna_Delbtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.guna_Delbtn.CheckedForeColor = System.Drawing.Color.White;
            this.guna_Delbtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna_Delbtn.CheckedImage")));
            this.guna_Delbtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.guna_Delbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna_Delbtn.FocusedColor = System.Drawing.Color.Empty;
            this.guna_Delbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_Delbtn.ForeColor = System.Drawing.Color.White;
            this.guna_Delbtn.Image = ((System.Drawing.Image)(resources.GetObject("guna_Delbtn.Image")));
            this.guna_Delbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.guna_Delbtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_Delbtn.Location = new System.Drawing.Point(286, 669);
            this.guna_Delbtn.Name = "guna_Delbtn";
            this.guna_Delbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_Delbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guna_Delbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.guna_Delbtn.OnHoverImage = null;
            this.guna_Delbtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_Delbtn.OnPressedColor = System.Drawing.Color.Black;
            this.guna_Delbtn.Radius = 15;
            this.guna_Delbtn.Size = new System.Drawing.Size(109, 42);
            this.guna_Delbtn.TabIndex = 20;
            this.guna_Delbtn.Text = "   삭제";
            this.guna_Delbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_Delbtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // guna_preset_1
            // 
            this.guna_preset_1.AnimationHoverSpeed = 0.07F;
            this.guna_preset_1.AnimationSpeed = 0.03F;
            this.guna_preset_1.BackColor = System.Drawing.Color.Transparent;
            this.guna_preset_1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_preset_1.BorderColor = System.Drawing.Color.Black;
            this.guna_preset_1.CausesValidation = false;
            this.guna_preset_1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.guna_preset_1.CheckedBorderColor = System.Drawing.Color.Black;
            this.guna_preset_1.CheckedForeColor = System.Drawing.Color.White;
            this.guna_preset_1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna_preset_1.CheckedImage")));
            this.guna_preset_1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.guna_preset_1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna_preset_1.FocusedColor = System.Drawing.Color.Empty;
            this.guna_preset_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_preset_1.ForeColor = System.Drawing.Color.White;
            this.guna_preset_1.Image = ((System.Drawing.Image)(resources.GetObject("guna_preset_1.Image")));
            this.guna_preset_1.ImageSize = new System.Drawing.Size(20, 20);
            this.guna_preset_1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_preset_1.Location = new System.Drawing.Point(286, 621);
            this.guna_preset_1.Name = "guna_preset_1";
            this.guna_preset_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_preset_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guna_preset_1.OnHoverForeColor = System.Drawing.Color.White;
            this.guna_preset_1.OnHoverImage = null;
            this.guna_preset_1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_preset_1.OnPressedColor = System.Drawing.Color.Black;
            this.guna_preset_1.Radius = 15;
            this.guna_preset_1.Size = new System.Drawing.Size(109, 42);
            this.guna_preset_1.TabIndex = 20;
            this.guna_preset_1.Text = "     불러오기";
            this.guna_preset_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_preset_1.Click += new System.EventHandler(this.preset_1_Click);
            // 
            // guna_changebtn
            // 
            this.guna_changebtn.AnimationHoverSpeed = 0.07F;
            this.guna_changebtn.AnimationSpeed = 0.03F;
            this.guna_changebtn.BackColor = System.Drawing.Color.Transparent;
            this.guna_changebtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_changebtn.BorderColor = System.Drawing.Color.Black;
            this.guna_changebtn.CausesValidation = false;
            this.guna_changebtn.CheckedBaseColor = System.Drawing.Color.Gray;
            this.guna_changebtn.CheckedBorderColor = System.Drawing.Color.Black;
            this.guna_changebtn.CheckedForeColor = System.Drawing.Color.White;
            this.guna_changebtn.CheckedImage = ((System.Drawing.Image)(resources.GetObject("guna_changebtn.CheckedImage")));
            this.guna_changebtn.CheckedLineColor = System.Drawing.Color.DimGray;
            this.guna_changebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.guna_changebtn.FocusedColor = System.Drawing.Color.Empty;
            this.guna_changebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_changebtn.ForeColor = System.Drawing.Color.White;
            this.guna_changebtn.Image = ((System.Drawing.Image)(resources.GetObject("guna_changebtn.Image")));
            this.guna_changebtn.ImageSize = new System.Drawing.Size(20, 20);
            this.guna_changebtn.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_changebtn.Location = new System.Drawing.Point(171, 669);
            this.guna_changebtn.Name = "guna_changebtn";
            this.guna_changebtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_changebtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.guna_changebtn.OnHoverForeColor = System.Drawing.Color.White;
            this.guna_changebtn.OnHoverImage = null;
            this.guna_changebtn.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.guna_changebtn.OnPressedColor = System.Drawing.Color.Black;
            this.guna_changebtn.Radius = 15;
            this.guna_changebtn.Size = new System.Drawing.Size(109, 42);
            this.guna_changebtn.TabIndex = 20;
            this.guna_changebtn.Text = "   변경";
            this.guna_changebtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guna_changebtn.Click += new System.EventHandler(this.ChangeBtn_Click);
            // 
            // guna_comboBox1_preset
            // 
            this.guna_comboBox1_preset.BackColor = System.Drawing.Color.Transparent;
            this.guna_comboBox1_preset.BaseColor = System.Drawing.Color.White;
            this.guna_comboBox1_preset.BorderColor = System.Drawing.Color.Silver;
            this.guna_comboBox1_preset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna_comboBox1_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna_comboBox1_preset.FocusedColor = System.Drawing.Color.Empty;
            this.guna_comboBox1_preset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna_comboBox1_preset.ForeColor = System.Drawing.Color.Black;
            this.guna_comboBox1_preset.FormattingEnabled = true;
            this.guna_comboBox1_preset.Location = new System.Drawing.Point(25, 621);
            this.guna_comboBox1_preset.Name = "guna_comboBox1_preset";
            this.guna_comboBox1_preset.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna_comboBox1_preset.OnHoverItemForeColor = System.Drawing.Color.White;
            this.guna_comboBox1_preset.Size = new System.Drawing.Size(250, 31);
            this.guna_comboBox1_preset.TabIndex = 21;
            this.guna_comboBox1_preset.SelectedIndexChanged += new System.EventHandler(this.comboBox1_preset_SelectedIndexChanged);
            // 
            // guna_pie_split_cb
            // 
            this.guna_pie_split_cb.BackColor = System.Drawing.Color.Transparent;
            this.guna_pie_split_cb.BaseColor = System.Drawing.Color.White;
            this.guna_pie_split_cb.BorderColor = System.Drawing.Color.Silver;
            this.guna_pie_split_cb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna_pie_split_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna_pie_split_cb.FocusedColor = System.Drawing.Color.Empty;
            this.guna_pie_split_cb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna_pie_split_cb.ForeColor = System.Drawing.Color.Black;
            this.guna_pie_split_cb.FormattingEnabled = true;
            this.guna_pie_split_cb.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.guna_pie_split_cb.Location = new System.Drawing.Point(25, 776);
            this.guna_pie_split_cb.Name = "guna_pie_split_cb";
            this.guna_pie_split_cb.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna_pie_split_cb.OnHoverItemForeColor = System.Drawing.Color.White;
            this.guna_pie_split_cb.Size = new System.Drawing.Size(250, 31);
            this.guna_pie_split_cb.TabIndex = 21;
            this.guna_pie_split_cb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_preset_SelectedIndexChanged);
            // 
            // guna_preset_name
            // 
            this.guna_preset_name.BackColor = System.Drawing.Color.White;
            this.guna_preset_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna_preset_name.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.guna_preset_name.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna_preset_name.ForeColor = System.Drawing.Color.Black;
            this.guna_preset_name.LineColor = System.Drawing.Color.Gainsboro;
            this.guna_preset_name.Location = new System.Drawing.Point(80, 729);
            this.guna_preset_name.Name = "guna_preset_name";
            this.guna_preset_name.PasswordChar = '\0';
            this.guna_preset_name.SelectedText = "";
            this.guna_preset_name.Size = new System.Drawing.Size(195, 30);
            this.guna_preset_name.TabIndex = 22;
            this.guna_preset_name.Text = "이름";
            this.guna_preset_name.Enter += new System.EventHandler(this.guna_preset_name_Enter);
            this.guna_preset_name.Leave += new System.EventHandler(this.guna_preset_name_Leave);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keydownToolStripMenuItem,
            this.RunToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.ColorTable = null;
            this.contextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.contextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.contextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.contextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.contextMenuStrip1.Size = new System.Drawing.Size(174, 52);
            // 
            // keydownToolStripMenuItem
            // 
            this.keydownToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ArrowToolStripMenuItem,
            this.VolumeToolStripMenuItem,
            this.FuncToolStripMenuItem,
            this.SubkeyToolStripMenuItem});
            this.keydownToolStripMenuItem.Name = "keydownToolStripMenuItem";
            this.keydownToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.keydownToolStripMenuItem.Text = "키 입력";
            // 
            // ArrowToolStripMenuItem
            // 
            this.ArrowToolStripMenuItem.Name = "ArrowToolStripMenuItem";
            this.ArrowToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.ArrowToolStripMenuItem.Text = "방향키";
            // 
            // VolumeToolStripMenuItem
            // 
            this.VolumeToolStripMenuItem.Name = "VolumeToolStripMenuItem";
            this.VolumeToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.VolumeToolStripMenuItem.Text = "불륨";
            // 
            // FuncToolStripMenuItem
            // 
            this.FuncToolStripMenuItem.Name = "FuncToolStripMenuItem";
            this.FuncToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.FuncToolStripMenuItem.Text = "펑션";
            // 
            // SubkeyToolStripMenuItem
            // 
            this.SubkeyToolStripMenuItem.Name = "SubkeyToolStripMenuItem";
            this.SubkeyToolStripMenuItem.Size = new System.Drawing.Size(137, 26);
            this.SubkeyToolStripMenuItem.Text = "기능";
            // 
            // RunToolStripMenuItem
            // 
            this.RunToolStripMenuItem.Name = "RunToolStripMenuItem";
            this.RunToolStripMenuItem.Size = new System.Drawing.Size(173, 24);
            this.RunToolStripMenuItem.Text = "프로그램 실행";
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna_preset_name);
            this.Controls.Add(this.guna_pie_split_cb);
            this.Controls.Add(this.guna_comboBox1_preset);
            this.Controls.Add(this.guna_preset_1);
            this.Controls.Add(this.guna_changebtn);
            this.Controls.Add(this.guna_Delbtn);
            this.Controls.Add(this.guna_preset_1_save);
            this.Controls.Add(this.guna_splitbtn);
            this.Controls.Add(this.Name_label);
            this.Name = "Edit";
            this.Size = new System.Drawing.Size(409, 822);
            this.Load += new System.EventHandler(this.Edit_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Edit_Paint);
            this.Enter += new System.EventHandler(this.Edit_Enter);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Guna.UI.WinForms.GunaAdvenceButton guna_splitbtn;
        private Guna.UI.WinForms.GunaAdvenceButton guna_preset_1_save;
        private Guna.UI.WinForms.GunaAdvenceButton guna_Delbtn;
        private Guna.UI.WinForms.GunaAdvenceButton guna_preset_1;
        private Guna.UI.WinForms.GunaAdvenceButton guna_changebtn;
        private Guna.UI.WinForms.GunaComboBox guna_comboBox1_preset;
        private Guna.UI.WinForms.GunaComboBox guna_pie_split_cb;
        private Guna.UI.WinForms.GunaLineTextBox guna_preset_name;
        private Guna.UI.WinForms.GunaContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem keydownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ArrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VolumeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FuncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubkeyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RunToolStripMenuItem;
    }
}
