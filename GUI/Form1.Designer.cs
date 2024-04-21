namespace GUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LogoPic = new System.Windows.Forms.PictureBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.linkForgetPass = new System.Windows.Forms.LinkLabel();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.grbMK = new System.Windows.Forms.GroupBox();
            this.ShowPassWord = new System.Windows.Forms.PictureBox();
            this.ClosePassWord = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.grbTK = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.lbLogin = new System.Windows.Forms.Label();
            this.Slogan = new System.Windows.Forms.Label();
            this.timerLogo = new System.Windows.Forms.Timer(this.components);
            this.lbWelcome = new System.Windows.Forms.Label();
            this.timerWelcomeLine = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            this.LoginPanel.SuspendLayout();
            this.grbMK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.grbTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoPic
            // 
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(98, 37);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.Size = new System.Drawing.Size(413, 362);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.White;
            this.LoginPanel.Controls.Add(this.linkForgetPass);
            this.LoginPanel.Controls.Add(this.btnDangNhap);
            this.LoginPanel.Controls.Add(this.grbMK);
            this.LoginPanel.Controls.Add(this.grbTK);
            this.LoginPanel.Controls.Add(this.lbLogin);
            this.LoginPanel.Location = new System.Drawing.Point(575, 81);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(386, 374);
            this.LoginPanel.TabIndex = 1;
            // 
            // linkForgetPass
            // 
            this.linkForgetPass.AutoSize = true;
            this.linkForgetPass.Location = new System.Drawing.Point(28, 256);
            this.linkForgetPass.Name = "linkForgetPass";
            this.linkForgetPass.Size = new System.Drawing.Size(96, 16);
            this.linkForgetPass.TabIndex = 4;
            this.linkForgetPass.TabStop = true;
            this.linkForgetPass.Text = "Quên mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.Location = new System.Drawing.Point(28, 297);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(331, 51);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // grbMK
            // 
            this.grbMK.Controls.Add(this.ShowPassWord);
            this.grbMK.Controls.Add(this.ClosePassWord);
            this.grbMK.Controls.Add(this.pictureBox3);
            this.grbMK.Controls.Add(this.txtMK);
            this.grbMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMK.Location = new System.Drawing.Point(28, 174);
            this.grbMK.Name = "grbMK";
            this.grbMK.Size = new System.Drawing.Size(331, 75);
            this.grbMK.TabIndex = 2;
            this.grbMK.TabStop = false;
            this.grbMK.Text = "Mật khẩu";
            // 
            // ShowPassWord
            // 
            this.ShowPassWord.Image = ((System.Drawing.Image)(resources.GetObject("ShowPassWord.Image")));
            this.ShowPassWord.Location = new System.Drawing.Point(300, 33);
            this.ShowPassWord.Name = "ShowPassWord";
            this.ShowPassWord.Size = new System.Drawing.Size(20, 20);
            this.ShowPassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ShowPassWord.TabIndex = 4;
            this.ShowPassWord.TabStop = false;
            this.ShowPassWord.Click += new System.EventHandler(this.ShowPassWord_Click);
            // 
            // ClosePassWord
            // 
            this.ClosePassWord.Image = ((System.Drawing.Image)(resources.GetObject("ClosePassWord.Image")));
            this.ClosePassWord.Location = new System.Drawing.Point(300, 33);
            this.ClosePassWord.Name = "ClosePassWord";
            this.ClosePassWord.Size = new System.Drawing.Size(20, 20);
            this.ClosePassWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePassWord.TabIndex = 3;
            this.ClosePassWord.TabStop = false;
            this.ClosePassWord.Click += new System.EventHandler(this.ClosePassWord_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(7, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // txtMK
            // 
            this.txtMK.Location = new System.Drawing.Point(59, 24);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(266, 39);
            this.txtMK.TabIndex = 0;
            // 
            // grbTK
            // 
            this.grbTK.Controls.Add(this.pictureBox2);
            this.grbTK.Controls.Add(this.txtTK);
            this.grbTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTK.Location = new System.Drawing.Point(28, 76);
            this.grbTK.Name = "grbTK";
            this.grbTK.Size = new System.Drawing.Size(331, 77);
            this.grbTK.TabIndex = 1;
            this.grbTK.TabStop = false;
            this.grbTK.Text = "Tài khoản";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(7, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 47);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(59, 24);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(266, 47);
            this.txtTK.TabIndex = 0;
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(23, 21);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(129, 29);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Đăng nhập";
            // 
            // Slogan
            // 
            this.Slogan.AutoSize = true;
            this.Slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slogan.ForeColor = System.Drawing.Color.White;
            this.Slogan.Location = new System.Drawing.Point(164, 365);
            this.Slogan.Name = "Slogan";
            this.Slogan.Size = new System.Drawing.Size(280, 64);
            this.Slogan.TabIndex = 2;
            this.Slogan.Text = "Không biết dùng csdl\r\nTôi yêu alime";
            this.Slogan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerLogo
            // 
            this.timerLogo.Interval = 40;
            this.timerLogo.Tick += new System.EventHandler(this.timerLogo_Tick);
            // 
            // lbWelcome
            // 
            this.lbWelcome.AutoSize = true;
            this.lbWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWelcome.ForeColor = System.Drawing.Color.White;
            this.lbWelcome.Location = new System.Drawing.Point(330, 458);
            this.lbWelcome.Name = "lbWelcome";
            this.lbWelcome.Size = new System.Drawing.Size(369, 58);
            this.lbWelcome.TabIndex = 3;
            this.lbWelcome.Text = "Chào mừng bạn đến với chúng tôi\r\nChúc bạn có một ngày tốt lành..";
            this.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbWelcome.Click += new System.EventHandler(this.lbWelcome_Click);
            // 
            // timerWelcomeLine
            // 
            this.timerWelcomeLine.Interval = 70;
            this.timerWelcomeLine.Tick += new System.EventHandler(this.timerWelcomeLine_Tick);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(191)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1069, 529);
            this.Controls.Add(this.lbWelcome);
            this.Controls.Add(this.Slogan);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.LogoPic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.grbMK.ResumeLayout(false);
            this.grbMK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.grbTK.ResumeLayout(false);
            this.grbTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LogoPic;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.GroupBox grbMK;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.GroupBox grbTK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label Slogan;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ShowPassWord;
        private System.Windows.Forms.PictureBox ClosePassWord;
        private System.Windows.Forms.Timer timerLogo;
        private System.Windows.Forms.LinkLabel linkForgetPass;
        private System.Windows.Forms.Label lbWelcome;
        private System.Windows.Forms.Timer timerWelcomeLine;
    }
}

