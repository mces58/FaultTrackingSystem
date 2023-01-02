namespace FaultTrackingSystem.FaultTracking.Main.Employee
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
            this.lnklblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlHorizonal2 = new System.Windows.Forms.Panel();
            this.mtxtEmployeeCode = new System.Windows.Forms.MaskedTextBox();
            this.pnlHorizonal = new System.Windows.Forms.Panel();
            this.btnHidePassword = new System.Windows.Forms.Button();
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.chkRememberMe = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.picFaultTrackingLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.FlowLayoutPanel();
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.errEmployeeCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblEmployeeType = new System.Windows.Forms.Label();
            this.rdoManager = new System.Windows.Forms.RadioButton();
            this.rdoStaff = new System.Windows.Forms.RadioButton();
            this.rdoTechnician = new System.Windows.Forms.RadioButton();
            this.errEmployeeType = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFaultTrackingLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeType)).BeginInit();
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
            this.pnlTop.TabIndex = 4;
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
            // lnklblForgetPassword
            // 
            this.lnklblForgetPassword.AutoSize = true;
            this.lnklblForgetPassword.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnklblForgetPassword.LinkColor = System.Drawing.Color.Silver;
            this.lnklblForgetPassword.Location = new System.Drawing.Point(175, 695);
            this.lnklblForgetPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lnklblForgetPassword.Name = "lnklblForgetPassword";
            this.lnklblForgetPassword.Size = new System.Drawing.Size(137, 17);
            this.lnklblForgetPassword.TabIndex = 71;
            this.lnklblForgetPassword.TabStop = true;
            this.lnklblForgetPassword.Text = "Parolamı Unuttum ?";
            this.lnklblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblForgetPassword_LinkClicked);
            this.lnklblForgetPassword.MouseEnter += new System.EventHandler(this.LnklblForgetPassword_MouseEnter);
            this.lnklblForgetPassword.MouseLeave += new System.EventHandler(this.LnklblForgetPassword_MouseLeave);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Beige;
            this.btnLogin.Location = new System.Drawing.Point(85, 640);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(300, 40);
            this.btnLogin.TabIndex = 70;
            this.btnLogin.Text = "Giriş Yap";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.btnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.btnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            // 
            // pnlHorizonal2
            // 
            this.pnlHorizonal2.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal2.Location = new System.Drawing.Point(85, 505);
            this.pnlHorizonal2.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal2.Name = "pnlHorizonal2";
            this.pnlHorizonal2.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal2.TabIndex = 69;
            // 
            // mtxtEmployeeCode
            // 
            this.mtxtEmployeeCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.mtxtEmployeeCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mtxtEmployeeCode.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtEmployeeCode.ForeColor = System.Drawing.Color.Beige;
            this.mtxtEmployeeCode.Location = new System.Drawing.Point(85, 290);
            this.mtxtEmployeeCode.Margin = new System.Windows.Forms.Padding(0);
            this.mtxtEmployeeCode.Name = "mtxtEmployeeCode";
            this.mtxtEmployeeCode.Size = new System.Drawing.Size(300, 26);
            this.mtxtEmployeeCode.TabIndex = 68;
            this.mtxtEmployeeCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtEmployeeCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MtxtEmployeeCode_KeyUp);
            // 
            // pnlHorizonal
            // 
            this.pnlHorizonal.BackColor = System.Drawing.Color.White;
            this.pnlHorizonal.Location = new System.Drawing.Point(85, 340);
            this.pnlHorizonal.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHorizonal.Name = "pnlHorizonal";
            this.pnlHorizonal.Size = new System.Drawing.Size(300, 1);
            this.pnlHorizonal.TabIndex = 67;
            // 
            // btnHidePassword
            // 
            this.btnHidePassword.BackgroundImage = global::FaultTrackingSystem.Properties.Resources.hide;
            this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHidePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHidePassword.FlatAppearance.BorderSize = 0;
            this.btnHidePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHidePassword.Location = new System.Drawing.Point(390, 420);
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
            this.btnShowPassword.Location = new System.Drawing.Point(390, 420);
            this.btnShowPassword.Margin = new System.Windows.Forms.Padding(0);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(25, 25);
            this.btnShowPassword.TabIndex = 65;
            this.btnShowPassword.UseVisualStyleBackColor = true;
            this.btnShowPassword.Click += new System.EventHandler(this.BtnShowPassword_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRememberMe.ForeColor = System.Drawing.Color.Beige;
            this.chkRememberMe.Location = new System.Drawing.Point(85, 465);
            this.chkRememberMe.Margin = new System.Windows.Forms.Padding(0);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(102, 21);
            this.chkRememberMe.TabIndex = 64;
            this.chkRememberMe.Text = "Beni Hatırla";
            this.chkRememberMe.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(94)))), ((int)(((byte)(129)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtPassword.Location = new System.Drawing.Point(85, 420);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.MaxLength = 25;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(300, 25);
            this.txtPassword.TabIndex = 63;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtPassword.Leave += new System.EventHandler(this.TxtPassword_Leave);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblPassword.Location = new System.Drawing.Point(85, 375);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(81, 30);
            this.lblPassword.TabIndex = 62;
            this.lblPassword.Text = "Parola";
            // 
            // lblEmployeeCode
            // 
            this.lblEmployeeCode.AutoSize = true;
            this.lblEmployeeCode.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeCode.ForeColor = System.Drawing.Color.Beige;
            this.lblEmployeeCode.Location = new System.Drawing.Point(85, 245);
            this.lblEmployeeCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(144, 30);
            this.lblEmployeeCode.TabIndex = 61;
            this.lblEmployeeCode.Text = "Görevli Kodu";
            // 
            // picFaultTrackingLogo
            // 
            this.picFaultTrackingLogo.Image = global::FaultTrackingSystem.Properties.Resources.faultTracking;
            this.picFaultTrackingLogo.Location = new System.Drawing.Point(85, 60);
            this.picFaultTrackingLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picFaultTrackingLogo.Name = "picFaultTrackingLogo";
            this.picFaultTrackingLogo.Size = new System.Drawing.Size(300, 150);
            this.picFaultTrackingLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFaultTrackingLogo.TabIndex = 60;
            this.picFaultTrackingLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 730);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 72;
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // errEmployeeCode
            // 
            this.errEmployeeCode.ContainerControl = this;
            this.errEmployeeCode.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmployeeCode.Icon")));
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            this.errPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errPassword.Icon")));
            // 
            // lblEmployeeType
            // 
            this.lblEmployeeType.AutoSize = true;
            this.lblEmployeeType.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEmployeeType.ForeColor = System.Drawing.Color.Beige;
            this.lblEmployeeType.Location = new System.Drawing.Point(85, 535);
            this.lblEmployeeType.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmployeeType.Name = "lblEmployeeType";
            this.lblEmployeeType.Size = new System.Drawing.Size(129, 30);
            this.lblEmployeeType.TabIndex = 73;
            this.lblEmployeeType.Text = "Görevli Tipi";
            // 
            // rdoManager
            // 
            this.rdoManager.AutoSize = true;
            this.rdoManager.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoManager.ForeColor = System.Drawing.Color.Beige;
            this.rdoManager.Location = new System.Drawing.Point(85, 580);
            this.rdoManager.Name = "rdoManager";
            this.rdoManager.Size = new System.Drawing.Size(92, 25);
            this.rdoManager.TabIndex = 74;
            this.rdoManager.TabStop = true;
            this.rdoManager.Text = "Yönetici";
            this.rdoManager.UseVisualStyleBackColor = true;
            this.rdoManager.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdoStaff
            // 
            this.rdoStaff.AutoSize = true;
            this.rdoStaff.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoStaff.ForeColor = System.Drawing.Color.Beige;
            this.rdoStaff.Location = new System.Drawing.Point(190, 580);
            this.rdoStaff.Name = "rdoStaff";
            this.rdoStaff.Size = new System.Drawing.Size(97, 25);
            this.rdoStaff.TabIndex = 75;
            this.rdoStaff.TabStop = true;
            this.rdoStaff.Text = "Personel";
            this.rdoStaff.UseVisualStyleBackColor = true;
            this.rdoStaff.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // rdoTechnician
            // 
            this.rdoTechnician.AutoSize = true;
            this.rdoTechnician.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoTechnician.ForeColor = System.Drawing.Color.Beige;
            this.rdoTechnician.Location = new System.Drawing.Point(295, 580);
            this.rdoTechnician.Name = "rdoTechnician";
            this.rdoTechnician.Size = new System.Drawing.Size(107, 25);
            this.rdoTechnician.TabIndex = 76;
            this.rdoTechnician.TabStop = true;
            this.rdoTechnician.Text = "Teknisyen";
            this.rdoTechnician.UseVisualStyleBackColor = true;
            this.rdoTechnician.CheckedChanged += new System.EventHandler(this.CheckedChanged);
            // 
            // errEmployeeType
            // 
            this.errEmployeeType.ContainerControl = this;
            this.errEmployeeType.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmployeeType.Icon")));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 750);
            this.Controls.Add(this.rdoTechnician);
            this.Controls.Add(this.rdoStaff);
            this.Controls.Add(this.rdoManager);
            this.Controls.Add(this.lblEmployeeType);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.lnklblForgetPassword);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.pnlHorizonal2);
            this.Controls.Add(this.mtxtEmployeeCode);
            this.Controls.Add(this.pnlHorizonal);
            this.Controls.Add(this.btnHidePassword);
            this.Controls.Add(this.btnShowPassword);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblEmployeeCode);
            this.Controls.Add(this.picFaultTrackingLogo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFaultTrackingLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmployeeType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMcesRecoLogo;
        private System.Windows.Forms.LinkLabel lnklblForgetPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlHorizonal2;
        private System.Windows.Forms.MaskedTextBox mtxtEmployeeCode;
        private System.Windows.Forms.Panel pnlHorizonal;
        private System.Windows.Forms.Button btnHidePassword;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.CheckBox chkRememberMe;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.PictureBox picFaultTrackingLogo;
        private System.Windows.Forms.FlowLayoutPanel pnlBottom;
        private System.Windows.Forms.Timer tmrLoad;
        private System.Windows.Forms.ErrorProvider errEmployeeCode;
        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.RadioButton rdoTechnician;
        private System.Windows.Forms.RadioButton rdoStaff;
        private System.Windows.Forms.RadioButton rdoManager;
        private System.Windows.Forms.Label lblEmployeeType;
        private System.Windows.Forms.ErrorProvider errEmployeeType;
    }
}