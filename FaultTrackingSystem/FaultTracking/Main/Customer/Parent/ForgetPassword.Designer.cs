namespace FaultTrackingSystem.FaultTracking.Main.Customer.Parent
{
    partial class ForgetPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgetPassword));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMcesRecoLogo = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.mtxtSecurityCode = new System.Windows.Forms.MaskedTextBox();
            this.pnlHorizonal3 = new System.Windows.Forms.Panel();
            this.btnEmailVerification = new System.Windows.Forms.Button();
            this.lblSecurityCode = new System.Windows.Forms.Label();
            this.lnklblNewAccount = new System.Windows.Forms.LinkLabel();
            this.btnConfirmHidePassword = new System.Windows.Forms.Button();
            this.btnConfirmShowPassword = new System.Windows.Forms.Button();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.lblOr = new System.Windows.Forms.Label();
            this.pnlHorizonal2 = new System.Windows.Forms.Panel();
            this.btnBackToLogin = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.pnlHorizonal = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.picResetPassword = new System.Windows.Forms.PictureBox();
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSecurityCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picResetPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSecurityCode)).BeginInit();
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
            this.btnMinimize.TabIndex = 5;
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
            this.btnClose.TabIndex = 4;
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
            this.btnMcesRecoLogo.TabIndex = 1;
            this.btnMcesRecoLogo.UseVisualStyleBackColor = true;
            this.btnMcesRecoLogo.Click += new System.EventHandler(this.BtnMcesRecoLogo_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 650);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 3;
            // 
            // mtxtSecurityCode
            // 
            this.mtxtSecurityCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.mtxtSecurityCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtSecurityCode.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtSecurityCode.ForeColor = System.Drawing.Color.Beige;
            this.mtxtSecurityCode.Location = new System.Drawing.Point(15, 594);
            this.mtxtSecurityCode.Margin = new System.Windows.Forms.Padding(0);
            this.mtxtSecurityCode.Mask = "000 000";
            this.mtxtSecurityCode.Name = "mtxtSecurityCode";
            this.mtxtSecurityCode.PromptChar = '-';
            this.mtxtSecurityCode.Size = new System.Drawing.Size(308, 22);
            this.mtxtSecurityCode.TabIndex = 73;
            this.mtxtSecurityCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtSecurityCode.TextChanged += new System.EventHandler(this.MtxtSecurityCode_TextChanged);
            this.mtxtSecurityCode.Leave += new System.EventHandler(this.MtxtSecurityCode_Leave);
            // 
            // pnlHorizonal3
            // 
            this.pnlHorizonal3.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal3.Location = new System.Drawing.Point(64, 629);
            this.pnlHorizonal3.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal3.Name = "pnlHorizonal3";
            this.pnlHorizonal3.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal3.TabIndex = 72;
            // 
            // btnEmailVerification
            // 
            this.btnEmailVerification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnEmailVerification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmailVerification.FlatAppearance.BorderSize = 0;
            this.btnEmailVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmailVerification.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmailVerification.ForeColor = System.Drawing.Color.Beige;
            this.btnEmailVerification.Location = new System.Drawing.Point(170, 543);
            this.btnEmailVerification.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmailVerification.Name = "btnEmailVerification";
            this.btnEmailVerification.Size = new System.Drawing.Size(300, 40);
            this.btnEmailVerification.TabIndex = 71;
            this.btnEmailVerification.Text = "E-mail doğrulama";
            this.btnEmailVerification.UseVisualStyleBackColor = false;
            this.btnEmailVerification.Click += new System.EventHandler(this.BtnEmailVerification_Click);
            this.btnEmailVerification.MouseEnter += new System.EventHandler(this.BtnEmailVerification_MouseEnter);
            this.btnEmailVerification.MouseLeave += new System.EventHandler(this.BtnEmailVerification_MouseLeave);
            // 
            // lblSecurityCode
            // 
            this.lblSecurityCode.AutoSize = true;
            this.lblSecurityCode.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecurityCode.ForeColor = System.Drawing.Color.Beige;
            this.lblSecurityCode.Location = new System.Drawing.Point(9, 546);
            this.lblSecurityCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecurityCode.Name = "lblSecurityCode";
            this.lblSecurityCode.Size = new System.Drawing.Size(161, 30);
            this.lblSecurityCode.TabIndex = 70;
            this.lblSecurityCode.Text = "Güvenlik Kodu";
            // 
            // lnklblNewAccount
            // 
            this.lnklblNewAccount.AutoSize = true;
            this.lnklblNewAccount.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblNewAccount.LinkColor = System.Drawing.Color.Silver;
            this.lnklblNewAccount.Location = new System.Drawing.Point(162, 510);
            this.lnklblNewAccount.Margin = new System.Windows.Forms.Padding(0);
            this.lnklblNewAccount.Name = "lnklblNewAccount";
            this.lnklblNewAccount.Size = new System.Drawing.Size(129, 17);
            this.lnklblNewAccount.TabIndex = 69;
            this.lnklblNewAccount.TabStop = true;
            this.lnklblNewAccount.Text = "Yeni Hesap Oluştur";
            this.lnklblNewAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblForgetPassword_LinkClicked);
            this.lnklblNewAccount.MouseEnter += new System.EventHandler(this.LnklblNewAccount_MouseEnter);
            this.lnklblNewAccount.MouseLeave += new System.EventHandler(this.LnklblNewAccount_MouseLeave);
            // 
            // btnConfirmHidePassword
            // 
            this.btnConfirmHidePassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.hide;
            this.btnConfirmHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmHidePassword.FlatAppearance.BorderSize = 0;
            this.btnConfirmHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmHidePassword.Location = new System.Drawing.Point(229, 240);
            this.btnConfirmHidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmHidePassword.Name = "btnConfirmHidePassword";
            this.btnConfirmHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnConfirmHidePassword.TabIndex = 68;
            this.btnConfirmHidePassword.UseVisualStyleBackColor = true;
            this.btnConfirmHidePassword.Click += new System.EventHandler(this.BtnConfirmHidePassword_Click);
            // 
            // btnConfirmShowPassword
            // 
            this.btnConfirmShowPassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.show;
            this.btnConfirmShowPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfirmShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmShowPassword.FlatAppearance.BorderSize = 0;
            this.btnConfirmShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmShowPassword.Location = new System.Drawing.Point(204, 240);
            this.btnConfirmShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfirmShowPassword.Name = "btnConfirmShowPassword";
            this.btnConfirmShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnConfirmShowPassword.TabIndex = 67;
            this.btnConfirmShowPassword.UseVisualStyleBackColor = true;
            this.btnConfirmShowPassword.Click += new System.EventHandler(this.BtnConfirmShowPassword_Click);
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.hide;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(324, 240);
            this.btnHidePassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnHidePassword.Name = "btnHidePassword";
            this.btnHidePassword.Size = new System.Drawing.Size(25, 25);
            this.btnHidePassword.TabIndex = 66;
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
            this.btnShowPassword.Location = new System.Drawing.Point(299, 240);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 65;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnNewPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPassword.FlatAppearance.BorderSize = 0;
            this.btnNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPassword.ForeColor = System.Drawing.Color.Beige;
            this.btnNewPassword.Location = new System.Drawing.Point(131, 175);
            this.btnNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(300, 40);
            this.btnNewPassword.TabIndex = 64;
            this.btnNewPassword.Text = "Parola Yenile";
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.BtnNewPassword_Click);
            this.btnNewPassword.MouseEnter += new System.EventHandler(this.BtnNewPassword_MouseEnter);
            this.btnNewPassword.MouseLeave += new System.EventHandler(this.BtnNewPassword_MouseLeave);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtConfirmPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtConfirmPassword.Location = new System.Drawing.Point(161, 135);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 25;
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '•';
            this.txtConfirmPassword.Size = new System.Drawing.Size(300, 25);
            this.txtConfirmPassword.TabIndex = 63;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtConfirmPassword_Leave);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtNewPassword.Location = new System.Drawing.Point(117, 83);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 25;
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '•';
            this.txtNewPassword.Size = new System.Drawing.Size(300, 25);
            this.txtNewPassword.TabIndex = 62;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.TxtNewPassword_TextChanged);
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtNewPassword.Leave += new System.EventHandler(this.TxtNewPassword_Leave);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblConfirmPassword.Location = new System.Drawing.Point(10, 128);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(160, 30);
            this.lblConfirmPassword.TabIndex = 61;
            this.lblConfirmPassword.Text = "Parola Onayla";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblNewPassword.Location = new System.Drawing.Point(19, 76);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(81, 30);
            this.lblNewPassword.TabIndex = 60;
            this.lblNewPassword.Text = "Parola";
            // 
            // lblOr
            // 
            this.lblOr.AutoSize = true;
            this.lblOr.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOr.ForeColor = System.Drawing.Color.Silver;
            this.lblOr.Location = new System.Drawing.Point(200, 475);
            this.lblOr.Margin = new System.Windows.Forms.Padding(0);
            this.lblOr.Name = "lblOr";
            this.lblOr.Size = new System.Drawing.Size(57, 20);
            this.lblOr.TabIndex = 59;
            this.lblOr.Text = "YA DA";
            // 
            // pnlHorizonal2
            // 
            this.pnlHorizonal2.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal2.Location = new System.Drawing.Point(85, 485);
            this.pnlHorizonal2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal2.Name = "pnlHorizonal2";
            this.pnlHorizonal2.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal2.TabIndex = 58;
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.ForeColor = System.Drawing.Color.Beige;
            this.btnBackToLogin.Location = new System.Drawing.Point(85, 420);
            this.btnBackToLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.Size = new System.Drawing.Size(300, 40);
            this.btnBackToLogin.TabIndex = 57;
            this.btnBackToLogin.Text = "İptal Et";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.BtnBackToLogin_Click);
            this.btnBackToLogin.MouseEnter += new System.EventHandler(this.BtnBackToLogin_MouseEnter);
            this.btnBackToLogin.MouseLeave += new System.EventHandler(this.BtnBackToLogin_MouseLeave);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Beige;
            this.btnSend.Location = new System.Drawing.Point(85, 350);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(300, 40);
            this.btnSend.TabIndex = 56;
            this.btnSend.Text = "Giriş Bağlantısı Gönder";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            this.btnSend.MouseEnter += new System.EventHandler(this.BtnSend_MouseEnter);
            this.btnSend.MouseLeave += new System.EventHandler(this.BtnSend_MouseLeave);
            // 
            // pnlHorizonal
            // 
            this.pnlHorizonal.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal.Location = new System.Drawing.Point(85, 315);
            this.pnlHorizonal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal.Name = "pnlHorizonal";
            this.pnlHorizonal.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal.TabIndex = 55;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Beige;
            this.txtEmail.Location = new System.Drawing.Point(85, 280);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 25);
            this.txtEmail.TabIndex = 54;
            this.txtEmail.WordWrap = false;
            this.txtEmail.EnabledChanged += new System.EventHandler(this.TxtEmail_EnabledChanged);
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtEmail.Leave += new System.EventHandler(this.TxtEmail_Leave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmail.ForeColor = System.Drawing.Color.Beige;
            this.lblEmail.Location = new System.Drawing.Point(85, 240);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(79, 30);
            this.lblEmail.TabIndex = 53;
            this.lblEmail.Text = "E-mail";
            // 
            // picResetPassword
            // 
            this.picResetPassword.Image = global::FaultTrackingSystem.Properties.Resources.resetPassword;
            this.picResetPassword.Location = new System.Drawing.Point(85, 65);
            this.picResetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.picResetPassword.Name = "picResetPassword";
            this.picResetPassword.Size = new System.Drawing.Size(300, 150);
            this.picResetPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResetPassword.TabIndex = 52;
            this.picResetPassword.TabStop = false;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            this.errEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmail.Icon")));
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            this.errPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errPassword.Icon")));
            // 
            // errConfirmPassword
            // 
            this.errConfirmPassword.ContainerControl = this;
            this.errConfirmPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errConfirmPassword.Icon")));
            // 
            // errSecurityCode
            // 
            this.errSecurityCode.ContainerControl = this;
            this.errSecurityCode.Icon = ((System.Drawing.Icon)(resources.GetObject("errSecurityCode.Icon")));
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 670);
            this.Controls.Add(this.mtxtSecurityCode);
            this.Controls.Add(this.pnlHorizonal3);
            this.Controls.Add(this.btnEmailVerification);
            this.Controls.Add(this.lblSecurityCode);
            this.Controls.Add(this.lnklblNewAccount);
            this.Controls.Add(this.btnConfirmHidePassword);
            this.Controls.Add(this.btnConfirmShowPassword);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.btnNewPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblOr);
            this.Controls.Add(this.pnlHorizonal2);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.pnlHorizonal);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.picResetPassword);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ForgetPassword";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.Load += new System.EventHandler(this.ForgetPassword_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picResetPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSecurityCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMcesRecoLogo;
        private System.Windows.Forms.FlowLayoutPanel pnlBottom;
        private System.Windows.Forms.MaskedTextBox mtxtSecurityCode;
        private System.Windows.Forms.Panel pnlHorizonal3;
        private System.Windows.Forms.Button btnEmailVerification;
        private System.Windows.Forms.Label lblSecurityCode;
        private System.Windows.Forms.LinkLabel lnklblNewAccount;
        private System.Windows.Forms.Button btnConfirmHidePassword;
        private System.Windows.Forms.Button btnConfirmShowPassword;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Label lblOr;
        private System.Windows.Forms.Panel pnlHorizonal2;
        private System.Windows.Forms.Button btnBackToLogin;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel pnlHorizonal;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.PictureBox picResetPassword;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.ErrorProvider errConfirmPassword;
        private System.Windows.Forms.ErrorProvider errSecurityCode;
        private System.Windows.Forms.Timer tmrLoad;
    }
}