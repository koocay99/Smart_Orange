namespace Serial_Communication.User_Control
{
    partial class detail_preset
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(detail_preset));
            this.lbAuthor = new Guna.UI.WinForms.GunaLabel();
            this.lbCategory = new Guna.UI.WinForms.GunaLabel();
            this.lbJoin = new Guna.UI.WinForms.GunaLabel();
            this.lbRate = new Guna.UI.WinForms.GunaLabel();
            this.lbEvent = new Guna.UI.WinForms.GunaLabel();
            this.previousbtn = new Guna.UI.WinForms.GunaButton();
            this.tbContext = new System.Windows.Forms.TextBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbNum = new Guna.UI.WinForms.GunaLabel();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.gunaAdvenceButton2 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.BT_delete = new Guna.UI.WinForms.GunaButton();
            this.BT_download = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbAuthor.Location = new System.Drawing.Point(21, 85);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(42, 20);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "저자:";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCategory.Location = new System.Drawing.Point(21, 119);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(72, 20);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "카테고리:";
            // 
            // lbJoin
            // 
            this.lbJoin.AutoSize = true;
            this.lbJoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbJoin.Location = new System.Drawing.Point(21, 153);
            this.lbJoin.Name = "lbJoin";
            this.lbJoin.Size = new System.Drawing.Size(48, 20);
            this.lbJoin.TabIndex = 4;
            this.lbJoin.Text = "lbJoin";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRate.Location = new System.Drawing.Point(368, 103);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(52, 20);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "lbRate";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbEvent.Location = new System.Drawing.Point(30, 184);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(58, 20);
            this.lbEvent.TabIndex = 6;
            this.lbEvent.Text = "lbEvent";
            this.lbEvent.Visible = false;
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
            this.previousbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.previousbtn.Location = new System.Drawing.Point(25, 12);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.previousbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.previousbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.previousbtn.OnHoverImage = null;
            this.previousbtn.OnPressedColor = System.Drawing.Color.Black;
            this.previousbtn.Size = new System.Drawing.Size(124, 33);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "     이전페이지";
            this.previousbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // tbContext
            // 
            this.tbContext.BackColor = System.Drawing.Color.White;
            this.tbContext.Location = new System.Drawing.Point(30, 184);
            this.tbContext.Multiline = true;
            this.tbContext.Name = "tbContext";
            this.tbContext.ReadOnly = true;
            this.tbContext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbContext.Size = new System.Drawing.Size(362, 587);
            this.tbContext.TabIndex = 12;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.Location = new System.Drawing.Point(25, 179);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(372, 598);
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTitle.Location = new System.Drawing.Point(21, 51);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(42, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "제목:";
            // 
            // lbNum
            // 
            this.lbNum.AutoSize = true;
            this.lbNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbNum.Location = new System.Drawing.Point(34, 204);
            this.lbNum.Name = "lbNum";
            this.lbNum.Size = new System.Drawing.Size(54, 20);
            this.lbNum.TabIndex = 16;
            this.lbNum.Text = "lbNum";
            this.lbNum.Visible = false;
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(352, 51);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(45, 45);
            this.gunaAdvenceButton1.TabIndex = 17;
            this.gunaAdvenceButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaAdvenceButton2
            // 
            this.gunaAdvenceButton2.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton2.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton2.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.CheckedImage")));
            this.gunaAdvenceButton2.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton2.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton2.Image")));
            this.gunaAdvenceButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton2.ImageSize = new System.Drawing.Size(40, 40);
            this.gunaAdvenceButton2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.Location = new System.Drawing.Point(352, 130);
            this.gunaAdvenceButton2.Name = "gunaAdvenceButton2";
            this.gunaAdvenceButton2.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton2.OnHoverImage = null;
            this.gunaAdvenceButton2.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton2.Size = new System.Drawing.Size(45, 45);
            this.gunaAdvenceButton2.TabIndex = 18;
            this.gunaAdvenceButton2.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // BT_delete
            // 
            this.BT_delete.AnimationHoverSpeed = 0.07F;
            this.BT_delete.AnimationSpeed = 0.03F;
            this.BT_delete.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_delete.BorderColor = System.Drawing.Color.Black;
            this.BT_delete.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_delete.FocusedColor = System.Drawing.Color.Empty;
            this.BT_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_delete.ForeColor = System.Drawing.Color.White;
            this.BT_delete.Image = ((System.Drawing.Image)(resources.GetObject("BT_delete.Image")));
            this.BT_delete.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_delete.Location = new System.Drawing.Point(25, 786);
            this.BT_delete.Name = "BT_delete";
            this.BT_delete.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_delete.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_delete.OnHoverForeColor = System.Drawing.Color.White;
            this.BT_delete.OnHoverImage = null;
            this.BT_delete.OnPressedColor = System.Drawing.Color.Black;
            this.BT_delete.Size = new System.Drawing.Size(171, 33);
            this.BT_delete.TabIndex = 19;
            this.BT_delete.Text = "삭제";
            this.BT_delete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BT_delete.Visible = false;
            this.BT_delete.Click += new System.EventHandler(this.BT_delete_Click);
            // 
            // BT_download
            // 
            this.BT_download.AnimationHoverSpeed = 0.07F;
            this.BT_download.AnimationSpeed = 0.03F;
            this.BT_download.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_download.BorderColor = System.Drawing.Color.Black;
            this.BT_download.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_download.FocusedColor = System.Drawing.Color.Empty;
            this.BT_download.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_download.ForeColor = System.Drawing.Color.White;
            this.BT_download.Image = ((System.Drawing.Image)(resources.GetObject("BT_download.Image")));
            this.BT_download.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_download.Location = new System.Drawing.Point(226, 786);
            this.BT_download.Name = "BT_download";
            this.BT_download.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_download.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_download.OnHoverForeColor = System.Drawing.Color.White;
            this.BT_download.OnHoverImage = null;
            this.BT_download.OnPressedColor = System.Drawing.Color.Black;
            this.BT_download.Size = new System.Drawing.Size(171, 33);
            this.BT_download.TabIndex = 21;
            this.BT_download.Text = "다운로드";
            this.BT_download.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BT_download.Click += new System.EventHandler(this.BT_download_Click);
            // 
            // detail_preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BT_download);
            this.Controls.Add(this.BT_delete);
            this.Controls.Add(this.gunaAdvenceButton2);
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.lbNum);
            this.Controls.Add(this.tbContext);
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbJoin);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gunaPictureBox1);
            this.Name = "detail_preset";
            this.Size = new System.Drawing.Size(420, 822);
            this.Load += new System.EventHandler(this.detail_preset_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Edit_Paint);
            this.Enter += new System.EventHandler(this.detail_preset_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbAuthor;
        private Guna.UI.WinForms.GunaLabel lbCategory;
        private Guna.UI.WinForms.GunaLabel lbJoin;
        private Guna.UI.WinForms.GunaLabel lbRate;
        private Guna.UI.WinForms.GunaLabel lbEvent;
        private Guna.UI.WinForms.GunaButton previousbtn;
        private System.Windows.Forms.TextBox tbContext;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaLabel lbNum;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton2;
        public Guna.UI.WinForms.GunaButton BT_delete;
        public Guna.UI.WinForms.GunaButton BT_download;
    }
}
