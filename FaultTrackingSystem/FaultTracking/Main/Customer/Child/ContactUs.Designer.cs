namespace FaultTrackingSystem.FaultTracking.Main.Customer.Child
{
    partial class ContactUs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactUs));
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtContent = new System.Windows.Forms.RichTextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblPhoneReco = new System.Windows.Forms.Label();
            this.lnklblEmail = new System.Windows.Forms.LinkLabel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneMces = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lnklblAddress = new System.Windows.Forms.LinkLabel();
            this.lblAddress = new System.Windows.Forms.Label();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picAddress = new System.Windows.Forms.PictureBox();
            this.picPromo = new System.Windows.Forms.PictureBox();
            this.errSubject = new System.Windows.Forms.ErrorProvider(this.components);
            this.errContent = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Beige;
            this.btnSend.Location = new System.Drawing.Point(910, 625);
            this.btnSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(200, 40);
            this.btnSend.TabIndex = 24;
            this.btnSend.Text = "Gönder";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            this.btnSend.MouseEnter += new System.EventHandler(this.BtnSend_MouseEnter);
            this.btnSend.MouseLeave += new System.EventHandler(this.BtnSend_MouseLeave);
            // 
            // rtxtContent
            // 
            this.rtxtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.rtxtContent.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtContent.ForeColor = System.Drawing.Color.Beige;
            this.rtxtContent.Location = new System.Drawing.Point(690, 235);
            this.rtxtContent.Margin = new System.Windows.Forms.Padding(0);
            this.rtxtContent.Name = "rtxtContent";
            this.rtxtContent.Size = new System.Drawing.Size(420, 348);
            this.rtxtContent.TabIndex = 23;
            this.rtxtContent.Text = "";
            this.rtxtContent.TextChanged += new System.EventHandler(this.RtxtContent_TextChanged);
            this.rtxtContent.Leave += new System.EventHandler(this.RtxtContent_Leave);
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.ForeColor = System.Drawing.Color.Beige;
            this.lblContent.Location = new System.Drawing.Point(843, 190);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(105, 21);
            this.lblContent.TabIndex = 22;
            this.lblContent.Text = "Konu İçeriği";
            // 
            // txtSubject
            // 
            this.txtSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.txtSubject.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.ForeColor = System.Drawing.Color.Beige;
            this.txtSubject.Location = new System.Drawing.Point(690, 125);
            this.txtSubject.Margin = new System.Windows.Forms.Padding(0);
            this.txtSubject.Multiline = true;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(420, 30);
            this.txtSubject.TabIndex = 21;
            this.txtSubject.WordWrap = false;
            this.txtSubject.TextChanged += new System.EventHandler(this.TxtSubject_TextChanged);
            this.txtSubject.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DisableEnterKey);
            this.txtSubject.Leave += new System.EventHandler(this.TxtSubject_Leave);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.ForeColor = System.Drawing.Color.Beige;
            this.lblSubject.Location = new System.Drawing.Point(845, 80);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(109, 21);
            this.lblSubject.TabIndex = 20;
            this.lblSubject.Text = "Konu Başlığı";
            // 
            // lblPhoneReco
            // 
            this.lblPhoneReco.AutoSize = true;
            this.lblPhoneReco.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneReco.ForeColor = System.Drawing.Color.Silver;
            this.lblPhoneReco.Location = new System.Drawing.Point(190, 353);
            this.lblPhoneReco.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhoneReco.Name = "lblPhoneReco";
            this.lblPhoneReco.Size = new System.Drawing.Size(116, 17);
            this.lblPhoneReco.TabIndex = 41;
            this.lblPhoneReco.Text = "0 (534) 792 79 28\r\n";
            // 
            // lnklblEmail
            // 
            this.lnklblEmail.AutoSize = true;
            this.lnklblEmail.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblEmail.LinkColor = System.Drawing.Color.Silver;
            this.lnklblEmail.Location = new System.Drawing.Point(190, 515);
            this.lnklblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lnklblEmail.Name = "lnklblEmail";
            this.lnklblEmail.Size = new System.Drawing.Size(185, 17);
            this.lnklblEmail.TabIndex = 40;
            this.lnklblEmail.TabStop = true;
            this.lnklblEmail.Text = "fault-tracking@fault.com.tr";
            this.lnklblEmail.MouseEnter += new System.EventHandler(this.LnklblEmail_MouseEnter);
            this.lnklblEmail.MouseLeave += new System.EventHandler(this.LnklblEmail_MouseLeave);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Beige;
            this.lblEmail.Location = new System.Drawing.Point(190, 475);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(61, 21);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "E-mail";
            // 
            // lblPhoneMces
            // 
            this.lblPhoneMces.AutoSize = true;
            this.lblPhoneMces.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneMces.ForeColor = System.Drawing.Color.Silver;
            this.lblPhoneMces.Location = new System.Drawing.Point(190, 320);
            this.lblPhoneMces.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhoneMces.Name = "lblPhoneMces";
            this.lblPhoneMces.Size = new System.Drawing.Size(116, 17);
            this.lblPhoneMces.TabIndex = 38;
            this.lblPhoneMces.Text = "0 (534) 075 50 58";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.Beige;
            this.lblPhone.Location = new System.Drawing.Point(190, 285);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 21);
            this.lblPhone.TabIndex = 37;
            this.lblPhone.Text = "Telefon";
            // 
            // lnklblAddress
            // 
            this.lnklblAddress.AutoSize = true;
            this.lnklblAddress.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblAddress.LinkColor = System.Drawing.Color.Silver;
            this.lnklblAddress.Location = new System.Drawing.Point(190, 160);
            this.lnklblAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lnklblAddress.Name = "lnklblAddress";
            this.lnklblAddress.Size = new System.Drawing.Size(202, 34);
            this.lnklblAddress.TabIndex = 36;
            this.lnklblAddress.TabStop = true;
            this.lnklblAddress.Text = "Yarbay Vecihibey Erkek Yurdu \r\nBandırma/Balıkesir";
            this.lnklblAddress.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnklblAddress_LinkClicked);
            this.lnklblAddress.MouseEnter += new System.EventHandler(this.LnklblAddress_MouseEnter);
            this.lnklblAddress.MouseLeave += new System.EventHandler(this.LnklblAddress_MouseLeave);
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Beige;
            this.lblAddress.Location = new System.Drawing.Point(190, 115);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(56, 21);
            this.lblAddress.TabIndex = 35;
            this.lblAddress.Text = "Adres";
            // 
            // picEmail
            // 
            this.picEmail.Image = global::FaultTrackingSystem.Properties.Resources.emailOrange;
            this.picEmail.Location = new System.Drawing.Point(90, 475);
            this.picEmail.Margin = new System.Windows.Forms.Padding(0);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(65, 65);
            this.picEmail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEmail.TabIndex = 34;
            this.picEmail.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::FaultTrackingSystem.Properties.Resources.telephoneCallOrange;
            this.picHome.Location = new System.Drawing.Point(90, 300);
            this.picHome.Margin = new System.Windows.Forms.Padding(0);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(65, 65);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHome.TabIndex = 33;
            this.picHome.TabStop = false;
            // 
            // picAddress
            // 
            this.picAddress.Image = global::FaultTrackingSystem.Properties.Resources.homeOrange;
            this.picAddress.Location = new System.Drawing.Point(90, 125);
            this.picAddress.Margin = new System.Windows.Forms.Padding(0);
            this.picAddress.Name = "picAddress";
            this.picAddress.Size = new System.Drawing.Size(70, 70);
            this.picAddress.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAddress.TabIndex = 32;
            this.picAddress.TabStop = false;
            // 
            // picPromo
            // 
            this.picPromo.Image = global::FaultTrackingSystem.Properties.Resources.promo;
            this.picPromo.Location = new System.Drawing.Point(1220, 0);
            this.picPromo.Margin = new System.Windows.Forms.Padding(0);
            this.picPromo.Name = "picPromo";
            this.picPromo.Size = new System.Drawing.Size(100, 700);
            this.picPromo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPromo.TabIndex = 31;
            this.picPromo.TabStop = false;
            // 
            // errSubject
            // 
            this.errSubject.ContainerControl = this;
            this.errSubject.Icon = ((System.Drawing.Icon)(resources.GetObject("errSubject.Icon")));
            // 
            // errContent
            // 
            this.errContent.ContainerControl = this;
            this.errContent.Icon = ((System.Drawing.Icon)(resources.GetObject("errContent.Icon")));
            // 
            // ContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.lblPhoneReco);
            this.Controls.Add(this.lnklblEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneMces);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lnklblAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picAddress);
            this.Controls.Add(this.picPromo);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.rtxtContent);
            this.Controls.Add(this.lblContent);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactUs";
            this.Text = "ContactUs";
            this.Load += new System.EventHandler(this.ContactUs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPromo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errContent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtxtContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.PictureBox picPromo;
        private System.Windows.Forms.Label lblPhoneReco;
        private System.Windows.Forms.LinkLabel lnklblEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneMces;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.LinkLabel lnklblAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picAddress;
        private System.Windows.Forms.ErrorProvider errSubject;
        private System.Windows.Forms.ErrorProvider errContent;
    }
}