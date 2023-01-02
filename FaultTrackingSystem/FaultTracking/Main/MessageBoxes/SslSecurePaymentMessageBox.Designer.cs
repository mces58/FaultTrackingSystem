namespace FaultTrackingSystem.FaultTracking.Main.MessageBoxes
{
    partial class SslSecurePaymentMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SslSecurePaymentMessageBox));
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.mtxtSecureCode = new System.Windows.Forms.MaskedTextBox();
            this.lblSecureCode = new System.Windows.Forms.Label();
            this.picErrorLogo = new System.Windows.Forms.PictureBox();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.errSecureCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.tmrLoad = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSecureCode)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(470, 50);
            this.pnlTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(186)))), ((int)(((byte)(124)))));
            this.lblTitle.Location = new System.Drawing.Point(175, 13);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(116, 25);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "SSL Ödeme";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.Beige;
            this.btnOk.Location = new System.Drawing.Point(9, 55);
            this.btnOk.Margin = new System.Windows.Forms.Padding(0);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(200, 40);
            this.btnOk.TabIndex = 18;
            this.btnOk.Text = "Tamam";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            this.btnOk.MouseEnter += new System.EventHandler(this.BtnOk_MouseEnter);
            this.btnOk.MouseLeave += new System.EventHandler(this.BtnOk_MouseLeave);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(116)))), ((int)(((byte)(60)))));
            this.btnApprove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.Color.Beige;
            this.btnApprove.Location = new System.Drawing.Point(135, 235);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(0);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(200, 40);
            this.btnApprove.TabIndex = 17;
            this.btnApprove.Text = "Onayla";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.BtnApprove_Click);
            this.btnApprove.MouseEnter += new System.EventHandler(this.BtnApprove_MouseEnter);
            this.btnApprove.MouseLeave += new System.EventHandler(this.BtnApprove_MouseLeave);
            // 
            // mtxtSecureCode
            // 
            this.mtxtSecureCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(45)))), ((int)(((byte)(65)))));
            this.mtxtSecureCode.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtSecureCode.ForeColor = System.Drawing.Color.Beige;
            this.mtxtSecureCode.Location = new System.Drawing.Point(135, 180);
            this.mtxtSecureCode.Margin = new System.Windows.Forms.Padding(0);
            this.mtxtSecureCode.Mask = "000 000";
            this.mtxtSecureCode.Name = "mtxtSecureCode";
            this.mtxtSecureCode.PromptChar = '-';
            this.mtxtSecureCode.Size = new System.Drawing.Size(200, 29);
            this.mtxtSecureCode.TabIndex = 16;
            this.mtxtSecureCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mtxtSecureCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MtxtSecureCode_KeyUp);
            this.mtxtSecureCode.Leave += new System.EventHandler(this.MtxtSecureCode_Leave);
            // 
            // lblSecureCode
            // 
            this.lblSecureCode.AutoSize = true;
            this.lblSecureCode.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSecureCode.ForeColor = System.Drawing.Color.Beige;
            this.lblSecureCode.Location = new System.Drawing.Point(115, 140);
            this.lblSecureCode.Margin = new System.Windows.Forms.Padding(0);
            this.lblSecureCode.Name = "lblSecureCode";
            this.lblSecureCode.Size = new System.Drawing.Size(238, 21);
            this.lblSecureCode.TabIndex = 15;
            this.lblSecureCode.Text = "SMS gönderildi. Kodu giriniz.\r\n";
            // 
            // picErrorLogo
            // 
            this.picErrorLogo.Image = global::FaultTrackingSystem.Properties.Resources.shield;
            this.picErrorLogo.Location = new System.Drawing.Point(185, 55);
            this.picErrorLogo.Margin = new System.Windows.Forms.Padding(0);
            this.picErrorLogo.Name = "picErrorLogo";
            this.picErrorLogo.Size = new System.Drawing.Size(100, 60);
            this.picErrorLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picErrorLogo.TabIndex = 14;
            this.picErrorLogo.TabStop = false;
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 280);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(470, 20);
            this.pnlBottom.TabIndex = 19;
            // 
            // errSecureCode
            // 
            this.errSecureCode.ContainerControl = this;
            this.errSecureCode.Icon = ((System.Drawing.Icon)(resources.GetObject("errSecureCode.Icon")));
            // 
            // tmrLoad
            // 
            this.tmrLoad.Interval = 10;
            this.tmrLoad.Tick += new System.EventHandler(this.TmrLoad_Tick);
            // 
            // SslSecurePaymentMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(59)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(470, 300);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.mtxtSecureCode);
            this.Controls.Add(this.lblSecureCode);
            this.Controls.Add(this.picErrorLogo);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SslSecurePaymentMessageBox";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SslSecurePaymentMessageBox";
            this.Load += new System.EventHandler(this.SslSecurePaymentMessageBox_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picErrorLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSecureCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.MaskedTextBox mtxtSecureCode;
        private System.Windows.Forms.Label lblSecureCode;
        private System.Windows.Forms.PictureBox picErrorLogo;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ErrorProvider errSecureCode;
        private System.Windows.Forms.Timer tmrLoad;
    }
}