namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMcesRecoLogo = new System.Windows.Forms.Button();
            this.errUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.picFaultTrackingLogo = new System.Windows.Forms.PictureBox();
            this.pnlHorizonal = new System.Windows.Forms.Panel();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.pnlHorizonal2 = new System.Windows.Forms.Panel();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.picTwitter = new System.Windows.Forms.PictureBox();
            this.picGmail = new System.Windows.Forms.PictureBox();
            this.picFacebook = new System.Windows.Forms.PictureBox();
            this.lblOr = new System.Windows.Forms.Label();
            this.pnlHorizonal3 = new System.Windows.Forms.Panel();
            this.lnklblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFaultTrackingLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.btnMinimize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnMcesRecoLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 50);
            this.pnlTop.TabIndex = 2;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlTop_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.minimizeOrange;
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(410, 15);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(18, 18);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.closeOrange;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(440, 15);
            this.btnClose.Margin = new System.Windows.Forms.Padding(0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(18, 18);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnMcesRecoLogo
            // 
            this.btnMcesRecoLogo.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.mces_reco;
            this.btnMcesRecoLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMcesRecoLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMcesRecoLogo.FlatAppearance.BorderSize = 0;
            this.btnMcesRecoLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMcesRecoLogo.Location = new System.Drawing.Point(15, 5);
            this.btnMcesRecoLogo.Margin = new System.Windows.Forms.Padding(0);
            this.btnMcesRecoLogo.Name = "btnMcesRecoLogo";
            this.btnMcesRecoLogo.Size = new System.Drawing.Size(160, 40);
            this.btnMcesRecoLogo.TabIndex = 0;
            this.btnMcesRecoLogo.UseVisualStyleBackColor = true;
            this.btnMcesRecoLogo.Click += new System.EventHandler(this.BtnMcesRecoLogo_Click);
            // 
            // errUserName
            // 
            this.errUserName.ContainerControl = this;
            this.errUserName.Icon = ((System.Drawing.Icon)(resources.GetObject("errUserName.Icon")));
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            this.errPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errPassword.Icon")));
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 730);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 3;
            // 
            // picFaultTrackingLogo
            // 
            this.picFaultTrackingLogo.Image = global::FaultTrackingSystem.Properties.Resources.faultTracking;
            this.picFaultTrackingLogo.Location = new System.Drawing.Point(85, 65);
            this.picFaultTrackingLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picFaultTrackingLogo.Name = "picFaultTrackingLogo";
            this.picFaultTrackingLogo.Size = new System.Drawing.Size(300, 150);
            this.picFaultTrackingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFaultTrackingLogo.TabIndex = 49;
            this.picFaultTrackingLogo.TabStop = false;
            // 
            // pnlHorizonal
            // 
            this.pnlHorizonal.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal.Location = new System.Drawing.Point(85, 330);
            this.pnlHorizonal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal.Name = "pnlHorizonal";
            this.pnlHorizonal.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal.TabIndex = 48;
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.hide;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(390, 395);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnHidePassword.TabIndex = 47;
            this.btnHidePassword.UseVisualStyleBackColor = true;
            this.btnHidePassword.Click += new System.EventHandler(this.BtnHidePassword_Click);
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.show;
            this.btnShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(390, 395);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 46;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // pnlHorizonal2
            // 
            this.pnlHorizonal2.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal2.Location = new System.Drawing.Point(85, 465);
            this.pnlHorizonal2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal2.Name = "pnlHorizonal2";
            this.pnlHorizonal2.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal2.TabIndex = 45;
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.Beige;
            this.chkRememberMe.Location = new System.Drawing.Point(85, 430);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(102, 21);
            this.chkRememberMe.TabIndex = 44;
            this.chkRememberMe.Text = "Beni Hatırla";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtPassword.Location = new System.Drawing.Point(85, 395);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(300, 25);
            this.txtPassword.TabIndex = 43;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblPassword.Location = new System.Drawing.Point(85, 355);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 30);
            this.lblPassword.TabIndex = 42;
            this.lblPassword.Text = "Parola";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Beige;
            this.txtUserName.Location = new System.Drawing.Point(85, 290);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.MaxLength = 25;
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(300, 25);
            this.txtUserName.TabIndex = 41;
            this.txtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtUserName.Leave += new System.EventHandler(this.TxtUserName_Leave);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.Beige;
            this.lblUserName.Location = new System.Drawing.Point(85, 250);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(141, 30);
            this.lblUserName.TabIndex = 40;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // picTwitter
            // 
            this.picTwitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTwitter.Image = global::FaultTrackingSystem.Properties.Resources.twitter;
            this.picTwitter.Location = new System.Drawing.Point(315, 680);
            this.picTwitter.Margin = new System.Windows.Forms.Padding(0);
            this.picTwitter.Name = "picTwitter";
            this.picTwitter.Size = new System.Drawing.Size(70, 45);
            this.picTwitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTwitter.TabIndex = 57;
            this.picTwitter.TabStop = false;
            this.picTwitter.Click += new System.EventHandler(this.PicTwitter_Click);
            this.picTwitter.MouseEnter += new System.EventHandler(this.PicTwitter_MouseEnter);
            this.picTwitter.MouseLeave += new System.EventHandler(this.PicTwitter_MouseLeave);
            // 
            // picGmail
            // 
            this.picGmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGmail.Image = global::FaultTrackingSystem.Properties.Resources.gmail;
            this.picGmail.Location = new System.Drawing.Point(195, 680);
            this.picGmail.Margin = new System.Windows.Forms.Padding(0);
            this.picGmail.Name = "picGmail";
            this.picGmail.Size = new System.Drawing.Size(70, 45);
            this.picGmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGmail.TabIndex = 56;
            this.picGmail.TabStop = false;
            this.picGmail.Click += new System.EventHandler(this.PicGmail_Click);
            this.picGmail.MouseEnter += new System.EventHandler(this.PicGmail_MouseEnter);
            this.picGmail.MouseLeave += new System.EventHandler(this.PicGmail_MouseLeave);
            // 
            // picFacebook
            // 
            this.picFacebook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFacebook.Image = global::FaultTrackingSystem.Properties.Resources.facebook;
            this.picFacebook.Location = new System.Drawing.Point(85, 680);
            this.picFacebook.Margin = new System.Windows.Forms.Padding(0);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(70, 45);
            this.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFacebook.TabIndex = 55;
            this.picFacebook.TabStop = false;
            this.picFacebook.Click += new System.EventHandler(this.PicFacebook_Click);
            this.picFacebook.MouseEnter += new System.EventHandler(this.PicFacebook_MouseEnter);
            this.picFacebook.MouseLeave += new System.EventHandler(this.PicFacebook_MouseLeave);
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Silver;
            this.lblOr.Location = new System.Drawing.Point(210, 640);
            this.lblOr.Margin = new System.Windows.Forms.Padding(0);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(57, 20);
            this.lblOr.TabIndex = 54;
            this.lblOr.Text = "YA DA";
            // 
            // pnlHorizonal3
            // 
            this.pnlHorizonal3.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal3.Location = new System.Drawing.Point(85, 650);
            this.pnlHorizonal3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal3.Name = "pnlHorizonal3";
            this.pnlHorizonal3.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal3.TabIndex = 53;
            // 
            // lnklblForgetPassword
            // 
            this.lnklblForgetPassword.AutoSize = true;
            this.lnklblForgetPassword.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblForgetPassword.LinkColor = System.Drawing.Color.Silver;
            this.lnklblForgetPassword.Location = new System.Drawing.Point(175, 610);
            this.lnklblForgetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lnklblForgetPassword.Name = "lnklblForgetPassword";
            this.lnklblForgetPassword.Size = new System.Drawing.Size(137, 17);
            this.lnklblForgetPassword.TabIndex = 52;
            this.lnklblForgetPassword.TabStop = true;
            this.lnklblForgetPassword.Text = "Parolamı Unuttum ?";
            this.lnklblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblForgetPassword_LinkClicked);
            this.lnklblForgetPassword.MouseEnter += new System.EventHandler(this.LnklblForgetPassword_MouseEnter);
            this.lnklblForgetPassword.MouseLeave += new System.EventHandler(this.LnklblForgetPassword_MouseLeave);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRegister.ForeColor = System.Drawing.Color.Beige;
            this.btnRegister.Location = new System.Drawing.Point(85, 555);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(300, 40);
            this.btnRegister.TabIndex = 51;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            this.btnRegister.MouseEnter += new System.EventHandler(this.BtnRegister_MouseEnter);
            this.btnRegister.MouseLeave += new System.EventHandler(this.BtnRegister_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Beige;
            this.btnLogin.Location = new System.Drawing.Point(85, 490);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 50;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 750);
            this.Controls.Add(this.picTwitter);
            this.Controls.Add(this.picGmail);
            this.Controls.Add(this.picFacebook);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.pnlHorizonal3);
            this.Controls.Add(this.lnklblForgetPassword);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picFaultTrackingLogo);
            this.Controls.Add(this.pnlHorizonal);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.pnlHorizonal2);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFaultTrackingLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTwitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMcesRecoLogo;
        private System.Windows.Forms.ErrorProvider errUserName;
        private System.Windows.Forms.PictureBox picTwitter;
        private System.Windows.Forms.PictureBox picGmail;
        private System.Windows.Forms.PictureBox picFacebook;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Panel pnlHorizonal3;
        private System.Windows.Forms.LinkLabel lnklblForgetPassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picFaultTrackingLogo;
        private System.Windows.Forms.Panel pnlHorizonal;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Panel pnlHorizonal2;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.FlowLayoutPanel pnlBottom;
        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.Timer tmrLoad;
    }
}