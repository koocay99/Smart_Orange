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
            this.tbContext = new Guna.UI.WinForms.GunaTextBox();
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbAuthor = new Guna.UI.WinForms.GunaLabel();
            this.lbCategory = new Guna.UI.WinForms.GunaLabel();
            this.lbJoin = new Guna.UI.WinForms.GunaLabel();
            this.lbRate = new Guna.UI.WinForms.GunaLabel();
            this.lbEvent = new Guna.UI.WinForms.GunaLabel();
            this.previousbtn = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // tbContext
            // 
            this.tbContext.BaseColor = System.Drawing.Color.White;
            this.tbContext.BorderColor = System.Drawing.Color.Silver;
            this.tbContext.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbContext.FocusedBaseColor = System.Drawing.Color.White;
            this.tbContext.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.tbContext.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbContext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbContext.Location = new System.Drawing.Point(26, 184);
            this.tbContext.Name = "tbContext";
            this.tbContext.PasswordChar = '\0';
            this.tbContext.SelectedText = "";
            this.tbContext.Size = new System.Drawing.Size(368, 573);
            this.tbContext.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbTitle.Location = new System.Drawing.Point(22, 17);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(51, 20);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "lbTitle";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbAuthor.Location = new System.Drawing.Point(22, 64);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(67, 20);
            this.lbAuthor.TabIndex = 2;
            this.lbAuthor.Text = "lbAuthor";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbCategory.Location = new System.Drawing.Point(220, 64);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(82, 20);
            this.lbCategory.TabIndex = 3;
            this.lbCategory.Text = "lbCategory";
            // 
            // lbJoin
            // 
            this.lbJoin.AutoSize = true;
            this.lbJoin.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbJoin.Location = new System.Drawing.Point(114, 790);
            this.lbJoin.Name = "lbJoin";
            this.lbJoin.Size = new System.Drawing.Size(48, 20);
            this.lbJoin.TabIndex = 4;
            this.lbJoin.Text = "lbJoin";
            // 
            // lbRate
            // 
            this.lbRate.AutoSize = true;
            this.lbRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbRate.Location = new System.Drawing.Point(22, 790);
            this.lbRate.Name = "lbRate";
            this.lbRate.Size = new System.Drawing.Size(52, 20);
            this.lbRate.TabIndex = 5;
            this.lbRate.Text = "lbRate";
            // 
            // lbEvent
            // 
            this.lbEvent.AutoSize = true;
            this.lbEvent.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbEvent.Location = new System.Drawing.Point(22, 122);
            this.lbEvent.Name = "lbEvent";
            this.lbEvent.Size = new System.Drawing.Size(58, 20);
            this.lbEvent.TabIndex = 6;
            this.lbEvent.Text = "lbEvent";
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
            this.previousbtn.Image = null;
            this.previousbtn.ImageSize = new System.Drawing.Size(20, 20);
            this.previousbtn.Location = new System.Drawing.Point(253, 790);
            this.previousbtn.Name = "previousbtn";
            this.previousbtn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.previousbtn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.previousbtn.OnHoverForeColor = System.Drawing.Color.White;
            this.previousbtn.OnHoverImage = null;
            this.previousbtn.OnPressedColor = System.Drawing.Color.Black;
            this.previousbtn.Size = new System.Drawing.Size(141, 20);
            this.previousbtn.TabIndex = 7;
            this.previousbtn.Text = "이전페이지";
            this.previousbtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.previousbtn.Click += new System.EventHandler(this.previousbtn_Click);
            // 
            // detail_preset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.previousbtn);
            this.Controls.Add(this.lbEvent);
            this.Controls.Add(this.lbRate);
            this.Controls.Add(this.lbJoin);
            this.Controls.Add(this.lbCategory);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.tbContext);
            this.Name = "detail_preset";
            this.Size = new System.Drawing.Size(420, 822);
            this.Load += new System.EventHandler(this.detail_preset_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaTextBox tbContext;
        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaLabel lbAuthor;
        private Guna.UI.WinForms.GunaLabel lbCategory;
        private Guna.UI.WinForms.GunaLabel lbJoin;
        private Guna.UI.WinForms.GunaLabel lbRate;
        private Guna.UI.WinForms.GunaLabel lbEvent;
        private Guna.UI.WinForms.GunaButton previousbtn;
    }
}
