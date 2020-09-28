namespace Serial_Communication.User_Control
{
    partial class community
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(community));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbPage = new System.Windows.Forms.Label();
            this.gunaButton3 = new Guna.UI.WinForms.GunaButton();
            this.gunaButton2 = new Guna.UI.WinForms.GunaButton();
            this.write_btn = new Guna.UI.WinForms.GunaButton();
            this.blinder_pb = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.BT_sort = new Guna.UI.WinForms.GunaButton();
            this.gunaContextMenuStrip1 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.추천수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.조회수ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.최신순ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_search = new Guna.UI.WinForms.GunaButton();
            this.TB_search = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaContextMenuStrip2 = new Guna.UI.WinForms.GunaContextMenuStrip();
            this.제목ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.내용ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.카테고리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchlist = new Guna.UI.WinForms.GunaAdvenceButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blinder_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaContextMenuStrip1.SuspendLayout();
            this.gunaContextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.lbPage);
            this.panel1.Controls.Add(this.gunaButton3);
            this.panel1.Controls.Add(this.gunaButton2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 822);
            this.panel1.TabIndex = 0;
            // 
            // lbPage
            // 
            this.lbPage.AutoSize = true;
            this.lbPage.Location = new System.Drawing.Point(185, 776);
            this.lbPage.Name = "lbPage";
            this.lbPage.Size = new System.Drawing.Size(45, 15);
            this.lbPage.TabIndex = 2;
            this.lbPage.Text = "label1";
            // 
            // gunaButton3
            // 
            this.gunaButton3.AnimationHoverSpeed = 0.07F;
            this.gunaButton3.AnimationSpeed = 0.03F;
            this.gunaButton3.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaButton3.BorderColor = System.Drawing.Color.Black;
            this.gunaButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton3.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton3.ForeColor = System.Drawing.Color.White;
            this.gunaButton3.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton3.Image")));
            this.gunaButton3.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton3.Location = new System.Drawing.Point(27, 765);
            this.gunaButton3.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton3.Name = "gunaButton3";
            this.gunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaButton3.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton3.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton3.OnHoverImage = null;
            this.gunaButton3.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton3.Radius = 7;
            this.gunaButton3.Size = new System.Drawing.Size(128, 35);
            this.gunaButton3.TabIndex = 1;
            this.gunaButton3.Text = "이전 페이지";
            this.gunaButton3.Click += new System.EventHandler(this.gunaButton3_Click);
            // 
            // gunaButton2
            // 
            this.gunaButton2.AnimationHoverSpeed = 0.07F;
            this.gunaButton2.AnimationSpeed = 0.03F;
            this.gunaButton2.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaButton2.BorderColor = System.Drawing.Color.Black;
            this.gunaButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton2.ForeColor = System.Drawing.Color.White;
            this.gunaButton2.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton2.Image")));
            this.gunaButton2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gunaButton2.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton2.Location = new System.Drawing.Point(264, 765);
            this.gunaButton2.Margin = new System.Windows.Forms.Padding(2);
            this.gunaButton2.Name = "gunaButton2";
            this.gunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaButton2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton2.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton2.OnHoverImage = null;
            this.gunaButton2.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton2.Radius = 7;
            this.gunaButton2.Size = new System.Drawing.Size(128, 35);
            this.gunaButton2.TabIndex = 0;
            this.gunaButton2.Text = "다음 페이지";
            this.gunaButton2.Click += new System.EventHandler(this.gunaButton2_Click);
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
            this.write_btn.Location = new System.Drawing.Point(164, 4);
            this.write_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.write_btn.Name = "write_btn";
            this.write_btn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(138)))), ((int)(((byte)(54)))));
            this.write_btn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.write_btn.OnHoverForeColor = System.Drawing.Color.White;
            this.write_btn.OnHoverImage = null;
            this.write_btn.OnPressedColor = System.Drawing.Color.Black;
            this.write_btn.Size = new System.Drawing.Size(75, 42);
            this.write_btn.TabIndex = 8;
            this.write_btn.Text = "새로고침";
            this.write_btn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.write_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // blinder_pb
            // 
            this.blinder_pb.BackColor = System.Drawing.Color.White;
            this.blinder_pb.BaseColor = System.Drawing.Color.White;
            this.blinder_pb.Location = new System.Drawing.Point(0, 0);
            this.blinder_pb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.blinder_pb.Name = "blinder_pb";
            this.blinder_pb.Size = new System.Drawing.Size(392, 50);
            this.blinder_pb.TabIndex = 9;
            this.blinder_pb.TabStop = false;
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.White;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Location = new System.Drawing.Point(0, 50);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(392, 50);
            this.gunaPictureBox1.TabIndex = 10;
            this.gunaPictureBox1.TabStop = false;
            // 
            // BT_sort
            // 
            this.BT_sort.AnimationHoverSpeed = 0.07F;
            this.BT_sort.AnimationSpeed = 0.03F;
            this.BT_sort.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_sort.BorderColor = System.Drawing.Color.Black;
            this.BT_sort.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_sort.FocusedColor = System.Drawing.Color.Empty;
            this.BT_sort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_sort.ForeColor = System.Drawing.Color.White;
            this.BT_sort.Image = null;
            this.BT_sort.ImageSize = new System.Drawing.Size(20, 20);
            this.BT_sort.Location = new System.Drawing.Point(313, 54);
            this.BT_sort.Name = "BT_sort";
            this.BT_sort.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.BT_sort.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_sort.OnHoverForeColor = System.Drawing.Color.White;
            this.BT_sort.OnHoverImage = null;
            this.BT_sort.OnPressedColor = System.Drawing.Color.Black;
            this.BT_sort.Size = new System.Drawing.Size(75, 42);
            this.BT_sort.TabIndex = 11;
            this.BT_sort.Text = "정렬";
            this.BT_sort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BT_sort.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaContextMenuStrip1
            // 
            this.gunaContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추천수ToolStripMenuItem,
            this.조회수ToolStripMenuItem,
            this.최신순ToolStripMenuItem});
            this.gunaContextMenuStrip1.Name = "gunaContextMenuStrip1";
            this.gunaContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip1.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip1.Size = new System.Drawing.Size(124, 76);
            // 
            // 추천수ToolStripMenuItem
            // 
            this.추천수ToolStripMenuItem.Name = "추천수ToolStripMenuItem";
            this.추천수ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.추천수ToolStripMenuItem.Text = "추천수";
            this.추천수ToolStripMenuItem.Click += new System.EventHandler(this.추천수ToolStripMenuItem_Click);
            // 
            // 조회수ToolStripMenuItem
            // 
            this.조회수ToolStripMenuItem.Name = "조회수ToolStripMenuItem";
            this.조회수ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.조회수ToolStripMenuItem.Text = "조회수";
            this.조회수ToolStripMenuItem.Click += new System.EventHandler(this.조회수ToolStripMenuItem_Click);
            // 
            // 최신순ToolStripMenuItem
            // 
            this.최신순ToolStripMenuItem.Name = "최신순ToolStripMenuItem";
            this.최신순ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.최신순ToolStripMenuItem.Text = "최신순";
            this.최신순ToolStripMenuItem.Click += new System.EventHandler(this.최신순ToolStripMenuItem_Click);
            // 
            // BT_search
            // 
            this.BT_search.AnimationHoverSpeed = 0.07F;
            this.BT_search.AnimationSpeed = 0.03F;
            this.BT_search.BaseColor = System.Drawing.Color.Transparent;
            this.BT_search.BorderColor = System.Drawing.Color.Black;
            this.BT_search.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BT_search.FocusedColor = System.Drawing.Color.Empty;
            this.BT_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BT_search.ForeColor = System.Drawing.Color.White;
            this.BT_search.Image = ((System.Drawing.Image)(resources.GetObject("BT_search.Image")));
            this.BT_search.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BT_search.ImageSize = new System.Drawing.Size(30, 30);
            this.BT_search.Location = new System.Drawing.Point(265, 54);
            this.BT_search.Name = "BT_search";
            this.BT_search.OnHoverBaseColor = System.Drawing.Color.White;
            this.BT_search.OnHoverBorderColor = System.Drawing.Color.Black;
            this.BT_search.OnHoverForeColor = System.Drawing.Color.White;
            this.BT_search.OnHoverImage = null;
            this.BT_search.OnPressedColor = System.Drawing.Color.Black;
            this.BT_search.Size = new System.Drawing.Size(42, 42);
            this.BT_search.TabIndex = 2;
            this.BT_search.Click += new System.EventHandler(this.BT_search_Click);
            // 
            // TB_search
            // 
            this.TB_search.BackColor = System.Drawing.Color.White;
            this.TB_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TB_search.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.TB_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TB_search.LineColor = System.Drawing.Color.Gainsboro;
            this.TB_search.Location = new System.Drawing.Point(3, 55);
            this.TB_search.Name = "TB_search";
            this.TB_search.PasswordChar = '\0';
            this.TB_search.SelectedText = "";
            this.TB_search.Size = new System.Drawing.Size(198, 41);
            this.TB_search.TabIndex = 3;
            // 
            // gunaContextMenuStrip2
            // 
            this.gunaContextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.gunaContextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.제목ToolStripMenuItem,
            this.내용ToolStripMenuItem,
            this.카테고리ToolStripMenuItem});
            this.gunaContextMenuStrip2.Name = "gunaContextMenuStrip2";
            this.gunaContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.ColorTable = null;
            this.gunaContextMenuStrip2.RenderStyle.RoundedEdges = true;
            this.gunaContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gunaContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaContextMenuStrip2.RenderStyle.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.SystemDefault;
            this.gunaContextMenuStrip2.Size = new System.Drawing.Size(211, 104);
            // 
            // 제목ToolStripMenuItem
            // 
            this.제목ToolStripMenuItem.Name = "제목ToolStripMenuItem";
            this.제목ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.제목ToolStripMenuItem.Text = "제목";
            this.제목ToolStripMenuItem.Click += new System.EventHandler(this.제목ToolStripMenuItem_Click);
            // 
            // 내용ToolStripMenuItem
            // 
            this.내용ToolStripMenuItem.Name = "내용ToolStripMenuItem";
            this.내용ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.내용ToolStripMenuItem.Text = "내용";
            this.내용ToolStripMenuItem.Click += new System.EventHandler(this.내용ToolStripMenuItem_Click);
            // 
            // 카테고리ToolStripMenuItem
            // 
            this.카테고리ToolStripMenuItem.Name = "카테고리ToolStripMenuItem";
            this.카테고리ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.카테고리ToolStripMenuItem.Text = "카테고리";
            this.카테고리ToolStripMenuItem.Click += new System.EventHandler(this.카테고리ToolStripMenuItem_Click);
            // 
            // searchlist
            // 
            this.searchlist.AnimationHoverSpeed = 0.07F;
            this.searchlist.AnimationSpeed = 0.03F;
            this.searchlist.BackColor = System.Drawing.Color.Transparent;
            this.searchlist.BaseColor = System.Drawing.Color.Transparent;
            this.searchlist.BorderColor = System.Drawing.Color.Black;
            this.searchlist.CheckedBaseColor = System.Drawing.Color.Gray;
            this.searchlist.CheckedBorderColor = System.Drawing.Color.Black;
            this.searchlist.CheckedForeColor = System.Drawing.Color.White;
            this.searchlist.CheckedImage = ((System.Drawing.Image)(resources.GetObject("searchlist.CheckedImage")));
            this.searchlist.CheckedLineColor = System.Drawing.Color.DimGray;
            this.searchlist.DialogResult = System.Windows.Forms.DialogResult.None;
            this.searchlist.FocusedColor = System.Drawing.Color.Empty;
            this.searchlist.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchlist.ForeColor = System.Drawing.Color.White;
            this.searchlist.Image = ((System.Drawing.Image)(resources.GetObject("searchlist.Image")));
            this.searchlist.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.searchlist.ImageSize = new System.Drawing.Size(20, 20);
            this.searchlist.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchlist.Location = new System.Drawing.Point(217, 54);
            this.searchlist.Name = "searchlist";
            this.searchlist.OnHoverBaseColor = System.Drawing.Color.White;
            this.searchlist.OnHoverBorderColor = System.Drawing.Color.Black;
            this.searchlist.OnHoverForeColor = System.Drawing.Color.White;
            this.searchlist.OnHoverImage = null;
            this.searchlist.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.searchlist.OnPressedColor = System.Drawing.Color.Black;
            this.searchlist.Size = new System.Drawing.Size(42, 42);
            this.searchlist.TabIndex = 2;
            this.searchlist.Click += new System.EventHandler(this.gunaAdvenceButton1_Click);
            // 
            // community
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.searchlist);
            this.Controls.Add(this.BT_search);
            this.Controls.Add(this.TB_search);
            this.Controls.Add(this.BT_sort);
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.write_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.blinder_pb);
            this.Name = "community";
            this.Size = new System.Drawing.Size(420, 822);
            this.Load += new System.EventHandler(this.community_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blinder_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaContextMenuStrip1.ResumeLayout(false);
            this.gunaContextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Guna.UI.WinForms.GunaButton write_btn;
        public System.Windows.Forms.Panel panel1;
        public Guna.UI.WinForms.GunaPictureBox blinder_pb;
        public Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 추천수ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 조회수ToolStripMenuItem;
        public Guna.UI.WinForms.GunaButton BT_sort;
        private Guna.UI.WinForms.GunaButton gunaButton2;
        private Guna.UI.WinForms.GunaButton gunaButton3;
        private Guna.UI.WinForms.GunaContextMenuStrip gunaContextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 제목ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 내용ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 카테고리ToolStripMenuItem;
        private System.Windows.Forms.Label lbPage;
        public System.Windows.Forms.ToolStripMenuItem 최신순ToolStripMenuItem;
        public Guna.UI.WinForms.GunaLineTextBox TB_search;
        public Guna.UI.WinForms.GunaButton BT_search;
        public Guna.UI.WinForms.GunaAdvenceButton searchlist;
    }
}
