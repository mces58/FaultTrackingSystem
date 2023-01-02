namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.rdoOther = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.picPromo = new System.Windows.Forms.PictureBox();
            this.picPassword = new System.Windows.Forms.PictureBox();
            this.picUser = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.errFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errGender = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCurrentPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNewPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errInfo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Beige;
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.Color.Black;
            this.txtUserName.Location = new System.Drawing.Point(100, 195);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(0);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 30);
            this.txtUserName.TabIndex = 151;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.Beige;
            this.lblUserName.Location = new System.Drawing.Point(100, 155);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(0);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(110, 21);
            this.lblUserName.TabIndex = 150;
            this.lblUserName.Text = "Kullanıcı Adı";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Beige;
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(100, 295);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(250, 30);
            this.txtEmail.TabIndex = 148;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Beige;
            this.lblEmail.Location = new System.Drawing.Point(100, 255);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 21);
            this.lblEmail.TabIndex = 147;
            this.lblEmail.Text = "E-posta";
            // 
            // rdoOther
            // 
            this.rdoOther.AutoSize = true;
            this.rdoOther.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOther.ForeColor = System.Drawing.Color.Beige;
            this.rdoOther.Location = new System.Drawing.Point(290, 595);
            this.rdoOther.Margin = new System.Windows.Forms.Padding(0);
            this.rdoOther.Name = "rdoOther";
            this.rdoOther.Size = new System.Drawing.Size(61, 21);
            this.rdoOther.TabIndex = 146;
            this.rdoOther.TabStop = true;
            this.rdoOther.Text = "Diğer";
            this.rdoOther.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemale.ForeColor = System.Drawing.Color.Beige;
            this.rdoFemale.Location = new System.Drawing.Point(195, 595);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(63, 21);
            this.rdoFemale.TabIndex = 145;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Kadın";
            this.rdoFemale.UseVisualStyleBackColor = true;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMale.ForeColor = System.Drawing.Color.Beige;
            this.rdoMale.Location = new System.Drawing.Point(100, 595);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(62, 21);
            this.rdoMale.TabIndex = 144;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Erkek";
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.Color.Beige;
            this.lblGender.Location = new System.Drawing.Point(100, 555);
            this.lblGender.Margin = new System.Windows.Forms.Padding(0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(73, 21);
            this.lblGender.TabIndex = 143;
            this.lblGender.Text = "Cinsiyet";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.ForeColor = System.Drawing.Color.Beige;
            this.txtLastName.Location = new System.Drawing.Point(100, 495);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(0);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(250, 30);
            this.txtLastName.TabIndex = 142;
            this.txtLastName.WordWrap = false;
            this.txtLastName.TextChanged += new System.EventHandler(this.TxtLastName_TextChanged);
            this.txtLastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtLastName.Leave += new System.EventHandler(this.TxtLastName_Leave);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.ForeColor = System.Drawing.Color.Beige;
            this.lblLastName.Location = new System.Drawing.Point(100, 455);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 21);
            this.lblLastName.TabIndex = 141;
            this.lblLastName.Text = "Soy İsim";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.Color.Beige;
            this.lblFirstName.Location = new System.Drawing.Point(100, 355);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(44, 21);
            this.lblFirstName.TabIndex = 140;
            this.lblFirstName.Text = "İsim";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.ForeColor = System.Drawing.Color.Beige;
            this.txtFirstName.Location = new System.Drawing.Point(100, 395);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(0);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(250, 30);
            this.txtFirstName.TabIndex = 139;
            this.txtFirstName.WordWrap = false;
            this.txtFirstName.TextChanged += new System.EventHandler(this.TxtFirstName_TextChanged);
            this.txtFirstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtFirstName.Leave += new System.EventHandler(this.TxtFirstName_Leave);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Beige;
            this.lblInfo.Location = new System.Drawing.Point(664, 140);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 25);
            this.lblInfo.TabIndex = 159;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Beige;
            this.txtConfirmPassword.Enabled = false;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtConfirmPassword.Location = new System.Drawing.Point(665, 475);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtConfirmPassword.MaxLength = 25;
            this.txtConfirmPassword.Multiline = true;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(250, 30);
            this.txtConfirmPassword.TabIndex = 157;
            this.txtConfirmPassword.WordWrap = false;
            this.txtConfirmPassword.EnabledChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.TxtConfirmPassword_TextChanged);
            this.txtConfirmPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.TxtConfirmPassword_Leave);
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblConfirmPassword.Location = new System.Drawing.Point(665, 425);
            this.lblConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(123, 21);
            this.lblConfirmPassword.TabIndex = 156;
            this.lblConfirmPassword.Text = "Parola Onayla";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Beige;
            this.txtNewPassword.Enabled = false;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtNewPassword.Location = new System.Drawing.Point(665, 345);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPassword.MaxLength = 25;
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(250, 30);
            this.txtNewPassword.TabIndex = 155;
            this.txtNewPassword.WordWrap = false;
            this.txtNewPassword.EnabledChanged += new System.EventHandler(this.TxtNewPassword_EnabledChanged);
            this.txtNewPassword.TextChanged += new System.EventHandler(this.TxtNewPassword_TextChanged);
            this.txtNewPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtNewPassword.Leave += new System.EventHandler(this.TxtNewPassword_Leave);
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblNewPassword.Location = new System.Drawing.Point(665, 295);
            this.lblNewPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 21);
            this.lblNewPassword.TabIndex = 154;
            this.lblNewPassword.Text = "Yeni Parola";
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtCurrentPassword.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPassword.ForeColor = System.Drawing.Color.Beige;
            this.txtCurrentPassword.Location = new System.Drawing.Point(665, 215);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtCurrentPassword.MaxLength = 25;
            this.txtCurrentPassword.Multiline = true;
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(250, 30);
            this.txtCurrentPassword.TabIndex = 153;
            this.txtCurrentPassword.WordWrap = false;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.TxtCurrentPassword_TextChanged);
            this.txtCurrentPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtCurrentPassword.Leave += new System.EventHandler(this.TxtCurrentPassword_Leave);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPassword.ForeColor = System.Drawing.Color.Beige;
            this.lblCurrentPassword.Location = new System.Drawing.Point(665, 165);
            this.lblCurrentPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(126, 21);
            this.lblCurrentPassword.TabIndex = 152;
            this.lblCurrentPassword.Text = "Mevcut Parola";
            // 
            // picPromo
            // 
            this.picPromo.Image = global::FaultTrackingSystem.Properties.Resources.promo;
            this.picPromo.Location = new System.Drawing.Point(1220, 0);
            this.picPromo.Margin = new System.Windows.Forms.Padding(0);
            this.picPromo.Name = "picPromo";
            this.picPromo.Size = new System.Drawing.Size(100, 700);
            this.picPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPromo.TabIndex = 160;
            this.picPromo.TabStop = false;
            // 
            // picPassword
            // 
            this.picPassword.Image = global::FaultTrackingSystem.Properties.Resources.resetPasswordOrange;
            this.picPassword.Location = new System.Drawing.Point(750, 50);
            this.picPassword.Margin = new System.Windows.Forms.Padding(0);
            this.picPassword.Name = "picPassword";
            this.picPassword.Size = new System.Drawing.Size(80, 80);
            this.picPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPassword.TabIndex = 158;
            this.picPassword.TabStop = false;
            // 
            // picUser
            // 
            this.picUser.Image = global::FaultTrackingSystem.Properties.Resources.userOrange;
            this.picUser.Location = new System.Drawing.Point(170, 50);
            this.picUser.Margin = new System.Windows.Forms.Padding(0);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(65, 65);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picUser.TabIndex = 149;
            this.picUser.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Beige;
            this.btnUpdate.Location = new System.Drawing.Point(685, 625);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(220, 40);
            this.btnUpdate.TabIndex = 161;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            this.btnUpdate.MouseEnter += new System.EventHandler(this.BtnUpdate_MouseEnter);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.BtnUpdate_MouseLeave);
            // 
            // errFirstName
            // 
            this.errFirstName.ContainerControl = this;
            this.errFirstName.Icon = ((System.Drawing.Icon)(resources.GetObject("errFirstName.Icon")));
            // 
            // errLastName
            // 
            this.errLastName.ContainerControl = this;
            this.errLastName.Icon = ((System.Drawing.Icon)(resources.GetObject("errLastName.Icon")));
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            this.errEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("errEmail.Icon")));
            // 
            // errGender
            // 
            this.errGender.ContainerControl = this;
            this.errGender.Icon = ((System.Drawing.Icon)(resources.GetObject("errGender.Icon")));
            // 
            // errCurrentPassword
            // 
            this.errCurrentPassword.ContainerControl = this;
            this.errCurrentPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errCurrentPassword.Icon")));
            // 
            // errNewPassword
            // 
            this.errNewPassword.ContainerControl = this;
            this.errNewPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errNewPassword.Icon")));
            // 
            // errConfirmPassword
            // 
            this.errConfirmPassword.ContainerControl = this;
            this.errConfirmPassword.Icon = ((System.Drawing.Icon)(resources.GetObject("errConfirmPassword.Icon")));
            // 
            // errInfo
            // 
            this.errInfo.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errInfo.ContainerControl = this;
            this.errInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("errInfo.Icon")));
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.picPromo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.picPassword);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.picUser);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.rdoOther);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtFirstName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCurrentPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNewPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.RadioButton rdoOther;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.PictureBox picPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.PictureBox picPromo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ErrorProvider errFirstName;
        private System.Windows.Forms.ErrorProvider errLastName;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errGender;
        private System.Windows.Forms.ErrorProvider errCurrentPassword;
        private System.Windows.Forms.ErrorProvider errNewPassword;
        private System.Windows.Forms.ErrorProvider errConfirmPassword;
        private System.Windows.Forms.ErrorProvider errInfo;
    }
}