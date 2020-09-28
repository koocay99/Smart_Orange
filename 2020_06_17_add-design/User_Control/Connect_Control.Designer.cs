namespace Serial_Communication.User_Control
{
    partial class Connect_Control
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
            this.components = new System.ComponentModel.Container();
            this.button_send = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.comboBox_preset = new Guna.UI.WinForms.GunaComboBox();
            this.textBox_send = new Guna.UI.WinForms.GunaTextBox();
            this.richTextBox_received = new System.Windows.Forms.RichTextBox();
            this.label_status = new Guna.UI.WinForms.GunaLabel();
            this.preset_1 = new Guna.UI.WinForms.GunaButton();
            this.button_connect = new Guna.UI.WinForms.GunaButton();
            this.button_disconnect = new Guna.UI.WinForms.GunaButton();
            this.button1 = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.comboBox_port = new Guna.UI.WinForms.GunaComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // button_send
            // 
            this.button_send.AnimationHoverSpeed = 0.07F;
            this.button_send.AnimationSpeed = 0.03F;
            this.button_send.BackColor = System.Drawing.Color.Transparent;
            this.button_send.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_send.BorderColor = System.Drawing.Color.Black;
            this.button_send.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_send.FocusedColor = System.Drawing.Color.Empty;
            this.button_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_send.ForeColor = System.Drawing.Color.White;
            this.button_send.Image = null;
            this.button_send.ImageSize = new System.Drawing.Size(20, 20);
            this.button_send.Location = new System.Drawing.Point(295, 596);
            this.button_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send.Name = "button_send";
            this.button_send.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_send.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_send.OnHoverForeColor = System.Drawing.Color.White;
            this.button_send.OnHoverImage = null;
            this.button_send.OnPressedColor = System.Drawing.Color.Black;
            this.button_send.Radius = 16;
            this.button_send.Size = new System.Drawing.Size(93, 42);
            this.button_send.TabIndex = 0;
            this.button_send.Text = "보내기";
            this.button_send.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_send.Click += new System.EventHandler(this.Button_send_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(21, 268);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(39, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "수신";
            // 
            // comboBox_preset
            // 
            this.comboBox_preset.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_preset.BaseColor = System.Drawing.Color.White;
            this.comboBox_preset.BorderColor = System.Drawing.Color.Silver;
            this.comboBox_preset.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_preset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_preset.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox_preset.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_preset.ForeColor = System.Drawing.Color.Black;
            this.comboBox_preset.FormattingEnabled = true;
            this.comboBox_preset.Location = new System.Drawing.Point(25, 698);
            this.comboBox_preset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_preset.Name = "comboBox_preset";
            this.comboBox_preset.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBox_preset.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBox_preset.Size = new System.Drawing.Size(249, 31);
            this.comboBox_preset.TabIndex = 2;
            // 
            // textBox_send
            // 
            this.textBox_send.BaseColor = System.Drawing.Color.White;
            this.textBox_send.BorderColor = System.Drawing.Color.Silver;
            this.textBox_send.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_send.FocusedBaseColor = System.Drawing.Color.White;
            this.textBox_send.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textBox_send.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textBox_send.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox_send.Location = new System.Drawing.Point(25, 596);
            this.textBox_send.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.PasswordChar = '\0';
            this.textBox_send.SelectedText = "";
            this.textBox_send.Size = new System.Drawing.Size(249, 42);
            this.textBox_send.TabIndex = 3;
            // 
            // richTextBox_received
            // 
            this.richTextBox_received.Location = new System.Drawing.Point(25, 290);
            this.richTextBox_received.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextBox_received.Name = "richTextBox_received";
            this.richTextBox_received.ReadOnly = true;
            this.richTextBox_received.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox_received.Size = new System.Drawing.Size(363, 248);
            this.richTextBox_received.TabIndex = 4;
            this.richTextBox_received.Text = "";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label_status.Location = new System.Drawing.Point(21, 235);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(69, 20);
            this.label_status.TabIndex = 1;
            this.label_status.Text = "연결상태";
            // 
            // preset_1
            // 
            this.preset_1.AnimationHoverSpeed = 0.07F;
            this.preset_1.AnimationSpeed = 0.03F;
            this.preset_1.BackColor = System.Drawing.Color.Transparent;
            this.preset_1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.preset_1.BorderColor = System.Drawing.Color.Black;
            this.preset_1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.preset_1.FocusedColor = System.Drawing.Color.Empty;
            this.preset_1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.preset_1.ForeColor = System.Drawing.Color.White;
            this.preset_1.Image = null;
            this.preset_1.ImageSize = new System.Drawing.Size(20, 20);
            this.preset_1.Location = new System.Drawing.Point(295, 690);
            this.preset_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preset_1.Name = "preset_1";
            this.preset_1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.preset_1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.preset_1.OnHoverForeColor = System.Drawing.Color.White;
            this.preset_1.OnHoverImage = null;
            this.preset_1.OnPressedColor = System.Drawing.Color.Black;
            this.preset_1.Radius = 16;
            this.preset_1.Size = new System.Drawing.Size(93, 42);
            this.preset_1.TabIndex = 0;
            this.preset_1.Text = "불러오기";
            this.preset_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.preset_1.Click += new System.EventHandler(this.preset_1_Click);
            // 
            // button_connect
            // 
            this.button_connect.AnimationHoverSpeed = 0.07F;
            this.button_connect.AnimationSpeed = 0.03F;
            this.button_connect.BackColor = System.Drawing.Color.Transparent;
            this.button_connect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_connect.BorderColor = System.Drawing.Color.Black;
            this.button_connect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_connect.FocusedColor = System.Drawing.Color.Empty;
            this.button_connect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_connect.ForeColor = System.Drawing.Color.White;
            this.button_connect.Image = null;
            this.button_connect.ImageSize = new System.Drawing.Size(20, 20);
            this.button_connect.Location = new System.Drawing.Point(25, 132);
            this.button_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_connect.Name = "button_connect";
            this.button_connect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_connect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_connect.OnHoverForeColor = System.Drawing.Color.White;
            this.button_connect.OnHoverImage = null;
            this.button_connect.OnPressedColor = System.Drawing.Color.Black;
            this.button_connect.Radius = 16;
            this.button_connect.Size = new System.Drawing.Size(118, 64);
            this.button_connect.TabIndex = 5;
            this.button_connect.Text = "연결하기";
            this.button_connect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_connect.Click += new System.EventHandler(this.Button_connect_Click);
            // 
            // button_disconnect
            // 
            this.button_disconnect.AnimationHoverSpeed = 0.07F;
            this.button_disconnect.AnimationSpeed = 0.03F;
            this.button_disconnect.BackColor = System.Drawing.Color.Transparent;
            this.button_disconnect.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_disconnect.BorderColor = System.Drawing.Color.Black;
            this.button_disconnect.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button_disconnect.FocusedColor = System.Drawing.Color.Empty;
            this.button_disconnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button_disconnect.ForeColor = System.Drawing.Color.White;
            this.button_disconnect.Image = null;
            this.button_disconnect.ImageSize = new System.Drawing.Size(20, 20);
            this.button_disconnect.Location = new System.Drawing.Point(155, 132);
            this.button_disconnect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_disconnect.Name = "button_disconnect";
            this.button_disconnect.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button_disconnect.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button_disconnect.OnHoverForeColor = System.Drawing.Color.White;
            this.button_disconnect.OnHoverImage = null;
            this.button_disconnect.OnPressedColor = System.Drawing.Color.Black;
            this.button_disconnect.Radius = 16;
            this.button_disconnect.Size = new System.Drawing.Size(118, 64);
            this.button_disconnect.TabIndex = 6;
            this.button_disconnect.Text = "연결끊기";
            this.button_disconnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button_disconnect.Click += new System.EventHandler(this.Button_disconnect_Click);
            // 
            // button1
            // 
            this.button1.AnimationHoverSpeed = 0.07F;
            this.button1.AnimationSpeed = 0.03F;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button1.BorderColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.button1.FocusedColor = System.Drawing.Color.Empty;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = null;
            this.button1.ImageSize = new System.Drawing.Size(20, 20);
            this.button1.Location = new System.Drawing.Point(295, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(150)))), ((int)(((byte)(73)))));
            this.button1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.button1.OnHoverForeColor = System.Drawing.Color.White;
            this.button1.OnHoverImage = null;
            this.button1.OnPressedColor = System.Drawing.Color.Black;
            this.button1.Radius = 16;
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 7;
            this.button1.Text = "로그아웃";
            this.button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(21, 48);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(110, 20);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "COM 포트 설정";
            // 
            // comboBox_port
            // 
            this.comboBox_port.BackColor = System.Drawing.Color.Transparent;
            this.comboBox_port.BaseColor = System.Drawing.Color.White;
            this.comboBox_port.BorderColor = System.Drawing.Color.Silver;
            this.comboBox_port.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBox_port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_port.FocusedColor = System.Drawing.Color.Empty;
            this.comboBox_port.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBox_port.ForeColor = System.Drawing.Color.Black;
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(25, 72);
            this.comboBox_port.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.comboBox_port.OnHoverItemForeColor = System.Drawing.Color.White;
            this.comboBox_port.Size = new System.Drawing.Size(249, 31);
            this.comboBox_port.TabIndex = 9;
            // 
            // Connect_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.comboBox_port);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_disconnect);
            this.Controls.Add(this.button_connect);
            this.Controls.Add(this.richTextBox_received);
            this.Controls.Add(this.textBox_send);
            this.Controls.Add(this.comboBox_preset);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.preset_1);
            this.Controls.Add(this.button_send);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Connect_Control";
            this.Size = new System.Drawing.Size(409, 822);
            this.Load += new System.EventHandler(this.Connect_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton button_send;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox comboBox_preset;
        private Guna.UI.WinForms.GunaTextBox textBox_send;
        private System.Windows.Forms.RichTextBox richTextBox_received;
        private Guna.UI.WinForms.GunaLabel label_status;
        private Guna.UI.WinForms.GunaButton preset_1;
        private Guna.UI.WinForms.GunaButton button_connect;
        private Guna.UI.WinForms.GunaButton button_disconnect;
        private Guna.UI.WinForms.GunaButton button1;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox comboBox_port;
        private System.IO.Ports.SerialPort serialPort1;
    }
}
