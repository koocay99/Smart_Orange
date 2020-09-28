namespace Serial_Communication.User_Control
{
    partial class user_preset
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
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbAuthor = new Guna.UI.WinForms.GunaLabel();
            this.lbRate = new Guna.UI.WinForms.GunaLabel();
            this.lbJoin = new Guna.UI.WinForms.GunaLabel();
            this.lbCategory = new Guna.UI.WinForms.GunaLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTitle.Location = new System.Drawing.Point(17, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(86, 20);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "gunaLabel1";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbAuthor.Location = new System.Drawing.Point(196, 49);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(86, 20);
            this.lbAuthor.TabIndex = 0;
            this.lbAuthor.Text = "gunaLabel1";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRate.Location = new System.Drawing.Point(61, 141);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(86, 20);
            this.lbRate.TabIndex = 0;
            this.lbRate.Text = "gunaLabel1";
            // 
            // lbJoin
            // 
            this.lbJoin.AutoSize = true;
            this.lbJoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbJoin.Location = new System.Drawing.Point(253, 141);
            this.lbJoin.Name = "lbJoin";
            this.lbJoin.Size = new System.Drawing.Size(86, 20);
            this.lbJoin.TabIndex = 0;
            this.lbJoin.Text = "gunaLabel1";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCategory.Location = new System.Drawing.Point(196, 95);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(86, 20);
            this.lbCategory.TabIndex = 0;
            this.lbCategory.Text = "gunaLabel1";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.gunaPictureBox1.Location = new System.Drawing.Point(80, 0);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(230, 2);
            this.gunaPictureBox1.TabIndex = 1;
            this.gunaPictureBox1.TabStop = false;
            // 
            // user_preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gunaPictureBox1);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbJoin);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Name = "user_preset";
            this.Size = new System.Drawing.Size(390, 180);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaLabel lbAuthor;
        private Guna.UI.WinForms.GunaLabel lbRate;
        private Guna.UI.WinForms.GunaLabel lbJoin;
        private Guna.UI.WinForms.GunaLabel lbCategory;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
    }
}
